using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class MarginCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS";

		public static Coding Code_AngularMargin = new Coding(System, "AngularMargin", "Angular margin");                                          // CSItemCodeSystem.cs:62
		public static Coding Code_CircumscribedMargin = new Coding(System, "CircumscribedMargin", "Circumscribed margin");                        // CSItemCodeSystem.cs:62
		public static Coding Code_IndistinctMargin = new Coding(System, "IndistinctMargin", "Indistinct margin");                                 // CSItemCodeSystem.cs:62
		public static Coding Code_IntraductalExtension = new Coding(System, "IntraductalExtension", "Intraductal extension");                     // CSItemCodeSystem.cs:62
		public static Coding Code_IrregularMargin = new Coding(System, "IrregularMargin", "Irregular margin");                                    // CSItemCodeSystem.cs:62
		public static Coding Code_LobulatedMargin = new Coding(System, "LobulatedMargin", "Lobulated margin");                                    // CSItemCodeSystem.cs:62
		public static Coding Code_MacrolobulatedMargin = new Coding(System, "MacrolobulatedMargin", "Macrolobulated margin");                     // CSItemCodeSystem.cs:62
		public static Coding Code_MicrolobulatedMargin = new Coding(System, "MicrolobulatedMargin", "Microlobulated margin");                     // CSItemCodeSystem.cs:62
		public static Coding Code_NonCircumscribedMargin = new Coding(System, "NonCircumscribedMargin", "Non circumscribed margin");              // CSItemCodeSystem.cs:62
		public static Coding Code_ObscuredMagin = new Coding(System, "ObscuredMagin", "Obscured magin");                                          // CSItemCodeSystem.cs:62
		public static Coding Code_SmoothMargin = new Coding(System, "SmoothMargin", "Smooth margin");                                             // CSItemCodeSystem.cs:62
		public static Coding Code_SpiculatedMargin = new Coding(System, "SpiculatedMargin", "Spiculated margin");                                 // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_AngularMargin;                                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_CircumscribedMargin;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_IndistinctMargin;                                                                                                   // CSItemCodeSystem.cs:65
		    yield return Code_IntraductalExtension;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_IrregularMargin;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_LobulatedMargin;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_MacrolobulatedMargin;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_MicrolobulatedMargin;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_NonCircumscribedMargin;                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_ObscuredMagin;                                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_SmoothMargin;                                                                                                       // CSItemCodeSystem.cs:65
		    yield return Code_SpiculatedMargin;                                                                                                   // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
