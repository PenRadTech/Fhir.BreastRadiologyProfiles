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
	/// Interface IAssociatedFeatureFragment.
	/// </summary>
	public interface IAssociatedFeatureFragment 
	{
		HasMemberCollection<AssociatedFeature> AssociatedFeature { get; set; }                                                                    // CSPropMatchHasMemberSlice.cs:69
	}


	/// <summary>
	/// Interface IAssociatedFeatureFragment.
	/// </summary>
	public static class AssociatedFeatureFragmentExtensions
	{
		public static void Init(this IAssociatedFeatureFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		fragment.AssociatedFeature = new HasMemberCollection<AssociatedFeature>();                                                                // CSPropMatchHasMemberSlice.cs:98
		}

		public static void Read(this IAssociatedFeatureFragment fragment)
		{
		}

		public static void Write(this IAssociatedFeatureFragment fragment)
		{
		}

		public static void Validate(this IAssociatedFeatureFragment fragment)
		{
		}
	}
}

