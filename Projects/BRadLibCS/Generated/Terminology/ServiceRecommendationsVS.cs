using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class ServiceRecommendationsVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		/// <summary>
		/// Url of this value set.
		/// </summary>
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/ServiceRecommendationsVS";

		public static TCoding Code_3DImaging = new TCoding(ServiceRecommendationsCS.Code_3DImaging);                                              // CSItemValueSet.cs:72
		public static TCoding Code_3DSpotCC = new TCoding(ServiceRecommendationsCS.Code_3DSpotCC);                                                // CSItemValueSet.cs:72
		public static TCoding Code_3DSpotLM = new TCoding(ServiceRecommendationsCS.Code_3DSpotLM);                                                // CSItemValueSet.cs:72
		public static TCoding Code_3DSpotML = new TCoding(ServiceRecommendationsCS.Code_3DSpotML);                                                // CSItemValueSet.cs:72
		public static TCoding Code_3DSpotMLO = new TCoding(ServiceRecommendationsCS.Code_3DSpotMLO);                                              // CSItemValueSet.cs:72
		public static TCoding Code_AdditionalViews = new TCoding(ServiceRecommendationsCS.Code_AdditionalViews);                                  // CSItemValueSet.cs:72
		public static TCoding Code_AddlitionalViewsWithPossibleUltrasound = new TCoding(ServiceRecommendationsCS.Code_AddlitionalViewsWithPossibleUltrasound);// CSItemValueSet.cs:72
		public static TCoding Code_AxillaView = new TCoding(ServiceRecommendationsCS.Code_AxillaView);                                            // CSItemValueSet.cs:72
		public static TCoding Code_AxillaryTailView = new TCoding(ServiceRecommendationsCS.Code_AxillaryTailView);                                // CSItemValueSet.cs:72
		public static TCoding Code_Biopsy = new TCoding(ServiceRecommendationsCS.Code_Biopsy);                                                    // CSItemValueSet.cs:72
		public static TCoding Code_BiopsyBaseOnClinical = new TCoding(ServiceRecommendationsCS.Code_BiopsyBaseOnClinical);                        // CSItemValueSet.cs:72
		public static TCoding Code_CaudocranialView = new TCoding(ServiceRecommendationsCS.Code_CaudocranialView);                                // CSItemValueSet.cs:72
		public static TCoding Code_CCWithCompressionView = new TCoding(ServiceRecommendationsCS.Code_CCWithCompressionView);                      // CSItemValueSet.cs:72
		public static TCoding Code_CCWithMagnificationView = new TCoding(ServiceRecommendationsCS.Code_CCWithMagnificationView);                  // CSItemValueSet.cs:72
		public static TCoding Code_CleavageView = new TCoding(ServiceRecommendationsCS.Code_CleavageView);                                        // CSItemValueSet.cs:72
		public static TCoding Code_ClinicalConsultation = new TCoding(ServiceRecommendationsCS.Code_ClinicalConsultation);                        // CSItemValueSet.cs:72
		public static TCoding Code_ClinicalCorrelation = new TCoding(ServiceRecommendationsCS.Code_ClinicalCorrelation);                          // CSItemValueSet.cs:72
		public static TCoding Code_ClinicalFollowUp = new TCoding(ServiceRecommendationsCS.Code_ClinicalFollowUp);                                // CSItemValueSet.cs:72
		public static TCoding Code_CompareToPriorExams = new TCoding(ServiceRecommendationsCS.Code_CompareToPriorExams);                          // CSItemValueSet.cs:72
		public static TCoding Code_CompressionViews = new TCoding(ServiceRecommendationsCS.Code_CompressionViews);                                // CSItemValueSet.cs:72
		public static TCoding Code_ConeCompression = new TCoding(ServiceRecommendationsCS.Code_ConeCompression);                                  // CSItemValueSet.cs:72
		public static TCoding Code_CoreBiopsy = new TCoding(ServiceRecommendationsCS.Code_CoreBiopsy);                                            // CSItemValueSet.cs:72
		public static TCoding Code_CraniocaudalView = new TCoding(ServiceRecommendationsCS.Code_CraniocaudalView);                                // CSItemValueSet.cs:72
		public static TCoding Code_Cryoablation = new TCoding(ServiceRecommendationsCS.Code_Cryoablation);                                        // CSItemValueSet.cs:72
		public static TCoding Code_CystAspiration = new TCoding(ServiceRecommendationsCS.Code_CystAspiration);                                    // CSItemValueSet.cs:72
		public static TCoding Code_CystAspirationForRelief = new TCoding(ServiceRecommendationsCS.Code_CystAspirationForRelief);                  // CSItemValueSet.cs:72
		public static TCoding Code_DiagnosticAspiration = new TCoding(ServiceRecommendationsCS.Code_DiagnosticAspiration);                        // CSItemValueSet.cs:72
		public static TCoding Code_DiagnosticMammogram = new TCoding(ServiceRecommendationsCS.Code_DiagnosticMammogram);                          // CSItemValueSet.cs:72
		public static TCoding Code_DrainageTube = new TCoding(ServiceRecommendationsCS.Code_DrainageTube);                                        // CSItemValueSet.cs:72
		public static TCoding Code_Ductography = new TCoding(ServiceRecommendationsCS.Code_Ductography);                                          // CSItemValueSet.cs:72
		public static TCoding Code_ExaggeratedCCViews = new TCoding(ServiceRecommendationsCS.Code_ExaggeratedCCViews);                            // CSItemValueSet.cs:72
		public static TCoding Code_FNABiopsy = new TCoding(ServiceRecommendationsCS.Code_FNABiopsy);                                              // CSItemValueSet.cs:72
		public static TCoding Code_FollowUp = new TCoding(ServiceRecommendationsCS.Code_FollowUp);                                                // CSItemValueSet.cs:72
		public static TCoding Code_Followup3Months = new TCoding(ServiceRecommendationsCS.Code_Followup3Months);                                  // CSItemValueSet.cs:72
		public static TCoding Code_Followup6Months = new TCoding(ServiceRecommendationsCS.Code_Followup6Months);                                  // CSItemValueSet.cs:72
		public static TCoding Code_IfPreviousShowNoChange = new TCoding(ServiceRecommendationsCS.Code_IfPreviousShowNoChange);                    // CSItemValueSet.cs:72
		public static TCoding Code_LateralMagnificationView = new TCoding(ServiceRecommendationsCS.Code_LateralMagnificationView);                // CSItemValueSet.cs:72
		public static TCoding Code_LateralMedialView = new TCoding(ServiceRecommendationsCS.Code_LateralMedialView);                              // CSItemValueSet.cs:72
		public static TCoding Code_LateralView = new TCoding(ServiceRecommendationsCS.Code_LateralView);                                          // CSItemValueSet.cs:72
		public static TCoding Code_LateralWithCompressionView = new TCoding(ServiceRecommendationsCS.Code_LateralWithCompressionView);            // CSItemValueSet.cs:72
		public static TCoding Code_LateromedialOblique = new TCoding(ServiceRecommendationsCS.Code_LateromedialOblique);                          // CSItemValueSet.cs:72
		public static TCoding Code_LateromedialView = new TCoding(ServiceRecommendationsCS.Code_LateromedialView);                                // CSItemValueSet.cs:72
		public static TCoding Code_LymphNodeAssessment = new TCoding(ServiceRecommendationsCS.Code_LymphNodeAssessment);                          // CSItemValueSet.cs:72
		public static TCoding Code_MagnificationViews = new TCoding(ServiceRecommendationsCS.Code_MagnificationViews);                            // CSItemValueSet.cs:72
		public static TCoding Code_Mammogram = new TCoding(ServiceRecommendationsCS.Code_Mammogram);                                              // CSItemValueSet.cs:72
		public static TCoding Code_Mammogram3MonthFollowUp = new TCoding(ServiceRecommendationsCS.Code_Mammogram3MonthFollowUp);                  // CSItemValueSet.cs:72
		public static TCoding Code_Mammogram6MonthFollowUp = new TCoding(ServiceRecommendationsCS.Code_Mammogram6MonthFollowUp);                  // CSItemValueSet.cs:72
		public static TCoding Code_MammogramAndUltrasound3MonthFollowUp = new TCoding(ServiceRecommendationsCS.Code_MammogramAndUltrasound3MonthFollowUp);// CSItemValueSet.cs:72
		public static TCoding Code_MammogramAndUltrasound6MonthFollowUp = new TCoding(ServiceRecommendationsCS.Code_MammogramAndUltrasound6MonthFollowUp);// CSItemValueSet.cs:72
		public static TCoding Code_MediolateralObliqueView = new TCoding(ServiceRecommendationsCS.Code_MediolateralObliqueView);                  // CSItemValueSet.cs:72
		public static TCoding Code_MediolateralView = new TCoding(ServiceRecommendationsCS.Code_MediolateralView);                                // CSItemValueSet.cs:72
		public static TCoding Code_MLOWithCompressionView = new TCoding(ServiceRecommendationsCS.Code_MLOWithCompressionView);                    // CSItemValueSet.cs:72
		public static TCoding Code_MLOWithMagnificationView = new TCoding(ServiceRecommendationsCS.Code_MLOWithMagnificationView);                // CSItemValueSet.cs:72
		public static TCoding Code_MRI = new TCoding(ServiceRecommendationsCS.Code_MRI);                                                          // CSItemValueSet.cs:72
		public static TCoding Code_MRIBiopsy = new TCoding(ServiceRecommendationsCS.Code_MRIBiopsy);                                              // CSItemValueSet.cs:72
		public static TCoding Code_MRIFollowUp = new TCoding(ServiceRecommendationsCS.Code_MRIFollowUp);                                          // CSItemValueSet.cs:72
		public static TCoding Code_NeedleLocationAndSurgicalBiopsy = new TCoding(ServiceRecommendationsCS.Code_NeedleLocationAndSurgicalBiopsy);  // CSItemValueSet.cs:72
		public static TCoding Code_NippleInProfileView = new TCoding(ServiceRecommendationsCS.Code_NippleInProfileView);                          // CSItemValueSet.cs:72
		public static TCoding Code_OffAngleCCView = new TCoding(ServiceRecommendationsCS.Code_OffAngleCCView);                                    // CSItemValueSet.cs:72
		public static TCoding Code_OffAngleMLOView = new TCoding(ServiceRecommendationsCS.Code_OffAngleMLOView);                                  // CSItemValueSet.cs:72
		public static TCoding Code_PossStereotacticBx = new TCoding(ServiceRecommendationsCS.Code_PossStereotacticBx);                            // CSItemValueSet.cs:72
		public static TCoding Code_PossibleCoreBiopsy = new TCoding(ServiceRecommendationsCS.Code_PossibleCoreBiopsy);                            // CSItemValueSet.cs:72
		public static TCoding Code_PossibleDiagnosticMammogram = new TCoding(ServiceRecommendationsCS.Code_PossibleDiagnosticMammogram);          // CSItemValueSet.cs:72
		public static TCoding Code_PossibleStereotacticVacuumBiopsy = new TCoding(ServiceRecommendationsCS.Code_PossibleStereotacticVacuumBiopsy);// CSItemValueSet.cs:72
		public static TCoding Code_PossibleSurgicalConsult = new TCoding(ServiceRecommendationsCS.Code_PossibleSurgicalConsult);                  // CSItemValueSet.cs:72
		public static TCoding Code_PossibleSurgicalEvaluation = new TCoding(ServiceRecommendationsCS.Code_PossibleSurgicalEvaluation);            // CSItemValueSet.cs:72
		public static TCoding Code_PossibleUltrasound = new TCoding(ServiceRecommendationsCS.Code_PossibleUltrasound);                            // CSItemValueSet.cs:72
		public static TCoding Code_PossibleUltrasoundGuidedBiopsy = new TCoding(ServiceRecommendationsCS.Code_PossibleUltrasoundGuidedBiopsy);    // CSItemValueSet.cs:72
		public static TCoding Code_PossibleVacuumBiopsy = new TCoding(ServiceRecommendationsCS.Code_PossibleVacuumBiopsy);                        // CSItemValueSet.cs:72
		public static TCoding Code_RepeatCCView = new TCoding(ServiceRecommendationsCS.Code_RepeatCCView);                                        // CSItemValueSet.cs:72
		public static TCoding Code_RepeatMLOView = new TCoding(ServiceRecommendationsCS.Code_RepeatMLOView);                                      // CSItemValueSet.cs:72
		public static TCoding Code_RolledLateralView = new TCoding(ServiceRecommendationsCS.Code_RolledLateralView);                              // CSItemValueSet.cs:72
		public static TCoding Code_RolledMedialView = new TCoding(ServiceRecommendationsCS.Code_RolledMedialView);                                // CSItemValueSet.cs:72
		public static TCoding Code_ScintimammogramGuidedBiopsy = new TCoding(ServiceRecommendationsCS.Code_ScintimammogramGuidedBiopsy);          // CSItemValueSet.cs:72
		public static TCoding Code_Scintimammography = new TCoding(ServiceRecommendationsCS.Code_Scintimammography);                              // CSItemValueSet.cs:72
		public static TCoding Code_SpotCompression = new TCoding(ServiceRecommendationsCS.Code_SpotCompression);                                  // CSItemValueSet.cs:72
		public static TCoding Code_SpotMagnificationViews = new TCoding(ServiceRecommendationsCS.Code_SpotMagnificationViews);                    // CSItemValueSet.cs:72
		public static TCoding Code_StereotacticBx = new TCoding(ServiceRecommendationsCS.Code_StereotacticBx);                                    // CSItemValueSet.cs:72
		public static TCoding Code_SuperolateralIOView = new TCoding(ServiceRecommendationsCS.Code_SuperolateralIOView);                          // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalBiopsy = new TCoding(ServiceRecommendationsCS.Code_SurgicalBiopsy);                                    // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalConsult = new TCoding(ServiceRecommendationsCS.Code_SurgicalConsult);                                  // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalConsultAndBiopsy = new TCoding(ServiceRecommendationsCS.Code_SurgicalConsultAndBiopsy);                // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalEvaluation = new TCoding(ServiceRecommendationsCS.Code_SurgicalEvaluation);                            // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalExcision = new TCoding(ServiceRecommendationsCS.Code_SurgicalExcision);                                // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalOncologicEvaluation = new TCoding(ServiceRecommendationsCS.Code_SurgicalOncologicEvaluation);          // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalOncologicalConsult = new TCoding(ServiceRecommendationsCS.Code_SurgicalOncologicalConsult);            // CSItemValueSet.cs:72
		public static TCoding Code_TangentialView = new TCoding(ServiceRecommendationsCS.Code_TangentialView);                                    // CSItemValueSet.cs:72
		public static TCoding Code_TangentialViews = new TCoding(ServiceRecommendationsCS.Code_TangentialViews);                                  // CSItemValueSet.cs:72
		public static TCoding Code_Ultrasound = new TCoding(ServiceRecommendationsCS.Code_Ultrasound);                                            // CSItemValueSet.cs:72
		public static TCoding Code_Ultrasound2ndLook = new TCoding(ServiceRecommendationsCS.Code_Ultrasound2ndLook);                              // CSItemValueSet.cs:72
		public static TCoding Code_Ultrasound3MonthFollowUp = new TCoding(ServiceRecommendationsCS.Code_Ultrasound3MonthFollowUp);                // CSItemValueSet.cs:72
		public static TCoding Code_Ultrasound6MonthFollowUp = new TCoding(ServiceRecommendationsCS.Code_Ultrasound6MonthFollowUp);                // CSItemValueSet.cs:72
		public static TCoding Code_UltrasoundGuidedBx = new TCoding(ServiceRecommendationsCS.Code_UltrasoundGuidedBx);                            // CSItemValueSet.cs:72
		public static TCoding Code_UltrasoundLocationAndSurgicalBiopsy = new TCoding(ServiceRecommendationsCS.Code_UltrasoundLocationAndSurgicalBiopsy);// CSItemValueSet.cs:72
		public static TCoding Code_UltrasoundWithPossibleAddlitonalViews = new TCoding(ServiceRecommendationsCS.Code_UltrasoundWithPossibleAddlitonalViews);// CSItemValueSet.cs:72
		public static TCoding Code_UnspecifiedOther = new TCoding(ServiceRecommendationsCS.Code_UnspecifiedOther);                                // CSItemValueSet.cs:72
		public static TCoding Code_VacuumBx = new TCoding(ServiceRecommendationsCS.Code_VacuumBx);                                                // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_3DImaging;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_3DSpotCC;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_3DSpotLM;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_3DSpotML;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_3DSpotMLO;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_AdditionalViews;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_AddlitionalViewsWithPossibleUltrasound;                                                                             // CSItemValueSet.cs:83
		    yield return Code_AxillaView;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_AxillaryTailView;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Biopsy;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_BiopsyBaseOnClinical;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_CaudocranialView;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_CCWithCompressionView;                                                                                              // CSItemValueSet.cs:83
		    yield return Code_CCWithMagnificationView;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_CleavageView;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_ClinicalConsultation;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_ClinicalCorrelation;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_ClinicalFollowUp;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_CompareToPriorExams;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_CompressionViews;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_ConeCompression;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_CoreBiopsy;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_CraniocaudalView;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Cryoablation;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_CystAspiration;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_CystAspirationForRelief;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_DiagnosticAspiration;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_DiagnosticMammogram;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_DrainageTube;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Ductography;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_ExaggeratedCCViews;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_FNABiopsy;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_FollowUp;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_Followup3Months;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_Followup6Months;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_IfPreviousShowNoChange;                                                                                             // CSItemValueSet.cs:83
		    yield return Code_LateralMagnificationView;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_LateralMedialView;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_LateralView;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_LateralWithCompressionView;                                                                                         // CSItemValueSet.cs:83
		    yield return Code_LateromedialOblique;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_LateromedialView;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_LymphNodeAssessment;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_MagnificationViews;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_Mammogram;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_Mammogram3MonthFollowUp;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_Mammogram6MonthFollowUp;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_MammogramAndUltrasound3MonthFollowUp;                                                                               // CSItemValueSet.cs:83
		    yield return Code_MammogramAndUltrasound6MonthFollowUp;                                                                               // CSItemValueSet.cs:83
		    yield return Code_MediolateralObliqueView;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_MediolateralView;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_MLOWithCompressionView;                                                                                             // CSItemValueSet.cs:83
		    yield return Code_MLOWithMagnificationView;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_MRI;                                                                                                                // CSItemValueSet.cs:83
		    yield return Code_MRIBiopsy;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_MRIFollowUp;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_NeedleLocationAndSurgicalBiopsy;                                                                                    // CSItemValueSet.cs:83
		    yield return Code_NippleInProfileView;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_OffAngleCCView;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_OffAngleMLOView;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_PossStereotacticBx;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_PossibleCoreBiopsy;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_PossibleDiagnosticMammogram;                                                                                        // CSItemValueSet.cs:83
		    yield return Code_PossibleStereotacticVacuumBiopsy;                                                                                   // CSItemValueSet.cs:83
		    yield return Code_PossibleSurgicalConsult;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_PossibleSurgicalEvaluation;                                                                                         // CSItemValueSet.cs:83
		    yield return Code_PossibleUltrasound;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_PossibleUltrasoundGuidedBiopsy;                                                                                     // CSItemValueSet.cs:83
		    yield return Code_PossibleVacuumBiopsy;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_RepeatCCView;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_RepeatMLOView;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_RolledLateralView;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_RolledMedialView;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_ScintimammogramGuidedBiopsy;                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Scintimammography;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_SpotCompression;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_SpotMagnificationViews;                                                                                             // CSItemValueSet.cs:83
		    yield return Code_StereotacticBx;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_SuperolateralIOView;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_SurgicalBiopsy;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_SurgicalConsult;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_SurgicalConsultAndBiopsy;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_SurgicalEvaluation;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_SurgicalExcision;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_SurgicalOncologicEvaluation;                                                                                        // CSItemValueSet.cs:83
		    yield return Code_SurgicalOncologicalConsult;                                                                                         // CSItemValueSet.cs:83
		    yield return Code_TangentialView;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_TangentialViews;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_Ultrasound;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_Ultrasound2ndLook;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_Ultrasound3MonthFollowUp;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_Ultrasound6MonthFollowUp;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_UltrasoundGuidedBx;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_UltrasoundLocationAndSurgicalBiopsy;                                                                                // CSItemValueSet.cs:83
		    yield return Code_UltrasoundWithPossibleAddlitonalViews;                                                                              // CSItemValueSet.cs:83
		    yield return Code_UnspecifiedOther;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_VacuumBx;                                                                                                           // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
