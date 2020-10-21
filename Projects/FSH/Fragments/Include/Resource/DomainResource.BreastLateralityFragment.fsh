Profile: BreastLateralityFragment
Parent: DomainResource
Title: "Breast Laterality Fragment"
Description: """
  This fragment adds the references for the breast laterality .
  """
    
  * extension contains breastLaterality 1..1
  * extension[breastLaterality] ^short = "Breast Laterality"
  * extension[breastLaterality] ^definition =
    """
	  The laterality of the breast that the container resource is referring to.
	  """
  * extension[breastLaterality].value[x] 1..1
  * extension[breastLaterality].value[x] only CodeableConcept
  * extension[breastLaterality].value[x] from BreastLateralityVS