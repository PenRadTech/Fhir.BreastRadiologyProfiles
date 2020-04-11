Extension: GNode
Id:   gNode
Title:  "Graph Node Extension"
Description: """
	Defines an extension used to embed info used in creating
	the FHRI graphs.
	
    """
* value[x] 0..0
* extension contains
	GString named graph 1..1 and
	GString named cssClass 0..1 and
	GString named group 1..1 and
	GString named display 0..* and
	GString named targets 0..1 and
	GString named lhsText 0..* and
	GString named rhsText 0..* and
	GBool named showChildren 0..1

	
Extension: GString
Id:   gString
Title:  "Graph String Extension"
Description: """
	Defines a string extension.
	If starts with ^, then string is a fhir path expression.
    """
* value[x] only string
* value[x] 1..1

Extension: GBool
Id:   gBool
Title:  "Graph Bool Extension"
Description: """
	Defines a bool extension.
    """
* value[x] only boolean
* value[x] 1..1
