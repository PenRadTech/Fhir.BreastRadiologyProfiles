using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar ObservationHasMemberAssociatedFeaturesFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("AssociatedFeaturesHasMemberFragment",
                            "AssociatedFeatures HasMember Fragment",
                            "AssociatedFeatures HasMember/Fragment",
                            Global.ObservationUrl)
                        .Description("AssociatedFeatures HasMember fragment",
                            new Markdown()
                                .Paragraph("This fragment adds the references for the AssociatedFeatures HasMember.")
                        )
                        .AddFragRef(Self.HeaderFragment)
                    ;
                s = e.SDef;

                ElementTreeNode sliceElementDef = e.ConfigureSliceByUrlDiscriminator("hasMember", false);
                e.SliceTargetReference(sliceElementDef, Self.AssociatedFeature.Value());
            });
    }
}