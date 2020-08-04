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
		ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                        // CSHasMemberSlice.cs:85
		ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                                      // CSHasMemberSlice.cs:85
		ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                        // CSHasMemberSlice.cs:85
		ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                        // CSHasMemberSlice.cs:85

	}

	/// <summary>
	/// class CFindingsLeftBreastProfile.
	/// </summary>
	public partial class FindingsLeftBreastProfile :  ObservationBase, IFindingsLeftBreast
	{
		public ObservationHasMemberItem<MGFindingProfile> MgFinding { get; set; }                                                                 // CSHasMemberSlice.cs:85
		public ObservationHasMemberItem<MRIFindingProfile> MriFinding { get; set; }                                                               // CSHasMemberSlice.cs:85
		public ObservationHasMemberItem<NMFindingProfile> NmFinding { get; set; }                                                                 // CSHasMemberSlice.cs:85
		public ObservationHasMemberItem<USFindingProfile> UsFinding { get; set; }                                                                 // CSHasMemberSlice.cs:85

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public FindingsLeftBreastProfile(BreastRadiologyDocument doc) : base(doc)
		{
		    this.Init();
		}

		/// <summary>
		/// Init object.
		/// </summary>
		protected override void Init()
		{
		    base.Init();
			this.MgFinding = new ObservationHasMemberItem<MGFindingProfile>();                                                                       // CSHasMemberSlice.cs:123
			this.MriFinding = new ObservationHasMemberItem<MRIFindingProfile>();                                                                     // CSHasMemberSlice.cs:123
			this.NmFinding = new ObservationHasMemberItem<NMFindingProfile>();                                                                       // CSHasMemberSlice.cs:123
			this.UsFinding = new ObservationHasMemberItem<USFindingProfile>();                                                                       // CSHasMemberSlice.cs:123
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
			this.MgFinding.Validate(sb);                                                                                                             // CSPropertyBase.cs:45
			this.MriFinding.Validate(sb);                                                                                                            // CSPropertyBase.cs:45
			this.NmFinding.Validate(sb);                                                                                                             // CSPropertyBase.cs:45
			this.UsFinding.Validate(sb);                                                                                                             // CSPropertyBase.cs:45
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			this.MgFinding.Write(this.Doc, this.Resource);                                                                                           // CSPropertyBase.cs:39
			this.MriFinding.Write(this.Doc, this.Resource);                                                                                          // CSPropertyBase.cs:39
			this.NmFinding.Write(this.Doc, this.Resource);                                                                                           // CSPropertyBase.cs:39
			this.UsFinding.Write(this.Doc, this.Resource);                                                                                           // CSPropertyBase.cs:39
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			this.MgFinding.Read(this.Doc, this.Resource);                                                                                            // CSPropertyBase.cs:33
			this.MriFinding.Read(this.Doc, this.Resource);                                                                                           // CSPropertyBase.cs:33
			this.NmFinding.Read(this.Doc, this.Resource);                                                                                            // CSPropertyBase.cs:33
			this.UsFinding.Read(this.Doc, this.Resource);                                                                                            // CSPropertyBase.cs:33
		}

	}
}

