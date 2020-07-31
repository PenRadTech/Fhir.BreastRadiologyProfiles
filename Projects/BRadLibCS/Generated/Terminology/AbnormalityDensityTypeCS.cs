using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class AbnormalityDensityTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDensityTypeCS";

		public static Coding Code_Density = new Coding(System, "Density", "Density");                                                             // CSItemCodeSystem.cs:55
		public static Coding Code_DensityFocalAsymmetry = new Coding(System, "DensityFocalAsymmetry", "Density focal asymmetry");                 // CSItemCodeSystem.cs:55
		public static Coding Code_DensityNodular = new Coding(System, "DensityNodular", "Density nodular");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_DensityTubular = new Coding(System, "DensityTubular", "Density tubular");                                       // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_Density;                                                                                                            // CSItemCodeSystem.cs:58
		    yield return Code_DensityFocalAsymmetry;                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_DensityNodular;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_DensityTubular;                                                                                                     // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
