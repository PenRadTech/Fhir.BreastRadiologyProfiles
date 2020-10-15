Profile: TumorSatelliteFragment
Parent: Observation
Title: "Tumor Satellite Fragment"
Description: """
  This fragment adds the references for the Tumor Satellite extension.
  """

     * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains tumorSatellite 0..*
  * Observation.hasMember[tumorSatellite] ^short = "'Tumor Satellite' reference. hasMember."
  * Observation.hasMember[tumorSatellite] only Reference(TumorSatellite)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------