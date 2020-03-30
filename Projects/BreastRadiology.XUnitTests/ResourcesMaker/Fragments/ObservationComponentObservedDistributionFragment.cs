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
        SDTaskVar ObservationComponentObservedDistributionFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("ObservedDistributionFragment",
                            "ObservedDistribution Fragment",
                            "ObservedDistribution Fragment",
                            Global.ObservationUrl)
                        .Description("Fragment that adds 'Observed Distribution' components to Observation.",
                            new Markdown()
                        )
                    ;
                s = e.SDef;

                e.StartComponentSliceing();
                {
                    e.ComponentSliceCodeableConcept("obsDistribution",
                        Self.ComponentSliceCodeObservedDistribution.ToCodeableConcept(),
                        Self.CalcificationDistributionVS.Value(),
                        BindingStrength.Required,
                        0,
                        "*",
                        "Observed distribution of abnormalities",
                        "describe the distribution of a group of abnormalities");
                }
                {
                    ValueSet binding = Self.UnitsOfLengthVS.Value();
                    String sliceName = "obsDistRegionSize";
                    e.SliceComponentSize(sliceName,
                        Self.ComponentSliceCodeObservedSize.ToCodeableConcept(),
                        binding,
                        0,
                        "3",
                        out ElementTreeSlice slice);

                    ElementDefinition sliceDef = slice.ElementDefinition
                            .SetShort($"Observed Distribution Region Size component.")
                            .SetDefinition(new Markdown()
                                .Paragraph($"This component slice contains the size of an region inside of which there ",
                                             $"is a distribution of abnormalities.")
                                .Paragraph($"There may be one, two, or three values indicating a size of",
                                           $"one dimension (length), two dimensions (area), or three dimensions (volume).")
                                .Paragraph($"Each dimension can be a quantity (i.e. 5), or a range (1 to 5).")
                                .Paragraph($"If the lower bound of the range is set but not the upper bound, ",
                                           $"then the size is {{lower bound}} or greater.")
                                .Paragraph($"If the upper bound of the range is set but not the lower bound, ",
                                           $"then the size is {{upper bound}} or less.")
                            )
                            .SetComment(componentDefinition)
                        ;

                    e.AddComponentLink($"Observed Distribution Region Size",
                        new SDefEditor.Cardinality(slice.ElementDefinition),
                        null,
                        Global.ElementAnchor(sliceDef),
                        "Quantity or Range",
                        binding.Url);
                }
            });
    }
}