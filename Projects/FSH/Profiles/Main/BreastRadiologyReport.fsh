Profile: BreastRadiologyReport
Parent: DiagnosticReport
Title: "Breast Radiology Report"
Description: """
	Breast Radiology Diagnostic Report.
	"""

  `  {
  `    "member" : {
  `      "groupingId" : "BaseResources",
  `      "sort": "C",
  `      "reference" : "StructureDefinition/BreastRadiologyReport"
  `    }
  `  },
  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   <p>
Breast Radiology Diagnostic Report is one of the components of a Breast Radiology Document.
</p>
<p>
Each Breast Radiology Document bundle will contain exactly one
Breast Radiology Document instance that is referenced in the
document's 'Report' section.
</p>
<p>
This instance will contain the top level results of the exam,
including the narrative result.
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
  `   <object data="FocusGraph-BreastRadiologyReport.svg" type="image/svg+xml">
  `     <img src="FocusGraph-BreastRadiologyReport.svg" alt="image/svg+xml" />
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
  `      "nodeName" : "BreastRadiologyReport/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "Report",
  `      "cssClass" : "profile"
  `    }
  `  },
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyReport/code/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "code"
  `      },
  `      "displayName" : "Code",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyReport.code"
  `    }
  `  },
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "focus",
  `      "source" : "^BreastRadiologyReport/$",
  `      "target" : "^BreastRadiologyReport/",
  `      "depth": 0
  `    }
  `  },
  
  * conclusionCode from BiRadsAssessmentCategoryVS (required)
  * code = LOINC#10193-1
  * specimen 0..0
  * result 0..0