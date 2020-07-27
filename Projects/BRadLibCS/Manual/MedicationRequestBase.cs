using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
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

        public MedicationRequestBase(BreastRadiologyDocument doc, MedicationRequest resource) : base()
        {
            this.Init(doc, resource);
        }

        public MedicationRequestBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new MedicationRequest());
        }
        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }
    }
}
