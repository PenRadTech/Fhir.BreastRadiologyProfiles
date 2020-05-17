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

Profile: ServiceRecommendation
Parent: ServiceRequest
Title: "Service Recommendation"
Description: """
  Service Recommendation
  """


  * ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
  * ^contact[0].telecom.value = "http://www.hl7.org/Special/committees/cic"
  * ^date = "2019-11-01"
  * ^status = http://hl7.org/fhir/ValueSet/publication-status#draft
  * ^publisher = "Hl7-Clinical Interoperability Council"
  * ^version = "0.0.2"


  * . ^definition = """
    Followup Service Recommendation.
	"""

  * code 1..1
  * code from RecommendationsVS  (extensible)


/*
   Value set that defines Recommendation codes.
 */
ValueSet:  RecommendationsVS
Title: "Recommendations ValueSet"
Description:  "Recommendations Value Set"
  * codes from system RecommendationsCS

/*
   Code system that defines Recommendation codes.
 */
CodeSystem: RecommendationsCS
Title: "Recommendations CodeSystem"
Description: "Recommendations code system"
  * #3DImaging "3D Imaging"
  * #3DSpotCC "3D spot CC"
  * #3DSpotLM "3D spot LM"
  * #3DSpotML "3D spot ML"
  * #3DSpotMLO "3D spot MLO"
  * #AdditionalViews "Additional views"
  * #AddlitionalViewsWithPossibleUltrasound "Addlitional views with possible ultrasound"
  * #AxillaView "Axilla view"
  * #AxillaryTailView "Axillary tail view"
  * #Biopsy "Biopsy"
  * #BiopsyBaseOnClinical "Biopsy base on clinical"
  * #CaudocranialView "Caudocranial view"
  * #CCWithCompressionView "CC with compression view"
  * #CCWithMagnificationView "CC with magnification view"
  * #CleavageView "Cleavage view"
  * #ClinicalConsultation "Clinical consultation"
  * #ClinicalCorrelation "Clinical correlation"
  * #ClinicalFollow-up "Clinical follow-up"
  * #CompareToPriorExams "Compare to prior exams"
  * #CompressionViews "Compression views"
  * #ConeCompression "Cone compression"
  * #CoreBiopsy "Core Biopsy"
  * #CraniocaudalView "Craniocaudal view"
  * #Cryoablation "Cryoablation"
  * #CystAspiration "Cyst aspiration"
  * #CystAspirationForRelief "Cyst aspiration for relief"
  * #DiagnosticAspiration "Diagnostic aspiration"
  * #DiagnosticMammogram "Diagnostic Mammogram"
  * #DrainageTube "Drainage tube"
  * #Ductography "Ductography"
  * #ExaggeratedCCViews "Exaggerated CC views"
  * #FNABiopsy "FNA biopsy"
  * #Follow-up "Follow-up"
  * #Followup3Months "Followup 3 months"
  * #Followup6Months "Followup 6 months"
  * #IfPreviousShowNoChange "If previous show no change"
  * #LateralMagnificationView "Lateral magnification view"
  * #LateralMedialView "Lateral medial view"
  * #LateralView "Lateral view"
  * #LateralWithCompressionView "Lateral with compression view"
  * #LateromedialOblique "Lateromedial oblique"
  * #LateromedialView "Lateromedial view"
  * #LymphNodeAssessment "Lymph node assessment"
  * #MagnificationViews "Magnification views"
  * #Mammogram "Mammogram"
  * #Mammogram3MonthFollow-up "Mammogram 3 month follow-up"
  * #Mammogram6MonthFollow-up "Mammogram 6 month follow-up"
  * #MammogramAndUltrasound3MonthFollow-up "Mammogram and ultrasound 3 month follow-up"
  * #MammogramAndUltrasound6MonthFollow-up "Mammogram and ultrasound 6 month follow-up"
  * #MediolateralObliqueView "Mediolateral oblique view"
  * #MediolateralView "Mediolateral view"
  * #MLOWithCompressionView "MLO with compression view"
  * #MLOWithMagnificationView "MLO with magnification view"
  * #MRI "MRI"
  * #MRIBiopsy "MRI biopsy"
  * #MRIFollow-up "MRI follow-up"
  * #NeedleLocationAndSurgicalBiopsy "Needle location and surgical biopsy"
  * #NippleInProfileView "Nipple in profile view"
  * #OffAngleCCView "Off angle CC view"
  * #OffAngleMLOView "Off angle MLO view"
  * #Poss.StereotacticBx "Poss. Stereotactic Bx"
  * #PossibleCoreBiopsy "Possible core biopsy"
  * #PossibleDiagnosticMammogram "Possible Diagnostic Mammogram"
  * #PossibleStereotacticVacuumBiopsy "Possible stereotactic vacuum biopsy"
  * #PossibleSurgicalConsult "Possible surgical consult"
  * #PossibleSurgicalEvaluation "Possible surgical evaluation"
  * #PossibleUltrasound "Possible ultrasound"
  * #PossibleUltrasoundGuidedBiopsy "Possible ultrasound guided biopsy"
  * #PossibleVacuumBiopsy "Possible vacuum biopsy"
  * #RepeatCCView "Repeat CC view"
  * #RepeatMLOView "Repeat MLO view"
  * #RolledLateralView "Rolled lateral view"
  * #RolledMedialView "Rolled medial view"
  * #ScintimammogramGuidedBiopsy "Scintimammogram Guided Biopsy"
  * #Scintimammography "Scintimammography"
  * #SpotCompression "Spot compression"
  * #SpotMagnificationViews "Spot magnification views"
  * #StereotacticBx "Stereotactic bx"
  * #SuperolateralIOView "Superolateral IO view"
  * #SurgicalBiopsy "Surgical biopsy"
  * #SurgicalConsult "Surgical consult"
  * #SurgicalConsultAndBiopsy "Surgical consult and biopsy"
  * #SurgicalEvaluation "Surgical evaluation"
  * #SurgicalExcision "Surgical excision"
  * #SurgicalOncologicEvaluation "Surgical oncologic evaluation"
  * #SurgicalOncologicalConsult "Surgical oncological consult"
  * #TangentialView "Tangential view"
  * #TangentialViews "Tangential views"
  * #Ultrasound "Ultrasound"
  * #Ultrasound2ndLook "Ultrasound 2nd Look"
  * #Ultrasound3MonthFollow-up "Ultrasound 3 month follow-up"
  * #Ultrasound6MonthFollow-up "Ultrasound 6 month follow-up"
  * #UltrasoundGuidedBx "Ultrasound guided bx"
  * #UltrasoundLocationAndSurgicalBiopsy "Ultrasound location and surgical biopsy"
  * #UltrasoundWithPossibleAddlitonalViews "Ultrasound with possible addlitonal views"
  * #Unspecified/Other "Unspecified / other"
  * #VacuumBx "Vacuum Bx"