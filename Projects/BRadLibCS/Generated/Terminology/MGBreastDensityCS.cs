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
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGBreastDensityCS";

		public static Coding Code_AlmostEntirelyFat = new Coding(System, "AlmostEntirelyFat", "Almost entirely fat");                             // CSItemCodeSystem.cs:59
		public static Coding Code_ScatteredAreasOfFibroglandularDensity = new Coding(System, "ScatteredAreasOfFibroglandularDensity", "Scattered areas of fibroglandular density");// CSItemCodeSystem.cs:59
		public static Coding Code_HeterogeneouslyDense = new Coding(System, "HeterogeneouslyDense", "Heterogeneously dense");                     // CSItemCodeSystem.cs:59
		public static Coding Code_ExtremelyDense = new Coding(System, "ExtremelyDense", "Extremely dense");                                       // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_AlmostEntirelyFat;                                                                                                  // CSItemCodeSystem.cs:62
		    yield return Code_ScatteredAreasOfFibroglandularDensity;                                                                              // CSItemCodeSystem.cs:62
		    yield return Code_HeterogeneouslyDense;                                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_ExtremelyDense;                                                                                                     // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
