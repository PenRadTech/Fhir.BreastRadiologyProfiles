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
	/// Interface IAssociatedFeatureFragment.
	/// </summary>
	public interface IAssociatedFeatureFragment 
	{
		ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                                  // CSHasMemberSlice.cs:91
	}


	/// <summary>
	/// Interface IAssociatedFeatureFragment.
	/// </summary>
	public static class AssociatedFeatureFragmentExtensions
	{

		public static void Init(this IAssociatedFeatureFragment fragment)
		{
		fragment.AssociatedFeature = new ObservationHasMemberCollection<AssociatedFeatureProfile>();                                              // CSHasMemberSlice.cs:129
		}

		public static void Read(this IAssociatedFeatureFragment fragment, BreastRadiologyDocument doc)
		{
		}

		public static void Write(this IAssociatedFeatureFragment fragment, BreastRadiologyDocument doc)
		{
		}

		public static void Validate(this IAssociatedFeatureFragment fragment,
								StringBuilder sb)
		{
		}
	}
}

