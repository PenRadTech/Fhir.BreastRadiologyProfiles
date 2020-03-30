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
        //#CSTaskVar USVascularityCS = new CSTaskVar(
        //     () =>
        //         cs = Self.CreateCodeSystem(
        //             "USVascularityCS",
        //             "US Echo Pattern CodeSystem",
        //             "US Vascularity/CodeSystem",
        //             "Ultra-sound Vascularity code system.",
        //             Group_USCodesCS,
        //             new ConceptDef[]
        //             {
        //            new ConceptDef("Adjacent",
        //                "Adjacent",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("IncreaseSurround",
        //                "Increase Surround",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Increased",
        //                "Increased",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("NoIncrease",
        //                "No increase",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("NotPresent",
        //                "Not present",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Present",
        //                "Present",
        //                new Definition()
        //                    .Line("[PR]")
        //                )
        //             })
        //         );


        //#VSTaskVar USVascularityVS = new VSTaskVar(
        //    () =>
        //        vs = Self.CreateValueSet(
        //            "USVascularityVS",
        //            "US Vascularity ValueSet",
        //            "US Vascularity/ValueSet",
        //            "Ultra-sound Vascularity codes value set.",
        //            Group_USCodesVS,
        //            Self.USVascularityCS.Value()
        //            )
        //    );

        //#    SDTaskVar USVascularity = new SDTaskVar(
        //        (out StructureDefinition  s) =>
        //        {
        //            ValueSet binding = Self.USVascularityVS.Value();

        //            {
        //                IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //                valueSetIntroDoc
        //                    .ValueSet(binding);
        //                    .ReviewedStatus("No One", "")
        //                ;
        //                String outputPath = valueSetIntroDoc.Save();
        //                Self.fc?.Mark(outputPath);
        //            }

        //            SDefEditor e = Self.CreateEditor("USVascularity",
        //                    "US Vascularity",
        //                    "US Vascularity",
        //                    ObservationUrl,
        //                    $"{Group_USResources}/Vascularity")
        //                .Description("Ultra-Sound Vascularity Observation",
        //                    new Markdown()
        //                        .Paragraph("[PR]")
        //                    )
        //                .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //                .AddFragRef(Self.ObservationLeafFragment.Value())
        //                ;

        //            s = e.SDef.Url;

        //            e.IntroDoc
        //                .CodedObservationLeafNode("an ultra-sound vascularity", binding)
        //                .ReviewedStatus("No One", "")
        //                ;

        //            e.Select("value[x]")
        //                .Type("CodeableConcept")
        //                .Binding(binding.Url, BindingStrength.Required)
        //                ;
        //            e.AddValueSetLink(binding);
        //        });
    }
}