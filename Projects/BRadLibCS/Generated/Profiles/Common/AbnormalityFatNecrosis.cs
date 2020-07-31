using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
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
		public HasMemberCollection<AssociatedFeature> AssociatedFeature { get; set; }                                                             // CSPropMatchHasMemberSlice.cs:126
		public HasMemberCollection<ConsistentWith> ConsistentWith { get; set; }                                                                   // CSPropMatchHasMemberSlice.cs:126

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
			((IBreastBodyLocationRequiredFragment)this).Init(doc, baseResource);                                                                     // CSItemClass.cs:73
			((IObservedChangesFragment)this).Init(doc, baseResource);                                                                                // CSItemClass.cs:73
			((IBiRadFragment)this).Init(doc, baseResource);                                                                                          // CSItemClass.cs:73
			((IShapeFragment)this).Init(doc, baseResource);                                                                                          // CSItemClass.cs:73
			((INotPreviouslySeenFragment)this).Init(doc, baseResource);                                                                              // CSItemClass.cs:73
			((IObservedCountFragment)this).Init(doc, baseResource);                                                                                  // CSItemClass.cs:73
			((IObservedSizeFragment)this).Init(doc, baseResource);                                                                                   // CSItemClass.cs:73
			((IObservedDistributionFragment)this).Init(doc, baseResource);                                                                           // CSItemClass.cs:73
			((ICorrespondsWithFragment)this).Init(doc, baseResource);                                                                                // CSItemClass.cs:73
			((IPreviouslyDemonstratedByFragment)this).Init(doc, baseResource);                                                                       // CSItemClass.cs:73
			((IAssociatedFeatureFragment)this).Init(doc, baseResource);                                                                              // CSItemClass.cs:73
			((IConsistentWithFragment)this).Init(doc, baseResource);                                                                                 // CSItemClass.cs:73
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
			((IBreastBodyLocationRequiredFragment)this).Validate();                                                                                  // CSItemClass.cs:82
			((IObservedChangesFragment)this).Validate();                                                                                             // CSItemClass.cs:82
			((IBiRadFragment)this).Validate();                                                                                                       // CSItemClass.cs:82
			((IShapeFragment)this).Validate();                                                                                                       // CSItemClass.cs:82
			((INotPreviouslySeenFragment)this).Validate();                                                                                           // CSItemClass.cs:82
			((IObservedCountFragment)this).Validate();                                                                                               // CSItemClass.cs:82
			((IObservedSizeFragment)this).Validate();                                                                                                // CSItemClass.cs:82
			((IObservedDistributionFragment)this).Validate();                                                                                        // CSItemClass.cs:82
			((ICorrespondsWithFragment)this).Validate();                                                                                             // CSItemClass.cs:82
			((IPreviouslyDemonstratedByFragment)this).Validate();                                                                                    // CSItemClass.cs:82
			((IAssociatedFeatureFragment)this).Validate();                                                                                           // CSItemClass.cs:82
			((IConsistentWithFragment)this).Validate();                                                                                              // CSItemClass.cs:82
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			((IBreastBodyLocationRequiredFragment)this).Write();                                                                                     // CSItemClass.cs:79
			((IObservedChangesFragment)this).Write();                                                                                                // CSItemClass.cs:79
			((IBiRadFragment)this).Write();                                                                                                          // CSItemClass.cs:79
			((IShapeFragment)this).Write();                                                                                                          // CSItemClass.cs:79
			((INotPreviouslySeenFragment)this).Write();                                                                                              // CSItemClass.cs:79
			((IObservedCountFragment)this).Write();                                                                                                  // CSItemClass.cs:79
			((IObservedSizeFragment)this).Write();                                                                                                   // CSItemClass.cs:79
			((IObservedDistributionFragment)this).Write();                                                                                           // CSItemClass.cs:79
			((ICorrespondsWithFragment)this).Write();                                                                                                // CSItemClass.cs:79
			((IPreviouslyDemonstratedByFragment)this).Write();                                                                                       // CSItemClass.cs:79
			((IAssociatedFeatureFragment)this).Write();                                                                                              // CSItemClass.cs:79
			((IConsistentWithFragment)this).Write();                                                                                                 // CSItemClass.cs:79
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			((IBreastBodyLocationRequiredFragment)this).Read();                                                                                      // CSItemClass.cs:76
			((IObservedChangesFragment)this).Read();                                                                                                 // CSItemClass.cs:76
			((IBiRadFragment)this).Read();                                                                                                           // CSItemClass.cs:76
			((IShapeFragment)this).Read();                                                                                                           // CSItemClass.cs:76
			((INotPreviouslySeenFragment)this).Read();                                                                                               // CSItemClass.cs:76
			((IObservedCountFragment)this).Read();                                                                                                   // CSItemClass.cs:76
			((IObservedSizeFragment)this).Read();                                                                                                    // CSItemClass.cs:76
			((IObservedDistributionFragment)this).Read();                                                                                            // CSItemClass.cs:76
			((ICorrespondsWithFragment)this).Read();                                                                                                 // CSItemClass.cs:76
			((IPreviouslyDemonstratedByFragment)this).Read();                                                                                        // CSItemClass.cs:76
			((IAssociatedFeatureFragment)this).Read();                                                                                               // CSItemClass.cs:76
			((IConsistentWithFragment)this).Read();                                                                                                  // CSItemClass.cs:76
		}

	}
}

