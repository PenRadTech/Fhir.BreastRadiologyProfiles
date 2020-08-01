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
	public class CalcificationTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationTypeCS";

		public static Coding Code_Amorphous = new Coding(System, "Amorphous", "Amorphous");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_Coarse = new Coding(System, "Coarse", "Coarse");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_Dystrophic = new Coding(System, "Dystrophic", "Dystrophic");                                                    // CSItemCodeSystem.cs:55
		public static Coding Code_Eggshell = new Coding(System, "Eggshell", "Eggshell");                                                          // CSItemCodeSystem.cs:55
		public static Coding Code_Fine = new Coding(System, "Fine", "Fine");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_Generic = new Coding(System, "Generic", "Generic");                                                             // CSItemCodeSystem.cs:55
		public static Coding Code_CoarseHeterogeneous = new Coding(System, "CoarseHeterogeneous", "Coarse Heterogeneous");                        // CSItemCodeSystem.cs:55
		public static Coding Code_Indistinct = new Coding(System, "Indistinct", "Indistinct");                                                    // CSItemCodeSystem.cs:55
		public static Coding Code_LargeRodlike = new Coding(System, "LargeRodlike", "Large rodlike");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_Layering = new Coding(System, "Layering", "Layering");                                                          // CSItemCodeSystem.cs:55
		public static Coding Code_FineLinear = new Coding(System, "FineLinear", "Fine Linear");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_LucentCentered = new Coding(System, "Lucent-centered", "Lucent-centered");                                      // CSItemCodeSystem.cs:55
		public static Coding Code_MilkOfCalcium = new Coding(System, "MilkOfCalcium", "Milk of calcium");                                         // CSItemCodeSystem.cs:55
		public static Coding Code_FinePleomorphic = new Coding(System, "FinePleomorphic", "Fine Pleomorphic");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_Punctate = new Coding(System, "Punctate", "Punctate");                                                          // CSItemCodeSystem.cs:55
		public static Coding Code_Rim = new Coding(System, "Rim", "Rim");                                                                         // CSItemCodeSystem.cs:55
		public static Coding Code_Round = new Coding(System, "Round", "Round");                                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_Skin = new Coding(System, "Skin", "Skin");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_Spherical = new Coding(System, "Spherical", "Spherical");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_Suture = new Coding(System, "Suture", "Suture");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_Vascular = new Coding(System, "Vascular", "Vascular");                                                          // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_Amorphous;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_Coarse;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_Dystrophic;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_Eggshell;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_Fine;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_Generic;                                                                                                            // CSItemCodeSystem.cs:58
		    yield return Code_CoarseHeterogeneous;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_Indistinct;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_LargeRodlike;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_Layering;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_FineLinear;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_LucentCentered;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemCodeSystem.cs:58
		    yield return Code_FinePleomorphic;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_Punctate;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_Rim;                                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_Round;                                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_Skin;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_Spherical;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_Suture;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_Vascular;                                                                                                           // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
