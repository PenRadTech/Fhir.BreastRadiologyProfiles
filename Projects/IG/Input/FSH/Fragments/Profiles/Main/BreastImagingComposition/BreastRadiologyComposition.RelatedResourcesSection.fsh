Profile: RelatedResourcesSectionFragment
Parent: Composition
Title: "Composition Related Resources Section Fragment"
Description: """
  Adds Related Resources Section to Composition
  """
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Breast Imaging Report Section"

* section contains relatedResources 0..1 MS
* section[relatedResources] ^definition = """
    References to FHIR clinical resources used during the exam or referenced by this report.

	Fhir resources that are related to this report, but dont fit into any of the other defined sections
	may be placed here. This section allows 'other' resources that the report author wants
	to be referenced by this report to be included without being constrained by only including
	those resourced that fit into the other defined sections.
  """
* section[relatedResources] ^short = "Related Clinical Resources Section."
* section[relatedResources].code = CompositionSectionSliceCodesCS#relatedResources
* section[relatedResources].title = "Related Clinical Resources Section."

* section[relatedResources].entry 0..*
* section[relatedResources].entry only Reference(RESOURCEURL)
* section[relatedResources].entry ^short = "Related Resources reference"
* section[relatedResources].entry ^definition = """
  Reference to related resources.
  """