Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 

Profile: FindingsRightBreast
Parent: Observation
Id: findingsRightBreast
Title: "Findings RightRight Breast"
Mixins: FindingBreastFragment
Description: """
	Findings Right Breast Section
	
	This Observation contains references to all the observations
	and exam information related to the Right breast.
	"""  

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
