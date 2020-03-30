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
        //#CSTaskVar NMMarginCS = new CSTaskVar(
        //     () =>
        //         cs = Self.CreateCodeSystem(
        //             "NMMarginCS",
        //             "NM Margin CodeSystem",
        //             "NM/Margin/CodeSystem",
        //             "NM margin code system.",
        //             Group_NMCodesCS,
        //             new ConceptDef[]
        //             {
        //            new ConceptDef("Circumscribed ",
        //                "Circumscribed Margin",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("(historically, \"well defined\" or \"sharply defined\")")
        //                    .Line("The margin is sharply demarcated with an abrupt transition between the lesion and the surrounding tissue.")
        //                .CiteEnd()
        //                )
        //             })
        //         );


        //#VSTaskVar NMMarginVS = new VSTaskVar(
        //    () =>
        //        vs = Self.CreateValueSet(
        //                "NMMarginVS",
        //                "NM Margin ValueSet",
        //                "NM/Margin/ValueSet",
        //                "NM margin value set.",
        //                Group_NMCodesVS,
        //                Self.NMMarginCS.Value()
        //            )
        //    );


        //#SDTaskVar NMMargin = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.NMMarginVS.Value();

        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("NMMargin",
        //            "NM Margin",
        //            "NM/Margin",
        //            ObservationUrl,
        //            $"{Group_NMResources}/Margin")
        //            .Description("NM Margin Observation",
        //                new Markdown()
        //                    .BiradHeader()
        //                    .BlockQuote("The margin is the edge or border of the lesion. The descriptors of margin, like the descriptors of shape, are important predictors of whether a mass is benign or malignant. ")
        //                    .BiradFooter()
        //            )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ObservationLeafFragment.Value())
        //            ;
        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .CodedObservationLeafNode("a NM margin", binding)
        //            .ReviewedStatus("No One", "")
        //            ;

        //        e.Select("value[x]")
        //            .Type("CodeableConcept")
        //            .Binding(binding.Url, BindingStrength.Required)
        //            ;
        //        e.AddValueSetLink(binding);
        //    });
    }
}