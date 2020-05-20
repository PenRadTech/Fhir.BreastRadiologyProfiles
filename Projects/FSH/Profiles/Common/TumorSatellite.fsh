/*
 Common Tumor Satellite Observation
 */
Profile: TumorSatellite
Parent: Observation
Title: "Tumor Satellite"
Description: """
    Tumor Satellite
    """
  `  {
  `    "member" : {
  `      "groupingId" : "CommonResources/TumorSatellite",
  `      "sort": "",
  `      "reference" : "StructureDefinition/TumorSatellite"
  `    }
  `  },
  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   <p>
<b>'Tumor Satellite' Observation</b>
</p>
<p>
If a tumor observation's Observation.hasMember field contains a referrence 
to a 'Tumor Satellite' observation, then it is a satellite tumor.
 The tumor that it is a satellite of is called the index tumor.
</p>
<p>
The 'Tumor Satellite' observation may contain a reference to the index tumor observation.
</p>
<p>
The 'Tumor Satellite' observation may contain a distance to the index tumor.
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
  `   <object data="FocusGraph-TumorSatellite.svg" type="image/svg+xml">
  `     <img src="FocusGraph-TumorSatellite.svg" alt="image/svg+xml" />
  `   </object>
  ` </div>
  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * hasMember 0..0
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0
  * component 0..0

  `  {
  `    "graphNode" : {
  `      "nodeName" : "TumorSatellite/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "ConsistentWith",
  `      "cssClass" : "profile"
  `    }
  `  },
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "focus",
  `      "source" : "^TumorSatellite/$",
  `      "target" : "^TumorSatellite/",
  `      "depth": 0
  `    }
  `  },

  * . ^definition = """
    Tumor Satellite Observation.
	"""

  * code 1..1
  * code = ObservationCodes#tumorSatelliteObservation

  * value[x] 0..1
  //#apply SliceValue()
  //* value[x] contains quantity and range 0..1
  //* value[x][quantity] ^ pattern.system = "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
  
  //       {
  //         "id": "Observation.value[x]:valueRange",
  //         "path": "Observation.value[x]",
  //         "sliceName": "valueRange",
  //         "min": 0,
  //         "max": "1",
  //         "base": {
  //           "path": "Observation.value[x]",
  //           "min": 0,
  //           "max": "1"
  //         },
  //         "type": [
  //           {
  //             "code": "Range"
  //           }
  //         ],
  //         "patternRange": {
  //           "low": {
  //             "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
  //           },
  //           "high": {
  //             "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
  //           }
  //         }
  //       },

  `  {
  `    "graphNode" : {
  `      "nodeName" : "TumorSatellite/derivedFrom:indexTumor/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "derivedFrom:indexTumor"
  `      },
  `      "displayName" : "Derived From/Component",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^TumorSatellite.derivedFrom:indexTumor"
  `    }
  `  },

  * derivedFrom ^slicing.discriminator.type = #value
  * derivedFrom ^slicing.discriminator.path = "url"
  * derivedFrom ^slicing.rules = #open
  * derivedFrom ^slicing.ordered = false
  * derivedFrom ^slicing.description = "derivedFrom slicing"
  * derivedFrom contains indexTumor 0..1
  * derivedFrom[indexTumor] ^short = "Tumor Observation reference component."
  * derivedFrom[indexTumor] ^comment = """
    This observation is derived from a 'Tumor Observation reference' observation.
    """
  * derivedFrom[indexTumor] ^definition = """
    This derivedFrom slice references the index tumor.
    """
  * derivedFrom[indexTumor] only Reference(OBSERVATIONURL)