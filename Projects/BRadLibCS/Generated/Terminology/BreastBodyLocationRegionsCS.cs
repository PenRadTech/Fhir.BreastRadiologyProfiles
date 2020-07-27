using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastBodyLocationRegionsCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastBodyLocationRegionsCS";

		public static Coding Code_Axilla = new Coding(System, "Axilla", "Axilla");                                                                // CSItemCodeSystem.cs:62
		public static Coding Code_AxillaryTail = new Coding(System, "AxillaryTail", "Axillary tail");                                             // CSItemCodeSystem.cs:62
		public static Coding Code_AxillaI = new Coding(System, "AxillaI", "Axilla I");                                                            // CSItemCodeSystem.cs:62
		public static Coding Code_AxillaII = new Coding(System, "AxillaII", "Axilla II");                                                         // CSItemCodeSystem.cs:62
		public static Coding Code_AxillaIII = new Coding(System, "AxillaIII", "Axilla III");                                                      // CSItemCodeSystem.cs:62
		public static Coding Code_InframammaryFold = new Coding(System, "InframammaryFold", "Inframammary fold");                                 // CSItemCodeSystem.cs:62
		public static Coding Code_InSkin = new Coding(System, "InSkin", "In skin");                                                               // CSItemCodeSystem.cs:62
		public static Coding Code_CentralToNipple = new Coding(System, "CentralToNipple", "Central to nipple");                                   // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_Axilla;                                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_AxillaryTail;                                                                                                       // CSItemCodeSystem.cs:65
		    yield return Code_AxillaI;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_AxillaII;                                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_AxillaIII;                                                                                                          // CSItemCodeSystem.cs:65
		    yield return Code_InframammaryFold;                                                                                                   // CSItemCodeSystem.cs:65
		    yield return Code_InSkin;                                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_CentralToNipple;                                                                                                    // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
