Profile: DensityFragment
Parent: Observation
Title: "Density Component Fragment"
Description: """
  Adds Density Component
  """

  // Define Density Slice
* component ^slicing.discriminator.type = #pattern
* component ^slicing.discriminator.path = "code"
* component ^slicing.rules = #open
* component ^slicing.ordered = false
* component ^slicing.description = "Component slicing"
* component contains density 0..1
* component[density] ^short = "Density component."
* component[density] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
* component[density] ^definition = """
    This slice contains the optional component that define the density of the abnormality.
    The value of this component is a codeable concept chosen from the LesionRadiographicDensityVS valueset.
    """
* component[density].code 1..1
* component[density].code ^short = "Density component code."
* component[density].code ^definition = """
    This code identifies the Density component.
    """
* component[density].code = ObservationComponentSliceCodesCS#density
* component[density].value[x] 0..1
* component[density].value[x] only CodeableConcept
* component[density].value[x] from LesionDensityVS