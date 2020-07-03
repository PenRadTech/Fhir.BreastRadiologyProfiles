using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityDensityTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDensityTypeCS";

		public static Coding Code_Density = new Coding(System, "Density", "Density");                                                             // CSItemCodeSystem.cs:62
		public static Coding Code_DensityFocalAsymmetry = new Coding(System, "DensityFocalAsymmetry", "Density focal asymmetry");                 // CSItemCodeSystem.cs:62
		public static Coding Code_DensityNodular = new Coding(System, "DensityNodular", "Density nodular");                                       // CSItemCodeSystem.cs:62
		public static Coding Code_DensityTubular = new Coding(System, "DensityTubular", "Density tubular");                                       // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_Density;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_DensityFocalAsymmetry;                                                                                              // CSItemCodeSystem.cs:65
		    yield return Code_DensityNodular;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_DensityTubular;                                                                                                     // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
