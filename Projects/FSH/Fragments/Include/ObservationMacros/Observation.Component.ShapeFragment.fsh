Profile: ShapeFragment
Parent: Observation
Title: "Shape Components Fragment"
Description: """
  Adds Orientation, Shape, Margin, and Density Components
  """

   



  * bodySite 1..1
  * bodySite.extension contains BreastBodyLocationExtension named breastBodyLocation 1..1
  * bodySite.extension[breastBodyLocation] ^short = "breastBodyLocation extension."
  * bodySite.extension[breastBodyLocation] ^definition = "This extension slice contains the breastBodyLocation extension."

  // Define Orientation Slice

  * component contains orientation 0..1
  * component[orientation] ^short = "Orientation component."
  * component[orientation] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[orientation] ^definition = """
    This slice contains the optional component that define the orientation of the abnormality.
    The value of this component is a codeable concept chosen from the OrientationVS valueset.
    """
  * component[orientation].code 1..1
  * component[orientation].code ^short = "Orientation component code."
  * component[orientation].code ^definition = """
    This code identifies the Orientation component.
	"""
  * component[orientation].code = ObservationComponentSliceCodesCS#orientation


  * component[orientation].value[x] 1..1
  * component[orientation].value[x] only CodeableConcept
  * component[orientation].value[x] from OrientationVS


  // Define Shape Slice

  * component contains shape 0..1
  * component[shape] ^short = "Shape component."
  * component[shape] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[shape] ^definition = """
    This slice contains the optional component that define the shape of the abnormality.
    The value of this component is a codeable concept chosen from the ShapeVS valueset.
    """
  * component[shape].code 1..1
  * component[shape].code ^short = "Shape component code."
  * component[shape].code ^definition = """
    This code identifies the Shape component.
	"""
  * component[shape].code = ObservationComponentSliceCodesCS#shape


  * component[shape].value[x] 1..1
  * component[shape].value[x] only CodeableConcept
  * component[shape].value[x] from ShapeVS

  // Define Margin Slice

  * component contains margin 0..1
  * component[margin] ^short = "Margin component."
  * component[margin] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[margin] ^definition = """
    This slice contains the optional component that define the margin of the abnormality.
    The value of this component is a codeable concept chosen from the MarginVS valueset.
    """
  * component[margin].code 1..1
  * component[margin].code ^short = "Margin component code."
  * component[margin].code ^definition = """
    This code identifies the Margin component.
	"""
  * component[margin].code = ObservationComponentSliceCodesCS#margin


  * component[margin].value[x] 1..1
  * component[margin].value[x] only CodeableConcept
  * component[margin].value[x] from ShapeVS

  // Define Breast Density

  * component contains mgBreastDensity 0..1
  * component[mgBreastDensity] ^short = "Density component."
  * component[mgBreastDensity] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[mgBreastDensity] ^definition = """
    This slice contains the optional component that define the 
    observed density of the breast tissue.
    The value of this component is a codeable concept chosen from the MarginVS valueset.
    """
  * component[mgBreastDensity].code 1..1
  * component[mgBreastDensity].code ^short = "Density component code."
  * component[mgBreastDensity].code ^definition = """
    This code identifies the Density component.
	"""
  * component[mgBreastDensity].code = ObservationComponentSliceCodesCS#mgBreastDensity


  * component[mgBreastDensity].value[x] 1..1
  * component[mgBreastDensity].value[x] only CodeableConcept
  * component[mgBreastDensity].value[x] from MGBreastDensityVS