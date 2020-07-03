using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityForeignObjectTypeVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		/// <summary>
		/// Url of this value set.
		/// </summary>
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/AbnormalityForeignObjectTypeVS";

		public static TCoding Code_BBPellet = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "BBPellet"));// CSItemValueSet.cs:67
		public static TCoding Code_BBPellets = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "BBPellets"));// CSItemValueSet.cs:67
		public static TCoding Code_BiopsyClip = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "BiopsyClip"));// CSItemValueSet.cs:67
		public static TCoding Code_BiopsyClips = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "BiopsyClips"));// CSItemValueSet.cs:67
		public static TCoding Code_BreastMarker = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "BreastMarker"));// CSItemValueSet.cs:67
		public static TCoding Code_CatheterSleeves = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "CatheterSleeves"));// CSItemValueSet.cs:67
		public static TCoding Code_ChemotherapyPort = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "ChemotherapyPort"));// CSItemValueSet.cs:67
		public static TCoding Code_Coil = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Coil"));// CSItemValueSet.cs:67
		public static TCoding Code_Glass = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Glass"));// CSItemValueSet.cs:67
		public static TCoding Code_GoldSeed = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "GoldSeed"));// CSItemValueSet.cs:67
		public static TCoding Code_GunshotWound = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "GunshotWound"));// CSItemValueSet.cs:67
		public static TCoding Code_MarkerClip = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "MarkerClip"));// CSItemValueSet.cs:67
		public static TCoding Code_Metal = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Metal"));// CSItemValueSet.cs:67
		public static TCoding Code_MetallicMarker = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "MetallicMarker"));// CSItemValueSet.cs:67
		public static TCoding Code_MetallicMarkers = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "MetallicMarkers"));// CSItemValueSet.cs:67
		public static TCoding Code_MetallicObjects = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "MetallicObjects"));// CSItemValueSet.cs:67
		public static TCoding Code_Needle = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Needle"));// CSItemValueSet.cs:67
		public static TCoding Code_NippleJewelry = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "NippleJewelry"));// CSItemValueSet.cs:67
		public static TCoding Code_NonMetallicBody = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Non-metallicBody"));// CSItemValueSet.cs:67
		public static TCoding Code_Pacemaker = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Pacemaker"));// CSItemValueSet.cs:67
		public static TCoding Code_SiliconeGranuloma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "SiliconeGranuloma"));// CSItemValueSet.cs:67
		public static TCoding Code_Sponge = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Sponge"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalClip = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "SurgicalClip"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalClips = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "SurgicalClips"));// CSItemValueSet.cs:67
		public static TCoding Code_Swab = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Swab"));// CSItemValueSet.cs:67
		public static TCoding Code_TitaniumClip = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "TitaniumClip"));// CSItemValueSet.cs:67
		public static TCoding Code_TitaniumClips = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "TitaniumClips"));// CSItemValueSet.cs:67
		public static TCoding Code_Wire = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "Wire"));// CSItemValueSet.cs:67
		public static TCoding Code_WireFragment = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityForeignObjectTypeCS", "WireFragment"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_BBPellet;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_BBPellets;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_BiopsyClip;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_BiopsyClips;                                                                                                        // CSItemValueSet.cs:70
		    yield return Code_BreastMarker;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_CatheterSleeves;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_ChemotherapyPort;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_Coil;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_Glass;                                                                                                              // CSItemValueSet.cs:70
		    yield return Code_GoldSeed;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_GunshotWound;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_MarkerClip;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_Metal;                                                                                                              // CSItemValueSet.cs:70
		    yield return Code_MetallicMarker;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_MetallicMarkers;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_MetallicObjects;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_Needle;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_NippleJewelry;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_NonMetallicBody;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_Pacemaker;                                                                                                          // CSItemValueSet.cs:70
		    yield return Code_SiliconeGranuloma;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_Sponge;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_SurgicalClip;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_SurgicalClips;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_Swab;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_TitaniumClip;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_TitaniumClips;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_Wire;                                                                                                               // CSItemValueSet.cs:70
		    yield return Code_WireFragment;                                                                                                       // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
