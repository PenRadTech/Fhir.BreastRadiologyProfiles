using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        CSTaskVar CSMassType = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "MassTypeCS",
                    "Mass Type CodeSystem",
                    "Mass/Type/CodeSystem",
                    "Codes defining mass refinements.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Type
                        #region Codes
                        new ConceptDef()
                            .SetCode("Mass")
                            .SetDisplay("Mass")
                            .MammoId("58")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("58",
                                "A breast mass has been identified in the breast. ",
                                "This is also known as a breast lump. ",
                                " It feels different from the surrounding tissue. ",
                                "Breast pain, nipple discharge, or skin changes may ",
                                "be present.")
                        ,
                        new ConceptDef()
                            .SetCode("MassIntraductal")
                            .SetDisplay("Mass intraductal")
                            .MammoId("621")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("621",
                                "ClinicalFinding | 369753003 | Intraductal tumor configuration ",
                                "(Finding)")
                            .SetUMLS("621",
                                "An intraductal mass has been identified in the breast. ",
                                "It is a lump that originates in one or more of the ",
                                "milk ducts in the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("MassPartiallySolid")
                            .SetDisplay("Mass partially solid")
                            .MammoId("697")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("697",
                                "A mass that is partially solid has been identified ",
                                "in the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("MassSkinATLASIsSkinLesion")
                            .SetDisplay("Mass skin ATLAS is skin lesion")
                            .MammoId("613")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedCode("613",
                                "126510002")
                            .SetSnomedDescription("613",
                                "ClinicalFinding | Neoplasm of skin of breast (Disorder)")
                            .SetUMLS("613",
                                "The mammogram and/or ultrasound show a skin lesion. ",
                                "This finding may be described in the mammography ",
                                "report or annotated on the mammographic image when ",
                                "it projects over the breast (especially on two different ",
                                "projections) and may be mistaken for an intramammary ",
                                "lesion.###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("MassSolid")
                            .SetDisplay("Mass solid")
                            .MammoId("608")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("608",
                                "The mammogram and/or ultrasound show solid mass of ",
                                "the breast. ",
                                "This can be nodules, fibrocystic tissue, phylloides ",
                                "tumor, breast cancer or metastatic. ",
                                "A biopsy confirmation may be required.")
                        #endregion // Codes
                        //- Type
                    })
        );


        VSTaskVar MassTypeValueSetVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "MassTypeValueSetVS",
                    "Mass Type ValueSet",
                    "Mass Type/ValueSet",
                    "Mass type value set.",
                    Group_CommonCodesVS,
                    Self.CSMassType.Value()
                )
        );

        SDTaskVar AbnormalityMass = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.MassTypeValueSetVS.Value();

                SDefEditor e = Self.CreateEditor("AbnormalityMass",
                            "Mass",
                            "Mass",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/MassAbnormality",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.TumorSatelliteFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentShapeFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedCountFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedSizeFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedDistributionFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberConsistentWithFragment.Value())
                        .Description("Mass Abnormality Observation",
                            new Markdown()
                                .Paragraph("This resource and referenced child resources contain ",
                                    "information about a mass abnormality observation ")
                        )
                    ;

                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeAbnormalityMass.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeAbnormalityMass.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    .ACRDescription(
                        "\"MASS\" is three dimensional and occupies space. It is seen on two different mammographic ",
                        "projections. It has completely or partially convex-outward borders and (when radiodense) appears",
                        "denser in the center than at the periphery. If a potential mass is seen only on a single projection, it",
                        "should be called an \"ASYMMETRY\" until 3-dimensionality is confirmed"
                    )
                    ;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("massType",
                    Self.ComponentSliceCodeAbnormalityMassType.ToCodeableConcept(),
                    binding,
                    BindingStrength.Required,
                    0,
                    "1",
                    "Mass Type",
                    "refine the mass type");
            });
    }
}
