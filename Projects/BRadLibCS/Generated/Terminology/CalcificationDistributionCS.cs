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
	public class CalcificationDistributionCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS";

		public static Coding Code_ClusteredDistribution = new Coding(System, "ClusteredDistribution", "Clustered distribution");                  // CSItemCodeSystem.cs:55
		public static Coding Code_DiffuseDistribution = new Coding(System, "DiffuseDistribution", "Diffuse distribution");                        // CSItemCodeSystem.cs:55
		public static Coding Code_GroupedDistribution = new Coding(System, "GroupedDistribution", "Grouped distribution");                        // CSItemCodeSystem.cs:55
		public static Coding Code_LinearDistribution = new Coding(System, "LinearDistribution", "Linear distribution");                           // CSItemCodeSystem.cs:55
		public static Coding Code_RegionalDistribution = new Coding(System, "RegionalDistribution", "Regional distribution");                     // CSItemCodeSystem.cs:55
		public static Coding Code_ScatteredDistribution = new Coding(System, "ScatteredDistribution", "Scattered distribution");                  // CSItemCodeSystem.cs:55
		public static Coding Code_SegmentalDistribution = new Coding(System, "SegmentalDistribution", "Segmental distribution");                  // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_ClusteredDistribution;                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_DiffuseDistribution;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_GroupedDistribution;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_LinearDistribution;                                                                                                 // CSItemCodeSystem.cs:58
		    yield return Code_RegionalDistribution;                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_ScatteredDistribution;                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_SegmentalDistribution;                                                                                              // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
