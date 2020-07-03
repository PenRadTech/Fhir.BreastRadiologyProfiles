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
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BiRadsAssessmentCategoryCS";

		public static Coding Code_Category0 = new Coding(System, "Category0", "Category 0 (Incomplete)");                                         // CSItemCodeSystem.cs:59
		public static Coding Code_Category2 = new Coding(System, "Category2", "Category 2 (Benign)");                                             // CSItemCodeSystem.cs:59
		public static Coding Code_Category3 = new Coding(System, "Category3", "Category 3 (Probably Benign)");                                    // CSItemCodeSystem.cs:59
		public static Coding Code_Category4 = new Coding(System, "Category4", "Category 4 (Suspicious)");                                         // CSItemCodeSystem.cs:59
		public static Coding Code_Category4A = new Coding(System, "Category4A", "Category 4A (Low suspicion)");                                   // CSItemCodeSystem.cs:59
		public static Coding Code_Category4B = new Coding(System, "Category4B", "Category 4B (Moderate suspicion)");                              // CSItemCodeSystem.cs:59
		public static Coding Code_Category4C = new Coding(System, "Category4C", "Category 4C (High suspicion)");                                  // CSItemCodeSystem.cs:59
		public static Coding Code_Category5 = new Coding(System, "Category5", "Category 5 (Highly Suggestive of Malignancy)");                    // CSItemCodeSystem.cs:59
		public static Coding Code_Category6 = new Coding(System, "Category6", "Category 6 (Known Biopsy-Proven Malignancy)");                     // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_Category0;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Category2;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Category3;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Category4;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Category4A;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_Category4B;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_Category4C;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_Category5;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Category6;                                                                                                          // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
