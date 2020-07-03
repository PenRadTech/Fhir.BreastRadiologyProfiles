using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class %ClassName%
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS";

		public static Coding Code_3DImaging = new Coding(System, "3DImaging", "3D Imaging");                                                      // CSItemCodeSystem.cs:59
		public static Coding Code_3DSpotCC = new Coding(System, "3DSpotCC", "3D spot CC");                                                        // CSItemCodeSystem.cs:59
		public static Coding Code_3DSpotLM = new Coding(System, "3DSpotLM", "3D spot LM");                                                        // CSItemCodeSystem.cs:59
		public static Coding Code_3DSpotML = new Coding(System, "3DSpotML", "3D spot ML");                                                        // CSItemCodeSystem.cs:59
		public static Coding Code_3DSpotMLO = new Coding(System, "3DSpotMLO", "3D spot MLO");                                                     // CSItemCodeSystem.cs:59
		public static Coding Code_AdditionalViews = new Coding(System, "AdditionalViews", "Additional views");                                    // CSItemCodeSystem.cs:59
		public static Coding Code_AddlitionalViewsWithPossibleUltrasound = new Coding(System, "AddlitionalViewsWithPossibleUltrasound", "Addlitional views with possible ultrasound");// CSItemCodeSystem.cs:59
		public static Coding Code_AxillaView = new Coding(System, "AxillaView", "Axilla view");                                                   // CSItemCodeSystem.cs:59
		public static Coding Code_AxillaryTailView = new Coding(System, "AxillaryTailView", "Axillary tail view");                                // CSItemCodeSystem.cs:59
		public static Coding Code_Biopsy = new Coding(System, "Biopsy", "Biopsy");                                                                // CSItemCodeSystem.cs:59
		public static Coding Code_BiopsyBaseOnClinical = new Coding(System, "BiopsyBaseOnClinical", "Biopsy base on clinical");                   // CSItemCodeSystem.cs:59
		public static Coding Code_CaudocranialView = new Coding(System, "CaudocranialView", "Caudocranial view");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_CCWithCompressionView = new Coding(System, "CCWithCompressionView", "CC with compression view");                // CSItemCodeSystem.cs:59
		public static Coding Code_CCWithMagnificationView = new Coding(System, "CCWithMagnificationView", "CC with magnification view");          // CSItemCodeSystem.cs:59
		public static Coding Code_CleavageView = new Coding(System, "CleavageView", "Cleavage view");                                             // CSItemCodeSystem.cs:59
		public static Coding Code_ClinicalConsultation = new Coding(System, "ClinicalConsultation", "Clinical consultation");                     // CSItemCodeSystem.cs:59
		public static Coding Code_ClinicalCorrelation = new Coding(System, "ClinicalCorrelation", "Clinical correlation");                        // CSItemCodeSystem.cs:59
		public static Coding Code_ClinicalFollowUp = new Coding(System, "ClinicalFollow-up", "Clinical follow-up");                               // CSItemCodeSystem.cs:59
		public static Coding Code_CompareToPriorExams = new Coding(System, "CompareToPriorExams", "Compare to prior exams");                      // CSItemCodeSystem.cs:59
		public static Coding Code_CompressionViews = new Coding(System, "CompressionViews", "Compression views");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_ConeCompression = new Coding(System, "ConeCompression", "Cone compression");                                    // CSItemCodeSystem.cs:59
		public static Coding Code_CoreBiopsy = new Coding(System, "CoreBiopsy", "Core Biopsy");                                                   // CSItemCodeSystem.cs:59
		public static Coding Code_CraniocaudalView = new Coding(System, "CraniocaudalView", "Craniocaudal view");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_Cryoablation = new Coding(System, "Cryoablation", "Cryoablation");                                              // CSItemCodeSystem.cs:59
		public static Coding Code_CystAspiration = new Coding(System, "CystAspiration", "Cyst aspiration");                                       // CSItemCodeSystem.cs:59
		public static Coding Code_CystAspirationForRelief = new Coding(System, "CystAspirationForRelief", "Cyst aspiration for relief");          // CSItemCodeSystem.cs:59
		public static Coding Code_DiagnosticAspiration = new Coding(System, "DiagnosticAspiration", "Diagnostic aspiration");                     // CSItemCodeSystem.cs:59
		public static Coding Code_DiagnosticMammogram = new Coding(System, "DiagnosticMammogram", "Diagnostic Mammogram");                        // CSItemCodeSystem.cs:59
		public static Coding Code_DrainageTube = new Coding(System, "DrainageTube", "Drainage tube");                                             // CSItemCodeSystem.cs:59
		public static Coding Code_Ductography = new Coding(System, "Ductography", "Ductography");                                                 // CSItemCodeSystem.cs:59
		public static Coding Code_ExaggeratedCCViews = new Coding(System, "ExaggeratedCCViews", "Exaggerated CC views");                          // CSItemCodeSystem.cs:59
		public static Coding Code_FNABiopsy = new Coding(System, "FNABiopsy", "FNA biopsy");                                                      // CSItemCodeSystem.cs:59
		public static Coding Code_FollowUp = new Coding(System, "Follow-up", "Follow-up");                                                        // CSItemCodeSystem.cs:59
		public static Coding Code_Followup3Months = new Coding(System, "Followup3Months", "Followup 3 months");                                   // CSItemCodeSystem.cs:59
		public static Coding Code_Followup6Months = new Coding(System, "Followup6Months", "Followup 6 months");                                   // CSItemCodeSystem.cs:59
		public static Coding Code_IfPreviousShowNoChange = new Coding(System, "IfPreviousShowNoChange", "If previous show no change");            // CSItemCodeSystem.cs:59
		public static Coding Code_LateralMagnificationView = new Coding(System, "LateralMagnificationView", "Lateral magnification view");        // CSItemCodeSystem.cs:59
		public static Coding Code_LateralMedialView = new Coding(System, "LateralMedialView", "Lateral medial view");                             // CSItemCodeSystem.cs:59
		public static Coding Code_LateralView = new Coding(System, "LateralView", "Lateral view");                                                // CSItemCodeSystem.cs:59
		public static Coding Code_LateralWithCompressionView = new Coding(System, "LateralWithCompressionView", "Lateral with compression view"); // CSItemCodeSystem.cs:59
		public static Coding Code_LateromedialOblique = new Coding(System, "LateromedialOblique", "Lateromedial oblique");                        // CSItemCodeSystem.cs:59
		public static Coding Code_LateromedialView = new Coding(System, "LateromedialView", "Lateromedial view");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_LymphNodeAssessment = new Coding(System, "LymphNodeAssessment", "Lymph node assessment");                       // CSItemCodeSystem.cs:59
		public static Coding Code_MagnificationViews = new Coding(System, "MagnificationViews", "Magnification views");                           // CSItemCodeSystem.cs:59
		public static Coding Code_Mammogram = new Coding(System, "Mammogram", "Mammogram");                                                       // CSItemCodeSystem.cs:59
		public static Coding Code_Mammogram3MonthFollowUp = new Coding(System, "Mammogram3MonthFollow-up", "Mammogram 3 month follow-up");        // CSItemCodeSystem.cs:59
		public static Coding Code_Mammogram6MonthFollowUp = new Coding(System, "Mammogram6MonthFollow-up", "Mammogram 6 month follow-up");        // CSItemCodeSystem.cs:59
		public static Coding Code_MammogramAndUltrasound3MonthFollowUp = new Coding(System, "MammogramAndUltrasound3MonthFollow-up", "Mammogram and ultrasound 3 month follow-up");// CSItemCodeSystem.cs:59
		public static Coding Code_MammogramAndUltrasound6MonthFollowUp = new Coding(System, "MammogramAndUltrasound6MonthFollow-up", "Mammogram and ultrasound 6 month follow-up");// CSItemCodeSystem.cs:59
		public static Coding Code_MediolateralObliqueView = new Coding(System, "MediolateralObliqueView", "Mediolateral oblique view");           // CSItemCodeSystem.cs:59
		public static Coding Code_MediolateralView = new Coding(System, "MediolateralView", "Mediolateral view");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_MLOWithCompressionView = new Coding(System, "MLOWithCompressionView", "MLO with compression view");             // CSItemCodeSystem.cs:59
		public static Coding Code_MLOWithMagnificationView = new Coding(System, "MLOWithMagnificationView", "MLO with magnification view");       // CSItemCodeSystem.cs:59
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // CSItemCodeSystem.cs:59
		public static Coding Code_MRIBiopsy = new Coding(System, "MRIBiopsy", "MRI biopsy");                                                      // CSItemCodeSystem.cs:59
		public static Coding Code_MRIFollowUp = new Coding(System, "MRIFollow-up", "MRI follow-up");                                              // CSItemCodeSystem.cs:59
		public static Coding Code_NeedleLocationAndSurgicalBiopsy = new Coding(System, "NeedleLocationAndSurgicalBiopsy", "Needle location and surgical biopsy");// CSItemCodeSystem.cs:59
		public static Coding Code_NippleInProfileView = new Coding(System, "NippleInProfileView", "Nipple in profile view");                      // CSItemCodeSystem.cs:59
		public static Coding Code_OffAngleCCView = new Coding(System, "OffAngleCCView", "Off angle CC view");                                     // CSItemCodeSystem.cs:59
		public static Coding Code_OffAngleMLOView = new Coding(System, "OffAngleMLOView", "Off angle MLO view");                                  // CSItemCodeSystem.cs:59
		public static Coding Code_PossStereotacticBx = new Coding(System, "Poss.StereotacticBx", "Poss. Stereotactic Bx");                        // CSItemCodeSystem.cs:59
		public static Coding Code_PossibleCoreBiopsy = new Coding(System, "PossibleCoreBiopsy", "Possible core biopsy");                          // CSItemCodeSystem.cs:59
		public static Coding Code_PossibleDiagnosticMammogram = new Coding(System, "PossibleDiagnosticMammogram", "Possible Diagnostic Mammogram");// CSItemCodeSystem.cs:59
		public static Coding Code_PossibleStereotacticVacuumBiopsy = new Coding(System, "PossibleStereotacticVacuumBiopsy", "Possible stereotactic vacuum biopsy");// CSItemCodeSystem.cs:59
		public static Coding Code_PossibleSurgicalConsult = new Coding(System, "PossibleSurgicalConsult", "Possible surgical consult");           // CSItemCodeSystem.cs:59
		public static Coding Code_PossibleSurgicalEvaluation = new Coding(System, "PossibleSurgicalEvaluation", "Possible surgical evaluation");  // CSItemCodeSystem.cs:59
		public static Coding Code_PossibleUltrasound = new Coding(System, "PossibleUltrasound", "Possible ultrasound");                           // CSItemCodeSystem.cs:59
		public static Coding Code_PossibleUltrasoundGuidedBiopsy = new Coding(System, "PossibleUltrasoundGuidedBiopsy", "Possible ultrasound guided biopsy");// CSItemCodeSystem.cs:59
		public static Coding Code_PossibleVacuumBiopsy = new Coding(System, "PossibleVacuumBiopsy", "Possible vacuum biopsy");                    // CSItemCodeSystem.cs:59
		public static Coding Code_RepeatCCView = new Coding(System, "RepeatCCView", "Repeat CC view");                                            // CSItemCodeSystem.cs:59
		public static Coding Code_RepeatMLOView = new Coding(System, "RepeatMLOView", "Repeat MLO view");                                         // CSItemCodeSystem.cs:59
		public static Coding Code_RolledLateralView = new Coding(System, "RolledLateralView", "Rolled lateral view");                             // CSItemCodeSystem.cs:59
		public static Coding Code_RolledMedialView = new Coding(System, "RolledMedialView", "Rolled medial view");                                // CSItemCodeSystem.cs:59
		public static Coding Code_ScintimammogramGuidedBiopsy = new Coding(System, "ScintimammogramGuidedBiopsy", "Scintimammogram Guided Biopsy");// CSItemCodeSystem.cs:59
		public static Coding Code_Scintimammography = new Coding(System, "Scintimammography", "Scintimammography");                               // CSItemCodeSystem.cs:59
		public static Coding Code_SpotCompression = new Coding(System, "SpotCompression", "Spot compression");                                    // CSItemCodeSystem.cs:59
		public static Coding Code_SpotMagnificationViews = new Coding(System, "SpotMagnificationViews", "Spot magnification views");              // CSItemCodeSystem.cs:59
		public static Coding Code_StereotacticBx = new Coding(System, "StereotacticBx", "Stereotactic bx");                                       // CSItemCodeSystem.cs:59
		public static Coding Code_SuperolateralIOView = new Coding(System, "SuperolateralIOView", "Superolateral IO view");                       // CSItemCodeSystem.cs:59
		public static Coding Code_SurgicalBiopsy = new Coding(System, "SurgicalBiopsy", "Surgical biopsy");                                       // CSItemCodeSystem.cs:59
		public static Coding Code_SurgicalConsult = new Coding(System, "SurgicalConsult", "Surgical consult");                                    // CSItemCodeSystem.cs:59
		public static Coding Code_SurgicalConsultAndBiopsy = new Coding(System, "SurgicalConsultAndBiopsy", "Surgical consult and biopsy");       // CSItemCodeSystem.cs:59
		public static Coding Code_SurgicalEvaluation = new Coding(System, "SurgicalEvaluation", "Surgical evaluation");                           // CSItemCodeSystem.cs:59
		public static Coding Code_SurgicalExcision = new Coding(System, "SurgicalExcision", "Surgical excision");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_SurgicalOncologicEvaluation = new Coding(System, "SurgicalOncologicEvaluation", "Surgical oncologic evaluation");// CSItemCodeSystem.cs:59
		public static Coding Code_SurgicalOncologicalConsult = new Coding(System, "SurgicalOncologicalConsult", "Surgical oncological consult");  // CSItemCodeSystem.cs:59
		public static Coding Code_TangentialView = new Coding(System, "TangentialView", "Tangential view");                                       // CSItemCodeSystem.cs:59
		public static Coding Code_TangentialViews = new Coding(System, "TangentialViews", "Tangential views");                                    // CSItemCodeSystem.cs:59
		public static Coding Code_Ultrasound = new Coding(System, "Ultrasound", "Ultrasound");                                                    // CSItemCodeSystem.cs:59
		public static Coding Code_Ultrasound2ndLook = new Coding(System, "Ultrasound2ndLook", "Ultrasound 2nd Look");                             // CSItemCodeSystem.cs:59
		public static Coding Code_Ultrasound3MonthFollowUp = new Coding(System, "Ultrasound3MonthFollow-up", "Ultrasound 3 month follow-up");     // CSItemCodeSystem.cs:59
		public static Coding Code_Ultrasound6MonthFollowUp = new Coding(System, "Ultrasound6MonthFollow-up", "Ultrasound 6 month follow-up");     // CSItemCodeSystem.cs:59
		public static Coding Code_UltrasoundGuidedBx = new Coding(System, "UltrasoundGuidedBx", "Ultrasound guided bx");                          // CSItemCodeSystem.cs:59
		public static Coding Code_UltrasoundLocationAndSurgicalBiopsy = new Coding(System, "UltrasoundLocationAndSurgicalBiopsy", "Ultrasound location and surgical biopsy");// CSItemCodeSystem.cs:59
		public static Coding Code_UltrasoundWithPossibleAddlitonalViews = new Coding(System, "UltrasoundWithPossibleAddlitonalViews", "Ultrasound with possible addlitonal views");// CSItemCodeSystem.cs:59
		public static Coding Code_UnspecifiedOther = new Coding(System, "Unspecified/Other", "Unspecified / other");                              // CSItemCodeSystem.cs:59
		public static Coding Code_VacuumBx = new Coding(System, "VacuumBx", "Vacuum Bx");                                                         // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_3DImaging;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_3DSpotCC;                                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_3DSpotLM;                                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_3DSpotML;                                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_3DSpotMLO;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_AdditionalViews;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_AddlitionalViewsWithPossibleUltrasound;                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_AxillaView;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_AxillaryTailView;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_Biopsy;                                                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_BiopsyBaseOnClinical;                                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_CaudocranialView;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_CCWithCompressionView;                                                                                              // CSItemCodeSystem.cs:62
		    yield return Code_CCWithMagnificationView;                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_CleavageView;                                                                                                       // CSItemCodeSystem.cs:62
		    yield return Code_ClinicalConsultation;                                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_ClinicalCorrelation;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_ClinicalFollowUp;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_CompareToPriorExams;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_CompressionViews;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_ConeCompression;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_CoreBiopsy;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_CraniocaudalView;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_Cryoablation;                                                                                                       // CSItemCodeSystem.cs:62
		    yield return Code_CystAspiration;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_CystAspirationForRelief;                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_DiagnosticAspiration;                                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_DiagnosticMammogram;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_DrainageTube;                                                                                                       // CSItemCodeSystem.cs:62
		    yield return Code_Ductography;                                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_ExaggeratedCCViews;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_FNABiopsy;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_FollowUp;                                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_Followup3Months;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_Followup6Months;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_IfPreviousShowNoChange;                                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_LateralMagnificationView;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_LateralMedialView;                                                                                                  // CSItemCodeSystem.cs:62
		    yield return Code_LateralView;                                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_LateralWithCompressionView;                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_LateromedialOblique;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_LateromedialView;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_LymphNodeAssessment;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_MagnificationViews;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_Mammogram;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Mammogram3MonthFollowUp;                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_Mammogram6MonthFollowUp;                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_MammogramAndUltrasound3MonthFollowUp;                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_MammogramAndUltrasound6MonthFollowUp;                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_MediolateralObliqueView;                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_MediolateralView;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_MLOWithCompressionView;                                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_MLOWithMagnificationView;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_MRI;                                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_MRIBiopsy;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_MRIFollowUp;                                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_NeedleLocationAndSurgicalBiopsy;                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_NippleInProfileView;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_OffAngleCCView;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_OffAngleMLOView;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_PossStereotacticBx;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_PossibleCoreBiopsy;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_PossibleDiagnosticMammogram;                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_PossibleStereotacticVacuumBiopsy;                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_PossibleSurgicalConsult;                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_PossibleSurgicalEvaluation;                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_PossibleUltrasound;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_PossibleUltrasoundGuidedBiopsy;                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_PossibleVacuumBiopsy;                                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_RepeatCCView;                                                                                                       // CSItemCodeSystem.cs:62
		    yield return Code_RepeatMLOView;                                                                                                      // CSItemCodeSystem.cs:62
		    yield return Code_RolledLateralView;                                                                                                  // CSItemCodeSystem.cs:62
		    yield return Code_RolledMedialView;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_ScintimammogramGuidedBiopsy;                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_Scintimammography;                                                                                                  // CSItemCodeSystem.cs:62
		    yield return Code_SpotCompression;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_SpotMagnificationViews;                                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_StereotacticBx;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_SuperolateralIOView;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_SurgicalBiopsy;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_SurgicalConsult;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_SurgicalConsultAndBiopsy;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_SurgicalEvaluation;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_SurgicalExcision;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_SurgicalOncologicEvaluation;                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_SurgicalOncologicalConsult;                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_TangentialView;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_TangentialViews;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_Ultrasound;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_Ultrasound2ndLook;                                                                                                  // CSItemCodeSystem.cs:62
		    yield return Code_Ultrasound3MonthFollowUp;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_Ultrasound6MonthFollowUp;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_UltrasoundGuidedBx;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_UltrasoundLocationAndSurgicalBiopsy;                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_UltrasoundWithPossibleAddlitonalViews;                                                                              // CSItemCodeSystem.cs:62
		    yield return Code_UnspecifiedOther;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_VacuumBx;                                                                                                           // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
