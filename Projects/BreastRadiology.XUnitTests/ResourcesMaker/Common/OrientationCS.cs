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
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        CSTaskVar OrientationCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "OrientationCS",
                    "Orientation CodeSystem",
                    "Orientation CodeSystem",
                    "Orientation CodeSystem",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("ParallelToSkin")
                            .SetDisplay("Parallel to skin")
                            .MammoId("1508")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("1508",
                                "The lesion/mass is oriented parellel to skin.")
                        ,
                        new ConceptDef()
                            .SetCode("PerpendicularToSkin")
                            .SetDisplay("Perpendicular to skin (not parallel)")
                            .MammoId("1509")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("1509",
                                "The lesion/mass is oriented perpendicular to skin.")
                        ,
                        new ConceptDef()
                            .SetCode("TallerThanWide")
                            .SetDisplay("Taller than wide")
                            .MammoId("1518")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("1518",
                                "The nodule is taller than wide. ",
                                "A nodule is said to be taller than wide when it is ",
                                "greater in the direction normal to the skin than ",
                                "in the parallel ones.")
                        ,
                        new ConceptDef()
                            .SetCode("WiderThanTall")
                            .SetDisplay("Wider than tall")
                            .MammoId("1517")
                            .ValidModalities(Modalities.MRI | Modalities.US)
                            .SetUMLS("1517",
                                "The nodule is wider than tall. ",
                                "A nodule is said to be wider than tall when it is ",
                                "larger in the direction not parallel to the direction ",
                                "of the skin.")
                        #endregion // Codes
                        //- Codes
                    })
        );


        VSTaskVar OrientationVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "OrientationVS",
                    "Orientation ValueSet",
                    "Orientation ValueSet",
                    "Orientation ValueSet",
                    Group_CommonCodesVS,
                    Self.OrientationCS.Value()
                )
        );
    }
}
