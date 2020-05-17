/*
  Value set for ACR birads codes.
 */
ValueSet:  BiRadsAssessmentCategoryVS
Title: "BiRadsAssessmentCategory ValueSet"
Description:  "BiRadsAssessmentCategory Value Set"
  * codes from system BiRadsAssessmentCategoryCS


/*
  Code system for ACR birads codes.
 */
CodeSystem:  BiRadsAssessmentCategoryCS
Title: "BiRadsAssessmentCategory CodeSystem"
Description:  "BiRadsAssessmentCategory CodeSystem"
  // .SnomedDescription ClinicalFinding | 397138000 | Mammography assessment (Category 0)
  * #Category0 "Category 0 (Incomplete)"

  // .SnomedDescription ClinicalFinding | 397141009 | Mammography assessment (Category 2)
  * #Category2 "Category 2 (Benign)"

  // .SnomedDescription ClinicalFinding | 397143007 | Mammography assessment (Category 3)
  * #Category3 "Category 3 (Probably Benign)"

  // .SnomedDescription ClinicalFinding | 397144001 | Mammography assessment (Category 4)
  * #Category4 "Category 4 (Suspicious)"

  // .SnomedDescription Not found
  * #Category4A "Category 4A (Low suspicion)"

  // .SnomedDescription Not found
  * #Category4B "Category 4B (Moderate suspicion)"

  // .SnomedDescription Not found
  * #Category4C "Category 4C (High suspicion)"

  // .SnomedDescription ClinicalFinding | 397145000 | Mammography assessment (Category 5)
  * #Category5 "Category 5 (Highly Suggestive of Malignancy)"

  * #Category6 "Category 6 (Known Biopsy-Proven Malignancy)"