using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
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

		public static TCoding Code_DecreaseInCalcifications = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "DecreaseInCalcifications"));// CSItemValueSet.cs:67
		public static TCoding Code_DecreaseInNumber = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "DecreaseInNumber"));// CSItemValueSet.cs:67
		public static TCoding Code_DecreaseInSize = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "DecreaseInSize"));// CSItemValueSet.cs:67
		public static TCoding Code_IncreaseInCalcifications = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "IncreaseInCalcifications"));// CSItemValueSet.cs:67
		public static TCoding Code_IncreaseInNumber = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "IncreaseInNumber"));// CSItemValueSet.cs:67
		public static TCoding Code_IncreaseInSize = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "IncreaseInSize"));// CSItemValueSet.cs:67
		public static TCoding Code_LessProminent = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "LessProminent"));// CSItemValueSet.cs:67
		public static TCoding Code_MoreProminent = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "MoreProminent"));// CSItemValueSet.cs:67
		public static TCoding Code_New = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "New"));  // CSItemValueSet.cs:67
		public static TCoding Code_NoLongerSeen = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "NoLongerSeen"));// CSItemValueSet.cs:67
		public static TCoding Code_NotSignificantChanged = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "NotSignificantChanged"));// CSItemValueSet.cs:67
		public static TCoding Code_PartiallyRemoved = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "PartiallyRemoved"));// CSItemValueSet.cs:67
		public static TCoding Code_RepresentsChange = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "RepresentsChange"));// CSItemValueSet.cs:67
		public static TCoding Code_Stable = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservedChangesCS", "Stable"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_DecreaseInCalcifications;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_DecreaseInNumber;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_DecreaseInSize;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_IncreaseInCalcifications;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_IncreaseInNumber;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_IncreaseInSize;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_LessProminent;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_MoreProminent;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_New;                                                                                                                // CSItemValueSet.cs:70
		    yield return Code_NoLongerSeen;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_NotSignificantChanged;                                                                                              // CSItemValueSet.cs:70
		    yield return Code_PartiallyRemoved;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_RepresentsChange;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_Stable;                                                                                                             // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
