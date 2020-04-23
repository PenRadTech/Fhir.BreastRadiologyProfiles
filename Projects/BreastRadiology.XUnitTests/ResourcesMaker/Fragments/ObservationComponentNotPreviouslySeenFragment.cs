using Eir.DevTools;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        SDTaskVar ObservationComponentNotPreviouslySeenFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("NotPreviouslySeenComponentFragment",
                            "Not Previously Seen Component Fragment",
                            "Not Previously Seen Component Fragment",
                            Global.ObservationUrl)
                        .Description("Not Previously Seen component slice fragment",
                            new Markdown()
                                .Paragraph("Adds NotPreviously Seen Component slice.")
                        )
                        .AddFragRef(Self.BreastBodyLocationRequiredFragment.Value())
                    ;
                s = e.SDef;

                e.StartComponentSliceing();

                e.ComponentSliceCodeableConcept("notPreviouslySeen",
                    Self.ComponentSliceCodeNotPreviouslySeen.ToCodeableConcept(),
                    Self.NotPreviouslySeenVS.Value(),
                    BindingStrength.Required,
                    0,
                    "*",
                    "Not Previously Seen",
                    "define prevous encounters in which this abnormality was not seen");
            });
    }
}