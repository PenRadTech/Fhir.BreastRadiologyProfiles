using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MarginVS
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

		public static TCoding Code_AngularMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "AngularMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_CircumscribedMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "CircumscribedMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_IndistinctMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "IndistinctMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_IntraductalExtension = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "IntraductalExtension"));// CSItemValueSet.cs:66
		public static TCoding Code_IrregularMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "IrregularMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_LobulatedMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "LobulatedMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_MacrolobulatedMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "MacrolobulatedMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_MicrolobulatedMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "MicrolobulatedMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_NonCircumscribedMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "NonCircumscribedMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_ObscuredMagin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "ObscuredMagin"));// CSItemValueSet.cs:66
		public static TCoding Code_SmoothMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "SmoothMargin"));// CSItemValueSet.cs:66
		public static TCoding Code_SpiculatedMargin = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/MarginCS", "SpiculatedMargin"));// CSItemValueSet.cs:66

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_AngularMargin;                                                                                                      // CSItemValueSet.cs:69
		    yield return Code_CircumscribedMargin;                                                                                                // CSItemValueSet.cs:69
		    yield return Code_IndistinctMargin;                                                                                                   // CSItemValueSet.cs:69
		    yield return Code_IntraductalExtension;                                                                                               // CSItemValueSet.cs:69
		    yield return Code_IrregularMargin;                                                                                                    // CSItemValueSet.cs:69
		    yield return Code_LobulatedMargin;                                                                                                    // CSItemValueSet.cs:69
		    yield return Code_MacrolobulatedMargin;                                                                                               // CSItemValueSet.cs:69
		    yield return Code_MicrolobulatedMargin;                                                                                               // CSItemValueSet.cs:69
		    yield return Code_NonCircumscribedMargin;                                                                                             // CSItemValueSet.cs:69
		    yield return Code_ObscuredMagin;                                                                                                      // CSItemValueSet.cs:69
		    yield return Code_SmoothMargin;                                                                                                       // CSItemValueSet.cs:69
		    yield return Code_SpiculatedMargin;                                                                                                   // CSItemValueSet.cs:69
		}                                                                                                                                         // CSItemValueSet.cs:92
	}
}
