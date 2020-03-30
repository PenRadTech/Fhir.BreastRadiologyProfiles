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
        //#SDTaskVar USCyst = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        SDefEditor e = Self.CreateEditor("USCyst",
        //                "Ultra-Sound Cyst",
        //                "US Cyst",
        //                ObservationUrl,
        //                $"{Group_USResources}/Cyst")
        //            .Description("UltraSound Cyst Observation",
        //                new Markdown()
        //                    .Paragraph("[PR]")
        //            )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.BreastBodyLocationRequiredFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ImagingStudyFragment.Value())
        //            ;
        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .ObservationSection("UltraSound Cyst")
        //            .ReviewedStatus("No One", "")
        //            ;

        //        //ProfileTargetSlice[] targets = new ProfileTargetSlice[]
        //        //{
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.BiRadsAssessmentCategory.Value(), 0, "1"),

        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedCount.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedChangeInState.Value(), 0, "*"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedSize.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.Orientation.Value(), 0, "1"),
        //        //};
        //        //e.SliceByUrl("hasMember", targets);
        //        //e.AddProfileTargets(targets);
        //        e.StartComponentSliceing();
        //        Self.ComponentSliceObservedCount(e);
        //    });
    }
}