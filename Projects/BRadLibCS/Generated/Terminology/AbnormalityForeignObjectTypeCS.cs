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
	public class AbnormalityForeignObjectTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS";

		public static Coding Code_BBPellet = new Coding(System, "BBPellet", "BB pellet");                                                         // CSItemCodeSystem.cs:55
		public static Coding Code_BBPellets = new Coding(System, "BBPellets", "BB pellets");                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_BiopsyClip = new Coding(System, "BiopsyClip", "Biopsy clip");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_BiopsyClips = new Coding(System, "BiopsyClips", "Biopsy clips");                                                // CSItemCodeSystem.cs:55
		public static Coding Code_BreastMarker = new Coding(System, "BreastMarker", "Breast Marker");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_CatheterSleeves = new Coding(System, "CatheterSleeves", "Catheter sleeves");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_ChemotherapyPort = new Coding(System, "ChemotherapyPort", "Chemotherapy port");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_Coil = new Coding(System, "Coil", "Coil");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_Glass = new Coding(System, "Glass", "Glass");                                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_GoldSeed = new Coding(System, "GoldSeed", "Gold seed");                                                         // CSItemCodeSystem.cs:55
		public static Coding Code_GunshotWound = new Coding(System, "GunshotWound", "Gunshot wound");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_MarkerClip = new Coding(System, "MarkerClip", "Marker clip");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_Metal = new Coding(System, "Metal", "Metal");                                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_MetallicMarker = new Coding(System, "MetallicMarker", "Metallic marker");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_MetallicMarkers = new Coding(System, "MetallicMarkers", "Metallic markers");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_MetallicObjects = new Coding(System, "MetallicObjects", "Metallic objects");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_Needle = new Coding(System, "Needle", "Needle");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_NippleJewelry = new Coding(System, "NippleJewelry", "Nipple jewelry");                                          // CSItemCodeSystem.cs:55
		public static Coding Code_NonMetallicBody = new Coding(System, "Non-metallicBody", "Non-metallic body");                                  // CSItemCodeSystem.cs:55
		public static Coding Code_Pacemaker = new Coding(System, "Pacemaker", "Pacemaker");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_SiliconeGranuloma = new Coding(System, "SiliconeGranuloma", "Silicone granuloma");                              // CSItemCodeSystem.cs:55
		public static Coding Code_Sponge = new Coding(System, "Sponge", "Sponge");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_SurgicalClip = new Coding(System, "SurgicalClip", "Surgical clip");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_SurgicalClips = new Coding(System, "SurgicalClips", "Surgical clips");                                          // CSItemCodeSystem.cs:55
		public static Coding Code_Swab = new Coding(System, "Swab", "Swab");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_TitaniumClip = new Coding(System, "TitaniumClip", "Titanium clip");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_TitaniumClips = new Coding(System, "TitaniumClips", "Titanium clips");                                          // CSItemCodeSystem.cs:55
		public static Coding Code_Wire = new Coding(System, "Wire", "Wire");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_WireFragment = new Coding(System, "WireFragment", "Wire fragment");                                             // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_BBPellet;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_BBPellets;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_BiopsyClip;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_BiopsyClips;                                                                                                        // CSItemCodeSystem.cs:58
		    yield return Code_BreastMarker;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_CatheterSleeves;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_ChemotherapyPort;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_Coil;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_Glass;                                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_GoldSeed;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_GunshotWound;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_MarkerClip;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_Metal;                                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_MetallicMarker;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_MetallicMarkers;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_MetallicObjects;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_Needle;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_NippleJewelry;                                                                                                      // CSItemCodeSystem.cs:58
		    yield return Code_NonMetallicBody;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_Pacemaker;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_SiliconeGranuloma;                                                                                                  // CSItemCodeSystem.cs:58
		    yield return Code_Sponge;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_SurgicalClip;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_SurgicalClips;                                                                                                      // CSItemCodeSystem.cs:58
		    yield return Code_Swab;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_TitaniumClip;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_TitaniumClips;                                                                                                      // CSItemCodeSystem.cs:58
		    yield return Code_Wire;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_WireFragment;                                                                                                       // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
