using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
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

		public static TCoding Code_Amorphous = new TCoding(CalcificationTypeCS.Code_Amorphous);                                                   // CSItemValueSet.cs:73
		public static TCoding Code_Coarse = new TCoding(CalcificationTypeCS.Code_Coarse);                                                         // CSItemValueSet.cs:73
		public static TCoding Code_Dystrophic = new TCoding(CalcificationTypeCS.Code_Dystrophic);                                                 // CSItemValueSet.cs:73
		public static TCoding Code_Eggshell = new TCoding(CalcificationTypeCS.Code_Eggshell);                                                     // CSItemValueSet.cs:73
		public static TCoding Code_Fine = new TCoding(CalcificationTypeCS.Code_Fine);                                                             // CSItemValueSet.cs:73
		public static TCoding Code_Generic = new TCoding(CalcificationTypeCS.Code_Generic);                                                       // CSItemValueSet.cs:73
		public static TCoding Code_CoarseHeterogeneous = new TCoding(CalcificationTypeCS.Code_CoarseHeterogeneous);                               // CSItemValueSet.cs:73
		public static TCoding Code_Indistinct = new TCoding(CalcificationTypeCS.Code_Indistinct);                                                 // CSItemValueSet.cs:73
		public static TCoding Code_LargeRodlike = new TCoding(CalcificationTypeCS.Code_LargeRodlike);                                             // CSItemValueSet.cs:73
		public static TCoding Code_Layering = new TCoding(CalcificationTypeCS.Code_Layering);                                                     // CSItemValueSet.cs:73
		public static TCoding Code_FineLinear = new TCoding(CalcificationTypeCS.Code_FineLinear);                                                 // CSItemValueSet.cs:73
		public static TCoding Code_LucentCentered = new TCoding(CalcificationTypeCS.Code_LucentCentered);                                         // CSItemValueSet.cs:73
		public static TCoding Code_MilkOfCalcium = new TCoding(CalcificationTypeCS.Code_MilkOfCalcium);                                           // CSItemValueSet.cs:73
		public static TCoding Code_FinePleomorphic = new TCoding(CalcificationTypeCS.Code_FinePleomorphic);                                       // CSItemValueSet.cs:73
		public static TCoding Code_Punctate = new TCoding(CalcificationTypeCS.Code_Punctate);                                                     // CSItemValueSet.cs:73
		public static TCoding Code_Rim = new TCoding(CalcificationTypeCS.Code_Rim);                                                               // CSItemValueSet.cs:73
		public static TCoding Code_Round = new TCoding(CalcificationTypeCS.Code_Round);                                                           // CSItemValueSet.cs:73
		public static TCoding Code_Skin = new TCoding(CalcificationTypeCS.Code_Skin);                                                             // CSItemValueSet.cs:73
		public static TCoding Code_Spherical = new TCoding(CalcificationTypeCS.Code_Spherical);                                                   // CSItemValueSet.cs:73
		public static TCoding Code_Suture = new TCoding(CalcificationTypeCS.Code_Suture);                                                         // CSItemValueSet.cs:73
		public static TCoding Code_Vascular = new TCoding(CalcificationTypeCS.Code_Vascular);                                                     // CSItemValueSet.cs:73

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Amorphous;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_Coarse;                                                                                                             // CSItemValueSet.cs:84
		    yield return Code_Dystrophic;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_Eggshell;                                                                                                           // CSItemValueSet.cs:84
		    yield return Code_Fine;                                                                                                               // CSItemValueSet.cs:84
		    yield return Code_Generic;                                                                                                            // CSItemValueSet.cs:84
		    yield return Code_CoarseHeterogeneous;                                                                                                // CSItemValueSet.cs:84
		    yield return Code_Indistinct;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_LargeRodlike;                                                                                                       // CSItemValueSet.cs:84
		    yield return Code_Layering;                                                                                                           // CSItemValueSet.cs:84
		    yield return Code_FineLinear;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_LucentCentered;                                                                                                     // CSItemValueSet.cs:84
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemValueSet.cs:84
		    yield return Code_FinePleomorphic;                                                                                                    // CSItemValueSet.cs:84
		    yield return Code_Punctate;                                                                                                           // CSItemValueSet.cs:84
		    yield return Code_Rim;                                                                                                                // CSItemValueSet.cs:84
		    yield return Code_Round;                                                                                                              // CSItemValueSet.cs:84
		    yield return Code_Skin;                                                                                                               // CSItemValueSet.cs:84
		    yield return Code_Spherical;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_Suture;                                                                                                             // CSItemValueSet.cs:84
		    yield return Code_Vascular;                                                                                                           // CSItemValueSet.cs:84
		}                                                                                                                                         // CSItemValueSet.cs:105
	}
}
