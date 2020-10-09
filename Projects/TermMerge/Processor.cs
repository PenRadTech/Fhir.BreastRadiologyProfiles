using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TermMerge
{
    class Processor
    {
        FhirResources fhirResources = new FhirResources();
        FSHFiles fshFiles = new FSHFiles();


        public void AddResources(params String[] inputDirs) => this.fhirResources.AddResources(inputDirs);
        public void AddFSHFiles(params String[] inputDirs) => this.fshFiles.AddFiles(inputDirs);

        public void Process()
        {
            foreach (CodeSystem codeSystem in fhirResources.CodeSystems)
            {
                if (this.fshFiles.TryGetCodeSystem(codeSystem.Name, out FSHFile f) == false)
                    throw new Exception($"Cant find code system {codeSystem.Name}");
            }
        }
    }
}
