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
	public class AbnormalityCystTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS";

		public static Coding Code_Cyst = new Coding(System, "Cyst", "Cyst");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_CystComplex = new Coding(System, "CystComplex", "Cyst complex");                                                // CSItemCodeSystem.cs:55
		public static Coding Code_CystComplicated = new Coding(System, "CystComplicated", "Cyst complicated");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_CystMicro = new Coding(System, "CystMicro", "Cyst micro");                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_CystOil = new Coding(System, "CystOil", "Cyst oil");                                                            // CSItemCodeSystem.cs:55
		public static Coding Code_CystSimple = new Coding(System, "CystSimple", "Cyst simple");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_CystWithDebris = new Coding(System, "CystWithDebris", "Cyst with debris");                                      // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_Cyst;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_CystComplex;                                                                                                        // CSItemCodeSystem.cs:58
		    yield return Code_CystComplicated;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_CystMicro;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_CystOil;                                                                                                            // CSItemCodeSystem.cs:58
		    yield return Code_CystSimple;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_CystWithDebris;                                                                                                     // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
