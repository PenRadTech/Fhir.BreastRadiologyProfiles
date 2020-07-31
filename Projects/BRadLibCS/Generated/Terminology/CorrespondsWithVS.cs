using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
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

		public static TCoding Code_Aspiration = new TCoding(CorrespondsWithCS.Code_Aspiration);                                                   // CSItemValueSet.cs:72
		public static TCoding Code_Biopsy = new TCoding(CorrespondsWithCS.Code_Biopsy);                                                           // CSItemValueSet.cs:72
		public static TCoding Code_Cprofilern = new TCoding(CorrespondsWithCS.Code_Cprofilern);                                                   // CSItemValueSet.cs:72
		public static TCoding Code_Ductogram = new TCoding(CorrespondsWithCS.Code_Ductogram);                                                     // CSItemValueSet.cs:72
		public static TCoding Code_IncidentalFinding = new TCoding(CorrespondsWithCS.Code_IncidentalFinding);                                     // CSItemValueSet.cs:72
		public static TCoding Code_Mammo = new TCoding(CorrespondsWithCS.Code_Mammo);                                                             // CSItemValueSet.cs:72
		public static TCoding Code_MRI = new TCoding(CorrespondsWithCS.Code_MRI);                                                                 // CSItemValueSet.cs:72
		public static TCoding Code_NippleDischarge = new TCoding(CorrespondsWithCS.Code_NippleDischarge);                                         // CSItemValueSet.cs:72
		public static TCoding Code_OutsideExam = new TCoding(CorrespondsWithCS.Code_OutsideExam);                                                 // CSItemValueSet.cs:72
		public static TCoding Code_Pain = new TCoding(CorrespondsWithCS.Code_Pain);                                                               // CSItemValueSet.cs:72
		public static TCoding Code_Palpated = new TCoding(CorrespondsWithCS.Code_Palpated);                                                       // CSItemValueSet.cs:72
		public static TCoding Code_PostOperative = new TCoding(CorrespondsWithCS.Code_PostOperative);                                             // CSItemValueSet.cs:72
		public static TCoding Code_PreviousBiopsy = new TCoding(CorrespondsWithCS.Code_PreviousBiopsy);                                           // CSItemValueSet.cs:72
		public static TCoding Code_PriorExam = new TCoding(CorrespondsWithCS.Code_PriorExam);                                                     // CSItemValueSet.cs:72
		public static TCoding Code_Redness = new TCoding(CorrespondsWithCS.Code_Redness);                                                         // CSItemValueSet.cs:72
		public static TCoding Code_Scinti = new TCoding(CorrespondsWithCS.Code_Scinti);                                                           // CSItemValueSet.cs:72
		public static TCoding Code_SizeLessThanMammo = new TCoding(CorrespondsWithCS.Code_SizeLessThanMammo);                                     // CSItemValueSet.cs:72
		public static TCoding Code_SizeLessThanMRI = new TCoding(CorrespondsWithCS.Code_SizeLessThanMRI);                                         // CSItemValueSet.cs:72
		public static TCoding Code_SizeLessThanPalp = new TCoding(CorrespondsWithCS.Code_SizeLessThanPalp);                                       // CSItemValueSet.cs:72
		public static TCoding Code_SizeLessThanUS = new TCoding(CorrespondsWithCS.Code_SizeLessThanUS);                                           // CSItemValueSet.cs:72
		public static TCoding Code_SizeGreaterThanMammo = new TCoding(CorrespondsWithCS.Code_SizeGreaterThanMammo);                               // CSItemValueSet.cs:72
		public static TCoding Code_SizeGreaterThanMRI = new TCoding(CorrespondsWithCS.Code_SizeGreaterThanMRI);                                   // CSItemValueSet.cs:72
		public static TCoding Code_SizeGreaterThanPalp = new TCoding(CorrespondsWithCS.Code_SizeGreaterThanPalp);                                 // CSItemValueSet.cs:72
		public static TCoding Code_SkinMarker = new TCoding(CorrespondsWithCS.Code_SkinMarker);                                                   // CSItemValueSet.cs:72
		public static TCoding Code_Surgery = new TCoding(CorrespondsWithCS.Code_Surgery);                                                         // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalSite = new TCoding(CorrespondsWithCS.Code_SurgicalSite);                                               // CSItemValueSet.cs:72
		public static TCoding Code_Tenderness = new TCoding(CorrespondsWithCS.Code_Tenderness);                                                   // CSItemValueSet.cs:72
		public static TCoding Code_TriggerPoint = new TCoding(CorrespondsWithCS.Code_TriggerPoint);                                               // CSItemValueSet.cs:72
		public static TCoding Code_US = new TCoding(CorrespondsWithCS.Code_US);                                                                   // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_Aspiration;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_Biopsy;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_Cprofilern;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_Ductogram;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_IncidentalFinding;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_Mammo;                                                                                                              // CSItemValueSet.cs:83
		    yield return Code_MRI;                                                                                                                // CSItemValueSet.cs:83
		    yield return Code_NippleDischarge;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_OutsideExam;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Pain;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_Palpated;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_PostOperative;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_PreviousBiopsy;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_PriorExam;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_Redness;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_Scinti;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_SizeLessThanMammo;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_SizeLessThanMRI;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_SizeLessThanPalp;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_SizeLessThanUS;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_SizeGreaterThanMammo;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_SizeGreaterThanMRI;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_SizeGreaterThanPalp;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_SkinMarker;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_Surgery;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_SurgicalSite;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Tenderness;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_TriggerPoint;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_US;                                                                                                                 // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
