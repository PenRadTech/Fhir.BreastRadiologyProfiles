using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AssociatedFeatureCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS";

		public static Coding Code_ArchitecturalDistortion = new Coding(System, "ArchitecturalDistortion", "Architectural distortion");            // CSItemCodeSystem.cs:62
		public static Coding Code_AxillaryAdenopathy = new Coding(System, "AxillaryAdenopathy", "Axillary adenopathy");                           // CSItemCodeSystem.cs:62
		public static Coding Code_BiopsyClip = new Coding(System, "BiopsyClip", "Biopsy clip");                                                   // CSItemCodeSystem.cs:62
		public static Coding Code_BrachytherapyTube = new Coding(System, "BrachytherapyTube", "Brachytherapy tube");                              // CSItemCodeSystem.cs:62
		public static Coding Code_ChestWallInvasion = new Coding(System, "ChestWallInvasion", "Chest wall invasion");                             // CSItemCodeSystem.cs:62
		public static Coding Code_CooperDistorted = new Coding(System, "CooperDistorted", "Cooper distorted");                                    // CSItemCodeSystem.cs:62
		public static Coding Code_CooperThickened = new Coding(System, "CooperThickened", "Cooper thickened");                                    // CSItemCodeSystem.cs:62
		public static Coding Code_Edema = new Coding(System, "Edema", "Edema");                                                                   // CSItemCodeSystem.cs:62
		public static Coding Code_EdemaAdj = new Coding(System, "EdemaAdj", "Edema adj");                                                         // CSItemCodeSystem.cs:62
		public static Coding Code_GoldSeed = new Coding(System, "GoldSeed", "Gold Seed");                                                         // CSItemCodeSystem.cs:62
		public static Coding Code_Hematoma = new Coding(System, "Hematoma", "Hematoma");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_NippleRetraction = new Coding(System, "NippleRetraction", "Nipple retraction");                                 // CSItemCodeSystem.cs:62
		public static Coding Code_NOChestWallInvasion = new Coding(System, "NOChestWallInvasion", "NO Chest wall invasion");                      // CSItemCodeSystem.cs:62
		public static Coding Code_PectoralisMuscleInvasion = new Coding(System, "PectoralisMuscleInvasion", "Pectoralis muscle invasion");        // CSItemCodeSystem.cs:62
		public static Coding Code_PectoralisMuscleInvolvement = new Coding(System, "PectoralisMuscleInvolvement", "Pectoralis muscle involvement");// CSItemCodeSystem.cs:62
		public static Coding Code_PectoralisMuscleTenting = new Coding(System, "PectoralisMuscleTenting", "Pectoralis muscle tenting");           // CSItemCodeSystem.cs:62
		public static Coding Code_PostSurgicalScar = new Coding(System, "PostSurgicalScar", "Post surgical scar");                                // CSItemCodeSystem.cs:62
		public static Coding Code_Seroma = new Coding(System, "Seroma", "Seroma");                                                                // CSItemCodeSystem.cs:62
		public static Coding Code_SkinInvolvement = new Coding(System, "SkinInvolvement", "Skin involvement");                                    // CSItemCodeSystem.cs:62
		public static Coding Code_SkinLesion = new Coding(System, "SkinLesion", "Skin lesion");                                                   // CSItemCodeSystem.cs:62
		public static Coding Code_SkinRetraction = new Coding(System, "SkinRetraction", "Skin retraction");                                       // CSItemCodeSystem.cs:62
		public static Coding Code_SkinThickening = new Coding(System, "SkinThickening", "Skin thickening");                                       // CSItemCodeSystem.cs:62
		public static Coding Code_SurgicalClip = new Coding(System, "SurgicalClip", "Surgical clip");                                             // CSItemCodeSystem.cs:62
		public static Coding Code_TrabecularThickening = new Coding(System, "TrabecularThickening", "Trabecular thickening");                     // CSItemCodeSystem.cs:62
		public static Coding Code_CalcificationInMass = new Coding(System, "CalcificationInMass", "Calcification in mass");                       // CSItemCodeSystem.cs:62
		public static Coding Code_CalcificationNotOnMammogarm = new Coding(System, "CalcificationNotOnMammogarm", "Calcification Not on mammogarm");// CSItemCodeSystem.cs:62
		public static Coding Code_CalcificationOnMammogram = new Coding(System, "CalcificationOnMammogram", "Calcification on mammogram");        // CSItemCodeSystem.cs:62
		public static Coding Code_Calcifications = new Coding(System, "Calcifications", "Calcifications");                                        // CSItemCodeSystem.cs:62
		public static Coding Code_MicroCalcifications = new Coding(System, "MicroCalcifications", "Micro calcifications");                        // CSItemCodeSystem.cs:62
		public static Coding Code_MilkOfCalcium = new Coding(System, "MilkOfCalcium", "Milk of calcium");                                         // CSItemCodeSystem.cs:62
		public static Coding Code_RimCalcifications = new Coding(System, "RimCalcifications", "Rim calcifications");                              // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_ArchitecturalDistortion;                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_AxillaryAdenopathy;                                                                                                 // CSItemCodeSystem.cs:65
		    yield return Code_BiopsyClip;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_BrachytherapyTube;                                                                                                  // CSItemCodeSystem.cs:65
		    yield return Code_ChestWallInvasion;                                                                                                  // CSItemCodeSystem.cs:65
		    yield return Code_CooperDistorted;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_CooperThickened;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_Edema;                                                                                                              // CSItemCodeSystem.cs:65
		    yield return Code_EdemaAdj;                                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_GoldSeed;                                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_Hematoma;                                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_NippleRetraction;                                                                                                   // CSItemCodeSystem.cs:65
		    yield return Code_NOChestWallInvasion;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_PectoralisMuscleInvasion;                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_PectoralisMuscleInvolvement;                                                                                        // CSItemCodeSystem.cs:65
		    yield return Code_PectoralisMuscleTenting;                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_PostSurgicalScar;                                                                                                   // CSItemCodeSystem.cs:65
		    yield return Code_Seroma;                                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_SkinInvolvement;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_SkinLesion;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_SkinRetraction;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_SkinThickening;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_SurgicalClip;                                                                                                       // CSItemCodeSystem.cs:65
		    yield return Code_TrabecularThickening;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_CalcificationInMass;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_CalcificationNotOnMammogarm;                                                                                        // CSItemCodeSystem.cs:65
		    yield return Code_CalcificationOnMammogram;                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_Calcifications;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_MicroCalcifications;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_RimCalcifications;                                                                                                  // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}
