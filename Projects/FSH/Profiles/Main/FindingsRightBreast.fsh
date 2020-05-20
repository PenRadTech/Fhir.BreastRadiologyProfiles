Profile: FindingsRightBreast
Parent: Observation
Title: "Findings Right Breast"
Description: """
	Findings Right Breast profile.
	"""  

  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   <p>
 The Findings Right Breast profile contains references to all the observations
 and exam information related to the Right breast.
</p>
<p>
 There are only 0 or 1 of these items in any Breast Radiology Document.
</p>
  `   <p>
  `     <u style="font-size:large;">Graphical Overview</u>
  `   </p>
  `   <p>
  `     This graph provides an overview of this profile, and its dependencies.
  `   </p>
  `   <p>
  `     Click on any of the elements of the graph to go to a section describing that element.
  `   </p>
  `   <object data="FocusGraph-FindingsRightBreast.svg" type="image/svg+xml">
  `     <img src="FocusGraph-FindingsRightBreast.svg" alt="image/svg+xml" />
  `   </object>
  ` </div>
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
  `  {
  `    "graphNode" : {
  `      "nodeName" : "FindingsRightBreast/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "Findings/Right Breast",
  `      "cssClass" : "profile"
  `    }
  `  },
  `  {
  `    "graphNode" : {
  `      "nodeName" : "FindingsRightBreast/bodySite/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "bodySite"
  `      },
  `      "displayName" : "Body Site",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^FindingsRightBreast.bodySite"
  `    }
  `  },
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "focus",
  `      "source" : "^FindingsRightBreast/$",
  `      "target" : "^FindingsRightBreast/",
  `      "depth": 0
  `    }
  `  },

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
  `  {
  `    "member" : {
  `      "groupingId" : "BaseResources",
  `      "sort": "C",
  `      "reference" : "StructureDefinition/FindingsRightBreast"
  `    }
  `  },

  * bodySite 1..1
  * bodySite = SNOMED#73056007 // "Right breast structure (body structure)"
  * code = ObservationCodesCS#findingsRightBreastObservation