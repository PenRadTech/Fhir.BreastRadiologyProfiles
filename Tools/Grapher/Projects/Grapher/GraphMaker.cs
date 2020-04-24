using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Eir.DevTools;
using System.Globalization;
using System.Linq;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;

namespace Grapher
{
    public class GraphMaker : ConverterBase
    {
        Dictionary<String, NodeInfo> nodes = new Dictionary<string, NodeInfo>();
        Dictionary<String, StructureDefinition> structDefDict = new Dictionary<string, StructureDefinition>();

        public String GraphicsOutputDir { get; set; } = ".";
        public String Graph { get; set; } = "focus";

        public GraphMaker()
        {
        }

        String FullName(StructureDefinition sDef, String sliceName) =>
            $"{sDef.Url.ToLower()} {sliceName}";

        public void AddResource(Resource resource)
        {
            switch (resource)
            {
                case StructureDefinition sDef:
                    this.structDefDict.Add(sDef.Url, sDef);
                    break;
                default:
                    break;
            }
        }

        DomainResource LoadResourceInFile(String path)
        {
            const String fcn = "LoadResourceInFile";

            this.ConversionInfo(this.GetType().Name,
                fcn,
                $"Adding FHIR file {path}");

            switch (Path.GetExtension(path).ToUpper(CultureInfo.InvariantCulture))
            {
                case ".XML":
                    {
                        FhirXmlParser parser = new FhirXmlParser();
                        return parser.Parse<DomainResource>(File.ReadAllText(path));
                    }

                case ".JSON":
                    {
                        FhirJsonParser parser = new FhirJsonParser();
                        return parser.Parse<DomainResource>(File.ReadAllText(path));
                    }

                default:
                    throw new Exception($"Unknown extension for serialized fhir resource '{path}'");
            }
        }

        void AddResourceInFile(String path)
        {
            DomainResource dr = this.LoadResourceInFile(path);
            AddResource(dr);
            StructureDefinition sDef = dr as StructureDefinition;
            if (sDef != null)
            {
                sDef.Snapshot = null;
                SnapshotCreator.Create(sDef);
                sDef.SaveJson(path);
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
            const String fcn = "Process";

            try
            {
                this.GraphicsOutputDir = this.ProcessPath(this.GraphicsOutputDir);
                LoadGraphicData();
                return 0;
            }
            catch (Exception e)
            {
                this.ConversionInfo(this.GetType().Name,
                    fcn,
                    $"error {e.Message}");

                return -1;
            }
        }
        ElementDefinition GetExtension(StructureDefinition sDef, 
            Int32 elementIndex,
            String path)
        {
            ElementDefinition e = sDef.Snapshot.Element[elementIndex++];
            String basePath = e.ElementId;
            String fullPath = $"{basePath}.{path}";
            while (elementIndex < sDef.Snapshot.Element.Count)
            {
                e = sDef.Snapshot.Element[elementIndex++];
                if (String.Compare(e.ElementId, fullPath) == 0)
                    return e;
                if (e.ElementId.StartsWith(basePath) == false)
                    return null;
            }
            return null;
        }

        String GetExtensionString(StructureDefinition sDef, 
            Int32 elementIndex, 
            String path)
        {
            ElementDefinition e = GetExtension(sDef, elementIndex, path);
            FhirString s = e.Fixed as FhirString;
            return s.Value;
        }

        void LoadGraphNode(StructureDefinition sDef, Int32 elementIndex, ElementDefinition item)
        {
            const String fcn = "LoadGraphNode";
            String graphName = GetExtensionString(sDef, 
                elementIndex, 
                $"extension:graphName.valueString");
            String fullName = FullName(sDef, item.SliceName);
            NodeInfo i = new NodeInfo
            {
                FullName = fullName,
                SDef = sDef,
                NodeName = "",
                DisplayName = "",
                CssClass = ""
            };

            if (this.nodes.TryAdd(fullName, i) == false)
            {
                this.ConversionError(this.GetType().Name,
                    fcn,
                    $"Error adding Node {fullName}. Was node already defined?");
            }
        }

        void LoadGraphLinkByName(StructureDefinition sDef, ElementDefinition item)
        {
            String parentSlice = "";
            String childSlice = "";
            String fullParentName = this.FullName(sDef, parentSlice);
            String fullChildName = this.FullName(sDef, childSlice);
        }

        bool IsExtension(ElementDefinition item)
        {
            if (item.Type.Count < 1)
                return false;
            if (item.Type[0].Code != "Extension")
                return false;
            if (String.IsNullOrEmpty(item.SliceName))
                return false;
            if (item.Type[0].Profile.Count() != 1)
                return false;
            return true;
        }

        ElementDefinition SearchFrom(List<ElementDefinition> items, 
            Int32 index,
            String id)
        {
            throw new NotImplementedException();
        }

        void LoadGraphLinks(StructureDefinition sDef)
        {
            const String fcn = "LoadGraphLinks";

            Int32 elementIndex = 0;
            while (elementIndex < sDef.Snapshot.Element.Count)
            {
                ElementDefinition item = sDef.Snapshot.Element[elementIndex];

                if (this.IsExtension(item))
                {
                    String profile = item.Type[0].Profile.FirstOrDefault();
                    switch (profile.LastUriPart())
                    {
                        case "GraphLinkByName":
                            this.ConversionInfo(this.GetType().Name,
                                fcn,
                                $"Processing 'GraphLinkByName' {item.ElementId}");
                            LoadGraphLinkByName(sDef, item);
                            break;
                    }
                }
                elementIndex += 1;
            }
        }

        void LoadGraphNodes(StructureDefinition sDef)
        {
            const String fcn = "LoadGraphNodes";

            Int32 elementIndex = 0;
            sDef.Snapshot = null;
            SnapshotCreator.Create(sDef);
            while (elementIndex < sDef.Snapshot.Element.Count)
            {
                ElementDefinition item = sDef.Snapshot.Element[elementIndex];

                if (this.IsExtension(item))
                {
                    String profile = item.Type[0].Profile.FirstOrDefault();
                    switch (profile.LastUriPart())
                    {
                        case "GraphNode":
                            this.ConversionInfo(this.GetType().Name,
                                fcn,
                                $"Processing 'GraphNode' {item.ElementId}");
                            LoadGraphNode(sDef, elementIndex, item);
                            break;
                    }
                }

                elementIndex += 1;
            }
        }


        void LoadGraphicData()
        {
            foreach (StructureDefinition sDef in this.structDefDict.Values)
                this.LoadGraphNodes(sDef);

            foreach (StructureDefinition sDef in this.structDefDict.Values)
                this.LoadGraphLinks(sDef);
        }
    }
}
