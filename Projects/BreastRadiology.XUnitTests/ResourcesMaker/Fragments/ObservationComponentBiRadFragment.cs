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
        SDTaskVar ObservationComponentBiRadFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("BiRadFragment",
                            "BiRad Fragment",
                            "BiRad Fragment",
                            Global.ObservationUrl)
                        .Description("Fragment that adds 'BiRad code' element to profile.",
                            new Markdown()
                        )
                    ;
                s = e.SDef;

                e.StartComponentSliceing();

                e.ComponentSliceCodeableConcept("biRadsAssessmentCategory",
                    Self.ComponentSliceCodeBiRads.ToCodeableConcept(),
                    Self.BiRadsAssessmentCategoriesVS.Value(),
                    BindingStrength.Required,
                    0,
                    "1",
                    "BiRads Assessment Category",
                    "define the BiRAD risk code");
            });
    }
}