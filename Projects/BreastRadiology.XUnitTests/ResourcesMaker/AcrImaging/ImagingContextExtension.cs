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
        public SDTaskVar ImagingContextExtension = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                ElementDefinition CreateElement(ElementTreeSlice slice, String name)
                {
                    ElementDefinition e = new ElementDefinition
                    {
                        Path = $"{slice.ElementDefinition.Path}.{name}",
                        ElementId = $"{slice.ElementDefinition.ElementId}.{name}"
                    };

                    slice.CreateNode(e);
                    return e;
                }

                SDefEditor e;
                ElementTreeNode extensionNode;

                e = Self.CreateEditor("ImagingContextExtension",
                            "Image Region Extension",
                            "Imaging Context Extension",
                            Global.ExtensionUrl,
                            $"{ResourcesMaker.Group_AimResources}",
                            "Extension")
                        .Description("Imaging Context Extension",
                            new Markdown()
                                .Paragraph(
                                    "Imaging Reference context as an extension of DocumentReference"
                                )
                        )
                        .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                        .Context(StructureDefinition.ExtensionContextType.Element,
                            "DocumentReference")
                    ;
                s = e.SDef;

                e.AddFragRef(Self.HeaderFragment);

                e.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e.SDef.Url));

                e.Select("value[x]")
                    .Zero()
                    .Type("code")
                    ;

                extensionNode = e.ConfigureSliceByUrlDiscriminator("extension", true);

                ElementDefinition SubExtension(String sliceName,
                    String subExtensionUrl)
                {
                    ElementTreeSlice extensionSlice = e.ApplyExtension(extensionNode,
                        sliceName,
                        subExtensionUrl);

                    e.AddExtensionLink(subExtensionUrl,
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        "Study Uid",
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        false);

                    {
                        ElementDefinition elementUrl = new ElementDefinition()
                                .Path($"{extensionNode.ElementDefinition.Path}.url")
                                .ElementId($"{extensionNode.ElementDefinition.Path}:{sliceName}.url")
                                .Value(new FhirUri(sliceName))
                                .Type("uri")
                                .Definition(new Markdown()
                                    .Paragraph($"Url for {sliceName} complex extension item.")
                                )
                            ;
                        extensionSlice.CreateNode(elementUrl);
                    }

                    return extensionSlice.ElementDefinition;
                }

                // Study Oid
                {
                    SubExtension("studyUid", Self.ImageStudyExtension.Value().Url)
                        .Single()
                        ;
                }

                // derivedFrom
                {
                    StructureDefinition extensionStructDef = Self.ImageStudyDerivedFromExtension.Value();
                    ElementDefinition extensionDef = e.ApplyExtension(extensionNode,
                            "derivedFrom",
                            extensionStructDef.Url)
                        .ElementDefinition
                        .ZeroToOne();

                    e.AddExtensionLink(extensionStructDef.Url,
                        new SDefEditor.Cardinality(extensionDef),
                        "Derived From",
                        Global.ElementAnchor(extensionDef),
                        false);
                }

                // Series Oid
                {
                    StructureDefinition extensionStructDef = Self.ImageSeriesExtension.Value();
                    ElementDefinition extensionDef = e.ApplyExtension(extensionNode,
                            "seriesUid",
                            extensionStructDef.Url)
                        .ElementDefinition
                        .Single();

                    e.AddExtensionLink(extensionStructDef.Url,
                        new SDefEditor.Cardinality(extensionDef),
                        "Series Uid",
                        Global.ElementAnchor(extensionDef),
                        false);
                }

                // instance
                {
                    StructureDefinition extensionStructDef = Self.ImageInstanceExtension.Value();
                    ElementDefinition extensionDef = e.ApplyExtension(extensionNode,
                            "instance",
                            extensionStructDef.Url)
                        .ElementDefinition
                        .ZeroToMany();

                    e.AddExtensionLink(extensionStructDef.Url,
                        new SDefEditor.Cardinality(extensionDef),
                        "Instance",
                        Global.ElementAnchor(extensionDef),
                        false);
                }
                e.SDef.Snapshot = null;
                //e.IntroDoc
                //    ;
                //$Self.ImagingContextExample();
            });
    }
}