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
        SDTaskVar CommonComponentsFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("CommonComponentsFragment",
                            "Common Components Fragment",
                            "Common Components Fragment",
                            Global.ObservationUrl)
                        .Description("Common Components fragment",
                            new Markdown()
                                .Paragraph("Adds commonly used component slice values, including:")
                                .List("Location", "Changes", "Size", "Area", "BiRad Code", "Recommendations")
                        )
                        .AddFragRef(Self.BreastBodyLocationRequiredFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedChangesFragment.Value())
                        .AddFragRef(Self.ObservationComponentBiRadFragment.Value())
                    ;
                s = e.SDef;

                e.StartComponentSliceing();
            });
    }
}