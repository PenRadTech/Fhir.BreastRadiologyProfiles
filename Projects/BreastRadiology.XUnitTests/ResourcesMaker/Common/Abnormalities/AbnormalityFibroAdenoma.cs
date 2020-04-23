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
        CSTaskVar FibroadenomaCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "FibroadenomaCodeSystemCS",
                    "Fibroadenoma CodeSystem",
                    "Fibroadenoma/CodeSystem",
                    "Fibroadenoma values code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Type
                        #region Codes
                        new ConceptDef()
                            .SetCode("Fibroadenoma")
                            .SetDisplay("Fibroadenoma")
                            .MammoId("70")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("70",
                                "A fibroadenoma is a benign, or noncancerous, breast ",
                                "tumor. ",
                                "Unlike a breast cancer, which grows larger over time ",
                                "and can spread to other organs, ",
                                "a fibroadenoma remains in the breast tissue. ",
                                "Most are only 1 or 2 centimeters in size. ",
                                "###URL#www.webmd.com > breast-cancer > what-are-fibroadenomas")
                        ,
                        new ConceptDef()
                            .SetCode("FibroadenomaDegeneration")
                            .SetDisplay("Fibroadenoma degeneration")
                            .MammoId("695")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("695",
                                "These are non-cancerous breast lumps. ",
                                "Fibroadenomas usually go away with age. ",
                                "By the time an individual is menopausal, Fibroadenomas ",
                                "degenerate.")
                        #endregion // Codes
                        //- Type
                    })
        );

        VSTaskVar FibroadenomaVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "FibroadenomaVS",
                    "Fibroadenoma ValueSet",
                    "FibroadenomaValueSet",
                    "Fibroadenoma value set.",
                    Group_CommonCodesVS,
                    Self.FibroadenomaCS.Value()
                )
        );

        SDTaskVar AbnormalityFibroadenoma = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.FibroadenomaVS.Value();

                SDefEditor e = Self.CreateEditor("AbnormalityFibroadenoma",
                            "Fibroadenoma",
                            "Fibroadenoma",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/AbnormalityFibroadenoma",
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
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .Description("Fibroadenoma Abnormality Observation",
                            new Markdown()
                                .Paragraph("This resource and referenced child resources contain ",
                                    "information about a fibroadenoma abnormality observation ")
                                .ValidModalities(Modalities.MG | Modalities.US)
                        )
                    ;

                s = e.SDef;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    .MissingDescription()
                    ;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeAbnormalityFibroadenoma.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeAbnormalityFibroadenoma.ToCodeableConcept())
                    ;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("fibroAdenomaType",
                    Self.ComponentSliceCodeAbnormalityFibroAdenomaType.ToCodeableConcept(),
                    binding,
                    BindingStrength.Required,
                    0,
                    "1",
                    "FibroAdenoma Type",
                    "refine the fibroadenema type");
            });
    }
}
