using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IMedicationRequestBase : IResourceBase
    {
        MedicationRequest Resource { get; }
    }

    public class MedicationRequestBase: ResourceBase, IMedicationRequestBase
    {
        public MedicationRequest Resource => (MedicationRequest) this.resource;

        public MedicationRequestBase() : base()
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
