using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Grapher
{
    class MapMaker
    {
        protected ResourceMap map;
        protected bool showCardinality = true;

        protected Color focusColor = Color.White;
        protected Color fhirColor = Color.LightGray;

        protected Color extensionColor = Color.LightSalmon;
        protected Color valueSetColor = Color.LightGreen;
        protected Color targetColor = Color.LightCyan;
        protected Color componentColor = Color.LightYellow;
        protected Color extensionReferenceColor = Color.LightBlue;

        protected String[] SplitTitle(String title, Int32 lineLength)
        {
            List<String> retVal = new List<string>();
            String[] stringBits = title.Split(' ');
            Int32 i = 0;
            StringBuilder sb = new StringBuilder();

            void AddToLine(String s)
            {
                if (sb.Length > 0)
                    sb.Append(" ");
                sb.Append(s);
                i += 1;
            }

            void BreakLine()
            {
                retVal.Add(sb.ToString());
                sb.Clear();
            }

            while (i < stringBits.Length)
            {
                String nextWord = stringBits[i];
                Int32 nextLen = sb.Length + nextWord.Length + 1;
                if (nextLen < lineLength)
                {
                    AddToLine(nextWord);
                }
                else if (nextLen - lineLength < lineLength - sb.Length)
                {
                    AddToLine(nextWord);
                    BreakLine();
                    i += 1;
                } else
                {
                    BreakLine();
                }
            }

            if (sb.Length > 0)
                BreakLine();
            return retVal.ToArray();
        }

        protected SENode CreateResourceNode(ResourceMap.Node mapNode,
            String[] text,
            Color color,
            String[] annotations,
            bool linkFlag = true)
        {
            String hRef = null;
            if (linkFlag)
                hRef = this.HRef(mapNode);
            SENode node = new SENode(0, color, annotations, hRef);
            foreach (String t in text)
                node.AddTextLine(t, hRef);


            return node;
        }

        public bool AlwaysShowChildren = false;

        public MapMaker(ResourceMap map)
        {
            this.map = map;
        }

        protected String HRef(ResourceMap.Node mapNode)
        {
            if (mapNode.ResourceUrl.StartsWith("http://hl7.org/fhir/StructureDefinition/"))
                return mapNode.ResourceUrl;
            return $"./{mapNode.StructureName}-{mapNode.Name}.html";
        }

        protected Color ReferenceColor(ResourceMap.Node refNode)
        {
            switch (refNode.StructureName)
            {
                case "StructureDefinition": return this.targetColor;
                case "ValueSet": return this.valueSetColor;
                case "Extension": return this.extensionReferenceColor;
                default: throw new NotImplementedException();
            }
        }
    }
}