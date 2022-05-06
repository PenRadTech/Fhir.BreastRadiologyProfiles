Profile: FindingsRightBreastSectionFragment
Parent: Composition
Title: "Composition Findings Right Breast Section Fragment"
Description: """
  Adds Findings Right Breast Section to Composition
  """
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Breast Imaging Report Section"

* section contains findingsRightBreast 0..1 MS
* section[findingsRightBreast] ^definition = """
    This section contains references to the report's findings 
    for the right breast.
  """
* section[findingsRightBreast] ^short = "Findings Right Breast Section."
* section[findingsRightBreast].code = CompositionSectionSliceCodesCS#findingsRightBreast
* section[findingsRightBreast].title = "Findings Right Breast Section"

* section[findingsRightBreast].entry 0..*
* section[findingsRightBreast].entry only Reference(FindingsRightBreast)
* section[findingsRightBreast].entry ^short = "Finding Right breast reference"
* section[findingsRightBreast].entry ^definition = """
  Reference to the finding for the Right breast.
  """