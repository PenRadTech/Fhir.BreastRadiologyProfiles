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
	/// Interface IPreviouslyDemonstratedByFragment.
	/// </summary>
	public interface IPreviouslyDemonstratedByFragment 
	{
		Component<CodeableConcept> PrevDemBy { get; set; }                                                                                        // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface IPreviouslyDemonstratedByFragment.
	/// </summary>
	public static class PreviouslyDemonstratedByFragmentExtensions
	{
		public static void Init(this IPreviouslyDemonstratedByFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this IPreviouslyDemonstratedByFragment fragment)
		{
		}

		public static void Write(this IPreviouslyDemonstratedByFragment fragment)
		{
		}

		public static void Validate(this IPreviouslyDemonstratedByFragment fragment)
		{
		}
	}
}

