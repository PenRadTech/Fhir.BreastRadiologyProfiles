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
* section ^slicing.description = "Breast Imaging Report Section"

* section contains impressions 0..1 MS
* section[impressions] ^definition = """
    This section contains references to the report's clinical impressions.
    """
* section[impressions] ^short = "Clinical Impressions Section."
* section[impressions].code = CompositionSectionSliceCodesCS#report
* section[impressions].title = "Clinical Impressions"


* section[impressions].entry 0..*
* section[impressions].entry only Reference(ClinicalImpression)
* section[impressions].entry ^short = "Clinical Impression reference"
* section[impressions].entry ^definition = """
    Reference to the clinical impression(s).
    """
    //#apply LinkByReference("frag", "^ImpressionsSectionFragment/section:report", ".entry", "1", "Bas")