using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class AbnormalityFibroadenomaTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityFibroadenomaTypeCS";

		public static Coding Code_Fibroadenoma = new Coding(System, "Fibroadenoma", "Fibroadenoma");                                              // CSItemCodeSystem.cs:62
		public static Coding Code_FibroadenomaDegeneration = new Coding(System, "FibroadenomaDegeneration", "Fibroadenoma degeneration");         // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_Fibroadenoma;                                                                                                       // CSItemCodeSystem.cs:65
		    yield return Code_FibroadenomaDegeneration;                                                                                           // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
