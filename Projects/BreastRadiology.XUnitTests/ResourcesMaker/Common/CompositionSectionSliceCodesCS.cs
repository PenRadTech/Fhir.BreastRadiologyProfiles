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
        const string CompositionSectionSliceCodesName = "CompositionSectionSliceCodes";
        String CompositionSectionSliceCodesUrl => this.CodeSystemUrl(CompositionSectionSliceCodesName);

        Coding SectionCodeReport =>
            new Coding(this.CompositionSectionSliceCodesUrl, "sectionReport",
                "Code to identify the 'Report' section slice");

        Coding SectionCodeImpressions =>
            new Coding(this.CompositionSectionSliceCodesUrl, "sectionImpressions",
                "Code to identify the 'Impressions' section slice");

        Coding SectionCodeRelatedResources =>
            new Coding(this.CompositionSectionSliceCodesUrl, "sectionRelatedResources",
                "Code to identify the 'RelatedResources' section slice");

        Coding SectionCodeRecommendations =>
            new Coding(this.CompositionSectionSliceCodesUrl, "sectionCodeRecommendations",
                "Code to identify the 'Recommendations' section slice");

        Coding SectionCodeFindingsLeftBreast =>
            new Coding(this.CompositionSectionSliceCodesUrl, "sectionCodeFindingsLeftBreast",
                "Code to identify the 'Findings Left Breast' section slice");

        Coding SectionCodeFindingsRightBreast =>
            new Coding(this.CompositionSectionSliceCodesUrl, "sectionCodeFindingsRightBreast",
                "Code to identify the 'Findings Right Breast' section slice");

        Coding SectionCodeAdmin =>
            new Coding(this.CompositionSectionSliceCodesUrl, "sectionCodeAdmin",
                "Code to identify the 'Admin' section slice");

        CSTaskVar CompositionSectionSliceCodesCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    CompositionSectionSliceCodesName,
                    "Composition Section Slice Codes CodeSystem",
                    "Composition Section/Slice Codes/ValueSet",
                    "Composition Section Slice Codes code system",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        new ConceptDef()
                            .SetCode(Self.SectionCodeReport)
                            .SetDefinition("Slicing CompositionSection Code - Report."),
                        new ConceptDef()
                            .SetCode(Self.SectionCodeImpressions)
                            .SetDefinition("Slicing CompositionSection Code - Impressions."),
                        new ConceptDef()
                            .SetCode(Self.SectionCodeRelatedResources)
                            .SetDefinition("Slicing CompositionSection Code - Related Resources."),
                        new ConceptDef()
                            .SetCode(Self.SectionCodeRecommendations)
                            .SetDefinition("Slicing CompositionSection Code - Recommendations."),
                        new ConceptDef()
                            .SetCode(Self.SectionCodeFindingsLeftBreast)
                            .SetDefinition("Slicing CompositionSection Code - Findings Left Breast."),
                        new ConceptDef()
                            .SetCode(Self.SectionCodeFindingsRightBreast)
                            .SetDefinition("Slicing CompositionSection Code - Findings Right Breast."),
                        new ConceptDef()
                            .SetCode(Self.SectionCodeAdmin)
                            .SetDefinition("Slicing CompositionSection Code - Admin.")
                    })
        );
    }
}