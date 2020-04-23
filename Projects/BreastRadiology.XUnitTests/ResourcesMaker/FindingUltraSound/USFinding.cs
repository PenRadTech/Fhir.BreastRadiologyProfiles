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
        SDTaskVar USFinding = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                //$ Fix me. Incorrect method!!!
                SDefEditor e = Self.CreateEditor("USFinding",
                            "Ultra-Sound Finding",
                            "US Finding",
                            Global.ObservationUrl,
                            $"{Group_USResources}",
                            "ObservationSection")
                        .Description("Ultra Sound Finding",
                            new Markdown()
                                .Paragraph("This Observation contains all references to all the observations",
                                           "and exam information related to an Ultra Sound (US) exam.")
                                .Paragraph("As of this ballot, the child observations of an US Exam have not",
                                           "been defined. They will be defined in a later ballot.")
                        )
                        .AddFragRef(Self.ObservationSectionFragment.Value())
                    ;
                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeUSFinding.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeUSFinding.ToCodeableConcept().ToPattern())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    .Description("This Observation contains all references to all the observations",
                                 "and exam information related to a Ultra Sound exam.")
                    ;

                //$e.Find("method")
                // .FixedCodeSlice("method", Snomed, "115341008")
                // .Card(1, "*")
                // ;

                //ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                //{
                //    new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USMass.Value(), 0, "*"),
                //    new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USTissueComposition.Value(), 1, "1"),
                //};
                //e.SliceByUrl("hasMember", targets);
                //e.AddProfileTargets(targets);
            });
    }
}