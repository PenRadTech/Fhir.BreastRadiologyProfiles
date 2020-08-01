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
	/// Interface INotPreviouslySeenFragment.
	/// </summary>
	public interface INotPreviouslySeenFragment 
	{
		Component<CodeableConcept> NotPreviouslySeen { get; set; }                                                                                // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface INotPreviouslySeenFragment.
	/// </summary>
	public static class NotPreviouslySeenFragmentExtensions
	{
		public static void Init(this INotPreviouslySeenFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this INotPreviouslySeenFragment fragment)
		{
		}

		public static void Write(this INotPreviouslySeenFragment fragment)
		{
		}

		public static void Validate(this INotPreviouslySeenFragment fragment)
		{
		}
	}
}

