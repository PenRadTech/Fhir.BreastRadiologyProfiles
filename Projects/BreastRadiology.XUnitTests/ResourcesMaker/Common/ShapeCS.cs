using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        VSTaskVar ShapeVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "ShapeVS",
                    "Shape ValueSet",
                    "Shape/ValueSet",
                    "Shape value set.",
                    Group_CommonCodesVS,
                    Self.ShapeCS.Value()
                )
        );


        CSTaskVar ShapeCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "ShapeCS",
                    "Shape CodeSystem",
                    "Shape/CodeSystem",
                    "Shape values code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("IrregularInShape")
                            .SetDisplay("Irregular in shape")
                            .MammoId("16")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("16",
                                "129736006")
                            .SetSnomedDescription("16",
                                "ClinicalFinding | Irregular shaped lesion")
                            .SetUMLS("16",
                                "A mass that can't be characterized by any specific ",
                                "shape.")
                        ,
                        new ConceptDef()
                            .SetCode("LobulatedInShape")
                            .SetDisplay("Lobulated in shape")
                            .MammoId("190")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("190",
                                "129735005")
                            .SetSnomedDescription("190",
                                "ClinicalFinding | Lobular shaped lesion (Finding)")
                            .SetUMLS("190",
                                "A mass that has an undulating  (having a smoothly ",
                                "rising and falling form or outline) ",
                                "contour.")
                        ,
                        new ConceptDef()
                            .SetCode("OvalInShape")
                            .SetDisplay("Oval in shape")
                            .MammoId("15")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("15",
                                "129734009")
                            .SetSnomedDescription("15",
                                "ClinicalFinding | Oval shaped lesion (Finding)")
                            .SetUMLS("15",
                                "There is a mass that is elliptical or egg-shaped.")
                        ,
                        new ConceptDef()
                            .SetCode("Reniform")
                            .SetDisplay("Reniform")
                            .MammoId("27")
                            .ValidModalities(Modalities.MG)
                            .SetUMLS("27",
                                "There is a mass that is reniform (kidney shape) in ",
                                "shape.")
                        ,
                        new ConceptDef()
                            .SetCode("RoundInShape")
                            .SetDisplay("Round in shape")
                            .MammoId("14")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetSnomedCode("14",
                                "129733003")
                            .SetSnomedDescription("14",
                                "ClinicalFinding | Round shaped lesion (Finding)")
                            .SetUMLS("14",
                                "There is a mass that is spherical, ball-shaped, circular ",
                                "or global.")
                        #endregion // Codes
                        //- Codes
                    })
        );
    }
}
