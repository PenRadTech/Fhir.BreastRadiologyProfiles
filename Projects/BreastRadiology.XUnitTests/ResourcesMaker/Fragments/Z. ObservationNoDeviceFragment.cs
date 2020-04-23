using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar ObservationNoDeviceFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("BreastRadObservationNoDeviceFragment",
                            "Observation NoDevice Fragment",
                            "Observation/NoDevice/Fragment",
                            Global.ObservationUrl)
                        .Description("Observations No Device Data fragment.",
                            new Markdown()
                                .Paragraph("Fragment for all observations that have no device.")
                        )
                        .AddFragRef(Self.ObservationFragment.Value())
                    ;
                s = e.SDef;

                e.Select("device").Zero();
            });
    }
}