using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class %ClassName%
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MassTypeCS";

		public static Coding Code_Mass = new Coding(System, "Mass", "Mass");                                                                      // CSItemCodeSystem.cs:59
		public static Coding Code_MassIntraductal = new Coding(System, "MassIntraductal", "Mass intraductal");                                    // CSItemCodeSystem.cs:59
		public static Coding Code_MassPartiallySolid = new Coding(System, "MassPartiallySolid", "Mass partially solid");                          // CSItemCodeSystem.cs:59
		public static Coding Code_MassSkinATLASIsSkinLesion = new Coding(System, "MassSkinATLASIsSkinLesion", "Mass skin ATLAS is skin lesion");  // CSItemCodeSystem.cs:59
		public static Coding Code_MassSolid = new Coding(System, "MassSolid", "Mass solid");                                                      // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_Mass;                                                                                                               // CSItemCodeSystem.cs:62
		    yield return Code_MassIntraductal;                                                                                                    // CSItemCodeSystem.cs:62
		    yield return Code_MassPartiallySolid;                                                                                                 // CSItemCodeSystem.cs:62
		    yield return Code_MassSkinATLASIsSkinLesion;                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_MassSolid;                                                                                                          // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}
