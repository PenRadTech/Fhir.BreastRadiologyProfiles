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
        VSTaskVar MarginVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "MarginVS",
                    "Margin ValueSet",
                    "MarginValueSet",
                    "Margin ValueSet.",
                    Group_CommonCodesVS,
                    Self.MarginCS.Value()
                )
        );


        CSTaskVar MarginCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "MarginCS",
                    "MarginCodeSystem",
                    "Margin CodeSystem",
                    "Margin code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("AngularMargin")
                            .SetDisplay("Angular margin")
                            .MammoId("191")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("191",
                                "Some or all of the margin has sharp corners, often ",
                                "forming acute angles. ",
                                "The margin of the mass is not circumscribed.")
                        ,
                        new ConceptDef()
                            .SetCode("CircumscribedMargin")
                            .SetDisplay("Circumscribed margin")
                            .MammoId("109")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("109",
                                "129738007")
                            .SetSnomedDescription("109",
                                "ClinicalFinding | Lesion with circumscribed margin ",
                                "(Finding)")
                            .SetUMLS("109",
                                "A circumscribed margin is one that is well defined, ",
                                "with an abrupt transition between ",
                                "the lesion and the surrounding tissue. ",
                                "For US, to describe a mass as circumscribed, its ",
                                "entire margin must be sharply defined. ",
                                "Most circumscribed lesions have round or oval shapes. ",
                                "###ACRUS#49")
                        ,
                        new ConceptDef()
                            .SetCode("IndistinctMargin")
                            .SetDisplay("Indistinct margin")
                            .MammoId("21")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedCode("21",
                                "129741003")
                            .SetSnomedDescription("21",
                                "ClinicalFinding | Lesion with indistinct margin (Finding)")
                            .SetUMLS("21",
                                "There is no clear demarcation of the entire margin, ",
                                "or of any portion of the margin, ",
                                "from the surrounding",
                                "tissue. ",
                                "For mammography, this descriptor should not be used ",
                                "when the interpreting",
                                "physician believes it is likely due to immediately ",
                                "adjacent breast tissue. ",
                                "Use of this descriptor",
                                "usually implies a suspicious finding. ",
                                "###ACRMG#23")
                        ,
                        new ConceptDef()
                            .SetCode("IntraductalExtension")
                            .SetDisplay("Intraductal extension")
                            .MammoId("201")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("201",
                                "Intraductal tumor extension is a characteristic feature ",
                                "of primary breast carcinoma, ",
                                "and is an important consideration in patients undergoing ",
                                "breast conservative surgery. ",
                                "###URL#https://www.ncbi.nlm.nih.gov/pubmed/8630874")
                        ,
                        new ConceptDef()
                            .SetCode("IrregularMargin")
                            .SetDisplay("Irregular margin")
                            .MammoId("20")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("20",
                                "Edges around the soft tissue that don't look smooth. ",
                                "Indicative of some sort of growth or mass rather ",
                                "than a cyst.")
                        ,
                        new ConceptDef()
                            .SetCode("LobulatedMargin")
                            .SetDisplay("Lobulated margin")
                            .MammoId("19")
                            .ValidModalities(Modalities.US)
                            .SetUMLS("19",
                                "The edge of the mass has broad bulges. ",
                                "Much like a 6 or 8 leaf clover. ",
                                "The edge of all of the leaves would be considered ",
                                "lobulated.")
                        ,
                        new ConceptDef()
                            .SetCode("MacrolobulatedMargin")
                            .SetDisplay("Macrolobulated margin")
                            .MammoId("218")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("218",
                                "Smooth margin with distinct separation between the ",
                                "mass and the surrounding border. ",
                                "Macrolobulaed margins are  oval-shaped and  have ",
                                "a wide rather than tall formation.")
                        ,
                        new ConceptDef()
                            .SetCode("MicrolobulatedMargin")
                            .SetDisplay("Microlobulated margin")
                            .MammoId("111")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedCode("111",
                                "129739004")
                            .SetSnomedDescription("111",
                                "ClinicalFinding | Lesion with microlobulated margin ",
                                "(Finding)")
                            .SetUMLS("111",
                                "The margin is characterized by short-cycle undulations ",
                                "or scalloped appearance,and ",
                                "the margin of the mass is not circumscribed. ",
                                "###ACRUS#54")
                        ,
                        new ConceptDef()
                            .SetCode("NonCircumscribedMargin")
                            .SetDisplay("Non circumscribed margin")
                            .MammoId("383")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("383",
                                "ClinicalFinding | 129738007 | Lesion with circumscribed ",
                                "margin (Finding)")
                            .SetUMLS("383",
                                "The mass has one or more of the following features: ",
                                "indistinct,",
                                "angular, microlobulated, or spiculated in any portion",
                                "of the margin There is not a clear demarcation between ",
                                "the mass and the surrounding ",
                                "tissue. ",
                                "###ACRUS#153")
                        ,
                        new ConceptDef()
                            .SetCode("ObscuredMagin")
                            .SetDisplay("Obscured magin")
                            .MammoId("28")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("28",
                                "129740002")
                            .SetSnomedDescription("28",
                                "ClinicalFinding | Lesion with obscured margin (Finding)")
                            .SetUMLS("28",
                                "It is hidden by superimposed or adjacent fibroglandular ",
                                "tissue. ",
                                "This is used primarily when some of the margin of ",
                                "the mass is circumscribed, but ",
                                "the rest (more than 25%) is hidden.")
                        ,
                        new ConceptDef()
                            .SetCode("SmoothMargin")
                            .SetDisplay("Smooth margin")
                            .MammoId("18")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("18",
                                "The edges of the mass have a smooth appearance and ",
                                "distinct separation between the ",
                                "mass and surrounding tissue.")
                        ,
                        new ConceptDef()
                            .SetCode("SpiculatedMargin")
                            .SetDisplay("Spiculated margin")
                            .MammoId("29")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("29",
                                "129742005")
                            .SetSnomedDescription("29",
                                "ClinicalFinding | Lesion with spiculated margin (Finding)")
                            .SetUMLS("29",
                                "The margin is characterized by sharp lines radiating ",
                                "from the mass, often a sign ",
                                "of malignancy,",
                                "but the significant feature is that the margin of ",
                                "the mass is not circumscribed. ",
                                "###ACRUS#55")
                        #endregion // Codes
                        //- Codes
                    })
        );
    }
}
