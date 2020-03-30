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
        /*

Observation SectionFindingsRightBreast
         */
        const String ObservationCodesName = "ObservationCodes";
        String ObservationCodesUrl => this.CodeSystemUrl(ObservationCodesName);

        Coding ObservationCodeMGFinding =>
            new Coding(this.ObservationCodesUrl, "mgFindingObservationObservation", "MG Finding observation");

        Coding ObservationCodeAbnormalityCyst =>
            new Coding(this.ObservationCodesUrl, "abnormalityCyst", "Abnormality Cyst observation");

        Coding ObservationCodeAssociatedFeature =>
            new Coding(this.ObservationCodesUrl, "associatedFeaturesObservation", "Associated Features observation");

        Coding ObservationCodeMGAbnormalityArchitecturalDistortion =>
            new Coding(this.ObservationCodesUrl, "mgAbnormalityArchitecturalDistortionObservation",
                "Abnormality Architectural Distortion observation");

        Coding ObservationCodeConsistentWith =>
            new Coding(this.ObservationCodesUrl, "consistentWithObservation", "Consistent With observation");

        Coding ObservationCodeTumorSatellite =>
            new Coding(this.ObservationCodesUrl, "tumorSatelliteObservation", "Tumor Satellite observation");

        Coding ObservationCodeMGAbnormalityCalcification =>
            new Coding(this.ObservationCodesUrl, "mgAbnormalityCalcificationObservation",
                "Abnormality Calcification observation");

        Coding ObservationCodeAbnormalityDuct =>
            new Coding(this.ObservationCodesUrl, "abnormalityDuctObservation", "Abnormality Duct observation");

        Coding ObservationCodeAbnormalityForeignObject =>
            new Coding(this.ObservationCodesUrl, "abnormalityForeignObjectObservation",
                "Abnormality Foreign Object observation");

        Coding ObservationCodeAbnormalityLymphNode =>
            new Coding(this.ObservationCodesUrl, "abnormalityLymphNodeObservation",
                "Abnormality Lymph Node observation");

        Coding ObservationCodeAbnormalityMass =>
            new Coding(this.ObservationCodesUrl, "abnormalityMassObservation", "Abnormality Mass observation");

        Coding ObservationCodeAbnormalityFibroadenoma =>
            new Coding(this.ObservationCodesUrl, "abnormalityFibroadenomaObservation",
                "Abnormality Fibroadenoma observation");

        Coding ObservationCodeMGAbnormalityAsymmetry =>
            new Coding(this.ObservationCodesUrl, "mgAbnormalityAsymmetryObservation",
                "MG Abnormality Asymmetry observation");

        Coding ObservationCodeMGAbnormalityDensity =>
            new Coding(this.ObservationCodesUrl, "mgAbnormalityDensityObservation",
                "MG Abnormality Density observation");

        Coding ObservationCodeMGAbnormalityFatNecrosis =>
            new Coding(this.ObservationCodesUrl, "mgAbnormalityFatNecrosisObservation",
                "MG Abnormality FatNecrosis observation");

        Coding ObservationCodeMGBreastDensity =>
            new Coding(this.ObservationCodesUrl, "mgBreastDensityObservation", "MG Breast Density observation");

        Coding ObservationCodeMRIFinding =>
            new Coding(this.ObservationCodesUrl, "mriFindingObservation", "MRI Finding observation");

        Coding ObservationCodeNMFinding =>
            new Coding(this.ObservationCodesUrl, "nmFindingObservation", "NM Findingobservation");

        Coding ObservationCodeUSFinding =>
            new Coding(this.ObservationCodesUrl, "usFindingObservation", "US Finding observation");

        Coding ObservationCodeFindingsRightBreast =>
            new Coding(this.ObservationCodesUrl, "findingsRightBreastObservation", "Findings Right Breast observation");

        Coding ObservationCodeFindingsLeftBreast =>
            new Coding(this.ObservationCodesUrl, "findingsLeftBreastObservation", "Findings Left Breast observation");

        CSTaskVar ObservationCodesCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    ObservationCodesName,
                    "Observation Codes CodeSystem",
                    "Observation Codes/ValueSet",
                    "Observation Codes code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMGFinding)
                            .SetDefinition("Observation.code to identify an MGFinding observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeAbnormalityCyst)
                            .SetDefinition("Observation.code to identify an AbnormalityCyst observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeAssociatedFeature)
                            .SetDefinition("Observation.code to identify an AssociatedFeatures observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMGAbnormalityArchitecturalDistortion)
                            .SetDefinition(
                                "Observation.code to identify an MGAbnormalityArchitecturalDistortion observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeConsistentWith)
                            .SetDefinition("Observation.code to identify a ConsistentWith observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeTumorSatellite)
                            .SetDefinition("Observation.code to identify a TumorSatellite observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMGAbnormalityCalcification)
                            .SetDefinition("Observation.code to identify an MGAbnormalityCalcification observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeAbnormalityDuct)
                            .SetDefinition(
                                "Observation.code to identify an ObservationCodeAbnormalityDuct observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeAbnormalityForeignObject)
                            .SetDefinition("Observation.code to identify an AbnormalityForeignObject observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeAbnormalityLymphNode)
                            .SetDefinition("Observation.code to identify an AbnormalityLymphNode observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeAbnormalityMass)
                            .SetDefinition("Observation.code to identify an AbnormalityMass observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeAbnormalityFibroadenoma)
                            .SetDefinition("Observation.code to identify an AbnormalityFibroadenoma observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMGAbnormalityAsymmetry)
                            .SetDefinition("Observation.code to identify an MGAbnormalityAsymmetry observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMGAbnormalityDensity)
                            .SetDefinition("Observation.code to identify an MGAbnormalityDensity observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMGAbnormalityFatNecrosis)
                            .SetDefinition("Observation.code to identify an MGAbnormalityFatNecrosis observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMGBreastDensity)
                            .SetDefinition("Observation.code to identify an MGBreastDensity observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeMRIFinding)
                            .SetDefinition("Observation.code to identify an MRIFinding observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeNMFinding)
                            .SetDefinition("Observation.code to identify an NMFinding observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeUSFinding)
                            .SetDefinition("Observation.code to identify a USFinding observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeFindingsLeftBreast)
                            .SetDefinition("Observation.code to identify a SectionFindingsLeftBreast observation."),
                        new ConceptDef()
                            .SetCode(Self.ObservationCodeFindingsRightBreast)
                            .SetDefinition("Observation.code to identify a SectionFindingsRightBreast observation."),
                    })
        );
    }
}