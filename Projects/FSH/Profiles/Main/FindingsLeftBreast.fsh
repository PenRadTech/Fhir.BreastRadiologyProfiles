Profile: FindingsLeftBreast
Parent: Observation
Title: "Findings left Breast"
Description: """
	Findings left Breast profile.
	"""  

  //#apply Graph.LinkByName("focus", "^FindingsLeftBreast/$", "^FindingsLeftBreast/", "0")

  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0
 
  * value[x] only CodeableConcept
  * value[x] from BiRadsAssessmentCategoryVS (required)
  * value[x] 0..1 MS
  * value[x] ^definition = """
	Composite BiRad value for left Breast.
	
	Typically this is the most severe of all the BiRad 
	codes set in any of the child observations of the left Breast.
    """
	
  //#apply HasMember.Add("mgFinding", "0..1", "MG Finding", MGFinding, 
  //#  "'MG Finding' reference.",
  //#  """
  //#  This slice references the Mammography findings section.
  //#  """)



  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"
  * hasMember contains mriFinding 0..1
  * hasMember[mriFinding] ^short = "'Magnetic Resonance Imaging Finding' reference. hasMember."
  * hasMember[mriFinding] only Reference(MRIFinding)
  * hasMember[mriFinding] MS


  * hasMember contains nmFinding 0..1
  * hasMember[nmFinding] ^short = "'Nuclear Medicine Finding' reference. hasMember."
  * hasMember[nmFinding] only Reference(NMFinding)
  * hasMember[nmFinding] MS


  * hasMember contains usFinding 0..1
  * hasMember[usFinding] ^short = "'Ultra Sound Finding' reference. hasMember."
  * hasMember[usFinding] only Reference(USFinding)
  
  * hasMember[usFinding] MS
 

  * bodySite 1..1
  * bodySite = SNOMED#80248007 // "Left breast structure (body structure)"
  * code = ObservationCodesCS#findingsLeftBreastObservation