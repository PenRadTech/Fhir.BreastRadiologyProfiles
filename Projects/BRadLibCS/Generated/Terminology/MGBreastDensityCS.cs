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
	public class MGBreastDensityCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGBreastDensityCS";

		public static Coding Code_AlmostEntirelyFat = new Coding(System, "AlmostEntirelyFat", "Almost entirely fat");                             // CSItemCodeSystem.cs:55
		public static Coding Code_ScatteredAreasOfFibroglandularDensity = new Coding(System, "ScatteredAreasOfFibroglandularDensity", "Scattered areas of fibroglandular density");// CSItemCodeSystem.cs:55
		public static Coding Code_HeterogeneouslyDense = new Coding(System, "HeterogeneouslyDense", "Heterogeneously dense");                     // CSItemCodeSystem.cs:55
		public static Coding Code_ExtremelyDense = new Coding(System, "ExtremelyDense", "Extremely dense");                                       // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_AlmostEntirelyFat;                                                                                                  // CSItemCodeSystem.cs:58
		    yield return Code_ScatteredAreasOfFibroglandularDensity;                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_HeterogeneouslyDense;                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_ExtremelyDense;                                                                                                     // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
