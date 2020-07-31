using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class ConsistentWithQualifierCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithQualifierCS";

		public static Coding Code_DifferentialDiagnosis = new Coding(System, "DifferentialDiagnosis", "Differential diagnosis");                  // CSItemCodeSystem.cs:55
		public static Coding Code_LikelyRepresents = new Coding(System, "LikelyRepresents", "Likely represents");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_MostLikely = new Coding(System, "MostLikely", "Most likely");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_Resembles = new Coding(System, "Resembles", "Resembles");                                                       // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_DifferentialDiagnosis;                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_LikelyRepresents;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_MostLikely;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_Resembles;                                                                                                          // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
