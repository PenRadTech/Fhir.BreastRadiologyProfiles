Alias: LOINC = http://loinc.org 

Profile: BreastRadiologyComposition
Parent: Composition
Id: breastRadiologyComposition
Title: "Breast Radiology Composition"
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
  // Start Macro HeaderFragment
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  // End Macro HeaderFragment
  * type = LOINC#42132-1 "US Breast screening"

	// Create Report section graph node.
  * extension contains GNode named nodeSection 1..1
  * extension[nodeSection].extension[graph].valueString = "focus"
  * extension[nodeSection].extension[display].valueString = "Breast/Radiology/Composition"
  * extension[nodeSection].extension[targets].valueString = "^Composition.section"

  * section ^slicing.discriminator.type = #pattern  
  * section ^slicing.discriminator.path = "code"
  * section ^slicing.rules = #open
  * section ^slicing.ordered = false
  * section ^slicing.description = "Breast Radiology Report Section"  
  * section contains
      reportSection 1..1 
  * section[reportSection].code = CompositionSectionSliceCodesCS#sectionReport
  * section[reportSection].title = "Breast Radiology Report"
  * section[reportSection].entry 1..1
  * section[reportSection].entry only Reference(BreastRadiologyReport)

	// Create Report section graph node.
  * section[reportSection].extension contains GNode named nodeSection 1..1
  * section[reportSection].extension[nodeSection].extension[graph].valueString = "focus"
  * section[reportSection].extension[nodeSection].extension[display].valueString = "Report/Section"
  * section[reportSection].extension[nodeSection].extension[group].valueString = "section"
  * section[reportSection].extension[nodeSection].extension[targets].valueString = "^entry"
  * section[reportSection].extension[nodeSection].extension[lhsText].valueString = "%card^"
  * section[reportSection].extension[nodeSection].extension[rhsText].valueString = "%card^.entry"