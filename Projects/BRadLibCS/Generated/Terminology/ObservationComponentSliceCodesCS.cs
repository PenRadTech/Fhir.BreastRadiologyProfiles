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
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodesCS";

		public static Coding Code_AbnormalityCystType = new Coding(System, "abnormalityCystType", "Component code for 'Cyst Type' slice");        // CSItemCodeSystem.cs:59
		public static Coding Code_AbnormalityDuctType = new Coding(System, "abnormalityDuctType", "Component code for 'Duct Type' slice");        // CSItemCodeSystem.cs:59
		public static Coding Code_AbnormalityFibroAdenomaType = new Coding(System, "abnormalityFibroAdenomaType", "Component code for 'FibroAdenoma Type' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_AbnormalityForeignObjectType = new Coding(System, "abnormalityForeignObjectType", "Component code for 'Foreign Object Type' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_AbnormalityLymphNodeType = new Coding(System, "abnormalityLymphNodeType", "Component code for 'Lymph Node Type' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_AbnormalityMassType = new Coding(System, "abnormalityMassType", "Component code for 'Abnormality Mass Type' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_AbnormalityAsymmetryType = new Coding(System, "abnormalityAsymmetryType", "Component code for 'Abnormality Asymmetry Type' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_AbnormalityDensityType = new Coding(System, "abnormalityDensityType", "Component code for 'Abnormality Density Type' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_TargetBiRads = new Coding(System, "targetBiRads", "Component code for 'BiRads Code' slice");                    // CSItemCodeSystem.cs:59
		public static Coding Code_ConsistentWithValue = new Coding(System, "consistentWithValue", "Component code for 'Consistent With Value' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_ConsistentWithQualifier = new Coding(System, "consistentWithQualifier", "Component code for 'Consistent With Qualifier' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_CorrespondsWith = new Coding(System, "correspondsWith", "Component code for 'Corresponds With' slice");         // CSItemCodeSystem.cs:59
		public static Coding Code_PrevDemBy = new Coding(System, "prevDemBy", "Component code for 'Previously Demonstrated By' slice");           // CSItemCodeSystem.cs:59
		public static Coding Code_Margin = new Coding(System, "margin", "Component code for 'Margin' slice");                                     // CSItemCodeSystem.cs:59
		public static Coding Code_MgBreastDensity = new Coding(System, "mgBreastDensity", "Component code for 'MG Density' slice");               // CSItemCodeSystem.cs:59
		public static Coding Code_NotPreviouslySeen = new Coding(System, "notPreviouslySeen", "Component code for 'Not Previously Seen' slice");  // CSItemCodeSystem.cs:59
		public static Coding Code_ObsChanges = new Coding(System, "obsChanges", "Component code for 'Observed Changes' slice");                   // CSItemCodeSystem.cs:59
		public static Coding Code_ObsCount = new Coding(System, "obsCount", "Component code for 'Observed Count' slice");                         // CSItemCodeSystem.cs:59
		public static Coding Code_ObsSize = new Coding(System, "obsSize", "Component code for 'Observed Size' slice");                            // CSItemCodeSystem.cs:59
		public static Coding Code_ObsDistribution = new Coding(System, "obsDistribution", "Component code for 'Observed Distribution' slice");    // CSItemCodeSystem.cs:59
		public static Coding Code_ObsDistRegionSize = new Coding(System, "obsDistRegionSize", "Component code for 'Observed Distribution Size' slice");// CSItemCodeSystem.cs:59
		public static Coding Code_FeatureType = new Coding(System, "featureType", "Component code for 'Feature Type' slice");                     // CSItemCodeSystem.cs:59
		public static Coding Code_Orientation = new Coding(System, "orientation", "Component code for 'Orientation' slice");                      // CSItemCodeSystem.cs:59
		public static Coding Code_Shape = new Coding(System, "shape", "Component code for 'Shape' slice");                                        // CSItemCodeSystem.cs:59
		public static Coding Code_CalcificationType = new Coding(System, "calcificationType", "Component code for 'Calcification Type' slice");   // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_AbnormalityCystType;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_AbnormalityDuctType;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_AbnormalityFibroAdenomaType;                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_AbnormalityForeignObjectType;                                                                                       // CSItemCodeSystem.cs:62
		    yield return Code_AbnormalityLymphNodeType;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_AbnormalityMassType;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_AbnormalityAsymmetryType;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_AbnormalityDensityType;                                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_TargetBiRads;                                                                                                       // CSItemCodeSystem.cs:62
		    yield return Code_ConsistentWithValue;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_ConsistentWithQualifier;                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_CorrespondsWith;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_PrevDemBy;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Margin;                                                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_MgBreastDensity;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_NotPreviouslySeen;                                                                                                  // CSItemCodeSystem.cs:62
		    yield return Code_ObsChanges;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_ObsCount;                                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_ObsSize;                                                                                                            // CSItemCodeSystem.cs:62
		    yield return Code_ObsDistribution;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_ObsDistRegionSize;                                                                                                  // CSItemCodeSystem.cs:62
		    yield return Code_FeatureType;                                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_Orientation;                                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_Shape;                                                                                                              // CSItemCodeSystem.cs:62
		    yield return Code_CalcificationType;                                                                                                  // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
