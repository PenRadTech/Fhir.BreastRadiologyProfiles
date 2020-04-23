Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 

Profile: BreastRadiologyComposition
Parent: Composition
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

   * extension contains GraphNode named Main 1..1
   * extension[Main].extension[graphName].valueString = "focus"
   * extension[Main].extension[nodeName].valueString = "Main"
   * extension[Main].extension[displayName].valueString = "Breast/Radiology/Composition"
   * extension[Main].extension[cssClass].valueString = ""
  // * section[reportSection].extension[nodeSection].extension[display].valueString = "%displayName%"
  // * section[reportSection].extension[nodeSection].extension[group].valueString = "%group%"
  // * section[reportSection].extension[nodeSection].extension[targets].valueString = "%target%"
  // * section[reportSection].extension[nodeSection].extension[lhsText].valueString = "%lhs%"
  // * section[reportSection].extension[nodeSection].extension[rhsText].valueString = "%rhs%"
   * extension contains GraphLinkByName named MainSectionLink 1..1
   * extension[MainSectionLink].extension[graphName].valueString = "focus"
   * extension[MainSectionLink].extension[parentName].valueString = "Main"
   * extension[MainSectionLink].extension[childName].valueString = "SectionNodes"
  //#apply GraphNode("", "focus","Breast/Radiology/Composition","","^Composition.section","","")
  * section ^slicing.discriminator.type = #pattern
  * section ^slicing.discriminator.path = "code"
  * section ^slicing.rules = #open
  * section ^slicing.ordered = false
  * section ^slicing.description = """
    Breast Radiology Report Section
    """

  * section contains
      report 1..1 MS and
      impressions 0..1 MS and
      findingsRightBreast 0..1 MS and
      findingsLeftBreast 0..1 MS

  //! TODO: Create Report section graph node.
  * section[report] ^definition = """
    This section references the Breast Radiology Report.

    One and only one Breast Radiology Report must be included in this section.
  """
  * section[report] 1..1
  * section[report] ^short = "Report Section."
  * section[report].code = CompositionSectionSliceCodesCS#sectionReport
  * section[report].title = "Breast Radiology Report"

  * section[report].entry 1..1
  * section[report].entry only Reference(BreastRadiologyReport)
  * section[report].entry ^short = "Breast Radiology Report reference"
  * section[report].entry ^definition = """
    Reference to the Breast Radiology Report.
	"""
  //! TODO: Create graph node.
  * section[impressions] ^definition = """
    This section contains references to the report's clinical impressions.
    """
  * section[impressions] 0..1
  * section[impressions] ^short = "Clinical Impressions Section."
  * section[impressions].code = CompositionSectionSliceCodesCS#sectionReport
  * section[impressions].title = "Clinical Impressions"


  * section[impressions].entry 0..*
  * section[impressions].entry only Reference(ClinicalImpression)
  * section[impressions].entry ^short = "Clinical Impression reference"
  * section[impressions].entry ^definition = """
    Reference to the clinical impression(s).
    """
  //! TODO: Create graph node.
  * section[findingsRightBreast] ^definition = """
    This section contains references to the report's findings 
    for the right breast.
  """
  * section[findingsRightBreast] ^short = "Findings Right Breast Section."
  * section[findingsRightBreast].code = CompositionSectionSliceCodesCS#findingsRightBreast
  * section[findingsRightBreast].title = "Findings Right Breast Section"
  * section[findingsRightBreast] 0..1

  * section[findingsRightBreast].entry 0..*
  * section[findingsRightBreast].entry only Reference(FindingsRightBreast)
  * section[findingsRightBreast].entry ^short = "Finding Right breast reference"
  * section[findingsRightBreast].entry ^definition = """
  Reference to the finding for the Right breast.
  """
  //! TODO: Create graph node.
  * section[findingsLeftBreast] ^definition = """
    This section contains references to the report's findings 
    for the left breast.
  """
  * section[findingsLeftBreast] ^short = "Findings Left Breast Section."
  * section[findingsLeftBreast].code = CompositionSectionSliceCodesCS#findingsLeftBreast
  * section[findingsLeftBreast].title = "Findings Left Breast Section"
  * section[findingsLeftBreast] 0..1

  * section[findingsLeftBreast].entry 0..*
  * section[findingsLeftBreast].entry only Reference(FindingsLeftBreast)
  * section[findingsLeftBreast].entry ^short = "Finding Left breast reference"
  * section[findingsLeftBreast].entry ^definition = """
  Reference to the finding for the Left breast.
  """


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