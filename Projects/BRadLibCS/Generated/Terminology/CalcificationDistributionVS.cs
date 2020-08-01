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
	public class CalcificationDistributionVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/CalcificationDistributionVS";

		public static TCoding Code_ClusteredDistribution = new TCoding(CalcificationDistributionCS.Code_ClusteredDistribution);                   // CSItemValueSet.cs:72
		public static TCoding Code_DiffuseDistribution = new TCoding(CalcificationDistributionCS.Code_DiffuseDistribution);                       // CSItemValueSet.cs:72
		public static TCoding Code_GroupedDistribution = new TCoding(CalcificationDistributionCS.Code_GroupedDistribution);                       // CSItemValueSet.cs:72
		public static TCoding Code_LinearDistribution = new TCoding(CalcificationDistributionCS.Code_LinearDistribution);                         // CSItemValueSet.cs:72
		public static TCoding Code_RegionalDistribution = new TCoding(CalcificationDistributionCS.Code_RegionalDistribution);                     // CSItemValueSet.cs:72
		public static TCoding Code_ScatteredDistribution = new TCoding(CalcificationDistributionCS.Code_ScatteredDistribution);                   // CSItemValueSet.cs:72
		public static TCoding Code_SegmentalDistribution = new TCoding(CalcificationDistributionCS.Code_SegmentalDistribution);                   // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_ClusteredDistribution;                                                                                              // CSItemValueSet.cs:83
		    yield return Code_DiffuseDistribution;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_GroupedDistribution;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_LinearDistribution;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_RegionalDistribution;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_ScatteredDistribution;                                                                                              // CSItemValueSet.cs:83
		    yield return Code_SegmentalDistribution;                                                                                              // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
