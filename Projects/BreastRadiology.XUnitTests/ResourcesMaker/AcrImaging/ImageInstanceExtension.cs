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

        public SDTaskVar ImageInstanceExtension = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e;
                ElementTreeNode extensionNode = null;

                void SliceOid(String sliceName,
                    String shortText,
                    Markdown definition,
                    out ElementTreeSlice extensionSlice,
                    out ElementTreeNode valueXNode
                )
                {
                    Self.Slice(e,
                        extensionNode,
                        sliceName,
                        shortText,
                        definition,
                        out extensionSlice,
                        out valueXNode
                    );
                    valueXNode.ElementDefinition
                        .Type("oid")
                        .Single()
                        ;

                    e.AddComponentLink(sliceName.ToMachineName(),
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        null,
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        "Oid");
                }

                e = Self.CreateEditor("ImageInstanceExtension",
                            "Image Instance Extension",
                            "Image Instance Extension",
                            Global.ExtensionUrl,
                            $"{ResourcesMaker.Group_AimResources}",
                            "Extension")
                        .Description("Image Instance Extension",
                            new Markdown()
                                .Paragraph(
                                    "Specifies DICOM Instance"
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

                // Slice sopClass .
                {
                    SliceOid("sopClass",
                        "Image Instance SopClass",
                        new Markdown()
                            .Paragraph("Image Instance SopClass"),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .ZeroToOne()
                        ;
                }

                // Slice UID .
                {
                    SliceOid("uid",
                        "Image Instance UID",
                        new Markdown()
                            .Paragraph("Image Instance UID"),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .Single()
                        ;
                }

                // frameNumber
                {
                    String sliceName = "frameNumber";
                    Self.Slice(e,
                        extensionNode,
                        sliceName,
                        "Image frame number",
                        new Markdown()
                            .Paragraph("Image frame number"),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .ZeroToMany()
                        ;
                    valueXNode.ElementDefinition
                        .Type("integer")
                        .Single()
                        ;

                    e.AddComponentLink(sliceName.ToMachineName(),
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        null,
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        "Oid");
                    extensionSlice.ElementDefinition
                        .Single()
                        ;
                }

                // Slice Observation UID .
                {
                    SliceOid("observationUid",
                        "Image Instance Observation UID",
                        new Markdown()
                            .Paragraph("Image Instance Observation UID"),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .ZeroToMany()
                        ;
                }

                // Slice Tracking UID .
                {
                    SliceOid("trackingUid",
                        "Image Instance Tracking UID",
                        new Markdown()
                            .Paragraph("Image Instance Tracking UID"),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .ZeroToMany()
                        ;
                }

                // imageRegion
                {
                    StructureDefinition extensionStructDef = Self.ImageRegionExtension.Value();
                    ElementDefinition extensionDef = e.ApplyExtension(extensionNode,
                            "imageRegion",
                            extensionStructDef.Url)
                        .ElementDefinition
                        .ZeroToOne();

                    e.AddExtensionLink(extensionStructDef.Url,
                        new SDefEditor.Cardinality(extensionDef),
                        "Image Region",
                        Global.ElementAnchor(extensionDef),
                        false);
                }

                //e.IntroDoc
                //    ;
            });
    }
}