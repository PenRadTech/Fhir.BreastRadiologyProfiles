using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar ObservationLeafFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("ObservationLeafFragment",
                            "Observation Leaf Fragment",
                            "Observation/Leaf/Fragment",
                            Global.ObservationUrl)
                        .Description("Observation Leaf Node Fragment",
                            new Markdown()
                                .Paragraph(
                                    "")
                        )
                    ;
                s = e.SDef;

                e.Select("hasMember").Zero();
            });
    }
}