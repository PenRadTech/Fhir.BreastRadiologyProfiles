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
        public SDTaskVar ImageSeriesExtension = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e;

                e = Self.CreateEditor("ImageSeriesExtension",
                            "Image Series Extension",
                            "Image Series Extension",
                            Global.ExtensionUrl,
                            $"{ResourcesMaker.Group_AimResources}",
                            "Extension")
                        .Description("Image Series Extension",
                            new Markdown()
                                .Paragraph(
                                    "Specifies DICOM Series"
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

                e.Select("value[x]")
                    .Type("oid")
                    .Single();

                //e.IntroDoc
                //    ;
            });
    }
}