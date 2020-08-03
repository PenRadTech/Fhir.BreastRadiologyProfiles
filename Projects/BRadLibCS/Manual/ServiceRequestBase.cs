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

        public override void Write(BreastRadiologyDocument doc)
        {
            base.Write(doc);
            this.Resource.Encounter = doc.Encounter;
            this.Resource.Subject = doc.Subject;
        }
    }
}
