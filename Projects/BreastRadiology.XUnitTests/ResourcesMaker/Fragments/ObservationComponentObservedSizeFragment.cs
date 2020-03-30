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
    partial class ResourcesMaker
    {
        SDTaskVar ObservationComponentObservedSizeFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("ObservedSizeFragment",
                            "ObservedSize Fragment",
                            "ObservedSize Fragment",
                            Global.ObservationUrl)
                        .Description("Fragment that adds 'Observed Size' components to Observation.",
                            new Markdown()
                        )
                    ;
                s = e.SDef;
                {
                    ValueSet binding = Self.UnitsOfLengthVS.Value();
                    const String sliceName = "obsSize";

                    e.StartComponentSliceing();
                    e.SliceComponentSize(sliceName,
                        Self.ComponentSliceCodeObservedSize.ToCodeableConcept(),
                        binding,
                        0,
                        "3",
                        out ElementTreeSlice slice);

                    ElementDefinition sliceDef = slice.ElementDefinition
                            .SetShort($"Observed Size component.")
                            .SetDefinition(new Markdown()
                                .Paragraph($"This component slice contains the size of an item observed.",
                                    $"There may be one, two, or three values indicating a size of",
                                    $"one dimension (length), two dimensions (area), or three dimensions (volume).",
                                    $"Each dimension can be a quantity (i.e. 5), or a range (1 to 5).",
                                    $"If the lower bound of the range is set but not the upper bound, then the size is {{lower bound}} or greater.",
                                    $"If the upper bound of the range is set but not the lower bound, then the size is {{upper bound}} or less.")
                            )
                            .SetComment(componentDefinition)
                        ;

                    e.AddComponentLink($"Observed Size",
                        new SDefEditor.Cardinality(slice.ElementDefinition),
                        null,
                        Global.ElementAnchor(sliceDef),
                        "Quantity or Range",
                        binding.Url);
                }
            });
    }
}