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
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDuctTypeCS";

		public static Coding Code_DuctNormal = new Coding(System, "DuctNormal", "Duct normal");                                                   // CSItemCodeSystem.cs:59
		public static Coding Code_SolitaryDilatedDuct = new Coding(System, "SolitaryDilatedDuct", "Solitary dilated duct");                       // CSItemCodeSystem.cs:59
		public static Coding Code_DuctEctasia = new Coding(System, "DuctEctasia", "Duct ectasia");                                                // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_DuctNormal;                                                                                                         // CSItemCodeSystem.cs:62
		    yield return Code_SolitaryDilatedDuct;                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_DuctEctasia;                                                                                                        // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
