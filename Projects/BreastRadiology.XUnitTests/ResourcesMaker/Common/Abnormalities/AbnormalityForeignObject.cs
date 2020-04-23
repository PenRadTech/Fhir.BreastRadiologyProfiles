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
        CSTaskVar AbnormalityForeignObjectCS = new CSTaskVar(
            (out CodeSystem vs) =>
                vs = Self.CreateCodeSystem(
                    "ForeignObjectCS",
                    "Foreign Object CodeSystem",
                    "Foreign/Object/ CodeSystem",
                    "Foreign objects observed during a Breast Radiology exam code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Type
                        #region Codes
                        new ConceptDef()
                            .SetCode("BBPellet")
                            .SetDisplay("BB pellet")
                            .MammoId("532")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("532",
                                "ClinicalFinding | 283574001 | Pellet wound of breast ",
                                "(Disorder) | [0/0] | S21.039?")
                            .SetUMLS("532",
                                "A BB pellet is present in the body and is visible ",
                                "by the Mammogram, MRI and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("BBPellets")
                            .SetDisplay("BB pellets")
                            .MammoId("531")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("531",
                                "ClinicalFinding | 283574001 | Pellet wound of breast ",
                                "(Disorder) | [0/0] | S21.039?")
                            .SetUMLS("531",
                                "BB pellets are present in the body and is visible ",
                                "by the Mammogram, MRI and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("BiopsyClip")
                            .SetDisplay("Biopsy clip")
                            .MammoId("591")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("591",
                                "470272007")
                            .SetSnomedDescription("591",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("591",
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
                                "This review serves to familiarize the breast interventionalist ",
                                "with the tissue markers ",
                                "most widely available in the United States today ",
                                "and to provide guidance regarding ",
                                "selection of appropriate markers for various clinical ",
                                "settings. ",
                                "###URL#https://www.ncbi.nlm.nih.gov/pubmed/30059952")
                        ,
                        new ConceptDef()
                            .SetCode("BiopsyClips")
                            .SetDisplay("Biopsy clips")
                            .MammoId("910")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("910",
                                "470272007")
                            .SetSnomedDescription("910",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("910",
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
                                "This review serves to familiarize the breast interventionalist ",
                                "with the tissue markers ",
                                "most widely available in the United States today ",
                                "and to provide guidance regarding ",
                                "selection of appropriate markers for various clinical ",
                                "settings. ",
                                "###URL#https://www.ncbi.nlm.nih.gov/pubmed/30059952")
                        ,
                        new ConceptDef()
                            .SetCode("BreastMarker")
                            .SetDisplay("Breast Marker")
                            .MammoId("906")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedCode("906",
                                "470272007")
                            .SetSnomedDescription("906",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("906",
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
                                "This review serves to familiarize the breast interventionalist ",
                                "with the tissue markers ",
                                "most widely available in the United States today ",
                                "and to provide guidance regarding ",
                                "selection of appropriate markers for various clinical ",
                                "settings. ",
                                "www.ncbi.nlm.nih.gov > pubmed")
                        ,
                        new ConceptDef()
                            .SetCode("CatheterSleeves")
                            .SetDisplay("Catheter sleeves")
                            .MammoId("519")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("519",
                                "A catheter sleeve was viewed in the Mammogram, MRI, ",
                                "and/or ultrasound. ",
                                "A catheter is a flexible tube used to deliver fluids ",
                                "into or withdraw fluids from the body.")
                        ,
                        new ConceptDef()
                            .SetCode("ChemotherapyPort")
                            .SetDisplay("Chemotherapy port")
                            .MammoId("592")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("592",
                                "A soft thin tube called a catheter connects the port ",
                                "to a large vein for administering ",
                                "chemotherapy is present in the MRI/Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("Coil")
                            .SetDisplay("Coil")
                            .MammoId("517")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("517",
                                "470342004")
                            .SetSnomedDescription("517",
                                "PhysicalObject | Implantable tissue clip (Object)")
                            .SetUMLS("517",
                                "The coil acts as an antenna to receive the radio ",
                                "frequency signal. ",
                                "This is present on the Mammogram, MRI and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("Glass")
                            .SetDisplay("Glass")
                            .MammoId("522")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("522",
                                "283258005")
                            .SetSnomedDescription("522",
                                "ClinicalFinding | Glass in breast (Disorder)")
                            .SetUMLS("522",
                                "Glass is present in the body and shows up on the ",
                                "MRI, Mammogram, and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("GoldSeed")
                            .SetDisplay("Gold seed")
                            .MammoId("913")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("913",
                                "Tiny, gold seeds that are put in and/or around a ",
                                "tumor to show exactly where the ",
                                "tumor is are present in the ultrasound/MRI.")
                        ,
                        new ConceptDef()
                            .SetCode("GunshotWound")
                            .SetDisplay("Gunshot wound")
                            .MammoId("533")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("533",
                                "ClinicalFinding | 425055008 | Gunshot entry wound ",
                                "(Disorder) | [0/0] | T14.8")
                            .SetUMLS("533",
                                "There is a gunshot would present in the body and ",
                                "is viewable on the Ultrasound, Mammogram and/or MRI")
                        ,
                        new ConceptDef()
                            .SetCode("MarkerClip")
                            .SetDisplay("Marker clip")
                            .MammoId("575")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("575",
                                "470272007")
                            .SetSnomedDescription("575",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("575",
                                "A marker clip (from possible previous biopsy) is ",
                                "visable in the Mammogram")
                        ,
                        new ConceptDef()
                            .SetCode("Metal")
                            .SetDisplay("Metal")
                            .MammoId("521")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("521",
                                "283169003")
                            .SetSnomedDescription("521",
                                "ClinicalFinding | Metal foreign body in breast (Disorder)")
                            .SetUMLS("521",
                                "A piece of metal is present in the body and is viewable ",
                                "on the MRI and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("MetallicMarker")
                            .SetDisplay("Metallic marker")
                            .MammoId("903")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedCode("903",
                                "470272007")
                            .SetSnomedDescription("903",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("903",
                                "A metallic tissue marker is present in the ultrasound/MRI.")
                        ,
                        new ConceptDef()
                            .SetCode("MetallicMarkers")
                            .SetDisplay("Metallic markers")
                            .MammoId("904")
                            .ValidModalities(Modalities.MRI)
                            .SetSnomedCode("904",
                                "470272007")
                            .SetSnomedDescription("904",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("904",
                                "Metallic tissue markers are present in the MRI/Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("MetallicObjects")
                            .SetDisplay("Metallic objects")
                            .MammoId("593")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("593",
                                "ClinicalFinding | 283169003 | Metal foreign body ",
                                "in breast (Disorder) | [0/0] | S21.009?")
                            .SetUMLS("593",
                                "The Mammogram suggests a foreign body in the breast ",
                                "that appears to be a metallic ",
                                "object.")
                        ,
                        new ConceptDef()
                            .SetCode("Needle")
                            .SetDisplay("Needle")
                            .MammoId("597")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("597",
                                "The Mammogram suggests a foreign body in the breast ",
                                "that appears to be a needle.")
                        ,
                        new ConceptDef()
                            .SetCode("NippleJewelry")
                            .SetDisplay("Nipple jewelry")
                            .MammoId("598")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedCode("598",
                                "80919006")
                            .SetSnomedDescription("598",
                                "PhysicalObject | Jewelry (Object)")
                            .SetUMLS("598",
                                "The Mammogram suggests a foreign body in the breast ",
                                "that appears to be a piece of ",
                                "nipple jewelry.")
                        ,
                        new ConceptDef()
                            .SetCode("Non-metallicBody")
                            .SetDisplay("Non-metallic body")
                            .MammoId("594")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("594",
                                "A non-metallic foreign body was located in the breast ",
                                "tissue.")
                        ,
                        new ConceptDef()
                            .SetCode("Pacemaker")
                            .SetDisplay("Pacemaker")
                            .MammoId("529")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("529",
                                "A pacemaker is present showing up on the MRI and/or ",
                                "Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("SiliconeGranuloma")
                            .SetDisplay("Silicone granuloma")
                            .MammoId("520")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("520",
                                "Silicone granuloma shows up on the MRI and/or Ultrasound. ",
                                "Snowball like hyperechogenic axillary lymph nodes ",
                                "in an individual with silicone implants ",
                                "removed due to complications. ",
                                "Specialty. ",
                                "Dermatology. ",
                                "Silicone granulomas are a skin condition that occur ",
                                "as a reaction to liquid silicones, ",
                                "and are characterized by the formation of nodules.")
                        ,
                        new ConceptDef()
                            .SetCode("Sponge")
                            .SetDisplay("Sponge")
                            .MammoId("535")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("535",
                                "PhysicalObject | 706640008 | Sponge (Object)")
                            .SetUMLS("535",
                                "A surgical sponge can be viewed from the images in ",
                                "the Mammogram, MRI and/or ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalClip")
                            .SetDisplay("Surgical clip")
                            .MammoId("911")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("911",
                                "470342004")
                            .SetSnomedDescription("911",
                                "PhysicalObject | Implantable tissue clip (Object)")
                            .SetUMLS("911",
                                "A surgical clip can be viewed within the Mammogram, ",
                                "MRI and/or Ultrasound. ",
                                "A tissue marker (or clip) is placed in the breast ",
                                "after a breast biopsy to help locate the site for ",
                                "future reference.")
                        ,
                        new ConceptDef()
                            .SetCode("SurgicalClips")
                            .SetDisplay("Surgical clips")
                            .MammoId("596")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("596",
                                "470342004")
                            .SetSnomedDescription("596",
                                "PhysicalObject | Implantable tissue clip (Object)")
                            .SetUMLS("596",
                                "Surgical clips can be viewed within the Mammogram, ",
                                "MRI and/or Ultrasound. ",
                                "A tissue marker (or clip) is placed in the breast ",
                                "after a breast biopsy to help locate the site for ",
                                "future reference.")
                        ,
                        new ConceptDef()
                            .SetCode("Swab")
                            .SetDisplay("Swab")
                            .MammoId("534")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedDescription("534",
                                "PhysicalObject | 408098004 | Swab (Object")
                            .SetUMLS("534",
                                "A Retained surgical swab appears to have been identified ",
                                "in the breast during the ",
                                "mammogram, ultrasound and/or MRI.")
                        ,
                        new ConceptDef()
                            .SetCode("TitaniumClip")
                            .SetDisplay("Titanium clip")
                            .MammoId("528")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("528",
                                "470272007")
                            .SetSnomedDescription("528",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("528",
                                "In review of the MRI, Ultrasound, and/or Mammogram, ",
                                "a titanium-based marker (also known as a \"clip\") can ",
                                "be viewed inside the breast. ",
                                "This is placed for most core biopsies to mark the ",
                                "area in case surgery will be needed in the future. ",
                                "These marker clips are placed at most facilities ",
                                "around the country, and are considered a standard ",
                                "part of the breast biopsy procedure.###URL#https://med.nyu.edu/radiology/about-nyu-langone-radiology/subspecialty-sections/breast-imaging/image-guided-procedures")
                        ,
                        new ConceptDef()
                            .SetCode("TitaniumClips")
                            .SetDisplay("Titanium clips")
                            .MammoId("530")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("530",
                                "470272007")
                            .SetSnomedDescription("530",
                                "PhysicalObject | Implantable lesion localization ",
                                "marker (Object)")
                            .SetUMLS("530",
                                "In review of the MRI, Ultrasound, and/or Mammogram, ",
                                "a titanium-based marker (also known as a \"clip\") can ",
                                "be viewed inside the breast. ",
                                "This is placed for most core biopsies to mark the ",
                                "area in case surgery will be needed in the future. ",
                                "These marker clips are placed at most facilities ",
                                "around the country, and are considered a standard ",
                                "part of the breast biopsy procedure.###URL#https://med.nyu.edu/radiology/about-nyu-langone-radiology/subspecialty-sections/breast-imaging/image-guided-procedures")
                        ,
                        new ConceptDef()
                            .SetCode("Wire")
                            .SetDisplay("Wire")
                            .MammoId("518")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("518",
                                "Guidewire is present in the body. ",
                                " It is viewable in the MRI and/or Ultrasound. ",
                                "Guidewire is used during medical procedures such ",
                                "as biopsy or placement of medical ",
                                "devices such as a catheter or pacemaker.")
                        ,
                        new ConceptDef()
                            .SetCode("WireFragment")
                            .SetDisplay("Wire fragment")
                            .MammoId("527")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("527",
                                "A fragment of a guidewire is present in the body. ",
                                "It is viewable in the MRI and/or Ultrasound. ",
                                " Guidewire is used during medical procedures such ",
                                "as a biopsy or  placement of medical ",
                                "devices such as a catheter or pacemaker.")
                        #endregion // Codes
                        //- Type
                    })
        );


        VSTaskVar AbnormalityForeignObjectVS = new VSTaskVar(
            (out ValueSet vs) =>
            {
                vs = Self.CreateValueSet(
                    "ForeignObjectVS",
                    "Foreign Object ValueSet",
                    "Foreign/Object/ValueSet",
                    "Foreign objects observed during a Breast Radiology exam value set",
                    Group_CommonCodesVS,
                    Self.AbnormalityForeignObjectCS.Value());

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

        SDTaskVar AbnormalityForeignObject = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.AbnormalityForeignObjectVS.Value();

                SDefEditor e = Self.CreateEditor("AbnormalityForeignObject",
                            "Foreign Object",
                            "Foreign Object",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/AbnormalityForeign",
                            "ObservationSection")
                        .Description("Foreign Object Observation",
                            new Markdown()
                                .Paragraph("This resource and referenced child resources contain ",
                                    "information about foreign objects observed")
                                .Paragraph("A foreign object is some non-biological item observed in the patient.",
                                    "These can include misplaced surgical items, trauma related items (bullet fragments), or ",
                                    "jewelery.")
                        )
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentBiRadFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberConsistentWithFragment.Value())
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
                    .Pattern(Self.ObservationCodeAbnormalityForeignObject.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeAbnormalityForeignObject.ToCodeableConcept())
                    ;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("abnormalityForeignObjectType",
                    Self.ComponentSliceCodeAbnormalityForeignObjectType.ToCodeableConcept(),
                    binding,
                    BindingStrength.Required,
                    1,
                    "1",
                    "Foreign Object Type",
                    "refine the foreign object type");
            });
    }
}
