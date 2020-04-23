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
        SDTaskVar AcrHeaderFragment= new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("AcrHeaderFragment",
                        "ACR Header Fragment",
                        "Common",
                        Global.ResourceUrl)
                    .Description("ACR Common Header Fragment",
                        new Markdown(
                            "Resource fragment used to by ACR resources to define common values such as Contact and Date.")
                    );
                ContactDetail cd = new ContactDetail();
                cd.Telecom.Add(new ContactPoint
                {
                    System = ContactPoint.ContactPointSystem.Url,
                    Value = Global.ContactUrl
                });

                s = e.SDef;

                e.SDef.Contact.Add(cd);
                e.SDef.Date = Self.date.ToString();
                e.SDef.Status = ProfileStatus;
                e.SDef.Publisher = "Hl7-Clinical Interoperability Council";
                e.SDef.Version = ProfileVersion;
            });
    }
}