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
		ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                        // CSHasMemberSlice.cs:85
		ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                                      // CSHasMemberSlice.cs:85
		ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                        // CSHasMemberSlice.cs:85
		ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                        // CSHasMemberSlice.cs:85

	}

	/// <summary>
	/// class CFindingsRightBreastProfile.
	/// </summary>
	public partial class FindingsRightBreastProfile :  ObservationBase, IFindingsRightBreast
	{
		public ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                 // CSHasMemberSlice.cs:85
		public ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                               // CSHasMemberSlice.cs:85
		public ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                 // CSHasMemberSlice.cs:85
		public ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                 // CSHasMemberSlice.cs:85

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public FindingsRightBreastProfile(BreastRadiologyDocument doc) : base(doc)
		{
		    this.Init();
		}

		/// <summary>
		/// Init object.
		/// </summary>
		protected override void Init()
		{
		    base.Init();
			this.MgFinding = new ObservationHasMemberItem<MGFindingProfile>();                                                                       // CSHasMemberSlice.cs:148
			this.MriFinding = new ObservationHasMemberItem<MRIFindingProfile>();                                                                     // CSHasMemberSlice.cs:148
			this.NmFinding = new ObservationHasMemberItem<NMFindingProfile>();                                                                       // CSHasMemberSlice.cs:148
			this.UsFinding = new ObservationHasMemberItem<USFindingProfile>();                                                                       // CSHasMemberSlice.cs:148
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
			this.MgFinding.Validate(sb);                                                                                                             // CSHasMemberSlice.cs:129
			this.MriFinding.Validate(sb);                                                                                                            // CSHasMemberSlice.cs:129
			this.NmFinding.Validate(sb);                                                                                                             // CSHasMemberSlice.cs:129
			this.UsFinding.Validate(sb);                                                                                                             // CSHasMemberSlice.cs:129
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			this.MgFinding.Write();                                                                                                                  // CSHasMemberSlice.cs:123
			this.MriFinding.Write();                                                                                                                 // CSHasMemberSlice.cs:123
			this.NmFinding.Write();                                                                                                                  // CSHasMemberSlice.cs:123
			this.UsFinding.Write();                                                                                                                  // CSHasMemberSlice.cs:123
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			this.MgFinding.Read();                                                                                                                   // CSHasMemberSlice.cs:117
			this.MriFinding.Read();                                                                                                                  // CSHasMemberSlice.cs:117
			this.NmFinding.Read();                                                                                                                   // CSHasMemberSlice.cs:117
			this.UsFinding.Read();                                                                                                                   // CSHasMemberSlice.cs:117
		}

	}
}

