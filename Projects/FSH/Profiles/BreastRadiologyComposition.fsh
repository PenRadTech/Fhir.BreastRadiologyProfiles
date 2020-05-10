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

Profile: BreastRadiologyComposition
Parent: Composition
Title: "Breast Radiology Composition"
Description: """
    Composition instance for the Breast Radiology FHIR Document.
"""

  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"
  * . ^short = "US Core Race Extension"
  * type = LOINC#42132-1 "US Breast screening"

  * section ^slicing.discriminator.type = #pattern
  * section ^slicing.discriminator.path = "code"
  * section ^slicing.rules = #open
  * section ^slicing.ordered = false
  * section ^slicing.description = """
    Breast Radiology Report Section
    """

  * section contains
      report 1..1 MS and
      impressions 0..1 MS and
      findingsRightBreast 0..1 MS and
      findingsLeftBreast 0..1 MS and
      relatedResources 0..1 MS and
      recommendations 0..1 MS and
      admin 0..1 MS

  
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