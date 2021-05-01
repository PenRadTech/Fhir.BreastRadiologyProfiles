Profile: BiRadBreastCompositionFragment
Parent: Observation
Title: "BiRad Fragment"
Description: """
  Fragment that adds 'BiRad code' element to profile
  """
    * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"
  * hasMember contains biRadsBreastComposition 0..1
  * hasMember[biRadsBreastComposition] ^short = "BiRads Code hasMember."
  * hasMember[biRadsBreastComposition] only Reference(BreastComposition)