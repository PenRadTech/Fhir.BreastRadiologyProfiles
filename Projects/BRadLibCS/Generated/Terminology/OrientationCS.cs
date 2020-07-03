using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class %ClassName%
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/OrientationCS";

		public static Coding Code_ParallelToSkin = new Coding(System, "ParallelToSkin", "Parallel to skin");                                      // CSItemCodeSystem.cs:59
		public static Coding Code_PerpendicularToSkin = new Coding(System, "PerpendicularToSkin", "Perpendicular to skin (not parallel)");        // CSItemCodeSystem.cs:59
		public static Coding Code_TallerThanWide = new Coding(System, "TallerThanWide", "Taller than wide");                                      // CSItemCodeSystem.cs:59
		public static Coding Code_WiderThanTall = new Coding(System, "WiderThanTall", "Wider than tall");                                         // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_ParallelToSkin;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_PerpendicularToSkin;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_TallerThanWide;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_WiderThanTall;                                                                                                      // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
