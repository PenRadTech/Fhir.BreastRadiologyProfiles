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

        public CompositionBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new Composition());
        }

        protected void ClearSection()
        {
            this.Resource.Section.Clear();
        }

        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }

    }
}
