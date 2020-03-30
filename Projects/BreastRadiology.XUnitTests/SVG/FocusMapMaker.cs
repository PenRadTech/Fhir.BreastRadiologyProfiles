using FhirKhit.Tools;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Create graphic for each resourece showing fragment parents and children..
    /// </summary>
    class FocusMapMaker : MapMaker
    {
        String graphicsDir;
        String contentDir;
        FileCleaner fc;

        public FocusMapMaker(FileCleaner fc,
            ResourceMap map,
            String graphicsDir,
            String contentDir) : base(map)
        {
            this.fc = fc;
            this.map = map;
            this.graphicsDir = graphicsDir;
            this.contentDir = contentDir;
        }

        public static String FocusMapName(ResourceMap.Node mapNode) => $"Focus-{mapNode.Name}.svg";
        public static String FocusMapName(String name) => $"Focus-{name}.svg";
        String IntroName(ResourceMap.Node mapNode) => $"{mapNode.StructureName}-{mapNode.Name}-intro.xml";

        void GraphNode(ResourceMap.Node focusNode)
        {
            if (focusNode.Name.Contains("Fragment", new StringComparison()) == true)
                return;
            //Debug.Assert(focusNode.Name != "SectionFindingsLeftBreast");

            SvgEditor e = new SvgEditor();
            SENodeGroup parentsGroup = new SENodeGroup("parents", true);
            SENodeGroup focusGroup = new SENodeGroup("focus", true);
            SENodeGroup childrenGroup = new SENodeGroup("children", true);
            parentsGroup.AppendChild(focusGroup);
            focusGroup.AppendChild(childrenGroup);
            {
                SENode node = this.CreateResourceNode(focusNode, Color.White, null, false);
                focusGroup.AppendNode(node);
            }
            {
                HashSet<String> alreadyLinkedResources = new HashSet<string>();

                void AddParent(dynamic link,
                    List<SENode> parents)
                {
                    String linkSource = link.LinkSource.ToObject<String>();
                    if (this.map.TryGetNode(linkSource, out ResourceMap.Node parentNode) == false)
                        throw new Exception($"Parent extension {linkSource} not found in map");
                    if (alreadyLinkedResources.Contains(parentNode.ResourceUrl) == true)
                        return;

                    if (this.map.TryGetNode(parentNode.ResourceUrl, out ResourceMap.Node parentMapNode) == false)
                        throw new Exception($"Resource '{parentNode.ResourceUrl}' not found!");

                    alreadyLinkedResources.Add(parentNode.ResourceUrl);
                    SENode node = this.CreateResourceNode(parentNode, this.ReferenceColor(parentMapNode),
                        new String[] {null, link.CardinalityLeft?.ToString()},
                        true);
                    parents.Add(node);
                }

                List<SENode> componentParents = new List<SENode>();
                List<SENode> extensionParents = new List<SENode>();
                List<SENode> valueSetParents = new List<SENode>();
                List<SENode> targetParents = new List<SENode>();

                foreach (dynamic link in this.map.TargetOrReferenceLinks(focusNode.ResourceUrl))
                {
                    switch (link.LinkType.ToObject<String>())
                    {
                        case "fragment":
                            break;

                        default:
                            AddParent(link, componentParents);
                            break;
                    }
                }

                parentsGroup.AppendNodes(targetParents);
                parentsGroup.AppendNodes(componentParents);
                parentsGroup.AppendNodes(valueSetParents);
                parentsGroup.AppendNodes(extensionParents);
            }
            {
                SENodeGroup targetChildren = new SENodeGroup("A.Targets", true);
                SENodeGroup componentChildren = new SENodeGroup("B.Components", true);
                SENodeGroup extensionChildren = new SENodeGroup("C.Extensions", true);
                SENodeGroup valueSetChildren = new SENodeGroup("D.ValueSets", true);

                childrenGroup.AppendChild(targetChildren);
                childrenGroup.AppendChild(componentChildren);
                childrenGroup.AppendChild(valueSetChildren);
                childrenGroup.AppendChild(extensionChildren);

                foreach (dynamic link in this.map.SourceLinks(focusNode.ResourceUrl))
                {
                    switch (link.LinkType.ToObject<String>())
                    {
                        case "fragment":
                            break;

                        case SVGGlobal.ComponentType:
                            MakeComponent(link, componentChildren);
                            break;

                        case SVGGlobal.ExtensionType:
                        {
                            String linkSource = link.LinkSource.ToObject<String>();
                            String componentHRef = link.ComponentHRef.ToObject<String>()
                                .Replace("{SDName}", linkSource.LastUriPart());

                            SENode node = new SENode(0,
                                LinkTypeColor(link),
                                new String[] {link.CardinalityLeft?.ToString()},
                                componentHRef);
                            node.AddTextLine(link.LocalName.ToObject<String>(), componentHRef);
                            node.AddTextLine("extension", componentHRef);

                            SENodeGroup nodeGroup = new SENodeGroup(node.AllText(), true);
                            extensionChildren.AppendChild(nodeGroup);
                            nodeGroup.AppendNode(node);

                            {
                                SENodeGroup extGroup = new SENodeGroup("extension", true);
                                nodeGroup.AppendChild(extGroup);
                                SENode extNode;
                                String extUrl = link.LinkTarget.ToObject<String>().Trim();
                                if (extUrl.ToLower().StartsWith(Global.BreastRadBaseUrl))
                                {
                                    if (this.map.TryGetNode(extUrl, out ResourceMap.Node targetNode) == false)
                                        throw new Exception($"Component resource '{extUrl}' not found!");
                                    extNode = this.CreateResourceNode(targetNode, this.ReferenceColor(targetNode),
                                        new String[] {link.CardinalityLeft?.ToString()},
                                        true);
                                }
                                else
                                {
                                    String name = extUrl.LastUriPart()
                                            .TrimStart("StructureDefinition-")
                                            .TrimStart("ValueSet-")
                                            .TrimEnd(".html")
                                        ;
                                    extNode = new SENode(0,
                                        this.fhirColor,
                                        new String[] {link.CardinalityLeft?.ToString()},
                                        extUrl);
                                    extNode.AddTextLine(name, extUrl);
                                }

                                extGroup.AppendNode(extNode);
                            }
                        }
                            break;

                        case SVGGlobal.ValueSetType:
                        {
                            if (this.map.TryGetNode(link.LinkTarget.ToObject<String>().ToObject<String>(),
                                    out ResourceMap.Node childNode) == true)
                            {
                                SENode node = this.CreateResourceNode(childNode, link, true);
                                SENodeGroup nodeGroup = new SENodeGroup(node.AllText(), false);
                                valueSetChildren.AppendChild(nodeGroup);
                                nodeGroup.AppendNode(node);
                            }
                        }
                            break;

                        case SVGGlobal.TargetType:
                        {
                            if (this.map.TryGetNode(link.LinkTarget.ToObject<String>(),
                                    out ResourceMap.Node childNode) == false)
                                throw new Exception(
                                    $"Child target {link.LinkTarget.ToObject<String>()} not found in map");
                            SENode node = this.CreateResourceNode(childNode, link, true);
                            SENodeGroup nodeGroup = new SENodeGroup(node.AllText(), true);
                            targetChildren.AppendChild(nodeGroup);
                            nodeGroup.AppendNode(node);
                        }
                            break;

                        default:
                            throw new NotImplementedException($"Unknown link type {link.LinkType.ToObject<String>()}");
                    }
                }
            }

            //parentsGroup.Sort();
            e.Render(parentsGroup, true);
            String outputPath = Path.Combine(this.graphicsDir, FocusMapName(focusNode));
            this.fc?.Mark(outputPath);
            e.Save(outputPath);
        }


        public void Create()
        {
            foreach (ResourceMap.Node focusNode in this.map.Nodes)
                this.GraphNode(focusNode);
        }
    }
}