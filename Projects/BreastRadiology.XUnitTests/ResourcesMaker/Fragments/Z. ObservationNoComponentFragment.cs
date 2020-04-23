using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar ObservationNoComponentFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("BreastRadObservationNoComponentFragment",
                            "Observation No Component Fragment",
                            "Observation/No Component/Fragment",
                            Global.ObservationUrl)
                        .Description("Observation No Component fragment",
                            new Markdown()
                                .Paragraph("Zero's Observation.component.")
                        )
                        .Description("Observation NoComponent Fragment.",
                            new Markdown()
                                .Paragraph(
                                    "Resource fragment used by all BreastRad observations that do not have components.")
                        )
                        .AddFragRef(Self.ObservationFragment.Value())
                    ;
                s = e.SDef;

                e.Select("component").Zero();
            });
    }
}