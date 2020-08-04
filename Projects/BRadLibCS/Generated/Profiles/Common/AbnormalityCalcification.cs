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
	/// Interface IAbnormalityCalcification.
	/// </summary>
	public interface IAbnormalityCalcification  : IBreastBodyLocationRequiredFragment,
        IObservedChangesFragment,
        IBiRadFragment,
        INotPreviouslySeenFragment,
        IObservedCountFragment,
        IObservedSizeFragment,
        IObservedDistributionFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeatureFragment,
        IConsistentWithFragment
	{
		ObservationComponentItem<CodeableConcept> CalcificationType { get; set; }                                                                 // CSComponentSlice.cs:105

	}

	/// <summary>
	/// class CAbnormalityCalcificationProfile.
	/// </summary>
	public partial class AbnormalityCalcificationProfile :  ObservationBase, IAbnormalityCalcification
	{
		public ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                           // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<ConsistentWithProfile> ConsistentWith { get; set; }                                                 // CSHasMemberSlice.cs:91
		public ObservationComponentItem<CodeableConcept> CalcificationType { get; set; }                                                          // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> ObsChanges { get; set; }                                                                 // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> BiRadsAssessmentCategory { get; set; }                                                   // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> NotPreviouslySeen { get; set; }                                                          // CSComponentSlice.cs:105
		public ObservationComponentItem<Base, Quantity,Range> ObservedCount { get; set; }                                                         // CSComponentSlice.cs:105
		public ObservationComponentItem<Base, Quantity,Range> ObsSize { get; set; }                                                               // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> ObsDistribution { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<Base, Quantity,Range> ObsDistRegionSize { get; set; }                                                     // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> CorrespondsWith { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> PrevDemBy { get; set; }                                                                  // CSComponentSlice.cs:105

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityCalcificationProfile(BreastRadiologyDocument doc) : base(doc)
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
			((IObservedChangesFragment)this).Init();                                                                                                 // CSItemClass.cs:75
			((IBiRadFragment)this).Init();                                                                                                           // CSItemClass.cs:75
			((INotPreviouslySeenFragment)this).Init();                                                                                               // CSItemClass.cs:75
			((IObservedCountFragment)this).Init();                                                                                                   // CSItemClass.cs:75
			((IObservedSizeFragment)this).Init();                                                                                                    // CSItemClass.cs:75
			((IObservedDistributionFragment)this).Init();                                                                                            // CSItemClass.cs:75
			((ICorrespondsWithFragment)this).Init();                                                                                                 // CSItemClass.cs:75
			((IPreviouslyDemonstratedByFragment)this).Init();                                                                                        // CSItemClass.cs:75
			((IAssociatedFeatureFragment)this).Init();                                                                                               // CSItemClass.cs:75
			((IConsistentWithFragment)this).Init();                                                                                                  // CSItemClass.cs:75
			{                                                                                                                                        // CSComponentSlice.cs:136
			     CodeableConcept ObservationCode()                                                                                                   // FhirConstruct.cs:760
			    {                                                                                                                                    // FhirConstruct.cs:761
			        CodeableConcept retVal = new CodeableConcept();                                                                                  // FhirConstruct.cs:762
			        retVal.Coding = new List<Coding>();                                                                                              // FhirConstruct.cs:768
			        {                                                                                                                                // FhirConstruct.cs:771
			            var temp4 = new Coding();                                                                                                    // FhirConstruct.cs:772
			            temp4.SystemElement = new FhirUri();                                                                                         // FhirConstruct.cs:775
			            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodesCS";           // FhirConstruct.cs:777
			            temp4.CodeElement = new Code();                                                                                              // FhirConstruct.cs:791
			            temp4.CodeElement.Value = "calcificationType";                                                                               // FhirConstruct.cs:793
			            retVal.Coding.Add(temp4);                                                                                                    // FhirConstruct.cs:820
			        }                                                                                                                                // FhirConstruct.cs:821
			        return retVal;                                                                                                                   // FhirConstruct.cs:836
			    }                                                                                                                                    // FhirConstruct.cs:837
			    this.CalcificationType = new ObservationComponentItem<CodeableConcept>(ObservationCode());                                           // CSComponentSlice.cs:145
			}                                                                                                                                        // CSComponentSlice.cs:153
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
			((IObservedChangesFragment)this).Validate(sb);                                                                                           // CSItemClass.cs:84
			((IBiRadFragment)this).Validate(sb);                                                                                                     // CSItemClass.cs:84
			((INotPreviouslySeenFragment)this).Validate(sb);                                                                                         // CSItemClass.cs:84
			((IObservedCountFragment)this).Validate(sb);                                                                                             // CSItemClass.cs:84
			((IObservedSizeFragment)this).Validate(sb);                                                                                              // CSItemClass.cs:84
			((IObservedDistributionFragment)this).Validate(sb);                                                                                      // CSItemClass.cs:84
			((ICorrespondsWithFragment)this).Validate(sb);                                                                                           // CSItemClass.cs:84
			((IPreviouslyDemonstratedByFragment)this).Validate(sb);                                                                                  // CSItemClass.cs:84
			((IAssociatedFeatureFragment)this).Validate(sb);                                                                                         // CSItemClass.cs:84
			((IConsistentWithFragment)this).Validate(sb);                                                                                            // CSItemClass.cs:84
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			((IBreastBodyLocationRequiredFragment)this).Write(this.Doc);                                                                             // CSItemClass.cs:81
			((IObservedChangesFragment)this).Write(this.Doc);                                                                                        // CSItemClass.cs:81
			((IBiRadFragment)this).Write(this.Doc);                                                                                                  // CSItemClass.cs:81
			((INotPreviouslySeenFragment)this).Write(this.Doc);                                                                                      // CSItemClass.cs:81
			((IObservedCountFragment)this).Write(this.Doc);                                                                                          // CSItemClass.cs:81
			((IObservedSizeFragment)this).Write(this.Doc);                                                                                           // CSItemClass.cs:81
			((IObservedDistributionFragment)this).Write(this.Doc);                                                                                   // CSItemClass.cs:81
			((ICorrespondsWithFragment)this).Write(this.Doc);                                                                                        // CSItemClass.cs:81
			((IPreviouslyDemonstratedByFragment)this).Write(this.Doc);                                                                               // CSItemClass.cs:81
			((IAssociatedFeatureFragment)this).Write(this.Doc);                                                                                      // CSItemClass.cs:81
			((IConsistentWithFragment)this).Write(this.Doc);                                                                                         // CSItemClass.cs:81
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			((IBreastBodyLocationRequiredFragment)this).Read(this.Doc);                                                                              // CSItemClass.cs:78
			((IObservedChangesFragment)this).Read(this.Doc);                                                                                         // CSItemClass.cs:78
			((IBiRadFragment)this).Read(this.Doc);                                                                                                   // CSItemClass.cs:78
			((INotPreviouslySeenFragment)this).Read(this.Doc);                                                                                       // CSItemClass.cs:78
			((IObservedCountFragment)this).Read(this.Doc);                                                                                           // CSItemClass.cs:78
			((IObservedSizeFragment)this).Read(this.Doc);                                                                                            // CSItemClass.cs:78
			((IObservedDistributionFragment)this).Read(this.Doc);                                                                                    // CSItemClass.cs:78
			((ICorrespondsWithFragment)this).Read(this.Doc);                                                                                         // CSItemClass.cs:78
			((IPreviouslyDemonstratedByFragment)this).Read(this.Doc);                                                                                // CSItemClass.cs:78
			((IAssociatedFeatureFragment)this).Read(this.Doc);                                                                                       // CSItemClass.cs:78
			((IConsistentWithFragment)this).Read(this.Doc);                                                                                          // CSItemClass.cs:78
		}

	}
}

