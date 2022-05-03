Profile: ReportSectionFragment
Parent: Composition
Title: "Composition Report Section Fragment"
Description: """
  Adds Report Section to Composition
  One and only one Breast Imaging Report must be included in this section.
  """
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Breast Imaging Report Section"

* section contains report 1..1 MS
* section[report] ^short = "Report Section."
* section[report].code = CompositionSectionSliceCodesCS#report
* section[report].title = "Breast Imaging Report"

* section[report].entry 1..1
* section[report].entry only Reference(BreastRadiologyReport)
* section[report].entry ^short = "Breast Imaging Report reference"
* section[report].entry ^definition = """
    Reference to the Breast Imaging Report.
	"""