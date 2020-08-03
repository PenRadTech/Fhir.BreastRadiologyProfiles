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


    public class ClinicalImpressionBase : ResourceBase<ClinicalImpression>, IClinicalImpression
    {
        public ClinicalImpression Resource => (ClinicalImpression)this.resource;

        public ClinicalImpressionBase() : base()
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
