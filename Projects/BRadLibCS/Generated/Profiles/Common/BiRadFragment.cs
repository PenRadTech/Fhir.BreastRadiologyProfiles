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
	/// Interface IBiRadFragment.
	/// </summary>
	public interface IBiRadFragment 
	{
		Component<CodeableConcept> BiRadsAssessmentCategory { get; set; }                                                                         // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface IBiRadFragment.
	/// </summary>
	public static class BiRadFragmentExtensions
	{
		public static void Init(this IBiRadFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this IBiRadFragment fragment)
		{
		}

		public static void Write(this IBiRadFragment fragment)
		{
		}

		public static void Validate(this IBiRadFragment fragment)
		{
		}
	}
}

