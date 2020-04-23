Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 

Profile: BreastRadiologyDocument
Parent: Bundle
Title: "Breast Radiology Document"
Description: """
    This is the top level container for the Breast Radiology FHIR Document.
    This profile is based on FHIR Bundle resource.

    A FHIR Document is a Bundle that provides a single item containing all the 
	resource instances that are a part of the Breast Radiology Diagnostic Report.
	
	The first entry in the bundle is a composition instance that provides an index
	to all the other FHIR resource instances that are part of this document.
	This index composition entry must be an instance of the BreastRadiologyComposition profile.
    """

  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * entry ^slicing.discriminator.type = #value
  * entry ^slicing.discriminator.path = "fullUrl"
  * entry ^slicing.rules = #open
  * entry ^slicing.ordered = false
  * entry ^slicing.description = "Index composition slice"
  * entry contains index 1..1
  * entry[index].fullUrl = "index"
  * entry[index].resource only BreastRadiologyComposition