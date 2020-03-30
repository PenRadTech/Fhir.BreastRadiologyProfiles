using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar ObservationHasMemberConsistentWithFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("ConsistentWithHasMemberFragment",
                            "ConsistentWith HasMember Fragment",
                            "ConsistentWith HasMember/Fragment",
                            Global.ObservationUrl)
                        .Description("ConsistentWith HasMember fragment",
                            new Markdown()
                                .Paragraph("This fragment adds the references for the ConsistentWith HasMember.")
                        )
                        .AddFragRef(Self.HeaderFragment)
                    ;
                s = e.SDef;

                ElementTreeNode sliceElementDef = e.ConfigureSliceByUrlDiscriminator("hasMember", false);
                e.SliceTargetReference(sliceElementDef, Self.ConsistentWith.Value(), 0, "*");
            });
    }
}