#include "Common.inc"
#use "NodeGraph.inc"

#macro StartSectionSlicing()
  * section ^slicing.discriminator.type = #pattern
  * section ^slicing.discriminator.path = "code"
  * section ^slicing.rules = #open
  * section ^slicing.ordered = false
  * section ^slicing.description = """
    Breast Radiology Report Section
    """
#end


  /*
   Compositon section for Breast Radiology Report.
   */
  #macro ReportSection(SliceName) 
  #apply GraphNode("focus", "%CurrentClass%/SectionNode/SliceName", "", "Report Section", "")
  * section[SliceName] ^definition = """
    This section references the Breast Radiology Report.

    One and only one Breast Radiology Report must be included in this section.
  """
  * section[SliceName] 1..1
  * section[SliceName] ^short = "Report Section."
  * section[SliceName].code = CompositionSectionSliceCodesCS#sectionReport
  * section[SliceName].title = "Breast Radiology Report"

  * section[SliceName].entry 1..1
  * section[SliceName].entry only Reference(BreastRadiologyReport)
  * section[SliceName].entry ^short = "Breast Radiology Report reference"
  * section[SliceName].entry ^definition = """
    Reference to the Breast Radiology Report.
	"""
  #end


  /*
   Compositon section for Impressions.
   */
  #macro ImpressionsSection(SliceName) 
  #apply GraphNode("focus", "%CurrentClass%/SectionNode/SliceName", "", "Impressions Section", "")
  * section[SliceName] ^definition = """
    This section contains references to the report's clinical impressions.
    """
  * section[SliceName] 0..1
  * section[SliceName] ^short = "Clinical Impressions Section."
  * section[SliceName].code = CompositionSectionSliceCodesCS#sectionReport
  * section[SliceName].title = "Clinical Impressions"


  * section[SliceName].entry 0..*
  * section[SliceName].entry only Reference(ClinicalImpression)
  * section[SliceName].entry ^short = "Clinical Impression reference"
  * section[SliceName].entry ^definition = """
    Reference to the clinical impression(s).
    """
#end






  /*
   Compositon section for Left Breast Findings.
   */
  #macro FindingsLeftBreastSection(SliceName) 
  #apply GraphNode("focus", "%CurrentClass%/SectionNode/SliceName", "", "Findings/Left Breast/Section", "")
  * section[SliceName] ^definition = """
    This section contains references to the report's findings 
    for the left breast.
  """
  * section[SliceName] ^short = "Findings Left Breast Section."
  * section[SliceName].code = CompositionSectionSliceCodesCS#findingsLeftBreast
  * section[SliceName].title = "Findings Left Breast Section"
  * section[SliceName] 0..1

  * section[SliceName].entry 0..*
  * section[SliceName].entry only Reference(FindingsLeftBreast)
  * section[SliceName].entry ^short = "Finding Left breast reference"
  * section[SliceName].entry ^definition = """
  Reference to the finding for the Left breast.
  """
#end






  /*
   Compositon section for Right Breast Findings.
   */
  #macro FindingsRightBreastSection(SliceName) 
  #apply GraphNode("focus", "%CurrentClass%/SectionNode/SliceName", "", "Findings/Right Breast/Section", "")
  * section[SliceName] ^definition = """
    This section contains references to the report's findings 
    for the right breast.
  """
  * section[SliceName] ^short = "Findings Right Breast Section."
  * section[SliceName].code = CompositionSectionSliceCodesCS#findingsRightBreast
  * section[SliceName].title = "Findings Right Breast Section"
  * section[SliceName] 0..1

  * section[SliceName].entry 0..*
  * section[SliceName].entry only Reference(FindingsRightBreast)
  * section[SliceName].entry ^short = "Finding Right breast reference"
  * section[SliceName].entry ^definition = """
  Reference to the finding for the Right breast.
  """
#end
