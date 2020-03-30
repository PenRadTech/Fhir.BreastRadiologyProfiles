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

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        SDTaskVar MGAbnormalityFatNecrosis = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("MGAbnormalityFatNecrosis",
                            "Mammography Fat Necrosis",
                            "MG Fat Necrosis",
                            Global.ObservationUrl,
                            $"{Group_MGResources}/AbnormalityFatNecrosis",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentShapeFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedCountFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedSizeFragment.Value())
                        .AddFragRef(Self.ObservationComponentObservedDistributionFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberConsistentWithFragment.Value())
                        .Description("Fat Necrosis Abnormality Observation",
                            new Markdown()
                                .Paragraph("[PR]")
                        )
                    ;

                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeMGAbnormalityFatNecrosis.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeMGAbnormalityFatNecrosis.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    //+ IntroDocDescription
                        .Description("688",
                            "Fat necrosis is a benign (not cancer) condition and ",
                            "does not increase risk of ",
                            "developing breast cancer. ",
                            "It can occur anywhere in the breast and can affect ",
                            "women of any age. ",
                            "Men can also get fat necrosis, but this is very rare.",
                            " Sometimes a lump can form if an area of the fatty ",
                            "breast tissue is damaged. ",
                            "This is called fat necrosis (necrosis is a medical ",
                            "term used to describe damaged ",
                            "or dead tissue).",
                            "Damage to the fatty tissue can occur following a ",
                            "breast biopsy, radiotherapy to the ",
                            "breast or any breast surgery. ",
                            "The fatty breast tissue can  also be damaged by a ",
                            "bruise or injury to the breast. ",
                            "Sometimes it develops without any trauma and many ",
                            "women with it don't remember any ",
                            "specific injury. ",
                            "###URL#https://breastcancernow.org/information-support/have-i-got-breast-cancer/breast-pain-other-benign-conditions/fat-necrosis")
                    //- IntroDocDescription
                    ;

                e.StartComponentSliceing();
            });
    }
}
