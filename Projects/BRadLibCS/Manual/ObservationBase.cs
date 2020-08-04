using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRadLibCS
{
    public interface IObservationBase : IResourceBase
    {
        Observation Resource { get; }
    }

    public class ObservationBase : ResourceBase, IObservationBase
    {
        public Observation Resource => (Observation)this.resource;


        public ObservationBase(BreastRadiologyDocument doc) : base(doc)
        {
        }

        protected void ClearHasMember()
        {
            this.Resource.HasMember.Clear();
        }

        protected void ClearComponent()
        {
            this.Resource.Component.Clear();
        }

        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }
    }
}
