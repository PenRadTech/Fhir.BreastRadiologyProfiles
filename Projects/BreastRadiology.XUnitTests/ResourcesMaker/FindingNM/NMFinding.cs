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
        SDTaskVar NMFinding = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateEditor("NMFinding",
                            "NM Finding",
                            "NM Finding",
                            Global.ObservationUrl,
                            $"{Group_NMResources}",
                            "ObservationSection")
                        .Description("NM Finding",
                            new Markdown()
                                .Paragraph("This Observation contains all references to all the observations",
                                           "and exam information related to a Nuclear Medicine (NM) exam.")
                                .Paragraph("As of this ballot, the child observations of an NM Exam have not",
                                           "been defined. They will be defined in a later ballot.")
                        )
                        .AddFragRef(Self.ObservationSectionFragment.Value())
                    ;
                s = e.SDef;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeNMFinding.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeNMFinding.ToCodeableConcept())
                    ;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    ;

                ////$ todo. Incorrect method!!!
                //e.Find("method")
                // .FixedCodeSlice("method", Snomed, "115341008")
                // .Card(1, "*")
                // ;

                //ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                //{
                //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.NMMass.Value(), 0, "*"),
                //};
                //e.SliceByUrl("hasMember", targets);
                //e.AddProfileTargets(targets);
            });
    }
}