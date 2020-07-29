using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class LateralityVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/LateralityVS";

		public static TCoding Code_51440002 = new TCoding(new Coding("http://snomed.info/sct", "51440002"));                                      // CSItemValueSet.cs:79
		public static TCoding Code_399488007 = new TCoding(new Coding("http://snomed.info/sct", "399488007"));                                    // CSItemValueSet.cs:79
		public static TCoding Code_85421007 = new TCoding(new Coding("http://snomed.info/sct", "85421007"));                                      // CSItemValueSet.cs:79
		public static TCoding Code_31156008 = new TCoding(new Coding("http://snomed.info/sct", "31156008"));                                      // CSItemValueSet.cs:79

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_51440002;                                                                                                           // CSItemValueSet.cs:84
		    yield return Code_399488007;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_85421007;                                                                                                           // CSItemValueSet.cs:84
		    yield return Code_31156008;                                                                                                           // CSItemValueSet.cs:84
		}                                                                                                                                         // CSItemValueSet.cs:105
	}
}
