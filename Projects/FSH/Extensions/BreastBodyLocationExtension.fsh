/*
  Extension that defined Breast Body Location
*/
Extension: BreastBodyLocationExtension
Parent: Extension
Title: "Breast Body Location Extension"
Description: """
    Breast Body Location Extension
    """


  * . ^short = "Breast Body Location extension"

  
  * extension contains laterality 0..1
  * extension[laterality] ^short = "Body side"
  * extension[laterality] ^definition =
    """
	The side of the body being examined.
	"""
  * extension[laterality].value[x] 1..1
  * extension[laterality].value[x] only CodeableConcept
  * extension[laterality].value[x] from LateralityVS

  
  * extension contains quadrant 0..1
  * extension[quadrant] ^short = "Quadrant of the body location"
  * extension[quadrant] ^definition =
    """
	The quadrant  of the body location.
	"""
  * extension[quadrant].value[x] 1..1
  * extension[quadrant].value[x] only CodeableConcept
  * extension[quadrant].value[x] from BreastLocationQuadrantVS

  
  * extension contains region 0..1
  * extension[region] ^short = "Region of the body location"
  * extension[region] ^definition =
    """
	The region  of the body location.
	"""
  * extension[region].value[x] 1..1
  * extension[region].value[x] only CodeableConcept
  * extension[region].value[x] from BreastLocationRegionVS

  
  * extension contains clockDirection 0..1
  * extension[clockDirection] ^short = "Clock direction of the body location"
  * extension[clockDirection] ^definition =
    """
	The clock direction of the body location.
	"""
  * extension[clockDirection].value[x] 1..1
  * extension[clockDirection].value[x] only CodeableConcept
  * extension[clockDirection].value[x] from BreastLocationClockVS

  
  * extension contains depth 0..1
  * extension[depth] ^short = "Depth of the body location"
  * extension[depth] ^definition =
    """
	The depth of the body location.
	"""
  * extension[depth].value[x] 1..1
  * extension[depth].value[x] only CodeableConcept
  * extension[depth].value[x] from BreastLocationDepthVS

  
  * extension contains BodyDistanceFromExtension named distanceFromLandmark 0..1
  * extension[distanceFromLandmark] ^short = "distanceFromLandmark extension."
  * extension[distanceFromLandmark] ^definition =
    """
	This extension slice contains the distanceFromLandmark extension.
	"""