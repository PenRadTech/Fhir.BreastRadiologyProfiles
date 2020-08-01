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
	/// Interface ITumorSatelliteFragment.
	/// </summary>
	public interface ITumorSatelliteFragment 
	{
		HasMemberCollection<TumorSatellite> TumorSatellite { get; set; }                                                                          // CSHasMemberSlice.cs:77
	}


	/// <summary>
	/// Interface ITumorSatelliteFragment.
	/// </summary>
	public static class TumorSatelliteFragmentExtensions
	{
		public static void Init(this ITumorSatelliteFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		fragment.TumorSatellite = new HasMemberCollection<TumorSatellite>();                                                                      // CSHasMemberSlice.cs:106
		}

		public static void Read(this ITumorSatelliteFragment fragment)
		{
		}

		public static void Write(this ITumorSatelliteFragment fragment)
		{
		}

		public static void Validate(this ITumorSatelliteFragment fragment)
		{
		}
	}
}

