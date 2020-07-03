using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class CorrespondsWithVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/CorrespondsWithVS";

		public static TCoding Code_Aspiration = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Aspiration"));// CSItemValueSet.cs:67
		public static TCoding Code_Biopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Biopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_Concern = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Concern"));// CSItemValueSet.cs:67
		public static TCoding Code_Ductogram = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Ductogram"));// CSItemValueSet.cs:67
		public static TCoding Code_IncidentalFinding = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "IncidentalFinding"));// CSItemValueSet.cs:67
		public static TCoding Code_Mammo = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Mammo"));// CSItemValueSet.cs:67
		public static TCoding Code_MRI = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "MRI"));  // CSItemValueSet.cs:67
		public static TCoding Code_NippleDischarge = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "NippleDischarge"));// CSItemValueSet.cs:67
		public static TCoding Code_OutsideExam = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "OutsideExam"));// CSItemValueSet.cs:67
		public static TCoding Code_Pain = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Pain"));// CSItemValueSet.cs:67
		public static TCoding Code_Palpated = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Palpated"));// CSItemValueSet.cs:67
		public static TCoding Code_PostOperative = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "PostOperative"));// CSItemValueSet.cs:67
		public static TCoding Code_PreviousBiopsy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "PreviousBiopsy"));// CSItemValueSet.cs:67
		public static TCoding Code_PriorExam = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "PriorExam"));// CSItemValueSet.cs:67
		public static TCoding Code_Redness = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Redness"));// CSItemValueSet.cs:67
		public static TCoding Code_Scinti = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Scinti"));// CSItemValueSet.cs:67
		public static TCoding Code_SizeLessThanMammo = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Size<Mammo"));// CSItemValueSet.cs:67
		public static TCoding Code_SizeLessThanMRI = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Size<MRI"));// CSItemValueSet.cs:67
		public static TCoding Code_SizeLessThanPalp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Size<Palp"));// CSItemValueSet.cs:67
		public static TCoding Code_SizeLessThanUS = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Size<US"));// CSItemValueSet.cs:67
		public static TCoding Code_SizeGreaterThanMammo = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Size>Mammo"));// CSItemValueSet.cs:67
		public static TCoding Code_SizeGreaterThanMRI = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Size>MRI"));// CSItemValueSet.cs:67
		public static TCoding Code_SizeGreaterThanPalp = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Size>Palp"));// CSItemValueSet.cs:67
		public static TCoding Code_SkinMarker = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "SkinMarker"));// CSItemValueSet.cs:67
		public static TCoding Code_Surgery = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Surgery"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalSite = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "SurgicalSite"));// CSItemValueSet.cs:67
		public static TCoding Code_Tenderness = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "Tenderness"));// CSItemValueSet.cs:67
		public static TCoding Code_TriggerPoint = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "TriggerPoint"));// CSItemValueSet.cs:67
		public static TCoding Code_US = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCS", "US"));    // CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Aspiration;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_Biopsy;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_Concern;                                                                                                            // CSItemValueSet.cs:70
		    yield return Code_Ductogram;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_IncidentalFinding;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_Mammo;                                                                                                              // CSItemValueSet.cs:70
		    yield return Code_MRI;                                                                                                                // CSItemValueSet.cs:70
		    yield return Code_NippleDischarge;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_OutsideExam;                                                                                                        // CSItemValueSet.cs:70
		    yield return Code_Pain;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_Palpated;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_PostOperative;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_PreviousBiopsy;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_PriorExam;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_Redness;                                                                                                            // CSItemValueSet.cs:70
		    yield return Code_Scinti;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_SizeLessThanMammo;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_SizeLessThanMRI;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_SizeLessThanPalp;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_SizeLessThanUS;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_SizeGreaterThanMammo;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_SizeGreaterThanMRI;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_SizeGreaterThanPalp;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_SkinMarker;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_Surgery;                                                                                                            // CSItemValueSet.cs:70
		    yield return Code_SurgicalSite;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_Tenderness;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_TriggerPoint;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_US;                                                                                                                 // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
