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
		ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                        // CSHasMemberSlice.cs:84
		ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                                      // CSHasMemberSlice.cs:84
		ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                        // CSHasMemberSlice.cs:84
		ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                        // CSHasMemberSlice.cs:84

	}

	/// <summary>
	/// class CFindingsRightBreastProfile.
	/// </summary>
	public partial class FindingsRightBreastProfile :  ObservationBase, IFindingsRightBreast
	{
		public ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                 // CSHasMemberSlice.cs:84
		public ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                               // CSHasMemberSlice.cs:84
		public ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                 // CSHasMemberSlice.cs:84
		public ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                 // CSHasMemberSlice.cs:84

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public FindingsRightBreastProfile() : base()
		{
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init()
		{
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
		public override void Write(BreastRadiologyDocument doc)
		{
			base.Write(doc);
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read<Observation>(BreastRadiologyDocument doc,
							      Observation resource)
		{
			base.Read(doc, resource);
		}

	}
}

