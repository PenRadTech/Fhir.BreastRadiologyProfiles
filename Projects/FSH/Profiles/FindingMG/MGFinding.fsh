Profile: MGFinding
Parent: Observation
Title: "Mammography Finding"
Description: """
    Mammography Finding
    """
  * code = ObservationCodesCS#mgFindingObservation
  
  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * category ^slicing.discriminator.type = #pattern
  * category ^slicing.discriminator.path = "$this"
  * category ^slicing.rules = #open
  * category ^slicing.ordered = false
  * category ^slicing.description = "Observation Category = imaging"
  * category contains categoryImaging 1..1
  * category[categoryImaging] = http://terminology.hl7.org/CodeSystem/observation-category#imaging
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * component 0..0
  * dataAbsentReason 0..0
  * value[x] 0..0
  * interpretation 0..0
  * referenceRange 0..0
  * interpretation 0..0
  * method 0..0  
  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityCyst 0..*
  * Observation.hasMember[abnormalityCyst] ^short = "'Cyst' reference. hasMember."
  * Observation.hasMember[abnormalityCyst] only Reference(AbnormalityCyst)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityDuct 0..*
  * Observation.hasMember[abnormalityDuct] ^short = "'Duct' reference. hasMember."
  * Observation.hasMember[abnormalityDuct] only Reference(AbnormalityDuct)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityForeignObject 0..*
  * Observation.hasMember[abnormalityForeignObject] ^short = "'Foreign Object' reference. hasMember."
  * Observation.hasMember[abnormalityForeignObject] only Reference(AbnormalityForeignObject)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityLymphNode 0..*
  * Observation.hasMember[abnormalityLymphNode] ^short = "'Lymph Node' reference. hasMember."
  * Observation.hasMember[abnormalityLymphNode] only Reference(AbnormalityLymphNode)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityMass 0..*
  * Observation.hasMember[abnormalityMass] ^short = "'Mass' reference. hasMember."
  * Observation.hasMember[abnormalityMass] only Reference(AbnormalityMass)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains associatedFeature 0..*
  * Observation.hasMember[associatedFeature] ^short = "'Associated Feature' reference. hasMember."
  * Observation.hasMember[associatedFeature] only Reference(AssociatedFeature)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityFibroadenoma 0..*
  * Observation.hasMember[abnormalityFibroadenoma] ^short = "'Fibroadenoma' reference. hasMember."
  * Observation.hasMember[abnormalityFibroadenoma] only Reference(AbnormalityFibroadenoma)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityArchDist 0..*
  * Observation.hasMember[abnormalityArchDist] ^short = "'Architectural Distortion' reference. hasMember."
  * Observation.hasMember[abnormalityArchDist] only Reference(AbnormalityArchitecturalDistortion)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityAsymmetry 0..*
  * Observation.hasMember[abnormalityAsymmetry] ^short = "'Asymmetry' reference. hasMember."
  * Observation.hasMember[abnormalityAsymmetry] only Reference(AbnormalityAsymmetry)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityCalcification 0..*
  * Observation.hasMember[abnormalityCalcification] ^short = "'Calcification' reference. hasMember."
  * Observation.hasMember[abnormalityCalcification] only Reference(AbnormalityCalcification)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityDensity 0..*
  * Observation.hasMember[abnormalityDensity] ^short = "'Density' reference. hasMember."
  * Observation.hasMember[abnormalityDensity] only Reference(AbnormalityDensity)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains abnormalityFatNecrosis 0..*
  * Observation.hasMember[abnormalityFatNecrosis] ^short = "'FatNecrosis' reference. hasMember."
  * Observation.hasMember[abnormalityFatNecrosis] only Reference(AbnormalityFatNecrosis)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains mgBreastDensity 1..1
  * Observation.hasMember[mgBreastDensity] ^short = "'Mammo Breast Density' reference. hasMember."
  * Observation.hasMember[mgBreastDensity] only Reference(MGBreastDensity)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------