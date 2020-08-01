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
	/// Interface IShapeFragment.
	/// </summary>
	public interface IShapeFragment 
	{
		Component<CodeableConcept> Orientation { get; set; }                                                                                      // CSComponentSlice.cs:103
		Component<CodeableConcept> Shape { get; set; }                                                                                            // CSComponentSlice.cs:103
		Component<CodeableConcept> Margin { get; set; }                                                                                           // CSComponentSlice.cs:103
		Component<CodeableConcept> MgBreastDensity { get; set; }                                                                                  // CSComponentSlice.cs:103
	}


	/// <summary>
	/// Interface IShapeFragment.
	/// </summary>
	public static class ShapeFragmentExtensions
	{
		public static void Init(this IShapeFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		}

		public static void Read(this IShapeFragment fragment)
		{
		}

		public static void Write(this IShapeFragment fragment)
		{
		}

		public static void Validate(this IShapeFragment fragment)
		{
		}
	}
}

