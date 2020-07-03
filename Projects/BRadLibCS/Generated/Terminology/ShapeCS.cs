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
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ShapeCS";

		public static Coding Code_IrregularInShape = new Coding(System, "IrregularInShape", "Irregular in shape");                                // CSItemCodeSystem.cs:59
		public static Coding Code_LobulatedInShape = new Coding(System, "LobulatedInShape", "Lobulated in shape");                                // CSItemCodeSystem.cs:59
		public static Coding Code_OvalInShape = new Coding(System, "OvalInShape", "Oval in shape");                                               // CSItemCodeSystem.cs:59
		public static Coding Code_Reniform = new Coding(System, "Reniform", "Reniform");                                                          // CSItemCodeSystem.cs:59
		public static Coding Code_RoundInShape = new Coding(System, "RoundInShape", "Round in shape");                                            // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_IrregularInShape;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_LobulatedInShape;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_OvalInShape;                                                                                                        // CSItemCodeSystem.cs:62
		    yield return Code_Reniform;                                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_RoundInShape;                                                                                                       // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
