using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IDiagnosticReportBase : IResourceBase
    {
        DiagnosticReport Resource { get; }
    }

    public class DiagnosticReportBase : ResourceBase, IDiagnosticReportBase
    {
        public DiagnosticReport Resource => (DiagnosticReport)this.resource;

        public DiagnosticReportBase(BreastRadiologyDocument doc) : base(doc)
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
