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
        public SDTaskVar ImageStudyDerivedFromExtension = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e;

                e = Self.CreateEditor("ImageStudyDerivedFromExtension",
                            "Image Study Derived From Extension",
                            "Image Study Derived From Extension",
                            Global.ExtensionUrl,
                            $"{ResourcesMaker.Group_AimResources}",
                            "Extension")
                        .Description("Image Study Derived From Extension",
                            new Markdown()
                                .Paragraph(
                                    "Specifies DICOM Study reference that the current study is derived from"
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

                String[] targets = new string[] { Self.ImagingContextExtension.Value().Url };
                e.Select("value[x]")
                    .Type("Reference", null, targets)
                    .Single();

                //e.IntroDoc
                //    ;
            });
    }
}