using FhirKhit.Tools;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Navigation;

namespace Grapher
{
    /// <summary>
    /// Create graphic for each resourece showing fragment parents and children..
    /// </summary>
    class FocusMapMaker : MapMaker
    {
        String pageContentDir;
        String graphicsDir;

        public FocusMapMaker(ResourceMap map,
            String graphicsDir,
            String pageContentDir) : base(map)
        {
            this.map = map;
            this.pageContentDir = pageContentDir;
            this.graphicsDir = graphicsDir;
        }

        public static String FocusMapName(ResourceMap.Node mapNode) => $"Focus-{mapNode.Name}.svg";
        public static String FocusMapName(String name) => $"Focus-{name}.svg";
        String IntroName(ResourceMap.Node mapNode) => $"{mapNode.StructureName}-{mapNode.Name}-intro.xml";

        void CreateIntroDoc(ResourceMap.Node focusNode)
        {
            if (this.map.TryGetResource(focusNode.ResourceUrl, out DomainResource r) == false)
                throw new Exception($"Cant find mapped item {focusNode.ResourceUrl}");
            StructureDefinition focusSDef = (StructureDefinition)r;

            String introDocPath = Path.Combine(
                this.pageContentDir,
                $"StructureDefinition-{focusNode.ResourceUrl.LastUriPart()}-intro.xml");
            CodeEditor introEditor = new CodeEditor();
            introEditor.IgnoreMacrosInQuotedStrings = false;
            introEditor.AddUserMacro("FocusPath", FocusMapName(focusNode));
            introEditor.TryAddUserMacro("Title", focusSDef.Title);
            introEditor.Load("introDoc.template");
            introEditor.Save(introDocPath);
        }

        String ResourceAnchor(DomainResource r)
        {
            String resourceName = r.GetUrl().LastUriPart();
            return $"{r.TypeName}-{resourceName}.html";
        }

        String ElementAnchor(DomainResource r, ElementDefinition e)
        {
            String resourceName = r.GetUrl().LastUriPart();
            return $"{r.TypeName}-{resourceName}-definitions.html#{e.ElementId}";
        }

        bool GraphNode(ResourceMap.Node focusNode)
        {
            SvgEditor e = new SvgEditor();
            SENodeGroup parentsGroup = new SENodeGroup("parents", true);
            SENodeGroup focusGroup = new SENodeGroup("focus", true);
            SENodeGroup childrenGroup = new SENodeGroup("children", true);
            parentsGroup.AppendChild(focusGroup);
            focusGroup.AppendChild(childrenGroup);

            if (this.map.TryGetResource(focusNode.ResourceUrl, out DomainResource r) == false)
                throw new Exception($"Cant find mapped item {focusNode.ResourceUrl}");
            StructureDefinition focusSDef = r as StructureDefinition;
            if (focusSDef == null)
                return false;

            {
                String parentUrl = focusSDef.BaseDefinition;
                if (parentUrl.StartsWith("http://hl7.org/fhir/us/core/StructureDefinition"))
                {
                    //var parentNode = this.CreateResourceNode(parentMapNode, Color.LightCyan, null, true);
                    //parentsGroup.AppendNode(parentNode);
                }
                else
                {
                    if (this.map.TryGetNode(parentUrl, out ResourceMap.Node parentMapNode) == false)
                        throw new Exception($"Cant find mapped item {parentUrl}");
                    StructureDefinition parentSDef = (StructureDefinition)r;
                    var parentNode = this.CreateResourceNode(parentMapNode, Color.LightCyan, null, true);
                    parentsGroup.AppendNode(parentNode);
                }
            }
            {
                SENode node = this.CreateResourceNode(focusNode, Color.White, null, false);
                focusGroup.AppendNode(node);
            }

            void AddChildren(IEnumerable<String> children)
            {
                foreach (String childUrl in children)
                {
                    if (this.map.TryGetNode(childUrl, out var childNode) == false)
                        throw new Exception($"Error finding mapped node {childUrl}");
                    SENode node = this.CreateResourceNode(childNode, Color.LightCyan, null, true);
                    childrenGroup.AppendNode(node);
                }
            }

            void AddDiffChildren()
            {
                foreach (ElementDefinition diff in focusSDef.Differential.Element)
                {
                    String hRef = this.ElementAnchor(focusSDef, diff);

                    SENode node = new SENode(0, Color.Cornsilk, null, hRef);
                    SENodeGroup childGroup = new SENodeGroup("child", true);
                    childGroup.AppendNode(node);
                    childrenGroup.AppendChild(childGroup);

                    node.AddTextLine(diff.Path.LastPathPart(), hRef);
                    if (diff.Binding != null)
                    {
                        String vsUrl = diff.Binding.ValueSet;
                        if (this.map.TryGetResource(vsUrl, out var resource))
                        {
                            String hRefVs = this.ResourceAnchor(resource);
                            SENodeGroup vsGroup = new SENodeGroup("vs", true);
                            childGroup.AppendChild(vsGroup);
                            SENode vsNode = new SENode(0, Color.LightGreen, null, hRefVs);
                            vsNode.AddTextLine(vsUrl.LastUriPart(), hRefVs);
                            vsGroup.AppendNode(vsNode);
                        }
                    }

                    void AddIfNotNull(String value)
                    {
                        if (value != null)
                            node.AddTextLine(value, hRef);
                    }

                    if (diff.Pattern != null)
                    {
                        Element p = diff.Pattern;
                        switch (p)
                        {
                            case CodeableConcept codeableConcept:
                                AddIfNotNull(codeableConcept.Coding[0].Code);
                                AddIfNotNull(codeableConcept.Coding[0].System);
                                break;

                            case Quantity quantity:
                                AddIfNotNull(quantity.Code);
                                AddIfNotNull(quantity.System);
                                break;
                            
                            default:
                                break;
                        }
                    }
                }
            }

            IEnumerable<String> children = this.map.Children(focusNode.ResourceUrl);
            if (children.Any())
                AddChildren(children);
            else
                AddDiffChildren();

            e.Render(parentsGroup, true);
            String outputPath = Path.Combine(this.graphicsDir, FocusMapName(focusNode));
            e.Save(outputPath);
            return true;
        }

        public void Create()
        {
            foreach (ResourceMap.Node focusNode in this.map.Nodes)
            {
                if (this.GraphNode(focusNode) == true)
                    this.CreateIntroDoc(focusNode);
            }
        }
    }
}