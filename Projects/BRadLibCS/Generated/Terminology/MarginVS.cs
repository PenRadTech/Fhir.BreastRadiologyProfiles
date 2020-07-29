using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
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

		/// <summary>
		/// Url of this value set.
		/// </summary>
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/MarginVS";

		public static TCoding Code_AngularMargin = new TCoding(MarginCS.Code_AngularMargin);                                                      // CSItemValueSet.cs:73
		public static TCoding Code_CircumscribedMargin = new TCoding(MarginCS.Code_CircumscribedMargin);                                          // CSItemValueSet.cs:73
		public static TCoding Code_IndistinctMargin = new TCoding(MarginCS.Code_IndistinctMargin);                                                // CSItemValueSet.cs:73
		public static TCoding Code_IntraductalExtension = new TCoding(MarginCS.Code_IntraductalExtension);                                        // CSItemValueSet.cs:73
		public static TCoding Code_IrregularMargin = new TCoding(MarginCS.Code_IrregularMargin);                                                  // CSItemValueSet.cs:73
		public static TCoding Code_LobulatedMargin = new TCoding(MarginCS.Code_LobulatedMargin);                                                  // CSItemValueSet.cs:73
		public static TCoding Code_MacrolobulatedMargin = new TCoding(MarginCS.Code_MacrolobulatedMargin);                                        // CSItemValueSet.cs:73
		public static TCoding Code_MicrolobulatedMargin = new TCoding(MarginCS.Code_MicrolobulatedMargin);                                        // CSItemValueSet.cs:73
		public static TCoding Code_NonCircumscribedMargin = new TCoding(MarginCS.Code_NonCircumscribedMargin);                                    // CSItemValueSet.cs:73
		public static TCoding Code_ObscuredMagin = new TCoding(MarginCS.Code_ObscuredMagin);                                                      // CSItemValueSet.cs:73
		public static TCoding Code_SmoothMargin = new TCoding(MarginCS.Code_SmoothMargin);                                                        // CSItemValueSet.cs:73
		public static TCoding Code_SpiculatedMargin = new TCoding(MarginCS.Code_SpiculatedMargin);                                                // CSItemValueSet.cs:73

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_AngularMargin;                                                                                                      // CSItemValueSet.cs:84
		    yield return Code_CircumscribedMargin;                                                                                                // CSItemValueSet.cs:84
		    yield return Code_IndistinctMargin;                                                                                                   // CSItemValueSet.cs:84
		    yield return Code_IntraductalExtension;                                                                                               // CSItemValueSet.cs:84
		    yield return Code_IrregularMargin;                                                                                                    // CSItemValueSet.cs:84
		    yield return Code_LobulatedMargin;                                                                                                    // CSItemValueSet.cs:84
		    yield return Code_MacrolobulatedMargin;                                                                                               // CSItemValueSet.cs:84
		    yield return Code_MicrolobulatedMargin;                                                                                               // CSItemValueSet.cs:84
		    yield return Code_NonCircumscribedMargin;                                                                                             // CSItemValueSet.cs:84
		    yield return Code_ObscuredMagin;                                                                                                      // CSItemValueSet.cs:84
		    yield return Code_SmoothMargin;                                                                                                       // CSItemValueSet.cs:84
		    yield return Code_SpiculatedMargin;                                                                                                   // CSItemValueSet.cs:84
		}                                                                                                                                         // CSItemValueSet.cs:105
	}
}
