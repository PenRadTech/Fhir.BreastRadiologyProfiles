using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Linq;
using Eir.DevTools;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        CSTaskVar MGAbnormalityDensityTypeCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "MGAbnormalityDensityTypeCS",
                    "Mammography Density Type CodeSystem",
                    "MG Density Type/CodeSystem",
                    "Mammography density abnormality refinement types code system.",
                    Group_MGCodesCS,
                    new ConceptDef[]
                    {
                        //+ Type
                        #region Codes
                        new ConceptDef()
                            .SetCode("Density")
                            .SetDisplay("Density")
                            .MammoId("686")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("686",
                                "The density types are referring to the amount of ",
                                " glandular tissue and fibrous connective tissue versus ",
                                "levels of fatty tissue.")
                        ,
                        new ConceptDef()
                            .SetCode("DensityFocalAsymmetry")
                            .SetDisplay("Density focal asymmetry")
                            .MammoId("645")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("645",
                                "The density is focal asymmetry on two mammographic ",
                                "views.")
                        ,
                        new ConceptDef()
                            .SetCode("DensityNodular")
                            .SetDisplay("Density nodular")
                            .MammoId("646")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("646",
                                "not found like tubular shaped")
                            .SetUMLS("646",
                                "The nodule found on Mammogram is dense.")
                        ,
                        new ConceptDef()
                            .SetCode("DensityTubular")
                            .SetDisplay("Density tubular")
                            .MammoId("647")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("647",
                                "ClinicalFinding | 129794007 | Tubular shaped density ",
                                "of breast (Finding)")
                            .SetUMLS("647",
                                "The milk ducts have formed a tubular appearing dense ",
                                "structure.")
                        #endregion // Codes
                        //- Type
                    }
                )
        );


        VSTaskVar MGAbnormalityDensityTypeVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "MGAbnormalityDensityTypeVS",
                    "Mammography Density Type ValueSet",
                    "MG Density Type/ValueSet",
                    "Mammography density abnormality refinement value set.",
                    Group_MGCodesVS,
                    Self.MGAbnormalityDensityTypeCS.Value()
                )
        );


        SDTaskVar MGAbnormalityDensity = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.MGAbnormalityDensityTypeVS.Value();

                SDefEditor e = Self.CreateEditor("MGAbnormalityDensity",
                            "Mammography Density",
                            "MG Density",
                            Global.ObservationUrl,
                            $"{Group_MGResources}/AbnormalityDensity",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentShapeFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedCountFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedSizeFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedDistributionFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberConsistentWithFragment.Value())
                        .Description("Mammography Density Abnormality Observation",
                            new Markdown()
                        )
                    ;

                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeMGAbnormalityDensity.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeMGAbnormalityDensity.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    //+ IntroDocDescription
                        .Description("686",
                            "The density types are referring to the amount of ",
                            " glandular tissue and fibrous connective tissue versus ",
                            "levels of fatty tissue.")
                    //- IntroDocDescription
                    ;

                e.Select("value[x]").Zero();

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("densityType",
                    Self.MGComponentSliceCodeAbnormalityDensityType.ToCodeableConcept(),
                    binding,
                    BindingStrength.Required,
                    1,
                    "1",
                    "Density Type",
                    "refine the density type");
            });
    }
}
