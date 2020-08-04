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
			this.AbnormalityCyst = new ObservationHasMemberCollection<AbnormalityCystProfile>();                                                     // CSHasMemberSlice.cs:129
			this.AbnormalityDuct = new ObservationHasMemberCollection<AbnormalityDuctProfile>();                                                     // CSHasMemberSlice.cs:129
			this.AbnormalityForeignObject = new ObservationHasMemberCollection<AbnormalityForeignObjectProfile>();                                   // CSHasMemberSlice.cs:129
			this.AbnormalityLymphNode = new ObservationHasMemberCollection<AbnormalityLymphNodeProfile>();                                           // CSHasMemberSlice.cs:129
			this.AbnormalityMass = new ObservationHasMemberCollection<AbnormalityMassProfile>();                                                     // CSHasMemberSlice.cs:129
			this.AssociatedFeature = new ObservationHasMemberCollection<AssociatedFeatureProfile>();                                                 // CSHasMemberSlice.cs:129
			this.AbnormalityFibroadenoma = new ObservationHasMemberCollection<AbnormalityFibroadenomaProfile>();                                     // CSHasMemberSlice.cs:129
			this.AbnormalityArchDist = new ObservationHasMemberCollection<AbnormalityArchitecturalDistortionProfile>();                              // CSHasMemberSlice.cs:129
			this.AbnormalityAsymmetry = new ObservationHasMemberCollection<AbnormalityAsymmetryProfile>();                                           // CSHasMemberSlice.cs:129
			this.AbnormalityCalcification = new ObservationHasMemberCollection<AbnormalityCalcificationProfile>();                                   // CSHasMemberSlice.cs:129
			this.AbnormalityDensity = new ObservationHasMemberCollection<AbnormalityDensityProfile>();                                               // CSHasMemberSlice.cs:129
			this.AbnormalityFatNecrosis = new ObservationHasMemberCollection<AbnormalityFatNecrosisProfile>();                                       // CSHasMemberSlice.cs:129
			this.MgBreastDensity = new ObservationHasMemberItem<MGBreastDensityProfile>();                                                           // CSHasMemberSlice.cs:123
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
			this.AbnormalityCyst.Validate(sb);                                                                                                       // CSPropertyBase.cs:45
			this.AbnormalityDuct.Validate(sb);                                                                                                       // CSPropertyBase.cs:45
			this.AbnormalityForeignObject.Validate(sb);                                                                                              // CSPropertyBase.cs:45
			this.AbnormalityLymphNode.Validate(sb);                                                                                                  // CSPropertyBase.cs:45
			this.AbnormalityMass.Validate(sb);                                                                                                       // CSPropertyBase.cs:45
			this.AssociatedFeature.Validate(sb);                                                                                                     // CSPropertyBase.cs:45
			this.AbnormalityFibroadenoma.Validate(sb);                                                                                               // CSPropertyBase.cs:45
			this.AbnormalityArchDist.Validate(sb);                                                                                                   // CSPropertyBase.cs:45
			this.AbnormalityAsymmetry.Validate(sb);                                                                                                  // CSPropertyBase.cs:45
			this.AbnormalityCalcification.Validate(sb);                                                                                              // CSPropertyBase.cs:45
			this.AbnormalityDensity.Validate(sb);                                                                                                    // CSPropertyBase.cs:45
			this.AbnormalityFatNecrosis.Validate(sb);                                                                                                // CSPropertyBase.cs:45
			this.MgBreastDensity.Validate(sb);                                                                                                       // CSPropertyBase.cs:45
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			this.AbnormalityCyst.Write(this.Doc, this.Resource);                                                                                     // CSPropertyBase.cs:39
			this.AbnormalityDuct.Write(this.Doc, this.Resource);                                                                                     // CSPropertyBase.cs:39
			this.AbnormalityForeignObject.Write(this.Doc, this.Resource);                                                                            // CSPropertyBase.cs:39
			this.AbnormalityLymphNode.Write(this.Doc, this.Resource);                                                                                // CSPropertyBase.cs:39
			this.AbnormalityMass.Write(this.Doc, this.Resource);                                                                                     // CSPropertyBase.cs:39
			this.AssociatedFeature.Write(this.Doc, this.Resource);                                                                                   // CSPropertyBase.cs:39
			this.AbnormalityFibroadenoma.Write(this.Doc, this.Resource);                                                                             // CSPropertyBase.cs:39
			this.AbnormalityArchDist.Write(this.Doc, this.Resource);                                                                                 // CSPropertyBase.cs:39
			this.AbnormalityAsymmetry.Write(this.Doc, this.Resource);                                                                                // CSPropertyBase.cs:39
			this.AbnormalityCalcification.Write(this.Doc, this.Resource);                                                                            // CSPropertyBase.cs:39
			this.AbnormalityDensity.Write(this.Doc, this.Resource);                                                                                  // CSPropertyBase.cs:39
			this.AbnormalityFatNecrosis.Write(this.Doc, this.Resource);                                                                              // CSPropertyBase.cs:39
			this.MgBreastDensity.Write(this.Doc, this.Resource);                                                                                     // CSPropertyBase.cs:39
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			this.AbnormalityCyst.Read(this.Doc, this.Resource);                                                                                      // CSPropertyBase.cs:33
			this.AbnormalityDuct.Read(this.Doc, this.Resource);                                                                                      // CSPropertyBase.cs:33
			this.AbnormalityForeignObject.Read(this.Doc, this.Resource);                                                                             // CSPropertyBase.cs:33
			this.AbnormalityLymphNode.Read(this.Doc, this.Resource);                                                                                 // CSPropertyBase.cs:33
			this.AbnormalityMass.Read(this.Doc, this.Resource);                                                                                      // CSPropertyBase.cs:33
			this.AssociatedFeature.Read(this.Doc, this.Resource);                                                                                    // CSPropertyBase.cs:33
			this.AbnormalityFibroadenoma.Read(this.Doc, this.Resource);                                                                              // CSPropertyBase.cs:33
			this.AbnormalityArchDist.Read(this.Doc, this.Resource);                                                                                  // CSPropertyBase.cs:33
			this.AbnormalityAsymmetry.Read(this.Doc, this.Resource);                                                                                 // CSPropertyBase.cs:33
			this.AbnormalityCalcification.Read(this.Doc, this.Resource);                                                                             // CSPropertyBase.cs:33
			this.AbnormalityDensity.Read(this.Doc, this.Resource);                                                                                   // CSPropertyBase.cs:33
			this.AbnormalityFatNecrosis.Read(this.Doc, this.Resource);                                                                               // CSPropertyBase.cs:33
			this.MgBreastDensity.Read(this.Doc, this.Resource);                                                                                      // CSPropertyBase.cs:33
		}

	}
}

