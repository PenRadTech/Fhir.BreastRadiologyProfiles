/*
   Value set that defines consistent with qualifier codes.
*/
ValueSet:  ConsistentWithQualifierVS
Title: "ConsistentWith Qualifier ValueSet"
Description:  "ConsistentWith Qualifier Value Set"
* insert Terminology_SnomedCopyright
* include codes from system $SCT where concept descendent-of #106230009 "Qualifier for certainty of diagnosis (qualifier value)"

* include SNOMED#47965005 "Differential diagnosis (contextual qualifier) (qualifier value)"

// #Resembles "Resembles"
// $FIXME
// * include SNOMED# ""