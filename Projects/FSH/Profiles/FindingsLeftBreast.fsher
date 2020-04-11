Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 

Profile: FindingsLeftBreast
Parent: Observation
Id: findingsLeftBreast
Title: "Findings Left Breast"
Mixins: FindingBreastFragment
Description: """
	Findings Left Breast Section
	
	This Observation contains references to all the observations
	and exam information related to the left breast.
	"""  

  * bodySite 1..1
  * bodySite = SNOMED#80248007 "Left breast structure (body structure)"
  * bodySite.extension contains BuilderSetValue named setValue 1..1
  * bodySite.extension[setValue].valueCodeableConcept = SNOMED#80248007 "Left breast structure (body structure)"

  * value[x] ^definition = """
	Composite BiRad value for Left Breast.
	
	Typically this is the most severe of all the BiRad 
	codes set in any of the child observations of the left breast.
    """

  * code = ObservationCodesCS#findingsLeftBreastObservation
