using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ConsistentWithQualifierVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/ConsistentWithQualifierVS";

		public static TCoding Code_DifferentialDiagnosis = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithQualifierCS", "DifferentialDiagnosis"));// CSItemValueSet.cs:79
		public static TCoding Code_LikelyRepresents = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithQualifierCS", "LikelyRepresents"));// CSItemValueSet.cs:79
		public static TCoding Code_MostLikely = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithQualifierCS", "MostLikely"));// CSItemValueSet.cs:79
		public static TCoding Code_Resembles = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithQualifierCS", "Resembles"));// CSItemValueSet.cs:79

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_DifferentialDiagnosis;                                                                                              // CSItemValueSet.cs:84
		    yield return Code_LikelyRepresents;                                                                                                   // CSItemValueSet.cs:84
		    yield return Code_MostLikely;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_Resembles;                                                                                                          // CSItemValueSet.cs:84
		}                                                                                                                                         // CSItemValueSet.cs:105
	}
}
