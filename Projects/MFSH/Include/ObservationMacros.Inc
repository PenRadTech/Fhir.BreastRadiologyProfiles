#use "NodeGraph.inc"

// ObservationFragment
// constraints used in all breast radiology observations.
#macro ObservationFragment()
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
#end

// ObservationHasMemberFragment
// constrains observations with hasMembers references).
#macro ObservationHasMemberFragment()
#end


// ObservationLeafFragment
// constrains observations leaf nodes (no hasMembers references).
#macro ObservationLeafFragment()
  * hasMember 0..0
#end

// ObservationNoDeviceFragment
// for all observations that have no device.
#macro ObservationNoDeviceFragment()
  #apply once ObservationFragment()
  * device 0..0
#end

// ObservationNoValueFragment
// Observations that have no explicit value.
#macro ObservationNoValueFragment()
  #apply once ObservationFragment()
  * dataAbsentReason 0..0
  * value[x] 0..0
  * interpretation 0..0
  * referenceRange 0..0
#end

// ObservationNoComponentFragment
// Used by all BreastRad observations that do not have components.
#macro ObservationNoComponentFragment()
  #apply once ObservationFragment()
  * component 0..0
#end

// ObservationSectionFragment
// Constrains a generic observation to be a observation section.
#macro ObservationSectionFragment()
  #incompatible ObservationLeafFragment
  #apply once ObservationFragment()
  #apply once ObservationNoComponentFragment()
  #apply once ObservationNoValueFragment()
  * interpretation 0..0
  * method 0..0
#end

// Set up component slicing on an Observation derived profile.
#macro ComponentSlicing()
  #incompatible ObservationNoComponentFragment
  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
#end

// Set up hasMember slicing on an Observation derived profile.
#macro HasMemberSlicing()
  #incompatible ObservationLeafFragment
  * component ^slicing.discriminator.type = #value
  * component ^slicing.discriminator.path = "url"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
#end

/*
 Add a hasmember slice to an observation.
 This adds the component slicing discriminator.
 It does not constrain the hasMember target.
 */
#macro ObservationAddHasMember(SliceName, Cardinality, DisplayName, ShortDesc, Definition)
  #apply GraphNodeElement("component:SliceName", "DisplayName/Component")

  #apply once HasMemberSlicing()
  * hasMember contains SliceName Cardinality
  * component[SliceName] ^short = "ShortDesc component."
  * component[SliceName] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[SliceName] ^definition = """
    Definition
    """
  * component[SliceName].code 1..1
  * component[SliceName].code ^short = "ShortDesc component code."
  * component[SliceName].code ^definition = """
    This code identifies the ShortDesc component.
	"""
  * component[SliceName].code = ComponentCode
#end

/*
 Add a component slice to an observation.
 This addes the component slicing discriminator.
 It does not constrain the component value.
 */
#macro ObservationAddComponent(SliceName, Cardinality, DisplayName, ShortDesc, Definition, ComponentCode)
  #apply GraphNodeElement("component:SliceName", "DisplayName/Component")

  #apply once ComponentSlicing()
  * component contains SliceName Cardinality
  * component[SliceName] ^short = "ShortDesc component."
  * component[SliceName] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[SliceName] ^definition = """
    Definition
    """
  * component[SliceName].code 1..1
  * component[SliceName].code ^short = "ShortDesc component code."
  * component[SliceName].code ^definition = """
    This code identifies the ShortDesc component.
	"""
  * component[SliceName].code = ComponentCode
#end

/*
  Constrain a  component slice value.
 */
#macro ObservationSetComponentConcept(SliceName, Cardinality, ValueSet)
  #apply GraphLinkByBinding("focus", "^%Profile%/component:SliceName/$", ".value[x]")

  * component[SliceName].value[x] Cardinality
  * component[SliceName].value[x] only CodeableConcept
  * component[SliceName].value[x] from ValueSet
#end