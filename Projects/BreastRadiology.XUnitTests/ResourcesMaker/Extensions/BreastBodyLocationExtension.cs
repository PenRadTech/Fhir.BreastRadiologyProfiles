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
        CSTaskVar BreastLocationRegionCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "BreastLocationRegionCS",
                    "Breast Location Region CodeSystem",
                    "Breast Location/Region CodeSystem",
                    "Breast body location region code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Regions
                        #region Codes
                        new ConceptDef()
                            .SetCode("Axilla")
                            .SetDisplay("Axilla")
                            .MammoId("1015")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("1015",
                                "BodyStructure | 416710001 | Skin and subcutaneous ",
                                "tissue structure of axilla")
                            .SetUMLS("1015",
                                "The axilla (also, armpit, underarm or oxter) is the ",
                                "area on the human body directly ",
                                "under the joint where the arm connects to the shoulder. ",
                                "It also contains many sweat glands. ",
                                "###URL#https://en.wikipedia.org/wiki/Axilla")
                        ,
                        new ConceptDef()
                            .SetCode("AxillaryTail")
                            .SetDisplay("Axillary tail")
                            .MammoId("1014")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1014",
                                "BodyStructure | 38412008 | Structure of axillary ",
                                "tail of breast (Bodypart)")
                            .SetUMLS("1014",
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
                            .SetCode("AxillaI")
                            .SetDisplay("Axilla I")
                            .MammoId("AxillaI")
                            .SetUMLS("AxillaI",
                                "There are three levels of axillary lymph nodes (the ",
                                "nodes in the underarm or \"axilla\" area): Level I is ",
                                "the bottom level, below the lower edge of the pectoralis ",
                                "minor muscle. ",
                                "###URL#https://www.breastcancer.org/treatment/surgery/lymph_node_removal/axillary_dissection")
                        ,
                        new ConceptDef()
                            .SetCode("AxillaII")
                            .SetDisplay("Axilla II")
                            .MammoId("AxillaII")
                            .SetUMLS("AxillaII",
                                "There are three levels of axillary lymph nodes (the ",
                                "nodes in the underarm or \"axilla\" area):Level II is ",
                                "lying underneath the pectoralis minor muscle. ",
                                "###URL#https://www.breastcancer.org/treatment/surgery/lymph_node_removal/axillary_dissection")
                        ,
                        new ConceptDef()
                            .SetCode("AxillaIII")
                            .SetDisplay("Axilla III")
                            .MammoId("AxillaIII")
                            .SetUMLS("AxillaIII",
                                "There are three levels of axillary lymph nodes (the ",
                                "nodes in the underarm or \"axilla\" area): Level III ",
                                "is above the pectoralis minor muscle. ",
                                "###URL#https://www.breastcancer.org/treatment/surgery/lymph_node_removal/axillary_dissection")
                        ,
                        new ConceptDef()
                            .SetCode("InframammaryFold")
                            .SetDisplay("Inframammary fold")
                            .MammoId("1515")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("1515",
                                "The mass/lesion is located in the inframammary crease ",
                                "where the lower boundary of the breast and the chest ",
                                "meet.")
                        ,
                        new ConceptDef()
                            .SetCode("InSkin")
                            .SetDisplay("In skin")
                            .MammoId("1511")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("1511",
                                "Located within the skin.")
                        ,
                        new ConceptDef()
                            .SetCode("CentralToNipple")
                            .SetDisplay("Central to nipple")
                            .MammoId("1013")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1013",
                                "BodyStructure | 49058007 | Structure of central portion ",
                                "of breast (Bodypart)")
                            .SetUMLS("1013",
                                "Central to the nipple (central portion of the breast-behind ",
                                "the nipple).")
                        #endregion // Codes
                        //- Regions
                        //new ConceptDef()
                        //    .SetCode("RetroaReolar", "RetroaReolar Region")
                        //    .SetDefinition("Central location in the anterior third of the breast close to the nipple."),
                    })
        );

        CSTaskVar BreastLocationQuadrantCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "BreastLocationQuadrantCS",
                    "Breast Location Quadrant CodeSystem",
                    "Breast Location/Quadrant CodeSystem",
                    "Breast body location quadrant code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Quadrants
                        #region Codes
                        new ConceptDef()
                            .SetCode("InferiorMedialQuadrent")
                            .SetDisplay("Inferior medial quadrent (lower inner)")
                            .MammoId("1024")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1024",
                                "BodyStructure | 19100000 | Structure of lower inner ",
                                "quadrant of breast (Bodypart)")
                            .SetUMLS("1024",
                                "The lower inside (closest to the cleavage of the ",
                                "breasts) quadrant of each breast. ",
                                "There are 4 quadrants to the anatomy of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("InferiorLateralQuadrent")
                            .SetDisplay("Inferior lateral quadrent (lower outer)")
                            .MammoId("1025")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1025",
                                "BodyStructure | 33564002 | Structure of lower outer ",
                                "quadrant of breast (Bodypart)")
                            .SetUMLS("1025",
                                "The upper inside (closest to the armpit of each breast) ",
                                "quadrant of each breast. ",
                                "There are 4 quadrants to the anatomy of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("SuperiorMedialQuadrent")
                            .SetDisplay("Superior medial quadrent (upper inner)")
                            .MammoId("1022")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1022",
                                "BodyStructure | 77831004 | Structure of upper inner ",
                                "quadrant of breast (Bodypart)")
                            .SetUMLS("1022",
                                "The upper inside (closest to the cleavage of the ",
                                "breasts) quadrant of each breast. ",
                                "There are 4 quadrants to the anatomy of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("SuperiorLateralQuadrent")
                            .SetDisplay("Superior lateral quadrent (upper outer)")
                            .MammoId("1023")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1023",
                                "BodyStructure | 76365002 | Structure of upper outer ",
                                "quadrant of breast (Bodypart)")
                            .SetUMLS("1023",
                                "The upper outside (closest to the armpit on each ",
                                "breast) quadrant of each breast. ",
                                "There are 4 quadrants to the anatomy of the breast.")
                        #endregion // Codes
                        //- Quadrants
                    })
        );

        CSTaskVar BreastLocationClockCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "BreastLocationClockCS",
                    "Breast Location Clock CodeSystem",
                    "Breast Location/Clock CodeSystem",
                    "Breast body location angles (expressed in clock-face units) code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ ClockPositions
                        #region Codes
                        new ConceptDef()
                            .SetCode("1O'clock")
                            .SetDisplay("1 o'clock")
                            .MammoId("1001")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1001",
                                "ClinicalFinding | 129772004 | 1 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1001",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "1 o'clock position is at the 1 o'clock position and ",
                                "in the Upper Inner Quandrant ",
                                "(UIQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("2O'clock")
                            .SetDisplay("2 o'clock")
                            .MammoId("1002")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1002",
                                "ClinicalFinding | 129773009 | 2 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1002",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "2 o'clock position is at the 2 o'clock position and ",
                                "in the Upper Inner Quandrant ",
                                "(UIQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("3O'clock")
                            .SetDisplay("3 o'clock")
                            .MammoId("1003")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1003",
                                "ClinicalFinding | 129774003 | 3 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1003",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "3 o'clock position is at the 3 o'clock position.")
                        ,
                        new ConceptDef()
                            .SetCode("4O'clock")
                            .SetDisplay("4 o'clock")
                            .MammoId("1004")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1004",
                                "ClinicalFinding | 129775002 | 4 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1004",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "4 o'clock position is at the 4 o'clock position and ",
                                "in the Lower Inner Quandrant ",
                                "(LIQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("5O'clock")
                            .SetDisplay("5 o'clock")
                            .MammoId("1005")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1005",
                                "ClinicalFinding | 129776001 | 5 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1005",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "5 o'clock position is at the 5 o'clock position and ",
                                "in the Lower Inner Quandrant ",
                                "(LIQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("6O'clock")
                            .SetDisplay("6 o'clock")
                            .MammoId("1006")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1006",
                                "ClinicalFinding | 129777005 | 6 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1006",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "6 o'clock position is at the 6 o'clock position.")
                        ,
                        new ConceptDef()
                            .SetCode("7O'clock")
                            .SetDisplay("7 o'clock")
                            .MammoId("1007")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1007",
                                "ClinicalFinding | 129778000 | 7 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1007",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "7 o'clock position is at the 7 o'clock position and ",
                                "in the Lower Outer Quandrant ",
                                "(LOQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("8O'clock")
                            .SetDisplay("8 o'clock")
                            .MammoId("1008")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1008",
                                "ClinicalFinding | 129779008 | 8 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1008",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "8 o'clock position is at the 8 o'clock position and ",
                                "in the Lower Outer Quandrant ",
                                "(LOQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("9O'clock")
                            .SetDisplay("9 o'clock")
                            .MammoId("1009")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1009",
                                "ClinicalFinding | 129780006 | 9 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1009",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "9 o'clock position is at the 9 o'clock position.")
                        ,
                        new ConceptDef()
                            .SetCode("10O'clock")
                            .SetDisplay("10 o'clock")
                            .MammoId("1010")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1010",
                                "ClinicalFinding | 129781005 | 10 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1010",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "10 o'clock position is at the 10 o'clock position ",
                                "and in the Upper Outer Quandrant ",
                                "(UOQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("11O'clock")
                            .SetDisplay("11 o'clock")
                            .MammoId("1011")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1011",
                                "ClinicalFinding | 129782003 | 11 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1011",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "11 o'clock position is at the 11 o'clock position ",
                                "and in the Upper Outer Quandrant ",
                                "(UOQ) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("12O'clock")
                            .SetDisplay("12 o'clock")
                            .MammoId("1012")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1012",
                                "ClinicalFinding | 129783008 | 12 o'clock position ",
                                "on mammogram (Finding) | [0/0] |")
                            .SetUMLS("1012",
                                "Just like the hands of a clock, this is how to describe ",
                                "the position of the tumor ",
                                "in the breast. ",
                                "12 o'clock position is at the 12 o'clock position.")
                        #endregion // Codes
                        //- ClockPositions
                    })
        );

        CSTaskVar BreastLocationDepthCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "BreastLocationDepthCS",
                    "Breast Location Depth CodeSystem",
                    "Breast Location/Depth CodeSystem",
                    "Breast body location depth code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Depth
                        #region Codes
                        new ConceptDef()
                            .SetCode("AnteriorDepth")
                            .SetDisplay("Anterior depth")
                            .MammoId("1017")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1017",
                                "Not found")
                            .SetUMLS("1017",
                                "The breast is divided into anterior, middle and posterior ",
                                "depth. ",
                                "The location of any lesion is given when discussed ",
                                "in the medical profession, with ",
                                "reference to a quadrant or 'clock position,' and the ",
                                "depth within the breast.",
                                "Anterior depth is the outer most depth (closest to ",
                                "the nipple) of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("MiddleDepth")
                            .SetDisplay("Middle depth")
                            .MammoId("1018")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1018",
                                "Not found")
                            .SetUMLS("1018",
                                "Middle depth in between the anterior and posterior ",
                                "portion of the breast.")
                        ,
                        new ConceptDef()
                            .SetCode("PosteriorDepth")
                            .SetDisplay("Posterior depth")
                            .MammoId("1019")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("1019",
                                "QualifierValue | 255551008 | Posterior (Qualifier) ",
                                "+ depth")
                            .SetUMLS("1019",
                                "Posterior depth (closest to the chest wall) of the ",
                                " breast.")
                        #endregion // Codes
                        //- Depth
                    })
        );

        VSTaskVar BreastLocationRegionVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "BreastLocationRegionVS",
                    "Breast Location Region ValueSet",
                    "Breast Location/Region ValueSet",
                    "Breast body location region value set.",
                    Group_CommonCodesVS,
                    Self.BreastLocationRegionCS.Value()
                )
        );

        VSTaskVar BreastLocationClockVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "BreastLocationClockVS",
                    "Breast Location Clock ValueSet",
                    "Breast Location/Clock ValueSet",
                    "Breast body location angles (expressed in clock-face units) value set.",
                    Group_CommonCodesVS,
                    Self.BreastLocationClockCS.Value()
                )
        );

        VSTaskVar BreastLocationDepthVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "BreastLocationDepthVS",
                    "Breast Location Depth ValueSet",
                    "Breast Location/Depth ValueSet",
                    "Breast body location depth value set.",
                    Group_CommonCodesVS,
                    Self.BreastLocationDepthCS.Value()
                )
        );

        VSTaskVar BreastLocationQuadrantVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "BreastLocationQuadrantVS",
                    "Breast Location Quadrant ValueSet",
                    "Breast Location/Quadrant ValueSet",
                    "Breast body location quadrant code system value set.",
                    Group_CommonCodesVS,
                    Self.BreastLocationQuadrantCS.Value()
                )
        );

        //$ Fix: complex extension is wrong - subslices are not identified.
        public SDTaskVar BreastBodyLocationExtension = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e;
                ElementTreeNode extensionNode;

                e = Self.CreateEditor("BreastBodyLocationExtension",
                            "Breast Body Location Extension",
                            "Breast Body\nLocation",
                            Global.ExtensionUrl,
                            $"{Group_ExtensionResources}/BreastBodyLocation",
                            "Extension")
                        .Description("Breast Body Location extension",
                            new Markdown()
                                .Paragraph("this extension defines the fields that are used to describe the",
                                    "location of an observed item in a breast radiology report.")
                                .Paragraph(
                                    "Breast radiology exams have specific ways of defining a location that are unique to this field.")
                        )
                        .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                        .Context()
                    ;
                s = e.SDef;

                e.AddFragRef(Self.HeaderFragment);

                e.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e.SDef.Url));

                e.Select("value[x]").Zero();

                extensionNode = e.ConfigureSliceByUrlDiscriminator("extension", true);

                {
                    ValueSet binding = Self.LateralityVS.Value();

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

                    ElementDefinition sliceDef = Self.SliceAndBindVS(e,
                                extensionNode,
                                "laterality",
                                binding,
                                "Body side",
                                new Markdown().Paragraph("The side of the body being examined."))
                            .ZeroToOne()
                        ;

                    e.AddComponentLink("Laterality",
                        new SDefEditor.Cardinality(sliceDef),
                        null,
                        Global.ElementAnchor(sliceDef),
                        "CodeableConcept",
                        binding.Url);
                }

                {
                    ValueSet binding = Self.BreastLocationQuadrantVS.Value();

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

                    ElementDefinition sliceDef = Self.SliceAndBindVS(e,
                                extensionNode,
                                "quadrant",
                                binding,
                                "Quadrant of the body location",
                                new Markdown().Paragraph("The quadrant  of the body location."))
                            .ZeroToOne()
                        ;

                    e.AddComponentLink("Quadrant",
                        new SDefEditor.Cardinality(sliceDef),
                        null,
                        Global.ElementAnchor(sliceDef),
                        "CodeableConcept",
                        binding.Url);
                }

                {
                    ValueSet binding = Self.BreastLocationRegionVS.Value();

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

                    ElementDefinition sliceDef = Self.SliceAndBindVS(e,
                                extensionNode,
                                "region",
                                binding,
                                "Region of the body location",
                                new Markdown().Paragraph("The region  of the body location."))
                            .ZeroToMany()
                        ;

                    e.AddComponentLink("Region",
                        new SDefEditor.Cardinality(sliceDef),
                        null,
                        Global.ElementAnchor(extensionNode.ElementDefinition),
                        "CodeableConcept",
                        binding.Url);
                }

                {
                    ValueSet binding = Self.BreastLocationClockVS.Value();

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

                    ElementDefinition sliceDef = Self.SliceAndBindVS(e,
                                extensionNode,
                                "clockDirection",
                                binding,
                                "Clock direction of the body location",
                                new Markdown().Paragraph("The clock direction of the body location."))
                            .ZeroToOne()
                        ;

                    e.AddComponentLink("ClockDirection",
                        new SDefEditor.Cardinality(sliceDef),
                        null,
                        Global.ElementAnchor(extensionNode.ElementDefinition),
                        "CodeableConcept",
                        binding.Url);
                }

                {
                    ValueSet binding = Self.BreastLocationDepthVS.Value();
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

                    ElementDefinition sliceDef = Self.SliceAndBindVS(e,
                                extensionNode,
                                "depth",
                                binding,
                                "Depth of the body location",
                                new Markdown().Paragraph("The depth of the body location."))
                            .ZeroToOne()
                        ;

                    e.AddComponentLink("Depth",
                        new SDefEditor.Cardinality(sliceDef),
                        null,
                        Global.ElementAnchor(extensionNode.ElementDefinition),
                        "CodeableConcept",
                        binding.Url);
                }
                /*
                 * Distance from Nipple
                 * Distance from ChestWall
                 * Distance from Skin
                 */
                {
                    StructureDefinition extensionStructDef = Self.BodyDistanceFromExtension.Value();
                    ElementTreeSlice extensionSlice = e.ApplyExtension("distanceFromLandmark", extensionStructDef, true);
                    extensionSlice.ElementDefinition.ZeroToMany();
                    e.AddExtensionLink(extensionStructDef.Url,
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        "Distance From Landmark, like nipple, chest wall, skin.",
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        false);
                }
                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    ;
            });
    }
}
