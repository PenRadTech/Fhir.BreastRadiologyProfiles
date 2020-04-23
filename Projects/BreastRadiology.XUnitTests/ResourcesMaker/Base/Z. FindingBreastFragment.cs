using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar FindingBreastFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("FindingBreastFragment",
                            "Finding Breast Fragment",
                            "Finding/Breast/Fragment",
                            Global.ObservationUrl)
                        .Description("Fragment definition for finding section of left or right breast",
                            new Markdown()
                                .Paragraph(
                                    "This fragment defines the elements of a finding section of a left or right breast.")
                        )
                        .AddFragRef(Self.HeaderFragment)
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                    ;
                s = e.SDef;

                {
                    ValueSet binding = Self.BiRadsAssessmentCategoriesVS.Value();
                    ElementDefinition valueXDef = e.Select("value[x]")
                            .ZeroToOne()
                            .Type("CodeableConcept")
                            .Binding(binding, BindingStrength.Required)
                            .MustSupport()
                        ;

                    e.AddComponentLink("Finding Value",
                        new SDefEditor.Cardinality(valueXDef),
                        null,
                        Global.ElementAnchor(valueXDef),
                        "CodeableConcept",
                        binding.Url);
                }
                ElementTreeNode sliceElementDef = e.ConfigureSliceByUrlDiscriminator("hasMember", false);

                {
                    ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.MGFinding.Value(), 0, "1");
                    slice.ElementDefinition.MustSupport();
                }
                {
                    ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.MRIFinding.Value(), 0, "1");
                    slice.ElementDefinition.MustSupport();
                }
                {
                    ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.NMFinding.Value(), 0, "1");
                    slice.ElementDefinition.MustSupport();
                }
                {
                    ElementTreeSlice slice = e.SliceTargetReference(sliceElementDef, Self.USFinding.Value(), 0, "1");
                    slice.ElementDefinition.MustSupport();
                }
            });
    }
}