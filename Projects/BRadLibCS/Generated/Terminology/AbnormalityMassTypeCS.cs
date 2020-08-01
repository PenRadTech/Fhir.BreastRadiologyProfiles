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
	public class AbnormalityMassTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityMassTypeCS";

		public static Coding Code_Mass = new Coding(System, "Mass", "Mass");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_MassIntraductal = new Coding(System, "MassIntraductal", "Mass intraductal");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_MassPartiallySolid = new Coding(System, "MassPartiallySolid", "Mass partially solid");                          // CSItemCodeSystem.cs:55
		public static Coding Code_MassSkinATLASIsSkinLesion = new Coding(System, "MassSkinATLASIsSkinLesion", "Mass skin ATLAS is skin lesion");  // CSItemCodeSystem.cs:55
		public static Coding Code_MassSolid = new Coding(System, "MassSolid", "Mass solid");                                                      // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_Mass;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_MassIntraductal;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_MassPartiallySolid;                                                                                                 // CSItemCodeSystem.cs:58
		    yield return Code_MassSkinATLASIsSkinLesion;                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_MassSolid;                                                                                                          // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
