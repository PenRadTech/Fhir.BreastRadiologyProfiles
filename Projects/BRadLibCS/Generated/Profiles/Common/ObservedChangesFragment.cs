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
	/// Interface IObservedChangesFragment.
	/// </summary>
	public interface IObservedChangesFragment 
	{
		ObservationComponentItem<CodeableConcept> ObsChanges { get; set; }                                                                        // CSComponentSlice.cs:106
	}


	/// <summary>
	/// Interface IObservedChangesFragment.
	/// </summary>
	public static class ObservedChangesFragmentExtensions
	{

		public static void Init(this IObservedChangesFragment fragment)
		{
		{                                                                                                                                         // CSComponentSlice.cs:137
		     CodeableConcept ObservationCode()                                                                                                    // FhirConstruct.cs:760
		    {                                                                                                                                     // FhirConstruct.cs:761
		        CodeableConcept retVal = new CodeableConcept();                                                                                   // FhirConstruct.cs:762
		        retVal.Coding = new List<Coding>();                                                                                               // FhirConstruct.cs:768
		        {                                                                                                                                 // FhirConstruct.cs:771
		            var temp4 = new Coding();                                                                                                     // FhirConstruct.cs:772
		            temp4.SystemElement = new FhirUri();                                                                                          // FhirConstruct.cs:775
		            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodesCS";            // FhirConstruct.cs:777
		            temp4.CodeElement = new Code();                                                                                               // FhirConstruct.cs:791
		            temp4.CodeElement.Value = "obsChanges";                                                                                       // FhirConstruct.cs:793
		            retVal.Coding.Add(temp4);                                                                                                     // FhirConstruct.cs:820
		        }                                                                                                                                 // FhirConstruct.cs:821
		        return retVal;                                                                                                                    // FhirConstruct.cs:836
		    }                                                                                                                                     // FhirConstruct.cs:837
		    fragment.ObsChanges = new ObservationComponentItem<CodeableConcept>(ObservationCode());                                               // CSComponentSlice.cs:146
		}                                                                                                                                         // CSComponentSlice.cs:154
		}

		public static void Read(this IObservedChangesFragment fragment, BreastRadiologyDocument doc)
		{
		}

		public static void Write(this IObservedChangesFragment fragment, BreastRadiologyDocument doc)
		{
		}

		public static void Validate(this IObservedChangesFragment fragment,
								StringBuilder sb)
		{
		}
	}
}

