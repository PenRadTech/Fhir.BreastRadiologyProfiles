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

		public static TCoding Code_BBPellet = new TCoding(AbnormalityForeignObjectTypeCS.Code_BBPellet);                                          // CSItemValueSet.cs:72
		public static TCoding Code_BBPellets = new TCoding(AbnormalityForeignObjectTypeCS.Code_BBPellets);                                        // CSItemValueSet.cs:72
		public static TCoding Code_BiopsyClip = new TCoding(AbnormalityForeignObjectTypeCS.Code_BiopsyClip);                                      // CSItemValueSet.cs:72
		public static TCoding Code_BiopsyClips = new TCoding(AbnormalityForeignObjectTypeCS.Code_BiopsyClips);                                    // CSItemValueSet.cs:72
		public static TCoding Code_BreastMarker = new TCoding(AbnormalityForeignObjectTypeCS.Code_BreastMarker);                                  // CSItemValueSet.cs:72
		public static TCoding Code_CatheterSleeves = new TCoding(AbnormalityForeignObjectTypeCS.Code_CatheterSleeves);                            // CSItemValueSet.cs:72
		public static TCoding Code_ChemotherapyPort = new TCoding(AbnormalityForeignObjectTypeCS.Code_ChemotherapyPort);                          // CSItemValueSet.cs:72
		public static TCoding Code_Coil = new TCoding(AbnormalityForeignObjectTypeCS.Code_Coil);                                                  // CSItemValueSet.cs:72
		public static TCoding Code_Glass = new TCoding(AbnormalityForeignObjectTypeCS.Code_Glass);                                                // CSItemValueSet.cs:72
		public static TCoding Code_GoldSeed = new TCoding(AbnormalityForeignObjectTypeCS.Code_GoldSeed);                                          // CSItemValueSet.cs:72
		public static TCoding Code_GunshotWound = new TCoding(AbnormalityForeignObjectTypeCS.Code_GunshotWound);                                  // CSItemValueSet.cs:72
		public static TCoding Code_MarkerClip = new TCoding(AbnormalityForeignObjectTypeCS.Code_MarkerClip);                                      // CSItemValueSet.cs:72
		public static TCoding Code_Metal = new TCoding(AbnormalityForeignObjectTypeCS.Code_Metal);                                                // CSItemValueSet.cs:72
		public static TCoding Code_MetallicMarker = new TCoding(AbnormalityForeignObjectTypeCS.Code_MetallicMarker);                              // CSItemValueSet.cs:72
		public static TCoding Code_MetallicMarkers = new TCoding(AbnormalityForeignObjectTypeCS.Code_MetallicMarkers);                            // CSItemValueSet.cs:72
		public static TCoding Code_MetallicObjects = new TCoding(AbnormalityForeignObjectTypeCS.Code_MetallicObjects);                            // CSItemValueSet.cs:72
		public static TCoding Code_Needle = new TCoding(AbnormalityForeignObjectTypeCS.Code_Needle);                                              // CSItemValueSet.cs:72
		public static TCoding Code_NippleJewelry = new TCoding(AbnormalityForeignObjectTypeCS.Code_NippleJewelry);                                // CSItemValueSet.cs:72
		public static TCoding Code_NonMetallicBody = new TCoding(AbnormalityForeignObjectTypeCS.Code_NonMetallicBody);                            // CSItemValueSet.cs:72
		public static TCoding Code_Pacemaker = new TCoding(AbnormalityForeignObjectTypeCS.Code_Pacemaker);                                        // CSItemValueSet.cs:72
		public static TCoding Code_SiliconeGranuloma = new TCoding(AbnormalityForeignObjectTypeCS.Code_SiliconeGranuloma);                        // CSItemValueSet.cs:72
		public static TCoding Code_Sponge = new TCoding(AbnormalityForeignObjectTypeCS.Code_Sponge);                                              // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalClip = new TCoding(AbnormalityForeignObjectTypeCS.Code_SurgicalClip);                                  // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalClips = new TCoding(AbnormalityForeignObjectTypeCS.Code_SurgicalClips);                                // CSItemValueSet.cs:72
		public static TCoding Code_Swab = new TCoding(AbnormalityForeignObjectTypeCS.Code_Swab);                                                  // CSItemValueSet.cs:72
		public static TCoding Code_TitaniumClip = new TCoding(AbnormalityForeignObjectTypeCS.Code_TitaniumClip);                                  // CSItemValueSet.cs:72
		public static TCoding Code_TitaniumClips = new TCoding(AbnormalityForeignObjectTypeCS.Code_TitaniumClips);                                // CSItemValueSet.cs:72
		public static TCoding Code_Wire = new TCoding(AbnormalityForeignObjectTypeCS.Code_Wire);                                                  // CSItemValueSet.cs:72
		public static TCoding Code_WireFragment = new TCoding(AbnormalityForeignObjectTypeCS.Code_WireFragment);                                  // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_BBPellet;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_BBPellets;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_BiopsyClip;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_BiopsyClips;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_BreastMarker;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_CatheterSleeves;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_ChemotherapyPort;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Coil;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_Glass;                                                                                                              // CSItemValueSet.cs:83
		    yield return Code_GoldSeed;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_GunshotWound;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_MarkerClip;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_Metal;                                                                                                              // CSItemValueSet.cs:83
		    yield return Code_MetallicMarker;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_MetallicMarkers;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_MetallicObjects;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_Needle;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_NippleJewelry;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_NonMetallicBody;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_Pacemaker;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_SiliconeGranuloma;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_Sponge;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_SurgicalClip;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_SurgicalClips;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_Swab;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_TitaniumClip;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_TitaniumClips;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_Wire;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_WireFragment;                                                                                                       // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
