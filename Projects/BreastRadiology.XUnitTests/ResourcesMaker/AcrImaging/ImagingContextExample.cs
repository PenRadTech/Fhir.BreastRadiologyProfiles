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
        public void ImagingContextExample()
        {
            String ExamplePath(String prefix, Resource r)
            {
                return Path.Combine(this.resourceDir,
                    "..",
                    "Examples",
                    $"{prefix}.{r.TypeName}.{r.Id}.json");
            }

            DocumentReference dr = new DocumentReference
            {
                Id = "ImagingContextExample",
                Status = DocumentReferenceStatus.Current,
                Subject = new ResourceReference("#Patient1"),
                Date = DateTimeOffset.Now
            };
            {
                Patient p = new Patient { Id = "Patient1" };
                p.Name.Add(new HumanName
                {
                    Given = new String[] { "Bullwinkle" },
                    Family = "Moose"
                });
                dr.Contained.Add(p);
            }

            dr.Content.Add(new DocumentReference.ContentComponent
            {
                Attachment = new Attachment
                {
                    ContentType = "application/dicom",
                    Data = new byte[0]
                }
            });

            Extension e = new Extension
            {
                Url = Self.ImagingContextExtension.Value().Url
            };
            dr.Extension.Add(e);

            {
                Extension studyUid = new Extension
                {
                    Url = "studyUid",
                    Value = new Oid("urn:oid:1.2.3.4.5")
                };
                e.Extension.Add(studyUid);
            }

            //{
            //    Extension studyUid = new Extension
            //    {
            //        Url = ImageSeriesExtension.Value().Url,
            //        Value = new Oid("urn:oid:2.25.4448")
            //    };
            //    e.Extension.Add(studyUid);
            //}

            //{
            //    Extension instance = new Extension
            //    {
            //        Url = ImageInstanceExtension.Value().Url
            //    };
            //    e.Extension.Add(instance);

            //    {
            //        Extension imageRegion = new Extension
            //        {
            //            Url = Self.ImageRegionExtension.Value().Url,
            //        };
            //        instance.Extension.Add(imageRegion);
            //        {
            //            CodeSystem regionTypeCS = Self.GraphicTypeCS.Value();
            //            Extension regionType = new Extension
            //            {
                           
            //                Url = "regionType",
            //                Value = new Coding(regionTypeCS.Url, "POLYLINE")
            //            };
            //            imageRegion.Extension.Add(regionType);
            //        }
            //        {
            //            Extension coordinateList = new Extension
            //            {
            //                Url = "coordinates",
            //                Value = new FhirString("105.2,276.5 89.1,352.5")
            //            };
            //            imageRegion.Extension.Add(coordinateList);
            //        }
            //    }
            //}
            String path = ExamplePath("ImagingContext", dr);
            dr.SaveJson(path);
        }
    }
}