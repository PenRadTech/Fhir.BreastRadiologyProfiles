Extension: GraphNode
Description: """
	Defines an extension used to embed info used in creating
	the FHIR graphs.
    """
* value[x] 0..0
* extension contains
	GString named graphName 1..1 and
	GString named nodeName 1..1 and
	GString named displayName 1..1 and
	GString named cssClass 0..1

Extension: GraphLinkByName
Description: """
	Link parent and child nodes by name.
    """
* value[x] 0..0
* extension contains
	GString named graphName 1..1 and
	GString named parentName 1..1 and
	GString named childName 1..1
	
Extension: GString
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