using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

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
		CodeableConcept BodySite { get; set; }                                                                                                    // CSItemFragment.cs:192
		List<Extension> Extension { get; set; }                                                                                                   // CSItemFragment.cs:192
	}


	/// <summary>
	/// ExtensionClass for interface IBreastBodyLocationRequired.
	/// </summary>
	public static class BreastBodyLocationRequiredExtensions
	{

		public static void GetBodySite(this IBreastBodyLocationRequired t, out CodeableConcept value)                                             // CSItemFragment.cs:206
		{                                                                                                                                         // CSItemFragment.cs:207
		    value = t.BodySite as CodeableConcept;                                                                                                // CSItemFragment.cs:208
		}                                                                                                                                         // CSItemFragment.cs:209
		public static void SetBodySite(this IBreastBodyLocationRequired t, CodeableConcept value)                                                 // CSItemFragment.cs:210
		{                                                                                                                                         // CSItemFragment.cs:211
		    t.BodySite = value;                                                                                                                   // CSItemFragment.cs:212
		}                                                                                                                                         // CSItemFragment.cs:213
	}
}
