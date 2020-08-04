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
		public FindingsLeftBreastProfile() : base()
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
		public override void Write(BreastRadiologyDocument doc)
		{
			base.Write(doc);
			this.MgFinding.Write(doc);                                                                                                               // CSHasMemberSlice.cs:123
			this.MriFinding.Write(doc);                                                                                                              // CSHasMemberSlice.cs:123
			this.NmFinding.Write(doc);                                                                                                               // CSHasMemberSlice.cs:123
			this.UsFinding.Write(doc);                                                                                                               // CSHasMemberSlice.cs:123
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read<Observation>(BreastRadiologyDocument doc,
							      Observation resource)
		{
			base.Read(doc, resource);
			this.MgFinding.Read(doc, resource);                                                                                                      // CSHasMemberSlice.cs:117
			this.MriFinding.Read(doc, resource);                                                                                                     // CSHasMemberSlice.cs:117
			this.NmFinding.Read(doc, resource);                                                                                                      // CSHasMemberSlice.cs:117
			this.UsFinding.Read(doc, resource);                                                                                                      // CSHasMemberSlice.cs:117
		}

	}
}

