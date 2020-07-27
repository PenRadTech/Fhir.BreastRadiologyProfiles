using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using 	BreastRadLib.NBreastRadiologyDocument;

namespace BreastRadLib
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IBreastRadiologyDocument.
	/// </summary>
	public interface IBreastRadiologyDocument 
	{

	}

	/// <summary>
	/// class BreastRadiologyDocument.
	/// </summary>
	public partial class BreastRadiologyDocument :  BundleBase, IBreastRadiologyDocument
	{

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public BreastRadiologyDocument() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public BreastRadiologyDocument(BreastRadiologyDocument doc, Bundle resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public BreastRadiologyDocument(BreastRadiologyDocument doc)
		{
			this.Init(doc, new Bundle());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			Bundle resource = (Bundle) baseResource;
			if (resource == null)
				resource = new Bundle();
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


	namespace NBreastRadiologyDocument
	{

	}
}

