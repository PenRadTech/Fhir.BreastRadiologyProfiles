/*
  Value set for Breast Assessment values.
  This includes the ACR BIRADS assessment category and other codes for
  that may not be a part of BIRADS.
*/
ValueSet:  BreastAssessmentCategoryVS
Title: "Breast Assessment Category ValueSet"
Description:  "Breast Assessment Category Value Set"
* insert Terminology_SnomedCopyright
* include codes from valueset BiRadsAssessmentCategory
* $SCT#470272007 "Implantable lesion localization marker (Object)"