using Eir.DevTools;
using Eir.FhirKhit.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lint
{
    class LinterStructureDefinition
    {
        private StructureDefinition sDef;
        private IConversionInfo info;
        public LinterStructureDefinition(IConversionInfo info,
            StructureDefinition sDef)
        {
            this.sDef = sDef;
            this.info = info;
        }

        public void FindLint()
        {
            if (this.sDef.Snapshot == null)
            {
                SnapshotCreator.Create(this.sDef);
            }
            ElementLoader loader = new ElementLoader(info);
            ElementNode e = loader.Create(sDef);
        }
    }
}
