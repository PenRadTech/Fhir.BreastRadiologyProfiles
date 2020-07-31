using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class PreviouslyDemonstratedByCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/PreviouslyDemonstratedByCS";

		public static Coding Code_Aspiration = new Coding(System, "Aspiration", "Aspiration");                                                    // CSItemCodeSystem.cs:55
		public static Coding Code_Biopsy = new Coding(System, "Biopsy", "Biopsy");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // CSItemCodeSystem.cs:55
		public static Coding Code_US = new Coding(System, "US", "US");                                                                            // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_Aspiration;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_Biopsy;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_MRI;                                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_US;                                                                                                                 // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
