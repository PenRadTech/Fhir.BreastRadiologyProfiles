using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Eir.DevTools;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        public SDTaskVar ImageRegionExtension = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e;
                ElementTreeNode extensionNode;

                e = Self.CreateEditor("ImageRegionExtension",
                            "Image Region Extension",
                            "Image Region Extension",
                            Global.ExtensionUrl,
                            $"{ResourcesMaker.Group_AimResources}",
                            "Extension")
                        .Description("Image Region Extension",
                            new Markdown()
                                .Paragraph(
                                    "Specifies region in a DICOM image or frame"
                                )
                        )
                        .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                        .Context()
                    ;
                s = e.SDef;

                e.AddFragRef(Self.HeaderFragment);

                e.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e.SDef.Url));

                e.Select("value[x]").Zero();

                extensionNode = e.ConfigureSliceByUrlDiscriminator("extension", true);
                ValueSet regionType = Self.GraphicTypeVS.Value();

                // Slice regionType.
                {
                    Self.Slice(e,
                        extensionNode,
                        "regionType",
                        "Image Region Type",
                        new Markdown()
                            .Paragraph("Image Region Type."),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .Single()
                        ;
                    valueXNode.ElementDefinition
                        .Binding(regionType, BindingStrength.Extensible)
                        .Type("CodeableConcept")
                        .Single()
                        ;
                    e.AddComponentLink("RegionType",
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        null,
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        "CodeableConcept",
                        regionType.Url);
                }

                // Slice coordinates.
                {
                    Self.Slice(e,
                        extensionNode,
                        "coordinates",
                        "Image Coordinates",
                        new Markdown()
                            .Paragraph("Image Coordinates.")
                            .Paragraph("String is a series of space separated points.")
                            .Paragraph("Each point is a comma separated sequence of decimal values",
                                        "one for each dimension of the point.")
                            .Paragraph("Point may have two or three dimensions.")
                            .Paragraph("Each and every point in this string will have the same number of dimensions.")
                        ,
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .Single()
                        ;
                    valueXNode.ElementDefinition
                        .Type("string")
                        .Single()
                        ;
                    e.AddComponentLink("Coordinates",
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        null,
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        "string");
                }

                //e.IntroDoc
                //    ;
            });
    }
}