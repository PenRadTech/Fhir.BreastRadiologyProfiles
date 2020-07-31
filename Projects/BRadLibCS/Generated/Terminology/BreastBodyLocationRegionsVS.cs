using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class BreastBodyLocationRegionsVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/BreastBodyLocationRegionsVS";

		public static TCoding Code_Axilla = new TCoding(BreastBodyLocationRegionsCS.Code_Axilla);                                                 // CSItemValueSet.cs:72
		public static TCoding Code_AxillaryTail = new TCoding(BreastBodyLocationRegionsCS.Code_AxillaryTail);                                     // CSItemValueSet.cs:72
		public static TCoding Code_AxillaI = new TCoding(BreastBodyLocationRegionsCS.Code_AxillaI);                                               // CSItemValueSet.cs:72
		public static TCoding Code_AxillaII = new TCoding(BreastBodyLocationRegionsCS.Code_AxillaII);                                             // CSItemValueSet.cs:72
		public static TCoding Code_AxillaIII = new TCoding(BreastBodyLocationRegionsCS.Code_AxillaIII);                                           // CSItemValueSet.cs:72
		public static TCoding Code_InframammaryFold = new TCoding(BreastBodyLocationRegionsCS.Code_InframammaryFold);                             // CSItemValueSet.cs:72
		public static TCoding Code_InSkin = new TCoding(BreastBodyLocationRegionsCS.Code_InSkin);                                                 // CSItemValueSet.cs:72
		public static TCoding Code_CentralToNipple = new TCoding(BreastBodyLocationRegionsCS.Code_CentralToNipple);                               // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_Axilla;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_AxillaryTail;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_AxillaI;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_AxillaII;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_AxillaIII;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_InframammaryFold;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_InSkin;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_CentralToNipple;                                                                                                    // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
