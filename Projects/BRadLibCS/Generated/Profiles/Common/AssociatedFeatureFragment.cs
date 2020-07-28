using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using 	BreastRadLib.NAssociatedFeatureFragment;

namespace BreastRadLib
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IAssociatedFeatureFragment.
	/// </summary>
	public interface IAssociatedFeatureFragment 
	{
		// CSItemFragment.cs:142
		/// <summary>
		/// Property for element Observation.hasMember
		/// </summary>
		NAssociatedFeatureFragment.AssociatedFeature.HasMember AssociatedFeature { get; set; }
		                                                                                                                                          // CSItemFragment.cs:146

		void AppendHasMember(ResourceReference value);                                                                                            // CSItemFragment.cs:451
	}


	namespace NAssociatedFeatureFragment
	{
		namespace AssociatedFeature
		{                                                                                                                                         // CSItemFragment.cs:550
		    /*
		    Id: Observation.hasMember
		    Cardinality 0 ... *
		    */
		    // CSItemFragment.cs:570
		    /// <summary>
		    /// This class defines the methods an properties for element Observation.hasMember
		    /// </summary>
		    public class HasMember
		    {                                                                                                                                     // CSItemFragment.cs:574
		    }                                                                                                                                     // CSItemFragment.cs:576
		                                                                                                                                          // CSItemFragment.cs:577
		    // CSItemFragment.cs:578
		    /// <summary>
		    /// This class contains the extension methods for HasMember
		    /// </summary>
		    public static class HasMemberExtensions
		    {                                                                                                                                     // CSItemFragment.cs:582
		    }                                                                                                                                     // CSItemFragment.cs:584
		}                                                                                                                                         // CSItemFragment.cs:525

	}
}

