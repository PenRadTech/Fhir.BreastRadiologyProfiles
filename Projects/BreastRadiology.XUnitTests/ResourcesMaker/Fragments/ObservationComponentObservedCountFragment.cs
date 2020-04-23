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
        SDTaskVar ObservationComponentObservedCountFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                const String sliceName = "obsCount";
                SDefEditor e = Self.CreateFragment("ObservedCountFragment",
                            "ObservedCount Fragment",
                            "ObservedCount Fragment",
                            Global.ObservationUrl)
                        .Description("Fragment that adds 'Observed Count' element to profile.",
                            new Markdown()
                        )
                    ;
                s = e.SDef;

                e.StartComponentSliceing();
                ElementTreeSlice slice = e.AppendSlice("component", sliceName, 0, "1");
                // Fix component code
                e.SliceComponentCode(slice, sliceName, Self.ComponentSliceCodeObservedCount.ToCodeableConcept());
                e.SliceValueXByType(slice, new string[] {"Quantity", "Range"});

                ElementDefinition sliceDef = slice.ElementDefinition
                        .SetShort($"Observed Count component.")
                        .SetDefinition(new Markdown()
                            .Paragraph($"This component slice contains the number of items observed.",
                                $"This can be a quantity (i.e. 5), or a range (1 to 5).")
                            .Paragraph($"If the lower bound of the range is set but not the upper bound,",
                                       $"then it means {{lower bound}} or more.")
                            .Paragraph($"If the lower bound of the range is not set but the upper bound is,",
                                       $"then it means {{upper bound}} or less."
                            )
                        )
                        .SetComment(componentDefinition)
                    ;

                e.AddComponentLink($"Observed Count",
                    new SDefEditor.Cardinality(slice.ElementDefinition),
                    null,
                    Global.ElementAnchor(sliceDef),
                    "Quantity or Range");
            });
    }
}