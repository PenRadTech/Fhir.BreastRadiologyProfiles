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
        VSTaskVar NotPreviouslySeenVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "NotPreviouslySeenVS",
                    "NotPreviouslySeen ValueSet",
                    "NotPreviouslySeen/ValueSet",
                    "NotPreviouslySeen value set.",
                    Group_CommonCodesVS,
                    Self.NotPreviouslySeenCS.Value()
                )
        );

        CSTaskVar NotPreviouslySeenCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "NotPreviouslySeenCodeSystemCS",
                    "Not Previously Seen CodeSystem",
                    "NotPreviouslySeen/CodeSystem",
                    "NotPreviouslySeen code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("ClinicalExam")
                            .SetDisplay("Clinical exam")
                            .MammoId("280")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("280",
                                "Not previously seen on clinical exam.")
                        ,
                        new ConceptDef()
                            .SetCode("Ductogram")
                            .SetDisplay("Ductogram")
                            .MammoId("284")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("284",
                                "Procedure | 420131003 | Fluoroscopic mammary ductography ",
                                "(Procedure)")
                            .SetUMLS("284",
                                "Breast ductography (a.k.a. ",
                                "galactography) is an imaging technique which is used ",
                                "to evaluate lesions causing ",
                                "nipple discharge. ",
                                "It helps in precisely locating the mass within breast ",
                                "tissue and gives useful information ",
                                "for surgical approach and planning.",
                                "A blunt-tipped sialogram needle (30-gauge) is used ",
                                "for performing the ductogram. ",
                                "The abnormal duct is identified and cannulated. ",
                                "###URL#https://radiopaedia.org/articles/breast-ductography-1?lang=us")
                        ,
                        new ConceptDef()
                            .SetCode("Mammogram")
                            .SetDisplay("Mammogram")
                            .MammoId("281")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("281",
                                "A mammogram is an X-Ray picture of the breast. ",
                                "It is used to look for early signs of breast cancer.")
                        ,
                        new ConceptDef()
                            .SetCode("MRI")
                            .SetDisplay("MRI")
                            .MammoId("283")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("283",
                                "Procedure | 241615005 | Magnetic resonance imaging ",
                                "of breast (Procedure)")
                            .SetUMLS("283",
                                "Magnetic Resonance Imaging (MRI) is a test that uses ",
                                "powerful magnets, radio waves, ",
                                "and a computer to make detailed pictures inside the ",
                                "body.")
                        ,
                        new ConceptDef()
                            .SetCode("OutsideExam")
                            .SetDisplay("Outside exam")
                            .MammoId("286")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("286",
                                "The findings on the Mammogram were not previously ",
                                "seen on the outside exam.")
                        ,
                        new ConceptDef()
                            .SetCode("Scintimammography")
                            .SetDisplay("Scintimammography")
                            .MammoId("285")
                            .ValidModalities(Modalities.NM)
                            .SetUMLS("285",
                                "This is a type of breast imaging that is used to ",
                                "detect cancer cells in the breasts ",
                                "of some patients who have had abnormal mammograms.")
                        ,
                        new ConceptDef()
                            .SetCode("Ultrasound")
                            .SetDisplay("Ultrasound")
                            .MammoId("282")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetSnomedDescription("282",
                                "Procedure | 47079000 | Ultrasonography of breast ",
                                "(Procedure)")
                            .SetUMLS("282",
                                "Uses soundwaves to develop ultrasound images. ",
                                "This information is relayed in real time to produce ",
                                "images on a computer screen. ",
                                "This can help diagnose and treat disease or conditions.")
                        #endregion // Codes
                        //- Codes
                    })
        );
    }
}
