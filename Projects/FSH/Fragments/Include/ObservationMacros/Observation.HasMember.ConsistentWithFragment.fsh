Profile: ConsistentWithFragment
Parent: Observation
Title: "ConsistentWith HasMember Fragment"
Description: """
  This fragment adds the references for the ConsistentWith HasMember.
  """

   


  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"
  * hasMember contains consistentWith 0..*
  * hasMember[consistentWith] ^short = "'Consistent With' reference. hasMember."
  * hasMember[consistentWith] only Reference(ConsistentWith)