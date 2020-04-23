#include "Common.inc"
#use "CompositionMacros.inc"
#use "NodeGraph.inc"


  /*
   Compositon section for Breast Radiology Report.
   */
  #macro ReportSection(SliceName) 
  # apply DefineSectionSlice("SliceName", 
  #  "Report Section.", 
  #  "CompositionSectionSliceCodesCS#sectionReport",
  #  "Breast Radiology Report",
  #  """
  #  This section references the Breast Radiology Report.
  #
  #  One and only one Breast Radiology Report must be included in this section.
  #  """ )

  # apply DefineSectionSliceEntry("SliceName", 
  #  "1..1", "Reference(BreastRadiologyReport)",
  #  "Breast Radiology Report reference",
  #  "Reference to the Breast Radiology Report.")
  //! TODO: Create Report section graph node.
  #end



  /*
   Compositon section for Impressions.
   */
  #macro ImpressionsSection(SliceName) 
  # apply DefineSectionSlice("SliceName", 
  #  "Clinical Impressions Section.", 
  #  "CompositionSectionSliceCodesCS#sectionReport",
  #  "Clinical Impressions",
  #  """
  #  This section contains references to the report's clinical impressions.
  #  """ )

  # apply DefineSectionSliceEntry("SliceName", 
  #                               "0..*", "Reference(BreastRadiologyReport)",
  #                               "Clinical Impression reference",
  #                               "Reference to the clinical impression(s).")
  //! TODO: Create graph node.
  #end
