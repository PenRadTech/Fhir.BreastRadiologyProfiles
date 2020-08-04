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
	/// Interface IAssociatedFeature.
	/// </summary>
	public interface IAssociatedFeature  : IBreastBodyLocationRequiredFragment,
        IObservedCountFragment
	{
		ObservationComponentItem<CodeableConcept> FeatureType { get; set; }                                                                       // CSComponentSlice.cs:106

	}

	/// <summary>
	/// class CAssociatedFeatureProfile.
	/// </summary>
	public partial class AssociatedFeatureProfile :  ObservationBase, IAssociatedFeature
	{
		public ObservationComponentItem<CodeableConcept> FeatureType { get; set; }                                                                // CSComponentSlice.cs:106
		public ObservationComponentItem<Base, Quantity,Range> ObservedCount { get; set; }                                                         // CSComponentSlice.cs:106

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AssociatedFeatureProfile(BreastRadiologyDocument doc) : base(doc)
		{
		    this.Init();
		}

		/// <summary>
		/// Init object.
		/// </summary>
		protected override void Init()
		{
		    base.Init();
			((IBreastBodyLocationRequiredFragment)this).Init();                                                                                      // CSItemClass.cs:75
			((IObservedCountFragment)this).Init();                                                                                                   // CSItemClass.cs:75
			{                                                                                                                                        // CSComponentSlice.cs:137
			     CodeableConcept ObservationCode()                                                                                                   // FhirConstruct.cs:760
			    {                                                                                                                                    // FhirConstruct.cs:761
			        CodeableConcept retVal = new CodeableConcept();                                                                                  // FhirConstruct.cs:762
			        retVal.Coding = new List<Coding>();                                                                                              // FhirConstruct.cs:768
			        {                                                                                                                                // FhirConstruct.cs:771
			            var temp4 = new Coding();                                                                                                    // FhirConstruct.cs:772
			            temp4.SystemElement = new FhirUri();                                                                                         // FhirConstruct.cs:775
			            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodesCS";           // FhirConstruct.cs:777
			            temp4.CodeElement = new Code();                                                                                              // FhirConstruct.cs:791
			            temp4.CodeElement.Value = "featureType";                                                                                     // FhirConstruct.cs:793
			            retVal.Coding.Add(temp4);                                                                                                    // FhirConstruct.cs:820
			        }                                                                                                                                // FhirConstruct.cs:821
			        return retVal;                                                                                                                   // FhirConstruct.cs:836
			    }                                                                                                                                    // FhirConstruct.cs:837
			    this.FeatureType = new ObservationComponentItem<CodeableConcept>(ObservationCode());                                                 // CSComponentSlice.cs:146
			}                                                                                                                                        // CSComponentSlice.cs:154
		}

		/// <summary>
		/// Validate object. Will return false if an error is detected. sb will contains text of error found.
		/// User must not call Init().
		/// </summary>
		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			((IBreastBodyLocationRequiredFragment)this).Validate(sb);                                                                                // CSItemClass.cs:84
			((IObservedCountFragment)this).Validate(sb);                                                                                             // CSItemClass.cs:84
			this.FeatureType.Validate(sb);                                                                                                           // CSPropertyBase.cs:45
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			((IBreastBodyLocationRequiredFragment)this).Write(this.Doc);                                                                             // CSItemClass.cs:81
			((IObservedCountFragment)this).Write(this.Doc);                                                                                          // CSItemClass.cs:81
			this.FeatureType.Write(this.Doc, this.Resource);                                                                                         // CSPropertyBase.cs:39
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			((IBreastBodyLocationRequiredFragment)this).Read(this.Doc);                                                                              // CSItemClass.cs:78
			((IObservedCountFragment)this).Read(this.Doc);                                                                                           // CSItemClass.cs:78
			this.FeatureType.Read(this.Doc, this.Resource);                                                                                          // CSPropertyBase.cs:33
		}

	}
}

