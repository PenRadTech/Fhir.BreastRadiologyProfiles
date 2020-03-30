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
        SDTaskVar MGAbnormalityArchitecturalDistortion = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("MGAbnormalityArchitecturalDistortion",
                            "Mammography Architectural Distortion",
                            "MG Arch. Distortion",
                            Global.ObservationUrl,
                            $"{Group_MGResources}/AbnormalityArchitecturalDistortion",
                            "ObservationLeaf")
                        .AddFragRef(Self.ObservationLeafFragment.Value())
                        .AddFragRef(Self.ObservationNoDeviceFragment.Value())
                        .AddFragRef(Self.ObservationNoComponentFragment.Value())
                        .AddFragRef(Self.ObservationNoValueFragment.Value())
                        .AddFragRef(Self.CommonComponentsFragment.Value())
                        .AddFragRef(Self.ObservationComponentShapeFragment.Value())
                        .AddFragRef(Self.ObservationComponentNotPreviouslySeenFragment.Value())
                        .AddFragRef(Self.ObservationComponentCorrespondsWithFragment.Value())
                        .AddFragRef(Self.ObservationComponentPreviouslyDemonstratedByFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberAssociatedFeaturesFragment.Value())
                        .AddFragRef(Self.ObservationHasMemberConsistentWithFragment.Value())
                        .Description("Architectural Distortion Observation",
                            new Markdown())
                    ;
                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeMGAbnormalityArchitecturalDistortion.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeMGAbnormalityArchitecturalDistortion.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    //+ IntroDocDescription
                        .Description("642",
                            "Many breast masses are found within the zone of fibroglandular ",
                            "tissue or at a fat-fibroglandular",
                            "junction. ",
                            "If the mass blurs a tissue plane between fat and ",
                            "fibroglandular tissue or if the ",
                            "mass produces distortion of the ducts, these findings ",
                            "may be termed architectural distortion. ",
                            "###ACRUS#139")
                    //- IntroDocDescription
                    .ACRDescription(
                        "The parenchyma is distorted with no definite mass visible. For mammography, this includes thin",
                        "straight lines or spiculations radiating from a point, and focal retraction, distortion or straightening",
                        "at the anterior or posterior edge of the parenchyma. Architectural distortion may also be associ-",
                        "ated with a mass, asymmetry, or calcifications. In the absence of appropriate history of trauma or",
                        "surgery, architectural distortion is suspicious for malignancy or radial scar, and tissue diagnosis is",
                        "appropriate.",
                        "As an ASSOCIATED FEATURE, architectural distortion may be used in conjunction with another",
                        "finding to indicate that the parenchyma is distorted or retracted adjacent to the FINDING")
                    ;
            });
    }
}
