Profile: FindingsLeftBreast
Parent: Observation
Title: "Findings Left Breast"
Description: """
	Findings Left Breast profile.
	"""  
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * ^jurisdiction.coding = urn:iso:std:iso:3166#US "United States of America"
  * category ^slicing.discriminator.type = #pattern
  * category ^slicing.discriminator.path = "$this"
  * category ^slicing.rules = #open
  * category ^slicing.ordered = false
  * category ^slicing.description = "Observation Category = imaging"
  * category contains categoryImaging 1..1
  * category[categoryImaging] = http://terminology.hl7.org/CodeSystem/observation-category#imaging
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0

  * value[x] 0..0
  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
  * component contains biRadsAssessmentCategory 0..1
  * component[biRadsAssessmentCategory] ^short = "BiRads Assessment Category component. component."
  * component[biRadsAssessmentCategory] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[biRadsAssessmentCategory] ^definition = """
    This slice contains the optional component that defines the BiRAD risk code.
    The value of this component is a codeable concept chosen from the BiRadsAssessmentCategoryVS valueset.
    """
  * component[biRadsAssessmentCategory].code 1..1
  * component[biRadsAssessmentCategory].code ^short = "BiRads Assessment Category component. component code."
  * component[biRadsAssessmentCategory].code ^definition = """
    This code identifies the BiRads Assessment Category component. component.
	"""
  * component[biRadsAssessmentCategory].code = ObservationComponentSliceCodesCS#biRadsAssessmentCategory
  * component[biRadsAssessmentCategory].value[x] 1..1
  * component[biRadsAssessmentCategory].value[x] only CodeableConcept
  * component[biRadsAssessmentCategory].value[x] from BiRadsAssessmentCategoryVS
  * component[biRadsAssessmentCategory] ^definition = """
   Composite BiRad value for Left Breast.
   Typically this is the most severe of all the BiRad 
   codes set in any of the child observations of the Left Breast.
    """
  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"
  * hasMember contains biRadsBreastComposition 0..1
  * hasMember[biRadsBreastComposition] ^short = "BiRads Code hasMember."
  * hasMember[biRadsBreastComposition] only Reference(BreastComposition)
  * hasMember[biRadsBreastComposition] ^definition = """
   BiRad Breast Composition value for Left Breast.
   """
  * hasMember contains mgFinding 0..1
  * hasMember[mgFinding] ^short = "'MG Finding' reference. hasMember."
  * hasMember[mgFinding] only Reference(MGFinding)
  * hasMember[mgFinding] MS
  * hasMember contains mriFinding 0..1
  * hasMember[mriFinding] ^short = "'Magnetic Resonance Imaging Finding' reference. hasMember."
  * hasMember[mriFinding] only Reference(MRIFinding)
  * hasMember[mriFinding] MS
  * hasMember contains nmFinding 0..1
  * hasMember[nmFinding] ^short = "'Nuclear Medicine Finding' reference. hasMember."
  * hasMember[nmFinding] only Reference(NMFinding)
  * hasMember[nmFinding] MS
  * hasMember contains usFinding 0..1
  * hasMember[usFinding] ^short = "'Ultrasound Finding' reference. hasMember."
  * hasMember[usFinding] only Reference(USFinding)
  * hasMember[usFinding] MS
  * hasMember contains other 0..1
  * hasMember[other] ^short = "Other modality finding. hasMember."
  * hasMember[other] only Reference(OtherModalityFinding)
  * hasMember[other] MS
  * code = ObservationCodesCS#findingsLeftBreastObservation
  * code 1..1
  * bodySite = SNOMED#80248007 "Left breast structure (body structure)"
  * bodySite 1..1