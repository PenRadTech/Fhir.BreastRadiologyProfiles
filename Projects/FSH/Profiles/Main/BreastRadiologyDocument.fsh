Profile: BreastRadiologyDocument
Parent: Bundle
Title: "Breast Radiology Document"
Description: """
	Breast Radiology Document Bundle.
    """

  `  {
  `    "member" : {
  `      "groupingId" : "BaseResources",
  `      "sort": "A",
  `      "reference" : "StructureDefinition/BreastRadiologyDocument"
  `    }
  `  },
  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   <P>
A Breast Radiology Document is an implementation of a Fhir Document. 
</P>
<P>
A FHIR Document is a Bundle that provides a single item containing all the 
resource instances that are a part of the Breast Radiology Diagnostic Report.
</P>
<P>
The Breast Radiology Document is an atomic item, meaning that no part in 
it can be changed without changing the entire bundle, and that 
all the parts are contained and in a single bundle  
</P>
<P>
The first entry in the bundle is a composition instance that provides an index
to all the other FHIR resource instances that are part of this document.
This index composition entry must be an instance of the BreastRadiologyComposition profile.
</P>
  `   <p>
  `     <u style="font-size:large;">Graphical Overview</u>
  `   </p>
  `   <p>
  `     This graph provides an overview of this profile, and its dependencies.
  `   </p>
  `   <p>
  `     Click on any of the elements of the graph to go to a section describing that element.
  `   </p>
  `   <object data="FocusGraph-BreastRadiologyDocument.svg" type="image/svg+xml">
  `     <img src="FocusGraph-BreastRadiologyDocument.svg" alt="image/svg+xml" />
  `   </object>
  ` </div>

  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyDocument/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "Breast/Radiology/Document",
  `      "cssClass" : "profile"
  `    }
  `  },
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "focus",
  `      "source" : "^BreastRadiologyDocument/$",
  `      "target" : "^BreastRadiologyDocument/entry:",
  `      "depth": 0
  `    }
  `  },
  `  {
  `    "graphLinkByReference" : {
  `      "traversalName" : "focus",
  `      "source" : "^BreastRadiologyDocument/entry:",
  `      "item" : ".resource",
  `      "depth": 1
  `    }
  `  },

  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyDocument/entry:index/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "entry:index"
  `      },
  `      "displayName" : "Composition index",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyDocument.entry:index"
  `    }
  `  },
  * entry ^slicing.discriminator.type = #value
  * entry ^slicing.discriminator.path = "fullUrl"
  * entry ^slicing.rules = #open
  * entry ^slicing.ordered = false
  * entry ^slicing.description = "Index composition slice"
  * entry contains index 1..1
  * entry[index].fullUrl = "index"
  * entry[index].resource only BreastRadiologyComposition