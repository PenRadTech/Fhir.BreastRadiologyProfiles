using System;
using System.Collections.Generic;
using System.Text;
using Hl7.Fhir.Model;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        CSTaskVar CalcificationDistributionCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "CalcificationDistributionCS",
                    "Calcification Distribution CodeSystem",
                    "Calcification/Distribution/CodeSystem",
                    "Calcification Distribution in an abnormality code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("ClusteredDistribution")
                            .SetDisplay("Clustered distribution")
                            .MammoId("751")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("751",
                                "ClinicalFinding | 129769006 | Radiographic calcification ",
                                "with clustered distribution (Finding)")
                            .SetUMLS("751",
                                "Grouped (historically, \"clustered\") ",
                                "This term should be used when relatively few calcifications ",
                                "occupy a small portion ",
                                "of breast",
                                "tissue. ",
                                "The lower limit for use of this descriptor is usually ",
                                "when 5 calcifications are grouped",
                                "within 1 cm of each other or when a definable pattern ",
                                "is identified. ",
                                "The upper limit for use",
                                "of this descriptor is when larger numbers of calcifications ",
                                "are grouped within 2 ",
                                "cm of each",
                                "other. ",
                                "###ACRMG#73")
                        ,
                        new ConceptDef()
                            .SetCode("DiffuseDistribution")
                            .SetDisplay("Diffuse distribution")
                            .MammoId("752")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("752",
                                "F-01770")
                            .SetSnomedDescription("752",
                                "ClinicalFinding | 129764001 | Radiographic calcification ",
                                "with diffuse distribution (Finding)")
                            .SetUMLS("752",
                                "Diffuse or Scattered: diffuse calcifications may ",
                                "be scattered calcifications or multiple similar appearing ",
                                "clusters of calcifications throughout the whole breast. ",
                                " Diffuse or scattered distribution is typically seen ",
                                "in benign entities.",
                                "Even when clusters of calcifications are scattered ",
                                "throughout the breast, this favors a benign entity. ",
                                "###URL#https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis")
                        ,
                        new ConceptDef()
                            .SetCode("GroupedDistribution")
                            .SetDisplay("Grouped distribution")
                            .MammoId("753")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("753",
                                "F-01772")
                            .SetSnomedDescription("753",
                                "ClinicalFinding | 129766004 | Radiographic calcification ",
                                "with grouped distribution (Finding)")
                            .SetUMLS("753",
                                "This term should be used when relatively few calcifications ",
                                "occupy a ",
                                "small portion of breast tissue. ",
                                "The lower limit for use of this descriptor is usually ",
                                "when 5 calcifications ",
                                "are grouped within 1 cm of each other or when a definable ",
                                "pattern is identified. ",
                                "The upper limit for use of this descriptor is when ",
                                "larger numbers of ",
                                "calcifications are grouped within 2 cm of each other.###ACRMG#74")
                        ,
                        new ConceptDef()
                            .SetCode("LinearDistribution")
                            .SetDisplay("Linear distribution")
                            .MammoId("754")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("754",
                                "F-01771")
                            .SetSnomedDescription("754",
                                "ClinicalFinding | 129765000 | Radiographic calcification ",
                                "with linear distribution (Finding)")
                            .SetUMLS("754",
                                "These are calcifications arrayed in a line. ",
                                "This distribution may elevate suspicion for malignancy, ",
                                "as it suggests deposits in a duct. ",
                                "Note that both vascular and large rod-like calcifications ",
                                "also are usually linear in distribution, but that ",
                                "these typically ",
                                "benign calcifications have a characteristically benign ",
                                "morphology.###ACRMG#")
                        ,
                        new ConceptDef()
                            .SetCode("RegionalDistribution")
                            .SetDisplay("Regional distribution")
                            .MammoId("755")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("755",
                                "F-01773")
                            .SetSnomedDescription("755",
                                "ClinicalFinding | 129767008 | Radiographic calcification ",
                                "with regional distribution (Finding)")
                            .SetUMLS("755",
                                "Scattered in a larger volume (> 2 cc) of breast tissue ",
                                "and not in the expected ductal distribution. ",
                                "Regional distribution according to the BI-RADS atlas ",
                                "would favor a non-ductal distribution (i.e. ",
                                "benignity) ###URL#https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis")
                        ,
                        new ConceptDef()
                            .SetCode("ScatteredDistribution")
                            .SetDisplay("Scattered distribution")
                            .MammoId("756")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("756",
                                "not found")
                            .SetUMLS("756",
                                "Scattered distributions are also called diffuse distributions. ",
                                "These are calcifications that are distributed randomly ",
                                "throughout the breast. ",
                                "Punctate and amorphous calcifications in this distribution ",
                                "are almost always benign, especially ",
                                "if bilateral (in both breasts). ",
                                "###ACRMG#70")
                        ,
                        new ConceptDef()
                            .SetCode("SegmentalDistribution")
                            .SetDisplay("Segmental distribution")
                            .MammoId("757")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("757",
                                "F-01774")
                            .SetSnomedCode("757",
                                "129768003")
                            .SetSnomedDescription("757",
                                "ClinicalFinding | 129768003 | Radiographic calcification ",
                                "with segmental distribution (Finding)")
                            .SetUMLS("757",
                                "Segmental: calcium deposits in ducts and branches ",
                                "of a segment or lobe. ",
                                " Segmental distribution would favor a ductal distribution ",
                                "(i.e. ",
                                "malignancy).",
                                "Sometimes this differentiation can be made, but in ",
                                "many cases the differentiation between 'regional' ",
                                "and 'segmental' is problematic, because it is not ",
                                "clear on a mammogram or MRI where the bounderies ",
                                "of a segment (or a lobe) exactly are. ",
                                "###URL#https://radiologyassistant.nl/breast/breast-calcifications-differential-diagnosis")
                        #endregion // Codes
                        //- Codes
                    }));

        VSTaskVar CalcificationDistributionVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "CalcificationDistributionVS",
                    "Calcification Distribution ValueSet",
                    "Calcification Distribution/ValueSet",
                    "Calcification Distribution of an abnormality value set.",
                    Group_CommonCodesVS,
                    Self.CalcificationDistributionCS.Value()
                )
        );
    }
}
