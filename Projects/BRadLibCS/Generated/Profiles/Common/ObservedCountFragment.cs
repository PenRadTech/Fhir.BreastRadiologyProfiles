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
	/// Interface IObservedCountFragment.
	/// </summary>
	public interface IObservedCountFragment 
	{
		Component<Quantity,Range> ObservedCount { get; set; }                                                                                     // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface IObservedCountFragment.
	/// </summary>
	public static class ObservedCountFragmentExtensions
	{
		public static void Init(this IObservedCountFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this IObservedCountFragment fragment)
		{
		}

		public static void Write(this IObservedCountFragment fragment)
		{
		}

		public static void Validate(this IObservedCountFragment fragment)
		{
		}
	}
}

