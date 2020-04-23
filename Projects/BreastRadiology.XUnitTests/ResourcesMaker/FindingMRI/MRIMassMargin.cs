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
        //#CSTaskVar MRIMarginCS = new CSTaskVar(
        //     (out CodeSystem cs) =>
        //         cs = Self.CreateCodeSystem(
        //             "MRIMarginCS",
        //             "MRI Margin CodeSystem",
        //             "MRI/Margin CodeSystem",
        //             "MRI margin code system.",
        //             Group_MRICodesCS,
        //             new ConceptDef[]
        //             {
        //            new ConceptDef("Irregular",
        //                "Irregular Margin",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Macrolobulated",
        //                "Microlobulated Margin",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Obscured",
        //                "Obscured Margin",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("A margin that is hidden by superimposed or adjacent fibroglandular tissue. This is used")
        //                    .Line("primarily when some of the margin of the mass is circumscribed, but the rest (more than 25%) is hidden.")
        //                .CiteEnd()
        //                ),
        //            new ConceptDef("Smooth",
        //                "Smooth Margin",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Spiculated",
        //                "Spiculated Margin",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("The margin is characterized by lines radiating from the mass. Use of this descriptor usually")
        //                    .Line("implies a suspicious finding.")
        //                .CiteEnd()
        //                )
        //             })
        //         );


        //#VSTaskVar MRIMarginVS = new VSTaskVar(
        //    (out CodeSystem cs) =>
        //        vs = Self.CreateValueSet(
        //            "MRIMarginVS",
        //            "MRI Margin ValueSet",
        //            "MRI/Margin ValueSet",
        //            "MRI margin value set.",
        //            Group_MRICodesVS,
        //            Self.MRIMarginCS.Value()
        //            )
        //    );


        //#SDTaskVar MRIMargin = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.MRIMarginVS.Value();
        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("MRIMargin",
        //            "MRI Margin",
        //            "MRI/Margin",
        //            ObservationUrl,
        //            $"{Group_MRIResources}/Margin")
        //            .Description("MRI Margin Observation",
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
        //            .CodedObservationLeafNode("a MRI margin", binding)
        //            .ReviewedStatus("No One", "")
        //            ;

        //        e.Select("value[x]")
        //                .Type("CodeableConcept")
        //                .Binding(binding.Url, BindingStrength.Required)
        //                ;
        //        e.AddValueSetLink(binding);
        //    });
    }
}