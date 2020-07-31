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
		ComponentHasMember<AbnormalityCyst> AbnormalityCyst { get; set; }                                                                         // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityDuct> AbnormalityDuct { get; set; }                                                                         // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityForeignObject> AbnormalityForeignObject { get; set; }                                                       // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityLymphNode> AbnormalityLymphNode { get; set; }                                                               // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityMass> AbnormalityMass { get; set; }                                                                         // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AssociatedFeature> AssociatedFeature { get; set; }                                                                     // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get; set; }                                                         // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityArchitecturalDistortion> AbnormalityArchDist { get; set; }                                                  // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityAsymmetry> AbnormalityAsymmetry { get; set; }                                                               // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityCalcification> AbnormalityCalcification { get; set; }                                                       // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityDensity> AbnormalityDensity { get; set; }                                                                   // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<AbnormalityFatNecrosis> AbnormalityFatNecrosis { get; set; }                                                           // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<MGBreastDensity> MgBreastDensity { get; set; }                                                                         // CSPropMatchHasMemberSlice.cs:43

	}

	/// <summary>
	/// class MGFinding.
	/// </summary>
	public partial class MGFinding :  ObservationBase, IMGFinding
	{
		public ComponentHasMember<AbnormalityCyst> AbnormalityCyst { get; set; }                                                                  // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityDuct> AbnormalityDuct { get; set; }                                                                  // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityForeignObject> AbnormalityForeignObject { get; set; }                                                // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityLymphNode> AbnormalityLymphNode { get; set; }                                                        // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityMass> AbnormalityMass { get; set; }                                                                  // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AssociatedFeature> AssociatedFeature { get; set; }                                                              // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get; set; }                                                  // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityArchitecturalDistortion> AbnormalityArchDist { get; set; }                                           // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityAsymmetry> AbnormalityAsymmetry { get; set; }                                                        // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityCalcification> AbnormalityCalcification { get; set; }                                                // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityDensity> AbnormalityDensity { get; set; }                                                            // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<AbnormalityFatNecrosis> AbnormalityFatNecrosis { get; set; }                                                    // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<MGBreastDensity> MgBreastDensity { get; set; }                                                                  // CSPropMatchHasMemberSlice.cs:53

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
}

