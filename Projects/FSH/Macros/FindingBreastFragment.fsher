// FindingBreastFragment
// Fragment definition for finding section of left or right breast

RuleSet: FindingBreastFragment
//+Mixins: HeaderFragment, ObservationNoDeviceFragment
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * device 0..0
  //- Mixins:
  
  * value[x] only CodeableConcept
  * value[x] from BiRadsAssessmentCategoryVS (required)
  * value[x] 0..1 MS
  
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
