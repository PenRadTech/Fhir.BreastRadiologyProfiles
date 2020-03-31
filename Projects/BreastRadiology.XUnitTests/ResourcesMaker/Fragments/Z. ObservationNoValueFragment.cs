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
        SDTaskVar ObservationNoValueFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("BreastRadObservationNoValueFragment",
                            "Observation NoValue Fragment",
                            "Observation/NoValue/Fragment",
                            Global.ObservationUrl)
                        .Description("Observation No Value fragment",
                            new Markdown()
                                .Paragraph("Base fragment for all BreastRad observations that have no explicit value.")
                        )
                        .AddFragRef(Self.ObservationFragment.Value())
                    ;
                s = e.SDef;

                e.Select("dataAbsentReason").Zero();
                e.Select("value[x]").Zero();
                e.Select("interpretation").Zero();
                e.Select("referenceRange").Zero();
            });
    }
}