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
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS";

		public static Coding Code_DecreaseInCalcifications = new Coding(System, "DecreaseInCalcifications", "Decrease in calcifications");        // CSItemCodeSystem.cs:59
		public static Coding Code_DecreaseInNumber = new Coding(System, "DecreaseInNumber", "Decrease in number");                                // CSItemCodeSystem.cs:59
		public static Coding Code_DecreaseInSize = new Coding(System, "DecreaseInSize", "Decrease in size");                                      // CSItemCodeSystem.cs:59
		public static Coding Code_IncreaseInCalcifications = new Coding(System, "IncreaseInCalcifications", "Increase in calcifications");        // CSItemCodeSystem.cs:59
		public static Coding Code_IncreaseInNumber = new Coding(System, "IncreaseInNumber", "Increase in number");                                // CSItemCodeSystem.cs:59
		public static Coding Code_IncreaseInSize = new Coding(System, "IncreaseInSize", "Increase in size");                                      // CSItemCodeSystem.cs:59
		public static Coding Code_LessProminent = new Coding(System, "LessProminent", "Less prominent");                                          // CSItemCodeSystem.cs:59
		public static Coding Code_MoreProminent = new Coding(System, "MoreProminent", "More prominent");                                          // CSItemCodeSystem.cs:59
		public static Coding Code_New = new Coding(System, "New", "New");                                                                         // CSItemCodeSystem.cs:59
		public static Coding Code_NoLongerSeen = new Coding(System, "NoLongerSeen", "No longer seen");                                            // CSItemCodeSystem.cs:59
		public static Coding Code_NotSignificantChanged = new Coding(System, "NotSignificantChanged", "Not significant changed");                 // CSItemCodeSystem.cs:59
		public static Coding Code_PartiallyRemoved = new Coding(System, "PartiallyRemoved", "Partially removed");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_RepresentsChange = new Coding(System, "RepresentsChange", "Represents change");                                 // CSItemCodeSystem.cs:59
		public static Coding Code_Stable = new Coding(System, "Stable", "Stable");                                                                // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_DecreaseInCalcifications;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_DecreaseInNumber;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_DecreaseInSize;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_IncreaseInCalcifications;                                                                                           // CSItemCodeSystem.cs:62
		    yield return Code_IncreaseInNumber;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_IncreaseInSize;                                                                                                     // CSItemCodeSystem.cs:62
		    yield return Code_LessProminent;                                                                                                      // CSItemCodeSystem.cs:62
		    yield return Code_MoreProminent;                                                                                                      // CSItemCodeSystem.cs:62
		    yield return Code_New;                                                                                                                // CSItemCodeSystem.cs:62
		    yield return Code_NoLongerSeen;                                                                                                       // CSItemCodeSystem.cs:62
		    yield return Code_NotSignificantChanged;                                                                                              // CSItemCodeSystem.cs:62
		    yield return Code_PartiallyRemoved;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_RepresentsChange;                                                                                                   // CSItemCodeSystem.cs:62
		    yield return Code_Stable;                                                                                                             // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
