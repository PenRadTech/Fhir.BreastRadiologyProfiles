Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 


Profile: BreastRadiologyComposition
Parent: Composition
Id: breastRadiologyComposition
Title: "Breast Radiology Composition"
Description: """
    This profile defines the composition instance for the Breast Radiology FHIR Document.
    This profile is based on FHIR Composition resource.

    The composition object is a required part of the FHIR Document structure.
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

  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * type = LOINC#42132-1 "US Breast screening"

  // * section[reportSection].extension contains GNode named nodeSection 1..1
  // * section[reportSection].extension[nodeSection].extension[graph].valueString = "%graphName%"
  // * section[reportSection].extension[nodeSection].extension[display].valueString = "%displayName%"
  // * section[reportSection].extension[nodeSection].extension[group].valueString = "%group%"
  // * section[reportSection].extension[nodeSection].extension[targets].valueString = "%target%"
  // * section[reportSection].extension[nodeSection].extension[lhsText].valueString = "%lhs%"
  // * section[reportSection].extension[nodeSection].extension[rhsText].valueString = "%rhs%"
  * section ^slicing.discriminator.type = #pattern
  * section ^slicing.discriminator.path = "path"
  * section ^slicing.rules = #open
  * section ^slicing.ordered = false
  * section ^slicing.description = """
  Breast Radiology Report Section
  """

  * section contains
      report 1..1 MS and
      impressions 0..1 MS

  * section[report] ^definition = """
  This section references the Breast Radiology Report.

  One and only one Breast Radiology Report must be included in this section.
  """
  * section[report] ^short = "Report Section."
  * section[report].code = CompositionSectionSliceCodesCS#sectionReport
  * section[report].title = "Breast Radiology Report"

  * section[report].entry 1..1
  * section[report].entry only Reference(BreastRadiologyReport)
  * section[report].entry ^short = "Breast Radiology Report reference"
  * section[report].entry ^definition = """
  Reference to the Breast Radiology Report.
  """
  //! TODO: Create Report section graph node.
  * section[impressions] ^definition = """
  This section contains references to the report's clinical impressions.
  """
  * section[impressions] ^short = "Clinical Impressions Section."
  * section[impressions].code = CompositionSectionSliceCodesCS#sectionReport
  * section[impressions].title = "Clinical Impressions"

  * section[impressions].entry 0..*
  * section[impressions].entry only Reference(BreastRadiologyReport)
  * section[impressions].entry ^short = "Clinical Impression reference"
  * section[impressions].entry ^definition = """
  Reference to the clinical impression(s).
  """
  //! TODO: Create graph node.

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