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

        public DiagnosticReportBase() : base()
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
