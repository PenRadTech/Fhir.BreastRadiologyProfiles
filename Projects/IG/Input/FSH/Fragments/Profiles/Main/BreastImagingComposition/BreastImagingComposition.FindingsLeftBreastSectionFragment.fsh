Profile: FindingsLeftBreastSectionFragment
Parent: Composition
Title: "Composition Findings Left Breast Section Fragment"
Description: """
  Adds Findings Left Breast Section to Composition
  """
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Composition Section slicing"
* section contains findingsLeftBreast 0..1 MS
* section[findingsLeftBreast] ^definition = """
	This section contains references to the report's findings 
	for the left breast.
    """
* section[findingsLeftBreast] ^short = "Findings Left Breast Section"
* section[findingsLeftBreast].code = CompositionSectionSliceCodesCS#findingsLeftBreast
* section[findingsLeftBreast].title = "Findings Left Breast Section"

* section[findingsLeftBreast].entry 1..1
* section[findingsLeftBreast].entry only Reference(FindingsLeftBreast)
* section[findingsLeftBreast].entry ^short = "FindingsLeftBreast references"
* section[findingsLeftBreast].entry ^definition = """
	This section contains references to the report's findings 
	for the left breast.
    """