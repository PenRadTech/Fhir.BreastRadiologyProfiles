using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastBodyLocationQuadrantsCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationQuadrantsCS";

		public static Coding Code_InferiorMedialQuadrent = new Coding(System, "InferiorMedialQuadrent", "Inferior medial quadrent (lower inner)");// CSItemCodeSystem.cs:62
		public static Coding Code_InferiorLateralQuadrent = new Coding(System, "InferiorLateralQuadrent", "Inferior lateral quadrent (lower outer)");// CSItemCodeSystem.cs:62
		public static Coding Code_SuperiorMedialQuadrent = new Coding(System, "SuperiorMedialQuadrent", "Superior medial quadrent (upper inner)");// CSItemCodeSystem.cs:62
		public static Coding Code_SuperiorLateralQuadrent = new Coding(System, "SuperiorLateralQuadrent", "Superior lateral quadrent (upper outer)");// CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_InferiorMedialQuadrent;                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_InferiorLateralQuadrent;                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_SuperiorMedialQuadrent;                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_SuperiorLateralQuadrent;                                                                                            // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
