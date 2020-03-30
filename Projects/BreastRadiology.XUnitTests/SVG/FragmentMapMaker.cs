using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Create graphic for each resourece showing fragment parents and children..
    /// </summary>
    class FragmentMapMaker
    {
        class FragmentNode
        {
            public ResourceMap.Node Focus;
            public List<ResourceMap.Node> Parents = new List<ResourceMap.Node>();
            public List<ResourceMap.Node> Children = new List<ResourceMap.Node>();
        }

        List<ResourceMap.Node> selectedNodes = new List<ResourceMap.Node>();
        Dictionary<String, FragmentNode> fragmentNodes = new Dictionary<string, FragmentNode>();
        String graphicsDir;

        ResourceMap map;
        FileCleaner fc;
        String pageTemplateDir;

        public FragmentMapMaker(FileCleaner fc,
            ResourceMap map,
            String graphicsDir,
            String pageTemplateDir)
        {
            this.fc = fc;
            this.map = map;
            this.graphicsDir = graphicsDir;
            this.pageTemplateDir = pageTemplateDir;
        }

        public static String FragmentMapName(String name) => $"Frag-{name}.svg";
        public static String FragmentMapName(ResourceMap.Node mapNode) => $"Frag-{mapNode.Name}.svg";

        IEnumerable<dynamic> FragmentLinks(ResourceMap.Node n)
        {
            foreach (dynamic link in n.Links)
            {
                switch (link.LinkType.ToObject<String>())
                {
                    case "fragment":
                        yield return link;
                        break;
                }
            }
        }

        void LinkNodes()
        {
            foreach (ResourceMap.Node focusMapNode in this.selectedNodes)
            {
                if (this.fragmentNodes.TryGetValue(focusMapNode.Name, out FragmentNode fragmentFocusNode) == false)
                    throw new Exception($"Internal error. Cant find Focus FragmentNode '{focusMapNode.Name}' ");

                foreach (dynamic link in this.FragmentLinks(focusMapNode))
                {
                    ResourceMap.Node referencedMapNode = this.map.GetNode(link.LinkTarget.ToObject<String>());
                    fragmentFocusNode.Parents.Add(referencedMapNode);

                    if (this.fragmentNodes.TryGetValue(referencedMapNode.Name, out FragmentNode fragmentParentNode) ==
                        false)
                        throw new Exception($"Internal error. Cant find FragmentNode '{referencedMapNode.Name}' ");
                    fragmentParentNode.Children.Add(focusMapNode);
                }
            }
        }

        SENode CreateNode(ResourceMap.Node mapNode, Color color, bool linkFlag)
        {
            if (this.map.TryGetNode(mapNode.ResourceUrl, out var dummy) == false)
                throw new Exception($"Referenced node {mapNode.ResourceUrl} not found in map");

            String hRef = null;
            if (linkFlag)
            {
                String fragMapName = $"{mapNode.StructureName}-{mapNode.Name}.html";
                hRef = $"./{fragMapName}";
            }

            SENode node = new SENode(0, color, null, hRef);
            foreach (String titlePart in mapNode.MapName)
            {
                String s = titlePart.Trim();
                node.AddTextLine(s, hRef);
            }

            return node;
        }

        void GraphNode(FragmentNode fragmentNode)
        {
            SvgEditor e = new SvgEditor();
            SENodeGroup parentsGroup = new SENodeGroup("parents", false);
            SENodeGroup focusGroup = new SENodeGroup("focus", false);
            SENodeGroup childrenGroup = new SENodeGroup("children", false);
            parentsGroup.AppendChild(focusGroup);
            focusGroup.AppendChild(childrenGroup);

            {
                SENode node = this.CreateNode(fragmentNode.Focus, Color.Green, false);
                focusGroup.AppendNode(node);
            }

            foreach (ResourceMap.Node childNode in fragmentNode.Children)
            {
                SENode node = this.CreateNode(childNode, Color.LightBlue, true);
                childrenGroup.AppendNode(node);
            }

            foreach (ResourceMap.Node parentNode in fragmentNode.Parents)
            {
                SENode node = this.CreateNode(parentNode, Color.LightCyan, true);
                parentsGroup.AppendNode(node);
            }

            e.Render(parentsGroup, true);
            String svgName = FragmentMapName(fragmentNode.Focus);
            String outputSvgPath = Path.Combine(this.graphicsDir, svgName);
            this.fc?.Mark(outputSvgPath);
            e.Save(outputSvgPath);

            this.fragmentsBlock
                .AppendLine($"<p>")
                .AppendLine($"Fragment Diagram {fragmentNode.Focus.Name}")
                .AppendLine($"</p>")
                .AppendLine($"<object data=\"{svgName}\" type=\"image/svg+xml\">")
                .AppendLine($"    <img src=\"{svgName}\" alt=\"{fragmentNode.Focus.Name}\"/>")
                .AppendLine($"</object>");
            ;
        }

        void GraphNodes()
        {
            foreach (FragmentNode fragmentNode in this.fragmentNodes.Values)
                this.GraphNode(fragmentNode);
        }

        /// <summary>
        /// Select nodes we are going to process.
        /// </summary>
        void SelectNodes()
        {
            foreach (ResourceMap.Node mapNode in this.map.Nodes)
            {
                switch (mapNode.StructureName)
                {
                    case "StructureDefinition":
                        this.selectedNodes.Add(mapNode);
                        break;
                }
            }
        }

        void CreateNodes()
        {
            foreach (ResourceMap.Node mapNode in this.selectedNodes)
            {
                FragmentNode fNode = new FragmentNode
                {
                    Focus = mapNode
                };
                this.fragmentNodes.Add(mapNode.Name, fNode);
            }
        }

        CodeEditor fragmentsEditor;
        CodeBlockNested fragmentsBlock;

        public void Create(bool saveTotalMap)
        {
            this.fragmentsEditor = new CodeEditorXml();
            this.fragmentsEditor.IgnoreMacrosInQuotedStrings = false;
            this.fragmentsEditor.Load(Path.Combine(this.pageTemplateDir, "fragments.xml"));
            this.fragmentsBlock = this.fragmentsEditor.Blocks.Find("Block");
            this.fragmentsBlock.Clear();

            this.SelectNodes();
            this.CreateNodes();
            this.LinkNodes();
            this.GraphNodes();

            if (saveTotalMap == true)
                this.fragmentsEditor.Save();
        }
    }
}