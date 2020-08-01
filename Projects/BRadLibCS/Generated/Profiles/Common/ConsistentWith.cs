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
	/// Interface IConsistentWith.
	/// </summary>
	public interface IConsistentWith 
	{
		Component<CodeableConcept> ConsistentWith { get; set; }                                                                                   // CSComponentSlice.cs:103
		Component<CodeableConcept> Qualifier { get; set; }                                                                                        // CSComponentSlice.cs:103

	}

	/// <summary>
	/// class ConsistentWith.
	/// </summary>
	public partial class ConsistentWith :  ObservationBase, IConsistentWith
	{
		public Component<CodeableConcept> ConsistentWith { get; set; }                                                                            // CSComponentSlice.cs:103
		public Component<CodeableConcept> Qualifier { get; set; }                                                                                 // CSComponentSlice.cs:103

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public ConsistentWith() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public ConsistentWith(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public ConsistentWith(BreastRadiologyDocument doc)
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

