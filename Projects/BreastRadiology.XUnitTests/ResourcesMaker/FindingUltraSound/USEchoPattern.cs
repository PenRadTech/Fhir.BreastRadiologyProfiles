using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.IO;
using Eir.DevTools;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        //CSTaskVar USEchoPatternCS = new CSTaskVar(
        //     () =>
        //         cs = Self.CreateCodeSystem(
        //             "USEchoPatternCS",
        //             "US Echo Pattern CodeSystem",
        //             "US Echo Pattern/CodeSystem",
        //             "Ultra-sound mass echo pattern code system.",
        //             Group_USCodesCS,
        //             new ConceptDef[]
        //             {
        //            new ConceptDef("Anechoic",
        //                "Anechoic",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("Without internal echoes.")
        //                .CiteEnd()
        //                ),
        //            new ConceptDef("ComplexCysticAndSolid",
        //                "Complex Cystic and Solid",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("A complex mass contains both anechoic (cystic or fluid) and echogenic (solid) components.")
        //                    .Line("Not [PR]")
        //                .CiteEnd()
        //                ),
        //            new ConceptDef("FibrocysticTissue",
        //                "Fibrocystic Tissue",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //             new ConceptDef("Heterogeneous",
        //                "Heterogeneous",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("A mixture of echogenic patterns within a solid mass. Heterogeneity has little prognostic")
        //                    .Line("value in differentiating benign from malignant masses, but it is not uncommon to observe")
        //                    .Line("heterogeneity in fibroadenomas as well as cancers. Clumped areas of different echogenicity")
        //                    .Line("may elevate the suspicion for malignancy, particularly in a mass whose margins are not")
        //                    .Line("circumscribed and whose shape is irregular.")
        //                .CiteEnd()
        //                ),
        //             new ConceptDef("Homogeneous",
        //                "Homogeneous",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //           new ConceptDef("Hyperechoic",
        //                "Hyperechoic",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("Hyperechogenicity is defined as having increased echogenicity relative to fat or equal to fibroglandular tissue.")
        //                .CiteEnd()
        //                ),
        //            new ConceptDef("Hypoechoic",
        //                "Hypoechoic",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("The term “hypoechoic” is defined relative to subcutaneous fat; hypoechoic masses, less")
        //                    .Line("echogenic than fat, are characterized by low-level echoes throughout (for example,")
        //                    .Line("complicated cysts and fibroadenomas)")
        //                .CiteEnd()
        //                ),
        //            new ConceptDef("Isoechoic",
        //                "Isoechoic",
        //                new Definition()
        //                .CiteStart(BiRadCitation)
        //                    .Line("Isoechogenicity is defined as having the same echogenicity as subcutaneous fat. Isoechoic")
        //                    .Line("masses may be relatively inconspicuous, particularly when they are situated within an area of")
        //                    .Line("fat lobules. This may limit the sensitivity of US, especially at screening, in which the presence")
        //                    .Line("and location of such a mass is not known at the time of examination.")
        //                .CiteEnd()
        //                ),
        //            new ConceptDef("MixedEchogenic",
        //                "Mixed Echogenic",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Septated",
        //                "Mixed Echogenic",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("Sonolucent",
        //                "Sonolucent",
        //                new Definition()
        //                    .Line("[PR]")
        //                ),
        //            new ConceptDef("WithInternalEchos",
        //                "With Internal Echos",
        //                new Definition()
        //                    .Line("[PR]")
        //                )
        //             })
        //         );


        //#VSTaskVar USEchoPatternVS = new VSTaskVar(
        //    () =>
        //        vs = Self.CreateValueSet(
        //            "USEchoPatternVS",
        //            "US Echo Pattern ValueSet",
        //            "US Echo Pattern/ValueSet",
        //            "Ultra-sound mass echo pattern codes value set.",
        //            Group_USCodesVS,
        //            Self.USEchoPatternCS.Value())
        //    );


        //#SDTaskVar USEchoPattern = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        ValueSet binding = Self.USEchoPatternVS.Value();

        //        {
        //            IntroDoc valueSetIntroDoc = Self.CreateIntroDocVS(binding);
        //            valueSetIntroDoc
        //                .ValueSet(binding);
        //                .ReviewedStatus("No One", "")
        //            ;
        //            String outputPath = valueSetIntroDoc.Save();
        //            Self.fc?.Mark(outputPath);
        //        }

        //        SDefEditor e = Self.CreateEditor("USEchoPattern",
        //                "US Echo Pattern",
        //                "US Echo Pattern",
        //                ObservationUrl,
        //                $"{Group_USResources}/EchoPattern")
        //            .Description("Ultra-Sound Echo Pattern Observation",
        //                new Markdown()
        //                    .BiradHeader()
        //                    .BlockQuote("The echogenicity of most benign and malignant masses is hypoechoic compared with ")
        //                    .BlockQuote("mammary fat. While many completely echogenic masses are benign, prospective assessment as")
        //                    .BlockQuote("benign has greater dependency on marginal circumscription. Although the echo pattern")
        //                    .BlockQuote("contributes with other feature categories to the assessment of a breast lesion, echogenicity")
        //                    .BlockQuote("alone has little specificity.")
        //                    .BiradFooter()
        //                )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ObservationLeafFragment.Value())
        //            ;
        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .CodedObservationLeafNode("an ultra-sound mass echo pattern", binding)
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