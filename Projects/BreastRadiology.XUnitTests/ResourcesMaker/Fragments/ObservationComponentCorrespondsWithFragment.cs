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
        SDTaskVar ObservationComponentCorrespondsWithFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("CorrespondsWithFragment",
                            "CorrespondsWith Fragment",
                            "CorrespondsWith Fragment",
                            Global.ObservationUrl)
                        .Description("Observation 'Consistent With' Component Fragment",
                            new Markdown()
                        )
                    ;
                s = e.SDef;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("correspondsWith",
                    Self.ComponentSliceCodeCorrespondsWith.ToCodeableConcept(),
                    Self.CorrespondsWithVS.Value(),
                    BindingStrength.Extensible,
                    0,
                    "*",
                    "Corresponds With",
                    "define what this observation corresponds with");
            });
    }
}