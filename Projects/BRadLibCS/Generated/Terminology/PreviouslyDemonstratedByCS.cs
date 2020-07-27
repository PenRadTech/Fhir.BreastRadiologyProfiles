using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class PreviouslyDemonstratedByCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/PreviouslyDemonstratedByCS";

		public static Coding Code_Aspiration = new Coding(System, "Aspiration", "Aspiration");                                                    // CSItemCodeSystem.cs:62
		public static Coding Code_Biopsy = new Coding(System, "Biopsy", "Biopsy");                                                                // CSItemCodeSystem.cs:62
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // CSItemCodeSystem.cs:62
		public static Coding Code_US = new Coding(System, "US", "US");                                                                            // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_Aspiration;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_Biopsy;                                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_MRI;                                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_US;                                                                                                                 // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
