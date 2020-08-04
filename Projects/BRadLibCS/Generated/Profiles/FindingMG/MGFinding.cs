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
		ObservationHasMemberCollection<AbnormalityCystProfile> AbnormalityCyst { get; set; }                                                      // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityDuctProfile> AbnormalityDuct { get; set; }                                                      // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityForeignObjectProfile> AbnormalityForeignObject { get; set; }                                    // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityLymphNodeProfile> AbnormalityLymphNode { get; set; }                                            // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityMassProfile> AbnormalityMass { get; set; }                                                      // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                                  // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityFibroadenomaProfile> AbnormalityFibroadenoma { get; set; }                                      // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityArchitecturalDistortionProfile> AbnormalityArchDist { get; set; }                               // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityAsymmetryProfile> AbnormalityAsymmetry { get; set; }                                            // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityCalcificationProfile> AbnormalityCalcification { get; set; }                                    // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityDensityProfile> AbnormalityDensity { get; set; }                                                // CSHasMemberSlice.cs:91
		ObservationHasMemberCollection<AbnormalityFatNecrosisProfile> AbnormalityFatNecrosis { get; set; }                                        // CSHasMemberSlice.cs:91
		ObservationHasMemberItem<MGBreastDensityProfile> MgBreastDensity { get; set; }                                                            // CSHasMemberSlice.cs:85

	}

	/// <summary>
	/// class CMGFindingProfile.
	/// </summary>
	public partial class MGFindingProfile :  ObservationBase, IMGFinding
	{
		public ObservationHasMemberCollection<AbnormalityCystProfile> AbnormalityCyst { get; set; }                                               // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityDuctProfile> AbnormalityDuct { get; set; }                                               // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityForeignObjectProfile> AbnormalityForeignObject { get; set; }                             // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityLymphNodeProfile> AbnormalityLymphNode { get; set; }                                     // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityMassProfile> AbnormalityMass { get; set; }                                               // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                           // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityFibroadenomaProfile> AbnormalityFibroadenoma { get; set; }                               // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityArchitecturalDistortionProfile> AbnormalityArchDist { get; set; }                        // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityAsymmetryProfile> AbnormalityAsymmetry { get; set; }                                     // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityCalcificationProfile> AbnormalityCalcification { get; set; }                             // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityDensityProfile> AbnormalityDensity { get; set; }                                         // CSHasMemberSlice.cs:91
		public ObservationHasMemberCollection<AbnormalityFatNecrosisProfile> AbnormalityFatNecrosis { get; set; }                                 // CSHasMemberSlice.cs:91
		public ObservationHasMemberItem<MGBreastDensityProfile> MgBreastDensity { get; set; }                                                     // CSHasMemberSlice.cs:85

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MGFindingProfile(BreastRadiologyDocument doc) : base(doc)
		{
		    this.Init();
		}

		/// <summary>
		/// Init object.
		/// </summary>
		protected override void Init()
		{
		    base.Init();
			this.AbnormalityCyst = new ObservationHasMemberCollection<AbnormalityCystProfile>();                                                     // CSHasMemberSlice.cs:154
			this.AbnormalityDuct = new ObservationHasMemberCollection<AbnormalityDuctProfile>();                                                     // CSHasMemberSlice.cs:154
			this.AbnormalityForeignObject = new ObservationHasMemberCollection<AbnormalityForeignObjectProfile>();                                   // CSHasMemberSlice.cs:154
			this.AbnormalityLymphNode = new ObservationHasMemberCollection<AbnormalityLymphNodeProfile>();                                           // CSHasMemberSlice.cs:154
			this.AbnormalityMass = new ObservationHasMemberCollection<AbnormalityMassProfile>();                                                     // CSHasMemberSlice.cs:154
			this.AssociatedFeature = new ObservationHasMemberCollection<AssociatedFeatureProfile>();                                                 // CSHasMemberSlice.cs:154
			this.AbnormalityFibroadenoma = new ObservationHasMemberCollection<AbnormalityFibroadenomaProfile>();                                     // CSHasMemberSlice.cs:154
			this.AbnormalityArchDist = new ObservationHasMemberCollection<AbnormalityArchitecturalDistortionProfile>();                              // CSHasMemberSlice.cs:154
			this.AbnormalityAsymmetry = new ObservationHasMemberCollection<AbnormalityAsymmetryProfile>();                                           // CSHasMemberSlice.cs:154
			this.AbnormalityCalcification = new ObservationHasMemberCollection<AbnormalityCalcificationProfile>();                                   // CSHasMemberSlice.cs:154
			this.AbnormalityDensity = new ObservationHasMemberCollection<AbnormalityDensityProfile>();                                               // CSHasMemberSlice.cs:154
			this.AbnormalityFatNecrosis = new ObservationHasMemberCollection<AbnormalityFatNecrosisProfile>();                                       // CSHasMemberSlice.cs:154
			this.MgBreastDensity = new ObservationHasMemberItem<MGBreastDensityProfile>();                                                           // CSHasMemberSlice.cs:148
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
			this.AbnormalityCyst.Validate(sb);                                                                                                       // CSHasMemberSlice.cs:129
			this.AbnormalityDuct.Validate(sb);                                                                                                       // CSHasMemberSlice.cs:129
			this.AbnormalityForeignObject.Validate(sb);                                                                                              // CSHasMemberSlice.cs:129
			this.AbnormalityLymphNode.Validate(sb);                                                                                                  // CSHasMemberSlice.cs:129
			this.AbnormalityMass.Validate(sb);                                                                                                       // CSHasMemberSlice.cs:129
			this.AssociatedFeature.Validate(sb);                                                                                                     // CSHasMemberSlice.cs:129
			this.AbnormalityFibroadenoma.Validate(sb);                                                                                               // CSHasMemberSlice.cs:129
			this.AbnormalityArchDist.Validate(sb);                                                                                                   // CSHasMemberSlice.cs:129
			this.AbnormalityAsymmetry.Validate(sb);                                                                                                  // CSHasMemberSlice.cs:129
			this.AbnormalityCalcification.Validate(sb);                                                                                              // CSHasMemberSlice.cs:129
			this.AbnormalityDensity.Validate(sb);                                                                                                    // CSHasMemberSlice.cs:129
			this.AbnormalityFatNecrosis.Validate(sb);                                                                                                // CSHasMemberSlice.cs:129
			this.MgBreastDensity.Validate(sb);                                                                                                       // CSHasMemberSlice.cs:129
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			this.AbnormalityCyst.Write();                                                                                                            // CSHasMemberSlice.cs:123
			this.AbnormalityDuct.Write();                                                                                                            // CSHasMemberSlice.cs:123
			this.AbnormalityForeignObject.Write();                                                                                                   // CSHasMemberSlice.cs:123
			this.AbnormalityLymphNode.Write();                                                                                                       // CSHasMemberSlice.cs:123
			this.AbnormalityMass.Write();                                                                                                            // CSHasMemberSlice.cs:123
			this.AssociatedFeature.Write();                                                                                                          // CSHasMemberSlice.cs:123
			this.AbnormalityFibroadenoma.Write();                                                                                                    // CSHasMemberSlice.cs:123
			this.AbnormalityArchDist.Write();                                                                                                        // CSHasMemberSlice.cs:123
			this.AbnormalityAsymmetry.Write();                                                                                                       // CSHasMemberSlice.cs:123
			this.AbnormalityCalcification.Write();                                                                                                   // CSHasMemberSlice.cs:123
			this.AbnormalityDensity.Write();                                                                                                         // CSHasMemberSlice.cs:123
			this.AbnormalityFatNecrosis.Write();                                                                                                     // CSHasMemberSlice.cs:123
			this.MgBreastDensity.Write();                                                                                                            // CSHasMemberSlice.cs:123
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			this.AbnormalityCyst.Read();                                                                                                             // CSHasMemberSlice.cs:117
			this.AbnormalityDuct.Read();                                                                                                             // CSHasMemberSlice.cs:117
			this.AbnormalityForeignObject.Read();                                                                                                    // CSHasMemberSlice.cs:117
			this.AbnormalityLymphNode.Read();                                                                                                        // CSHasMemberSlice.cs:117
			this.AbnormalityMass.Read();                                                                                                             // CSHasMemberSlice.cs:117
			this.AssociatedFeature.Read();                                                                                                           // CSHasMemberSlice.cs:117
			this.AbnormalityFibroadenoma.Read();                                                                                                     // CSHasMemberSlice.cs:117
			this.AbnormalityArchDist.Read();                                                                                                         // CSHasMemberSlice.cs:117
			this.AbnormalityAsymmetry.Read();                                                                                                        // CSHasMemberSlice.cs:117
			this.AbnormalityCalcification.Read();                                                                                                    // CSHasMemberSlice.cs:117
			this.AbnormalityDensity.Read();                                                                                                          // CSHasMemberSlice.cs:117
			this.AbnormalityFatNecrosis.Read();                                                                                                      // CSHasMemberSlice.cs:117
			this.MgBreastDensity.Read();                                                                                                             // CSHasMemberSlice.cs:117
		}

	}
}

