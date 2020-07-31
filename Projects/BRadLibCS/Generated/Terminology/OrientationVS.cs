using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class OrientationVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/OrientationVS";

		public static TCoding Code_ParallelToSkin = new TCoding(OrientationCS.Code_ParallelToSkin);                                               // CSItemValueSet.cs:72
		public static TCoding Code_PerpendicularToSkin = new TCoding(OrientationCS.Code_PerpendicularToSkin);                                     // CSItemValueSet.cs:72
		public static TCoding Code_TallerThanWide = new TCoding(OrientationCS.Code_TallerThanWide);                                               // CSItemValueSet.cs:72
		public static TCoding Code_WiderThanTall = new TCoding(OrientationCS.Code_WiderThanTall);                                                 // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_ParallelToSkin;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_PerpendicularToSkin;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_TallerThanWide;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_WiderThanTall;                                                                                                      // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
