using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastBodyLocationQuadrantsVS
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

		public static TCoding Code_InferiorMedialQuadrent = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationQuadrantsCS", "InferiorMedialQuadrent"));// CSItemValueSet.cs:66
		public static TCoding Code_InferiorLateralQuadrent = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationQuadrantsCS", "InferiorLateralQuadrent"));// CSItemValueSet.cs:66
		public static TCoding Code_SuperiorMedialQuadrent = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationQuadrantsCS", "SuperiorMedialQuadrent"));// CSItemValueSet.cs:66
		public static TCoding Code_SuperiorLateralQuadrent = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationQuadrantsCS", "SuperiorLateralQuadrent"));// CSItemValueSet.cs:66

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_InferiorMedialQuadrent;                                                                                             // CSItemValueSet.cs:69
		    yield return Code_InferiorLateralQuadrent;                                                                                            // CSItemValueSet.cs:69
		    yield return Code_SuperiorMedialQuadrent;                                                                                             // CSItemValueSet.cs:69
		    yield return Code_SuperiorLateralQuadrent;                                                                                            // CSItemValueSet.cs:69
		}                                                                                                                                         // CSItemValueSet.cs:92
	}
}
