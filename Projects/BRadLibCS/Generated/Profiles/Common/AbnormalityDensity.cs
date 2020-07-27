using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using 	BreastRadLib.NAbnormalityDensity;

namespace BreastRadLib
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IAbnormalityDensity.
	/// </summary>
	public interface IAbnormalityDensity  : IBreastBodyLocationRequiredFragment, IObservedChangesFragment, IBiRadFragment, IShapeFragment, INotPreviouslySeenFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeatureFragment, IConsistentWithFragment
	{

	}

	/// <summary>
	/// class CAbnormalityDensity.
	/// </summary>
	public interface CAbnormalityDensity :  IAbnormalityDensity
	{

	}


	namespace NAbnormalityDensity
	{

	}
}

