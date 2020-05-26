Profile: ServiceRecommendation
Parent: ServiceRequest
Title: "Service Recommendation"
Description: """
  Service Recommendation
  """

  //#apply Graph.LinkByName("focus", "^ServiceRecommendation/$", "^ServiceRecommendation/", "0")
  //#apply Graph.NodeElement("code", "code")
  //#apply Graph.LinkByBinding("focus", "^ServiceRecommendation/code/$", "")


  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"

  * . ^definition = """
    Followup Service Recommendation.
	"""

  * code 1..1
  * code from RecommendationsVS  (extensible)