using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BiRadsAssessmentCategoryVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/BiRadsAssessmentCategoryVS";

		public static TCoding Code_Category0 = new TCoding(BiRadsAssessmentCategoryCS.Code_Category0);                                            // CSItemValueSet.cs:73
		public static TCoding Code_Category2 = new TCoding(BiRadsAssessmentCategoryCS.Code_Category2);                                            // CSItemValueSet.cs:73
		public static TCoding Code_Category3 = new TCoding(BiRadsAssessmentCategoryCS.Code_Category3);                                            // CSItemValueSet.cs:73
		public static TCoding Code_Category4 = new TCoding(BiRadsAssessmentCategoryCS.Code_Category4);                                            // CSItemValueSet.cs:73
		public static TCoding Code_Category4A = new TCoding(BiRadsAssessmentCategoryCS.Code_Category4A);                                          // CSItemValueSet.cs:73
		public static TCoding Code_Category4B = new TCoding(BiRadsAssessmentCategoryCS.Code_Category4B);                                          // CSItemValueSet.cs:73
		public static TCoding Code_Category4C = new TCoding(BiRadsAssessmentCategoryCS.Code_Category4C);                                          // CSItemValueSet.cs:73
		public static TCoding Code_Category5 = new TCoding(BiRadsAssessmentCategoryCS.Code_Category5);                                            // CSItemValueSet.cs:73
		public static TCoding Code_Category6 = new TCoding(BiRadsAssessmentCategoryCS.Code_Category6);                                            // CSItemValueSet.cs:73

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_Category0;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_Category2;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_Category3;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_Category4;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_Category4A;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_Category4B;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_Category4C;                                                                                                         // CSItemValueSet.cs:84
		    yield return Code_Category5;                                                                                                          // CSItemValueSet.cs:84
		    yield return Code_Category6;                                                                                                          // CSItemValueSet.cs:84
		}                                                                                                                                         // CSItemValueSet.cs:105
	}
}
