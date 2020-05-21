/*
 Common Tumor Satellite Observation
 */
Profile: TumorSatellite
Parent: Observation
Title: "Tumor Satellite"
Description: """
    Tumor Satellite
    """
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * hasMember 0..0
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0
  * component 0..0


  * . ^definition = """
    Tumor Satellite Observation.
	"""

  * code 1..1
  * code = ObservationCodes#tumorSatelliteObservation

  * value[x] 0..1
  * value[x] only Quantity or Range
  * valueQuantity units from http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS
  * valueRange.low units from http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS
  * valueRange.high units from http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS
 


  * derivedFrom ^slicing.discriminator.type = #value
  * derivedFrom ^slicing.discriminator.path = "url"
  * derivedFrom ^slicing.rules = #open
  * derivedFrom ^slicing.ordered = false
  * derivedFrom ^slicing.description = "derivedFrom slicing"
  * derivedFrom contains indexTumor 0..1
  * derivedFrom[indexTumor] ^short = "Tumor Observation reference component."
  * derivedFrom[indexTumor] ^comment = """
    This observation is derived from a 'Tumor Observation reference' observation.
    """
  * derivedFrom[indexTumor] ^definition = """
This derivedFrom slice references the index tumor.
    """
  * derivedFrom[indexTumor] only Reference(OBSERVATIONURL)