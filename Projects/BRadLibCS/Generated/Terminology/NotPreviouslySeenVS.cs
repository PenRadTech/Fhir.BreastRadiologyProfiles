using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
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

		public static TCoding Code_ClinicalExam = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS", "ClinicalExam"));// CSItemValueSet.cs:66
		public static TCoding Code_Ductogram = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS", "Ductogram"));// CSItemValueSet.cs:66
		public static TCoding Code_Mammogram = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS", "Mammogram"));// CSItemValueSet.cs:66
		public static TCoding Code_MRI = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS", "MRI"));// CSItemValueSet.cs:66
		public static TCoding Code_OutsideExam = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS", "OutsideExam"));// CSItemValueSet.cs:66
		public static TCoding Code_Scintimammography = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS", "Scintimammography"));// CSItemValueSet.cs:66
		public static TCoding Code_Ultrasound = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/NotPreviouslySeenCS", "Ultrasound"));// CSItemValueSet.cs:66

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_ClinicalExam;                                                                                                       // CSItemValueSet.cs:69
		    yield return Code_Ductogram;                                                                                                          // CSItemValueSet.cs:69
		    yield return Code_Mammogram;                                                                                                          // CSItemValueSet.cs:69
		    yield return Code_MRI;                                                                                                                // CSItemValueSet.cs:69
		    yield return Code_OutsideExam;                                                                                                        // CSItemValueSet.cs:69
		    yield return Code_Scintimammography;                                                                                                  // CSItemValueSet.cs:69
		    yield return Code_Ultrasound;                                                                                                         // CSItemValueSet.cs:69
		}                                                                                                                                         // CSItemValueSet.cs:92
	}
}
