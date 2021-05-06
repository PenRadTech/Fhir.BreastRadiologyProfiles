using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace TermMerge
{
    class FhirResources
    {
        public List<CodeSystem> CodeSystems = new List<CodeSystem>();

        public void AddResources(params String[] inputDirs)
        {
            foreach (String inputDir in inputDirs)
            {
                foreach (String file in Directory.GetFiles(inputDir))
                {
                    String fhirText = File.ReadAllText(file);
                    FhirJsonParser parser = new FhirJsonParser();
                    var resource = parser.Parse(fhirText, typeof(Resource));
                    switch (resource)
                    {
                        case CodeSystem codeSystem:
                            CodeSystems.Add(codeSystem);
                            break;
                    }
                }
            }
        }
    }
}
