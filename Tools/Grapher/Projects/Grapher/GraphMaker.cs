using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Eir.DevTools;
using System.Globalization;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Serialization;

namespace Grapher
{
    public class GraphMaker : ConverterBase
    {
        Dictionary<String, StructureDefinition> structDefDict = new Dictionary<string, StructureDefinition>();
        Dictionary<String, ValueSet> valueSetDict = new Dictionary<string, ValueSet>();
        Dictionary<String, CodeSystem> codeSystemDict = new Dictionary<string, CodeSystem>();

        public String GraphicsOutputDir { get; set; } = ".";
        public String Graph { get; set; } = "focus";

        public void AddResource(Resource resource)
        {
            switch (resource)
            {
                case StructureDefinition sDef:
                    this.structDefDict.Add(sDef.Url, sDef);
                    break;
                case ValueSet valueSet:
                    this.valueSetDict.Add(valueSet.Url, valueSet);
                    break;
                case CodeSystem codeSystem:
                    this.codeSystemDict.Add(codeSystem.Url, codeSystem);
                    break;
                default:
                    throw new NotImplementedException($"Fhir resource type '{resource.TypeName}' not implemented.");
            }
        }

        void AddResourceInFile(String path)
        {
            const String fcn = "AddResourceInFile";

            this.ConversionInfo(this.GetType().Name,
                fcn,
                $"Adding FHIR file {path}");

            DomainResource domainResource;
            switch (Path.GetExtension(path).ToUpper(CultureInfo.InvariantCulture))
            {
                case ".XML":
                    {
                        FhirXmlParser parser = new FhirXmlParser();
                        domainResource = parser.Parse<DomainResource>(File.ReadAllText(path));
                        break;
                    }

                case ".JSON":
                    {
                        FhirJsonParser parser = new FhirJsonParser();
                        domainResource = parser.Parse<DomainResource>(File.ReadAllText(path));
                        break;
                    }

                default:
                    throw new Exception($"Unknown extension for serialized fhir resource '{path}'");
            }
        }

        void AddResourcesInDir(String dirPath)
        {
            const String fcn = "AddResourcesInDir";

            this.ConversionInfo(this.GetType().Name,
                fcn, 
                $"Adding FHIR files in directory {dirPath}");

            foreach (String subDir in Directory.GetDirectories(dirPath))
                AddResourcesInDir(subDir);
            foreach (String file in Directory.GetFiles(dirPath, "*.json"))
                AddResourceInFile(file);
            foreach (String file in Directory.GetFiles(dirPath, "*.xml"))
                AddResourceInFile(file);
        }

        String ProcessPath(String path)
        {
            if (path.StartsWith("^"))
            {
                String[] pathParts = path.Split('\\');
                String parentPath = pathParts[0].Substring(1);
                parentPath = DirHelper.FindParentDir(parentPath);
                pathParts[0] = parentPath;
                path = Path.Combine(pathParts);
            }

            return path;
        }

        public void AddResources(String path)
        {
            path = this.ProcessPath(path);
            if (Directory.Exists(path) == true)
                AddResourcesInDir(path);
            else
                AddResourceInFile(path);
        }

        public Int32 Process()
        {
            this.GraphicsOutputDir = this.ProcessPath(this.GraphicsOutputDir);
            throw new NotImplementedException();
        }
    }
}
