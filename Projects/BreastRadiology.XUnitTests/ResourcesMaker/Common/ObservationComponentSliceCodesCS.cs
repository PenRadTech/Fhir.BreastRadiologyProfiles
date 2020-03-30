using Hl7.Fhir.Model;
using System;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        const String ObservationComponentSliceCodesName = "ObservationComponentSliceCodes";

        String ObservationComponentSliceCodesUrl => this.CodeSystemUrl(ObservationComponentSliceCodesName);

        Coding ComponentSliceCodeAbnormalityCystType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "abnormalityCystType",
                "Component code for 'Cyst Type' slice");

        Coding ComponentSliceCodeAbnormalityDuctType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "abnormalityDuctType",
                "Component code for 'Duct Type' slice");

        Coding ComponentSliceCodeAbnormalityFibroAdenomaType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "mgAbnormalityFibroAdenomaType",
                "Component code for 'FibroAdenoma Type' slice");

        Coding ComponentSliceCodeAbnormalityForeignObjectType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "abnormalityForeignObjectType",
                "Component code for 'Foreign Object Type' slice");

        Coding ComponentSliceCodeAbnormalityLymphNodeType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "abnormalityLymphNodeType",
                "Component code for 'Lymph Node Type' slice");

        Coding ComponentSliceCodeAbnormalityMassType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "abnormalityMassType",
                "Component code for 'Abnormality Mass Type' slice");

        Coding ComponentSliceCodeBiRads =>
            new Coding(this.ObservationComponentSliceCodesUrl, "targetBiRads",
                "Component code for 'BiRads Code' slice");

        Coding ComponentSliceCodeConsistentWithValue =>
            new Coding(this.ObservationComponentSliceCodesUrl, "consistentWithValue",
                "Component code for 'Consistent With Value' slice");

        Coding ComponentSliceCodeConsistentWithQualifier =>
            new Coding(this.ObservationComponentSliceCodesUrl, "consistentWithQualifier",
                "Component code for 'Consistent With Qualifier' slice");

        Coding ComponentSliceCodeCorrespondsWith =>
            new Coding(this.ObservationComponentSliceCodesUrl, "correspondsWith",
                "Component code for 'Corresponds With' slice");

        Coding ComponentSliceCodePreviouslyDemonstratedBy =>
            new Coding(this.ObservationComponentSliceCodesUrl, "prevDemBy",
                "Component code for 'Previously Demonstrated By' slice");

        Coding ComponentSliceCodeObservedChanges =>
            new Coding(this.ObservationComponentSliceCodesUrl, "obsChanges",
                "Component code for 'Observed Changes' slice");

        Coding ComponentSliceCodeMargin =>
            new Coding(this.ObservationComponentSliceCodesUrl, "margin", "Component code for 'Margin' slice");

        Coding ComponentSliceCodeMGDensity =>
            new Coding(this.ObservationComponentSliceCodesUrl, "mgDensity", "Component code for 'MG Density' slice");

        Coding ComponentSliceCodeNotPreviouslySeen =>
            new Coding(this.ObservationComponentSliceCodesUrl, "notPreviouslySeen",
                "Component code for 'Not Previously Seen' slice");

        Coding ComponentSliceCodeObservedSize =>
            new Coding(this.ObservationComponentSliceCodesUrl, "obsSize", "Component code for 'Observed Size' slice");

        Coding ComponentSliceCodeObservedDistribution =>
            new Coding(this.ObservationComponentSliceCodesUrl, "obsDistribution",
                "Component code for 'Observed Distribution' slice");

        Coding ComponentSliceCodeObservedCount =>
            new Coding(this.ObservationComponentSliceCodesUrl, "obsCount", "Component code for 'Observed Count' slice");

        Coding ComponentSliceCodeAssociatedFeatureType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "featureType",
                "Component code for 'Feature Type' slice");

        Coding ComponentSliceCodeOrientation =>
            new Coding(this.ObservationComponentSliceCodesUrl, "orientation", "Component code for 'Orientation' slice");

        Coding ComponentSliceCodeShape =>
            new Coding(this.ObservationComponentSliceCodesUrl, "shape", "Component code for 'Shape' slice");

        Coding MGComponentSliceCodeAbnormalityAsymmetryType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "mgAbnormalityAsymmetryType",
                "Component code for 'Abnormality Asymmetry Type' slice");

        Coding MGComponentSliceCodeAbnormalityDensityType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "mgAbnormalityDensityType",
                "Component code for 'Abnormality Density Type' slice");

        Coding MGComponentSliceCodeCalcificationType =>
            new Coding(this.ObservationComponentSliceCodesUrl, "mgCalcificationType",
                "Component code for 'Calcification Type' slice");

        Coding MGCodeCalcificationDistribution =>
            new Coding(this.ObservationComponentSliceCodesUrl, "mgCalcificationDistribution",
                "Component code for 'Distribution' slice");

        CSTaskVar ComponentSliceCodesCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    ObservationComponentSliceCodesName,
                    "Component Slice Codes CodeSystem",
                    "ComponentSliceCodes/ValueSet",
                    "Component Slice Codes code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeAbnormalityCystType)
                            .SetDefinition("Code to identify the component slice AbnormalityCystType."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeAbnormalityDuctType)
                            .SetDefinition("Code to identify the component slice AbnormalityDuctType."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeAbnormalityFibroAdenomaType)
                            .SetDefinition("Code to identify the component slice AbnormalityFibroAdenomaType."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeAbnormalityForeignObjectType)
                            .SetDefinition("Code to identify the component slice AbnormalityForeignObjectType."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeAbnormalityLymphNodeType)
                            .SetDefinition("Code to identify the component slice AbnormalityLymphNodeType."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeAbnormalityMassType)
                            .SetDefinition("Code to identify the component slice AbnormalityMassType."),

                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeBiRads)
                            .SetDefinition("Code to identify the component slice BiRads."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeConsistentWithValue)
                            .SetDefinition("Code to identify the component slice ConsistentWithValue."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeConsistentWithQualifier)
                            .SetDefinition("Code to identify the component slice ConsistentWithQualifier."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeCorrespondsWith)
                            .SetDefinition("Code to identify the component slice CorrespondsWith."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodePreviouslyDemonstratedBy)
                            .SetDefinition("Code to identify the component slice Previously Demonstrated By."),

                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeMargin)
                            .SetDefinition("Code to identify the component slice Margin."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeMGDensity)
                            .SetDefinition("Code to identify the component slice MGDensity."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeNotPreviouslySeen)
                            .SetDefinition("Code to identify the component slice Not Previously Seen."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeObservedChanges)
                            .SetDefinition("Code to identify the component slice Observed Changes."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeObservedCount)
                            .SetDefinition("Code to identify the component slice ObservedCount."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeObservedDistribution)
                            .SetDefinition("Code to identify the component slice ObservedDistribution."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeObservedSize)
                            .SetDefinition("Code to identify the component slice ObservedSize."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeAssociatedFeatureType)
                            .SetDefinition("Code to identify the component slice ObservedFeatureType."),

                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeOrientation)
                            .SetDefinition("Code to identify the component slice Orientation."),
                        new ConceptDef()
                            .SetCode(Self.ComponentSliceCodeShape)
                            .SetDefinition("Code to identify the component slice Shape."),

                        new ConceptDef()
                            .SetCode(Self.MGComponentSliceCodeAbnormalityAsymmetryType)
                            .SetDefinition("Code to identify the component slice MGCodeAbnormalityAsymmetryType."),
                        new ConceptDef()
                            .SetCode(Self.MGComponentSliceCodeAbnormalityDensityType)
                            .SetDefinition("Code to identify the component slice MGCodeAbnormalityDensityType."),

                        new ConceptDef()
                            .SetCode(Self.MGComponentSliceCodeCalcificationType)
                            .SetDefinition("Code to identify the component slice MGCalcificationType."),
                        new ConceptDef()
                            .SetCode(Self.MGCodeCalcificationDistribution)
                            .SetDefinition("Code to identify the component slice MGCalcificationDistribution."),
                    })
        );
    }
}