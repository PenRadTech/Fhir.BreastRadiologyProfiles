Profile: FindingsBiLateralBreastSectionFragment
Parent: Composition
Title: "Composition Findings BiLateral Breast Section Fragment"
Description: """
  Adds Findings BiLateral Breast Section to Composition
  """
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Composition Section slicing"
    //#apply NodeElement("", "section", "Sections")
    //#apply LinkByName("focus", "^%ProfileId%/$", "^%ProfileId%/section/$", "0", "Cmp")
    //#apply LinkByName("focus", "^%ProfileId%/section/$", "^%ProfileId%/section:", "0", "Cmp")
* section contains findingsBiLateralBreast 0..1 MS
* section[findingsBiLateralBreast] ^definition = """
	This section contains references to the report's findings 
	for both (bi lateral) breasts.
    """
* section[findingsBiLateralBreast] ^short = "Findings BiLateral Breast Section"
* section[findingsBiLateralBreast].code = CompositionSectionSliceCodesCS#findingsBiLateralBreast
* section[findingsBiLateralBreast].title = "Findings BiLateral Breast Section"

* section[findingsBiLateralBreast].entry 1..1
* section[findingsBiLateralBreast].entry only Reference(FindingsBiLateralBreast)
* section[findingsBiLateralBreast].entry ^short = "FindingsBiLateralBreast references"
* section[findingsBiLateralBreast].entry ^definition = """
	This section contains references to the report's findings 
	for both (bi lateral) breasts.
    """
    //#apply NodeElement("B", "section:findingsBiLateralBreast", "BiLateral Breast")
    //#apply LinkByBinding("focus", "^%ProfileId%/section:findingsBiLateralBreast/$", ".entry", "Cmp")