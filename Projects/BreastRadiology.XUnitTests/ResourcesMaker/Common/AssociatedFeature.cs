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
        CSTaskVar AssociatedFeatureCS = new CSTaskVar(
            (out CodeSystem vs) =>
                vs = Self.CreateCodeSystem(
                    "AssociatedFeatureCS",
                    "Associated Feature CodeSystem",
                    "AssociatedFeature/CodeSystem",
                    "Associated Feature seen during a breast examination.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ AssociatedFeatureCS
                        #region Codes
                        new ConceptDef()
                            .SetCode("ArchitecturalDistortion")
                            .SetDisplay("Architectural distortion")
                            .MammoId("260")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("260",
                                "Many breast masses are found within the zone of fibroglandular ",
                                "tissue or at a fat-fibroglandular",
                                "junction. ",
                                "If the mass blurs a tissue plane between fat and ",
                                "fibroglandular tissue or if the ",
                                "mass produces",
                                "distortion of the ducts, these findings may be termed ",
                                "architectural distortion. ",
                                "###ACRUS#139")
                        ,
                        new ConceptDef()
                            .SetCode("AxillaryAdenopathy")
                            .SetDisplay("Axillary adenopathy")
                            .MammoId("239")
                            .ValidModalities(Modalities.MG | Modalities.MRI)
                            .SetUMLS("239",
                                "Enlarged axillary (under the armpit) lymph nodes. ",
                                "Additional evaluation is needed to determine the ",
                                "cause. ",
                                "###ACRMG#110")
                        ,
                        new ConceptDef()
                            .SetCode("BiopsyClip")
                            .SetDisplay("Biopsy clip")
                            .MammoId("471.263")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("471.263",
                                "470272007")
                            .SetSnomedDescription("471.263",
                                "Physical Object | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("471.263",
                                "Tissue marker placement after image-guided breast ",
                                "biopsy has become a routine component ",
                                "of clinical practice. ",
                                "Marker placement distinguishes multiple biopsied ",
                                "lesions within the same breast, ",
                                "prevents re-biopsy of benign lesions, enables multi-modality ",
                                "correlation, guides ",
                                "pre-operative localization and helps confirm surgical ",
                                "target removal. ",
                                "Numerous breast tissue markers are currently available, ",
                                "with varied shapes, composition, ",
                                "and associated bio-absorbable components. ",
                                "###URL#https://www.ncbi.nlm.nih.gov/pubmed/30059952")
                        ,
                        new ConceptDef()
                            .SetCode("BrachytherapyTube")
                            .SetDisplay("Brachytherapy tube")
                            .MammoId("475")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("475",
                                "Brachytherapy may be temporary or permanent. ",
                                "Temporary brachytherapy places radioactive material ",
                                "inside a catheter for a specific ",
                                "amount of time and then it is removed. ",
                                "It is given at a low-dose rate (LDR) or high-dose ",
                                "rate (HDR). ",
                                "Permanent brachytherapy is also called seed implantation. ",
                                "It puts radioactive seeds (about the size of a grain ",
                                "of rice) in or near the tumor ",
                                "permanently. ",
                                "After several months, the seeds lose their radioactivity. ",
                                "###URL#https://www.radiologyinfo.org/en/info.cfm?pg=brachy")
                        ,
                        new ConceptDef()
                            .SetCode("ChestWallInvasion")
                            .SetDisplay("Chest wall invasion")
                            .MammoId("255")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("255",
                                "NO FIND")
                            .SetUMLS("255",
                                "A tumor of the lung that has invaded the chest wall.")
                        ,
                        new ConceptDef()
                            .SetCode("CooperDistorted")
                            .SetDisplay("Cooper distorted")
                            .MammoId("261")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("261",
                                "The cooper's ligaments are fibrous bands extending ",
                                "vertically from surface attached to ",
                                "chest wall muscles. ",
                                "These ligaments maintain the shape and structure ",
                                "of the breasts and help to prevent ",
                                "sagging. ",
                                " Cooper's ligaments support the breasts on the chest ",
                                "wall, maintain their contour, ",
                                "and keep them in position. ",
                                "Breasts become distorted if cancerous tumors grow ",
                                "on the ligaments. ",
                                "The normal breast contours can be noticeably different ",
                                "once distorted. ",
                                "This can be because of swelling, bulges, retraction, ",
                                "etc.")
                        ,
                        new ConceptDef()
                            .SetCode("CooperThickened")
                            .SetDisplay("Cooper thickened")
                            .MammoId("262")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("262",
                                "The cooper's ligaments are fibrous bands extending ",
                                "vertically from surface attached",
                                "to chest wall muscles. ",
                                "These ligaments maintain the shape and structure ",
                                "of the breasts and help to prevent ",
                                "sagging. ",
                                "Cooper's ligaments support the breasts on the chest ",
                                "wall, maintain their contour, ",
                                "and keep them in position. ",
                                "These support breast tissue; and can become contracted ",
                                "in cancer of breast, producing ",
                                "dimples in overlying skin. ",
                                "Thickening occurs when there are skin changes usually ",
                                "associated with the presence ",
                                "of a mass, benign or malignant, that causes shortening ",
                                "in the Coopers ligaments due ",
                                "to fibrosis.")
                        ,
                        new ConceptDef()
                            .SetCode("Edema")
                            .SetDisplay("Edema")
                            .MammoId("258")
                            .ValidModalities(Modalities.US)
                            .SetSnomedCode("258",
                                "290077003")
                            .SetSnomedDescription("258",
                                "Clinical Finding | Edema of breast (Finding)")
                            .SetUMLS("258",
                                "Edema (swelling of the breasts)  may be due to blockage ",
                                "of subdermal lymphatics by tumor cells or an inflammatory ",
                                "process within the breast or axilla.")
                        ,
                        new ConceptDef()
                            .SetCode("EdemaAdj")
                            .SetDisplay("Edema adj")
                            .MammoId("259")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("259",
                                "This is swelling of one or both breasts. ",
                                "A mammographic pattern of skin thickening, increased ",
                                "parenchymal density, and interstitial marking.")
                        ,
                        new ConceptDef()
                            .SetCode("GoldSeed")
                            .SetDisplay("Gold Seed")
                            .MammoId("238")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("238",
                                "470272007")
                            .SetSnomedDescription("238",
                                "Physical Object | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("238",
                                "Tiny, gold seeds, about the size of a grain of rice, ",
                                "that are put in and/or around ",
                                "a tumor to show exactly where it is in the body. ",
                                "The tumor can then be directly targeted and be given ",
                                "higher doses of radiation ",
                                "with less harm to nearby healthy tissue. ",
                                "Also called gold fiducial marker seeds, gold fiducial ",
                                "markers, and gold-seed fiducial ",
                                "markers. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/gold-seeds")
                        ,
                        new ConceptDef()
                            .SetCode("Hematoma")
                            .SetDisplay("Hematoma")
                            .MammoId("478")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("478",
                                "302924003")
                            .SetSnomedDescription("478",
                                "Clinical Finding | Breast hematoma (Disorder) | N64.89")
                            .SetUMLS("478",
                                "A hematoma is a localized bleeding outside of blood ",
                                "vessels, due to either disease ",
                                "or trauma including injury or surgery and may involve ",
                                "blood continuing to seep from ",
                                "broken capillaries. ",
                                "en.wikipedia.org > wiki > Hematoma")
                        ,
                        new ConceptDef()
                            .SetCode("NippleRetraction")
                            .SetDisplay("Nipple retraction")
                            .MammoId("477")
                            .ValidModalities(Modalities.MG | Modalities.MRI)
                            .SetSnomedCode("477",
                                "31845005")
                            .SetSnomedDescription("477",
                                "ClinicalFinding | Retraction of nipple (Disorder) ",
                                "| [2/9] | N64.53")
                            .SetUMLS("477",
                                "Retracted nipples lie flat against the areola. ",
                                "The condition can be the result of inflammation or ",
                                "scarring of the tissue behind ",
                                "the nipple, and caused by numerous conditions, not ",
                                "just cancer. ",
                                "In the case of breast cancer, nipple retraction occurs ",
                                "when the tumor attacks the ",
                                "duct behind the nipple, pulling it in.")
                        ,
                        new ConceptDef()
                            .SetCode("NOChestWallInvasion")
                            .SetDisplay("NO Chest wall invasion")
                            .MammoId("257")
                            .ValidModalities(Modalities.MRI)
                            .SetUMLS("257",
                                "The mass has not attached itself to the chest wall.")
                        ,
                        new ConceptDef()
                            .SetCode("PectoralisMuscleInvasion")
                            .SetDisplay("Pectoralis muscle invasion")
                            .MammoId("254")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("254",
                                "choices with muscle + invasion")
                            .SetUMLS("254",
                                "Pectoralis muscle invasion is when a tumor has become ",
                                "large enough to invade into ",
                                "the pectoralis muscle.")
                        ,
                        new ConceptDef()
                            .SetCode("PectoralisMuscleInvolvement")
                            .SetDisplay("Pectoralis muscle involvement")
                            .MammoId("256")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedDescription("256",
                                "choices with muscle + invasion")
                            .SetUMLS("256",
                                "Pectoralis muscle involvement of the tumor has been ",
                                "detected on the MRI by muscle ",
                                "enhancement with obliteration of the fat plane between ",
                                "the tumor and the muscle. ",
                                "pubs.rsna.org > doi > pdf")
                        ,
                        new ConceptDef()
                            .SetCode("PectoralisMuscleTenting")
                            .SetDisplay("Pectoralis muscle tenting")
                            .MammoId("253")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("253",
                                "NO FIND")
                            .SetUMLS("253",
                                "The tent sign is a term referring to a characteristic ",
                                "appearance of the posterior ",
                                "edge of the breast parenchyma when a mass (usually ",
                                "an infiltrating lesion) causes ",
                                "its retraction and forms an inverted \"V\" that resembles ",
                                "the tip of a circus tent. ",
                                "###URL#https://radiopaedia.org/articles/tent-sign-breast?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("PostSurgicalScar")
                            .SetDisplay("Post surgical scar")
                            .MammoId("479")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("479",
                                "442523003")
                            .SetSnomedDescription("479",
                                "ClinicalFinding | Surgical scar finding (Finding) ",
                                "| [2/7] | L90.5 |")
                            .SetUMLS("479",
                                "Post surgical scarring happens because of the incisions ",
                                "needed to surgically remove ",
                                "tumor, cells, etc. ",
                                "The amount of scarring is connected to the different ",
                                "stages of wound healing. ",
                                "Surgical scar care should be continued for a year.")
                        ,
                        new ConceptDef()
                            .SetCode("Seroma")
                            .SetDisplay("Seroma")
                            .MammoId("469")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("469",
                                "297178008")
                            .SetSnomedDescription("469",
                                "ClinicalFinding | Breast seroma (Disorder)")
                            .SetUMLS("469",
                                "A breast seroma is a collection (pocket) of serous ",
                                "fluid that can develop after trauma ",
                                "to the breast or following procedures such as breast ",
                                "surgery or radiation therapy. ",
                                "Serous fluid is a pale yellow, transparent fluid ",
                                "that contains protein, but no blood ",
                                "cells or pus. ",
                                "###URL#https://www.verywellhealth.com/seroma-medical-definition-430372")
                        ,
                        new ConceptDef()
                            .SetCode("SkinInvolvement")
                            .SetDisplay("Skin involvement")
                            .MammoId("252")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("252",
                                "The mass or lesion has attached itself to the skin ",
                                "of the breast. ",
                                "There are several layers of skin that the mass or ",
                                "lesion can penetrate and that is ",
                                "what determines the level of skin invasion.")
                        ,
                        new ConceptDef()
                            .SetCode("SkinLesion")
                            .SetDisplay("Skin lesion")
                            .MammoId("473")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("473",
                                "126510002")
                            .SetSnomedDescription("473",
                                "ClinicalFinding | Neoplasm of skin of breast (Disorder)")
                            .SetUMLS("473",
                                "A skin lesion is a part of the skin that has an abnormal ",
                                "growth or appearance compared ",
                                "to the skin around it.In order to diagnose a skin ",
                                "lesion, a full physical exam is necessary.")
                        ,
                        new ConceptDef()
                            .SetCode("SkinRetraction")
                            .SetDisplay("Skin retraction")
                            .MammoId("251")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("251",
                                "ClinicalFinding | 129796009 | Mammographic skin retraction ",
                                "of breast (Finding) | [0/0] | N64.5")
                            .SetUMLS("251",
                                "Skin retraction (or inversion) or Skin retraction. ",
                                "Breast cancers that are located near the skin or ",
                                "nipple may cause scarring within ",
                                "the breast that pulls at the nipple or nearby skin. ",
                                "Skin and nipple retraction are more obvious when ",
                                "a woman raises her arms above her ",
                                "head or leans forward. ",
                                "###URL#https://www.drholmesmd.com/blog/early-signs-of-breast-cancer")
                        ,
                        new ConceptDef()
                            .SetCode("SkinThickening")
                            .SetDisplay("Skin thickening")
                            .MammoId("250")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("250",
                                "ClinicalFinding | 129797000 | Mammographic skin thickening ",
                                "of breast (Finding) | [0/0] | R92")
                            .SetUMLS("250",
                                "The presence of skin thickening on mammography is ",
                                "variably defined, usually being ",
                                "more than 2 mm in thickness. ",
                                "It can result from a number of both benign and malignant ",
                                "causes. ",
                                "###URL#https://radiopaedia.org/articles/skin-thickening-on-mammography-differential?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalClip")
                            .SetDisplay("Surgical clip")
                            .MammoId("485")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("485",
                                "470342004")
                            .SetSnomedDescription("485",
                                "PhysicalObject | Implantable tissue clip (Object)")
                            .SetUMLS("485",
                                "Most surgical clips are currently made of titanium, ",
                                "and as many as 30 to 40 clips ",
                                "may be used during a single surgical procedure. ",
                                "Surgical clips may remain inside the patient's body ",
                                "after the wounds are healed.")
                        ,
                        new ConceptDef()
                            .SetCode("TrabecularThickening")
                            .SetDisplay("Trabecular thickening")
                            .MammoId("470")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("470",
                                "129795008")
                            .SetSnomedDescription("470",
                                "ClinicalFinding | Mammographic trabecular thickening ",
                                "of breast (Finding)")
                            .SetUMLS("470",
                                "Trabecular thickening-thickening of the Cooper's ligaments ",
                                "and fibrous stroma-is ",
                                "an imaging finding of breast edema, usually secondary ",
                                "to dilated lymphatics. ",
                                "Skin thickening and trabecular thickening often occur ",
                                "together, and they have similar ",
                                "differential diagnoses. ",
                                "###URL#https://oxfordmedicine.com/view/10.1093/med/9780190270261.001.0001/med-9780190270261-chapter-48")
                        #endregion // Codes
                        //- AssociatedFeatureCS
                        ,
                        //+ AssociatedFeature2CS
                        #region Codes
                        new ConceptDef()
                            .SetCode("CalcificationInMass")
                            .SetDisplay("Calcification in mass")
                            .MammoId("233")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("233",
                                "Calcifications usually can't be felt, but appear ",
                                "on a mammogram. ",
                                "Depending on how calcifications are clustered; shape, ",
                                "size, and number, further tests may be necessary. ",
                                "Larger \"macrocalcifications\" are usually not associated ",
                                "with cancer.")
                        ,
                        new ConceptDef()
                            .SetCode("CalcificationNotOnMammogarm")
                            .SetDisplay("Calcification Not on mammogarm")
                            .MammoId("235")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("235",
                                "Calcifications usually can't be felt, but appear ",
                                "on a mammogram. ",
                                "Calcifications can be clustered and their shape, ",
                                "size, and number. ",
                                "Large \"macrocalcifications\" are usually not associated ",
                                "with cancer.")
                        ,
                        new ConceptDef()
                            .SetCode("CalcificationOnMammogram")
                            .SetDisplay("Calcification on mammogram")
                            .MammoId("234")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("234",
                                "Calcifications are small deposits of calcium that ",
                                "show up on mammograms as bright ",
                                "white specks or dots on the soft tissue background ",
                                "of the breasts. ",
                                "The calcium readily absorbs the X-rays from mammograms")
                        ,
                        new ConceptDef()
                            .SetCode("Calcifications")
                            .SetDisplay("Calcifications")
                            .MammoId("232")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("232",
                                "Calcifications are small deposits of calcium that ",
                                "show up on mammograms as bright ",
                                "white specks or dots on the soft tissue background ",
                                "of the breasts.")
                        ,
                        new ConceptDef()
                            .SetCode("MicroCalcifications")
                            .SetDisplay("Micro calcifications")
                            .MammoId("231")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("231",
                                "ClinicalFinding | 44771000 | Microcalcifications ",
                                "of the breast (Disorder) | [1/1] | R92.0")
                            .SetUMLS("231",
                                "Micro-calcifications show up as fine, white specks ",
                                "in a mammogram, similar to grains of salt; usually ",
                                "noncancerous, but certain patterns can be an early ",
                                "sign of cancer.")
                        ,
                        new ConceptDef()
                            .SetCode("MilkOfCalcium")
                            .SetDisplay("Milk of calcium")
                            .MammoId("237")
                            .ValidModalities(Modalities.US)
                            .SetSnomedCode("237",
                                "129753004")
                            .SetSnomedDescription("237",
                                "ClinicalFinding | 129753004 | Milk of calcium radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("237",
                                "The term milk of calcium (MOC) is given to dependent, ",
                                "sedimented calcification within ",
                                "a cystic structure or hollow organ. ",
                                "This sort of colloidal calcium suspension layering ",
                                "can occur in various regions. ",
                                "###URL#https://radiopaedia.org/articles/milk-of-calcium-disambiguation?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("RimCalcifications")
                            .SetDisplay("Rim calcifications")
                            .MammoId("236")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("236",
                                "not found")
                            .SetUMLS("236",
                                "These are very thin benign calcifications that appear ",
                                "as calcium is deposited on ",
                                "the surface of a sphere. ",
                                "Although fat necrosis can produce these thin deposits, ",
                                "calcifications in the wall ",
                                "of cysts are the most common 'rim' calcifications.")
                        #endregion // Codes
                        //- AssociatedFeature2CS
                    })
        );


        VSTaskVar AssociatedFeatureVS = new VSTaskVar(
            (out ValueSet vs) =>
            {
                vs = Self.CreateValueSet(
                    "AssociatedFeatureVS",
                    "Associated Feature ValueSet",
                    "Associated Feature/ValueSet",
                    "Associated feature observed during a Breast Radiology exam value set",
                    Group_CommonCodesVS,
                    Self.AssociatedFeatureCS.Value());

                IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(vs);
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
        );

        SDTaskVar AssociatedFeature = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.AssociatedFeatureVS.Value();

                SDefEditor e = Self.CreateEditor("AssociatedFeature",
                            "Associated Feature",
                            "Associated Feature",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/AssociatedFeature/AssociatedFeature",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.BreastBodyLocationRequiredFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedCountFragment.Value())
                        .Description("Associated Feature Observation",
                            new Markdown()
                                    .Paragraph("This resource and referenced child resources contain ",
                                               "information about a associated feature observations")
                                    .Paragraph("The feature observed is defined by the codeable concept in the value[x] field.")
                        )
                    ;
                s = e.SDef;
                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    ;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeAssociatedFeature.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeAssociatedFeature.ToCodeableConcept())
                    ;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("featureType",
                    Self.ComponentSliceCodeAssociatedFeatureType.ToCodeableConcept(),
                    binding,
                    BindingStrength.Required,
                    1,
                    "1",
                    "Associated Feature Type",
                    "define the observed feature");
            });
    }
}
