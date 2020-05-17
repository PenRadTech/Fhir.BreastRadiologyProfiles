
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// ObservedCount Fragment
// Fragment that adds 'Observed Count' element to profile.

#macro ObservedCountFragment()
  #incompatible ObservationNoComponentFragment
  #apply once SliceComponent()
  #apply ObservationAddComponent("observedCount", "0..1", "Observed Count", "Observed Count component.",
  #	  """
  #   This component slice contains the number of items observed.
  #   This can be a quantity (i.e. 5), or a range (1 to 5).
  # 
  #   If the lower bound of the range is set but not the upper bound,
  #   then it means {lower bound} or more.
  # 
  #   If the lower bound of the range is not set but the upper bound is,
  #   then it means {upper bound} or less.
  #	  """,
  #   "ObservationComponentSliceCodes#obsCount")
	
  * component[observedCount].value[x] 1..1
  * component[observedCount].value[x] only Quantity or Range

#end
