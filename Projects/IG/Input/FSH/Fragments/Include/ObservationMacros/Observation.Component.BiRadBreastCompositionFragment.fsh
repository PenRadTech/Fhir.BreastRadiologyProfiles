Profile: BiRadBreastCompositionFragment
Parent: Observation
Title: "BiRad Fragment"
Description: """
  Fragment that adds 'BiRad code' element to profile
  """
    * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
  * component contains biRadsBreastComposition 0..1
  * component[biRadsBreastComposition] ^short = "BiRads Assessment Category component. component."
  * component[biRadsBreastComposition] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[biRadsBreastComposition] ^definition = """
    
    """
  * component[biRadsBreastComposition].code 1..1
  * component[biRadsBreastComposition].code ^short = "BiRads Assessment Category component. component code."
  * component[biRadsBreastComposition].code ^definition = """
    This code identifies the BiRads Assessment Category component. component.
	"""
  * component[biRadsBreastComposition].code = ObservationComponentSliceCodesCS#biRadsBreastComposition
  * component[biRadsBreastComposition].value[x] 1..1
  * component[biRadsBreastComposition].value[x] only CodeableConcept
  * component[biRadsBreastComposition].value[x] from BiRadsBreastCompositionVS