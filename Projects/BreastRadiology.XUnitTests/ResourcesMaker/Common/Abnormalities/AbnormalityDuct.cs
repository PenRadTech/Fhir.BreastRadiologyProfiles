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
    partial class ResourcesMaker : ConverterBase
    {
        CSTaskVar AbnormalityDuctCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "AbnormalityDuctTypeCS",
                    "Duct Type CodeSystem",
                    "Duct Type/CodeSystem",
                    "Duct abnormality types code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Type
                        #region Codes
                        new ConceptDef()
                            .SetCode("DuctNormal")
                            .SetDisplay("Duct normal")
                            .MammoId("692")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("692",
                                "Duct is considered normal. ",
                                "It is surrounded by normal cells and collagen in ",
                                "the breast with no abnormalities. ",
                                "A system of ducts in the breast carries milk to the ",
                                "nipples.")
                        ,
                        new ConceptDef()
                            .SetCode("SolitaryDilatedDuct")
                            .SetDisplay("Solitary dilated duct")
                            .MammoId("694.602")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("694.602",
                                "When it is malignant, solitary dilated duct appears ",
                                "to indicate the presence of DCIS. ",
                                "In almost all solitary dilated duct cases, the dilated ",
                                "duct appears to be filled with some debris, with ",
                                "or without accompanying fluid, as seen at ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("DuctEctasia")
                            .SetDisplay("Duct ectasia")
                            .MammoId("693.614")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("693.614",
                                "ClinicalFinding | 22049009 | Mammary duct ectasia ",
                                "(Disorder) | [0/0] | N60.49")
                            .SetUMLS("693.614",
                                "A noncancerous condition that results in clogged ",
                                "ducts around the nipple. ",
                                "While it sometimes causes pain, irritation and discharge, ",
                                "it's generally not a cause ",
                                "for concern. ",
                                "If left untreated, it can eventually obliterate the ",
                                "breast duct. ",
                                "www.healthline.com > health > duct-ectasia-of-the-breast")
                        #endregion // Codes
                        //- Type
                    }
                )
        );


        VSTaskVar AbnormalityDuctVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "AbnormalityDuctTypeVS",
                    "Duct ValueSet",
                    "Duct/ValueSet",
                    "Duct node abnormality types value set.",
                    Group_CommonCodesVS,
                    Self.AbnormalityDuctCS.Value()
                )
        );


        SDTaskVar AbnormalityDuct = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.AbnormalityDuctVS.Value();
                SDefEditor e = Self.CreateEditor("AbnormalityDuct",
                            "Duct",
                            "Duct",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/AbnormalityDuct",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentShapeFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedCountFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedDistributionFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedSizeFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberConsistentWithFragment.Value())
                        .Description("Duct Abnormality Observation",
                            new Markdown()
                                .Paragraph("This resource and referenced child resources contain ",
                                    "information about a duct abnormality observation ")
                        )
                    ;

                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeAbnormalityDuct.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeAbnormalityDuct.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    .MissingDescription()
                    ;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("ductType",
                    Self.ComponentSliceCodeAbnormalityDuctType.ToCodeableConcept(),
                    binding,
                    BindingStrength.Required,
                    0,
                    "1",
                    "Duct Type",
                    "refine the duct type");
            });
    }
}
