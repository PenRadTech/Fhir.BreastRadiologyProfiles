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
        //#CSTaskVar USBoundaryCS = new CSTaskVar(
        //     () =>
        //         cs = Self.CreateCodeSystem(
        //             "USBoundaryCS",
        //             "Ultra-Sound Boundary CodeSystem",
        //             "US Boundary/CodeSystem",
        //             "Ultra Sound Boundary code system.",
        //             Group_USCodesCS,
        //             new ConceptDef[]
        //             {
        //            new ConceptDef("WellDefined",
        //                "Well defined boundary",
        //                new Definition()
        //                    .Line("[PR]")
        //            ),
        //            new ConceptDef("Abrupt",
        //                "Abrupt boundary",
        //                new Definition()
        //                    .Line("[PR]")
        //            ),
        //            new ConceptDef("Echogenic",
        //                "Echogenic boundary",
        //                new Definition()
        //                    .Line("[PR]")
        //            ),
        //            new ConceptDef("Hyperechoic",
        //                "Hyperechoic boundary",
        //                new Definition()
        //                    .Line("[PR]")
        //            )
        //             }
        //         )
        //     );


        //#VSTaskVar USBoundaryVS = new VSTaskVar(
        //    () =>
        //        vs = Self.CreateValueSet(
        //            "USBoundaryVS",
        //            "Ultra-Sound Boundary ValueSet",
        //            "US Boundary/ValueSet",
        //            "Ultra-Sound Boundary Codes value set.",
        //            Group_USCodesVS,
        //            Self.USBoundaryCS.Value()
        //            )
        //    );


        //#SDTaskVar USBoundary = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.USBoundaryVS.Value();

        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("USBoundary",
        //            "Ultra Sound Boundary",
        //            "US Boundary",
        //            ObservationUrl,
        //            $"{Group_USResources}/Boundary")
        //            .Description("Ultra-Sound Boundary Observation",
        //                new Markdown()
        //                    .Paragraph("This resource describes an Ultra-Sound boundary observation.")
        //                    .Paragraph("[PR]")
        //             )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ObservationLeafFragment.Value())
        //            ;

        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .CodedObservationLeafNode("an UltraSound boundary", binding)
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