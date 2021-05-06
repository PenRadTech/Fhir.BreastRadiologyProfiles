using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace Lint
{
    class FhirResources
    {
        public Dictionary<String, CodeSystem> CodeSystems = new Dictionary<String, CodeSystem>();
        public Dictionary<String, ValueSet> ValueSets = new Dictionary<String, ValueSet>();
        public Dictionary<String, StructureDefinition> StructureDefinitions = new Dictionary<String, StructureDefinition>();

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
                            CodeSystems.Add(codeSystem.Url, codeSystem);
                            break;

                        case ValueSet valueSet:
                            ValueSets.Add(valueSet.Url, valueSet);
                            break;
                        
                        case StructureDefinition structureDefinition:
                            StructureDefinitions.Add(structureDefinition.Url, structureDefinition);
                            break;
                    }
                }
            }
        }
    }
}
