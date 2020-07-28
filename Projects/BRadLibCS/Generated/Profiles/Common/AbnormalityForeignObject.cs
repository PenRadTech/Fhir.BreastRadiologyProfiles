using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using 	BreastRadLib.NAbnormalityForeignObject;

namespace BreastRadLib
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IAbnormalityForeignObject.
	/// </summary>
	public interface IAbnormalityForeignObject  : IBreastBodyLocationRequiredFragment,
        IObservedChangesFragment,
        IBiRadFragment,
        INotPreviouslySeenFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeatureFragment,
        IConsistentWithFragment
	{

	}

	/// <summary>
	/// class AbnormalityForeignObject.
	/// </summary>
	public partial class AbnormalityForeignObject :  ObservationBase, IAbnormalityForeignObject
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
		// Properties from fragment NotPreviouslySeenFragment
		// CSItemFragment.cs:150
		/// <summary>
		/// Property for fragment NotPreviouslySeenFragment element Observation.component
		/// </summary>
		public NNotPreviouslySeenFragment.NotPreviouslySeen.Component NotPreviouslySeen { get; set; }
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
		public AbnormalityForeignObject() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityForeignObject(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AbnormalityForeignObject(BreastRadiologyDocument doc)
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


	namespace NAbnormalityForeignObject
	{

	}
}

