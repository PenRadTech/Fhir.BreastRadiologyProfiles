using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityCystTypeVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/AbnormalityCystTypeVS";

		public static TCoding Code_Cyst = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "Cyst"));// CSItemValueSet.cs:67
		public static TCoding Code_CystComplex = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystComplex"));// CSItemValueSet.cs:67
		public static TCoding Code_CystComplicated = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystComplicated"));// CSItemValueSet.cs:67
		public static TCoding Code_CystMicro = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystMicro"));// CSItemValueSet.cs:67
		public static TCoding Code_CystOil = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystOil"));// CSItemValueSet.cs:67
		public static TCoding Code_CystSimple = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystSimple"));// CSItemValueSet.cs:67
		public static TCoding Code_CystWithDebris = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityCystTypeCS", "CystWithDebris"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Cyst;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_CystComplex;                                                                                                        // CSItemValueSet.cs:70
		    yield return Code_CystComplicated;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_CystMicro;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_CystOil;                                                                                                            // CSItemValueSet.cs:70
		    yield return Code_CystSimple;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_CystWithDebris;                                                                                                     // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
