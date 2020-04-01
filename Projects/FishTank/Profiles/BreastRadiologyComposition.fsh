Alias: LOINC = http://loinc.org 

Profile: BreastRadiologyComposition
Parent: Composition
Id: breastRadiologyComposition
Title: "Breast Radiology Composition"
Mixins: HeaderFragment
Description: """
    This profile defines the composition instance for the Breast Radiology FHIR Document.
    This profile is based on FHIR Composition resource.

    A FHIR Document is a Bundle that contains a composition as the first entry and ,
    provides a single item (bundle) that contains all the resources that are a part of
    the Breast Radiology Diagnostic Report.

    The composition object is an required part of the FHIR Document structure.
    One composition must exist, and it must be the first resource stored in the FHIR document bundle.

    The other exam related resources are referenced through the 
    sections defined in this resource.

    This composition creates the following sections.

    A. Report Section.
    This contains a single reference to the Breast Radiology Report
    All Breast Radiology Findings are referenced by the reports results element.

    B. Impressions Section.
    All of the clinical impressions created for this exam are referenced in this section.

    C. Recommendations Section.
    All of the service and medication recommendations created for this exam are referenced in this section.
    If a recommendation is in response to a particular observation or finding, then 
    the recommendations 'reasonReference' should contain a  reference to the pertinant observation or finding.
	"""

  * type = LOINC#42132-1 "US Breast screening"

    //// Report Section
    //{
    //    ElementTreeNode sliceElementDef = StartSectionSlicing(e);
    //    {
    //        String[] targets = new string[] {Self.BreastRadiologyReport.Value().Url};

    //        ElementTreeSlice sectionSlice = SliceSection(sliceElementDef,
    //            "report",
    //            "Breast Radiology Report",
    //            Self.SectionCodeReport,
    //            out ElementDefinition entry);
    //        entry
    //            .Single()
    //            .Type("Reference", null, targets)
    //            .Short("Breast Radiology Report reference")
    //            .Definition("Reference to the Breast Radiology Report.")
    //            ;

    //        sectionSlice.ElementDefinition
    //            .Single()
    //            .SetShort($"Report Section.")
    //            .SetDefinition(
    //    new Markdown()
    //        .Paragraph($"This section references the Breast Radiology Report'.")
    //        .Paragraph($"One and only one Breast Radiology Report must be included in this section.'.")
    //            )
    //            .MustSupport();
    //        ;

    //        e.AddComponentLink("Report",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
    //    }
    //}

    //// Impressions Section
    //{
    //    ElementTreeNode sliceElementDef = StartSectionSlicing(e);
    //    {
    //        String[] targets = new string[] {Global.ClinicalImpressionUrl};

    //        ElementTreeSlice sectionSlice = SliceSection(sliceElementDef,
    //            "impressions",
    //            "Clinical Impressions",
    //            Self.SectionCodeImpressions,
    //            out ElementDefinition entry);
    //        entry
    //            .ZeroToMany()
    //            .Type("Reference", null, targets)
    //            .Short("Clinical Impression reference")
    //            .Definition("Reference to the clinical impression(s).")
    //            ;
    //        sectionSlice.ElementDefinition
    //            .ZeroToOne()
    //            .SetShort($"Impressions Section.")
    //            .SetDefinition(
    //    new Markdown()
    //        .Paragraph(
    //            $"This section contains references to the report's clinical impressions.")
    //            )
    //            .MustSupport();
    //        ;
    //        e.AddComponentLink("Impressions",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
    //    }
    //}

    //// Findings Right Breast Section
    //{
    //    ElementTreeNode sliceElementDef = StartSectionSlicing(e);
    //    {
    //        String[] targets = new string[] {Self.FindingsRightBreast.Value().Url};

    //        ElementTreeSlice sectionSlice = SliceSection(sliceElementDef,
    //            "findingsRightBreast",
    //            "Findings Right Breast",
    //            Self.SectionCodeFindingsRightBreast,
    //            out ElementDefinition entry);
    //        entry
    //            .ZeroToOne()
    //            .Type("Reference", null, targets)
    //            .Short("Finding Right breast reference")
    //            .Definition("Reference to the finding for the right breast.")
    //            ;
    //        sectionSlice.ElementDefinition
    //            .ZeroToOne()
    //            .SetShort($"Findings Section Right Breast.")
    //            .SetDefinition(
    //    new Markdown()
    //        .Paragraph(
    //            $"This section contains references to the report's findings for the right breast.")
    //            )
    //            .MustSupport();
    //        ;
    //        e.AddComponentLink("Findings Right Breast",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
    //    }
    //}

    //// Findings Left Breast Section
    //{
    //    ElementTreeNode sliceElementDef = StartSectionSlicing(e);
    //    {
    //        String[] targets = new string[] {Self.FindingsLeftBreast.Value().Url};

    //        ElementTreeSlice sectionSlice = SliceSection(sliceElementDef,
    //            "findingsLeftBreast",
    //            "Findings Left Breast",
    //            Self.SectionCodeFindingsLeftBreast,
    //            out ElementDefinition entry);
    //        entry
    //            .ZeroToOne()
    //            .Type("Reference", null, targets)
    //            .Short("Finding left breast reference")
    //            .Definition("Reference to the finding for the left breast.")
    //            ;
    //        sectionSlice.ElementDefinition
    //            .ZeroToOne()
    //            .SetShort($"Findings Section Left Breast.")
    //            .SetDefinition(
    //    new Markdown()
    //        .Paragraph(
    //            $"This section contains references to the report's findings for the left breast.")
    //            )
    //            .MustSupport();
    //        ;
    //        e.AddComponentLink("Findings Left Breast",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
    //    }
    //}

    //// Related Resources Section
    //{
    //    ElementTreeNode sliceElementDef = StartSectionSlicing(e);
    //    {
    //        String[] targets = new string[] {Global.ResourceUrl};

    //        ElementTreeSlice sectionSlice = SliceSection(sliceElementDef,
    //            "relatedResources",
    //            "Related Resources",
    //            Self.SectionCodeRelatedResources,
    //            out ElementDefinition entry);
    //        entry
    //            .ZeroToMany()
    //            .Type("Reference", null, targets)
    //            .Short("Related Resource reference")
    //            .Definition("Reference to the related resource.")
    //            ;
    //        sectionSlice.ElementDefinition
    //            .ZeroToOne()
    //            .Short("Related Clinical Resources Section")
    //            .Definition(
    //    "References to FHIR clinical resources used during the exam or referenced by this report.")
    //            .MustSupport();
    //        ;
    //        e.AddComponentLink("Related Resources",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
    //    }
    //}

    //// Recommendations Section
    //{
    //    ElementTreeNode sliceElementDef = StartSectionSlicing(e);
    //    {
    //        String[] targets = new string[]
    //        {
    //            Global.MedicationRequestUrl, Global.ServiceRequestUrl,
    //            Self.ServiceRecommendation.Value().Url
    //        };

    //        ElementTreeSlice sectionSlice = SliceSection(sliceElementDef,
    //            "recommendations",
    //            "Recommendations",
    //            Self.SectionCodeRecommendations,
    //            out ElementDefinition entry);
    //        entry
    //            .ZeroToMany()
    //            .Type("Reference", null, targets)
    //            .Short("Recommendation reference")
    //            .Definition("Reference to the recommended action.")
    //            ;
    //        sectionSlice.ElementDefinition
    //            .ZeroToOne()
    //            .Short("Recommendations Section")
    //            .Definition(
    //    "This section contains references to recommended actions taken in response to the observations and findings of this report.")
    //            .MustSupport();
    //        ;
    //        e.AddComponentLink("Recommendations",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
    //    }
    //}

    //// Admin Section
    //{
    //    ElementTreeNode sliceElementDef = StartSectionSlicing(e);
    //    {
    //        String[] targets = new string[] { Global.ResourceUrl };

    //        ElementTreeSlice sectionSlice = SliceSection(sliceElementDef,
    //            "admin",
    //            "Admin",
    //            Self.SectionCodeAdmin,
    //            out ElementDefinition entry);
    //        entry
    //            .ZeroToMany()
    //            .Type("Reference", null, targets)
    //            .Short("Administrative section")
    //            .Definition("References to all administrative resources go here.")
    //            ;
    //        sectionSlice.ElementDefinition
    //            .ZeroToOne()
    //            .Short("Administrative section")
    //            .Definition(
    //    "References to all administrative resources go here.")
    //            .MustSupport();
    //        ;
    //        e.AddComponentLink("Admin",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
    //    }
    //}
				