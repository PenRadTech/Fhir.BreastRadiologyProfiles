Profile: AssociatedFeatureFragment
Parent: Observation
Title: "Associated Feature Fragment"
Description: """
  This fragment adds the references for the Associated Feature hasMember slice.
  """

     * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains associatedFeature 0..*
  * Observation.hasMember[associatedFeature] ^short = "'Associated Feature' reference. hasMember."
  * Observation.hasMember[associatedFeature] only Reference(AssociatedFeature)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  
  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------