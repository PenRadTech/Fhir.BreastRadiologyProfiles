Profile: ConsistentWithFragment
Parent: Observation
Title: "ConsistentWith HasMember Fragment"
Description: "This fragment adds the references for the ConsistentWith HasMember."


  * hasMember contains consistentWith 0..*
  * hasMember[consistentWith] ^short = "'Consistent With' reference. hasMember."
  * hasMember[consistentWith] only Reference(ConsistentWith)