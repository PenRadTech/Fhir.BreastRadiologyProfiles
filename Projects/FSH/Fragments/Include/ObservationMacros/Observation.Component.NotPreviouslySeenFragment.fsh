Profile: NotPreviouslySeenFragment
Parent: Observation
Title: "NotPreviously Seen Fragment"
Description: """
  Adds NotPreviously Seen Component slice.
  """

     * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains notPreviouslySeen 0..*
  * component[notPreviouslySeen] ^short = "Not Previously Seen component."
  * component[notPreviouslySeen] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[notPreviouslySeen] ^definition = """
    This slice contains the optional components that define prevous encounters in which this abnormality was not seen.
    The value of this component is a codeable concept chosen from the NotPreviouslySeenVS valueset.
    """
  * component[notPreviouslySeen].code 1..1
  * component[notPreviouslySeen].code ^short = "Not Previously Seen component code."
  * component[notPreviouslySeen].code ^definition = """
    This code identifies the Not Previously Seen component.
	"""
  * component[notPreviouslySeen].code = ObservationComponentSliceCodesCS#notPreviouslySeen

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[notPreviouslySeen].value[x] 1..1
  * component[notPreviouslySeen].value[x] only CodeableConcept
  * component[notPreviouslySeen].value[x] from NotPreviouslySeenVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------