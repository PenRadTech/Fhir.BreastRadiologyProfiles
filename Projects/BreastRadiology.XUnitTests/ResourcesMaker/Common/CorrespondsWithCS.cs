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
    partial class ResourcesMaker
    {
        VSTaskVar CorrespondsWithVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "CorrespondsWithVS",
                    "CorrespondsWith ValueSet",
                    "CorrespondsWith/ValueSet",
                    "CorrespondsWith value set.",
                    Group_CommonCodesVS,
                    Self.CorrespondsWithCS.Value()
                )
        );


        CSTaskVar CorrespondsWithCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "CorrespondsWithCodeSystemCS",
                    "Consistent With CodeSystem",
                    "CorrespondsWith/CodeSystem",
                    "CorrespondsWith code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("Aspiration")
                            .SetDisplay("Aspiration")
                            .MammoId("391")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("391",
                                "Procedure | 287572003 | Diagnostic aspiration of ",
                                "breast cyst (Procedure)")
                            .SetUMLS("391",
                                "A medical procedure that removes something from an ",
                                "area of the body. ",
                                "These substances can be air, body fluids, or bone ",
                                "fragments.",
                                "###URL#https://medlineplus.gov/ency/article/002216.htm")
                        ,
                        new ConceptDef()
                            .SetCode("Biopsy")
                            .SetDisplay("Biopsy")
                            .MammoId("392")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("392",
                                "Procedure | 122548005 | Biopsy of breast (Procedure)")
                            .SetUMLS("392",
                                "The Mammogram and Biopsy correspond with each other.")
                        ,
                        new ConceptDef()
                            .SetCode("Concern")
                            .SetDisplay("Concern")
                            .MammoId("327")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("327",
                                "The test corresponds with the concern.")
                        ,
                        new ConceptDef()
                            .SetCode("Ductogram")
                            .SetDisplay("Ductogram")
                            .MammoId("324")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("324",
                                "Procedure | 420131003 | Fluoroscopic mammary ductography ",
                                "(Procedure)")
                            .SetUMLS("324",
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
                            .SetCode("IncidentalFinding")
                            .SetDisplay("Incidental finding")
                            .MammoId("79")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("79",
                                "A medical finding that wasn't the abnormality of ",
                                "the original  mammogram, MRI, nuclear ",
                                "medicine, or ultrasound was intended to find.")
                        ,
                        new ConceptDef()
                            .SetCode("Mammo")
                            .SetDisplay("Mammo")
                            .MammoId("10")
                            .ValidModalities(Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("10",
                                "The original MRI, Nuclear Medicine, or Ultrasound ",
                                "corresponds with the findings on ",
                                "the Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("MRI")
                            .SetDisplay("MRI")
                            .MammoId("272")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("272",
                                "Procedure | 241615005 | Magnetic resonance imaging ",
                                "of breast (Procedure)")
                            .SetUMLS("272",
                                "The original Mammogram, Nuclear Medicine, or Ultrasound ",
                                "corresponds with the findings ",
                                "on the MRI.")
                        ,
                        new ConceptDef()
                            .SetCode("NippleDischarge")
                            .SetDisplay("Nipple discharge")
                            .MammoId("318")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("318",
                                "ClinicalFinding | 162166009 | Nipple discharge present ",
                                "(Disorder) | [0/0] | N64.52 |")
                            .SetUMLS("318",
                                "The findings on the Mammogram and/or Ultrasound, ",
                                "correspond with the nipple discharge.")
                        ,
                        new ConceptDef()
                            .SetCode("OutsideExam")
                            .SetDisplay("Outside exam")
                            .MammoId("451")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("451",
                                "Previous exam at another clinic that took place separate ",
                                "from current exam.")
                        ,
                        new ConceptDef()
                            .SetCode("Pain")
                            .SetDisplay("Pain")
                            .MammoId("271")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("271",
                                "Mammogram, MRI, Nuclear Medicine, or ultrasound corresponds ",
                                "with the pain the patient ",
                                "is experiencing.")
                        ,
                        new ConceptDef()
                            .SetCode("Palpated")
                            .SetDisplay("Palpated")
                            .MammoId("8")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("8",
                                "The Mammogram, Ultrasound, Nuclear Medicine, MRI ",
                                "correspond with the palpated (physical ",
                                "exam to touch) lump.")
                        ,
                        new ConceptDef()
                            .SetCode("PostOperative")
                            .SetDisplay("Post operative")
                            .MammoId("325")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("325",
                                "BodyStructure | 312285003 | Post-surgical breast ",
                                "structure")
                            .SetUMLS("325",
                                "The Mammogram corresponds with the post operative ",
                                "results of the breast incision.")
                        ,
                        new ConceptDef()
                            .SetCode("PreviousBiopsy")
                            .SetDisplay("Previous biopsy")
                            .MammoId("330")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("330",
                                "Procedure | 122548005 | Biopsy of breast (Procedure)")
                            .SetUMLS("330",
                                "The previous biopsy results correspond with the MRI ",
                                "and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("PriorExam")
                            .SetDisplay("Prior exam")
                            .MammoId("450")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("450",
                                "The prior exam of the breast, corresponds with the ",
                                "results of the Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("Redness")
                            .SetDisplay("Redness")
                            .MammoId("326")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("326",
                                "The redness in the breast, corresponds with the results ",
                                "of the Mammogram and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("Scinti")
                            .SetDisplay("Scinti")
                            .MammoId("323")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("323",
                                "The initial Mammogram corresponds with the Scinti ",
                                "results. ",
                                " Scintigraphy definition is a diagnostic technique ",
                                "in which a two-dimensional picture ",
                                "of internal body tissue is produced through the detection ",
                                "of radiation emitted by ",
                                "a radioactive substance administered into the body.")
                        ,
                        new ConceptDef()
                            .SetCode("Size<Mammo")
                            .SetDisplay("Size < mammo")
                            .MammoId("274")
                            .ValidModalities(Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("274",
                                "size < mammo")
                        ,
                        new ConceptDef()
                            .SetCode("Size<MRI")
                            .SetDisplay("Size < MRI")
                            .MammoId("276")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("276",
                                "size < MRI")
                        ,
                        new ConceptDef()
                            .SetCode("Size<Palp")
                            .SetDisplay("Size < palp")
                            .MammoId("278")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("278",
                                "size < palp")
                        ,
                        new ConceptDef()
                            .SetCode("Size<US")
                            .SetDisplay("Size < US")
                            .MammoId("320.276")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("320.276",
                                "size < US")
                        ,
                        new ConceptDef()
                            .SetCode("Size>Mammo")
                            .SetDisplay("Size > mammo")
                            .MammoId("273")
                            .ValidModalities(Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("273",
                                "size > mammo")
                        ,
                        new ConceptDef()
                            .SetCode("Size>MRI")
                            .SetDisplay("Size > MRI")
                            .MammoId("275")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("275",
                                "size > MRI")
                        ,
                        new ConceptDef()
                            .SetCode("Size>Palp")
                            .SetDisplay("Size > palp")
                            .MammoId("277")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("277",
                                "size > palp")
                        ,
                        new ConceptDef()
                            .SetCode("SkinMarker")
                            .SetDisplay("Skin marker")
                            .MammoId("328")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("328",
                                "PhysicalObject | 706314007 | Imaging lesion localization ",
                                "marker (Object)")
                            .SetUMLS("328",
                                "The mammogram findings correspond with where the ",
                                "skin marker was placed on the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("Surgery")
                            .SetDisplay("Surgery")
                            .MammoId("393")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("393",
                                "Procedure | 274331003 | Surgical biopsy of breast ",
                                "(Procedure)")
                            .SetUMLS("393",
                                "Surgery")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalSite")
                            .SetDisplay("Surgical site")
                            .MammoId("329")
                            .ValidModalities(Modalities.MRI)
                            .SetUMLS("329",
                                "The MRI information corresponds with the surgical ",
                                "site.")
                        ,
                        new ConceptDef()
                            .SetCode("Tenderness")
                            .SetDisplay("Tenderness")
                            .MammoId("322")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("322",
                                "ClinicalFinding | 290080002 | Localized tenderness ",
                                "of breast (Finding) | [0/0] | N64.4")
                            .SetUMLS("322",
                                "The mammogram results correspond with where the patient ",
                                "feels tenderness.")
                        ,
                        new ConceptDef()
                            .SetCode("TriggerPoint")
                            .SetDisplay("Trigger point")
                            .MammoId("319")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("319",
                                "BodyStructure | 134190002 | Trigger point (BodyStructure)")
                            .SetUMLS("319",
                                "The results of the Ultrasound correspond with where ",
                                "the trigger point is around the ",
                                "tumor/lesion. ",
                                "The trigger point is the point where the site of ",
                                "the pain is.")
                        ,
                        new ConceptDef()
                            .SetCode("US")
                            .SetDisplay("US")
                            .MammoId("270")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("270",
                                "The results of the MRI, Mammogram and/or Nuclear ",
                                "Medicine exam, correspond with this ",
                                "Ultrasound.")
                        #endregion // Codes
                        //- Codes
                    })
        );
    }
}
