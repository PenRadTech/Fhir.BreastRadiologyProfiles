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
	/// Interface ICorrespondsWithFragment.
	/// </summary>
	public interface ICorrespondsWithFragment 
	{
		Component<CodeableConcept> CorrespondsWith { get; set; }                                                                                  // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface ICorrespondsWithFragment.
	/// </summary>
	public static class CorrespondsWithFragmentExtensions
	{
		public static void Init(this ICorrespondsWithFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this ICorrespondsWithFragment fragment)
		{
		}

		public static void Write(this ICorrespondsWithFragment fragment)
		{
		}

		public static void Validate(this ICorrespondsWithFragment fragment)
		{
		}
	}
}

