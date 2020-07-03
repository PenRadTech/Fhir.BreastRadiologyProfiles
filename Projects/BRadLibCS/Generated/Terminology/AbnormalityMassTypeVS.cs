using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityMassTypeVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/AbnormalityMassTypeVS";

		public static TCoding Code_Mass = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityMassTypeCS", "Mass"));// CSItemValueSet.cs:67
		public static TCoding Code_MassIntraductal = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityMassTypeCS", "MassIntraductal"));// CSItemValueSet.cs:67
		public static TCoding Code_MassPartiallySolid = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityMassTypeCS", "MassPartiallySolid"));// CSItemValueSet.cs:67
		public static TCoding Code_MassSkinATLASIsSkinLesion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityMassTypeCS", "MassSkinATLASIsSkinLesion"));// CSItemValueSet.cs:67
		public static TCoding Code_MassSolid = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityMassTypeCS", "MassSolid"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Mass;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_MassIntraductal;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_MassPartiallySolid;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_MassSkinATLASIsSkinLesion;                                                                                          // CSItemValueSet.cs:70
		    yield return Code_MassSolid;                                                                                                          // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
