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
        SDTaskVar MRIFinding = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                //$ Fix me. Incorrect method!!!
                SDefEditor e = Self.CreateEditor("MRIFinding",
                            "MRI Finding",
                            "MRI Finding",
                            Global.ObservationUrl,
                            $"{Group_MRIResources}",
                            "ObservationSection")
                        .Description("MRI Finding",
                            new Markdown()
                                .Paragraph("This Observation contains all references to all the observations" ,
                                           "and exam information related to a Magnetic Resonance Imaging (MRI) exam.")
                                .Paragraph("As of this ballot, the child observations of an MRI Exam have not",
                                           "been defined. They will be defined in a later ballot.")
                        )
                        .AddFragRef(Self.ObservationSectionFragment.Value())
                    ;
                s = e.SDef;

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    ;

                // Set Observation.code to unique value for this profile.
                e.Select("code")
                    .Pattern(Self.ObservationCodeMRIFinding.ToCodeableConcept().ToPattern())
                    .DefaultValueExtension(Self.ObservationCodeMRIFinding.ToCodeableConcept())
                    ;

                //ProfileTargetSlice[] targets = new ProfileTargetSlice[]
                //{
                //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.MRIMass.Value(), 0, "*"),
                //};
                //e.SliceByUrl("hasMember", targets);
                //e.AddProfileTargets(targets);

                //$e.Find("method")
                //     .FixedCodeSlice("method", Snomed, "115341008")
                //     .Card(1, "*")
                //     ;
            });
    }
}