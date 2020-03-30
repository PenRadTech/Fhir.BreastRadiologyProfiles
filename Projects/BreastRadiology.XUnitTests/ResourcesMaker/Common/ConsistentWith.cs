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
        SDTaskVar ConsistentWith = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("ConsistentWith",
                            "Consistent With",
                            "Consistent/With",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/ConsistentWith",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .Description("'Consistent With' Observation",
                            new Markdown()
                                .Paragraph("This resource contains information about a determination ",
                                    "that the parent abnormality is consistent with ",
                                    "the finding described in this resource.")
                        )
                    ;
                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeConsistentWith.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeConsistentWith.ToCodeableConcept())
                    ;


                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("value",
                    Self.ComponentSliceCodeConsistentWithValue.ToCodeableConcept(),
                    Self.ConsistentWithVS.Value(),
                    BindingStrength.Extensible,
                    1,
                    "1",
                    "Consistent With Value",
                    "defines what this observation is consistent with");
                e.ComponentSliceCodeableConcept("qualifier",
                    Self.ComponentSliceCodeConsistentWithQualifier.ToCodeableConcept(),
                    Self.ConsistentWithQualifierVS.Value(),
                    BindingStrength.Required,
                    0,
                    "*",
                    "Consistent With Qualifier",
                    "qualify the 'consistentWith' slice component value");

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    ;
            });

        VSTaskVar ConsistentWithVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "ConsistentWithVS",
                    "ConsistentWith ValueSet",
                    "ConsistentWith/ValueSet",
                    "ConsistentWith value set.",
                    Group_CommonCodesVS,
                    Self.ConsistentWithCS.Value()
                )
        );

        VSTaskVar ConsistentWithQualifierVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "ConsistentWithQualifierVS",
                    "ConsistentWithQualifier ValueSet",
                    "ConsistentWithQualifier/ValueSet",
                    "ConsistentWithQualifier value set.",
                    Group_CommonCodesVS,
                    Self.ConsistentWithQualifierCS.Value()
                )
        );

        CSTaskVar ConsistentWithCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "ConsistentWithCodeSystemCS",
                    "Consistent With CodeSystem",
                    "ConsistentWith/CodeSystem",
                    "ConsistentWith code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("Abscess")
                            .SetDisplay("Abscess")
                            .MammoId("104")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("104",
                                "An area within the body tissue that is swollen and ",
                                "contains an accumulation of pus.")
                        ,
                        new ConceptDef()
                            .SetCode("Angiolipoma")
                            .SetDisplay("Angiolipoma")
                            .MammoId("503")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedCode("503",
                                "404057003")
                            .SetSnomedDescription("503",
                                "ClinicalFinding | Angiolipoma (Disorder)")
                            .SetUMLS("503",
                                "Angiolipoma is a rare type of lipoma - a growth made ",
                                "of fat and blood vessels that ",
                                "develops under the skin. ",
                                " Unlike other types of lipomas, angiolipomas are ",
                                "often painful or tender. ",
                                "###URL#https://www.healthline.com/health/angiolipoma")
                        ,
                        new ConceptDef()
                            .SetCode("ApocrineMetaplasia")
                            .SetDisplay("Apocrine metaplasia")
                            .MammoId("948")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("948",
                                "ClinicalFinding | 37009001 | Apocrine metaplasia ",
                                "of breast (Disorder) | [0/0] | N60.89")
                            .SetUMLS("948",
                                "A benign condition; Apocrine Metaplasia refers to ",
                                "a particular type of cell change. ",
                                "This is a type of 'umbrella term' that relates to a ",
                                "variety of cystic breast disorders. ",
                                "The epithelial cells are undergoing an unexpected ",
                                "change.",
                                "These breast changes may show on a mammogram and ",
                                "biopsy as a mass or benign lesion, ",
                                "or possibly even develop into a palpable mass.",
                                "###URL#https://breast-cancer.ca/apo-meta/")
                        ,
                        new ConceptDef()
                            .SetCode("Artifact")
                            .SetDisplay("Artifact")
                            .MammoId("946")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("946",
                                "X-ray artifacts can present in a variety of ways ",
                                "including abnormal shadows noted ",
                                "on a radiograph or degraded image quality, and have ",
                                "been produced by artificial means ",
                                "from hardware failure, operator error and software ",
                                "(post-processing) artifacts. ",
                                "There are common and distinct artifacts for film, ",
                                "computed (CR) and digital radiography ",
                                "(DR). ",
                                "Common causes are improper handling of the films",
                                "errors while processing the films",
                                "patient movement while taking the image. ",
                                "###URL#https://radiopaedia.org/articles/x-ray-artifacts?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("AtypicalHyperplasia")
                            .SetDisplay("Atypical hyperplasia")
                            .MammoId("545")
                            .ValidModalities(Modalities.MRI)
                            .SetUMLS("545",
                                "Atypical hyperplasia is a precancerous condition ",
                                "that affects cells in the breast. ",
                                "Atypical hyperplasia describes an accumulation of ",
                                "abnormal cells in the breast.",
                                "Atypical hyperplasia isn't cancer, but it can be ",
                                "a forerunner to the development ",
                                "of breast cancer. ",
                                "Over the course of the lifetime, if the atypical ",
                                "hyperplasia cells keep dividing ",
                                "and become more abnormal, this can transition into ",
                                "noninvasive breast cancer (carcinoma ",
                                "in situ) or invasive breast cancer. ",
                                "###URL#https://www.mayoclinic.org/diseases-conditions/atypical-hyperplasia/symptoms-causes/syc-20369773")
                        ,
                        new ConceptDef()
                            .SetCode("AxillaryLymphNode")
                            .SetDisplay("Axillary lymph node")
                            .MammoId("942")
                            .ValidModalities(Modalities.NM)
                            .SetSnomedDescription("942",
                                "BodyStructure | 245269009 | Axillary lymph node group ",
                                "(Bodypart)")
                            .SetUMLS("942",
                                "Axillary lymph nodes are the lymph nodes located ",
                                "in the armpits. ",
                                "They can become enlarged in many conditions including ",
                                "infections, lymphomas, and ",
                                "breast cancers. ",
                                "Lymph nodes are small structures located all over ",
                                "the body around blood vessels that ",
                                "act as filters and can accumulate germs or cancer ",
                                "cells. ",
                                "They are a part of the lymph system of the body. ",
                                "###URL#https://www.verywellhealth.com/axillary-lymph-nodes-2252131")
                        ,
                        new ConceptDef()
                            .SetCode("Carcinoma")
                            .SetDisplay("Carcinoma")
                            .MammoId("504")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("504",
                                "ClinicalFinding | 254838004 | Carcinoma of breast ",
                                "(Disorder) | [4/33] | C50.929")
                            .SetUMLS("504",
                                "Carcinoma is a type of cancer that starts in cells ",
                                "that make up the skin or the tissue ",
                                "lining organs.")
                        ,
                        new ConceptDef()
                            .SetCode("CarcinomaKnown")
                            .SetDisplay("Carcinoma known")
                            .MammoId("510")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("510",
                                "ClinicalFinding | 254838004 | Carcinoma of breast ",
                                "(Disorder) | [4/33] | C50.929")
                            .SetUMLS("510",
                                "Imaging tests used in diagnosing cancer may include ",
                                "a computerized tomography (CT) ",
                                "scan, bone scan, magnetic resonance imaging (MRI), ",
                                "(PET) scan, ultrasound and X-ray, ",
                                "among others. ",
                                "In most cases, a biopsy is the only way to definitively ",
                                "diagnose cancer. ",
                                "Most breast cancers are carcinomas, which are tumors ",
                                "that start in the epithelial ",
                                "cells that line organs and tissues throughout the ",
                                "body. ",
                                "When carcinomas form in the breast, they are usually ",
                                "a more specific type called ",
                                "adenocarcinoma, which starts in cells in the ducts ",
                                "(the milk ducts) or the lobules ",
                                "(milk-producing glands). ",
                                "www.mayoclinic.org > cancer > diagnosis-treatment > ",
                                "drc-20370594")
                        ,
                        new ConceptDef()
                            .SetCode("ClusterOfCysts")
                            .SetDisplay("Cluster of cysts")
                            .MammoId("577")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("577",
                                "399294002")
                            .SetSnomedDescription("577",
                                "ClinicalFinding |Cyst of breast (Disorder) ++++++")
                            .SetUMLS("577",
                                "A breast cyst is a non-cancerous (benign) fluid-filled ",
                                "sac in the breast. ",
                                " Some cysts are too small to feel and others may ",
                                "be large and uncomfortable. ",
                                "Sometimes there are clusters of cysts in one breast ",
                                "or both.")
                        ,
                        new ConceptDef()
                            .SetCode("Cyst")
                            .SetDisplay("Cyst")
                            .MammoId("565")
                            .ValidModalities(Modalities.MG | Modalities.MRI)
                            .SetSnomedCode("565",
                                "399294002")
                            .SetSnomedDescription("565",
                                "ClinicalFinding |Cyst of breast (Disorder)")
                            .SetUMLS("565",
                                "A breast cyst is a non-cancerous (benign) fluid-filled ",
                                "sac in the breast. ",
                                " Some cysts are too small to feel and others may ",
                                "be large and uncomfortable. ",
                                "Sometimes there are clusters of cysts in one breast ",
                                "or both.")
                        ,
                        new ConceptDef()
                            .SetCode("CystComplex")
                            .SetDisplay("Cyst complex")
                            .MammoId("61")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedCode("61",
                                "449837001")
                            .SetSnomedDescription("61",
                                "ClinicalFinding | Complex cyst of breast (Disorder)")
                            .SetUMLS("61",
                                "Complex cysts have irregular or scalloped borders, ",
                                "thick walls, and some evidence ",
                                "of solid areas and/or debris in the fluid. ",
                                "These solid areas echo back the sound waves from ",
                                "the ultrasound. ",
                                "A complex cyst is sometimes aspirated, or drained ",
                                "with a fine needle, so that the ",
                                "fluid inside can be tested. ",
                                "If blood or any unusual cells are present, further ",
                                "testing may be needed to rule ",
                                "out breast cancer. ",
                                "###URL#https://www.breastcancer.org/symptoms/benign/cysts")
                        ,
                        new ConceptDef()
                            .SetCode("CystComplicated")
                            .SetDisplay("Cyst complicated")
                            .MammoId("115")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("115",
                                "Complicated cysts are \"in between\" simple and complex. ",
                                "Although they share most of the features of simple ",
                                "cysts, they tend to have some ",
                                "debris inside them and echo back some of the ultrasound ",
                                "waves. ",
                                "However, they don't have the thick walls or obvious ",
                                "solid components that a complex ",
                                "cyst has. ",
                                "###URL#https://www.breastcancer.org/symptoms/benign/cysts")
                        ,
                        new ConceptDef()
                            .SetCode("CystOil")
                            .SetDisplay("Cyst oil")
                            .MammoId("582")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("582",
                                "Oil cysts are filled with fluid that may feel smooth ",
                                "and squishy. ",
                                "Oil cysts are caused by the breakdown of fatty tissue.")
                        ,
                        new ConceptDef()
                            .SetCode("CystSebaceous")
                            .SetDisplay("Cyst sebaceous")
                            .MammoId("501")
                            .ValidModalities(Modalities.US)
                            .SetSnomedCode("501",
                                "76649007")
                            .SetSnomedDescription("501",
                                "ClinicalFinding | Sebaceous cyst of skin of breast ",
                                "(Disorder)")
                            .SetUMLS("501",
                                "Sebaceous cysts are common noncancerous cysts of ",
                                "the skin. ",
                                "Cysts are abnormalities in the body that may contain ",
                                "liquid or semiliquid material. ",
                                "Sebaceous cysts are mostly found on the face, neck, ",
                                "or torso. ",
                                "They grow slowly and aren't life-threatening, but ",
                                "they may become uncomfortable if ",
                                "they go unchecked. ",
                                "www.healthline.com > health > sebaceous-cyst")
                        ,
                        new ConceptDef()
                            .SetCode("CystSimple")
                            .SetDisplay("Cyst simple")
                            .MammoId("60")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedCode("60",
                                "399253005")
                            .SetSnomedDescription("60",
                                "ClinicalFinding | Simple cyst of breast (Disorder)")
                            .SetUMLS("60",
                                "Simple cysts have smooth, thin, regularly shaped ",
                                "walls and are completely filled ",
                                "with fluid. ",
                                "The sound waves sent out by the ultrasound test pass ",
                                "right through them, indicating ",
                                "there are no solid areas. ",
                                "Simple cysts are always benign. ",
                                "###URL#https://www.breastcancer.org/symptoms/benign/cysts")
                        ,
                        new ConceptDef()
                            .SetCode("CystsComplex")
                            .SetDisplay("Cysts complex")
                            .MammoId("537")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedCode("537",
                                "449837001")
                            .SetSnomedDescription("537",
                                "ClinicalFinding | Complex cyst of breast (Disorder)")
                            .SetUMLS("537",
                                "Complex cysts have irregular or scalloped borders, ",
                                "thick walls, and some evidence ",
                                "of solid areas and/or debris in the fluid. ",
                                "These solid areas echo back the sound waves from ",
                                "the ultrasound. ",
                                "A complex cyst is sometimes aspirated, or drained ",
                                "with a fine needle, so that the ",
                                "fluid inside can be tested. ",
                                "If blood or any unusual cells are present, further ",
                                "testing may be needed to rule ",
                                "out breast cancer. ",
                                "###URL#https://www.breastcancer.org/symptoms/benign/cysts")
                        ,
                        new ConceptDef()
                            .SetCode("CystsComplicated")
                            .SetDisplay("Cysts complicated")
                            .MammoId("506")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("506",
                                "Complicated cysts are \"in between\" simple and complex. ",
                                "Although they share most of the features of simple ",
                                "cysts, they tend to have some ",
                                "debris inside them and echo back some of the ultrasound ",
                                "waves. ",
                                "However, they don't have the thick walls or obvious ",
                                "solid components that a complex ",
                                "cyst has. ",
                                "###URL#https://www.breastcancer.org/symptoms/benign/cysts")
                        ,
                        new ConceptDef()
                            .SetCode("CystsMicroClustered")
                            .SetDisplay("Cysts micro clustered")
                            .MammoId("505")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("505",
                                "Microcysts are tiny, microscopic cysts. ",
                                "Clustered microcysts are a cluster of these tiny ",
                                "cysts and only have fluid inside ",
                                "of them.")
                        ,
                        new ConceptDef()
                            .SetCode("DCIS")
                            .SetDisplay("DCIS")
                            .MammoId("514")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("514",
                                "BodyStructure | 399935008 | Ductal carcinoma in situ ",
                                "- category (Morphologic-Abnormality)")
                            .SetUMLS("514",
                                "Ductal carcinoma in situ (DCIS) is the presence of ",
                                "abnormal cells inside a milk duct ",
                                "in the breast. ",
                                "DCIS is considered the earliest form of breast cancer. ",
                                "DCIS is noninvasive, meaning it hasn't spread out ",
                                "of the milk duct and has a low ",
                                "risk of becoming invasive. ",
                                "###URL#https://www.mayoclinic.org/diseases-conditions/dcis/symptoms-causes/syc-20371889")
                        ,
                        new ConceptDef()
                            .SetCode("Debris")
                            .SetDisplay("Debris")
                            .MammoId("515")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("515",
                                "Debris is a substance that is anything other than ",
                                "a liquid inside of the cyst.")
                        ,
                        new ConceptDef()
                            .SetCode("Deodorant")
                            .SetDisplay("Deodorant")
                            .MammoId("589")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("589",
                                "39432004")
                            .SetSnomedDescription("589",
                                "PharmaceuticalBiologicProduct | Deodorant (Product)")
                            .SetUMLS("589",
                                "Because estrogen can promote the growth of breast ",
                                "cancer cells, some scientists have ",
                                "suggested that the aluminum-based compounds in antiperspirants ",
                                "may contribute to ",
                                "the development of breast cancer. ",
                                "In addition, it has been suggested that aluminum ",
                                "may have direct activity in breast ",
                                "tissue.",
                                "###URL#https://www.cancer.gov/about-cancer/causes-prevention/risk/myths/antiperspirants-fact-sheet")
                        ,
                        new ConceptDef()
                            .SetCode("DermalCalcification")
                            .SetDisplay("Dermal calcification")
                            .MammoId("572")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("572",
                                "Skin calcifications in the breast usually form in ",
                                "dermal sweat glands after low grade ",
                                "folliculitis and inspissation of sebaceous material. ",
                                "Calcifications may also form in moles and other skin ",
                                "lesions. ",
                                "Often, these calcifications are in groups as they ",
                                "extend into small glands in the ",
                                "skin. ",
                                "###URL#https://radiopaedia.org/articles/skin-calcification-in-breast?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("DuctEctasia")
                            .SetDisplay("Duct ectasia")
                            .MammoId("64")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("64",
                                "ClinicalFinding | 22049009 | Mammary duct ectasia ",
                                "(Disorder) | [0/0] | N60.49")
                            .SetUMLS("64",
                                "An abnormal dilation of a duct by lipids and cellular ",
                                "debris. ",
                                "In  mammary duct the condition, which tends mainly ",
                                "to affect postmenopausal women, ",
                                "may be accompanied by inflammation and infiltration ",
                                "by plasma cells. ",
                                "###URL#https://www.hoafredericksburg.com/duct-ectasia/")
                        ,
                        new ConceptDef()
                            .SetCode("Edema")
                            .SetDisplay("Edema")
                            .MammoId("513")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedCode("513",
                                "290077003")
                            .SetSnomedDescription("513",
                                "ClinicalFinding | Edema of breast (Finding)")
                            .SetUMLS("513",
                                "Breast edema is defined as a mammographic pattern ",
                                "of skin thickening, increased parenchymal ",
                                "density, and interstitial marking. ",
                                "It can be caused by benign or malignant diseases, ",
                                "as a result of a tumor in the dermal ",
                                "lymphatics of the breast, lymphatic congestion caused ",
                                "by breast, lymphatic drainage ",
                                "obstruction, or by congestive heart failure. ",
                                "###URL#https://www.researchgate.net/publication/7988898_Unilateral_Breast_Edema_Spectrum_of_Etiologies_and_Imaging_Appearances")
                        ,
                        new ConceptDef()
                            .SetCode("FatLobule")
                            .SetDisplay("Fat lobule")
                            .MammoId("523")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("523",
                                "no direct match possible fat necrosis?")
                            .SetUMLS("523",
                                "Fat Lobule. ",
                                "The normal breast is composed of numerous fat lobules ",
                                "mixed with dense fibroglandular ",
                                "tissue. ",
                                "Fat lobule in breast. ",
                                "Yes. ",
                                "Breast tissue is composed of functional elements ",
                                "(glands and ducts) as well as structural ",
                                "elements (connective tissue and vessels). ",
                                "The connective tissue (or stroma) in the breast is ",
                                "composed of various proportions ",
                                "of fat and fibrous tissue.")
                        ,
                        new ConceptDef()
                            .SetCode("FatNecrosis")
                            .SetDisplay("Fat necrosis")
                            .MammoId("509")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("509",
                                "21381006")
                            .SetSnomedDescription("509",
                                "ClinicalFinding | Fat necrosis of breast (Disorder)")
                            .SetUMLS("509",
                                "Breasts are made up of lobules (milk-producing glands) ",
                                "and ducts (tubes that carry ",
                                "milk to the nipple). ",
                                "These are surrounded by glandular, fibrous and fatty ",
                                "tissue. ",
                                "Sometimes a lump can form if an area of the fatty ",
                                "breast tissue is damaged. ",
                                "This is called fat necrosis (necrosis is a medical ",
                                "term used to describe damaged ",
                                "or dead tissue). ",
                                "###URL#https://breastcancernow.org/information-support/have-i-got-breast-cancer/breast-pain-other-benign-conditions/fat-necrosis")
                        ,
                        new ConceptDef()
                            .SetCode("Fibroadenolipoma")
                            .SetDisplay("Fibroadenolipoma")
                            .MammoId("500")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("500",
                                "Another name for Hamartomas, Hamartomas represent ",
                                "benign proliferation of fibrous, ",
                                "glandular, and fatty tissue (hence fibro-adeno-lipoma) ",
                                "surrounded by a thin capsule ",
                                "of connective tissue. ",
                                "All components are found in normal breast tissue, ",
                                "which is why the lesions are considered ",
                                "hamartomatous. ",
                                "###URL#https://radiopaedia.org/articles/breast-hamartoma?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("Fibroadenoma")
                            .SetDisplay("Fibroadenoma")
                            .MammoId("81")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("81",
                                "Fibroadenomas are common benign (non-cancerous) breast ",
                                "tumors made up of both glandular ",
                                "tissue and stromal (connective) tissue. ",
                                "Fibroadenomas are most common in women in their 20s ",
                                "and 30s, but they can be found ",
                                "in women of any age. ",
                                "They tend to shrink after a woman goes through menopause. ",
                                "###URL#https://www.cancer.org/cancer/breast-cancer/non-cancerous-breast-conditions/fibroadenomas-of-the-breast.html")
                        ,
                        new ConceptDef()
                            .SetCode("FibroadenomaDegenerating")
                            .SetDisplay("Fibroadenoma degenerating")
                            .MammoId("587")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("587",
                                "These are non-cancerous breast lumps. ",
                                "Fibroadenomas usually go away with age. ",
                                "By the time an individual is menopausal, Fibroadenomas ",
                                "degenerate.")
                        ,
                        new ConceptDef()
                            .SetCode("FibrocysticChange")
                            .SetDisplay("Fibrocystic change")
                            .MammoId("538")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("538",
                                "367647000")
                            .SetSnomedDescription("538",
                                "BodyStructure | Fibrocystic change")
                            .SetUMLS("538",
                                "Fibrocystic breast changes lead to the development ",
                                "of fluid-filled round or oval ",
                                "sacs (cysts) and more prominent scar-like (fibrous) ",
                                "tissue, which can make breasts ",
                                "feel tender, lumpy or ropy. ",
                                "Fibrocystic breasts are composed of tissue that feels ",
                                "lumpy or rope-like in texture. ",
                                "This is called nodular or glandular breast tissue. ",
                                "###URL#https://www.mayoclinic.org/diseases-conditions/fibrocystic-breasts/symptoms-causes/syc-20350438")
                        ,
                        new ConceptDef()
                            .SetCode("FibroglandularTissue")
                            .SetDisplay("Fibroglandular tissue")
                            .MammoId("94")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("94",
                                "Fibrocystic breast changes lead to the development ",
                                "of fluid-filled round or oval ",
                                "sacs (cysts) and more prominent scar-like (fibrous) ",
                                "tissue, which can make breasts ",
                                "feel tender, lumpy or ropy. ",
                                "Fibrocystic breasts are composed of tissue that feels ",
                                "lumpy or rope-like in texture. ",
                                "This is called nodular or glandular breast tissue. ",
                                "###URL#https://www.mayoclinic.org/diseases-conditions/fibrocystic-breasts/symptoms-causes/syc-20350438")
                        ,
                        new ConceptDef()
                            .SetCode("Fibrosis")
                            .SetDisplay("Fibrosis")
                            .MammoId("578")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("578",
                                "???????????")
                            .SetUMLS("578",
                                "Fibrosis may refer to the connective tissue deposition ",
                                "that occurs as part of normal ",
                                "healing or to the excess tissue deposition that occurs ",
                                "as a pathological process. ",
                                "When fibrosis occurs in response to injury, the term ",
                                "\"scarring\" is used. ",
                                "###URL#https://www.news-medical.net/health/What-is-Fibrosis.aspx")
                        ,
                        new ConceptDef()
                            .SetCode("FibrousRidge")
                            .SetDisplay("Fibrous ridge")
                            .MammoId("914")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("914",
                                "Fibrous tissue, which extends under the skin, from ",
                                "the front of the breast to the ",
                                "back of the chest wall, supports the breast and gives ",
                                "it shape. ",
                                "Strands of supportive tissue surround the breast ",
                                "and form a prominent ridge called ",
                                "the inframammary ridge. ",
                                "###URL#https://www.stjoeshealth.org/find-a-service-or-specialty/womens-health/")
                        ,
                        new ConceptDef()
                            .SetCode("Folliculitis")
                            .SetDisplay("Folliculitis")
                            .MammoId("562")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("562",
                                "ClinicalFinding | 13600006 | Folliculitis (Disorder) ",
                                "| [6/113] | L73.9")
                            .SetUMLS("562",
                                "Folliculitis is the inflammation of hair follicles ",
                                "due to an infection, injury, or ",
                                "irritation. ",
                                "It is characterized by tender, swollen areas that ",
                                "form around hair follicles, often ",
                                "on the neck, breasts, buttocks, and face. ",
                                "Boils (also referred to as furuncles) are pus-filled ",
                                "lesions that are painful and ",
                                "usually firm. ",
                                "###URL#https://www.hopkinsmedicine.org/health/conditions-and-diseases/folliculitis-boils-and-carbuncles")
                        ,
                        new ConceptDef()
                            .SetCode("Gynecomastia")
                            .SetDisplay("Gynecomastia")
                            .MammoId("759")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("759",
                                "Gynecomastia is an enlargement or swelling of breast ",
                                "tissue in males. ",
                                "It is most commonly caused by male estrogen levels ",
                                "that are too high or are out of ",
                                "balance with testosterone levels. ",
                                "###URL#https://my.clevelandclinic.org/health/diseases/16227-enlarged-male-breast-tissue-gynecomastia")
                        ,
                        new ConceptDef()
                            .SetCode("Hamartoma")
                            .SetDisplay("Hamartoma")
                            .MammoId("552.544")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("552.544",
                                "51398009")
                            .SetSnomedDescription("552.544",
                                "BodyStructure | Hamartoma (Morphologic-Abnormality)")
                            .SetUMLS("552.544",
                                "A benign (not cancer) growth made up of an abnormal ",
                                "mixture of cells and tissues ",
                                "normally found in the area of the body where the ",
                                "growth occurs. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/hamartoma")
                        ,
                        new ConceptDef()
                            .SetCode("Hematoma")
                            .SetDisplay("Hematoma")
                            .MammoId("112")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("112",
                                "302924003")
                            .SetSnomedDescription("112",
                                "ClinicalFinding | Breast hematoma (Disorder) | N64.89")
                            .SetUMLS("112",
                                "A breast hematoma is a collection of blood that forms ",
                                "under the skin's surface. ",
                                "It's not unlike having a large bruise in your breast. ",
                                "The mass it forms is not cancerous, but it can sometimes ",
                                "lead to inflammation, fever, ",
                                "skin discoloration, and may leave behind scar tissue ",
                                "that mimics the shape of a breast ",
                                "tumor. ",
                                "###URL#https://www.verywellhealth.com/breast-hematomas-430281")
                        ,
                        new ConceptDef()
                            .SetCode("HormonalStimulation")
                            .SetDisplay("Hormonal stimulation")
                            .MammoId("539")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("539",
                                "Hormonal effects of certain medications including ",
                                "antihypertensives, antidepressants, ",
                                "H2 blockers,",
                                "illicit drugs, and endocrine active tumors stimulate ",
                                "development of rudimentary breast ",
                                "tissue. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("IntracysticLesion")
                            .SetDisplay("Intracystic lesion")
                            .MammoId("62")
                            .ValidModalities(Modalities.NM | Modalities.US)
                            .SetUMLS("62",
                                "Intracystic tumors of the breast are uncommon and, ",
                                "at the time of ultrasonography ",
                                "and aspiration cytology, it is difficult to distinguish ",
                                "cancer from a benign tumor. ",
                                "###URL#https://www.ncbi.nlm.nih.gov/pubmed/11911303")
                        ,
                        new ConceptDef()
                            .SetCode("IntramammaryNode")
                            .SetDisplay("Intramammary node")
                            .MammoId("566,941")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("566,941",
                                "BodyStructure | 443159006 | Intramammary lymph node ",
                                "group (Bodypart)")
                            .SetUMLS("566,941",
                                "These are lymph  nodes within the breast tissue. ",
                                "They are generally 1 cm or smaller",
                                "in size. ",
                                "They frequently occur in the lateral and usually ",
                                "upper portions of the breast closer ",
                                "to the",
                                "axilla (armpit area), although they may occur anywhere ",
                                "in the breast. ",
                                "They usually are seen adjacent to a vein, because ",
                                "the lymphatic drainage of the breast ",
                                "parallels the venous drainage. ",
                                "###ACRUS#")
                        ,
                        new ConceptDef()
                            .SetCode("Lipoma")
                            .SetDisplay("Lipoma")
                            .MammoId("508")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("508",
                                "276891009")
                            .SetSnomedDescription("508",
                                "ClinicalFinding | Lipoma of breast (Disorder)")
                            .SetUMLS("508",
                                "A lipoma is a slow-growing, fatty lump that's most ",
                                "often situated between the skin ",
                                "and the underlying muscle layer. ",
                                "A lipoma, which feels doughy and usually isn't tender, ",
                                "moves readily with slight ",
                                "finger pressure. ",
                                "Lipomas are usually detected in middle age. ",
                                "Some people have more than one lipoma.A lipoma isn't ",
                                "cancer and usually is harmless. ",
                                "www.mayoclinic.org > lipoma > symptoms-causes > syc-20374470")
                        ,
                        new ConceptDef()
                            .SetCode("LumpectomyCavity")
                            .SetDisplay("Lumpectomy cavity")
                            .MammoId("512")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("512",
                                "BodyStructure | 261719000 | Breast cavity (Morphologic-Abnormality)")
                            .SetUMLS("512",
                                "With a lumpectomy, the surgeon removes only the tumor ",
                                "and a small amount of normal ",
                                "surrounding tissue. ",
                                "The cavity is the hollow area or hole left behind ",
                                "after the tumor and surrounding ",
                                "tissue is removed.")
                        ,
                        new ConceptDef()
                            .SetCode("LumpectomySite")
                            .SetDisplay("Lumpectomy site")
                            .MammoId("564")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedDescription("564",
                                "BodyStructure | 261719000 | Breast cavity (Morphologic-Abnormality)")
                            .SetUMLS("564",
                                "The area of the breast where the incision is made ",
                                "during the lumpectomy.")
                        ,
                        new ConceptDef()
                            .SetCode("LymphNode")
                            .SetDisplay("Lymph node")
                            .MammoId("74")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("74",
                                "A small bean-shaped structure that is part of the ",
                                "body's immune system. ",
                                "Lymph nodes filter substances that travel through ",
                                "the lymphatic fluid, and they contain ",
                                "lymphocytes (white blood cells) that help the body ",
                                "fight infection and disease. ",
                                "There are hundreds of lymph nodes found throughout ",
                                "the body. ",
                                "They are connected to one another by lymph vessels. ",
                                "Clusters of lymph nodes are found in the neck, axilla ",
                                "(underarm), chest, abdomen, ",
                                "and groin. ",
                                "For example, there are about 20-40 lymph nodes in ",
                                "the axilla. ",
                                "Also called lymph gland. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/lymph-node")
                        ,
                        new ConceptDef()
                            .SetCode("LymphNodeEnlarged")
                            .SetDisplay("Lymph node enlarged")
                            .MammoId("541.588")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedCode("541.588",
                                "274741002")
                            .SetSnomedDescription("541.588",
                                "ClinicalFinding | Generalized enlarged lymph nodes ",
                                "(Disorder) | [0/0] | R59.1")
                            .SetUMLS("541.588",
                                "Enlarged or swollen lymph nodes usually indicate ",
                                "a common infection, but can ",
                                "also signal a medical condition, such as an immune ",
                                "disorder or, rarely, a type of ",
                                "cancer. ",
                                "Lymph nodes are small, round structures that play ",
                                "a vital role in the body's immune ",
                                "system. ",
                                "Swollen lymph nodes are also known as swollen glands.")
                        ,
                        new ConceptDef()
                            .SetCode("LymphNodeNormal")
                            .SetDisplay("Lymph node normal")
                            .MammoId("907")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("907",
                                "Lymph nodes filter substances that travel through ",
                                "the lymphatic fluid, and they contain ",
                                "lymphocytes (white blood cells) that help the body ",
                                "fight infection and disease. ",
                                "There are hundreds of lymph nodes found throughout ",
                                "the body. ",
                                " The lymph nodes are connected to one another by ",
                                "lymph vessels. ",
                                "Clusters of lymph nodes are found in the neck, axilla ",
                                "(underarm), chest, abdomen, ",
                                "and groin. ",
                                "A normal sized lymph node is about pea-sized or bean-sized ",
                                "(or smaller than 1/2 inch ",
                                "or 12mm).")
                        ,
                        new ConceptDef()
                            .SetCode("LymphNodePathological")
                            .SetDisplay("Lymph node pathological")
                            .MammoId("540")
                            .ValidModalities(Modalities.MRI)
                            .SetUMLS("540",
                                "Lymphadenopathy (or adenopathy) is, if anything, ",
                                "a broader term, referring to any ",
                                "pathology of lymph nodes, not necessarily resulting ",
                                "in increased size; this includes ",
                                "abnormal number of nodes, or derangement of internal ",
                                "architecture (e.g. ",
                                "cystic or necrotic nodes). ",
                                "###URL#https://radiopaedia.org/articles/lymph-node-enlargement?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("MassSolid")
                            .SetDisplay("Mass solid")
                            .MammoId("63")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("63",
                                "An abnormal mass of tissue that usually does not ",
                                "contain cysts or liquid areas. ",
                                "Solid masses or tumors may be benign (not cancer), ",
                                "or malignant (cancer). ",
                                "Different types of solid mass/ tumors are named for ",
                                "the type of cells that form them. ",
                                "Examples of solid tumors are sarcomas, carcinomas, ",
                                "and lymphomas. ",
                                "Leukemias (cancer of the blood) generally do not ",
                                "form solid mass/tumors. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/solid-tumor")
                        ,
                        new ConceptDef()
                            .SetCode("MassSolidW/tumorVasc")
                            .SetDisplay("Mass solid w/tumor vasc")
                            .MammoId("550")
                            .ValidModalities(Modalities.MRI)
                            .SetUMLS("550",
                                "An abnormal mass of tissue that usually does not ",
                                "contain cysts or liquid areas. ",
                                "Solid masses or tumors may be benign (not cancer), ",
                                "or malignant (cancer). ",
                                "Different types of solid mass/ tumors are named for ",
                                "the type of cells that form them. ",
                                "Examples of solid tumors are sarcomas, carcinomas, ",
                                "and lymphomas. ",
                                "Leukemias (cancer of the blood) generally do not ",
                                "form solid mass/tumors. ",
                                "A vascular tumor is a type of tumor that forms from ",
                                "cells that make blood vessels ",
                                "or lymph vessels. ",
                                "Vascular tumors may be benign (not cancer) or malignant ",
                                "(cancer) and can occur anywhere ",
                                "in the body. ",
                                "They may form on the skin, in the tissues below the ",
                                "skin, and/or in an organ. ",
                                "There are many types of vascular tumors. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/solid-tumor ",
                                "https://www.cancer.gov/publications/dictionaries/cancer-terms/def/vascular-tumor")
                        ,
                        new ConceptDef()
                            .SetCode("Mastitis")
                            .SetDisplay("Mastitis")
                            .MammoId("524")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("524",
                                "ClinicalFinding | 45198002 | Mastitis (Disorder) ",
                                "| [3/51] | P39.0 | Neonatal infective mastitis | ",
                                "N61 | Inflammatory disorders of breast |")
                            .SetUMLS("524",
                                "Infection of the breast tissue resulting in pain, ",
                                "swelling, warmth and redness.")
                        ,
                        new ConceptDef()
                            .SetCode("MilkOfCalcium")
                            .SetDisplay("Milk of calcium")
                            .MammoId("571")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("571",
                                "F-01765")
                            .SetSnomedCode("571",
                                "129753004")
                            .SetSnomedDescription("571",
                                "ClinicalFinding | 129753004 | Milk of calcium radiographic ",
                                "calcification (Finding)")
                            .SetUMLS("571",
                                "The term milk of calcium (MOC) is given to dependent, ",
                                "sedimented calcification within ",
                                "a cystic structure or hollow organ. ",
                                "This sort of colloidal calcium suspension layering ",
                                "can occur in various regions. ",
                                "###URL#https://radiopaedia.org/articles/milk-of-calcium-disambiguation?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("Multi-focalCancer")
                            .SetDisplay("Multi-focal cancer")
                            .MammoId("944")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("944",
                                "Multifocal breast cancer occurs when there are two ",
                                "or more tumors in the same breast. ",
                                "All of the tumors begin in one original tumor. ",
                                "The tumors are also all in the same quadrant - or ",
                                "section - of the breast. ",
                                "###URL#https://www.healthline.com/health/breast-cancer/multifocal-breast-cancer")
                        ,
                        new ConceptDef()
                            .SetCode("PapillaryLesion")
                            .SetDisplay("Papillary lesion")
                            .MammoId("563")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("563",
                                "need help")
                            .SetUMLS("563",
                                "Breast papillary lesions are characterised by growth ",
                                "inside the milk ducts, and they ",
                                "represent a heterogeneous pathology. ",
                                "They are rare and constitute less than 10% of benign ",
                                "breast lesions and less than ",
                                "1% of malignant breast neoplasms. ",
                                "Breast papillary lesions are usually detected by ",
                                "imaging or clinically by the presence ",
                                "of a palpable breast mass or unilateral spontaneous ",
                                "nipple discharge. ",
                                "###URL#https://ecancer.org/es/journal/article/461-breast-papillary-lesions-an-analysis-of-70-cases")
                        ,
                        new ConceptDef()
                            .SetCode("Papilloma")
                            .SetDisplay("Papilloma")
                            .MammoId("507")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("507",
                                "99571000119102")
                            .SetSnomedDescription("507",
                                "ClinicalFinding | Papilloma of breast (Disorder)")
                            .SetUMLS("507",
                                "Intraductal papillomas are benign (non-cancerous), ",
                                "wart-like tumors that grow within ",
                                "the milk ducts of the breast. ",
                                "They are made up of gland tissue along with fibrous ",
                                "tissue and blood vessels (called ",
                                "fibrovascular tissue). ",
                                "###URL#https://www.cancer.org/cancer/breast-cancer/non-cancerous-breast-conditions/intraductal-papillomas.html")
                        ,
                        new ConceptDef()
                            .SetCode("PhyllodesTumor")
                            .SetDisplay("Phyllodes tumor")
                            .MammoId("560")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("560",
                                "ClinicalFinding | 712989008 | Phyllodes tumor of ",
                                "breast (Disorder) | D48.6 |")
                            .SetUMLS("560",
                                "Phyllodes tumors of the breast are rare, accounting ",
                                "for less than 1% of all breast ",
                                "tumors. ",
                                "The name \"phyllodes,\" which is taken from the Greek ",
                                "language and means \"leaflike,\" refers ",
                                "to that fact that the tumor cells grow in a leaflike ",
                                "pattern. ",
                                "Other names for these tumors are phylloides tumor ",
                                "and cystosarcoma phyllodes. ",
                                "Phyllodes tumors tend to grow quickly, but they rarely ",
                                "spread outside the breast.",
                                "Although most phyllodes tumors are benign (not cancerous), ",
                                "some are malignant (cancerous) ",
                                "and some are borderline (in between noncancerous ",
                                "and cancerous). ",
                                "All three kinds of phyllodes tumors tend to grow ",
                                "quickly, and they require surgery ",
                                "to reduce the risk of a phyllodes tumor coming back ",
                                "in the breast (local recurrence). ",
                                "###URL#https://www.breastcancer.org/symptoms/types/phyllodes")
                        ,
                        new ConceptDef()
                            .SetCode("PostLumpectomyScar")
                            .SetDisplay("Post lumpectomy scar")
                            .MammoId("590")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("590",
                                "BodyStructure | 63130001 | Surgical scar (Morphologic-Abnormality)")
                            .SetUMLS("590",
                                "This is scarring that occurs from the lumpectomy ",
                                "site. ",
                                "It can include nerve pain or numbness if scar tissue ",
                                "forms around nerves.",
                                "A lump of scar tissue forms in the hole left after ",
                                "breast tissue is removed. ",
                                "If scar tissue forms around a stitch from surgery ",
                                "it's called a suture granuloma ",
                                "and also feels like a lump.",
                                "Changes in breast appearance. ",
                                "Scar tissue and fluid retention can make breast tissue ",
                                "appear a little firmer or ",
                                "rounder than before surgery and/or radiation. ",
                                "###URL#https://www.breastcancer.org/treatment/side_effects/scar_tissue")
                        ,
                        new ConceptDef()
                            .SetCode("PostSurgicalScar")
                            .SetDisplay("Post surgical scar")
                            .MammoId("567.943")
                            .ValidModalities(Modalities.MG | Modalities.NM)
                            .SetSnomedDescription("567.943",
                                "BodyStructure | 63130001 | Surgical scar (Morphologic-Abnormality)")
                            .SetUMLS("567.943",
                                "Post surgical scarring happens because of the incisions ",
                                "needed to surgically remove ",
                                "tumor, cells, etc. ",
                                "The amount of scarring is connected to the different ",
                                "stages of wound healing. ",
                                "Surgical scar care should be continued for a year.")
                        ,
                        new ConceptDef()
                            .SetCode("PreviousBiopsy")
                            .SetDisplay("Previous biopsy")
                            .MammoId("584")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("584",
                                "Findings on mammogram are  consistent with previous ",
                                "biopsy.")
                        ,
                        new ConceptDef()
                            .SetCode("PreviousSurgery")
                            .SetDisplay("Previous surgery")
                            .MammoId("585")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("585",
                                "Findings on mammogram are consistent with previous ",
                                "surgery.")
                        ,
                        new ConceptDef()
                            .SetCode("PreviousTrauma")
                            .SetDisplay("Previous trauma")
                            .MammoId("586")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("586",
                                "ClinicalFinding | 62112002 | Injury of breast (Disorder) ",
                                "| [4/41] | S29.9XX?")
                            .SetUMLS("586",
                                "Findings on mammogram are consistent with previous ",
                                "trauma to breast.")
                        ,
                        new ConceptDef()
                            .SetCode("RadialScar")
                            .SetDisplay("Radial scar")
                            .MammoId("568")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedCode("568",
                                "390787006")
                            .SetSnomedDescription("568",
                                "ClinicalFinding | Radial scar of breast (Finding)")
                            .SetUMLS("568",
                                "Radial scar is a growth that looks like a scar when ",
                                "the tissue is viewed under a ",
                                "microscope. ",
                                "It has a central core containing benign ducts. ",
                                "Growing out of this core are ducts and lobules that ",
                                "show evidence of unusual changes ",
                                "such as cysts and epithelial hyperplasia (overgrowth ",
                                "of their inner lining). ",
                                "Often, more than one radial scar is present. ",
                                "Another term for this condition is complex sclerosing ",
                                "lesions. ",
                                "###URL#https://www.breastcancer.org/symptoms/benign/radial-scars")
                        ,
                        new ConceptDef()
                            .SetCode("RadiationChanges")
                            .SetDisplay("Radiation changes")
                            .MammoId("548")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedCode("548",
                                "143501000119107")
                            .SetSnomedDescription("548",
                                "SituationWithExplicitContext  | History of radiation ",
                                "therapy to breast area (Situation)")
                            .SetUMLS("548",
                                "Radiation levels during radiation therapy may change ",
                                "as a result of side effects ",
                                "or to complete a more aggressive cancer treatment.")
                        ,
                        new ConceptDef()
                            .SetCode("RadiationTherapy")
                            .SetDisplay("Radiation therapy")
                            .MammoId("549")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedCode("549",
                                "429479009")
                            .SetSnomedDescription("549",
                                "SituationWithExplicitContext | History of radiation ",
                                "therapy (Situation)")
                            .SetUMLS("549",
                                "The use of high-energy radiation from x-rays, gamma ",
                                "rays, neutrons, protons, and ",
                                "other sources to kill cancer cells and shrink tumors. ",
                                "Radiation may come from a machine outside the body ",
                                "(external-beam radiation therapy), ",
                                "or it may come from radioactive material placed in ",
                                "the body near cancer cells (internal ",
                                "radiation therapy or brachytherapy). ",
                                "Systemic radiation therapy uses a radioactive substance, ",
                                "such as a radiolabeled monoclonal ",
                                "antibody, that travels in the blood to tissues throughout ",
                                "the body. ",
                                "Also called irradiation and radiotherapy. ",
                                "###URL#https://www.cancer.gov/publications/dictionaries/cancer-terms/def/44971")
                        ,
                        new ConceptDef()
                            .SetCode("Scar")
                            .SetDisplay("Scar")
                            .MammoId("502")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("502",
                                "Scar tissue forms as part of the healing process ",
                                "after a skin injury. ",
                                "A scar is fibrous tissue made of collagen that replaces ",
                                "the injured skin. ",
                                "###URL#https://www.breastcancer.org/treatment/side_effects/scar_tissue")
                        ,
                        new ConceptDef()
                            .SetCode("ScarWithShadowing")
                            .SetDisplay("Scar with shadowing")
                            .MammoId("113")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("113",
                                "In cases when the appropriate history is not available, ",
                                "a postsurgical scar may mimic ",
                                "a malignancy. ",
                                "At sonographic evaluation, an area of posterior acoustic ",
                                "shadowing may be seen. ",
                                " This lack of a central mass helps differentiate ",
                                "a scar from a carcinoma, which has ",
                                "shadowing arising from a central mass. ",
                                "onlinelibrary.wiley.com > doi > full > jum.2004.23.1.73")
                        ,
                        new ConceptDef()
                            .SetCode("SclerosingAdenosis")
                            .SetDisplay("Sclerosing adenosis")
                            .MammoId("599")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("599",
                                "Sclerosing adenosis is a type of adenosis in which ",
                                "enlarged acini become slightly ",
                                "distorted by surrounded stromal fibrosis (\"sclerosis\"). ",
                                "The normal lobular architecture of the breast is ",
                                "maintained, but becomes exaggerated ",
                                "and distorted.")
                        ,
                        new ConceptDef()
                            .SetCode("SecretoryCalcification")
                            .SetDisplay("Secretory calcification")
                            .MammoId("570")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("570",
                                "??????????????")
                            .SetUMLS("570",
                                "Secretory calcifications are benign calcifications ",
                                "usually in women older than 60. ",
                                "They classically appear as solid or discontinuous, ",
                                "smooth, linear and rod-like calcifications. ",
                                "Usually bilateral and symmetric and may appear lucent-centered. ",
                                "Also known as plasma cell mastitis. ",
                                "###URL#https://radiopaedia.org/cases/secretory-calcifications?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("SentinelNode")
                            .SetDisplay("Sentinel node")
                            .MammoId("945")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("945",
                                "The sentinel nodes are the first few lymph nodes ",
                                "into which a tumor drains. ",
                                "Sentinel node biopsy involves injecting a tracer ",
                                "material that helps the surgeon ",
                                "locate the sentinel nodes during surgery. ",
                                "The sentinel nodes are removed and analyzed in a ",
                                "laboratory. ",
                                "###URL#https://www.mayoclinic.org/tests-procedures/sentinel-node-biopsy/about/pac-20385264")
                        ,
                        new ConceptDef()
                            .SetCode("Seroma")
                            .SetDisplay("Seroma")
                            .MammoId("511.576")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("511.576",
                                "297178008")
                            .SetSnomedDescription("511.576",
                                "ClinicalFinding | Breast seroma (Disorder)")
                            .SetUMLS("511.576",
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
                            .SetCode("SkinLesion")
                            .SetDisplay("Skin lesion")
                            .MammoId("583")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("583",
                                "126510002")
                            .SetSnomedDescription("583",
                                "ClinicalFinding | Neoplasm of skin of breast (Disorder)")
                            .SetUMLS("583",
                                "A skin lesion is a part of the skin that has an abnormal ",
                                "growth or appearance compared ",
                                "to the skin around it. ",
                                "Primary skin lesions are abnormal skin conditions ",
                                "present at birth or acquired over ",
                                "a person's lifetime. ",
                                "Secondary skin lesions are the result of irritated ",
                                "or manipulated primary skin lesions. ",
                                "###URL#https://www.healthline.com/health/skin-lesions")
                        ,
                        new ConceptDef()
                            .SetCode("Surgery")
                            .SetDisplay("Surgery")
                            .MammoId("546")
                            .ValidModalities(Modalities.MRI)
                            .SetUMLS("546",
                                "The branch of medicine that employs operations in ",
                                "the treatment of disease or injury. ",
                                "Surgery can involve cutting, abrading, suturing, ",
                                "or otherwise physically changing ",
                                "body tissues and organs. ",
                                "###URL#https://www.medicinenet.com/script/main/art.asp?articlekey=5603")
                        ,
                        new ConceptDef()
                            .SetCode("Trauma")
                            .SetDisplay("Trauma")
                            .MammoId("547")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedDescription("547",
                                "ClinicalFinding | 62112002 | Injury of breast (Disorder)")
                            .SetUMLS("547",
                                "Previous injury to breast consistent with surgery, ",
                                "infection, etc.")
                        ,
                        new ConceptDef()
                            .SetCode("VascularCalcifications")
                            .SetDisplay("Vascular calcifications")
                            .MammoId("569")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("569",
                                "ClinicalFinding | 396779001 | Breast arterial calcification ",
                                "(Finding) | [0/0] | R92.1")
                            .SetUMLS("569",
                                "Parallel tracks, or linear tubular calcifications ",
                                "that are clearly associated with ",
                                "blood vessels.",
                                "While most vascular calcification is not difficult ",
                                "to identify, if only a few discontinuous ",
                                "calcific",
                                "particles are visible in a single location and if ",
                                "association with a tubular structure ",
                                "is questionable,",
                                "then additional spot-compression magnification views ",
                                "may be needed to further characterize",
                                "their nature. ",
                                "###ACRMG#38")
                        ,
                        new ConceptDef()
                            .SetCode("VenousStasis")
                            .SetDisplay("Venous stasis")
                            .MammoId("947")
                            .ValidModalities(Modalities.NM)
                            .SetSnomedDescription("947",
                                "ClinicalFinding | 71897006 | Venous stasis (Finding) ",
                                "| [0/0] | I87.8")
                            .SetUMLS("947",
                                "Venous stasis dermatitis happens when there's a problem ",
                                "with the veins, that keeps ",
                                "blood from moving through very well. ",
                                "As more fluid and pressure build, some of the blood ",
                                "leaks out of the veins and into ",
                                "the skin. ",
                                "###URL#https://www.webmd.com/skin-problems-and-treatments/eczema/venous-stasis-dermatitis#1")
                        #endregion // Codes
                        //- Codes
                    })
        );


        CSTaskVar ConsistentWithQualifierCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "ConsistentWithQualifierCS",
                    "ConsistentWith Qualifier CodeSystem",
                    "ConsistentWithQualifier/ValueSet",
                    "ConsistentWithQualifier  code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Qualifiers
                        #region Codes
                        new ConceptDef()
                            .SetCode("DifferentialDiagnosis")
                            .SetDisplay("Differential diagnosis")
                            .MammoId("561")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("561",
                                "More than one possibility for a diagnosis. ",
                                "The process of weighing the probability of one disease ",
                                "versus that of other diseases ",
                                "possibly accounting for a patient's illness.")
                        ,
                        new ConceptDef()
                            .SetCode("LikelyRepresents")
                            .SetDisplay("Likely represents")
                            .MammoId("536")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("536",
                                "Likely represents")
                        ,
                        new ConceptDef()
                            .SetCode("MostLikely")
                            .SetDisplay("Most likely")
                            .MammoId("581")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("581",
                                "Most likely")
                        ,
                        new ConceptDef()
                            .SetCode("Resembles")
                            .SetDisplay("Resembles")
                            .MammoId("580")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("580",
                                "Resembles")
                        #endregion // Codes
                        //- Qualifiers
                    })
        );
    }
}
