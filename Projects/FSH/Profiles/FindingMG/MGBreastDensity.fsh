Profile: MGBreastDensity
Parent: Observation
Title: "Mammography Breast Density"
Description: """
    Mammography Breast Density
    """



  * code 1..1
  * code = ObservationCodesCS#mgBreastDensityObservation

  * hasMember 0..0
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
  * value[x] = ObservationCodesCS#MGBreastDensityVS