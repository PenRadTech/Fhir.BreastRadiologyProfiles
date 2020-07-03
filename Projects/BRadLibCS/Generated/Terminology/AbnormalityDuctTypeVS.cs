using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityDuctTypeVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/AbnormalityDuctTypeVS";

		public static TCoding Code_DuctNormal = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDuctTypeCS", "DuctNormal"));// CSItemValueSet.cs:67
		public static TCoding Code_SolitaryDilatedDuct = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDuctTypeCS", "SolitaryDilatedDuct"));// CSItemValueSet.cs:67
		public static TCoding Code_DuctEctasia = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityDuctTypeCS", "DuctEctasia"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_DuctNormal;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_SolitaryDilatedDuct;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_DuctEctasia;                                                                                                        // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
