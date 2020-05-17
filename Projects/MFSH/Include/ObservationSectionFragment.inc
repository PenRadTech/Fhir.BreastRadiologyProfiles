
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
#use "ObservationMacros.inc"

// Observation Section Fragment
// this fragment constrains a generic observation to be a observation section.

#macro ObservationSectionFragment()
  #apply once ObservationFragment()
  #apply once ObservationNoComponentFragment()
  #apply once ObservationNoValueFragment()

  * interpretation 0..0
  * method 0..0  
#end
