using Eir.DevTools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Grapher
{
    public class FocusMapDiffNode
    {
        private FocusMapMaker mapMaker;
        private SENodeGroup childrenGroup;
        private StructureDefinition focusSDef;
        private SENode node;
        private String hRef;

        public FocusMapDiffNode(FocusMapMaker mapMaker,
            SENodeGroup childrenGroup)
        {
            this.mapMaker = mapMaker;
            this.childrenGroup = childrenGroup;
        }

        bool ShouldShow(ElementDefinition diff)
        {
            String type = diff.Path.LastPathPart();
            if (type.EndsWith("value[x]"))
                return false;

            return true;
        }

        void AddIfNotNull(String value)
        {
            if (value != null)
                node.AddTextLine(value, hRef);
        }

        public void AddDiffChildren(StructureDefinition focusSDef)
        {
            //ElementTreeLoader loader = new ElementTreeLoader();
            //ElementTreeNode diffTreeNodes = loader.Create(focusSDef.Differential.Element);

            foreach (ElementDefinition diff in focusSDef.Differential.Element)
            {
                hRef = FocusMapMaker.ElementAnchor(focusSDef, diff);

                node = new SENode(0, Color.Cornsilk, null, hRef);
                SENodeGroup childGroup = new SENodeGroup("child", true);
                childGroup.AppendNode(node);
                childrenGroup.AppendChild(childGroup);

                String type = diff.Path.LastPathPart();
                if (type.StartsWith("value"))
                    type = $"Value[{type.Substring(5)}]";
                else
                    type = type.ToMachineName();

                //Debug.Assert(type != "HasMember");
                node.AddTextLine(type, hRef);
                if (diff.Binding != null)
                {
                    node.OutgoingAnnotation = "bind";
                    String vsUrl = diff.Binding.ValueSet;
                    if (this.mapMaker.Map.TryGetResource(vsUrl, out var resource))
                    {
                        String hRefVs = FocusMapMaker.ResourceAnchor(resource);
                        SENodeGroup vsGroup = new SENodeGroup("vs", true);
                        childGroup.AppendChild(vsGroup);
                        SENode vsNode = new SENode(0, Color.LightGreen, null, hRefVs);
                        String vsName = vsUrl.LastUriPart();
                        if (this.mapMaker.Map.TryGetResource(vsUrl, out DomainResource vsResource) == true)
                        {
                            ValueSet vs = (ValueSet)vsResource;
                            vsName = vs.Name;
                        }

                        vsNode.AddTextLine(vsName, hRefVs);
                        vsGroup.AppendNode(vsNode);
                    }
                }

                if (diff.Pattern != null)
                {
                    Element p = diff.Pattern;
                    switch (p)
                    {
                        case CodeableConcept codeableConcept:
                            //if (diff.Path == "Observation.code")
                            //    ProcessLoincCode(diff, codeableConcept);
                            AddIfNotNull(codeableConcept.Coding[0].Code);
                            AddIfNotNull(codeableConcept.Coding[0].System);
                            if (
                                (codeableConcept.Coding[0].System == FocusMapMaker.LoincBase) ||
                                (codeableConcept.Coding[0].System == FocusMapMaker.Loinc2Base)
                            )
                            {
                                node.OutgoingAnnotation = "bind";
                                String hRefVs = FocusMapMaker.LoincCodeLink(codeableConcept.Coding[0].Code);
                                SENodeGroup vsGroup = new SENodeGroup("vs", true);
                                childGroup.AppendChild(vsGroup);
                                SENode vsNode = new SENode(0, Color.LightGreen, null, hRefVs);
                                vsNode.AddTextLine(codeableConcept.Coding[0].Code, hRefVs);
                                vsNode.AddTextLine(codeableConcept.Coding[0].System, hRefVs);
                                vsGroup.AppendNode(vsNode);
                            }

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
    }
}
