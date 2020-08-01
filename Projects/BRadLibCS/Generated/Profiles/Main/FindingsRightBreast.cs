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
	/// Interface IFindingsRightBreast.
	/// </summary>
	public interface IFindingsRightBreast 
	{
		HasMemberCollection<MGFindingProfile> MgFinding { get; set; }                                                                             // CSHasMemberSlice.cs:71
		HasMemberCollection<MRIFindingProfile> MriFinding { get; set; }                                                                           // CSHasMemberSlice.cs:71
		HasMemberCollection<NMFindingProfile> NmFinding { get; set; }                                                                             // CSHasMemberSlice.cs:71
		HasMemberCollection<USFindingProfile> UsFinding { get; set; }                                                                             // CSHasMemberSlice.cs:71

	}

	/// <summary>
	/// class CFindingsRightBreastProfile.
	/// </summary>
	public partial class FindingsRightBreastProfile :  ObservationBase, IFindingsRightBreast
	{
		public HasMemberCollection<MGFindingProfile> MgFinding { get; set; }                                                                      // CSHasMemberSlice.cs:128
		public HasMemberCollection<MRIFindingProfile> MriFinding { get; set; }                                                                    // CSHasMemberSlice.cs:128
		public HasMemberCollection<NMFindingProfile> NmFinding { get; set; }                                                                      // CSHasMemberSlice.cs:128
		public HasMemberCollection<USFindingProfile> UsFinding { get; set; }                                                                      // CSHasMemberSlice.cs:128

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public FindingsRightBreastProfile() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public FindingsRightBreastProfile(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public FindingsRightBreastProfile(BreastRadiologyDocument doc)
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

