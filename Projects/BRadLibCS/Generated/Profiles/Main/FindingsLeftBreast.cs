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
	/// Interface IFindingsLeftBreast.
	/// </summary>
	public interface IFindingsLeftBreast 
	{
		ComponentHasMember<MGFinding> MgFinding { get; set; }                                                                                     // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<MRIFinding> MriFinding { get; set; }                                                                                   // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<NMFinding> NmFinding { get; set; }                                                                                     // CSPropMatchHasMemberSlice.cs:43
		ComponentHasMember<USFinding> UsFinding { get; set; }                                                                                     // CSPropMatchHasMemberSlice.cs:43

	}

	/// <summary>
	/// class FindingsLeftBreast.
	/// </summary>
	public partial class FindingsLeftBreast :  ObservationBase, IFindingsLeftBreast
	{
		public ComponentHasMember<MGFinding> MgFinding { get; set; }                                                                              // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<MRIFinding> MriFinding { get; set; }                                                                            // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<NMFinding> NmFinding { get; set; }                                                                              // CSPropMatchHasMemberSlice.cs:53
		public ComponentHasMember<USFinding> UsFinding { get; set; }                                                                              // CSPropMatchHasMemberSlice.cs:53

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public FindingsLeftBreast() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public FindingsLeftBreast(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public FindingsLeftBreast(BreastRadiologyDocument doc)
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

