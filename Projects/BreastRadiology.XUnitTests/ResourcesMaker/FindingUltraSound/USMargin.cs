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
        //#VSTaskVar USMarginVS = new VSTaskVar(
        //    () =>
        //    {
        //        ValueSet binding = Self.CreateValueSet(
        //            "USMarginVS",
        //            "US Margin ValueSet",
        //            "US Margin ValueSet",
        //            "Ultra-sound mass margin codes value set.",
        //            Group_USCodesVS,
        //            Self.MarginCS.Value());
        //        binding
        //            .Remove("Macrolobulated")
        //            .Remove("Obscured")
        //            ;
        //        return binding;
        //    }
        //    );


        //#SDTaskVar USMargin = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.USMarginVS.Value();
        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("USMargin",
        //                "US Margin",
        //                "US Margin",
        //                ObservationUrl,
        //                $"{Group_USResources}/Margin")
        //            .Description("Ultra-Sound Margin Observation",
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
        //            .CodedObservationLeafNode("a mammography mass margin", binding)
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