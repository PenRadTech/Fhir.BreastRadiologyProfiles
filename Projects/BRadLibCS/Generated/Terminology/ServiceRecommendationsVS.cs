using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
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

		public static TCoding Code_3DImaging = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "3DImaging"));// CSItemValueSet.cs:67
		public static TCoding Code_3DSpotCC = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "3DSpotCC"));// CSItemValueSet.cs:67
		public static TCoding Code_3DSpotLM = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "3DSpotLM"));// CSItemValueSet.cs:67
		public static TCoding Code_3DSpotML = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "3DSpotML"));// CSItemValueSet.cs:67
		public static TCoding Code_3DSpotMLO = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "3DSpotMLO"));// CSItemValueSet.cs:67
		public static TCoding Code_AdditionalViews = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "AdditionalViews"));// CSItemValueSet.cs:67
		public static TCoding Code_AddlitionalViewsWithPossibleUltrasound = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "AddlitionalViewsWithPossibleUltrasound"));// CSItemValueSet.cs:67
		public static TCoding Code_AxillaView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "AxillaView"));// CSItemValueSet.cs:67
		public static TCoding Code_AxillaryTailView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "AxillaryTailView"));// CSItemValueSet.cs:67
		public static TCoding Code_Biopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Biopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_BiopsyBaseOnClinical = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "BiopsyBaseOnClinical"));// CSItemValueSet.cs:67
		public static TCoding Code_CaudocranialView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CaudocranialView"));// CSItemValueSet.cs:67
		public static TCoding Code_CCWithCompressionView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CCWithCompressionView"));// CSItemValueSet.cs:67
		public static TCoding Code_CCWithMagnificationView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CCWithMagnificationView"));// CSItemValueSet.cs:67
		public static TCoding Code_CleavageView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CleavageView"));// CSItemValueSet.cs:67
		public static TCoding Code_ClinicalConsultation = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "ClinicalConsultation"));// CSItemValueSet.cs:67
		public static TCoding Code_ClinicalCorrelation = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "ClinicalCorrelation"));// CSItemValueSet.cs:67
		public static TCoding Code_ClinicalFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "ClinicalFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_CompareToPriorExams = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CompareToPriorExams"));// CSItemValueSet.cs:67
		public static TCoding Code_CompressionViews = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CompressionViews"));// CSItemValueSet.cs:67
		public static TCoding Code_ConeCompression = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "ConeCompression"));// CSItemValueSet.cs:67
		public static TCoding Code_CoreBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CoreBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_CraniocaudalView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CraniocaudalView"));// CSItemValueSet.cs:67
		public static TCoding Code_Cryoablation = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Cryoablation"));// CSItemValueSet.cs:67
		public static TCoding Code_CystAspiration = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CystAspiration"));// CSItemValueSet.cs:67
		public static TCoding Code_CystAspirationForRelief = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "CystAspirationForRelief"));// CSItemValueSet.cs:67
		public static TCoding Code_DiagnosticAspiration = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "DiagnosticAspiration"));// CSItemValueSet.cs:67
		public static TCoding Code_DiagnosticMammogram = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "DiagnosticMammogram"));// CSItemValueSet.cs:67
		public static TCoding Code_DrainageTube = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "DrainageTube"));// CSItemValueSet.cs:67
		public static TCoding Code_Ductography = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Ductography"));// CSItemValueSet.cs:67
		public static TCoding Code_ExaggeratedCCViews = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "ExaggeratedCCViews"));// CSItemValueSet.cs:67
		public static TCoding Code_FNABiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "FNABiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_FollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Follow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_Followup3Months = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Followup3Months"));// CSItemValueSet.cs:67
		public static TCoding Code_Followup6Months = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Followup6Months"));// CSItemValueSet.cs:67
		public static TCoding Code_IfPreviousShowNoChange = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "IfPreviousShowNoChange"));// CSItemValueSet.cs:67
		public static TCoding Code_LateralMagnificationView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "LateralMagnificationView"));// CSItemValueSet.cs:67
		public static TCoding Code_LateralMedialView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "LateralMedialView"));// CSItemValueSet.cs:67
		public static TCoding Code_LateralView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "LateralView"));// CSItemValueSet.cs:67
		public static TCoding Code_LateralWithCompressionView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "LateralWithCompressionView"));// CSItemValueSet.cs:67
		public static TCoding Code_LateromedialOblique = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "LateromedialOblique"));// CSItemValueSet.cs:67
		public static TCoding Code_LateromedialView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "LateromedialView"));// CSItemValueSet.cs:67
		public static TCoding Code_LymphNodeAssessment = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "LymphNodeAssessment"));// CSItemValueSet.cs:67
		public static TCoding Code_MagnificationViews = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MagnificationViews"));// CSItemValueSet.cs:67
		public static TCoding Code_Mammogram = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Mammogram"));// CSItemValueSet.cs:67
		public static TCoding Code_Mammogram3MonthFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Mammogram3MonthFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_Mammogram6MonthFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Mammogram6MonthFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_MammogramAndUltrasound3MonthFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MammogramAndUltrasound3MonthFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_MammogramAndUltrasound6MonthFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MammogramAndUltrasound6MonthFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_MediolateralObliqueView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MediolateralObliqueView"));// CSItemValueSet.cs:67
		public static TCoding Code_MediolateralView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MediolateralView"));// CSItemValueSet.cs:67
		public static TCoding Code_MLOWithCompressionView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MLOWithCompressionView"));// CSItemValueSet.cs:67
		public static TCoding Code_MLOWithMagnificationView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MLOWithMagnificationView"));// CSItemValueSet.cs:67
		public static TCoding Code_MRI = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MRI"));// CSItemValueSet.cs:67
		public static TCoding Code_MRIBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MRIBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_MRIFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "MRIFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_NeedleLocationAndSurgicalBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "NeedleLocationAndSurgicalBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_NippleInProfileView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "NippleInProfileView"));// CSItemValueSet.cs:67
		public static TCoding Code_OffAngleCCView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "OffAngleCCView"));// CSItemValueSet.cs:67
		public static TCoding Code_OffAngleMLOView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "OffAngleMLOView"));// CSItemValueSet.cs:67
		public static TCoding Code_PossStereotacticBx = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Poss.StereotacticBx"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleCoreBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleCoreBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleDiagnosticMammogram = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleDiagnosticMammogram"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleStereotacticVacuumBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleStereotacticVacuumBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleSurgicalConsult = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleSurgicalConsult"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleSurgicalEvaluation = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleSurgicalEvaluation"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleUltrasound = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleUltrasound"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleUltrasoundGuidedBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleUltrasoundGuidedBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_PossibleVacuumBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "PossibleVacuumBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_RepeatCCView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "RepeatCCView"));// CSItemValueSet.cs:67
		public static TCoding Code_RepeatMLOView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "RepeatMLOView"));// CSItemValueSet.cs:67
		public static TCoding Code_RolledLateralView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "RolledLateralView"));// CSItemValueSet.cs:67
		public static TCoding Code_RolledMedialView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "RolledMedialView"));// CSItemValueSet.cs:67
		public static TCoding Code_ScintimammogramGuidedBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "ScintimammogramGuidedBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_Scintimammography = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Scintimammography"));// CSItemValueSet.cs:67
		public static TCoding Code_SpotCompression = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SpotCompression"));// CSItemValueSet.cs:67
		public static TCoding Code_SpotMagnificationViews = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SpotMagnificationViews"));// CSItemValueSet.cs:67
		public static TCoding Code_StereotacticBx = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "StereotacticBx"));// CSItemValueSet.cs:67
		public static TCoding Code_SuperolateralIOView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SuperolateralIOView"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SurgicalBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalConsult = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SurgicalConsult"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalConsultAndBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SurgicalConsultAndBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalEvaluation = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SurgicalEvaluation"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalExcision = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SurgicalExcision"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalOncologicEvaluation = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SurgicalOncologicEvaluation"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalOncologicalConsult = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "SurgicalOncologicalConsult"));// CSItemValueSet.cs:67
		public static TCoding Code_TangentialView = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "TangentialView"));// CSItemValueSet.cs:67
		public static TCoding Code_TangentialViews = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "TangentialViews"));// CSItemValueSet.cs:67
		public static TCoding Code_Ultrasound = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Ultrasound"));// CSItemValueSet.cs:67
		public static TCoding Code_Ultrasound2ndLook = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Ultrasound2ndLook"));// CSItemValueSet.cs:67
		public static TCoding Code_Ultrasound3MonthFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Ultrasound3MonthFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_Ultrasound6MonthFollowUp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Ultrasound6MonthFollow-up"));// CSItemValueSet.cs:67
		public static TCoding Code_UltrasoundGuidedBx = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "UltrasoundGuidedBx"));// CSItemValueSet.cs:67
		public static TCoding Code_UltrasoundLocationAndSurgicalBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "UltrasoundLocationAndSurgicalBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_UltrasoundWithPossibleAddlitonalViews = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "UltrasoundWithPossibleAddlitonalViews"));// CSItemValueSet.cs:67
		public static TCoding Code_UnspecifiedOther = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "Unspecified/Other"));// CSItemValueSet.cs:67
		public static TCoding Code_VacuumBx = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ServiceRecommendationsCS", "VacuumBx"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_3DImaging;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_3DSpotCC;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_3DSpotLM;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_3DSpotML;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_3DSpotMLO;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_AdditionalViews;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_AddlitionalViewsWithPossibleUltrasound;                                                                             // CSItemValueSet.cs:70
		    yield return Code_AxillaView;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_AxillaryTailView;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_Biopsy;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_BiopsyBaseOnClinical;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_CaudocranialView;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_CCWithCompressionView;                                                                                              // CSItemValueSet.cs:70
		    yield return Code_CCWithMagnificationView;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_CleavageView;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_ClinicalConsultation;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_ClinicalCorrelation;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_ClinicalFollowUp;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_CompareToPriorExams;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_CompressionViews;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_ConeCompression;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_CoreBiopsy;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_CraniocaudalView;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_Cryoablation;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_CystAspiration;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_CystAspirationForRelief;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_DiagnosticAspiration;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_DiagnosticMammogram;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_DrainageTube;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_Ductography;                                                                                                        // CSItemValueSet.cs:70
		    yield return Code_ExaggeratedCCViews;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_FNABiopsy;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_FollowUp;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_Followup3Months;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_Followup6Months;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_IfPreviousShowNoChange;                                                                                             // CSItemValueSet.cs:70
		    yield return Code_LateralMagnificationView;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_LateralMedialView;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_LateralView;                                                                                                        // CSItemValueSet.cs:70
		    yield return Code_LateralWithCompressionView;                                                                                         // CSItemValueSet.cs:70
		    yield return Code_LateromedialOblique;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_LateromedialView;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_LymphNodeAssessment;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_MagnificationViews;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_Mammogram;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_Mammogram3MonthFollowUp;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_Mammogram6MonthFollowUp;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_MammogramAndUltrasound3MonthFollowUp;                                                                               // CSItemValueSet.cs:70
		    yield return Code_MammogramAndUltrasound6MonthFollowUp;                                                                               // CSItemValueSet.cs:70
		    yield return Code_MediolateralObliqueView;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_MediolateralView;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_MLOWithCompressionView;                                                                                             // CSItemValueSet.cs:70
		    yield return Code_MLOWithMagnificationView;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_MRI;                                                                                                                // CSItemValueSet.cs:70
		    yield return Code_MRIBiopsy;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_MRIFollowUp;                                                                                                        // CSItemValueSet.cs:70
		    yield return Code_NeedleLocationAndSurgicalBiopsy;                                                                                    // CSItemValueSet.cs:70
		    yield return Code_NippleInProfileView;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_OffAngleCCView;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_OffAngleMLOView;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_PossStereotacticBx;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_PossibleCoreBiopsy;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_PossibleDiagnosticMammogram;                                                                                        // CSItemValueSet.cs:70
		    yield return Code_PossibleStereotacticVacuumBiopsy;                                                                                   // CSItemValueSet.cs:70
		    yield return Code_PossibleSurgicalConsult;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_PossibleSurgicalEvaluation;                                                                                         // CSItemValueSet.cs:70
		    yield return Code_PossibleUltrasound;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_PossibleUltrasoundGuidedBiopsy;                                                                                     // CSItemValueSet.cs:70
		    yield return Code_PossibleVacuumBiopsy;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_RepeatCCView;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_RepeatMLOView;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_RolledLateralView;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_RolledMedialView;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_ScintimammogramGuidedBiopsy;                                                                                        // CSItemValueSet.cs:70
		    yield return Code_Scintimammography;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_SpotCompression;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_SpotMagnificationViews;                                                                                             // CSItemValueSet.cs:70
		    yield return Code_StereotacticBx;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_SuperolateralIOView;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_SurgicalBiopsy;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_SurgicalConsult;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_SurgicalConsultAndBiopsy;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_SurgicalEvaluation;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_SurgicalExcision;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_SurgicalOncologicEvaluation;                                                                                        // CSItemValueSet.cs:70
		    yield return Code_SurgicalOncologicalConsult;                                                                                         // CSItemValueSet.cs:70
		    yield return Code_TangentialView;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_TangentialViews;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_Ultrasound;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_Ultrasound2ndLook;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_Ultrasound3MonthFollowUp;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_Ultrasound6MonthFollowUp;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_UltrasoundGuidedBx;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_UltrasoundLocationAndSurgicalBiopsy;                                                                                // CSItemValueSet.cs:70
		    yield return Code_UltrasoundWithPossibleAddlitonalViews;                                                                              // CSItemValueSet.cs:70
		    yield return Code_UnspecifiedOther;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_VacuumBx;                                                                                                           // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
