using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CompositionSectionSliceCodesCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodesCS";

		public static Coding Code_Report = new Coding(System, "report", "Code to identify the 'Report' section slice");                           // CSItemCodeSystem.cs:62
		public static Coding Code_Impressions = new Coding(System, "impressions", "Code to identify the 'Impressions' section slice");            // CSItemCodeSystem.cs:62
		public static Coding Code_RelatedResources = new Coding(System, "relatedResources", "Code to identify the 'RelatedResources' section slice");// CSItemCodeSystem.cs:62
		public static Coding Code_Recommendations = new Coding(System, "recommendations", "Code to identify the 'Recommendations' section slice");// CSItemCodeSystem.cs:62
		public static Coding Code_FindingsLeftBreast = new Coding(System, "findingsLeftBreast", "Code to identify the 'Findings Left Breast' section slice");// CSItemCodeSystem.cs:62
		public static Coding Code_FindingsRightBreast = new Coding(System, "findingsRightBreast", "Code to identify the 'Findings Right Breast' section slice");// CSItemCodeSystem.cs:62
		public static Coding Code_Admin = new Coding(System, "admin", "Code to identify the 'Admin' section slice");                              // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_Report;                                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_Impressions;                                                                                                        // CSItemCodeSystem.cs:65
		    yield return Code_RelatedResources;                                                                                                   // CSItemCodeSystem.cs:65
		    yield return Code_Recommendations;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_FindingsLeftBreast;                                                                                                 // CSItemCodeSystem.cs:65
		    yield return Code_FindingsRightBreast;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_Admin;                                                                                                              // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
