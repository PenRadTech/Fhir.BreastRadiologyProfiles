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
        //#CSTaskVar HilumCS = new CSTaskVar(
        //     (out CodeSystem cs) =>
        //         cs = Self.CreateCodeSystem(
        //                 "HilumCodeSystemCS",
        //                 "Hilum CodeSystem",
        //                 "Hilum/CodeSystem",
        //                 "Hilum values code system.",
        //                 Group_CommonCodesCS,
        //                 new ConceptDef[]
        //                 {
        //                new ConceptDef("HilumFatty",
        //                    "Hilum Fatty",
        //                    new Definition()
        //                        .Line("Definition needed")
        //                    ),
        //                new ConceptDef("Hilum Not Fatty",
        //                    "Hilum Not Fatty",
        //                    new Definition()
        //                        .Line("Definition needed")
        //                    )
        //                 })
        //             );

        //#VSTaskVar HilumVS = new VSTaskVar(
        //    (out ValueSet vs) =>
        //        vs = Self.CreateValueSet(
        //                "HilumVS",
        //                "Hilum ValueSet",
        //                "Hilum/ValueSet",
        //                "Hilum value set.",
        //                Group_CommonCodesVS,
        //                Self.HilumCS.Value())
        //    );

        //#SDTaskVar Hilum = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.HilumVS.Value();

        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("Hilum",
        //                "Hilum Shape",
        //                "Hilum/Shape",
        //                ObservationUrl,
        //                $"{Group_CommonResources}/Hilum")
        //            .Description("Hilum Observation",
        //                new Markdown()
        //                        "Definition(s) needed"
        //                    )
        //            )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationLeafFragment.Value())
        //            ;

        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .CodedObservationLeafNode("a hilum", binding)
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