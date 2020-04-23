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
        //#SDTaskVar MRIMass = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        SDefEditor e = Self.CreateEditor("MRIMass",
        //                "MRI Mass",
        //                "MRI Mass",
        //                ObservationUrl,
        //                $"{Group_MRIResources}/Mass")
        //            .Description("MRI Mass Observation",
        //                new Markdown()
        //                    .BiradHeader()
        //                    .BlockQuote("\"MASS\" is three dimensional and occupies space. It is seen on two different pro-")
        //                    .BlockQuote("jections. It has completely or partially convex-outward borders and (when radiodense) appears")
        //                    .BlockQuote("denser in the center than at the periphery. If a potential mass is seen only on a single projection, it")
        //                    .BlockQuote("should be called an \"ASYMMETRY\" until 3-dimensionality is confirmed")
        //                    .BiradFooter()
        //            )
        //            .AddFragRef(Self.ObservationNoDeviceFragment.Value())
        //             .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.BreastBodyLocationRequiredFragment.Value())
        //            .AddFragRef(Self.ObservationNoValueFragment.Value())
        //            .AddFragRef(Self.ImagingStudyFragment.Value())
        //            ;
        //        s = e.SDef.Url;

        //        e.IntroDoc
        //            .ReviewedStatus("No One", "")
        //            .ObservationSection("MRI Mass")
        //            ;

        //        //ProfileTargetSlice[] targets = new ProfileTargetSlice[]
        //        //{
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedSize.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedCount.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.Orientation.Value(), 0, "1"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.MRIMargin.Value(), 0, "*"),
        //        //new ProfileTargetSelf.Slice(e, sliceElementDef, Self.ObservedChangeInState.Value(), 0, "*"),
        //        //};
        //        //e.SliceByUrl("hasMember", targets);
        //        //e.AddProfileTargets(targets);
        //        e.StartComponentSliceing();
        //        Self.ComponentSliceObservedCount(e);
        //    });
    }
}