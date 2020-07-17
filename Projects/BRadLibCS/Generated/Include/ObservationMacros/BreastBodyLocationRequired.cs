using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using 	BreastRadLib.NBreastBodyLocationRequired;

namespace BreastRadLib
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IBreastBodyLocationRequired.
	/// </summary>
	public interface IBreastBodyLocationRequired 
	{
		IBodySiteLocal BodySite { get; set; }                                                                                                     // CSItemFragment.cs:101

	}


	namespace NBreastBodyLocationRequired
	{
		
		// CSItemFragment.cs:115
		/// <summary>
		/// Interface class for I{fragmentName}.{propertyName}
		/// </summary>
		public class IBodySiteLocal                                                                                                               // CSItemFragment.cs:118
		{                                                                                                                                         // CSItemFragment.cs:119
		    CodeableConcept Value { get; set;}                                                                                                    // CSItemFragment.cs:153
		}                                                                                                                                         // CSItemFragment.cs:121
		
		// CSItemFragment.cs:127
		/// <summary>
		/// Extension class for I{fragmentName}.{propertyName}
		/// </summary>
		public class BodySiteExtensions                                                                                                           // CSItemFragment.cs:130
		{                                                                                                                                         // CSItemFragment.cs:131
		}                                                                                                                                         // CSItemFragment.cs:133

	}
}

