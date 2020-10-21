Profile: BreastServiceRequest
Parent: ServiceRequest
Title: "Breast Radiology Service Request"
Description: """
  Service request with required breast laterality field.
  """
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * ^jurisdiction.coding = urn:iso:std:iso:3166#US "United States of America"
  
  * extension contains breastLaterality 1..1
  * extension[breastLaterality] ^short = "Breast Laterality"
  * extension[breastLaterality] ^definition =
    """
	  The laterality of the breast that the container resource is referring to.
	  """
  * extension[breastLaterality].value[x] 1..1
  * extension[breastLaterality].value[x] only CodeableConcept
  * extension[breastLaterality].value[x] from BreastLateralityVS