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
	/// Interface IAbnormalityCyst.
	/// </summary>
	public interface IAbnormalityCyst  : IBreastBodyLocationRequiredFragment,
        IObservedChangesFragment,
        IBiRadFragment,
        IShapeFragment,
        IObservedCountFragment,
        IObservedDistributionFragment,
        IObservedSizeFragment,
        INotPreviouslySeenFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeatureFragment,
        IConsistentWithFragment,
        ITumorSatelliteFragment
	{
		ObservationComponentItem<CodeableConcept> CystType { get; set; }                                                                          // CSComponentSlice.cs:105

	}

	/// <summary>
	/// class CAbnormalityCystProfile.
	/// </summary>
	public partial class AbnormalityCystProfile :  ObservationBase, IAbnormalityCyst
	{
		public ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                           // CSHasMemberSlice.cs:90
		public ObservationHasMemberCollection<ConsistentWithProfile> ConsistentWith { get; set; }                                                 // CSHasMemberSlice.cs:90
		public ObservationHasMemberCollection<TumorSatelliteProfile> TumorSatellite { get; set; }                                                 // CSHasMemberSlice.cs:90
		public ObservationComponentItem<CodeableConcept> CystType { get; set; }                                                                   // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> ObsChanges { get; set; }                                                                 // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> BiRadsAssessmentCategory { get; set; }                                                   // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> Orientation { get; set; }                                                                // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> Shape { get; set; }                                                                      // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> Margin { get; set; }                                                                     // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> MgBreastDensity { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<Quantity,Range> ObservedCount { get; set; }                                                               // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> ObsDistribution { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<Quantity,Range> ObsDistRegionSize { get; set; }                                                           // CSComponentSlice.cs:105
		public ObservationComponentItem<Quantity,Range> ObsSize { get; set; }                                                                     // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> NotPreviouslySeen { get; set; }                                                          // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> CorrespondsWith { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> PrevDemBy { get; set; }                                                                  // CSComponentSlice.cs:105

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityCystProfile() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityCystProfile(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AbnormalityCystProfile(BreastRadiologyDocument doc)
		{
			this.Init(doc, new Observation());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			Observation resource = (Observation) baseResource;
			if (resource == null)
				resource = new Observation();
			base.Init(doc, resource);
			((IBreastBodyLocationRequiredFragment)this).Init(doc, baseResource);                                                                     // CSItemClass.cs:75
			((IObservedChangesFragment)this).Init(doc, baseResource);                                                                                // CSItemClass.cs:75
			((IBiRadFragment)this).Init(doc, baseResource);                                                                                          // CSItemClass.cs:75
			((IShapeFragment)this).Init(doc, baseResource);                                                                                          // CSItemClass.cs:75
			((IObservedCountFragment)this).Init(doc, baseResource);                                                                                  // CSItemClass.cs:75
			((IObservedDistributionFragment)this).Init(doc, baseResource);                                                                           // CSItemClass.cs:75
			((IObservedSizeFragment)this).Init(doc, baseResource);                                                                                   // CSItemClass.cs:75
			((INotPreviouslySeenFragment)this).Init(doc, baseResource);                                                                              // CSItemClass.cs:75
			((ICorrespondsWithFragment)this).Init(doc, baseResource);                                                                                // CSItemClass.cs:75
			((IPreviouslyDemonstratedByFragment)this).Init(doc, baseResource);                                                                       // CSItemClass.cs:75
			((IAssociatedFeatureFragment)this).Init(doc, baseResource);                                                                              // CSItemClass.cs:75
			((IConsistentWithFragment)this).Init(doc, baseResource);                                                                                 // CSItemClass.cs:75
			((ITumorSatelliteFragment)this).Init(doc, baseResource);                                                                                 // CSItemClass.cs:75
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
			            temp4.CodeElement.Value = "abnormalityCystType";                                                                             // FhirConstruct.cs:793
			            retVal.Coding.Add(temp4);                                                                                                    // FhirConstruct.cs:820
			        }                                                                                                                                // FhirConstruct.cs:821
			        return retVal;                                                                                                                   // FhirConstruct.cs:836
			    }                                                                                                                                    // FhirConstruct.cs:837
			    this.CystType = new ObservationComponentItem<CodeableConcept>(ObservationCode());                                                    // CSComponentSlice.cs:145
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
			((IBreastBodyLocationRequiredFragment)this).Validate();                                                                                  // CSItemClass.cs:84
			((IObservedChangesFragment)this).Validate();                                                                                             // CSItemClass.cs:84
			((IBiRadFragment)this).Validate();                                                                                                       // CSItemClass.cs:84
			((IShapeFragment)this).Validate();                                                                                                       // CSItemClass.cs:84
			((IObservedCountFragment)this).Validate();                                                                                               // CSItemClass.cs:84
			((IObservedDistributionFragment)this).Validate();                                                                                        // CSItemClass.cs:84
			((IObservedSizeFragment)this).Validate();                                                                                                // CSItemClass.cs:84
			((INotPreviouslySeenFragment)this).Validate();                                                                                           // CSItemClass.cs:84
			((ICorrespondsWithFragment)this).Validate();                                                                                             // CSItemClass.cs:84
			((IPreviouslyDemonstratedByFragment)this).Validate();                                                                                    // CSItemClass.cs:84
			((IAssociatedFeatureFragment)this).Validate();                                                                                           // CSItemClass.cs:84
			((IConsistentWithFragment)this).Validate();                                                                                              // CSItemClass.cs:84
			((ITumorSatelliteFragment)this).Validate();                                                                                              // CSItemClass.cs:84
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			((IBreastBodyLocationRequiredFragment)this).Write();                                                                                     // CSItemClass.cs:81
			((IObservedChangesFragment)this).Write();                                                                                                // CSItemClass.cs:81
			((IBiRadFragment)this).Write();                                                                                                          // CSItemClass.cs:81
			((IShapeFragment)this).Write();                                                                                                          // CSItemClass.cs:81
			((IObservedCountFragment)this).Write();                                                                                                  // CSItemClass.cs:81
			((IObservedDistributionFragment)this).Write();                                                                                           // CSItemClass.cs:81
			((IObservedSizeFragment)this).Write();                                                                                                   // CSItemClass.cs:81
			((INotPreviouslySeenFragment)this).Write();                                                                                              // CSItemClass.cs:81
			((ICorrespondsWithFragment)this).Write();                                                                                                // CSItemClass.cs:81
			((IPreviouslyDemonstratedByFragment)this).Write();                                                                                       // CSItemClass.cs:81
			((IAssociatedFeatureFragment)this).Write();                                                                                              // CSItemClass.cs:81
			((IConsistentWithFragment)this).Write();                                                                                                 // CSItemClass.cs:81
			((ITumorSatelliteFragment)this).Write();                                                                                                 // CSItemClass.cs:81
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			((IBreastBodyLocationRequiredFragment)this).Read();                                                                                      // CSItemClass.cs:78
			((IObservedChangesFragment)this).Read();                                                                                                 // CSItemClass.cs:78
			((IBiRadFragment)this).Read();                                                                                                           // CSItemClass.cs:78
			((IShapeFragment)this).Read();                                                                                                           // CSItemClass.cs:78
			((IObservedCountFragment)this).Read();                                                                                                   // CSItemClass.cs:78
			((IObservedDistributionFragment)this).Read();                                                                                            // CSItemClass.cs:78
			((IObservedSizeFragment)this).Read();                                                                                                    // CSItemClass.cs:78
			((INotPreviouslySeenFragment)this).Read();                                                                                               // CSItemClass.cs:78
			((ICorrespondsWithFragment)this).Read();                                                                                                 // CSItemClass.cs:78
			((IPreviouslyDemonstratedByFragment)this).Read();                                                                                        // CSItemClass.cs:78
			((IAssociatedFeatureFragment)this).Read();                                                                                               // CSItemClass.cs:78
			((IConsistentWithFragment)this).Read();                                                                                                  // CSItemClass.cs:78
			((ITumorSatelliteFragment)this).Read();                                                                                                  // CSItemClass.cs:78
		}

	}
}

