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
        SDTaskVar ObservationComponentPreviouslyDemonstratedByFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("PreviouslyDemonstratedByFragment",
                            "PreviouslyDemonstratedBy Fragment",
                            "PreviouslyDemonstratedBy Fragment",
                            Global.ObservationUrl)
                        .Description("Observation 'Demonstrated By' Component Fragment",
                            new Markdown()
                        )
                    ;
                s = e.SDef;

                e.StartComponentSliceing();
                e.ComponentSliceCodeableConcept("PreviouslyDemonstratedBy",
                    Self.ComponentSliceCodePreviouslyDemonstratedBy.ToCodeableConcept(),
                    Self.PreviouslyDemonstratedByVS.Value(),
                    BindingStrength.Extensible,
                    0,
                    "*",
                    "Previously Demonstrated By",
                    "specifies what this observation has been previously demonstrated by");
            });
    }
}