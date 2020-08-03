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
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IObservedDistributionFragment.
	/// </summary>
	public interface IObservedDistributionFragment 
	{
		ObservationComponentItem<CodeableConcept> ObsDistribution { get; set; }                                                                   // CSComponentSlice.cs:96
		ObservationComponentItem<Quantity,Range> ObsDistRegionSize { get; set; }                                                                  // CSComponentSlice.cs:96
	}


	/// <summary>
	/// Interface IObservedDistributionFragment.
	/// </summary>
	public static class ObservedDistributionFragmentExtensions
	{

		public static void Init(this IObservedDistributionFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		{                                                                                                                                         // CSComponentSlice.cs:127
		     CodeableConcept ObservationCode()                                                                                                    // FhirConstruct.cs:760
		    {                                                                                                                                     // FhirConstruct.cs:761
		        CodeableConcept retVal = new CodeableConcept();                                                                                   // FhirConstruct.cs:762
		        retVal.Coding = new List<Coding>();                                                                                               // FhirConstruct.cs:768
		        {                                                                                                                                 // FhirConstruct.cs:771
		            var temp4 = new Coding();                                                                                                     // FhirConstruct.cs:772
		            temp4.SystemElement = new FhirUri();                                                                                          // FhirConstruct.cs:775
		            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodesCS";            // FhirConstruct.cs:777
		            temp4.CodeElement = new Code();                                                                                               // FhirConstruct.cs:791
		            temp4.CodeElement.Value = "obsDistribution";                                                                                  // FhirConstruct.cs:793
		            retVal.Coding.Add(temp4);                                                                                                     // FhirConstruct.cs:820
		        }                                                                                                                                 // FhirConstruct.cs:821
		        return retVal;                                                                                                                    // FhirConstruct.cs:836
		    }                                                                                                                                     // FhirConstruct.cs:837
		    fragment.ObsDistribution = new ObservationComponentItem<CodeableConcept>(ObservationCode());                                          // CSComponentSlice.cs:136
		}                                                                                                                                         // CSComponentSlice.cs:144
		{                                                                                                                                         // CSComponentSlice.cs:127
		     CodeableConcept ObservationCode()                                                                                                    // FhirConstruct.cs:760
		    {                                                                                                                                     // FhirConstruct.cs:761
		        CodeableConcept retVal = new CodeableConcept();                                                                                   // FhirConstruct.cs:762
		        retVal.Coding = new List<Coding>();                                                                                               // FhirConstruct.cs:768
		        {                                                                                                                                 // FhirConstruct.cs:771
		            var temp4 = new Coding();                                                                                                     // FhirConstruct.cs:772
		            temp4.SystemElement = new FhirUri();                                                                                          // FhirConstruct.cs:775
		            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodesCS";            // FhirConstruct.cs:777
		            temp4.CodeElement = new Code();                                                                                               // FhirConstruct.cs:791
		            temp4.CodeElement.Value = "obsDistRegionSize";                                                                                // FhirConstruct.cs:793
		            retVal.Coding.Add(temp4);                                                                                                     // FhirConstruct.cs:820
		        }                                                                                                                                 // FhirConstruct.cs:821
		        return retVal;                                                                                                                    // FhirConstruct.cs:836
		    }                                                                                                                                     // FhirConstruct.cs:837
		    fragment.ObsDistRegionSize = new ObservationComponentItem<Quantity,Range>(ObservationCode());                                         // CSComponentSlice.cs:136
		}                                                                                                                                         // CSComponentSlice.cs:144
		}

		public static void Read(this IObservedDistributionFragment fragment)
		{
		}

		public static void Write(this IObservedDistributionFragment fragment)
		{
		}

		public static void Validate(this IObservedDistributionFragment fragment)
		{
		}
	}
}

