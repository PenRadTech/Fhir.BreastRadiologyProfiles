
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"

// BiRad Fragment
// <b>Fragment that adds 'BiRad code' element to profile.</b>
#macro BiRadFragment()
  #apply once SliceComponent()
  #apply ObservationAddComponent("biRadsAssessmentCategory", "0..1", "BiRads", "BiRads Assessment Category component.",
  #	 """
  #  This slice contains the optional component that define the BiRAD risk code.
  #  The value of this component is a codeable concept chosen from the BiRadsAssessmentCategoriesVS valueset.
  #	 """,
  #  "ObservationComponentSliceCodes#targetBiRads")
	
  #apply ObservationSetComponentConcept("biRadsAssessmentCategory", "1..1", "BiRadsAssessmentCategoryVS")
#end
