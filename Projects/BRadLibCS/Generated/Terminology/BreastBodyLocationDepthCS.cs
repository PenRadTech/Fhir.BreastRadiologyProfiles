using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastBodyLocationDepthCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationDepthCS";

		public static Coding Code_AnteriorDepth = new Coding(System, "AnteriorDepth", "Anterior depth");                                          // CSItemCodeSystem.cs:62
		public static Coding Code_MiddleDepth = new Coding(System, "MiddleDepth", "Middle depth");                                                // CSItemCodeSystem.cs:62
		public static Coding Code_PosteriorDepth = new Coding(System, "PosteriorDepth", "Posterior depth");                                       // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_AnteriorDepth;                                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_MiddleDepth;                                                                                                        // CSItemCodeSystem.cs:65
		    yield return Code_PosteriorDepth;                                                                                                     // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
