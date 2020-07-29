using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class BreastBodyLocationClockPositionsCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS";

		public static Coding Code_1OClock = new Coding(System, "1O'clock", "1 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_2OClock = new Coding(System, "2O'clock", "2 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_3OClock = new Coding(System, "3O'clock", "3 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_4OClock = new Coding(System, "4O'clock", "4 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_5OClock = new Coding(System, "5O'clock", "5 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_6OClock = new Coding(System, "6O'clock", "6 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_7OClock = new Coding(System, "7O'clock", "7 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_8OClock = new Coding(System, "8O'clock", "8 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_9OClock = new Coding(System, "9O'clock", "9 o'clock");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_10OClock = new Coding(System, "10O'clock", "10 o'clock");                                                       // CSItemCodeSystem.cs:62
		public static Coding Code_11OClock = new Coding(System, "11O'clock", "11 o'clock");                                                       // CSItemCodeSystem.cs:62
		public static Coding Code_12OClock = new Coding(System, "12O'clock", "12 o'clock");                                                       // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_1OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_2OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_3OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_4OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_5OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_6OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_7OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_8OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_9OClock;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_10OClock;                                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_11OClock;                                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_12OClock;                                                                                                           // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
