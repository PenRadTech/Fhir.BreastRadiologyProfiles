using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ObservationCodesCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodesCS";

		public static Coding Code_MgFindingObservation = new Coding(System, "mgFindingObservation", "MG Finding observation");                    // CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityCyst = new Coding(System, "abnormalityCyst", "Abnormality Cyst observation");                        // CSItemCodeSystem.cs:62
		public static Coding Code_AssociatedFeaturesObservation = new Coding(System, "associatedFeaturesObservation", "Associated Features observation");// CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityArchitecturalDistortionObservation = new Coding(System, "abnormalityArchitecturalDistortionObservation", "Abnormality Architectural Distortion observation");// CSItemCodeSystem.cs:62
		public static Coding Code_ConsistentWithObservation = new Coding(System, "consistentWithObservation", "Consistent With observation");     // CSItemCodeSystem.cs:62
		public static Coding Code_TumorSatelliteObservation = new Coding(System, "tumorSatelliteObservation", "Tumor Satellite observation");     // CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityCalcificationObservation = new Coding(System, "abnormalityCalcificationObservation", "Abnormality Calcification observation");// CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityDuctObservation = new Coding(System, "abnormalityDuctObservation", "Abnormality Duct observation");  // CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityForeignObjectObservation = new Coding(System, "abnormalityForeignObjectObservation", "Abnormality Foreign Object observation");// CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityLymphNodeObservation = new Coding(System, "abnormalityLymphNodeObservation", "Abnormality Lymph Node observation");// CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityMassObservation = new Coding(System, "abnormalityMassObservation", "Abnormality Mass observation");  // CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityFibroadenomaObservation = new Coding(System, "abnormalityFibroadenomaObservation", "Abnormality Fibroadenoma observation");// CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityAsymmetryObservation = new Coding(System, "abnormalityAsymmetryObservation", "MG Abnormality Asymmetry observation");// CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityDensityObservation = new Coding(System, "abnormalityDensityObservation", "MG Abnormality Density observation");// CSItemCodeSystem.cs:62
		public static Coding Code_AbnormalityFatNecrosisObservation = new Coding(System, "abnormalityFatNecrosisObservation", "MG Abnormality FatNecrosis observation");// CSItemCodeSystem.cs:62
		public static Coding Code_MgBreastDensityObservation = new Coding(System, "mgBreastDensityObservation", "MG Breast Density observation"); // CSItemCodeSystem.cs:62
		public static Coding Code_MriFindingObservation = new Coding(System, "mriFindingObservation", "MRI Finding observation");                 // CSItemCodeSystem.cs:62
		public static Coding Code_NmFindingObservation = new Coding(System, "nmFindingObservation", "NM Findingobservation");                     // CSItemCodeSystem.cs:62
		public static Coding Code_UsFindingObservation = new Coding(System, "usFindingObservation", "US Finding observation");                    // CSItemCodeSystem.cs:62
		public static Coding Code_FindingsLeftBreastObservation = new Coding(System, "findingsLeftBreastObservation", "Findings Left Breast observation");// CSItemCodeSystem.cs:62
		public static Coding Code_FindingsRightBreastObservation = new Coding(System, "findingsRightBreastObservation", "Findings Right Breast observation");// CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_MgFindingObservation;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityCyst;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_AssociatedFeaturesObservation;                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityArchitecturalDistortionObservation;                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_ConsistentWithObservation;                                                                                          // CSItemCodeSystem.cs:65
		    yield return Code_TumorSatelliteObservation;                                                                                          // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityCalcificationObservation;                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityDuctObservation;                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityForeignObjectObservation;                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityLymphNodeObservation;                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityMassObservation;                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityFibroadenomaObservation;                                                                                 // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityAsymmetryObservation;                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityDensityObservation;                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_AbnormalityFatNecrosisObservation;                                                                                  // CSItemCodeSystem.cs:65
		    yield return Code_MgBreastDensityObservation;                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_MriFindingObservation;                                                                                              // CSItemCodeSystem.cs:65
		    yield return Code_NmFindingObservation;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_UsFindingObservation;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_FindingsLeftBreastObservation;                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_FindingsRightBreastObservation;                                                                                     // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
