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
        SDTaskVar FindingsRightBreast = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("SectionFindingsRightBreast",
                            "Findings Right Breast",
                            "Findings/Right Breast",
                            Global.ObservationUrl,
                            $"{Group_BaseResources}/Findings/RightBreast",
                            "ObservationSection")
                        .Description("Findings Right Breast Section",
                            new Markdown()
                                .Paragraph("This Observation contains references to all the observations",
                                           "and exam information related to the left breast.")
                        )
                        .AddFragRef(Self.FindingBreastFragment.Value())
                    ;
                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeFindingsRightBreast.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeFindingsRightBreast.ToCodeableConcept())
                    ;
                {
                    CodeableConcept coding =
                        new Coding(Global.Snomed, "73056007", "Right breast structure (body structure)")
                            .ToCodeableConcept();
                    e.Select("bodySite")
                        .Single()
                        .Pattern(coding.ToPattern())
                        .DefaultValueExtension(coding)
                        ;
                }
                e.Select("value[x]")
                    .Definition(new Markdown()
                        .Paragraph("Composite BiRad value for Right Breast.")
                        .Paragraph(
                            "Typically this is the most severe of all the BiRad codes set in any of the child observations.")
                    )
                    ;
                e.IntroDoc
                    .ReviewedStatus("KWA 3/19/10")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    .ReviewedStatus("CIC 22.1.2020")
                    ;
            });
    }
}