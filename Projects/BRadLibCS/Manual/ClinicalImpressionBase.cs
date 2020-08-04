using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IClinicalImpression : IResourceBase
    {
        ClinicalImpression Resource { get; }
    }


    public class ClinicalImpressionBase : ResourceBase, IClinicalImpression
    {
        public ClinicalImpression Resource => (ClinicalImpression)this.resource;

        public ClinicalImpressionBase(BreastRadiologyDocument doc) : base(doc)
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
