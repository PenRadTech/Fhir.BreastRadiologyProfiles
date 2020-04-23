using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Eir.DevTools;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar TumorSatellite = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("TumorSatellite",
                            "Tumor Satellite",
                            "Tumor Satellite",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/TumorSatellite",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .Description("'Tumor Satellite' Observation",
                            new Markdown()
                                .Paragraph(
                                    "If a tumor observation's Observation.hasMember field contains a referrence ",
                                    "to a 'Tumor Satellite' observation, then it is a satellite tumor.",
                                    "The tumor that it is a satellite of is called the index tumor.")
                                .Paragraph(
                                    "The 'Tumor Satellite' observation may contain a reference to the index tumor observation.")
                                .Paragraph(
                                    "The 'Tumor Satellite' observation may contain a distance to the index tumor.")
                        )
                    ;
                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeTumorSatellite.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeTumorSatellite.ToCodeableConcept())
                    ;

                ElementTreeNode sliceElementDef = e.ConfigureSliceByUrlDiscriminator("derivedFrom", false);
                {
                    String baseName = sliceElementDef.ElementDefinition.Path.LastPathPart();
                    ElementTreeSlice treeSlice = e.SliceByUrlTarget(sliceElementDef, Global.ObservationUrl, 0, "1");
                    treeSlice.ElementDefinition
                        .SetShort($"Tumor Observation reference.")
                        .SetDefinition(
                            new Markdown()
                                .Paragraph($"This slice references the index tumor.")
                        )
                        ;
                }

                {
                    ValueSet units = Self.UnitsOfLengthVS.Value();
                    ElementTreeNode valueXNode = e.ApplySliceSelf("value[x]");
                    valueXNode.ElementDefinition
                        .ZeroToOne()
                        .Types("Quantity", "Range")
                        ;
                    {
                        Hl7.Fhir.Model.Quantity q = new Hl7.Fhir.Model.Quantity
                        {
                            System = units.Url
                        };

                        ElementDefinition valueX = new ElementDefinition
                                {
                                    Path = $"{valueXNode.ElementDefinition.Path}",
                                    ElementId = $"{valueXNode.ElementDefinition.ElementId}:valueQuantity",
                                    SliceName = $"valueQuantity",
                                    Min = 0,
                                    Max = "1"
                                }
                                .Pattern(q)
                                .Type("Quantity")
                            ;
                        valueXNode.CreateSlice($"valueQuantity", valueX);
                    }

                    {
                        Hl7.Fhir.Model.Range r = new Hl7.Fhir.Model.Range
                        {
                            Low = new SimpleQuantity
                            {
                                System = units.Url,
                            },
                            High = new SimpleQuantity
                            {
                                System = units.Url,
                            }
                        };
                        ElementDefinition valueX = new ElementDefinition
                                {
                                    Path = $"{valueXNode.ElementDefinition.Path}",
                                    ElementId = $"{valueXNode.ElementDefinition.ElementId}:valueRange",
                                    SliceName = $"valueRange",
                                    Min = 0,
                                    Max = "1"
                                }
                                .Pattern(r)
                                .Type("Range")
                            ;
                        valueXNode.CreateSlice($"valueRange", valueX);
                    }

                    e.IntroDoc
                        .ReviewedStatus("Needs review by KWA")
                        .ReviewedStatus("Needs review by Penrad")
                        .ReviewedStatus("Needs review by MRS")
                        .ReviewedStatus("Needs review by MagView")
                        .ReviewedStatus("Needs review by CIMI")
                        //+ IntroDocDescription
                            .Description("623",
                                "A group of tumor cells in an area near the primary ",
                                "(original) tumor. ",
                                "In melanoma, satellite tumors occur within 2 centimeters ",
                                "of the primary tumor, on ",
                                "or under the skin, and can be seen without a microscope. ",
                                "Satellite tumors may also be found in other types ",
                                "of cancer, including cancers of ",
                                "the breast, lung, liver, and brain. ",
                                "Having a satellite tumor is a sign that the cancer ",
                                "has spread from where it first ",
                                "formed. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/satellite-tumor")
                        //- IntroDocDescription
                        ;
                }
            });
    }
}
