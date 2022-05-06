Profile: RecommendationsSectionFragment
Parent: Composition
Title: "Composition Recommendations Section Fragment"
Description: """
  Adds Recommendations Section to Composition
  """
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Breast Imaging Report Section"


* section contains recommendations 0..1 MS
* section[recommendations] ^definition = """
    This section contains references to recommended actions 
	taken in response to the observations and findings of this report.
  """
* section[recommendations] ^short = "Recommendation/Follow up Resources Section."
* section[recommendations].code = CompositionSectionSliceCodesCS#recommendations
* section[recommendations].title = "Recommendations Section."

* section[recommendations].entry 0..*
* section[recommendations].entry only Reference(BreastMedicationRequest or BreastServiceRequest or ServiceRecommendation)
* section[recommendations].entry ^short = "Recommendation resources"
* section[recommendations].entry ^definition = """
  Reference to any recommendations.
  """