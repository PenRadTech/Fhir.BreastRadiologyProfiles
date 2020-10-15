Profile: MGBreastDensity
Parent: Observation
Title: "Mammography Breast Density"
Description: """
    Mammography Breast Density
    """
  * code = ObservationCodesCS#mgBreastDensityObservation
  
  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * hasMember 0..0
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
  * device 0..0

  * value[x] only CodeableConcept
  * value[x] 1..1
  * value[x] = ObservationCodesCS#mgBreastDensityObservation


  // -----------------------------------------
  // IG Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------