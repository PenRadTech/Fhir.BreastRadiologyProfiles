// FindingBreastFragment
// Fragment definition for finding section of left or right breast
#use "HeaderFragment.inc"
#use "ObservationFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"

#macro FindingBreastFragment(%Laterality%)
Parent: Observation
Title: "Findings %Laterality% Breast"
Description: """
	Findings %Laterality% Breast profile.
	"""  

  #apply IntroDocGraph("""
  #<p>
  # The Findings %Laterality% Breast profile contains references to all the observations
  # and exam information related to the Right breast.
  #</p>
  #<p>
  # There are only 0 or 1 of these items in any Breast Radiology Document.
  #</p>
  # """)
  #apply HeaderFragment()
  #apply ObservationNoDeviceFragment()
  #apply GraphNodeProfile("Findings/%Laterality% Breast")
  #apply GraphNodeElement("bodySite", "Body Site")
  #apply GraphLinkByName("focus", "^%Profile%$", "^%Profile%/", "0")

  * value[x] only CodeableConcept
  * value[x] from BiRadsAssessmentCategoryVS (required)
  * value[x] 0..1 MS
  * value[x] ^definition = """
	Composite BiRad value for %Laterality% Breast.
	
	Typically this is the most severe of all the BiRad 
	codes set in any of the child observations of the %Laterality% Breast.
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
#end
