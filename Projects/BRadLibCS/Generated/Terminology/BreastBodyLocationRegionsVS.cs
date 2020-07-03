using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
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

		public static TCoding Code_Axilla = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "Axilla"));// CSItemValueSet.cs:67
		public static TCoding Code_AxillaryTail = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaryTail"));// CSItemValueSet.cs:67
		public static TCoding Code_AxillaI = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaI"));// CSItemValueSet.cs:67
		public static TCoding Code_AxillaII = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaII"));// CSItemValueSet.cs:67
		public static TCoding Code_AxillaIII = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaIII"));// CSItemValueSet.cs:67
		public static TCoding Code_InframammaryFold = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "InframammaryFold"));// CSItemValueSet.cs:67
		public static TCoding Code_InSkin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "InSkin"));// CSItemValueSet.cs:67
		public static TCoding Code_CentralToNipple = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "CentralToNipple"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Axilla;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_AxillaryTail;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_AxillaI;                                                                                                            // CSItemValueSet.cs:70
		    yield return Code_AxillaII;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_AxillaIII;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_InframammaryFold;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_InSkin;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_CentralToNipple;                                                                                                    // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
