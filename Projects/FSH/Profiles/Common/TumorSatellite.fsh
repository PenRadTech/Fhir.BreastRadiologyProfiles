Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 
Alias: BREASTRADBASEURL = http://hl7.org/fhir/us/breast-radiology
Alias: COMPOSITIONURL = http://hl7.org/fhir/StructureDefinition/Composition
Alias: CLINICALIMPRESSIONURL = http://hl7.org/fhir/StructureDefinition/ClinicalImpression
Alias: DIAGNOSTICREPORTURL = http://hl7.org/fhir/StructureDefinition/DiagnosticReport
Alias: DOMAINRESOURCEURL = http://hl7.org/fhir/StructureDefinition/DomainResource
Alias: EXTENSIONURL = http://hl7.org/fhir/StructureDefinition/Extension
Alias: IMAGINGSTUDYURL = http://hl7.org/fhir/StructureDefinition/ImagingStudy
Alias: MEDICATIONREQUESTURL = http://hl7.org/fhir/StructureDefinition/MedicationRequest
Alias: OBSERVATIONURL = http://hl7.org/fhir/StructureDefinition/Observation
Alias: RESOURCEURL = http://hl7.org/fhir/StructureDefinition/Resource
Alias: RISKASSESSMENTURL = http://hl7.org/fhir/StructureDefinition/RiskAssessment
Alias: SERVICEREQUESTURL = http://hl7.org/fhir/StructureDefinition/ServiceRequest

Alias: CONTACTURL = http://hl7.org/Special/committees/cic

/*
 Common Tumor Satellite Observation
 */
Profile: TumorSatellite
Parent: Observation
Title: "Tumor Satellite"
Description: """
    Tumor Satellite
    """

  * . ^definition = """
    Tumor Satellite Observation.
	"""


	* code 1..1
	* code = ObservationCodes#tumorSatelliteObservation

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