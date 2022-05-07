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
* section ^slicing.description = "Composition Section slicing"
* section contains report 1..1 MS
* section[report] ^definition = """
	This section contains the main breast imaging report.
    """
* section[report] ^short = "Report Section"
* section[report].code = CompositionSectionSliceCodesCS#report
* section[report].title = "Report Section"

* section[report].entry 1..1
* section[report].entry only Reference(BreastImagingReport)
* section[report].entry ^short = "BreastImagingReport references"
* section[report].entry ^definition = """
	This section contains the main breast imaging report.
    """