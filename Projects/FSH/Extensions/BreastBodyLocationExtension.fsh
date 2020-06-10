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

  //$#apply Graph.LinkByName("focus", "^BreastBodyLocationExtension/extension/$", "^BreastBodyLocationExtension/extension:", "0")
  
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


  
  * extension contains landMark 1..1
  * extension[landMark] ^short = "Body landmark. Origin of distance measurement."
  * extension[landMark] ^definition =
    """
	  Body landmark which defines the origin of the measurement.

  Currently the value set this is bound to does not contain the required breast 
  landmarks like nipple.  
	"""
  * extension[landMark].value[x] 1..1
  * extension[landMark].value[x] only CodeableConcept
  * extension[landMark].value[x] from BreastLocationQuadrantVS

  
  * extension contains distanceFromLandMark 1..1
  * extension[distanceFromLandMark] ^short = "Distance from landmark"
  * extension[distanceFromLandMark] ^definition =
    """
		 Distance from body landmark to body location
	"""
  * extension[distanceFromLandMark].value[x] 1..1
  * extension[distanceFromLandMark].value[x] only Quantity
  * extension[distanceFromLandMark].valueQuantity from UNITSOFLENGTH