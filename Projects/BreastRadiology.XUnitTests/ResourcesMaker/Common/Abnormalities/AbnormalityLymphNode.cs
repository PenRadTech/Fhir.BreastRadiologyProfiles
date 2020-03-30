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
    partial class ResourcesMaker : ConverterBase
    {
        CSTaskVar AbnormalityLymphNodeCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "AbnormalityLymphNodeTypeCS",
                    "Lymph Node Type CodeSystem",
                    "Lymph Node Type/CodeSystem",
                    "Lymph node abnormality types code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Type
                        #region Codes
                        new ConceptDef()
                            .SetCode("NodeAxillary")
                            .SetDisplay("Node axillary")
                            .MammoId("648")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("648",
                                "BodyStructure | 68171009 | Axillary lymph node structure ",
                                "(Bodypart)")
                            .SetUMLS("648",
                                "The axillary nodes are a group of lymph nodes located ",
                                "in the axillary (or armpit) ",
                                "region of the body. ",
                                "Auxillary nodes perform the vital function of filtration ",
                                "and conduction of lymph from the upper ",
                                "limbs, pectoral region, and upper back. ",
                                "There are five axillary lymph node groups, ",
                                "namely the lateral (humeral), anterior (pectoral), ",
                                "posterior (subscapular), central ",
                                "and apical nodes.")
                        ,
                        new ConceptDef()
                            .SetCode("NodeEnlarged")
                            .SetDisplay("Node enlarged")
                            .MammoId("649")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedCode("649",
                                "274744005")
                            .SetSnomedDescription("649",
                                "ClinicalFinding | Localized enlarged lymph nodes ",
                                "(Disorder)")
                            .SetUMLS("649",
                                "Swollen lymph nodes usually occur as a result of ",
                                "infection from bacteria or viruses. ",
                                "Rarely, swollen lymph nodes are caused by cancer.",
                                "Lymph nodes, also called lymph glands, play a vital ",
                                "role in the body's ability ",
                                "to fight off infections.",
                                "Lymph nodes function as filters, trapping viruses, ",
                                "bacteria and other causes of illnesses ",
                                "prior to infecting the body. ",
                                " ",
                                "Common areas subject to swollen lymph nodes include ",
                                "the neck, under chin,  armpits and groin.")
                        ,
                        new ConceptDef()
                            .SetCode("NodeFocalCortex")
                            .SetDisplay("Node focal cortex")
                            .MammoId("662")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("662",
                                "The mammogram and/or ultrasound show enlargement ",
                                "of the cortex. ",
                                "Metastatic deposits accumulate in the lymph node ",
                                "peripheral area, causing enlargement of the cortex, ",
                                "usually focal (at early stages), or uniform. ",
                                "###URL#www.ncbi.nlm.nih.gov > pmc > articles > PMC4337126")
                        ,
                        new ConceptDef()
                            .SetCode("NodeInfraclavicular")
                            .SetDisplay("Node infraclavicular")
                            .MammoId("665")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("665",
                                "BodyStructure | 9659009 | Infraclavicular lymph node ",
                                "(Bodypart)")
                            .SetUMLS("665",
                                "(Infraclavicular labeled at upper left.) One or two ",
                                "deltopectoral lymph nodes (or ",
                                "infraclavicular nodes) are found beside the cephalic ",
                                "vein, between the pectoralis ",
                                "major and deltoideus, immediately below the clavicle ",
                                ". ",
                                "Lymph nodes are situated in the course of the external ",
                                "collecting trunks of the arm.")
                        ,
                        new ConceptDef()
                            .SetCode("NodeIntramammary")
                            .SetDisplay("Node intramammary")
                            .MammoId("650")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetSnomedDescription("650",
                                "BodyStructure | 443808008 | Structure of intramammary ",
                                "lymph node (Bodypart)")
                            .SetUMLS("650",
                                "Intramammary lymph nodes are defined as lymph nodes ",
                                "surrounded by breast tissue.")
                        ,
                        new ConceptDef()
                            .SetCode("NodeLymph")
                            .SetDisplay("Node lymph")
                            .MammoId("651")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("651",
                                "Abnormal lymph node viewed on ultrasound and/or ultrasound. ",
                                "Enlarged lymph nodes may warrant comment, clinical ",
                                "correlation and additional evaluation, especially ",
                                "if new or considerably larger or rounder when compared ",
                                "to previous examination. ",
                                "###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("NodeLymphNormal")
                            .SetDisplay("Node lymph normal")
                            .MammoId("652")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("652",
                                "The lymph node appears normal and is probably benign.")
                        ,
                        new ConceptDef()
                            .SetCode("NodeSupraclavicular")
                            .SetDisplay("Node supraclavicular")
                            .MammoId("666")
                            .ValidModalities(Modalities.US)
                            .SetSnomedDescription("666",
                                "BodyStructure | 76838003 | Structure of supraclavicular ",
                                "lymph node (Bodypart)")
                            .SetUMLS("666",
                                "The supraclavicular lymph nodes are a set of lymph ",
                                "nodes found just above the clavicle ",
                                "or collarbone, toward the hollow of the neck. ",
                                "Lymph nodes are responsible for filtering the lymphatic ",
                                "fluid of unwanted debris ",
                                "and bacteria.")
                        ,
                        new ConceptDef()
                            .SetCode("NodeUniformThickness")
                            .SetDisplay("Node uniform thickness")
                            .MammoId("663")
                            .ValidModalities(Modalities.MG | Modalities.US)
                            .SetUMLS("663",
                                "The mammogram and/or ultrasound shows thickening ",
                                "of the cortex is an indicator of an early change ",
                                "in metastasis. ",
                                " The qualitative methods used for the diagnosis of ",
                                "lymph node metastases on US include a round morphology, ",
                                "hypoechogenicity, loss of central hilum, or eccentric ",
                                "cortical hypertrophy.")
                        #endregion // Codes
                        //- Type
                    }
                )
        );


        VSTaskVar AbnormalityLymphNodeVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "AbnormalityLymphNodeTypeVS",
                    "Lymph Node ValueSet",
                    "Lymph Node/ValueSet",
                    "lymph node abnormality types value set.",
                    Group_CommonCodesVS,
                    Self.AbnormalityLymphNodeCS.Value()
                )
        );


        SDTaskVar AbnormalityLymphNode = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ValueSet binding = Self.AbnormalityLymphNodeVS.Value();

                SDefEditor e = Self.CreateEditor("AbnormalityLymphNode",
                            "LymphNode",
                            "Lymph Node",
                            Global.ObservationUrl,
                            $"{Group_CommonResources}/AbnormalityLymphNode",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.TumorSatelliteFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentShapeFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedCountFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedDistributionFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedSizeFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .Description("LymphNode Abnormality Observation",
                            new Markdown()
                                .Paragraph("This resource and referenced child resources contain ",
                                    "information about a lymph node abnormality observation ")
                        )
                    ;

                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeAbnormalityLymphNode.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeAbnormalityLymphNode.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    .MissingDescription()
                    ;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("lymphNodeType",
                    Self.ComponentSliceCodeAbnormalityLymphNodeType.ToCodeableConcept(),
                    binding,
                    BindingStrength.Required,
                    0,
                    "1",
                    "Lymph Node Type",
                    "refine the lymph node type");
            });
    }
}
