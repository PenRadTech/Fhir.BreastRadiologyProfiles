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
	public class NotPreviouslySeenVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/NotPreviouslySeenVS";

		public static TCoding Code_ClinicalExam = new TCoding(NotPreviouslySeenCS.Code_ClinicalExam);                                             // CSItemValueSet.cs:72
		public static TCoding Code_Ductogram = new TCoding(NotPreviouslySeenCS.Code_Ductogram);                                                   // CSItemValueSet.cs:72
		public static TCoding Code_Mammogram = new TCoding(NotPreviouslySeenCS.Code_Mammogram);                                                   // CSItemValueSet.cs:72
		public static TCoding Code_MRI = new TCoding(NotPreviouslySeenCS.Code_MRI);                                                               // CSItemValueSet.cs:72
		public static TCoding Code_OutsideExam = new TCoding(NotPreviouslySeenCS.Code_OutsideExam);                                               // CSItemValueSet.cs:72
		public static TCoding Code_Scintimammography = new TCoding(NotPreviouslySeenCS.Code_Scintimammography);                                   // CSItemValueSet.cs:72
		public static TCoding Code_Ultrasound = new TCoding(NotPreviouslySeenCS.Code_Ultrasound);                                                 // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_ClinicalExam;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Ductogram;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_Mammogram;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_MRI;                                                                                                                // CSItemValueSet.cs:83
		    yield return Code_OutsideExam;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Scintimammography;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_Ultrasound;                                                                                                         // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
