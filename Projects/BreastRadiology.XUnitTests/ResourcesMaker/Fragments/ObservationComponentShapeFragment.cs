using Eir.DevTools;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        SDTaskVar ObservationComponentShapeFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("ShapeComponentsFragment",
                            "Shape Components Fragment",
                            "Shape Components Fragment",
                            Global.ObservationUrl)
                        .Description("Shape component slice fragment",
                            new Markdown()
                                .Paragraph("Adds Orientation, Shape, Margin, and Density Components")
                        )
                        .AddFragRef(Self.BreastBodyLocationRequiredFragment.Value())
                    ;
                s = e.SDef;

                e.StartComponentSliceing();

                e.ComponentSliceCodeableConcept("orientation",
                    Self.ComponentSliceCodeOrientation.ToCodeableConcept(),
                    Self.OrientationVS.Value(),
                    BindingStrength.Required,
                    0,
                    "1",
                    "Orientation",
                    "define the orientation of the abnormality");

                e.ComponentSliceCodeableConcept("shape",
                    Self.ComponentSliceCodeShape.ToCodeableConcept(),
                    Self.ShapeVS.Value(),
                    BindingStrength.Required,
                    0,
                    "1",
                    "Shape",
                    "define the shape of the abnormality");

                e.ComponentSliceCodeableConcept("margin",
                    Self.ComponentSliceCodeMargin.ToCodeableConcept(),
                    Self.MarginVS.Value(),
                    BindingStrength.Required,
                    0,
                    "1",
                    "Margin",
                    "define the observed margin of the abnormality");

                e.ComponentSliceCodeableConcept("mgDensity",
                    Self.ComponentSliceCodeMGDensity.ToCodeableConcept(),
                    Self.MGDensityVS.Value(),
                    BindingStrength.Required,
                    0,
                    "1",
                    "Density",
                    "define the observed density of the breast tissue",
                    Modalities.MG
                );
            });
    }
}