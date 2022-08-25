Profile: ImpressionsSectionFragment
Parent: Composition
Title: "Composition Impressions Section Fragment"
Description: """
  Adds Impressionst Section to Composition
  """
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Composition Section slicing"
* section contains impressions 0..1 MS
* section[impressions] ^definition = """
    This section contains references to the report's clinical impressions.
    """
* section[impressions] ^short = "Impressions Section"
* section[impressions].code = CompositionSectionSliceCodesCS#impressions
* section[impressions].title = "Impressions Section"

* section[impressions].entry 1..*
* section[impressions].entry only Reference(ClinicalImpression)
* section[impressions].entry ^short = "ClinicalImpression references"
* section[impressions].entry ^definition = """
    This section contains references to the report's clinical impressions.
    """