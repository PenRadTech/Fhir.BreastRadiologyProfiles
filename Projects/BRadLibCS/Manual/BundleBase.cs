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


    public class BundleBase : ResourceBase, IBundle
    {
        public Bundle Resource => (Bundle)this.resource;

        public BundleBase() : base()
        {
        }

        public BundleBase(BreastRadiologyDocument doc, Bundle resource) : base()
        {
            this.Init(doc, resource);
        }

        public BundleBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new Bundle());
        }
        public override void Write()
        {
            base.Write();
        }
    }
}
