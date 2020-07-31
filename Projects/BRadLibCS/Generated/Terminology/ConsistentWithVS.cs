using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class ConsistentWithVS
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
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/ConsistentWithVS";

		public static TCoding Code_Abscess = new TCoding(ConsistentWithCS.Code_Abscess);                                                          // CSItemValueSet.cs:72
		public static TCoding Code_Angiolipoma = new TCoding(ConsistentWithCS.Code_Angiolipoma);                                                  // CSItemValueSet.cs:72
		public static TCoding Code_ApocrineMetaplasia = new TCoding(ConsistentWithCS.Code_ApocrineMetaplasia);                                    // CSItemValueSet.cs:72
		public static TCoding Code_Artifact = new TCoding(ConsistentWithCS.Code_Artifact);                                                        // CSItemValueSet.cs:72
		public static TCoding Code_AtypicalHyperplasia = new TCoding(ConsistentWithCS.Code_AtypicalHyperplasia);                                  // CSItemValueSet.cs:72
		public static TCoding Code_AxillaryLymphNode = new TCoding(ConsistentWithCS.Code_AxillaryLymphNode);                                      // CSItemValueSet.cs:72
		public static TCoding Code_Carcinoma = new TCoding(ConsistentWithCS.Code_Carcinoma);                                                      // CSItemValueSet.cs:72
		public static TCoding Code_CarcinomaKnown = new TCoding(ConsistentWithCS.Code_CarcinomaKnown);                                            // CSItemValueSet.cs:72
		public static TCoding Code_ClusterOfCysts = new TCoding(ConsistentWithCS.Code_ClusterOfCysts);                                            // CSItemValueSet.cs:72
		public static TCoding Code_Cyst = new TCoding(ConsistentWithCS.Code_Cyst);                                                                // CSItemValueSet.cs:72
		public static TCoding Code_CystComplex = new TCoding(ConsistentWithCS.Code_CystComplex);                                                  // CSItemValueSet.cs:72
		public static TCoding Code_CystComplicated = new TCoding(ConsistentWithCS.Code_CystComplicated);                                          // CSItemValueSet.cs:72
		public static TCoding Code_CystOil = new TCoding(ConsistentWithCS.Code_CystOil);                                                          // CSItemValueSet.cs:72
		public static TCoding Code_CystSebaceous = new TCoding(ConsistentWithCS.Code_CystSebaceous);                                              // CSItemValueSet.cs:72
		public static TCoding Code_CystSimple = new TCoding(ConsistentWithCS.Code_CystSimple);                                                    // CSItemValueSet.cs:72
		public static TCoding Code_CystsComplex = new TCoding(ConsistentWithCS.Code_CystsComplex);                                                // CSItemValueSet.cs:72
		public static TCoding Code_CystsComplicated = new TCoding(ConsistentWithCS.Code_CystsComplicated);                                        // CSItemValueSet.cs:72
		public static TCoding Code_CystsMicroClustered = new TCoding(ConsistentWithCS.Code_CystsMicroClustered);                                  // CSItemValueSet.cs:72
		public static TCoding Code_DCIS = new TCoding(ConsistentWithCS.Code_DCIS);                                                                // CSItemValueSet.cs:72
		public static TCoding Code_Debris = new TCoding(ConsistentWithCS.Code_Debris);                                                            // CSItemValueSet.cs:72
		public static TCoding Code_Deodorant = new TCoding(ConsistentWithCS.Code_Deodorant);                                                      // CSItemValueSet.cs:72
		public static TCoding Code_DermalCalcification = new TCoding(ConsistentWithCS.Code_DermalCalcification);                                  // CSItemValueSet.cs:72
		public static TCoding Code_DuctEctasia = new TCoding(ConsistentWithCS.Code_DuctEctasia);                                                  // CSItemValueSet.cs:72
		public static TCoding Code_Edema = new TCoding(ConsistentWithCS.Code_Edema);                                                              // CSItemValueSet.cs:72
		public static TCoding Code_FatLobule = new TCoding(ConsistentWithCS.Code_FatLobule);                                                      // CSItemValueSet.cs:72
		public static TCoding Code_FatNecrosis = new TCoding(ConsistentWithCS.Code_FatNecrosis);                                                  // CSItemValueSet.cs:72
		public static TCoding Code_Fibroadenolipoma = new TCoding(ConsistentWithCS.Code_Fibroadenolipoma);                                        // CSItemValueSet.cs:72
		public static TCoding Code_Fibroadenoma = new TCoding(ConsistentWithCS.Code_Fibroadenoma);                                                // CSItemValueSet.cs:72
		public static TCoding Code_FibroadenomaDegenerating = new TCoding(ConsistentWithCS.Code_FibroadenomaDegenerating);                        // CSItemValueSet.cs:72
		public static TCoding Code_FibrocysticChange = new TCoding(ConsistentWithCS.Code_FibrocysticChange);                                      // CSItemValueSet.cs:72
		public static TCoding Code_FibroglandularTissue = new TCoding(ConsistentWithCS.Code_FibroglandularTissue);                                // CSItemValueSet.cs:72
		public static TCoding Code_Fibrosis = new TCoding(ConsistentWithCS.Code_Fibrosis);                                                        // CSItemValueSet.cs:72
		public static TCoding Code_FibrousRidge = new TCoding(ConsistentWithCS.Code_FibrousRidge);                                                // CSItemValueSet.cs:72
		public static TCoding Code_Folliculitis = new TCoding(ConsistentWithCS.Code_Folliculitis);                                                // CSItemValueSet.cs:72
		public static TCoding Code_Gynecomastia = new TCoding(ConsistentWithCS.Code_Gynecomastia);                                                // CSItemValueSet.cs:72
		public static TCoding Code_Hamartoma = new TCoding(ConsistentWithCS.Code_Hamartoma);                                                      // CSItemValueSet.cs:72
		public static TCoding Code_Hematoma = new TCoding(ConsistentWithCS.Code_Hematoma);                                                        // CSItemValueSet.cs:72
		public static TCoding Code_HormonalStimulation = new TCoding(ConsistentWithCS.Code_HormonalStimulation);                                  // CSItemValueSet.cs:72
		public static TCoding Code_IntracysticLesion = new TCoding(ConsistentWithCS.Code_IntracysticLesion);                                      // CSItemValueSet.cs:72
		public static TCoding Code_IntramammaryNode = new TCoding(ConsistentWithCS.Code_IntramammaryNode);                                        // CSItemValueSet.cs:72
		public static TCoding Code_Lipoma = new TCoding(ConsistentWithCS.Code_Lipoma);                                                            // CSItemValueSet.cs:72
		public static TCoding Code_LumpectomyCavity = new TCoding(ConsistentWithCS.Code_LumpectomyCavity);                                        // CSItemValueSet.cs:72
		public static TCoding Code_LumpectomySite = new TCoding(ConsistentWithCS.Code_LumpectomySite);                                            // CSItemValueSet.cs:72
		public static TCoding Code_LymphNode = new TCoding(ConsistentWithCS.Code_LymphNode);                                                      // CSItemValueSet.cs:72
		public static TCoding Code_LymphNodeEnlarged = new TCoding(ConsistentWithCS.Code_LymphNodeEnlarged);                                      // CSItemValueSet.cs:72
		public static TCoding Code_LymphNodeNormal = new TCoding(ConsistentWithCS.Code_LymphNodeNormal);                                          // CSItemValueSet.cs:72
		public static TCoding Code_LymphNodePathological = new TCoding(ConsistentWithCS.Code_LymphNodePathological);                              // CSItemValueSet.cs:72
		public static TCoding Code_MassSolid = new TCoding(ConsistentWithCS.Code_MassSolid);                                                      // CSItemValueSet.cs:72
		public static TCoding Code_MassSolidWTumorVasc = new TCoding(ConsistentWithCS.Code_MassSolidWTumorVasc);                                  // CSItemValueSet.cs:72
		public static TCoding Code_Mastitis = new TCoding(ConsistentWithCS.Code_Mastitis);                                                        // CSItemValueSet.cs:72
		public static TCoding Code_MilkOfCalcium = new TCoding(ConsistentWithCS.Code_MilkOfCalcium);                                              // CSItemValueSet.cs:72
		public static TCoding Code_MultiFocalCancer = new TCoding(ConsistentWithCS.Code_MultiFocalCancer);                                        // CSItemValueSet.cs:72
		public static TCoding Code_PapillaryLesion = new TCoding(ConsistentWithCS.Code_PapillaryLesion);                                          // CSItemValueSet.cs:72
		public static TCoding Code_Papilloma = new TCoding(ConsistentWithCS.Code_Papilloma);                                                      // CSItemValueSet.cs:72
		public static TCoding Code_PhyllodesTumor = new TCoding(ConsistentWithCS.Code_PhyllodesTumor);                                            // CSItemValueSet.cs:72
		public static TCoding Code_PostLumpectomyScar = new TCoding(ConsistentWithCS.Code_PostLumpectomyScar);                                    // CSItemValueSet.cs:72
		public static TCoding Code_PostSurgicalScar = new TCoding(ConsistentWithCS.Code_PostSurgicalScar);                                        // CSItemValueSet.cs:72
		public static TCoding Code_PreviousBiopsy = new TCoding(ConsistentWithCS.Code_PreviousBiopsy);                                            // CSItemValueSet.cs:72
		public static TCoding Code_PreviousSurgery = new TCoding(ConsistentWithCS.Code_PreviousSurgery);                                          // CSItemValueSet.cs:72
		public static TCoding Code_PreviousTrauma = new TCoding(ConsistentWithCS.Code_PreviousTrauma);                                            // CSItemValueSet.cs:72
		public static TCoding Code_RadialScar = new TCoding(ConsistentWithCS.Code_RadialScar);                                                    // CSItemValueSet.cs:72
		public static TCoding Code_RadiationChanges = new TCoding(ConsistentWithCS.Code_RadiationChanges);                                        // CSItemValueSet.cs:72
		public static TCoding Code_RadiationTherapy = new TCoding(ConsistentWithCS.Code_RadiationTherapy);                                        // CSItemValueSet.cs:72
		public static TCoding Code_Scar = new TCoding(ConsistentWithCS.Code_Scar);                                                                // CSItemValueSet.cs:72
		public static TCoding Code_ScarWithShadowing = new TCoding(ConsistentWithCS.Code_ScarWithShadowing);                                      // CSItemValueSet.cs:72
		public static TCoding Code_SclerosingAdenosis = new TCoding(ConsistentWithCS.Code_SclerosingAdenosis);                                    // CSItemValueSet.cs:72
		public static TCoding Code_SecretoryCalcification = new TCoding(ConsistentWithCS.Code_SecretoryCalcification);                            // CSItemValueSet.cs:72
		public static TCoding Code_SentinelNode = new TCoding(ConsistentWithCS.Code_SentinelNode);                                                // CSItemValueSet.cs:72
		public static TCoding Code_Seroma = new TCoding(ConsistentWithCS.Code_Seroma);                                                            // CSItemValueSet.cs:72
		public static TCoding Code_SkinLesion = new TCoding(ConsistentWithCS.Code_SkinLesion);                                                    // CSItemValueSet.cs:72
		public static TCoding Code_Surgery = new TCoding(ConsistentWithCS.Code_Surgery);                                                          // CSItemValueSet.cs:72
		public static TCoding Code_Trauma = new TCoding(ConsistentWithCS.Code_Trauma);                                                            // CSItemValueSet.cs:72
		public static TCoding Code_VascularCalcifications = new TCoding(ConsistentWithCS.Code_VascularCalcifications);                            // CSItemValueSet.cs:72
		public static TCoding Code_VenousStasis = new TCoding(ConsistentWithCS.Code_VenousStasis);                                                // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_Abscess;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_Angiolipoma;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_ApocrineMetaplasia;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_Artifact;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_AtypicalHyperplasia;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_AxillaryLymphNode;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_Carcinoma;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_CarcinomaKnown;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_ClusterOfCysts;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_Cyst;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_CystComplex;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_CystComplicated;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_CystOil;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_CystSebaceous;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_CystSimple;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_CystsComplex;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_CystsComplicated;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_CystsMicroClustered;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_DCIS;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_Debris;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_Deodorant;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_DermalCalcification;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_DuctEctasia;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Edema;                                                                                                              // CSItemValueSet.cs:83
		    yield return Code_FatLobule;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_FatNecrosis;                                                                                                        // CSItemValueSet.cs:83
		    yield return Code_Fibroadenolipoma;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Fibroadenoma;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_FibroadenomaDegenerating;                                                                                           // CSItemValueSet.cs:83
		    yield return Code_FibrocysticChange;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_FibroglandularTissue;                                                                                               // CSItemValueSet.cs:83
		    yield return Code_Fibrosis;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_FibrousRidge;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Folliculitis;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Gynecomastia;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Hamartoma;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_Hematoma;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_HormonalStimulation;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_IntracysticLesion;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_IntramammaryNode;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Lipoma;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_LumpectomyCavity;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_LumpectomySite;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_LymphNode;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_LymphNodeEnlarged;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_LymphNodeNormal;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_LymphNodePathological;                                                                                              // CSItemValueSet.cs:83
		    yield return Code_MassSolid;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_MassSolidWTumorVasc;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_Mastitis;                                                                                                           // CSItemValueSet.cs:83
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemValueSet.cs:83
		    yield return Code_MultiFocalCancer;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_PapillaryLesion;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_Papilloma;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_PhyllodesTumor;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_PostLumpectomyScar;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_PostSurgicalScar;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_PreviousBiopsy;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_PreviousSurgery;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_PreviousTrauma;                                                                                                     // CSItemValueSet.cs:83
		    yield return Code_RadialScar;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_RadiationChanges;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_RadiationTherapy;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_Scar;                                                                                                               // CSItemValueSet.cs:83
		    yield return Code_ScarWithShadowing;                                                                                                  // CSItemValueSet.cs:83
		    yield return Code_SclerosingAdenosis;                                                                                                 // CSItemValueSet.cs:83
		    yield return Code_SecretoryCalcification;                                                                                             // CSItemValueSet.cs:83
		    yield return Code_SentinelNode;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_Seroma;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_SkinLesion;                                                                                                         // CSItemValueSet.cs:83
		    yield return Code_Surgery;                                                                                                            // CSItemValueSet.cs:83
		    yield return Code_Trauma;                                                                                                             // CSItemValueSet.cs:83
		    yield return Code_VascularCalcifications;                                                                                             // CSItemValueSet.cs:83
		    yield return Code_VenousStasis;                                                                                                       // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
