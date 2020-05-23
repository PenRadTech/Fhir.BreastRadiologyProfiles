Extension: BodyDistanceFromExtension
Parent: Extension
Title: "Body Distance From Extension"
Description: """
    Body Distance From Extension
    """



  * . ^short = "Body Distance From extension"

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