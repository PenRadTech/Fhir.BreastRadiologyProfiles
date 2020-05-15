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
//
// Make a graph node that refers to a profile.
//

//
// Make a graph node that refers to an element in a profile.
//






Profile: BreastRadiologyReport
Parent: DiagnosticReport
Title: "Breast Radiology Report"
Description: """
	Breast Radiology Diagnostic Report.
	"""

  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  
  * conclusionCode from BiRadsAssessmentCategoryVS (required)
  * code = LOINC#10193-1
  * specimen 0..0
  * result 0..0