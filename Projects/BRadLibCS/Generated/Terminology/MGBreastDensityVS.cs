using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGBreastDensityVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/MGBreastDensityVS";

		public static TCoding Code_AlmostEntirelyFat = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGBreastDensityCS", "AlmostEntirelyFat"));// CSItemValueSet.cs:67
		public static TCoding Code_ScatteredAreasOfFibroglandularDensity = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGBreastDensityCS", "ScatteredAreasOfFibroglandularDensity"));// CSItemValueSet.cs:67
		public static TCoding Code_HeterogeneouslyDense = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGBreastDensityCS", "HeterogeneouslyDense"));// CSItemValueSet.cs:67
		public static TCoding Code_ExtremelyDense = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGBreastDensityCS", "ExtremelyDense"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_AlmostEntirelyFat;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_ScatteredAreasOfFibroglandularDensity;                                                                              // CSItemValueSet.cs:70
		    yield return Code_HeterogeneouslyDense;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_ExtremelyDense;                                                                                                     // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
