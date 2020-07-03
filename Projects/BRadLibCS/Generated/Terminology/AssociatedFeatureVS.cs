using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
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

		public static TCoding Code_ArchitecturalDistortion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "ArchitecturalDistortion"));// CSItemValueSet.cs:67
		public static TCoding Code_AxillaryAdenopathy = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "AxillaryAdenopathy"));// CSItemValueSet.cs:67
		public static TCoding Code_BiopsyClip = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "BiopsyClip"));// CSItemValueSet.cs:67
		public static TCoding Code_BrachytherapyTube = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "BrachytherapyTube"));// CSItemValueSet.cs:67
		public static TCoding Code_ChestWallInvasion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "ChestWallInvasion"));// CSItemValueSet.cs:67
		public static TCoding Code_CooperDistorted = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "CooperDistorted"));// CSItemValueSet.cs:67
		public static TCoding Code_CooperThickened = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "CooperThickened"));// CSItemValueSet.cs:67
		public static TCoding Code_Edema = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "Edema"));// CSItemValueSet.cs:67
		public static TCoding Code_EdemaAdj = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "EdemaAdj"));// CSItemValueSet.cs:67
		public static TCoding Code_GoldSeed = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "GoldSeed"));// CSItemValueSet.cs:67
		public static TCoding Code_Hematoma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "Hematoma"));// CSItemValueSet.cs:67
		public static TCoding Code_NippleRetraction = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "NippleRetraction"));// CSItemValueSet.cs:67
		public static TCoding Code_NOChestWallInvasion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "NOChestWallInvasion"));// CSItemValueSet.cs:67
		public static TCoding Code_PectoralisMuscleInvasion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "PectoralisMuscleInvasion"));// CSItemValueSet.cs:67
		public static TCoding Code_PectoralisMuscleInvolvement = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "PectoralisMuscleInvolvement"));// CSItemValueSet.cs:67
		public static TCoding Code_PectoralisMuscleTenting = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "PectoralisMuscleTenting"));// CSItemValueSet.cs:67
		public static TCoding Code_PostSurgicalScar = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "PostSurgicalScar"));// CSItemValueSet.cs:67
		public static TCoding Code_Seroma = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "Seroma"));// CSItemValueSet.cs:67
		public static TCoding Code_SkinInvolvement = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "SkinInvolvement"));// CSItemValueSet.cs:67
		public static TCoding Code_SkinLesion = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "SkinLesion"));// CSItemValueSet.cs:67
		public static TCoding Code_SkinRetraction = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "SkinRetraction"));// CSItemValueSet.cs:67
		public static TCoding Code_SkinThickening = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "SkinThickening"));// CSItemValueSet.cs:67
		public static TCoding Code_SurgicalClip = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "SurgicalClip"));// CSItemValueSet.cs:67
		public static TCoding Code_TrabecularThickening = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "TrabecularThickening"));// CSItemValueSet.cs:67
		public static TCoding Code_CalcificationInMass = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "CalcificationInMass"));// CSItemValueSet.cs:67
		public static TCoding Code_CalcificationNotOnMammogarm = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "CalcificationNotOnMammogarm"));// CSItemValueSet.cs:67
		public static TCoding Code_CalcificationOnMammogram = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "CalcificationOnMammogram"));// CSItemValueSet.cs:67
		public static TCoding Code_Calcifications = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "Calcifications"));// CSItemValueSet.cs:67
		public static TCoding Code_MicroCalcifications = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "MicroCalcifications"));// CSItemValueSet.cs:67
		public static TCoding Code_MilkOfCalcium = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "MilkOfCalcium"));// CSItemValueSet.cs:67
		public static TCoding Code_RimCalcifications = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AssociatedFeatureCS", "RimCalcifications"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_ArchitecturalDistortion;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_AxillaryAdenopathy;                                                                                                 // CSItemValueSet.cs:70
		    yield return Code_BiopsyClip;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_BrachytherapyTube;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_ChestWallInvasion;                                                                                                  // CSItemValueSet.cs:70
		    yield return Code_CooperDistorted;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_CooperThickened;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_Edema;                                                                                                              // CSItemValueSet.cs:70
		    yield return Code_EdemaAdj;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_GoldSeed;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_Hematoma;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_NippleRetraction;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_NOChestWallInvasion;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_PectoralisMuscleInvasion;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_PectoralisMuscleInvolvement;                                                                                        // CSItemValueSet.cs:70
		    yield return Code_PectoralisMuscleTenting;                                                                                            // CSItemValueSet.cs:70
		    yield return Code_PostSurgicalScar;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_Seroma;                                                                                                             // CSItemValueSet.cs:70
		    yield return Code_SkinInvolvement;                                                                                                    // CSItemValueSet.cs:70
		    yield return Code_SkinLesion;                                                                                                         // CSItemValueSet.cs:70
		    yield return Code_SkinRetraction;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_SkinThickening;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_SurgicalClip;                                                                                                       // CSItemValueSet.cs:70
		    yield return Code_TrabecularThickening;                                                                                               // CSItemValueSet.cs:70
		    yield return Code_CalcificationInMass;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_CalcificationNotOnMammogarm;                                                                                        // CSItemValueSet.cs:70
		    yield return Code_CalcificationOnMammogram;                                                                                           // CSItemValueSet.cs:70
		    yield return Code_Calcifications;                                                                                                     // CSItemValueSet.cs:70
		    yield return Code_MicroCalcifications;                                                                                                // CSItemValueSet.cs:70
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemValueSet.cs:70
		    yield return Code_RimCalcifications;                                                                                                  // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}
