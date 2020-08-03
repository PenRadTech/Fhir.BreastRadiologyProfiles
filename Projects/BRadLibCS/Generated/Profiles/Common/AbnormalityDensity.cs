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
	/// Interface IAbnormalityDensity.
	/// </summary>
	public interface IAbnormalityDensity  : IBreastBodyLocationRequiredFragment,
        IObservedChangesFragment,
        IBiRadFragment,
        IShapeFragment,
        INotPreviouslySeenFragment,
        IObservedCountFragment,
        IObservedSizeFragment,
        IObservedDistributionFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeatureFragment,
        IConsistentWithFragment
	{
		ObservationComponentItem<CodeableConcept> DensityType { get; set; }                                                                       // CSComponentSlice.cs:100

	}

	/// <summary>
	/// class CAbnormalityDensityProfile.
	/// </summary>
	public partial class AbnormalityDensityProfile :  ObservationBase, IAbnormalityDensity
	{
		public ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                           // CSHasMemberSlice.cs:90
		public ObservationHasMemberCollection<ConsistentWithProfile> ConsistentWith { get; set; }                                                 // CSHasMemberSlice.cs:90
		public ObservationComponentItem<CodeableConcept> DensityType { get; set; }                                                                // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> ObsChanges { get; set; }                                                                 // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> BiRadsAssessmentCategory { get; set; }                                                   // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> Orientation { get; set; }                                                                // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> Shape { get; set; }                                                                      // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> Margin { get; set; }                                                                     // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> MgBreastDensity { get; set; }                                                            // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> NotPreviouslySeen { get; set; }                                                          // CSComponentSlice.cs:100
		public ObservationComponentItem<Quantity,Range> ObservedCount { get; set; }                                                               // CSComponentSlice.cs:100
		public ObservationComponentItem<Quantity,Range> ObsSize { get; set; }                                                                     // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> ObsDistribution { get; set; }                                                            // CSComponentSlice.cs:100
		public ObservationComponentItem<Quantity,Range> ObsDistRegionSize { get; set; }                                                           // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> CorrespondsWith { get; set; }                                                            // CSComponentSlice.cs:100
		public ObservationComponentItem<CodeableConcept> PrevDemBy { get; set; }                                                                  // CSComponentSlice.cs:100

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityDensityProfile() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityDensityProfile(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AbnormalityDensityProfile(BreastRadiologyDocument doc)
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
			((IBreastBodyLocationRequiredFragment)this).Init(doc, baseResource);                                                                     // CSItemClass.cs:74
			((IObservedChangesFragment)this).Init(doc, baseResource);                                                                                // CSItemClass.cs:74
			((IBiRadFragment)this).Init(doc, baseResource);                                                                                          // CSItemClass.cs:74
			((IShapeFragment)this).Init(doc, baseResource);                                                                                          // CSItemClass.cs:74
			((INotPreviouslySeenFragment)this).Init(doc, baseResource);                                                                              // CSItemClass.cs:74
			((IObservedCountFragment)this).Init(doc, baseResource);                                                                                  // CSItemClass.cs:74
			((IObservedSizeFragment)this).Init(doc, baseResource);                                                                                   // CSItemClass.cs:74
			((IObservedDistributionFragment)this).Init(doc, baseResource);                                                                           // CSItemClass.cs:74
			((ICorrespondsWithFragment)this).Init(doc, baseResource);                                                                                // CSItemClass.cs:74
			((IPreviouslyDemonstratedByFragment)this).Init(doc, baseResource);                                                                       // CSItemClass.cs:74
			((IAssociatedFeatureFragment)this).Init(doc, baseResource);                                                                              // CSItemClass.cs:74
			((IConsistentWithFragment)this).Init(doc, baseResource);                                                                                 // CSItemClass.cs:74
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
			((IBreastBodyLocationRequiredFragment)this).Validate();                                                                                  // CSItemClass.cs:83
			((IObservedChangesFragment)this).Validate();                                                                                             // CSItemClass.cs:83
			((IBiRadFragment)this).Validate();                                                                                                       // CSItemClass.cs:83
			((IShapeFragment)this).Validate();                                                                                                       // CSItemClass.cs:83
			((INotPreviouslySeenFragment)this).Validate();                                                                                           // CSItemClass.cs:83
			((IObservedCountFragment)this).Validate();                                                                                               // CSItemClass.cs:83
			((IObservedSizeFragment)this).Validate();                                                                                                // CSItemClass.cs:83
			((IObservedDistributionFragment)this).Validate();                                                                                        // CSItemClass.cs:83
			((ICorrespondsWithFragment)this).Validate();                                                                                             // CSItemClass.cs:83
			((IPreviouslyDemonstratedByFragment)this).Validate();                                                                                    // CSItemClass.cs:83
			((IAssociatedFeatureFragment)this).Validate();                                                                                           // CSItemClass.cs:83
			((IConsistentWithFragment)this).Validate();                                                                                              // CSItemClass.cs:83
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			((IBreastBodyLocationRequiredFragment)this).Write();                                                                                     // CSItemClass.cs:80
			((IObservedChangesFragment)this).Write();                                                                                                // CSItemClass.cs:80
			((IBiRadFragment)this).Write();                                                                                                          // CSItemClass.cs:80
			((IShapeFragment)this).Write();                                                                                                          // CSItemClass.cs:80
			((INotPreviouslySeenFragment)this).Write();                                                                                              // CSItemClass.cs:80
			((IObservedCountFragment)this).Write();                                                                                                  // CSItemClass.cs:80
			((IObservedSizeFragment)this).Write();                                                                                                   // CSItemClass.cs:80
			((IObservedDistributionFragment)this).Write();                                                                                           // CSItemClass.cs:80
			((ICorrespondsWithFragment)this).Write();                                                                                                // CSItemClass.cs:80
			((IPreviouslyDemonstratedByFragment)this).Write();                                                                                       // CSItemClass.cs:80
			((IAssociatedFeatureFragment)this).Write();                                                                                              // CSItemClass.cs:80
			((IConsistentWithFragment)this).Write();                                                                                                 // CSItemClass.cs:80
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			((IBreastBodyLocationRequiredFragment)this).Read();                                                                                      // CSItemClass.cs:77
			((IObservedChangesFragment)this).Read();                                                                                                 // CSItemClass.cs:77
			((IBiRadFragment)this).Read();                                                                                                           // CSItemClass.cs:77
			((IShapeFragment)this).Read();                                                                                                           // CSItemClass.cs:77
			((INotPreviouslySeenFragment)this).Read();                                                                                               // CSItemClass.cs:77
			((IObservedCountFragment)this).Read();                                                                                                   // CSItemClass.cs:77
			((IObservedSizeFragment)this).Read();                                                                                                    // CSItemClass.cs:77
			((IObservedDistributionFragment)this).Read();                                                                                            // CSItemClass.cs:77
			((ICorrespondsWithFragment)this).Read();                                                                                                 // CSItemClass.cs:77
			((IPreviouslyDemonstratedByFragment)this).Read();                                                                                        // CSItemClass.cs:77
			((IAssociatedFeatureFragment)this).Read();                                                                                               // CSItemClass.cs:77
			((IConsistentWithFragment)this).Read();                                                                                                  // CSItemClass.cs:77
		}

	}
}

