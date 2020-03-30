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
    partial class ResourcesMaker
    {
        //#VSTaskVar UltraSoundShapeVS = new VSTaskVar(
        //    () =>
        //    {
        //        ValueSet binding = Self.CreateValueSet(
        //                "UltraSoundShapeVS",
        //                "ShapeValueSet",
        //                "Shape/ValueSet",
        //                "Shape value set.",
        //                Group_USCodesVS,
        //                Self.ShapeCS.Value()
        //            );
        //        binding.Remove("Reniform");
        //        return binding;
        //    }
        //    );


        //#SDTaskVar USShape = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.UltraSoundShapeVS.Value();
        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("UltraSoundShape",
        //                "Shape",
        //                "Shape",
        //                ObservationUrl,
        //                $"{Group_CommonResources}/Shape")
        //            .Description("Shape Observation",
        //                new Markdown()
        //            )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ObservationLeafFragment.Value())
        //            ;

        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .CodedObservationLeafNode("a shape", binding)
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