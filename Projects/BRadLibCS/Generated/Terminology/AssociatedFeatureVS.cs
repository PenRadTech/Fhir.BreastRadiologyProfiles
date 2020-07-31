using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class AssociatedFeatureVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/AssociatedFeatureVS";

		public static TCoding Code_ArchitecturalDistortion = new TCoding(AssociatedFeatureCS.Code_ArchitecturalDistortion);                       // CSItemValueSet.cs:72
		public static TCoding Code_AxillaryAdenopathy = new TCoding(AssociatedFeatureCS.Code_AxillaryAdenopathy);                                 // CSItemValueSet.cs:72
		public static TCoding Code_BiopsyClip = new TCoding(AssociatedFeatureCS.Code_BiopsyClip);                                                 // CSItemValueSet.cs:72
		public static TCoding Code_BrachytherapyTube = new TCoding(AssociatedFeatureCS.Code_BrachytherapyTube);                                   // CSItemValueSet.cs:72
		public static TCoding Code_ChestWallInvasion = new TCoding(AssociatedFeatureCS.Code_ChestWallInvasion);                                   // CSItemValueSet.cs:72
		public static TCoding Code_CooperDistorted = new TCoding(AssociatedFeatureCS.Code_CooperDistorted);                                       // CSItemValueSet.cs:72
		public static TCoding Code_CooperThickened = new TCoding(AssociatedFeatureCS.Code_CooperThickened);                                       // CSItemValueSet.cs:72
		public static TCoding Code_Edema = new TCoding(AssociatedFeatureCS.Code_Edema);                                                           // CSItemValueSet.cs:72
		public static TCoding Code_EdemaAdj = new TCoding(AssociatedFeatureCS.Code_EdemaAdj);                                                     // CSItemValueSet.cs:72
		public static TCoding Code_GoldSeed = new TCoding(AssociatedFeatureCS.Code_GoldSeed);                                                     // CSItemValueSet.cs:72
		public static TCoding Code_Hematoma = new TCoding(AssociatedFeatureCS.Code_Hematoma);                                                     // CSItemValueSet.cs:72
		public static TCoding Code_NippleRetraction = new TCoding(AssociatedFeatureCS.Code_NippleRetraction);                                     // CSItemValueSet.cs:72
		public static TCoding Code_NOChestWallInvasion = new TCoding(AssociatedFeatureCS.Code_NOChestWallInvasion);                               // CSItemValueSet.cs:72
		public static TCoding Code_PectoralisMuscleInvasion = new TCoding(AssociatedFeatureCS.Code_PectoralisMuscleInvasion);                     // CSItemValueSet.cs:72
		public static TCoding Code_PectoralisMuscleInvolvement = new TCoding(AssociatedFeatureCS.Code_PectoralisMuscleInvolvement);               // CSItemValueSet.cs:72
		public static TCoding Code_PectoralisMuscleTenting = new TCoding(AssociatedFeatureCS.Code_PectoralisMuscleTenting);                       // CSItemValueSet.cs:72
		public static TCoding Code_PostSurgicalScar = new TCoding(AssociatedFeatureCS.Code_PostSurgicalScar);                                     // CSItemValueSet.cs:72
		public static TCoding Code_Seroma = new TCoding(AssociatedFeatureCS.Code_Seroma);                                                         // CSItemValueSet.cs:72
		public static TCoding Code_SkinInvolvement = new TCoding(AssociatedFeatureCS.Code_SkinInvolvement);                                       // CSItemValueSet.cs:72
		public static TCoding Code_SkinLesion = new TCoding(AssociatedFeatureCS.Code_SkinLesion);                                                 // CSItemValueSet.cs:72
		public static TCoding Code_SkinRetraction = new TCoding(AssociatedFeatureCS.Code_SkinRetraction);                                         // CSItemValueSet.cs:72
		public static TCoding Code_SkinThickening = new TCoding(AssociatedFeatureCS.Code_SkinThickening);                                         // CSItemValueSet.cs:72
		public static TCoding Code_SurgicalClip = new TCoding(AssociatedFeatureCS.Code_SurgicalClip);                                             // CSItemValueSet.cs:72
		public static TCoding Code_TrabecularThickening = new TCoding(AssociatedFeatureCS.Code_TrabecularThickening);                             // CSItemValueSet.cs:72
		public static TCoding Code_CalcificationInMass = new TCoding(AssociatedFeatureCS.Code_CalcificationInMass);                               // CSItemValueSet.cs:72
		public static TCoding Code_CalcificationNotOnMammogarm = new TCoding(AssociatedFeatureCS.Code_CalcificationNotOnMammogarm);               // CSItemValueSet.cs:72
		public static TCoding Code_CalcificationOnMammogram = new TCoding(AssociatedFeatureCS.Code_CalcificationOnMammogram);                     // CSItemValueSet.cs:72
		public static TCoding Code_Calcifications = new TCoding(AssociatedFeatureCS.Code_Calcifications);                                         // CSItemValueSet.cs:72
		public static TCoding Code_MicroCalcifications = new TCoding(AssociatedFeatureCS.Code_MicroCalcifications);                               // CSItemValueSet.cs:72
		public static TCoding Code_MilkOfCalcium = new TCoding(AssociatedFeatureCS.Code_MilkOfCalcium);                                           // CSItemValueSet.cs:72
		public static TCoding Code_RimCalcifications = new TCoding(AssociatedFeatureCS.Code_RimCalcifications);                                   // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_ArchitecturalDistortion;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_AxillaryAdenopathy;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_BiopsyClip;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_BrachytherapyTube;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_ChestWallInvasion;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_CooperDistorted;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_CooperThickened;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_Edema;                                                                                                              // CSItemValueSet.cs:83
		    yield return Code_EdemaAdj;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_GoldSeed;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_Hematoma;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_NippleRetraction;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_NOChestWallInvasion;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_PectoralisMuscleInvasion;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_PectoralisMuscleInvolvement;                                                                                        // CSItemValueSet.cs:83
		    yield return Code_PectoralisMuscleTenting;                                                                                            // CSItemValueSet.cs:83
		    yield return Code_PostSurgicalScar;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Seroma;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_SkinInvolvement;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_SkinLesion;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_SkinRetraction;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_SkinThickening;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_SurgicalClip;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_TrabecularThickening;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_CalcificationInMass;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_CalcificationNotOnMammogarm;                                                                                        // CSItemValueSet.cs:83
		    yield return Code_CalcificationOnMammogram;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_Calcifications;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_MicroCalcifications;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_RimCalcifications;                                                                                                  // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
