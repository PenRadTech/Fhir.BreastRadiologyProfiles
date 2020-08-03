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
	/// Interface ITumorSatelliteFragment.
	/// </summary>
	public interface ITumorSatelliteFragment 
	{
		ObservationHasMemberCollection<TumorSatelliteProfile> TumorSatellite { get; set; }                                                        // CSHasMemberSlice.cs:90
	}


	/// <summary>
	/// Interface ITumorSatelliteFragment.
	/// </summary>
	public static class TumorSatelliteFragmentExtensions
	{

		public static void Init(this ITumorSatelliteFragment fragment)
		{
		fragment.TumorSatellite = new ObservationHasMemberCollection<TumorSatelliteProfile>();                                                    // CSHasMemberSlice.cs:128
		}

		public static void Read<T>(this ITumorSatelliteFragment fragment,
								BreastRadiologyDocument doc,
								T resource)
		    where T : DomainResource
		{
		}

		public static void Write(this ITumorSatelliteFragment fragment,
								BreastRadiologyDocument doc)
		{
		}

		public static void Validate(this ITumorSatelliteFragment fragment,
								StringBuilder sb)
		{
		}
	}
}

