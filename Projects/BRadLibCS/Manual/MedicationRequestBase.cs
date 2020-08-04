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

        public MedicationRequestBase(BreastRadiologyDocument doc) : base(doc)
        {
        }

        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }
    }
}
