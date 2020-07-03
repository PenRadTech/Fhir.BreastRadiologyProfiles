using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CalcificationTypeVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/CalcificationTypeVS";

		public static TCoding Code_Amorphous = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Amorphous"));// CSItemValueSet.cs:67
		public static TCoding Code_Coarse = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Coarse"));// CSItemValueSet.cs:67
		public static TCoding Code_Dystrophic = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Dystrophic"));// CSItemValueSet.cs:67
		public static TCoding Code_Eggshell = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Eggshell"));// CSItemValueSet.cs:67
		public static TCoding Code_Fine = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Fine"));// CSItemValueSet.cs:67
		public static TCoding Code_Generic = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Generic"));// CSItemValueSet.cs:67
		public static TCoding Code_CoarseHeterogeneous = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "CoarseHeterogeneous"));// CSItemValueSet.cs:67
		public static TCoding Code_Indistinct = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Indistinct"));// CSItemValueSet.cs:67
		public static TCoding Code_LargeRodlike = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "LargeRodlike"));// CSItemValueSet.cs:67
		public static TCoding Code_Layering = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Layering"));// CSItemValueSet.cs:67
		public static TCoding Code_FineLinear = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "FineLinear"));// CSItemValueSet.cs:67
		public static TCoding Code_LucentCentered = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Lucent-centered"));// CSItemValueSet.cs:67
		public static TCoding Code_MilkOfCalcium = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "MilkOfCalcium"));// CSItemValueSet.cs:67
		public static TCoding Code_FinePleomorphic = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "FinePleomorphic"));// CSItemValueSet.cs:67
		public static TCoding Code_Punctate = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Punctate"));// CSItemValueSet.cs:67
		public static TCoding Code_Rim = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Rim"));// CSItemValueSet.cs:67
		public static TCoding Code_Round = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Round"));// CSItemValueSet.cs:67
		public static TCoding Code_Skin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Skin"));// CSItemValueSet.cs:67
		public static TCoding Code_Spherical = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Spherical"));// CSItemValueSet.cs:67
		public static TCoding Code_Suture = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Suture"));// CSItemValueSet.cs:67
		public static TCoding Code_Vascular = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS", "Vascular"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Amorphous;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_Coarse;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_Dystrophic;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_Eggshell;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_Fine;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_Generic;                                                                                                            // CSItemValueSet.cs:70
		    yield return Code_CoarseHeterogeneous;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_Indistinct;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_LargeRodlike;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_Layering;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_FineLinear;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_LucentCentered;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_FinePleomorphic;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_Punctate;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_Rim;                                                                                                                // CSItemValueSet.cs:70
		    yield return Code_Round;                                                                                                              // CSItemValueSet.cs:70
		    yield return Code_Skin;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_Spherical;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_Suture;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_Vascular;                                                                                                           // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
