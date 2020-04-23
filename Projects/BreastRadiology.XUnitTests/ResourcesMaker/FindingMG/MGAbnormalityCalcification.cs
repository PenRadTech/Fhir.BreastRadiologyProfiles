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
        CSTaskVar MGCalcificationTypeCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "MammoCalcificationTypeCS",
                    "Mammography Calcification Type CodeSystem",
                    "MG Calc. Type/CodeSystem",
                    "Mammography calcification type code system.",
                    Group_MGCodesCS,
                    new ConceptDef[]
                    {
                        //+ Type
                        #region Codes
                        new ConceptDef()
                            .SetCode("Amorphous")
                            .SetDisplay("Amorphous")
                            .MammoId("702")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("702",
                                "F-0176C")
                            .SetSnomedCode("702",
                                "129760005")
                            .SetSnomedDescription("702",
                                "ClinicalFinding | 129760005 | Radiographic finding ",
                                "of amorphous calcification (Finding)")
                            .SetUMLS("702",
                                "(historically, \"indistinct\")",
                                "These are sufficiently small and/or hazy in appearance ",
                                "that a more specific particle shape",
                                "cannot be determined. ",
                                "Amorphous calcifications in a grouped, linear, or ",
                                "segmental distribution",
                                "are suspicious and generally warrant biopsy. ",
                                "Bilateral, diffuse amorphous calcifications",
                                "usually may be dismissed as benign, although baseline ",
                                "magnification views may be helpful.",
                                "The positive predictive value (PPV) of amorphous ",
                                "calcifications is reported to be",
                                "approximately 20%. ",
                                "Therefore, calcifications of this morphology appropriately",
                                "should be placed into BI-RADS  assessment category ",
                                "4B (PPV range > 10% to ? 50%). ",
                                "###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("Coarse")
                            .SetDisplay("Coarse")
                            .MammoId("704")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("704",
                                "F-01761")
                            .SetSnomedCode("704",
                                "129749001")
                            .SetSnomedDescription("704",
                                "ClinicalFinding | 129749001 | Coarse (popcorn-like) ",
                                "radiographic calcification (Finding)")
                            .SetUMLS("704",
                                "The classic large 'popcorn-like' calcifications are ",
                                "produced by involuting fibroadenomas.",
                                "These calcifications usually do not cause a diagnostic ",
                                "problem.",
                                "When the calcifications in an fibroadenoma are small ",
                                "and numerous, they may resemble malignant-type calcifications ",
                                "and need a biopsy. ",
                                "These are the classic large (> 2 to 3 mm in greatest ",
                                "diameter) calcifications produced by an involuting ",
                                "fibroadenoma. ",
                                "###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("Dystrophic")
                            .SetDisplay("Dystrophic")
                            .MammoId("705")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("705",
                                "F-01762")
                            .SetSnomedCode("705",
                                "129750001")
                            .SetSnomedDescription("705",
                                "ClinicalFinding | 129750001 | Dystrophic radiographic ",
                                "calcification (Finding) | [0/0] | R93.8")
                            .SetUMLS("705",
                                "Dystrophic soft tissue calcification is a broad term ",
                                "that encompasses a wide range of pathologies that ",
                                "cause soft-tissue calcification and is caused by ",
                                "calcification of damaged tissues. ",
                                " The amorphous calcification that results may be ",
                                "small or large. ",
                                " In some cases, ossification may occur - this is ",
                                "characterized by cortical formation and a central ",
                                "medullary cavity. ",
                                "###URL#https://radiopaedia.org/articles/dystrophic-soft-tissue-calcification-1?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("Eggshell")
                            .SetDisplay("Eggshell")
                            .MammoId("706")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("706",
                                "F-01763")
                            .SetSnomedCode("706",
                                "129751002")
                            .SetSnomedDescription("706",
                                "ClinicalFinding | 129751002 | Eggshell radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("706",
                                "Eggshell calcifications in the breast are benign ",
                                "peripheral rim like calcifications",
                                "They are typically secondary to fat necrosis or calcification ",
                                "of oil cysts.",
                                "thin rim-like calcification (<1 mm in thickness)",
                                "lucent centers",
                                "small to several centimeters in diameter (oil cyst)",
                                "may disappear (fat necrosis)",
                                " ###URL#https://radiopaedia.org/articles/eggshell-calcification-breast-1?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("Fine")
                            .SetDisplay("Fine")
                            .MammoId("707")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("707",
                                "ClinicalFinding | 129761009 | Fine, linear, (casting) ",
                                "radiographic calcification (Finding)")
                            .SetUMLS("707",
                                "These are thin, linear or curvilinear irregular calcifications ",
                                "and may be discontinuous.")
                        ,
                        new ConceptDef()
                            .SetCode("Generic")
                            .SetDisplay("Generic")
                            .MammoId("701")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("701",
                                "ClinicalFinding | 129748009 | Radiographic calcification ",
                                "finding")
                            .SetUMLS("701",
                                "Calcification happens when calcium builds up in body ",
                                "tissue, blood vessels, or organs. ",
                                "This buildup can harden and disrupt the body's normal ",
                                "processes. ",
                                "Calcium is transported through the bloodstream and ",
                                "is also found in every cell. ",
                                "As a result, calcification can occur in almost any ",
                                "part of the body.")
                        ,
                        new ConceptDef()
                            .SetCode("CoarseHeterogeneous")
                            .SetDisplay("Coarse Heterogeneous")
                            .MammoId("708")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("708",
                                "F-0176F")
                            .SetSnomedCode("708",
                                "129763007")
                            .SetSnomedDescription("708",
                                "ClinicalFinding | 129763007 | Heterogeneous radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("708",
                                "These are irregular, conspicuous calcifications that ",
                                "are generally between 0.5 mm and 1 mm",
                                "and tend to coalesce, but are smaller than dystrophic ",
                                "calcifications. ",
                                "They may be associated",
                                "with malignancy but more frequently are present in ",
                                "a fibroadenoma or in areas of fibrosis or",
                                "trauma representing evolving dystrophic calcifications. ",
                                "Numerous bilateral groups of coarse",
                                "heterogeneous calcifications usually may be dismissed ",
                                "as benign, although baseline magnification",
                                "views may be helpful. ",
                                "However, a single group of coarse heterogeneous calcifications ",
                                "has a positive",
                                "predictive value of slightly less than 15%, and therefore ",
                                "this finding should be",
                                "placed in BI-RADS  assessment category 4B (PPV range ",
                                "> 10% to ? 50%).###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("Indistinct")
                            .SetDisplay("Indistinct")
                            .MammoId("709")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("709",
                                "Amorphous calcifications, previously known as indistinct ",
                                "calcifications, are a morphological ",
                                "descriptor for breast calcifications that are small ",
                                "and/or hazy such that no clearly ",
                                "defined shape/form can be ascribed. ",
                                "###URL#https://radiopaedia.org > articles > amorphous-calcifications-breast")
                        ,
                        new ConceptDef()
                            .SetCode("LargeRodlike")
                            .SetDisplay("Large rodlike")
                            .MammoId("710")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("710",
                                "F-01764")
                            .SetSnomedCode("710",
                                "129752009")
                            .SetSnomedDescription("710",
                                "ClinicalFinding | 129752009 | Large rod-like radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("710",
                                "These benign calcifications associated with ductal ",
                                "ectasia may form solid or discontinuous",
                                "smooth linear rods, most of which are 0.5 mm or larger ",
                                "in diameter. ",
                                "A small percentage of",
                                "these calcifications may have lucent centers if the ",
                                "calcium is in the wall of the duct (periductal),",
                                "but most are intraductal, when calcification forms ",
                                "within the lumen of the duct. ",
                                "All large",
                                "rod-like calcifications follow a ductal distribution, ",
                                "radiating toward the nipple, occasionally",
                                "branching. ",
                                "The calcifications usually are bilateral, although ",
                                "they may be seen in only one",
                                "breast, especially when few calcific particles are ",
                                "visible. ",
                                "These calcifications usually are seen",
                                "in women older than 60 years.###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("Layering")
                            .SetDisplay("Layering")
                            .MammoId("711")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("711",
                                "Layering of calcium within the calcification. ",
                                "###URL#https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis")
                        ,
                        new ConceptDef()
                            .SetCode("FineLinear")
                            .SetDisplay("Fine Linear")
                            .MammoId("712")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("712",
                                "ClinicalFinding | 129761009 | Fine, linear, (casting) ",
                                "radiographic calcification (Finding)")
                            .SetUMLS("712",
                                "Also called fine linear branching. ",
                                "These are thin, linear, irregular calcifications, ",
                                "which may be discontinuous and ",
                                "which are",
                                "smaller than 0.5 mm in caliber. ",
                                "Occasionally, branching forms may be seen. ",
                                "Their appearance",
                                "suggests filling of the lumen of a duct or ducts ",
                                "involved irregularly by breast cancer. ",
                                "###ACRMG#66")
                        ,
                        new ConceptDef()
                            .SetCode("Lucent-centered")
                            .SetDisplay("Lucent-centered")
                            .MammoId("713")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("713",
                                "F-01766")
                            .SetSnomedCode("713",
                                "129754005")
                            .SetSnomedDescription("713",
                                "ClinicalFinding | 129754005 | Lucent-centered radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("713",
                                "These are round or oval calcifications that range ",
                                "from under 1 mm to over a centimeter.",
                                "They are the result of fat necrosis, calcified debris ",
                                "in ducts, and occasional fibroadenomas.",
                                "###URL#https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis")
                        ,
                        new ConceptDef()
                            .SetCode("MilkOfCalcium")
                            .SetDisplay("Milk of calcium")
                            .MammoId("714")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("714",
                                "F-01765")
                            .SetSnomedCode("714",
                                "129753004")
                            .SetSnomedDescription("714",
                                "ClinicalFinding | 129753004 | Milk of calcium radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("714",
                                "This is a manifestation of sedimented calcifications ",
                                "in macro- or microcysts, usually but not",
                                "always grouped. ",
                                "On the craniocaudal image they are often less evident ",
                                "and appear as round,",
                                "smudgy deposits, while occasionally on MLO and especially ",
                                "on 90  lateral (LM/ML) views,",
                                "they are more clearly defined and often semilunar, ",
                                "crescent shaped, curvilinear (concave up),",
                                "or linear, defining the dependent portion of cysts. ",
                                "The most important feature of these calcifications",
                                "is the apparent change in shape of the calcific particles ",
                                "on different mammographic",
                                "projections (craniocaudal versus occasionally the ",
                                "MLO view and especially LM/ML views). ",
                                "At",
                                "times milk of calcium calcifications are seen adjacent ",
                                "to other types of calcifications that may",
                                "be associated with malignancy, so it is important ",
                                "to search for more suspicious forms, especially ",
                                "those that do not change shape from the 90  lateral ",
                                "projection to the CC projection.###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("FinePleomorphic")
                            .SetDisplay("Fine Pleomorphic")
                            .MammoId("715")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("715",
                                "111344")
                            .SetSnomedDescription("715",
                                "not found")
                            .SetUMLS("715",
                                "These calcifications are usually more conspicuous ",
                                "than amorphous forms and are seen ",
                                "to have",
                                "discrete shapes. ",
                                "These irregular calcifications are distinguished ",
                                "from fine linear and fine-linear",
                                "branching forms by the absence of fine-linear particles. ",
                                "Fine pleomorphic calcifications vary in",
                                "size and shape and are usually smaller than 0.5 mm ",
                                "in diameter. ",
                                "###ACRMG#64")
                        ,
                        new ConceptDef()
                            .SetCode("Punctate")
                            .SetDisplay("Punctate")
                            .MammoId("716")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("716",
                                "F-01767")
                            .SetSnomedCode("716",
                                "129755006")
                            .SetSnomedDescription("716",
                                "ClinicalFinding | 129755006 | Punctate radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("716",
                                "Calcification is punctate/round. ",
                                "It's different than a \"round\" calcification though ",
                                "as it also means the calcifications are less than ",
                                ".5 mm in size. ",
                                "May warrant a probably benign (non-cancer) assessment ",
                                "unless there is also a linear pattern or in a segmental ",
                                "distibution. ",
                                "This may require and imaging guided biopy or mammographic ",
                                "surveillance. ",
                                " ###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("Rim")
                            .SetDisplay("Rim")
                            .MammoId("717")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("717",
                                "not found")
                            .SetUMLS("717",
                                "Eggshell or Rim Calcifications",
                                "These are very thin benign calcifications that appear ",
                                "as calcium is deposited on ",
                                "the surface of a sphere. ",
                                "Fat necrosis and calcifications in the walls of cysts ",
                                "are the most common \"rim\"",
                                "calcifications, although more extensive (and occasionally ",
                                "thicker-rimmed) calcification ",
                                "in the",
                                "walls of oil cysts or simple cysts may be seen. ",
                                "###ACRMG#49")
                        ,
                        new ConceptDef()
                            .SetCode("Round")
                            .SetDisplay("Round")
                            .MammoId("718")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("718",
                                "F-01768")
                            .SetSnomedCode("718",
                                "129756007")
                            .SetSnomedDescription("718",
                                "ClinicalFinding | 129756007 | Round shaped radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("718",
                                "When multiple, they may vary in size and therefore ",
                                "also in opacity. ",
                                "They may be considered",
                                "benign when diffuse and small (< 1 mm), and are frequently ",
                                "formed in the acini of lobules. ",
                                "When",
                                "smaller than 0.5 mm, the term \"punctate\" should be ",
                                "used.",
                                "An isolated group of punctate calcifications may ",
                                "warrant probably benign assessment and",
                                "mammographic surveillance if no prior examinations ",
                                "are available for comparison, or",
                                "image-guided biopsy if the group is new, increasing, ",
                                "linear or segmental in distribution, or if",
                                "adjacent to a known cancer.###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("Skin")
                            .SetDisplay("Skin")
                            .MammoId("719")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("719",
                                "ClinicalFinding | 129757003 | Radiographic finding ",
                                "of calcified skin of breast (Finding) | [0/0] | R92")
                            .SetUMLS("719",
                                "These are usually lucent-centered and pathognomonic ",
                                "in their appearance. ",
                                "Skin calcifications are most commonly seen along ",
                                "the inframammary fold, parasternally, overlying the ",
                                "axilla and around the areola. ",
                                "The individual calcific particles usually are tightly ",
                                "grouped, with individual",
                                "groups smaller than 5 mm in greatest dimension. ",
                                "Skin calcifications may develop from a degenerative ",
                                "metaplastic process. ",
                                "###ACRMG#36")
                        ,
                        new ConceptDef()
                            .SetCode("Spherical")
                            .SetDisplay("Spherical")
                            .MammoId("720")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("720",
                                "QualifierValue | 34258004 | Spherical shape (Qualifier) ",
                                "+")
                            .SetUMLS("720",
                                "Calcifications that have formed a  spherical shape ",
                                "are usually associated with benign ",
                                "lesions. ",
                                "###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("Suture")
                            .SetDisplay("Suture")
                            .MammoId("721")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("721",
                                "F-0176A")
                            .SetSnomedCode("721",
                                "129758008")
                            .SetSnomedDescription("721",
                                "ClinicalFinding | 129758008 | Radiographic finding ",
                                "of calcified suture material (Finding)")
                            .SetUMLS("721",
                                "Calcified suture materials are typically linear or ",
                                "tubular in appearance, and when present in Mammogram, ",
                                "may show up in a knot pattern.")
                        ,
                        new ConceptDef()
                            .SetCode("Vascular")
                            .SetDisplay("Vascular")
                            .MammoId("722")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("722",
                                "F-0176B")
                            .SetSnomedDescription("722",
                                "ClinicalFinding | 396779001 | Breast arterial calcification ",
                                "(Finding) | [0/0] | R92.1")
                            .SetUMLS("722",
                                "These are linear or form parallel tracks, that are ",
                                "usually clearly associated with blood vessels.",
                                "Vascular calcifications noted in women",
                                "On the left typical vascular calcifications.",
                                "If only one side of a vessel is calcified, the calcification ",
                                "may simulate intraductal (across a group of milk ",
                                "ducts) calcification.###URL#https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis")
                        #endregion // Codes
                        //- Type
                    }
                )
        );


        VSTaskVar MGCalcificationTypeVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "MammoCalcificationTypeVS",
                    "Mammography Calcification Type ValueSet",
                    "MG Calc. TypeValueSet",
                    "Mammography calcification types value set.",
                    Group_MGCodesVS,
                    Self.MGCalcificationTypeCS.Value()
                )
        );

        SDTaskVar MGAbnormalityCalcification = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("MGAbnormalityCalcification",
                            "Mammography Calcification",
                            "MG Calc.",
                            Global.ObservationUrl,
                            $"{Group_MGResources}/CalcificationAbnormality",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedCountFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedSizeFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedDistributionFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberConsistentWithFragment.Value())
                        .Description("Calcification Abnormality Observation",
                            new Markdown()
                        )
                    ;

                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeMGAbnormalityCalcification.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeMGAbnormalityCalcification.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    //+ IntroDocDescription
                        .Description("690",
                            "Calcifications usually can't be felt, but appear ",
                            "on a mammogram. ",
                            "Depending on  cluster, shape, size, and number, further ",
                            "tests may be recommended. ",
                            "Larger \"macrocalcifications\" are usually not associated ",
                            "with cancer.")
                    //- IntroDocDescription
                    ;

                e.StartComponentSliceing();

                e.ComponentSliceCodeableConcept("calcificationType",
                    Self.MGComponentSliceCodeCalcificationType.ToCodeableConcept(),
                    Self.MGCalcificationTypeVS.Value(),
                    BindingStrength.Required,
                    0,
                    "1",
                    "Calcification Type",
                    "refine the calcification type");

                e.ComponentSliceCodeableConcept("calcificationDistribution",
                    Self.MGCodeCalcificationDistribution.ToCodeableConcept(),
                    Self.CalcificationDistributionVS.Value(),
                    BindingStrength.Required,
                    0,
                    "1",
                    "Calcification Distribution",
                    "define the calcification distribution");
            });
    }
}
