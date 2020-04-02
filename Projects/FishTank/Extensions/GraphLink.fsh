Extension: GNode
Id:   gNode
Title:  "Graph Node Extension"
Description: """
	Defines an extension used to embed info used in creating
	the FHRI graphs.
	
	This extensional data is removed before the profile is published
	in the IG. Is is used internally only for making the graphs.
	
	This extension defines a node in a graph. The node has the follwing
	attributes.
	
	if a string value starts with $, then it is a profile/instance name,
	and if a profile may have a '#' element name.
	i.e. $MyCompositionProfile#section:mySection
	
	graph is the name of the graph that this node is a member of.
	
	group is the name of the group that this node is a member of. 
	All members of a group are drawn together.
	
	child are the name(s) of the children of this group. The format of this
	is ${ItemName}#{GroupName}.
	
	cssClass is the name of the css class for this node.

	showChildren defines if the graph should show children of the this node.
	If empty, then the default value for the graph is used.

	lhsText the string annotation of the lhs line connected to this
	node.
	Use ${path} for this value and the cardinality of the target will be used.
	
	rhsText the string annotation of the rhs line connected to this
	node. The format of rhsTest is the same as lhsText described above.

    """
* value[x] 0..0
* extension contains
	GString named graph 1..1 and
	GString named group 1..1 and
	GString named cssClass 0..1 and
	GString named child 0..* and
    //GraphNode named leftNode 1..1 and
    //GraphNode named rightNode 1..1 and
	GBool named showChildren 0..1

	
Extension: GString
Id:   gString
Title:  "Graph String Extension"
Description: """
	Defines a string extension.
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
