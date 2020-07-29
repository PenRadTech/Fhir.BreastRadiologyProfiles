using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IServiceRequestBase : IResourceBase
    {
    }

    public class ServiceRequestBase : ResourceBase, IServiceRequestBase
    {
        public ServiceRequest Resource => (ServiceRequest)this.resource;

        public ServiceRequestBase() : base()
        {
        }

        public ServiceRequestBase(BreastRadiologyDocument doc, ServiceRequest resource) : base()
        {
            this.Init(doc, resource);
        }

        public ServiceRequestBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new ServiceRequest());
        }

        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }
    }
}
