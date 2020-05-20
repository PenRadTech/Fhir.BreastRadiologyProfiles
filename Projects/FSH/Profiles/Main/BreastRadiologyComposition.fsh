Profile: BreastRadiologyComposition
Parent: Composition
Title: "Breast Radiology Composition"
Description: """
    Composition instance for the Breast Radiology FHIR Document.
"""

  `  {
  `    "member" : {
  `      "groupingId" : "BaseResources",
  `      "sort": "B",
  `      "reference" : "StructureDefinition/BreastRadiologyComposition"
  `    }
  `  },

  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   <P>
This profile defines the composition instance for the Breast Radiology FHIR Document.
</P>
<P>
The composition object is a required part of the FHIR Document structure.
One composition must exist, and it must be the first resource stored in the FHIR document bundle.
</P>
<P>
The other exam related resources are referenced through the 
sections defined in this resource.
</P>
<P>
This composition creates the following sections.
</P>
<P>
A. Report Section.
This contains a single reference to the Breast Radiology Report
All Breast Radiology Findings are referenced by the reports results element.
</P>
<P>
B. Impressions Section.
All of the clinical impressions created for this exam are referenced in this section.
</P>
<P>
C. Recommendations Section.
All of the service and medication recommendations created for this exam are referenced in this section.
If a recommendation is in response to a particular observation or finding, then 
the recommendations 'reasonReference' should contain a  reference to the pertinant observation or finding.
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
  `   <object data="FocusGraph-BreastRadiologyComposition.svg" type="image/svg+xml">
  `     <img src="FocusGraph-BreastRadiologyComposition.svg" alt="image/svg+xml" />
  `   </object>
  ` </div>
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * . ^short = "US Core Race Extension"
  * type = LOINC#42132-1 "US Breast screening"

  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "Breast/Radiology/Composition",
  `      "cssClass" : "profile"
  `    }
  `  },
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "focus",
  `      "source" : "^BreastRadiologyComposition/$",
  `      "target" : "^BreastRadiologyComposition/section:",
  `      "depth": 0
  `    }
  `  },
  `  {
  `    "graphLinkByReference" : {
  `      "traversalName" : "focus",
  `      "source" : "^BreastRadiologyComposition/section:",
  `      "item" : ".entry",
  `      "depth": 1
  `    }
  `  },

  * section ^slicing.discriminator.type = #pattern
  * section ^slicing.discriminator.path = "code"
  * section ^slicing.rules = #open
  * section ^slicing.ordered = false
  * section ^slicing.description = """
    Breast Radiology Report Section
    """

  * section contains report 1..1 MS
  * section contains impressions 0..1 MS
  * section contains findingsRightBreast 0..1 MS
  * section contains findingsLeftBreast 0..1 MS
  * section contains relatedResources 0..1 MS
  * section contains recommendations 0..1 MS
  * section contains admin 0..1 MS

  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/section:report/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "section:report"
  `      },
  `      "displayName" : "Report Section",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyComposition.section:report"
  `    }
  `  },
  
  * section[report] ^definition = """
    This section references the Breast Radiology Report.

    One and only one Breast Radiology Report must be included in this section.
  """
  * section[report] 1..1
  * section[report] ^short = "Report Section."
  * section[report].code = CompositionSectionSliceCodesCS#sectionReport
  * section[report].title = "Breast Radiology Report"

  * section[report].entry 1..1
  * section[report].entry only Reference(BreastRadiologyReport)
  * section[report].entry ^short = "Breast Radiology Report reference"
  * section[report].entry ^definition = """
    Reference to the Breast Radiology Report.
	"""
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/section:impressions/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "section:impressions"
  `      },
  `      "displayName" : "Impressions Section",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyComposition.section:impressions"
  `    }
  `  },
  * section[impressions] ^definition = """
    This section contains references to the report's clinical impressions.
    """
  * section[impressions] 0..1
  * section[impressions] ^short = "Clinical Impressions Section."
  * section[impressions].code = CompositionSectionSliceCodesCS#sectionReport
  * section[impressions].title = "Clinical Impressions"


  * section[impressions].entry 0..*
  * section[impressions].entry only Reference(ClinicalImpression)
  * section[impressions].entry ^short = "Clinical Impression reference"
  * section[impressions].entry ^definition = """
    Reference to the clinical impression(s).
    """
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/section:findingsRightBreast/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "section:findingsRightBreast"
  `      },
  `      "displayName" : "Findings/Right Breast/Section",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyComposition.section:findingsRightBreast"
  `    }
  `  },
  * section[findingsRightBreast] ^definition = """
    This section contains references to the report's findings 
    for the right breast.
  """
  * section[findingsRightBreast] ^short = "Findings Right Breast Section."
  * section[findingsRightBreast].code = CompositionSectionSliceCodesCS#findingsRightBreast
  * section[findingsRightBreast].title = "Findings Right Breast Section"
  * section[findingsRightBreast] 0..1

  * section[findingsRightBreast].entry 0..*
  * section[findingsRightBreast].entry only Reference(FindingsRightBreast)
  * section[findingsRightBreast].entry ^short = "Finding Right breast reference"
  * section[findingsRightBreast].entry ^definition = """
  Reference to the finding for the Right breast.
  """
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/section:findingsLeftBreast/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "section:findingsLeftBreast"
  `      },
  `      "displayName" : "Findings/Left Breast/Section",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyComposition.section:findingsLeftBreast"
  `    }
  `  },
  * section[findingsLeftBreast] ^definition = """
    This section contains references to the report's findings 
    for the left breast.
  """
  * section[findingsLeftBreast] ^short = "Findings Left Breast Section."
  * section[findingsLeftBreast].code = CompositionSectionSliceCodesCS#findingsLeftBreast
  * section[findingsLeftBreast].title = "Findings Left Breast Section"
  * section[findingsLeftBreast] 0..1

  * section[findingsLeftBreast].entry 0..*
  * section[findingsLeftBreast].entry only Reference(FindingsLeftBreast)
  * section[findingsLeftBreast].entry ^short = "Finding Left breast reference"
  * section[findingsLeftBreast].entry ^definition = """
  Reference to the finding for the Left breast.
  """
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/section:relatedResources/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "section:relatedResources"
  `      },
  `      "displayName" : "Related Resources/Section",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyComposition.section:relatedResources"
  `    }
  `  },
  * section[relatedResources] ^definition = """
    References to FHIR clinical resources used during the exam or referenced by this report.
  """
  * section[relatedResources] ^short = "Related Clinical Resources Section."
  * section[relatedResources].code = CompositionSectionSliceCodesCS#relatedResources
  * section[relatedResources].title = "Related Clinical Resources Section."
  * section[relatedResources] 0..1

  * section[relatedResources].entry 0..*
  * section[relatedResources].entry only Reference(RESOURCEURL)
  * section[relatedResources].entry ^short = "Finding Right breast reference"
  * section[relatedResources].entry ^definition = """
  Reference to related resources.
  """
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/section:recommendations/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "section:recommendations"
  `      },
  `      "displayName" : "Recommendations/Section",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyComposition.section:recommendations"
  `    }
  `  },
  * section[recommendations] ^definition = """
    This section contains references to recommended actions 
	taken in response to the observations and findings of this report.
  """
  * section[recommendations] ^short = "Recommendation/Follow up Resources Section."
  * section[recommendations].code = CompositionSectionSliceCodesCS#recommendations
  * section[recommendations].title = "Recommendations Section."
  * section[recommendations] 0..1

  * section[recommendations].entry 0..*
  * section[recommendations].entry only Reference(MEDICATIONREQUESTURL)
                                  or Reference(SERVICEREQUESTURL)
								  //$or Reference(ServiceRecommendation)
								  
  * section[recommendations].entry ^short = "Recommendation resources"
  * section[recommendations].entry ^definition = """
  Reference to any recommendations.
  """
  `  {
  `    "graphNode" : {
  `      "nodeName" : "BreastRadiologyComposition/section:admin/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "section:admin"
  `      },
  `      "displayName" : "Admin/Section",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^BreastRadiologyComposition.section:admin"
  `    }
  `  },
  * section[admin] ^definition = """
    References to all administrative resources go here.
  """
  * section[admin] ^short = "Administrative section."
  * section[admin].code = CompositionSectionSliceCodesCS#admin
  * section[admin].title = "Administrative Section."
  * section[admin] 0..1

  * section[admin].entry 0..*
  * section[admin].entry only Reference(RESOURCEURL)
  * section[admin].entry ^short = "Administrative resources"
  * section[admin].entry ^definition = """
  Reference to any administrative resource.
  """