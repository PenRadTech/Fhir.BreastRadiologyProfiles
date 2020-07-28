using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using 	BreastRadLib.NAbnormalityFatNecrosis;

namespace BreastRadLib
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IAbnormalityFatNecrosis.
	/// </summary>
	public interface IAbnormalityFatNecrosis  : IBreastBodyLocationRequiredFragment,
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

	}

	/// <summary>
	/// class AbnormalityFatNecrosis.
	/// </summary>
	public partial class AbnormalityFatNecrosis :  ObservationBase, IAbnormalityFatNecrosis
	{
		// Properties from fragment BreastBodyLocationRequiredFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment BreastBodyLocationRequiredFragment element Observation.bodySite
		/// </summary>
		public NBreastBodyLocationRequiredFragment.BodySite bodySite { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment ObservedChangesFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ObservedChangesFragment element Observation.component
		/// </summary>
		public NObservedChangesFragment.ObsChanges.Component ObsChanges { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment BiRadFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment BiRadFragment element Observation.component
		/// </summary>
		public NBiRadFragment.BiRadsAssessmentCategory.Component BiRadsAssessmentCategory { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment ShapeFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ShapeFragment element Observation.component
		/// </summary>
		public NShapeFragment.Orientation.Component Orientation { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ShapeFragment element Observation.component
		/// </summary>
		public NShapeFragment.Shape.Component Shape { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ShapeFragment element Observation.component
		/// </summary>
		public NShapeFragment.Margin.Component Margin { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ShapeFragment element Observation.component
		/// </summary>
		public NShapeFragment.MgBreastDensity.Component MgBreastDensity { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment NotPreviouslySeenFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment NotPreviouslySeenFragment element Observation.component
		/// </summary>
		public NNotPreviouslySeenFragment.NotPreviouslySeen.Component NotPreviouslySeen { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment ObservedCountFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ObservedCountFragment element Observation.component
		/// </summary>
		public NObservedCountFragment.ObservedCount.Component ObservedCount { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment ObservedSizeFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ObservedSizeFragment element Observation.component
		/// </summary>
		public NObservedSizeFragment.ObsSize.Component ObsSize { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment ObservedDistributionFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ObservedDistributionFragment element Observation.component
		/// </summary>
		public NObservedDistributionFragment.ObsDistribution.Component ObsDistribution { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ObservedDistributionFragment element Observation.component
		/// </summary>
		public NObservedDistributionFragment.ObsDistRegionSize.Component ObsDistRegionSize { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment CorrespondsWithFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment CorrespondsWithFragment element Observation.component
		/// </summary>
		public NCorrespondsWithFragment.CorrespondsWith.Component CorrespondsWith { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment PreviouslyDemonstratedByFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment PreviouslyDemonstratedByFragment element Observation.component
		/// </summary>
		public NPreviouslyDemonstratedByFragment.PrevDemBy.Component PrevDemBy { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment AssociatedFeatureFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment AssociatedFeatureFragment element Observation.hasMember
		/// </summary>
		public NAssociatedFeatureFragment.AssociatedFeature.HasMember AssociatedFeature { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154
		// Properties from fragment ConsistentWithFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment ConsistentWithFragment element Observation.hasMember
		/// </summary>
		public NConsistentWithFragment.ConsistentWith.HasMember ConsistentWith { get; set; }
		                                                                                                                                            // CSItemFragment.cs:154

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityFatNecrosis() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityFatNecrosis(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AbnormalityFatNecrosis(BreastRadiologyDocument doc)
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
			//+ Constructor
			//- Constructor
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
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			//- ValidateCode
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			//- WriteCode
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			//- ReadCode
		}

	}


	namespace NAbnormalityFatNecrosis
	{

	}
}

