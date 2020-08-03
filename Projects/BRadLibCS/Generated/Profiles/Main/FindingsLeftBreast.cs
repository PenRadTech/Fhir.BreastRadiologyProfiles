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
	/// Interface IFindingsLeftBreast.
	/// </summary>
	public interface IFindingsLeftBreast 
	{
		ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                        // CSHasMemberSlice.cs:84
		ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                                      // CSHasMemberSlice.cs:84
		ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                        // CSHasMemberSlice.cs:84
		ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                        // CSHasMemberSlice.cs:84

	}

	/// <summary>
	/// class CFindingsLeftBreastProfile.
	/// </summary>
	public partial class FindingsLeftBreastProfile :  ObservationBase, IFindingsLeftBreast
	{
		public ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                 // CSHasMemberSlice.cs:84
		public ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                               // CSHasMemberSlice.cs:84
		public ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                 // CSHasMemberSlice.cs:84
		public ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                 // CSHasMemberSlice.cs:84

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public FindingsLeftBreastProfile() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public FindingsLeftBreastProfile(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public FindingsLeftBreastProfile(BreastRadiologyDocument doc)
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
			this.MgFinding = new ObservationHasMemberItem<MGFindingProfile>();                                                                       // CSHasMemberSlice.cs:122
			this.MriFinding = new ObservationHasMemberItem<MRIFindingProfile>();                                                                     // CSHasMemberSlice.cs:122
			this.NmFinding = new ObservationHasMemberItem<NMFindingProfile>();                                                                       // CSHasMemberSlice.cs:122
			this.UsFinding = new ObservationHasMemberItem<USFindingProfile>();                                                                       // CSHasMemberSlice.cs:122
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

