using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastBodyLocationClockPositionsVS
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

		public static TCoding Code_1OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "1O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_2OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "2O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_3OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "3O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_4OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "4O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_5OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "5O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_6OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "6O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_7OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "7O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_8OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "8O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_9OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "9O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_10OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "10O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_11OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "11O'clock"));// CSItemValueSet.cs:66
		public static TCoding Code_12OClock = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationClockPositionsCS", "12O'clock"));// CSItemValueSet.cs:66

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_1OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_2OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_3OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_4OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_5OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_6OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_7OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_8OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_9OClock;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_10OClock;                                                                                                           // CSItemValueSet.cs:69
		    yield return Code_11OClock;                                                                                                           // CSItemValueSet.cs:69
		    yield return Code_12OClock;                                                                                                           // CSItemValueSet.cs:69
		}                                                                                                                                         // CSItemValueSet.cs:92
	}
}
