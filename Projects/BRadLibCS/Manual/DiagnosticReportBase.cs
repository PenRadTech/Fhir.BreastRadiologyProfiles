using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public interface IDiagnosticReportBase : IResourceBase
    {
        DiagnosticReport Resource { get; }
    }

    public class DiagnosticReportBase : ResourceBase, IDiagnosticReportBase
    {
        public DiagnosticReport Resource => (DiagnosticReport)this.resource;

        public DiagnosticReportBase() : base()
        {
        }

        public DiagnosticReportBase(BreastRadiologyDocument doc, DiagnosticReport resource) : base()
        {
            this.Init(doc, resource);
        }

        public DiagnosticReportBase(BreastRadiologyDocument doc) : base()
        {
            this.Init(doc, new DiagnosticReport());
        }
        public override void Write()
        {
            base.Write();
            this.Resource.Encounter = this.Doc.Encounter;
            this.Resource.Subject = this.Doc.Subject;
        }
    }
}
