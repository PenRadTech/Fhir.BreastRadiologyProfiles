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
	/// Interface IObservedChangesFragment.
	/// </summary>
	public interface IObservedChangesFragment 
	{
		Component<CodeableConcept> ObsChanges { get; set; }                                                                                       // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface IObservedChangesFragment.
	/// </summary>
	public static class ObservedChangesFragmentExtensions
	{
		public static void Init(this IObservedChangesFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this IObservedChangesFragment fragment)
		{
		}

		public static void Write(this IObservedChangesFragment fragment)
		{
		}

		public static void Validate(this IObservedChangesFragment fragment)
		{
		}
	}
}

