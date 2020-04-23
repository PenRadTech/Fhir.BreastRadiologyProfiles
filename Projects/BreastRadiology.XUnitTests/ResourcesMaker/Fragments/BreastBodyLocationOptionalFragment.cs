using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        //#SDTaskVar BreastBodyLocationOptionalFragment = new SDTaskVar(
        //    (out StructureDefinition  s) =>
        //    {
        //        SDefEditor e = Self.CreateFragment("BreastBodyLocationOptionalFragment",
        //                            "Breast Body Location (Optional) Fragment",
        //                            "Breast/Body/Location/Fragment/(Optional)",
        //                            ObservationUrl)
        //            .Description("Fragment definition for a Optional Breast Body Location",
        //                new Markdown()
        //                .Paragraph("This fragment adds the references for the breast body location extension.")
        //                .Paragraph("The references are optional, meaning that the breast body location may exist.")
        //             )
        //            .AddFragRef(Self.HeaderFragment)
        //            ;
        //        s = e.SDef.Url;

        //        e
        //            .Select("bodySite")
        //            .ZeroToOne()
        //            ;
        //        e
        //            .ApplyExtension("breastBodyLocation", Self.BreastBodyLocationExtension.Value(), true, false)
        //            .ZeroToOne()
        //            ;
        //    });
    }
}