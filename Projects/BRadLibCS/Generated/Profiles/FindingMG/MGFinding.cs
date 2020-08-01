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
		HasMemberCollection<AbnormalityCystProfile> AbnormalityCyst { get; set; }                                                                 // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityDuctProfile> AbnormalityDuct { get; set; }                                                                 // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityForeignObjectProfile> AbnormalityForeignObject { get; set; }                                               // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityLymphNodeProfile> AbnormalityLymphNode { get; set; }                                                       // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityMassProfile> AbnormalityMass { get; set; }                                                                 // CSHasMemberSlice.cs:81
		HasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                                             // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityFibroadenomaProfile> AbnormalityFibroadenoma { get; set; }                                                 // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityArchitecturalDistortionProfile> AbnormalityArchDist { get; set; }                                          // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityAsymmetryProfile> AbnormalityAsymmetry { get; set; }                                                       // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityCalcificationProfile> AbnormalityCalcification { get; set; }                                               // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityDensityProfile> AbnormalityDensity { get; set; }                                                           // CSHasMemberSlice.cs:81
		HasMemberCollection<AbnormalityFatNecrosisProfile> AbnormalityFatNecrosis { get; set; }                                                   // CSHasMemberSlice.cs:81
		HasMemberCollection<MGBreastDensityProfile> MgBreastDensity { get; set; }                                                                 // CSHasMemberSlice.cs:75

	}

	/// <summary>
	/// class CMGFindingProfile.
	/// </summary>
	public partial class MGFindingProfile :  ObservationBase, IMGFinding
	{
		public HasMemberCollection<AbnormalityCystProfile> AbnormalityCyst { get; set; }                                                          // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityDuctProfile> AbnormalityDuct { get; set; }                                                          // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityForeignObjectProfile> AbnormalityForeignObject { get; set; }                                        // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityLymphNodeProfile> AbnormalityLymphNode { get; set; }                                                // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityMassProfile> AbnormalityMass { get; set; }                                                          // CSHasMemberSlice.cs:138
		public HasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                                      // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityFibroadenomaProfile> AbnormalityFibroadenoma { get; set; }                                          // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityArchitecturalDistortionProfile> AbnormalityArchDist { get; set; }                                   // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityAsymmetryProfile> AbnormalityAsymmetry { get; set; }                                                // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityCalcificationProfile> AbnormalityCalcification { get; set; }                                        // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityDensityProfile> AbnormalityDensity { get; set; }                                                    // CSHasMemberSlice.cs:138
		public HasMemberCollection<AbnormalityFatNecrosisProfile> AbnormalityFatNecrosis { get; set; }                                            // CSHasMemberSlice.cs:138
		public HasMemberCollection<MGBreastDensityProfile> MgBreastDensity { get; set; }                                                          // CSHasMemberSlice.cs:132

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

