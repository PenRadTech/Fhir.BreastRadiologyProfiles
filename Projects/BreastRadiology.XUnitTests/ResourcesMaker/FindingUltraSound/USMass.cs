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
        //#SDTaskVar USMass = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        SDefEditor e = Self.CreateEditor("USMass",
        //                "US Mass",
        //                "US Mass",
        //                ObservationUrl,
        //                $"{Group_USResources}/Finding/Mass")
        //            .Description("Ultra-Sound Mass Observation",
        //                new Markdown()
        //                    .BiradHeader()
        //                    .BlockQuote("A mass is three dimensional and occupies space. With 2-D ultrasound, it should be seen in two")
        //                    .BlockQuote("different planes, and in three planes with volumetric acquisitions. Masses can be distinguished")
        //                    .BlockQuote("from normal anatomic structures, such as ribs or fat lobules, using two or more projections and")
        //                    .BlockQuote("real-time scanning.")
        //                    .BiradFooter()
        //            )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.BreastBodyLocationRequiredFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ImagingStudyFragment.Value())
        //            ;
        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .ObservationSection($"Ultra-Sound Mass")
        //            .ReviewedStatus("No One", "")
        //            ;

        //        //ProfileTargetSlice[] targets = new ProfileTargetSlice[]
        //        //{
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.BiRadsAssessmentCategory.Value(), 0, "1"),

        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedCount.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedChangeInState.Value(), 0, "*"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedSize.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.Orientation.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.Hilum.Value(), 0, "1"),

        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USBoundary.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USEchoPattern.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USElasticity.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USMargin.Value(), 0, "*"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USPosteriorAcousticFeatures.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USShape.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.USVascularity.Value(), 0, "1"),
        //        //};
        //        //e.SliceByUrl("hasMember", targets);
        //        //e.AddProfileTargets(targets);

        //        e.StartComponentSliceing();
        //        Self.ComponentSliceObservedCount(e);
        //    });
    }
}