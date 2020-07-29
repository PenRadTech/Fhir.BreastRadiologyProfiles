using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class OrientationCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/OrientationCS";

		public static Coding Code_ParallelToSkin = new Coding(System, "ParallelToSkin", "Parallel to skin");                                      // CSItemCodeSystem.cs:62
		public static Coding Code_PerpendicularToSkin = new Coding(System, "PerpendicularToSkin", "Perpendicular to skin (not parallel)");        // CSItemCodeSystem.cs:62
		public static Coding Code_TallerThanWide = new Coding(System, "TallerThanWide", "Taller than wide");                                      // CSItemCodeSystem.cs:62
		public static Coding Code_WiderThanTall = new Coding(System, "WiderThanTall", "Wider than tall");                                         // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_ParallelToSkin;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_PerpendicularToSkin;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_TallerThanWide;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_WiderThanTall;                                                                                                      // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
