using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class PreviouslyDemonstratedByVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/PreviouslyDemonstratedByVS";

		public static TCoding Code_Aspiration = new TCoding(PreviouslyDemonstratedByCS.Code_Aspiration);                                          // CSItemValueSet.cs:73
		public static TCoding Code_Biopsy = new TCoding(PreviouslyDemonstratedByCS.Code_Biopsy);                                                  // CSItemValueSet.cs:73
		public static TCoding Code_MRI = new TCoding(PreviouslyDemonstratedByCS.Code_MRI);                                                        // CSItemValueSet.cs:73
		public static TCoding Code_US = new TCoding(PreviouslyDemonstratedByCS.Code_US);                                                          // CSItemValueSet.cs:73

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Aspiration;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_Biopsy;                                                                                                             // CSItemValueSet.cs:84
		    yield return Code_MRI;                                                                                                                // CSItemValueSet.cs:84
		    yield return Code_US;                                                                                                                 // CSItemValueSet.cs:84
		}                                                                                                                                         // CSItemValueSet.cs:105
	}
}
