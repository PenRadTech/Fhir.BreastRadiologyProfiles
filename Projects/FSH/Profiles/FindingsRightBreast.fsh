Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 

Profile: FindingsRightBreast
Parent: Observation
Id: findingsRightBreast
Title: "Findings RightRight Breast"
Description: """
	Findings Right Breast Section
	
	This Observation contains references to all the observations
	and exam information related to the Right breast.
	"""
  // Start Macro FindingBreastFragment
  // Start Macro HeaderFragment
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  // End Macro HeaderFragment
  // Start Macro ObservationNoDeviceFragment
  // Start Macro ObservationFragment
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  // End Macro ObservationFragment
  * device 0..0
  // End Macro ObservationNoDeviceFragment
  * value[x] only CodeableConcept
  * value[x] from BiRadsAssessmentCategoryVS (required)
  * value[x] 0..1 MS
  // End Macro FindingBreastFragment
  * bodySite 1..1
  * bodySite = SNOMED#73056007 "Right breast structure (body structure)"
  * bodySite.extension contains BuilderSetValue named setValue 1..1
  * bodySite.extension[setValue].valueCodeableConcept = SNOMED#73056007 "Right breast structure (body structure)"

  * value[x] ^definition = """
	Composite BiRad value for Right Breast.
	
	Typically this is the most severe of all the BiRad 
	codes set in any of the child observations of the Right breast.
    """

  * code = ObservationCodesCS#findingsRightBreastObservation