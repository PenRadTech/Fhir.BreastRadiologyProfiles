using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace Grapher
{
    internal class HierarchyMapMaker : MapMaker
    {
        private const Int32 TextLen = 32;

        public HierarchyMapMaker(ResourceMap map) : base(map)
        {
        }

        public void CreateGraph(String baseName,
            String outputPath)
        {
            SvgEditor e = new SvgEditor();
            SENodeGroup baseGroup = new SENodeGroup("base", true);

            GraphNode(e, baseGroup, baseName);
            e.Render(baseGroup, true);
            e.Save(outputPath);
        }

        void GraphNode(SvgEditor e,
            SENodeGroup group, 
            String baseName)
        {
            if (this.Map.TryGetNode(baseName, out ResourceMap.Node focusNode) == false)
                throw new Exception($"Node {baseName} not found");


            SENode node = this.CreateResourceNode(focusNode, 
                this.SplitTitle(focusNode.Title, TextLen),
                Color.LightCyan, 
                null);
            group.AppendNode(node);

            foreach (String childUrl in this.Map.Children(baseName))
            {
                SENodeGroup childrenGroup = new SENodeGroup("children", true);
                group.AppendChild(childrenGroup);
                GraphNode(e, childrenGroup, childUrl);
            }
            group.Sort();
        }
    }
}
