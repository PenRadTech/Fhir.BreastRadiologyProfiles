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
	public class BreastBodyLocationDepthCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationDepthCS";

		public static Coding Code_AnteriorDepth = new Coding(System, "AnteriorDepth", "Anterior depth");                                          // CSItemCodeSystem.cs:55
		public static Coding Code_MiddleDepth = new Coding(System, "MiddleDepth", "Middle depth");                                                // CSItemCodeSystem.cs:55
		public static Coding Code_PosteriorDepth = new Coding(System, "PosteriorDepth", "Posterior depth");                                       // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_AnteriorDepth;                                                                                                      // CSItemCodeSystem.cs:58
		    yield return Code_MiddleDepth;                                                                                                        // CSItemCodeSystem.cs:58
		    yield return Code_PosteriorDepth;                                                                                                     // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
