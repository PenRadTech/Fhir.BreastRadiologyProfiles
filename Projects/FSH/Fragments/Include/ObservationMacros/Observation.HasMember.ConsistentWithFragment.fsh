Profile: ConsistentWithFragment
Parent: Observation
Title: "Consistent With Fragment"
Description: """
  This fragment adds the references for the ConsistentWith HasMember.
  """

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
    * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains consistentWith 0..*
  * Observation.hasMember[consistentWith] ^short = "'Consistent With' reference. hasMember."
  * Observation.hasMember[consistentWith] only Reference(ConsistentWith)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------