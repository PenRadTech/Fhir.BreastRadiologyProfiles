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
        //#CSTaskVar USElasticityCS = new CSTaskVar(
        //     () =>
        //         cs = Self.CreateCodeSystem(
        //             "USElasticityCS",
        //             "US Echo Pattern CodeSystem",
        //             "US Elasticity/CodeSystem",
        //             "Ultra-sound Elasticity code system.",
        //             Group_USCodesCS,
        //             new ConceptDef[]
        //             {
        //            new ConceptDef("Soft",
        //                "Soft",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Medium",
        //                "Medium",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Hard",
        //                "Hard",
        //                new Definition()
        //                    .Line("[PR]")
        //                )
        //             })
        //         );


        //#VSTaskVar USElasticityVS = new VSTaskVar(
        //    () =>
        //        vs = Self.CreateValueSet(
        //            "USElasticityVS",
        //            "US Elasticity ValueSet",
        //            "US Elasticity/ValueSet",
        //            "Ultra-sound Elasticity  value set.",
        //            Group_USCodesVS,
        //            Self.USElasticityCS.Value())
        //    );

        //#SDTaskVar USElasticity = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.USElasticityVS.Value();
        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("USElasticity",
        //                "US Elasticity",
        //                "US Elasticity",
        //                ObservationUrl,
        //                $"{Group_USResources}/Elasticity")
        //            .Description("Ultra-Sound Elasticity Observation",
        //                new Markdown()
        //                    .Paragraph("[PR]")
        //                )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ObservationLeafFragment.Value())
        //            ;
        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .CodedObservationLeafNode("an ultra-sound vascularity", binding)
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