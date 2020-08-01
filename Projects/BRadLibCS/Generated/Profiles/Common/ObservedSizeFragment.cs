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
	/// Interface IObservedSizeFragment.
	/// </summary>
	public interface IObservedSizeFragment 
	{
		Component<Quantity,Range> ObsSize { get; set; }                                                                                           // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface IObservedSizeFragment.
	/// </summary>
	public static class ObservedSizeFragmentExtensions
	{
		public static void Init(this IObservedSizeFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this IObservedSizeFragment fragment)
		{
		}

		public static void Write(this IObservedSizeFragment fragment)
		{
		}

		public static void Validate(this IObservedSizeFragment fragment)
		{
		}
	}
}

