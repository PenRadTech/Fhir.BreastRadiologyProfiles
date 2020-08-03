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
		ObservationComponentItem<CodeableConcept> FeatureType { get; set; }                                                                       // CSComponentSlice.cs:100

	}

	/// <summary>
	/// class CAssociatedFeatureProfile.
	/// </summary>
	public partial class AssociatedFeatureProfile :  ObservationBase, IAssociatedFeature
	{
		public ObservationComponentItem<CodeableConcept> FeatureType { get; set; }                                                                // CSComponentSlice.cs:100
		public ObservationComponentItem<Quantity,Range> ObservedCount { get; set; }                                                               // CSComponentSlice.cs:100

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AssociatedFeatureProfile() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AssociatedFeatureProfile(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AssociatedFeatureProfile(BreastRadiologyDocument doc)
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
			((IObservedCountFragment)this).Init(doc, baseResource);                                                                                  // CSItemClass.cs:74
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
			((IObservedCountFragment)this).Validate();                                                                                               // CSItemClass.cs:83
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			((IBreastBodyLocationRequiredFragment)this).Write();                                                                                     // CSItemClass.cs:80
			((IObservedCountFragment)this).Write();                                                                                                  // CSItemClass.cs:80
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			((IBreastBodyLocationRequiredFragment)this).Read();                                                                                      // CSItemClass.cs:77
			((IObservedCountFragment)this).Read();                                                                                                   // CSItemClass.cs:77
		}

	}
}

