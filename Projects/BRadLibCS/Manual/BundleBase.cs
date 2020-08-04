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

        public BundleBase(BreastRadiologyDocument doc) : base(doc)
        {
        }

        public override void Write()
        {
            base.Write();
        }
    }
}
