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
        SDTaskVar ObservationComponentObservedChangesFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("ObservedChangesFragment",
                            "ObservedChanges Fragment",
                            "ObservedChanges Fragment",
                            Global.ObservationUrl)
                        .Description("Fragment that adds 'Observed Changes' element to profile.",
                            new Markdown()
                        )
                    ;
                s = e.SDef;

                e.StartComponentSliceing();

                e.ComponentSliceCodeableConcept("obsChanges",
                    Self.ComponentSliceCodeObservedChanges.ToCodeableConcept(),
                    Self.ObservedChangesVS.Value(),
                    BindingStrength.Required,
                    0,
                    "*",
                    "Observed Change In Abnormality",
                    "define observed changes in this abnormality");
            });
    }
}