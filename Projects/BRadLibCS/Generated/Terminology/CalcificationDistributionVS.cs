using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
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

		public static TCoding Code_ClusteredDistribution = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS", "ClusteredDistribution"));// CSItemValueSet.cs:67
		public static TCoding Code_DiffuseDistribution = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS", "DiffuseDistribution"));// CSItemValueSet.cs:67
		public static TCoding Code_GroupedDistribution = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS", "GroupedDistribution"));// CSItemValueSet.cs:67
		public static TCoding Code_LinearDistribution = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS", "LinearDistribution"));// CSItemValueSet.cs:67
		public static TCoding Code_RegionalDistribution = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS", "RegionalDistribution"));// CSItemValueSet.cs:67
		public static TCoding Code_ScatteredDistribution = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS", "ScatteredDistribution"));// CSItemValueSet.cs:67
		public static TCoding Code_SegmentalDistribution = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/CalcificationDistributionCS", "SegmentalDistribution"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_ClusteredDistribution;                                                                                              // CSItemValueSet.cs:70
		    yield return Code_DiffuseDistribution;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_GroupedDistribution;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_LinearDistribution;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_RegionalDistribution;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_ScatteredDistribution;                                                                                              // CSItemValueSet.cs:70
		    yield return Code_SegmentalDistribution;                                                                                              // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
