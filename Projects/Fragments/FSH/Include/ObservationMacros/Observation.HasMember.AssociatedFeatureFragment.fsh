Profile: Observation.HasMember.AssociatedFeatureFragment
Parent: Observation
Title: "Associated Feature Fragment"
Description: "This fragment adds the references for the Associated Feature hasMember slice."


  * hasMember contains associatedFeature 0..*
  * hasMember[associatedFeature] ^short = "'Associated Feature' reference. hasMember."
  * hasMember[associatedFeature] only Reference(AssociatedFeature)