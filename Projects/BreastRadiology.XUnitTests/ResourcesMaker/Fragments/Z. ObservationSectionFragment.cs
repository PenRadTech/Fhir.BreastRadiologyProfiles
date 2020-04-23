using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar ObservationSectionFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("ObservationSectionFragment",
                            "Observation Section Fragment",
                            "Section/Fragment",
                            Global.ObservationUrl)
                        .Description("Observation section fragment",
                            new Markdown()
                                .Paragraph(
                                    "this fragment constrains a generic observation to be a observation section.")
                        )
                        .AddFragRef(Self.ObservationFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                    ;
                s = e.SDef;

                e.Select("interpretation").Zero();
                e.Select("method").Zero();
                e.AddIncompatibleFragment(Self.ObservationLeafFragment.Value().Url);
            });
    }
}