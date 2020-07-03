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

		public static TCoding Code_Axilla = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "Axilla"));// CSItemValueSet.cs:66
		public static TCoding Code_AxillaryTail = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaryTail"));// CSItemValueSet.cs:66
		public static TCoding Code_AxillaI = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaI"));// CSItemValueSet.cs:66
		public static TCoding Code_AxillaII = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaII"));// CSItemValueSet.cs:66
		public static TCoding Code_AxillaIII = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "AxillaIII"));// CSItemValueSet.cs:66
		public static TCoding Code_InframammaryFold = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "InframammaryFold"));// CSItemValueSet.cs:66
		public static TCoding Code_InSkin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "InSkin"));// CSItemValueSet.cs:66
		public static TCoding Code_CentralToNipple = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS", "CentralToNipple"));// CSItemValueSet.cs:66

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_Axilla;                                                                                                             // CSItemValueSet.cs:69
		    yield return Code_AxillaryTail;                                                                                                       // CSItemValueSet.cs:69
		    yield return Code_AxillaI;                                                                                                            // CSItemValueSet.cs:69
		    yield return Code_AxillaII;                                                                                                           // CSItemValueSet.cs:69
		    yield return Code_AxillaIII;                                                                                                          // CSItemValueSet.cs:69
		    yield return Code_InframammaryFold;                                                                                                   // CSItemValueSet.cs:69
		    yield return Code_InSkin;                                                                                                             // CSItemValueSet.cs:69
		    yield return Code_CentralToNipple;                                                                                                    // CSItemValueSet.cs:69
		}                                                                                                                                         // CSItemValueSet.cs:92
	}
}
