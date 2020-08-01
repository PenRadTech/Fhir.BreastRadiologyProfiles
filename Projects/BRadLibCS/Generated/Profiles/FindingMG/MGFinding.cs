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
	/// Interface IMGFinding.
	/// </summary>
	public interface IMGFinding 
	{
		HasMemberCollection<AbnormalityCyst> AbnormalityCyst { get; set; }                                                                        // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityDuct> AbnormalityDuct { get; set; }                                                                        // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityForeignObject> AbnormalityForeignObject { get; set; }                                                      // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityLymphNode> AbnormalityLymphNode { get; set; }                                                              // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityMass> AbnormalityMass { get; set; }                                                                        // CSHasMemberSlice.cs:77
		HasMemberCollection<AssociatedFeature> AssociatedFeature { get; set; }                                                                    // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get; set; }                                                        // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityArchitecturalDistortion> AbnormalityArchDist { get; set; }                                                 // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityAsymmetry> AbnormalityAsymmetry { get; set; }                                                              // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityCalcification> AbnormalityCalcification { get; set; }                                                      // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityDensity> AbnormalityDensity { get; set; }                                                                  // CSHasMemberSlice.cs:77
		HasMemberCollection<AbnormalityFatNecrosis> AbnormalityFatNecrosis { get; set; }                                                          // CSHasMemberSlice.cs:77
		HasMemberCollection<MGBreastDensity> MgBreastDensity { get; set; }                                                                        // CSHasMemberSlice.cs:71

	}

	/// <summary>
	/// class MGFinding.
	/// </summary>
	public partial class MGFinding :  ObservationBase, IMGFinding
	{
		public HasMemberCollection<AbnormalityCyst> AbnormalityCyst { get; set; }                                                                 // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityDuct> AbnormalityDuct { get; set; }                                                                 // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityForeignObject> AbnormalityForeignObject { get; set; }                                               // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityLymphNode> AbnormalityLymphNode { get; set; }                                                       // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityMass> AbnormalityMass { get; set; }                                                                 // CSHasMemberSlice.cs:134
		public HasMemberCollection<AssociatedFeature> AssociatedFeature { get; set; }                                                             // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get; set; }                                                 // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityArchitecturalDistortion> AbnormalityArchDist { get; set; }                                          // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityAsymmetry> AbnormalityAsymmetry { get; set; }                                                       // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityCalcification> AbnormalityCalcification { get; set; }                                               // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityDensity> AbnormalityDensity { get; set; }                                                           // CSHasMemberSlice.cs:134
		public HasMemberCollection<AbnormalityFatNecrosis> AbnormalityFatNecrosis { get; set; }                                                   // CSHasMemberSlice.cs:134
		public HasMemberCollection<MGBreastDensity> MgBreastDensity { get; set; }                                                                 // CSHasMemberSlice.cs:128

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MGFinding() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public MGFinding(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public MGFinding(BreastRadiologyDocument doc)
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

