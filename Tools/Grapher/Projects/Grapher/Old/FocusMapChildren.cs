using Eir.DevTools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Grapher
{
    class FocusMapChildren
    {
        private FocusMapMaker mapMaker;
        private SENodeGroup group;

        public FocusMapChildren(FocusMapMaker mapMaker,
            SENodeGroup group)
        {
            this.mapMaker = mapMaker;
            this.group = group;
        }

        public void AddChildren(IEnumerable<String> children)
        {
            foreach (String childUrl in children)
            {
                if (this.mapMaker.Map.TryGetNode(childUrl, out var childNode) == false)
                    throw new Exception($"Error finding mapped node {childUrl}");
                SENode node = this.mapMaker.CreateResourceNode(childNode,
                    this.mapMaker.SplitTitle(childNode.Title, FocusMapMaker.TextLen),
                    Color.LightCyan,
                    null,
                    true);
                this.group.AppendNode(node);
            }
        }
    }
}
