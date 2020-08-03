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
	/// Interface IMGFinding.
	/// </summary>
	public interface IMGFinding 
	{
		ObservationHasMemberCollection<AbnormalityCystProfile> AbnormalityCyst { get; set; }                                                      // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityDuctProfile> AbnormalityDuct { get; set; }                                                      // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityForeignObjectProfile> AbnormalityForeignObject { get; set; }                                    // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityLymphNodeProfile> AbnormalityLymphNode { get; set; }                                            // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityMassProfile> AbnormalityMass { get; set; }                                                      // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                                  // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityFibroadenomaProfile> AbnormalityFibroadenoma { get; set; }                                      // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityArchitecturalDistortionProfile> AbnormalityArchDist { get; set; }                               // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityAsymmetryProfile> AbnormalityAsymmetry { get; set; }                                            // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityCalcificationProfile> AbnormalityCalcification { get; set; }                                    // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityDensityProfile> AbnormalityDensity { get; set; }                                                // CSHasMemberSlice.cs:81
		ObservationHasMemberCollection<AbnormalityFatNecrosisProfile> AbnormalityFatNecrosis { get; set; }                                        // CSHasMemberSlice.cs:81
		ObservationHasMemberItem<MGBreastDensityProfile> MgBreastDensity { get; set; }                                                            // CSHasMemberSlice.cs:75

	}

	/// <summary>
	/// class CMGFindingProfile.
	/// </summary>
	public partial class MGFindingProfile :  ObservationBase, IMGFinding
	{
		public ObservationHasMemberCollection<AbnormalityCystProfile> AbnormalityCyst { get; set; }                                               // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityDuctProfile> AbnormalityDuct { get; set; }                                               // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityForeignObjectProfile> AbnormalityForeignObject { get; set; }                             // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityLymphNodeProfile> AbnormalityLymphNode { get; set; }                                     // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityMassProfile> AbnormalityMass { get; set; }                                               // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                           // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityFibroadenomaProfile> AbnormalityFibroadenoma { get; set; }                               // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityArchitecturalDistortionProfile> AbnormalityArchDist { get; set; }                        // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityAsymmetryProfile> AbnormalityAsymmetry { get; set; }                                     // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityCalcificationProfile> AbnormalityCalcification { get; set; }                             // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityDensityProfile> AbnormalityDensity { get; set; }                                         // CSHasMemberSlice.cs:138
		public ObservationHasMemberCollection<AbnormalityFatNecrosisProfile> AbnormalityFatNecrosis { get; set; }                                 // CSHasMemberSlice.cs:138
		public ObservationHasMemberItem<MGBreastDensityProfile> MgBreastDensity { get; set; }                                                     // CSHasMemberSlice.cs:132

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MGFindingProfile() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public MGFindingProfile(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public MGFindingProfile(BreastRadiologyDocument doc)
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
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
		}

	}
}

