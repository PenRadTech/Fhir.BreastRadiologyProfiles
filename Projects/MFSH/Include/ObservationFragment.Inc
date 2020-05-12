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
  #apply ObservationFragment()
  * device 0..0
#end

// ObservationNoValueFragment
// Observations that have no explicit value.
#macro ObservationNoValueFragment()
  #apply ObservationFragment()
  * dataAbsentReason 0..0
  * value[x] 0..0
  * interpretation 0..0
  * referenceRange 0..0
#end

// ObservationNoComponentFragment
// Used by all BreastRad observations that do not have components.
#macro ObservationNoComponentFragment()
Parent: Observation
  #apply ObservationFragment()
  * component 0..0
#end

// ObservationSectionFragment
// Constrains a generic observation to be a observation section.

// IncompatibleFragment ObservationLeafFragment

#macro ObservationSectionFragment()
  #apply ObservationFragment()
  #apply ObservationNoComponentFragment()
  #apply ObservationNoValueFragment()
  * interpretation 0..0
  * method 0..0
#end
