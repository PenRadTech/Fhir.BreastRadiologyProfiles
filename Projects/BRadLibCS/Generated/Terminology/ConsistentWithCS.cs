using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class ConsistentWithCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ConsistentWithCS";

		public static Coding Code_Abscess = new Coding(System, "Abscess", "Abscess");                                                             // CSItemCodeSystem.cs:55
		public static Coding Code_Angiolipoma = new Coding(System, "Angiolipoma", "Angiolipoma");                                                 // CSItemCodeSystem.cs:55
		public static Coding Code_ApocrineMetaplasia = new Coding(System, "ApocrineMetaplasia", "Apocrine metaplasia");                           // CSItemCodeSystem.cs:55
		public static Coding Code_Artifact = new Coding(System, "Artifact", "Artifact");                                                          // CSItemCodeSystem.cs:55
		public static Coding Code_AtypicalHyperplasia = new Coding(System, "AtypicalHyperplasia", "Atypical hyperplasia");                        // CSItemCodeSystem.cs:55
		public static Coding Code_AxillaryLymphNode = new Coding(System, "AxillaryLymphNode", "Axillary lymph node");                             // CSItemCodeSystem.cs:55
		public static Coding Code_Carcinoma = new Coding(System, "Carcinoma", "Carcinoma");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_CarcinomaKnown = new Coding(System, "CarcinomaKnown", "Carcinoma known");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_ClusterOfCysts = new Coding(System, "ClusterOfCysts", "Cluster of cysts");                                      // CSItemCodeSystem.cs:55
		public static Coding Code_Cyst = new Coding(System, "Cyst", "Cyst");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_CystComplex = new Coding(System, "CystComplex", "Cyst complex");                                                // CSItemCodeSystem.cs:55
		public static Coding Code_CystComplicated = new Coding(System, "CystComplicated", "Cyst complicated");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_CystOil = new Coding(System, "CystOil", "Cyst oil");                                                            // CSItemCodeSystem.cs:55
		public static Coding Code_CystSebaceous = new Coding(System, "CystSebaceous", "Cyst sebaceous");                                          // CSItemCodeSystem.cs:55
		public static Coding Code_CystSimple = new Coding(System, "CystSimple", "Cyst simple");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_CystsComplex = new Coding(System, "CystsComplex", "Cysts complex");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_CystsComplicated = new Coding(System, "CystsComplicated", "Cysts complicated");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_CystsMicroClustered = new Coding(System, "CystsMicroClustered", "Cysts micro clustered");                       // CSItemCodeSystem.cs:55
		public static Coding Code_DCIS = new Coding(System, "DCIS", "DCIS");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_Debris = new Coding(System, "Debris", "Debris");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_Deodorant = new Coding(System, "Deodorant", "Deodorant");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_DermalCalcification = new Coding(System, "DermalCalcification", "Dermal calcification");                        // CSItemCodeSystem.cs:55
		public static Coding Code_DuctEctasia = new Coding(System, "DuctEctasia", "Duct ectasia");                                                // CSItemCodeSystem.cs:55
		public static Coding Code_Edema = new Coding(System, "Edema", "Edema");                                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_FatLobule = new Coding(System, "FatLobule", "Fat lobule");                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_FatNecrosis = new Coding(System, "FatNecrosis", "Fat necrosis");                                                // CSItemCodeSystem.cs:55
		public static Coding Code_Fibroadenolipoma = new Coding(System, "Fibroadenolipoma", "Fibroadenolipoma");                                  // CSItemCodeSystem.cs:55
		public static Coding Code_Fibroadenoma = new Coding(System, "Fibroadenoma", "Fibroadenoma");                                              // CSItemCodeSystem.cs:55
		public static Coding Code_FibroadenomaDegenerating = new Coding(System, "FibroadenomaDegenerating", "Fibroadenoma degenerating");         // CSItemCodeSystem.cs:55
		public static Coding Code_FibrocysticChange = new Coding(System, "FibrocysticChange", "Fibrocystic change");                              // CSItemCodeSystem.cs:55
		public static Coding Code_FibroglandularTissue = new Coding(System, "FibroglandularTissue", "Fibroglandular tissue");                     // CSItemCodeSystem.cs:55
		public static Coding Code_Fibrosis = new Coding(System, "Fibrosis", "Fibrosis");                                                          // CSItemCodeSystem.cs:55
		public static Coding Code_FibrousRidge = new Coding(System, "FibrousRidge", "Fibrous ridge");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_Folliculitis = new Coding(System, "Folliculitis", "Folliculitis");                                              // CSItemCodeSystem.cs:55
		public static Coding Code_Gynecomastia = new Coding(System, "Gynecomastia", "Gynecomastia");                                              // CSItemCodeSystem.cs:55
		public static Coding Code_Hamartoma = new Coding(System, "Hamartoma", "Hamartoma");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_Hematoma = new Coding(System, "Hematoma", "Hematoma");                                                          // CSItemCodeSystem.cs:55
		public static Coding Code_HormonalStimulation = new Coding(System, "HormonalStimulation", "Hormonal stimulation");                        // CSItemCodeSystem.cs:55
		public static Coding Code_IntracysticLesion = new Coding(System, "IntracysticLesion", "Intracystic lesion");                              // CSItemCodeSystem.cs:55
		public static Coding Code_IntramammaryNode = new Coding(System, "IntramammaryNode", "Intramammary node");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_Lipoma = new Coding(System, "Lipoma", "Lipoma");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_LumpectomyCavity = new Coding(System, "LumpectomyCavity", "Lumpectomy cavity");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_LumpectomySite = new Coding(System, "LumpectomySite", "Lumpectomy site");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_LymphNode = new Coding(System, "LymphNode", "Lymph node");                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_LymphNodeEnlarged = new Coding(System, "LymphNodeEnlarged", "Lymph node enlarged");                             // CSItemCodeSystem.cs:55
		public static Coding Code_LymphNodeNormal = new Coding(System, "LymphNodeNormal", "Lymph node normal");                                   // CSItemCodeSystem.cs:55
		public static Coding Code_LymphNodePathological = new Coding(System, "LymphNodePathological", "Lymph node pathological");                 // CSItemCodeSystem.cs:55
		public static Coding Code_MassSolid = new Coding(System, "MassSolid", "Mass solid");                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_MassSolidWTumorVasc = new Coding(System, "MassSolidW/tumorVasc", "Mass solid w/tumor vasc");                    // CSItemCodeSystem.cs:55
		public static Coding Code_Mastitis = new Coding(System, "Mastitis", "Mastitis");                                                          // CSItemCodeSystem.cs:55
		public static Coding Code_MilkOfCalcium = new Coding(System, "MilkOfCalcium", "Milk of calcium");                                         // CSItemCodeSystem.cs:55
		public static Coding Code_MultiFocalCancer = new Coding(System, "Multi-focalCancer", "Multi-focal cancer");                               // CSItemCodeSystem.cs:55
		public static Coding Code_PapillaryLesion = new Coding(System, "PapillaryLesion", "Papillary lesion");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_Papilloma = new Coding(System, "Papilloma", "Papilloma");                                                       // CSItemCodeSystem.cs:55
		public static Coding Code_PhyllodesTumor = new Coding(System, "PhyllodesTumor", "Phyllodes tumor");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_PostLumpectomyScar = new Coding(System, "PostLumpectomyScar", "Post lumpectomy scar");                          // CSItemCodeSystem.cs:55
		public static Coding Code_PostSurgicalScar = new Coding(System, "PostSurgicalScar", "Post surgical scar");                                // CSItemCodeSystem.cs:55
		public static Coding Code_PreviousBiopsy = new Coding(System, "PreviousBiopsy", "Previous biopsy");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_PreviousSurgery = new Coding(System, "PreviousSurgery", "Previous surgery");                                    // CSItemCodeSystem.cs:55
		public static Coding Code_PreviousTrauma = new Coding(System, "PreviousTrauma", "Previous trauma");                                       // CSItemCodeSystem.cs:55
		public static Coding Code_RadialScar = new Coding(System, "RadialScar", "Radial scar");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_RadiationChanges = new Coding(System, "RadiationChanges", "Radiation changes");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_RadiationTherapy = new Coding(System, "RadiationTherapy", "Radiation therapy");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_Scar = new Coding(System, "Scar", "Scar");                                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_ScarWithShadowing = new Coding(System, "ScarWithShadowing", "Scar with shadowing");                             // CSItemCodeSystem.cs:55
		public static Coding Code_SclerosingAdenosis = new Coding(System, "SclerosingAdenosis", "Sclerosing adenosis");                           // CSItemCodeSystem.cs:55
		public static Coding Code_SecretoryCalcification = new Coding(System, "SecretoryCalcification", "Secretory calcification");               // CSItemCodeSystem.cs:55
		public static Coding Code_SentinelNode = new Coding(System, "SentinelNode", "Sentinel node");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_Seroma = new Coding(System, "Seroma", "Seroma");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_SkinLesion = new Coding(System, "SkinLesion", "Skin lesion");                                                   // CSItemCodeSystem.cs:55
		public static Coding Code_Surgery = new Coding(System, "Surgery", "Surgery");                                                             // CSItemCodeSystem.cs:55
		public static Coding Code_Trauma = new Coding(System, "Trauma", "Trauma");                                                                // CSItemCodeSystem.cs:55
		public static Coding Code_VascularCalcifications = new Coding(System, "VascularCalcifications", "Vascular calcifications");               // CSItemCodeSystem.cs:55
		public static Coding Code_VenousStasis = new Coding(System, "VenousStasis", "Venous stasis");                                             // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_Abscess;                                                                                                            // CSItemCodeSystem.cs:58
		    yield return Code_Angiolipoma;                                                                                                        // CSItemCodeSystem.cs:58
		    yield return Code_ApocrineMetaplasia;                                                                                                 // CSItemCodeSystem.cs:58
		    yield return Code_Artifact;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_AtypicalHyperplasia;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_AxillaryLymphNode;                                                                                                  // CSItemCodeSystem.cs:58
		    yield return Code_Carcinoma;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_CarcinomaKnown;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_ClusterOfCysts;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_Cyst;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_CystComplex;                                                                                                        // CSItemCodeSystem.cs:58
		    yield return Code_CystComplicated;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_CystOil;                                                                                                            // CSItemCodeSystem.cs:58
		    yield return Code_CystSebaceous;                                                                                                      // CSItemCodeSystem.cs:58
		    yield return Code_CystSimple;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_CystsComplex;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_CystsComplicated;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_CystsMicroClustered;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_DCIS;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_Debris;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_Deodorant;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_DermalCalcification;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_DuctEctasia;                                                                                                        // CSItemCodeSystem.cs:58
		    yield return Code_Edema;                                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_FatLobule;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_FatNecrosis;                                                                                                        // CSItemCodeSystem.cs:58
		    yield return Code_Fibroadenolipoma;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_Fibroadenoma;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_FibroadenomaDegenerating;                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_FibrocysticChange;                                                                                                  // CSItemCodeSystem.cs:58
		    yield return Code_FibroglandularTissue;                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_Fibrosis;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_FibrousRidge;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_Folliculitis;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_Gynecomastia;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_Hamartoma;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_Hematoma;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_HormonalStimulation;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_IntracysticLesion;                                                                                                  // CSItemCodeSystem.cs:58
		    yield return Code_IntramammaryNode;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_Lipoma;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_LumpectomyCavity;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_LumpectomySite;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_LymphNode;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_LymphNodeEnlarged;                                                                                                  // CSItemCodeSystem.cs:58
		    yield return Code_LymphNodeNormal;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_LymphNodePathological;                                                                                              // CSItemCodeSystem.cs:58
		    yield return Code_MassSolid;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_MassSolidWTumorVasc;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_Mastitis;                                                                                                           // CSItemCodeSystem.cs:58
		    yield return Code_MilkOfCalcium;                                                                                                      // CSItemCodeSystem.cs:58
		    yield return Code_MultiFocalCancer;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_PapillaryLesion;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_Papilloma;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_PhyllodesTumor;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_PostLumpectomyScar;                                                                                                 // CSItemCodeSystem.cs:58
		    yield return Code_PostSurgicalScar;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_PreviousBiopsy;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_PreviousSurgery;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_PreviousTrauma;                                                                                                     // CSItemCodeSystem.cs:58
		    yield return Code_RadialScar;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_RadiationChanges;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_RadiationTherapy;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_Scar;                                                                                                               // CSItemCodeSystem.cs:58
		    yield return Code_ScarWithShadowing;                                                                                                  // CSItemCodeSystem.cs:58
		    yield return Code_SclerosingAdenosis;                                                                                                 // CSItemCodeSystem.cs:58
		    yield return Code_SecretoryCalcification;                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_SentinelNode;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_Seroma;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_SkinLesion;                                                                                                         // CSItemCodeSystem.cs:58
		    yield return Code_Surgery;                                                                                                            // CSItemCodeSystem.cs:58
		    yield return Code_Trauma;                                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_VascularCalcifications;                                                                                             // CSItemCodeSystem.cs:58
		    yield return Code_VenousStasis;                                                                                                       // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
