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
	/// Interface IObservedDistributionFragment.
	/// </summary>
	public interface IObservedDistributionFragment 
	{
		Component<CodeableConcept> ObsDistribution { get; set; }                                                                                  // CSComponentSlice.cs:103
		Component<Quantity,Range> ObsDistRegionSize { get; set; }                                                                                 // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface IObservedDistributionFragment.
	/// </summary>
	public static class ObservedDistributionFragmentExtensions
	{
		public static void Init(this IObservedDistributionFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this IObservedDistributionFragment fragment)
		{
		}

		public static void Write(this IObservedDistributionFragment fragment)
		{
		}

		public static void Validate(this IObservedDistributionFragment fragment)
		{
		}
	}
}

