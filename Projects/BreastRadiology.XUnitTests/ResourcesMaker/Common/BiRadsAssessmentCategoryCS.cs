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
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        //# TODO: get from gg
        CSTaskVar BiRadsAssessmentCategoriesCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "BiRadsAssessmentCategoriesCS",
                    "BiRads(r) Assessment Category Codes CodeSystem",
                    "BiRads/CodeSystem",
                    "BiRads(r) Assessment Category code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("Category0")
                            .SetDisplay("Category 0 (Incomplete)")
                            .MammoId("36")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("36",
                                "ClinicalFinding | 397138000 | Mammography assessment ",
                                "(Category 0)")
                            .SetUMLS("36",
                                "Need additional Imaging Evaluation and/or prior Mammograms ",
                                "for comparison. ",
                                "Recall for additional imaging and/or comparison with ",
                                "prior examination(s)        ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category2")
                            .SetDisplay("Category 2 (Benign)")
                            .MammoId("32")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("32",
                                "ClinicalFinding | 397141009 | Mammography assessment ",
                                "(Category 2)")
                            .SetUMLS("32",
                                "This is a normal assessment. ",
                                "Benign refers to a condition, tumor, or growth that ",
                                "is not cancerous. ",
                                "This means that it does not spread to other parts ",
                                "of the body. ",
                                "It does not invade nearby tissue. ",
                                " Essentially 0% likelihood of malignancy. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category3")
                            .SetDisplay("Category 3 (Probably Benign)")
                            .MammoId("33")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("33",
                                "ClinicalFinding | 397143007 | Mammography assessment ",
                                "(Category 3)")
                            .SetUMLS("33",
                                "A finding assessed using this category should have ",
                                "a <= 2% likelihood of malignancy, ",
                                "but greater than the essentially 0% likelihood of ",
                                "malignancy of a characteristically ",
                                "benign finding. ",
                                "A probably benign finding is not expected to change ",
                                "over the suggested period of ",
                                "imaging surveillance, but the interpreting physician ",
                                "prefers to establish stability ",
                                "of the finding before recommending management limited ",
                                "to routine mammography screening. ",
                                " Six month follow-up and/or",
                                "surveillance mammography is recommended. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category4")
                            .SetDisplay("Category 4 (Suspicious)")
                            .MammoId("34")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("34",
                                "ClinicalFinding | 397144001 | Mammography assessment ",
                                "(Category 4)")
                            .SetUMLS("34",
                                "This category is reserved for findings that do not ",
                                "have the classic appearance of ",
                                "malignancy but are sufficiently suspicious to justify ",
                                "a recommendation for biopsy. ",
                                "There is a 2% likelihood of malignancy (cancer). ",
                                "Almost all recommendations for breast interventional ",
                                "procedures will come from assessments ",
                                "made using",
                                "this category. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category4A")
                            .SetDisplay("Category 4A (Low suspicion)")
                            .MammoId("176")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("176",
                                "Not found")
                            .SetUMLS("176",
                                "Low suspicion for malignancy. ",
                                "A malignant finding is not suspected. ",
                                "A biopsy or other test will likely still be performed ",
                                "in order to determine. ",
                                "Tissue diagnosis may be recommended. ",
                                "Six month follow-up and/or surveillance mammography ",
                                "is recommended. ",
                                "Likelihood of malignancy is > 2% to <= 10% likelihood ",
                                "of malignancy. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category4B")
                            .SetDisplay("Category 4B (Moderate suspicion)")
                            .MammoId("177")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("177",
                                "Not found")
                            .SetUMLS("177",
                                "Category 4B: Moderate suspicion for malignancy. ",
                                "It warrants radiologic and pathologic correlation ",
                                "after tissue diagnosis. ",
                                "Likelihood of malignancy is > 10% to <= 50% likelihood ",
                                "of",
                                "malignancy. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category4C")
                            .SetDisplay("Category 4C (High suspicion)")
                            .MammoId("178")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("178",
                                "Not found")
                            .SetUMLS("178",
                                "Category 4C: High suspicion for",
                                "malignancy. ",
                                "Includes findings that have a high suspicion of malignancy ",
                                "but that are not highly",
                                "suggestive of malignancy (category 5). ",
                                "Tissue Diagnosis is highly recommended. ",
                                " Range for likelihood of malignancy is > 50% to < ",
                                "95% likelihood of malignancy. ",
                                "It is more likely malignant versus benign. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category5")
                            .SetDisplay("Category 5 (Highly Suggestive of Malignancy)")
                            .MammoId("35")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("35",
                                "ClinicalFinding | 397145000 | Mammography assessment ",
                                "(Category 5)")
                            .SetUMLS("35",
                                "Highly Suggestive of Malignancy. ",
                                "Almost certainly predictive of breast cancer with ",
                                "a ",
                                "value of at least 95%. ",
                                "Tissue Diagnosis is highly recommended or required. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Category6")
                            .SetDisplay("Category 6 (Known Biopsy-Proven Malignancy)")
                            .MammoId("172")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("172",
                                "Known Biopsy-Proven Malignancy. ",
                                "Surgical excision when clinically",
                                "appropriate. ",
                                "This category is only used for findings on a mammogram ",
                                "that have already been shown to be cancer by a previous ",
                                "biopsy. ",
                                "Mammograms may be used in this way to see how well ",
                                "the cancer is responding to treatment. ",
                                "###ACRUS#")
                        #endregion // Codes
                        //- Codes
                    })
        );

        VSTaskVar BiRadsAssessmentCategoriesVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "BiRadsAssessmentCategoriesVS",
                    "BiRads(r) Assessment Category ValueSet",
                    "BiRads/ValueSet",
                    "BiRads(r) Assessment Category value set.",
                    Group_CommonCodesVS,
                    Self.BiRadsAssessmentCategoriesCS.Value())
        );
    }
}
