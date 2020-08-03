using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRadLibCS
{
    public interface ICompositionBase : IResourceBase
    {
        Composition Resource { get; }
    }

    public class CompositionBase : ResourceBase, ICompositionBase
    {
        public Composition Resource => (Composition)this.resource;

        public CompositionBase() : base()
        {
        }

        protected void ClearSection()
        {
            this.Resource.Section.Clear();
        }

        public override void Write(BreastRadiologyDocument doc)
        {
            base.Write(doc);
            this.Resource.Encounter = doc.Encounter;
            this.Resource.Subject = doc.Subject;
        }

    }
}
