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
	public class ObservedChangesVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		/// <summary>
		/// Url of this value set.
		/// </summary>
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/ObservedChangesVS";

		public static TCoding Code_DecreaseInCalcifications = new TCoding(ObservedChangesCS.Code_DecreaseInCalcifications);                       // CSItemValueSet.cs:72
		public static TCoding Code_DecreaseInNumber = new TCoding(ObservedChangesCS.Code_DecreaseInNumber);                                       // CSItemValueSet.cs:72
		public static TCoding Code_DecreaseInSize = new TCoding(ObservedChangesCS.Code_DecreaseInSize);                                           // CSItemValueSet.cs:72
		public static TCoding Code_IncreaseInCalcifications = new TCoding(ObservedChangesCS.Code_IncreaseInCalcifications);                       // CSItemValueSet.cs:72
		public static TCoding Code_IncreaseInNumber = new TCoding(ObservedChangesCS.Code_IncreaseInNumber);                                       // CSItemValueSet.cs:72
		public static TCoding Code_IncreaseInSize = new TCoding(ObservedChangesCS.Code_IncreaseInSize);                                           // CSItemValueSet.cs:72
		public static TCoding Code_LessProminent = new TCoding(ObservedChangesCS.Code_LessProminent);                                             // CSItemValueSet.cs:72
		public static TCoding Code_MoreProminent = new TCoding(ObservedChangesCS.Code_MoreProminent);                                             // CSItemValueSet.cs:72
		public static TCoding Code_New = new TCoding(ObservedChangesCS.Code_New);                                                                 // CSItemValueSet.cs:72
		public static TCoding Code_NoLongerSeen = new TCoding(ObservedChangesCS.Code_NoLongerSeen);                                               // CSItemValueSet.cs:72
		public static TCoding Code_NotSignificantChanged = new TCoding(ObservedChangesCS.Code_NotSignificantChanged);                             // CSItemValueSet.cs:72
		public static TCoding Code_PartiallyRemoved = new TCoding(ObservedChangesCS.Code_PartiallyRemoved);                                       // CSItemValueSet.cs:72
		public static TCoding Code_RepresentsChange = new TCoding(ObservedChangesCS.Code_RepresentsChange);                                       // CSItemValueSet.cs:72
		public static TCoding Code_Stable = new TCoding(ObservedChangesCS.Code_Stable);                                                           // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_DecreaseInCalcifications;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_DecreaseInNumber;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_DecreaseInSize;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_IncreaseInCalcifications;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_IncreaseInNumber;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_IncreaseInSize;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_LessProminent;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_MoreProminent;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_New;                                                                                                                // CSItemValueSet.cs:83
		    yield return Code_NoLongerSeen;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_NotSignificantChanged;                                                                                              // CSItemValueSet.cs:83
		    yield return Code_PartiallyRemoved;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_RepresentsChange;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Stable;                                                                                                             // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
