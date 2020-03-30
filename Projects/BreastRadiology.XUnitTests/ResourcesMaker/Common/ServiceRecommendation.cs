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
    partial class ResourcesMaker : ConverterBase
    {
        SDTaskVar ServiceRecommendation = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("ServiceRecommendation",
                            "Service Recommendation",
                            "Service/Recommendation",
                            Global.ServiceRequestUrl,
                            Group_BaseResources,
                            "Resource")
                        .Description("Service Recommendation",
                            new Markdown()
                                .Paragraph("Recommended follow-up action to be taken in response to the ",
                                           "findings of this exam.")
                                .Paragraph(
                                    "This resource is a profile of ServiceRequest. It's ServiceRequest.code is bound to a value set of common",
                                    "breast radiology recommendations. This list is not meant to be comprehensive, just commonly used items will",
                                    "will be included in the list.")
                                .Paragraph(
                                    "The Breast Radiology Report contains references to zero or more recommendations, which may include ServiceRecommendation instances",
                                    "but is not limited to only ServiceRecommendation instances.")
                        )
                        .AddFragRef(Self.HeaderFragment)
                    ;

                s = e.SDef;
                e.IntroDoc
                    .ReviewedStatus("KWA 3/19/10")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    ;
                {
                    ValueSet binding = Self.RecommendationsVS.Value();
                    ElementDefinition codeDef = e.Select("code").Binding(binding, BindingStrength.Extensible);

                    e.AddComponentLink("Service Recommendation Code",
                        new SDefEditor.Cardinality(codeDef),
                        null,
                        Global.ElementAnchor(codeDef),
                        "CodeableConcept",
                        binding.Url);
                }
            });

        VSTaskVar RecommendationsVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "RecommendationsVS",
                    "Recommendations ValueSet",
                    "Recommendations/ValueSet",
                    "Recommendations value set.",
                    Group_CommonCodesVS,
                    Self.RecommendationsCS.Value()
                )
        );

        CSTaskVar RecommendationsCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "RecommendationsCodeSystemCS",
                    "Recommendations CodeSystem",
                    "Recommendations/CodeSystem",
                    "Recommendations code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("3DImaging")
                            .SetDisplay("3D Imaging")
                            .MammoId("1828")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("1828",
                                "Procedure | 450566007 | Digital breast tomosynthesis ",
                                "(Procedure) +")
                            .SetUMLS("1828",
                                "Advanced Technology that takes multiple images, or ",
                                "X-rays, of breast tissue to recreate ",
                                "a 3-dimensional picture of the breast. ",
                                "Also called breast tomosynthesis.")
                        ,
                        new ConceptDef()
                            .SetCode("3DSpotCC")
                            .SetDisplay("3D spot CC")
                            .MammoId("1830")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("1830",
                                "Procedure | 450566007 | Digital breast tomosynthesis ",
                                "(Procedure) + QualifierValue | 399162004 | Cranio-caudal ",
                                "projection (Qualifier) + SPOT")
                            .SetUMLS("1830",
                                "Advanced Technology that takes multiple images, or ",
                                "X-rays, of breast tissue to recreate ",
                                "a 3-dimensional picture of the breast. ",
                                "Cranial-Caudal (CC) is a 3D view from above the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("3DSpotLM")
                            .SetDisplay("3D spot LM")
                            .MammoId("1833")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("1833",
                                "Procedure | 450566007 | Digital breast tomosynthesis ",
                                "(Procedure) + QualifierValue | 399352003 | Lateral-medial ",
                                "projection (Qualifier) + SPOT")
                            .SetUMLS("1833",
                                "Advanced Technology that takes multiple images, or ",
                                "X-rays, of breast tissue to recreate ",
                                "a 3-dimensional picture of the breast. ",
                                "Lateral-medial (LM) is")
                        ,
                        new ConceptDef()
                            .SetCode("3DSpotML")
                            .SetDisplay("3D spot ML")
                            .MammoId("1832")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("1832",
                                "Procedure | 450566007 | Digital breast tomosynthesis ",
                                "(Procedure) + QualifierValue | 399260004 | Medial-lateral ",
                                "projection (Qualifier) + SPOT")
                            .SetUMLS("1832",
                                "Advanced Technology that takes multiple images, or ",
                                "X-rays, of breast tissue to recreate ",
                                "a 3-dimensional picture of the breast. ",
                                "Mediolateral (ML) is")
                        ,
                        new ConceptDef()
                            .SetCode("3DSpotMLO")
                            .SetDisplay("3D spot MLO")
                            .MammoId("1831")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("1831",
                                "Procedure | 450566007 | Digital breast tomosynthesis ",
                                "(Procedure) + QualifierValue | 399368009 | Medio-lateral ",
                                "oblique projection (Qualifier) + SPOT")
                            .SetUMLS("1831",
                                "Advanced Technology that takes multiple images, or ",
                                "X-rays, of breast tissue to recreate ",
                                "a 3-dimensional picture of the breast. ",
                                "Mediolateral-oblique (MLO) is")
                        ,
                        new ConceptDef()
                            .SetCode("AdditionalViews")
                            .SetDisplay("Additional views")
                            .MammoId("68")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("68",
                                "Additional views in Mammography, MRI and US, help ",
                                "increase the chances of finding ",
                                "any possible tumors in the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("AddlitionalViewsWithPossibleUltrasound")
                            .SetDisplay("Addlitional views with possible ultrasound")
                            .MammoId("87")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("87",
                                "Procedure | 47079000 | Ultrasonography of breast ",
                                "(Procedure)")
                            .SetUMLS("87",
                                "Additional views in a Mammogram, MRI or Ultrasound ",
                                "are recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("AxillaView")
                            .SetDisplay("Axilla view")
                            .MammoId("1820")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("1820",
                                "An axillary view (also known as a \"Cleopatra view\") ",
                                "is a type of view in mammography. It is ",
                                "an exaggerated craniocaudal view for better imaging ",
                                "of the lateral portion of the ",
                                "breast to the axillary tail. ",
                                "This projection is performed whenever we want to ",
                                "show a lesion seen only in the axillary ",
                                "tail on the MLO view. ",
                                "An optimal axillary view require to be clearly displayed ",
                                "the most lateral portion ",
                                "of the breast including the axillary tail, as well ",
                                "the pectoral muscle and the nipple ",
                                "in profile. ",
                                "###URL#https://radiopaedia.org/articles/axillary-view?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("AxillaryTailView")
                            .SetDisplay("Axillary tail view")
                            .MammoId("45")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("45",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 442580003 | Axillary tissue mammography ",
                                "view (Qualifier)")
                            .SetUMLS("45",
                                "The tail of Spence (Spence's tail, axillary process, ",
                                "axillary tail) is an extension ",
                                "of the tissue of the breast that extends into the ",
                                "axilla. ",
                                "It is actually an extension of the upper lateral ",
                                "quadrant of the breast. ",
                                "It passes into the axilla through an opening in the ",
                                "deep fascia called foramen of ",
                                "Langer. ",
                                "###URL#https://en.wikipedia.org/wiki/Tail_of_Spence")
                        ,
                        new ConceptDef()
                            .SetCode("Biopsy")
                            .SetDisplay("Biopsy")
                            .MammoId("100")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("100",
                                "A biopsy is recommended. ",
                                "An examination under a microscope  of the specific ",
                                "tissue removed from the body. ",
                                "The examination is used to check for abnormalities ",
                                "or cancer cells.")
                        ,
                        new ConceptDef()
                            .SetCode("BiopsyBaseOnClinical")
                            .SetDisplay("Biopsy base on clinical")
                            .MammoId("52")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("52",
                                "Based on the clinical exam, a biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("CaudocranialView")
                            .SetDisplay("Caudocranial view")
                            .MammoId("46")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("46",
                                "It is recommended that a Caudocranial view is captured ",
                                "by Ultrasound and/or Mammogram. ",
                                "It is useful for the study of breasts in the lower ",
                                "quadrants. ",
                                "The patient will bend forward at the waist to view ",
                                "the underside of the breast. ",
                                "Also called a reverse CC view. ",
                                "The reversed CC view is an additional view. ",
                                "It is useful for the study of breasts with surgical ",
                                "scars in the lower quadrants. ",
                                "The ability to see the scar through the compressor ",
                                "paddle offers to the mammographer ",
                                "the possibility to flatten it properly, reducing ",
                                "the formation of scar folds as well ",
                                "artifacts from false parenchymal distortion.")
                        ,
                        new ConceptDef()
                            .SetCode("CCWithCompressionView")
                            .SetDisplay("CC with compression view")
                            .MammoId("84")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("84",
                                "Procedure | 439324009 | Mammogram in compression ",
                                "view (Procedure)+ QualifierValue | 399162004 | Cranio-caudal ",
                                "projection (Qualifier)")
                            .SetUMLS("84",
                                "The recommendation is for a CC with compression view ",
                                "to be completed on an Ultrasound and/or Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("CCWithMagnificationView")
                            .SetDisplay("CC with magnification view")
                            .MammoId("82")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("82",
                                "Procedure | 241058008 | Mammogram magnification (Procedure) ",
                                "+ QualifierValue | 399162004 | Cranio-caudal projection ",
                                "(Qualifier)")
                            .SetUMLS("82",
                                "The recommendation is for a CC with magnification ",
                                "view to be completed on an Ultrasound and/or Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("CleavageView")
                            .SetDisplay("Cleavage view")
                            .MammoId("44")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("44",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399161006 | Cleavage mammography ",
                                "view (Qualifier)")
                            .SetUMLS("44",
                                "It is recommended that a cleavage view is captured ",
                                "via Mammogram and/or Ultrasound. ",
                                "Also called \"valley view\" is a mammogram view that ",
                                "images the most central portions ",
                                "of the breasts. ",
                                "To get as much central tissue as possible, the mammogram ",
                                "technologist will place ",
                                "both breasts on the plate at the same time to image ",
                                "the medial half of both breasts.")
                        ,
                        new ConceptDef()
                            .SetCode("ClinicalConsultation")
                            .SetDisplay("Clinical consultation")
                            .MammoId("116")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("116",
                                "A clinical consultation is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("ClinicalCorrelation")
                            .SetDisplay("Clinical correlation")
                            .MammoId("56")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("56",
                                "The recommendation is for a clinicial correlation ",
                                "and/or comparison to be completed.")
                        ,
                        new ConceptDef()
                            .SetCode("ClinicalFollow-up")
                            .SetDisplay("Clinical follow-up")
                            .MammoId("93")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("93",
                                "The recommendation is for a clinical follow-up to ",
                                "be completed.")
                        ,
                        new ConceptDef()
                            .SetCode("CompareToPriorExams")
                            .SetDisplay("Compare to prior exams")
                            .MammoId("103")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("103",
                                "The recommendation is for a compare to prior exams ",
                                "to be completed.")
                        ,
                        new ConceptDef()
                            .SetCode("CompressionViews")
                            .SetDisplay("Compression views")
                            .MammoId("43")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("43",
                                "Procedure | 439324009 | Mammogram in compression ",
                                "view (Procedure)")
                            .SetUMLS("43",
                                "It is recommended that a compression view is admininstered ",
                                "via Mammogram or Ultrasound. ",
                                "All mammograms use compression of the breast. ",
                                "By applying compression to only a specific area of ",
                                "the breast, the effective pressure ",
                                "is increased on that spot. ",
                                "This results in better tissue separation and allows ",
                                "better visualization of the area ",
                                "of the breast needing additional examination.")
                        ,
                        new ConceptDef()
                            .SetCode("ConeCompression")
                            .SetDisplay("Cone compression")
                            .MammoId("185")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("185",
                                "Procedure | 439324009 | Mammogram in compression ",
                                "view (Procedure)")
                            .SetUMLS("185",
                                "A cone compression is recommended to catch a specific ",
                                "spot or view during the mammogram ",
                                "and/or ultrasound. ",
                                "Spot views apply the compression to a smaller area ",
                                "of tissue using a small compression ",
                                "plate or \"cone\".")
                        ,
                        new ConceptDef()
                            .SetCode("CoreBiopsy")
                            .SetDisplay("Core Biopsy")
                            .MammoId("1829")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("1829",
                                "Procedure | 44578009 | Core needle biopsy of breast ",
                                "(Procedure)")
                            .SetUMLS("1829",
                                "It is recommended that a core biopsy procedure is ",
                                "administered. ",
                                "It is a procedure where a needle is passed through ",
                                "the skin to take a sample of tissue ",
                                "from a mass or lump. ",
                                "The tissue is then examined under a microscope for ",
                                "any abnormalities.")
                        ,
                        new ConceptDef()
                            .SetCode("CraniocaudalView")
                            .SetDisplay("Craniocaudal view")
                            .MammoId("332")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("332",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399162004 | Cranio-caudal projection ",
                                "(Qualifier)")
                            .SetUMLS("332",
                                "Cranial-Caudal (CC) is a view from above the breast ",
                                "during a mammogram or ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("Cryoablation")
                            .SetDisplay("Cryoablation")
                            .MammoId("168")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("168",
                                "Uses imaging guidance, a needle-like applicator called ",
                                "a cryoprobe, and liquid nitrogen ",
                                "or argon gas to create intense cold to freeze and ",
                                "destroy diseased tissue, including ",
                                "cancer cells. ",
                                "It may be used to treat a variety of skin conditions ",
                                "as well as tumors within the ",
                                "liver, kidneys, bones, lungs and breasts.")
                        ,
                        new ConceptDef()
                            .SetCode("CystAspiration")
                            .SetDisplay("Cyst aspiration")
                            .MammoId("51")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("51",
                                "Procedure | 287572003 | Diagnostic aspiration of ",
                                "breast cyst (Procedure)")
                            .SetUMLS("51",
                                "A cyst aspiration is a procedure used to drain fluid ",
                                "from a breast cyst. ",
                                "The vast majority of cysts are benign (non-cancerous), ",
                                "though some are quite tender. ",
                                "Aspirating the fluid from a cyst may alleviate symptoms ",
                                "or discomfort. ",
                                "In some cases, specimens are sent to pathology. ",
                                "###URL#www.carolmilgardbreastcenter.org > Cyst_Aspiration")
                        ,
                        new ConceptDef()
                            .SetCode("CystAspirationForRelief")
                            .SetDisplay("Cyst aspiration for relief")
                            .MammoId("1821")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("1821",
                                "Procedure | 287572003 | Diagnostic aspiration of ",
                                "breast cyst (Procedure)")
                            .SetUMLS("1821",
                                "One way to get relief from the pain of a cyst is ",
                                "to remove fluid from ",
                                "the cyst, thereby decreasing the pressure. ",
                                "This is called aspiration for relief.")
                        ,
                        new ConceptDef()
                            .SetCode("DiagnosticAspiration")
                            .SetDisplay("Diagnostic aspiration")
                            .MammoId("108")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("108",
                                "Procedure | 287572003 | Diagnostic aspiration of ",
                                "breast cyst (Procedure)")
                            .SetUMLS("108",
                                "This is a fine needle aspiration and is a type of ",
                                "biopsy procedure. ",
                                "In fine needle aspiration, a thin needle is inserted ",
                                "into an area of abnormal-appearing ",
                                "tissue or body fluid. ",
                                "###URL#https://www.webmd.com > a-to-z-guides > fine-needle-aspiration")
                        ,
                        new ConceptDef()
                            .SetCode("DiagnosticMammogram")
                            .SetDisplay("Diagnostic Mammogram")
                            .MammoId("1834")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("1834",
                                "While screening mammograms are used as a routine ",
                                "check-up for breast health,  diagnostic ",
                                "mammograms are used after suspicious results on a ",
                                "screening mammogram or after some ",
                                "signs of breast cancer alert the physician to check ",
                                "the tissue.These signs may include ",
                                "a lump or breast pain. ",
                                "###URL#https://www.nationalbreastcancer.org/diagnostic-mammogram")
                        ,
                        new ConceptDef()
                            .SetCode("DrainageTube")
                            .SetDisplay("Drainage tube")
                            .MammoId("183")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("183",
                                "The recommendation is for a drainage tube to be attached ",
                                "to breast. ",
                                "A drainage tube is a tube used to remove pus, blood ",
                                "or other fluids from a wound. ",
                                "This is a common practice by surgeons or interventional ",
                                "radiologists. ",
                                "###URL#https://en.wikipedia.org/wiki/Drain_(surgery)")
                        ,
                        new ConceptDef()
                            .SetCode("Ductography")
                            .SetDisplay("Ductography")
                            .MammoId("179")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("179",
                                "Procedure | 420131003 | Fluoroscopic mammary ductography ",
                                "(Procedure)")
                            .SetUMLS("179",
                                "A ductogram, also called a galactogram, is a special ",
                                "type of mammogram used for imaging ",
                                "the breast ducts. ",
                                "It can aid in diagnosing the cause of abnormal nipple ",
                                "discharges.",
                                "Ductography (also called galactography or ductogalactography) ",
                                "is a special type of ",
                                "contrast enhanced mammography used for imaging the ",
                                "breast ducts. ",
                                "Ductography can aid in diagnosing the cause of an ",
                                "abnormal nipple discharge and is ",
                                "valuable in diagnosing intraductal papillomas and ",
                                "other conditions.",
                                "###URL#https://www.imaginis.com/mammography/ductogram-galactogram-imaging-the-breast-ducts")
                        ,
                        new ConceptDef()
                            .SetCode("ExaggeratedCCViews")
                            .SetDisplay("Exaggerated CC views")
                            .MammoId("41")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("41",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399265009 | Exaggerated cranio-caudal ",
                                "projection (Qualifier)")
                            .SetUMLS("41",
                                "An XCCL view is a supplementary mammographic view. ",
                                "It is a type of exaggerated cranio-caudal view. ",
                                "It is particularly good for imaging the lateral aspect ",
                                "of the breast. It is often ",
                                "done when a lesion is suspected on a MLO view but ",
                                "cannot be seen on the CC view. In ",
                                "this view, the lateral aspect of the breast is placed ",
                                "forward. ",
                                "One rationale of performing this view is that many ",
                                "cancers are located in the lateral ",
                                "aspect of the breast. ",
                                "An XCCM view is a supplementary mammographic view. ",
                                "It is a type of exaggerated cranio-caudal view. ",
                                "It is particularly good for imaging the medial portion ",
                                "of the breast. ",
                                "In this view, the medial portion of the breast is ",
                                "placed forward. ",
                                "A negative 15degrees tube tilt is suggested.",
                                "An optimal XCCM view requires the most medial portion ",
                                "of the breast and the nipple ",
                                "in profile to be clearly displayed. ",
                                "###URL#https://radiopaedia.org/articles/xccl-view?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("FNABiopsy")
                            .SetDisplay("FNA biopsy")
                            .MammoId("57")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("57",
                                "not matching")
                            .SetUMLS("57",
                                "FNA stands for Fine needle aspiration and this is ",
                                "a type of biopsy procedure. ",
                                "In fine needle aspiration, a thin needle is inserted ",
                                "into an area of abnormal-appearing ",
                                "tissue or body fluid.",
                                "As with other types of biopsies, the sample collected ",
                                "during fine needle aspiration ",
                                "can help make a diagnosis or rule out conditions ",
                                "such as cancer. ",
                                "###URL#https://www.webmd.com/a-to-z-guides/fine-needle-aspiration#1")
                        ,
                        new ConceptDef()
                            .SetCode("Follow-up")
                            .SetDisplay("Follow-up")
                            .MammoId("38")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("38",
                                "It is recommended to make a follow-up appointment.")
                        ,
                        new ConceptDef()
                            .SetCode("Followup3Months")
                            .SetDisplay("Followup 3 months")
                            .MammoId("123")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("123",
                                "It is recommended to make a follow-up appointment ",
                                "in 3 months.")
                        ,
                        new ConceptDef()
                            .SetCode("Followup6Months")
                            .SetDisplay("Followup 6 months")
                            .MammoId("119")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("119",
                                "It is recommended to make a follow-up appointment ",
                                "in 6 months.")
                        ,
                        new ConceptDef()
                            .SetCode("IfPreviousShowNoChange")
                            .SetDisplay("If previous show no change")
                            .MammoId("89")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("89",
                                "The recommendation is for a if previous show no change ",
                                "to be completed.")
                        ,
                        new ConceptDef()
                            .SetCode("LateralMagnificationView")
                            .SetDisplay("Lateral magnification view")
                            .MammoId("161")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("161",
                                "Procedure | 241058008 | Mammogram magnification (Procedure) ",
                                "+ QualifierValue | 399067008 | Lateral projection ",
                                "(Qualifier)")
                            .SetUMLS("161",
                                "The recommendation is for a Lateral magnification ",
                                "view to be completed on Mammogram and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("LateralMedialView")
                            .SetDisplay("Lateral medial view")
                            .MammoId("90")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("90",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399352003 | Lateral-medial projection ",
                                "(Qualifier)")
                            .SetUMLS("90",
                                "There are different views of the breast in mammography. ",
                                "For the LM view, the tube is lateral and the detector ",
                                "is placed medially",
                                "LM view is best for evaluating medial lesions.")
                        ,
                        new ConceptDef()
                            .SetCode("LateralView")
                            .SetDisplay("Lateral view")
                            .MammoId("95")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("95",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399067008 | Lateral projection ",
                                "(Qualifier)")
                            .SetUMLS("95",
                                "There are different views of the breast in mammography. ",
                                "The lateral view is a view obtained at virtually ",
                                "every diagnostic evaluation. ",
                                "A lateral view may be obtained as a mediolateral ",
                                "view (ML) or lateromedial view (LM) ",
                                "view depending on where the imaging tube and detector ",
                                "are located.")
                        ,
                        new ConceptDef()
                            .SetCode("LateralWithCompressionView")
                            .SetDisplay("Lateral with compression view")
                            .MammoId("86")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("86",
                                "Procedure | 439324009 | Mammogram in compression ",
                                "view (Procedure) + QualifierValue | 399067008 | Lateral ",
                                "projection (Qualifier)")
                            .SetUMLS("86",
                                "The recommendation is for a Lateral with compression ",
                                "view to be completed on Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("LateromedialOblique")
                            .SetDisplay("Lateromedial oblique")
                            .MammoId("47")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("47",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure)+ ",
                                "QualifierValue | 399352003 | Lateral-medial projection ",
                                "(Qualifier)")
                            .SetUMLS("47",
                                "The recommendation is for a lateromedial oblique ",
                                "view to be completed on Mammogram and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("LateromedialView")
                            .SetDisplay("Lateromedial view")
                            .MammoId("96")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("96",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399352003 | Lateral-medial projection ",
                                "(Qualifier)")
                            .SetUMLS("96",
                                "The recommendation is for a lateromedial view to ",
                                "be completed on Mammogram and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("LymphNodeAssessment")
                            .SetDisplay("Lymph node assessment")
                            .MammoId("1835")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("1835",
                                "Lymph Node Exam. ",
                                "Palpation of the lymph nodes provides information ",
                                "about the possible presence of ",
                                "a malignant or inflammatory process and the localization ",
                                "or generalization of that ",
                                "process. ",
                                "###URL#https://stanfordmedicine25.stanford.edu/the25/lymph.html")
                        ,
                        new ConceptDef()
                            .SetCode("MagnificationViews")
                            .SetDisplay("Magnification views")
                            .MammoId("42")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("42",
                                "Procedure | 241058008 | Mammogram magnification (Procedure)")
                            .SetUMLS("42",
                                "A magnification view in mammography is performed ",
                                "to evaluate and count microcalcifications and ",
                                "its extension (as well the assessment of the borders ",
                                "and the tissue structures of ",
                                "a suspicious area or a mass) by using a magnification ",
                                "device which brings the breast ",
                                "away from the film plate and closer to the x-ray ",
                                "source. ",
                                "This allows the acquisition of magnified images (1.5x ",
                                "to 2x magnification) of the ",
                                "region of interest. radiopaedia.org > articles > magnification-view-mammography")
                        ,
                        new ConceptDef()
                            .SetCode("Mammogram")
                            .SetDisplay("Mammogram")
                            .MammoId("182")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedDescription("182",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure)")
                            .SetUMLS("182",
                                "A mammogram is an X-Ray picture of the breast. ",
                                "It is used to look for early signs of breast cancer.")
                        ,
                        new ConceptDef()
                            .SetCode("Mammogram3MonthFollow-up")
                            .SetDisplay("Mammogram 3 month follow-up")
                            .MammoId("1822")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("1822",
                                "A three month follow-up is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("Mammogram6MonthFollow-up")
                            .SetDisplay("Mammogram 6 month follow-up")
                            .MammoId("1823")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("1823",
                                "A six month follow-up is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MammogramAndUltrasound3MonthFollow-up")
                            .SetDisplay("Mammogram and ultrasound 3 month follow-up")
                            .MammoId("1826")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("1826",
                                "A three month follow-up with ultrasound is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MammogramAndUltrasound6MonthFollow-up")
                            .SetDisplay("Mammogram and ultrasound 6 month follow-up")
                            .MammoId("1827")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("1827",
                                "A six month follow-up with ultrasound is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MediolateralObliqueView")
                            .SetDisplay("Mediolateral oblique view")
                            .MammoId("187")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("187",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399368009 | Medio-lateral oblique ",
                                "projection (Qualifier)")
                            .SetUMLS("187",
                                "A mediolateral oblique view is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MediolateralView")
                            .SetDisplay("Mediolateral view")
                            .MammoId("162")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("162",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399260004 | Medial-lateral projection ",
                                "(Qualifier)")
                            .SetUMLS("162",
                                "A mediolateral view is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MLOWithCompressionView")
                            .SetDisplay("MLO with compression view")
                            .MammoId("85")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("85",
                                "Procedure | 439324009 | Mammogram in compression ",
                                "view (Procedure) + QualifierValue | 399368009 | Medio-lateral ",
                                "oblique projection (Qualifier)")
                            .SetUMLS("85",
                                "An additional MLO with compression view of the breast ",
                                "is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MLOWithMagnificationView")
                            .SetDisplay("MLO with magnification view")
                            .MammoId("83")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("83",
                                "Procedure | 241058008 | Mammogram magnification (Procedure) ",
                                "+ QualifierValue | 399368009 | Medio-lateral oblique ",
                                "projection (Qualifier)")
                            .SetUMLS("83",
                                "An additional MLO with magnification view of the ",
                                "breast is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MRI")
                            .SetDisplay("MRI")
                            .MammoId("92")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("92",
                                "Procedure | 241615005 | Magnetic resonance imaging ",
                                "of breast (Procedure)")
                            .SetUMLS("92",
                                "An MRI is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MRIBiopsy")
                            .SetDisplay("MRI biopsy")
                            .MammoId("120")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("120",
                                "Procedure | 433008009 | Core needle biopsy of breast ",
                                "using magnetic resonance imaging guidance (Procedure)")
                            .SetUMLS("120",
                                "An MRI with biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("MRIFollow-up")
                            .SetDisplay("MRI follow-up")
                            .MammoId("180")
                            .ValidModalities(Modalities.MRI | Modalities.NM)
                            .SetUMLS("180",
                                "An MRI follow-up is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("NeedleLocationAndSurgicalBiopsy")
                            .SetDisplay("Needle location and surgical biopsy")
                            .MammoId("53")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("53",
                                "A Needle localization and surgical biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("NippleInProfileView")
                            .SetDisplay("Nipple in profile view")
                            .MammoId("144")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("144",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 442581004 | Nipple in profile ",
                                "mammography view (Qualifier)")
                            .SetUMLS("144",
                                "A technically adequate exam has the nipple in profile, ",
                                "allows visualization of the ",
                                "inframammary fold and includes the pectoralis muscle ",
                                "extending down to the posterior ",
                                "nipple line (an oblique line drawn straight back ",
                                "from the nipple.) ",
                                "###URL#https://www.mammoguide.com/mammo-techniques.html")
                        ,
                        new ConceptDef()
                            .SetCode("OffAngleCCView")
                            .SetDisplay("Off angle CC view")
                            .MammoId("106")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("106",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399162004 | Cranio-caudal projection ",
                                "(Qualifier)")
                            .SetUMLS("106",
                                "An additional off angle CC view of the breast is ",
                                "recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("OffAngleMLOView")
                            .SetDisplay("Off angle MLO view")
                            .MammoId("107")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("107",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399368009 | Medio-lateral oblique ",
                                "projection (Qualifier) +++++")
                            .SetUMLS("107",
                                "An additional off angle MLO  view of the breast is ",
                                "recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("Poss.StereotacticBx")
                            .SetDisplay("Poss. Stereotactic Bx")
                            .MammoId("1837")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("1837",
                                "Procedure | 116334007 | Stereotactically guided core ",
                                "needle biopsy of breast (Procedure) ++ POSSILE")
                            .SetUMLS("1837",
                                "Stereotactic breast biopsy uses mammography - a specific ",
                                "type of breast imaging that ",
                                "uses low-dose x-rays - to help locate a breast abnormality ",
                                "and remove a tissue sample ",
                                "for examination under a microscope. ",
                                "It's less invasive than surgical biopsy, leaves little ",
                                "to no scarring and can be ",
                                "an excellent way to evaluate calcium deposits or ",
                                "tiny masses that are not visible ",
                                "on ultrasound. ",
                                "###URL#https://www.radiologyinfo.org/en/info.cfm?pg=breastbixr")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleCoreBiopsy")
                            .SetDisplay("Possible core biopsy")
                            .MammoId("91")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("91",
                                "Procedure | 44578009 | Core needle biopsy of breast ",
                                "(Procedure) ++ POSSIBLE")
                            .SetUMLS("91",
                                "A core needle biopsy (CNB)  uses a hollow needle ",
                                "to take out pieces of breast tissue from ",
                                "a suspicious area in an imaging test.",
                                "The needle may be attached to a spring-loaded tool ",
                                "that moves the needle in and out ",
                                "of the tissue quickly, or it may be attached to a ",
                                "suction device that helps pull ",
                                "breast tissue into the needle. ",
                                "A small cylinder (core) of tissue is taken out in ",
                                "the needle. ",
                                "Several cores are often removed. ",
                                "###URL#https://www.cancer.org/cancer/breast-cancer/screening-tests-and-early-detection/breast-biopsy/core-needle-biopsy-of-the-breast.html")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleDiagnosticMammogram")
                            .SetDisplay("Possible Diagnostic Mammogram")
                            .MammoId("1836")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("1836",
                                "A possible diagnostic mammogram is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleStereotacticVacuumBiopsy")
                            .SetDisplay("Possible stereotactic vacuum biopsy")
                            .MammoId("133")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("133",
                                "Based on the results of the mammogram, a possible ",
                                "stereotactic vacuum biopsy is recommended. ",
                                "During this type of biopsy, small samples of tissue ",
                                "are removed from the breast using ",
                                "a hollow needle, which is precisely guided to the ",
                                "correct location using x-rays and ",
                                "computer generated coordinates of the concerning ",
                                "area of breast tissue. ",
                                "###URL#https://www.genesishealth.com/care-treatment/cancer/treat/breast/diagnosis/sterotactic_vacuum/")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleSurgicalConsult")
                            .SetDisplay("Possible surgical consult")
                            .MammoId("1805")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("1805",
                                "A possible surgical consultation may be recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleSurgicalEvaluation")
                            .SetDisplay("Possible surgical evaluation")
                            .MammoId("1806")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("1806",
                                "A possible surgical evaluation is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleUltrasound")
                            .SetDisplay("Possible ultrasound")
                            .MammoId("186")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("186",
                                "A possible ultrasound is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleUltrasoundGuidedBiopsy")
                            .SetDisplay("Possible ultrasound guided biopsy")
                            .MammoId("130")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("130",
                                "Procedure | 432550005 | Core needle biopsy of breast ",
                                "using ultrasound guidance (Procedure) +++ POSSIBLE")
                            .SetUMLS("130",
                                "A possible ultrasound guided biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("PossibleVacuumBiopsy")
                            .SetDisplay("Possible vacuum biopsy")
                            .MammoId("132")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("132",
                                "A possible vacuum biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("RepeatCCView")
                            .SetDisplay("Repeat CC view")
                            .MammoId("135")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("135",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399162004 | Cranio-caudal projection ",
                                "(Qualifier)")
                            .SetUMLS("135",
                                "Another CC view of Mammogram is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("RepeatMLOView")
                            .SetDisplay("Repeat MLO view")
                            .MammoId("134")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("134",
                                "Procedure | 241055006 | Mammogram - symptomatic (Procedure) ",
                                "+ QualifierValue | 399368009 | Medio-lateral oblique ",
                                "projection (Qualifier)")
                            .SetUMLS("134",
                                "Another MLO view of Mammogram is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("RolledLateralView")
                            .SetDisplay("Rolled lateral view")
                            .MammoId("49")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("49",
                                "Procedure | 399197002 | Lateral rolling of breast ",
                                "(Procedure)")
                            .SetUMLS("49",
                                "A rolled CC lateral view is recommended. ",
                                "A rolled CC view Is performed to locate a lesion ",
                                "only visible in the cranio-caudal ",
                                "view, or when overlapped tissues in the standard ",
                                "view can simulate or partially conceal ",
                                "a lesion: changing of  tissues distribution  allows ",
                                "to determine whether or not its ",
                                "presence. ",
                                "When the lesion identified moves medially or laterally ",
                                "respect to the standard projection, ",
                                "it is possible to determine in which quadrant it ",
                                "is localized.",
                                "The breast is positioned on the image receptor as ",
                                "for the cranio-caudal view, then ",
                                "is rotated medially or laterally around the axis ",
                                "of the nipple prior to applying ",
                                "compression. ",
                                "###URL#https://radiopaedia.org/articles/rolled-cc-view-1?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("RolledMedialView")
                            .SetDisplay("Rolled medial view")
                            .MammoId("50")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("50",
                                "Procedure | 399226006 | Medial rolling of breast ",
                                "(Procedure)")
                            .SetUMLS("50",
                                "A rolled medial view is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("ScintimammogramGuidedBiopsy")
                            .SetDisplay("Scintimammogram Guided Biopsy")
                            .MammoId("1807")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("1807",
                                "A Scintimammogram guided biopsy is recommended. ",
                                "This is performed by taking samples of an abnormality ",
                                "under guidance from the Scintimammogram. ",
                                "Scintimammography uses small amounts of radioactive ",
                                "material, a special camera and a computer to help ",
                                "investigate a breast abnormality. ",
                                "This helps to guide the radiologist's biopsy equipment ",
                                "to the site of the imaging abnormality.###URL#https://www.radiologyinfo.org/en/info.cfm?pg=breastbixr")
                        ,
                        new ConceptDef()
                            .SetCode("Scintimammography")
                            .SetDisplay("Scintimammography")
                            .MammoId("102")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("102",
                                "A scintimammogram is recommended. ",
                                "Scintimammography is also known as nuclear medicine ",
                                "breast imaging, Breast Specific ",
                                "Gamma Imaging (BSGI) and Molecular Breast Imaging ",
                                "(MBI). ",
                                "This type of exam is used to investigate a breast ",
                                "abnormality found with mammography. ",
                                "Scintimammography uses small amounts of radioactive ",
                                "material, a special camera and ",
                                "a computer to help investigate a breast abnormality. ",
                                "Scintimammography can detect cancer even when dense ",
                                "breast tissue and breast implants ",
                                "are present. ",
                                "It can reduce unnecessary procedures by helping determine ",
                                "whether a biopsy is needed. ",
                                "###URL#https://www.radiologyinfo.org/en/info.cfm?pg=scintimammo")
                        ,
                        new ConceptDef()
                            .SetCode("SpotCompression")
                            .SetDisplay("Spot compression")
                            .MammoId("1801")
                            .ValidModalities(Modalities.MG | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("1801",
                                "Procedure | 439324009 | Mammogram in compression ",
                                "view (Procedure)")
                            .SetUMLS("1801",
                                "A spot compression is recommended. ",
                                "A spot view (also known as a spot compression view ",
                                "or focal compression view) is ",
                                "an additional mammographic view performed by applying ",
                                "the compression to a smaller ",
                                "area of tissue using a small compression paddle, ",
                                "increasing the effective pressure ",
                                "on that spot. ",
                                "This results in better tissue separation and allows ",
                                "better visualization of the breast ",
                                "tissue in that area. ",
                                "It is used to distinguish between the presence of ",
                                "a true lesion and an overlap of ",
                                "tissues, as well to better show the borders of an ",
                                "abnormality or questionable area ",
                                "or a little cluster of faint microcalcifications ",
                                "in a dense area. ",
                                "###URL#https://radiopaedia.org/articles/spot-view-mammography?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("SpotMagnificationViews")
                            .SetDisplay("Spot magnification views")
                            .MammoId("188")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("188",
                                "Procedure | 241058008 | Mammogram magnification (Procedure) ",
                                "+++++")
                            .SetUMLS("188",
                                "Spot magnification views are recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("StereotacticBx")
                            .SetDisplay("Stereotactic bx")
                            .MammoId("54")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("54",
                                "Procedure | 116334007 | Stereotactically guided core ",
                                "needle biopsy of breast (Procedure)")
                            .SetUMLS("54",
                                "A stereotactic biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("SuperolateralIOView")
                            .SetDisplay("Superolateral IO view")
                            .MammoId("48")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("48",
                                "A superolateral IO view is recommended. ",
                                "The view of the upper outer quadrant of the breast. ",
                                "This is the quadrant of the breast that is closest ",
                                "to the armpit. ",
                                "There are 4 quadrants in the anatomy of a breast.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalBiopsy")
                            .SetDisplay("Surgical biopsy")
                            .MammoId("1803")
                            .ValidModalities(Modalities.NM)
                            .SetSnomedDescription("1803",
                                "Procedure | 274331003 | Surgical biopsy of breast ",
                                "(Procedure)")
                            .SetUMLS("1803",
                                "A surgical biopsy is recommended. ",
                                "A surgical biopsy is a procedure that involves the ",
                                "surgical removal of tissue from ",
                                "a lump or mass for examination under a microscope. ",
                                "This test may also be called an open biopsy.",
                                "Surgical biopsies can be excisional (removal of an ",
                                "entire lump or abnormal area) ",
                                "or incisional (removal of a piece of a lump or abnormal ",
                                "area). ",
                                "###URL#https://www.cancer.ca/en/cancer-information/diagnosis-and-treatment/tests-and-procedures/surgical-biopsy/?region=on")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalConsult")
                            .SetDisplay("Surgical consult")
                            .MammoId("101")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("101",
                                "A surgical consult is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalConsultAndBiopsy")
                            .SetDisplay("Surgical consult and biopsy")
                            .MammoId("118")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("118",
                                "Procedure | 274331003 | Surgical biopsy of breast ",
                                "(Procedure) ++++")
                            .SetUMLS("118",
                                "A surgical consult and biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalEvaluation")
                            .SetDisplay("Surgical evaluation")
                            .MammoId("1802")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("1802",
                                "The recommendation is for a surgical evaluation.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalExcision")
                            .SetDisplay("Surgical excision")
                            .MammoId("1804")
                            .ValidModalities(Modalities.NM)
                            .SetSnomedDescription("1804",
                                "Procedure | 237372000 | Excisional biopsy of breast ",
                                "(Procedure)")
                            .SetUMLS("1804",
                                "The recommendation is for a surgical excision.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalOncologicEvaluation")
                            .SetDisplay("Surgical oncologic evaluation")
                            .MammoId("1810")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("1810",
                                "The recommendation is for a surgical oncologic evaluation.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalOncologicalConsult")
                            .SetDisplay("Surgical oncological consult")
                            .MammoId("1809")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("1809",
                                "The recommendation is for a surgical oncologic consult.")
                        ,
                        new ConceptDef()
                            .SetCode("TangentialView")
                            .SetDisplay("Tangential view")
                            .MammoId("114")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("114",
                                "A tangential view is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("TangentialViews")
                            .SetDisplay("Tangential views")
                            .MammoId("40")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("40",
                                "Tangential views are recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("Ultrasound")
                            .SetDisplay("Ultrasound")
                            .MammoId("181")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM)
                            .SetSnomedDescription("181",
                                "Procedure | 47079000 | Ultrasonography of breast ",
                                "(Procedure)")
                            .SetUMLS("181",
                                "An ultrasound is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("Ultrasound2ndLook")
                            .SetDisplay("Ultrasound 2nd Look")
                            .MammoId("184")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("184",
                                "An additional ultrasound is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("Ultrasound3MonthFollow-up")
                            .SetDisplay("Ultrasound 3 month follow-up")
                            .MammoId("1824")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("1824",
                                "An additional ultrasound is recommended in a 3 month ",
                                "follow-up.")
                        ,
                        new ConceptDef()
                            .SetCode("Ultrasound6MonthFollow-up")
                            .SetDisplay("Ultrasound 6 month follow-up")
                            .MammoId("1825")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("1825",
                                "An additional ultrasound is recommended in a 3 month ",
                                "follow-up.")
                        ,
                        new ConceptDef()
                            .SetCode("UltrasoundGuidedBx")
                            .SetDisplay("Ultrasound guided bx")
                            .MammoId("55")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("55",
                                "Procedure | 432550005 | Core needle biopsy of breast ",
                                "using ultrasound guidance (Procedure)")
                            .SetUMLS("55",
                                "An ultrasound guided biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("UltrasoundLocationAndSurgicalBiopsy")
                            .SetDisplay("Ultrasound location and surgical biopsy")
                            .MammoId("171")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("171",
                                "Procedure | 274331003 | Surgical biopsy of breast ",
                                "(Procedure)++++++++++++")
                            .SetUMLS("171",
                                "An ultrasound localized and surgical biopsy is recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("UltrasoundWithPossibleAddlitonalViews")
                            .SetDisplay("Ultrasound with possible addlitonal views")
                            .MammoId("189")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("189",
                                "An ultrasound with possible additional views are ",
                                "recommended.")
                        ,
                        new ConceptDef()
                            .SetCode("Unspecified/Other")
                            .SetDisplay("Unspecified / other")
                            .MammoId("117")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("117",
                                "Unspecified / other")
                        ,
                        new ConceptDef()
                            .SetCode("VacuumBx")
                            .SetDisplay("Vacuum Bx")
                            .MammoId("131")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("131",
                                "A vacuum biopsy is recommended.")
                        #endregion // Codes
                        //- Codes
                    })
        );
    }
}
