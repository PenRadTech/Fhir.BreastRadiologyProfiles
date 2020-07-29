using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class AbnormalityDuctTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDuctTypeCS";

		public static Coding Code_DuctNormal = new Coding(System, "DuctNormal", "Duct normal");                                                   // CSItemCodeSystem.cs:62
		public static Coding Code_SolitaryDilatedDuct = new Coding(System, "SolitaryDilatedDuct", "Solitary dilated duct");                       // CSItemCodeSystem.cs:62
		public static Coding Code_DuctEctasia = new Coding(System, "DuctEctasia", "Duct ectasia");                                                // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_DuctNormal;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_SolitaryDilatedDuct;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_DuctEctasia;                                                                                                        // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
