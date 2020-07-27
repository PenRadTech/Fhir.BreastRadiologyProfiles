using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using 	BreastRadLib.NAbnormalityForeignObject;

namespace BreastRadLib
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IAbnormalityForeignObject.
	/// </summary>
	public interface IAbnormalityForeignObject  : IBreastBodyLocationRequiredFragment, IObservedChangesFragment, IBiRadFragment, INotPreviouslySeenFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeatureFragment, IConsistentWithFragment
	{

	}

	/// <summary>
	/// class CAbnormalityForeignObject.
	/// </summary>
	public interface CAbnormalityForeignObject :  IAbnormalityForeignObject
	{

	}


	namespace NAbnormalityForeignObject
	{

	}
}

