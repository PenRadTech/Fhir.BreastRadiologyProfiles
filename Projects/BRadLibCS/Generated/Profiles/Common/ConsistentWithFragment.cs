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
	/// Interface IConsistentWithFragment.
	/// </summary>
	public interface IConsistentWithFragment 
	{
		HasMemberCollection<ConsistentWith> ConsistentWith { get; set; }                                                                          // CSPropMatchHasMemberSlice.cs:69
	}


	/// <summary>
	/// Interface IConsistentWithFragment.
	/// </summary>
	public static class ConsistentWithFragmentExtensions
	{
		public static void Init(this IConsistentWithFragment fragment, BreastRadiologyDocument doc, Base baseResource = null)
		{
		fragment.ConsistentWith = new HasMemberCollection<ConsistentWith>();                                                                      // CSPropMatchHasMemberSlice.cs:98
		}

		public static void Read(this IConsistentWithFragment fragment)
		{
		}

		public static void Write(this IConsistentWithFragment fragment)
		{
		}

		public static void Validate(this IConsistentWithFragment fragment)
		{
		}
	}
}

