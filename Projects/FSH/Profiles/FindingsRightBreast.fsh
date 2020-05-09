Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 

Profile: FindingsRightBreast
Parent: Observation
Title: "Findings Right Breast"
Description: """
	The Findings Right Breast profile contains references to all the observations
	and exam information related to the Right breast.
	
	There is only 0 or 1 of these items in any Breast Radiology Document.
	"""  

  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0

  * value[x] only CodeableConcept
  * value[x] from BiRadsAssessmentCategoryVS (required)
  * value[x] 0..1 MS
  * value[x] ^definition = """
	Composite BiRad value for Right Breast.
	
	Typically this is the most severe of all the BiRad 
	codes set in any of the child observations of the Right Breast.
    """
	
  //$ e.AddComponentLink("Finding Value",
  // new SDefEditor.Cardinality(valueXDef),
  // null,
  // Global.ElementAnchor(valueXDef),
  // "CodeableConcept",
  // binding.Url);
  // ElementTreeNode sliceElementDef = e.ConfigureSliceByUrlDiscriminator("hasMember", false);
  // 
  // {
  // 	ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.MGFinding.Value(), 0, "1");
  // 	slice.ElementDefinition.MustSupport();
  // }
  // {
  // 	ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.MRIFinding.Value(), 0, "1");
  // 	slice.ElementDefinition.MustSupport();
  // }
  // {
  // 	ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.NMFinding.Value(), 0, "1");
  // 	slice.ElementDefinition.MustSupport();
  // }
  // {
  // 	ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.USFinding.Value(), 0, "1");
  // 	slice.ElementDefinition.MustSupport();
  // }

  * bodySite 1..1
  * bodySite = SNOMED#73056007 "Right breast structure (body structure)"
  * bodySite.extension contains BuilderSetValue named setValue 1..1
  * bodySite.extension[setValue].valueCodeableConcept = SNOMED#73056007 "Right breast structure (body structure)"

  * code = ObservationCodesCS#findingsRightBreastObservation