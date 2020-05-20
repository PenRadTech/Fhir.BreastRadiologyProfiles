Profile: ServiceRecommendation
Parent: ServiceRequest
Title: "Service Recommendation"
Description: """
  Service Recommendation
  """

  `  {
  `    "member" : {
  `      "groupingId" : "BaseResources",
  `      "sort": "",
  `      "reference" : "StructureDefinition/ServiceRecommendation"
  `    }
  `  },

  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   <p>
Recommended follow-up action to be taken in response to the 
findings of this exam.
</p>
<p>
This resource is a profile of ServiceRequest. It's ServiceRequest.code is bound to a value set of common
 breast radiology recommendations. This list is not meant to be comprehensive, just commonly used items will
 will be included in the list.
</p>
<p>
The Breast Radiology Report contains references to zero or more recommendations, which may include ServiceRecommendation instances
 but is not limited to only ServiceRecommendation instances.
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
  `   <object data="FocusGraph-ServiceRecommendation.svg" type="image/svg+xml">
  `     <img src="FocusGraph-ServiceRecommendation.svg" alt="image/svg+xml" />
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
  `      "nodeName" : "ServiceRecommendation/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "ServiceRecommendation",
  `      "cssClass" : "profile"
  `    }
  `  },
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "focus",
  `      "source" : "^ServiceRecommendation/$",
  `      "target" : "^ServiceRecommendation/",
  `      "depth": 0
  `    }
  `  },
  `  {
  `    "graphNode" : {
  `      "nodeName" : "ServiceRecommendation/code/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "code"
  `      },
  `      "displayName" : "code",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^ServiceRecommendation.code"
  `    }
  `  },
  `  {
  `    "graphLinkByBinding" : {
  `      "traversalName" : "focus",
  `      "source" : "^ServiceRecommendation/code/$",
  `      "item" : "",
  `    }
  `  },

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