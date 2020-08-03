using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IBundle : IResourceBase
    {
        Bundle Resource { get; }
    }


    public class BundleBase : ResourceBase<Bundle>, IBundle
    {
        public Bundle Resource => (Bundle)this.resource;

        public BundleBase() : base()
        {
        }

        public override void Write(BreastRadiologyDocument doc)
        {
            base.Write(doc);
        }
    }
}
