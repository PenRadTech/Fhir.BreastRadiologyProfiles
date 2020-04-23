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
        CSTaskVar MGBreastDensityCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "MGBreastDensityCS",
                    "Mammography Breast Density CodeSystem",
                    "MG Breast Density/CodeSystem",
                    "Mammography breast density values code system.",
                    Group_MGCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("AlmostEntirelyFat")
                            .SetDisplay("Almost entirely fat")
                            .MammoId("Row618")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("Row618",
                                "A term used to describe breast tissue that is made ",
                                "up of almost all fatty tissue. ",
                                "Fatty breast tissue does not look dense on a mammogram, ",
                                "which may make it easier ",
                                "to find tumors or other changes in the breast. ",
                                "Fatty breast tissue is more common in older women ",
                                "than in younger women. ",
                                "Fatty breast tissue is one of four categories used ",
                                "to describe a level of breast ",
                                "density seen on a mammogram. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/search?contains=false&q=fatty")
                        ,
                        new ConceptDef()
                            .SetCode("ScatteredAreasOfFibroglandularDensity")
                            .SetDisplay("Scattered areas of fibroglandular density")
                            .MammoId("Row619")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("Row619",
                                "A term used to describe breast tissue that is made ",
                                "up of mostly fatty tissue and ",
                                "also has some dense fibrous tissue and glandular ",
                                "tissue. ",
                                "On a mammogram, the dense areas of the breast make ",
                                "it harder to find tumors or other ",
                                "changes. ",
                                "Scattered fibroglandular breast tissue is one of ",
                                "four categories used to describe ",
                                "a level of breast density seen on a mammogram. ",
                                "About 40% of women have this type of breast tissue. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/scattered-fibroglandular-breast-tissue")
                        ,
                        new ConceptDef()
                            .SetCode("HeterogeneouslyDense")
                            .SetDisplay("Heterogeneously dense")
                            .MammoId("Row620")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("Row620",
                                "A term used to describe breast tissue that has large ",
                                "areas of dense fibrous tissue ",
                                "and glandular tissue and also has some fatty tissue. ",
                                "The dense areas of the breast make it harder to find ",
                                "tumors or other changes on a ",
                                "mammogram. ",
                                "Heterogeneously dense breast tissue is one of four ",
                                "categories used to describe a ",
                                "level of breast density seen on a mammogram. ",
                                "About 40% of women have this type of breast tissue. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/heterogeneously-dense-breast-tissue")
                        ,
                        new ConceptDef()
                            .SetCode("ExtremelyDense")
                            .SetDisplay("Extremely dense")
                            .MammoId("Row621")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("Row621",
                                "Also called extremely dense breast tissue. ",
                                "A term used to describe breast tissue that is made ",
                                "up of almost all dense fibrous ",
                                "tissue and glandular tissue. ",
                                "On a mammogram, the dense areas of the breast make ",
                                "it harder to find tumors or other ",
                                "changes. ",
                                "Women who have extremely dense breast tissue have ",
                                "a higher risk of breast cancer ",
                                "than those who have little or no dense breast tissue. ",
                                "Extremely dense breast tissue is one of four categories ",
                                "used to describe a level ",
                                "of breast density seen on a mammogram. ",
                                "About 10% of women have this type of breast tissue. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/extremely-dense-breast-tissue")
                        #endregion // Codes
                        //- Codes
                    }
                )
        );

        VSTaskVar MGBreastDensityVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "MGBreastDensityVS",
                    "Mammography Breast Density ValueSet",
                    "MG Breast DensityValueSet",
                    "Mammography breast density value set.",
                    Group_MGCodesVS,
                    Self.MGBreastDensityCS.Value()
                )
        );


        SDTaskVar MGBreastDensity = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.MGBreastDensityVS.Value();

                {
                    IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
                    valueSetIntroDoc
                        .ReviewedStatus("Needs review by KWA")
                        .ReviewedStatus("Needs review by Penrad")
                        .ReviewedStatus("Needs review by MRS")
                        .ReviewedStatus("Needs review by MagView")
                        .ReviewedStatus("Needs review by CIMI")
                        ;
                    String outputPath = valueSetIntroDoc.Save();
                    Self.fc?.Mark(outputPath);
                }

                SDefEditor e = Self.CreateEditor("MGBreastDensity",
                            "Mammography Breast Density",
                            "MG Breast Density",
                            Global.ObservationUrl,
                            $"{Group_MGResources}/BreastDensity",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .Description("Breast Density Observation",
                            new Markdown()
                        )
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                    ;

                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeMGBreastDensity.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeMGBreastDensity.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    .ACRDescription(
                        "The following four categories of breast composition are defined by the visually estimated content of fibroglandular-density tissue within the breasts. Please note that the ",
                        "categories are listed as a, b, c, and d so as not to be confused with the numbered BI-RADS® assessment categories. If the breasts are not of apparently equal density, the ",
                        "denser breast should be used to categorize breast density. The sensitivity of mammography for noncalcified lesions decreases as the BI-RADS® breast density category ",
                        "increases. The denser the breast, the larger the lesion(s) that may be obscured. There is considerable intra- and inter-observer variation in visually estimating breast density ",
                        "between any two adjacent density categories. Furthermore, there is only a minimal and insignificant difference in the sensitivity of mammography between the densest breast ",
                        "in a lower-density category and the least dense breast in the next-higher-density category. These factors limit the clinical relevance of breast density categorization for the ",
                        "individual patient. "
                    )
                    ;
                ElementDefinition valueXDef = e.Select("value[x]")
                        .Type("CodeableConcept")
                        .Binding(binding.Url, BindingStrength.Required)
                    ;
                e.AddComponentLink("Breast Density Value",
                    new SDefEditor.Cardinality(e.Select("value[x]")),
                    null,
                    Global.ElementAnchor(valueXDef),
                    "CodeableConcept",
                    binding.Url);
            });
    }
}
