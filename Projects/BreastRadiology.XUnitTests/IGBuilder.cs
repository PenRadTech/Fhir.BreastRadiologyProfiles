using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    public class IGBuilder : ConverterBase
    {
        FileCleaner fcGuide;

        String outputDir;
        String resourceDir;
        String exampleDir;
        String pagecontentDir;
        String includesDir;
        String imagesDir;

        String ImpGuidePath => Path.Combine(this.outputDir, this.impGuideName);
        String impGuideName;
        ImplementationGuideEditor implementationGuide;

        public IGBuilder(String outputDir)
        {
            String SetSubDir(String subDir)
            {
                String retVal = Path.Combine(this.outputDir, subDir);
                if (Directory.Exists(retVal) == false)
                    Directory.CreateDirectory(retVal);
                return retVal;
            }
            this.outputDir = outputDir;
            this.fcGuide = new FileCleaner();
            this.fcGuide.Add(this.outputDir);
            this.fcGuide.Mark(Path.Combine(this.outputDir, "ignoreWarnings.txt"));

            this.resourceDir = SetSubDir("resources");
            this.exampleDir = SetSubDir("examples");
            this.pagecontentDir = SetSubDir("pagecontent");
            this.imagesDir = SetSubDir("images");
            this.includesDir = SetSubDir("includes");
        }

        public void SaveAll()
        {
            this.implementationGuide.Save(this.ImpGuidePath);
            this.fcGuide?.Mark(this.ImpGuidePath);
        }

        public void Start(String impGuidePath)
        {
            this.impGuideName = Path.GetFileName(impGuidePath);
            this.implementationGuide = new ImplementationGuideEditor(impGuidePath);
        }

        void CopyFiles(String inputDir, String inputMask, String outputDir)
        {
            foreach (String inputPath in Directory.GetFiles(inputDir, inputMask))
            {
                String outputPath = Path.Combine(outputDir, Path.GetFileName(inputPath));

                File.Copy(inputPath, outputPath, true);
                this.fcGuide?.Mark(outputPath);
            }
        }

        public void AddIncludes(String inputDir)
        {
            this.CopyFiles(inputDir, "*.xml", this.includesDir);
        }

        public void AddPageContent(String inputDir)
        {
            this.CopyFiles(inputDir, "*.xml", this.pagecontentDir);
        }

        public void AddImages(String inputDir)
        {
            this.CopyFiles(inputDir, "*.svg", this.imagesDir);
        }

        HashSet<String> groupIds = new HashSet<string>();

        public void AddGrouping(String groupId, String name, String description)
        {
            Debug.Assert(groupId.StartsWith(" ") == false);
            Debug.Assert(groupId.EndsWith(" ") == false);

            this.implementationGuide.AddGrouping(groupId, name, description);
            if (this.groupIds.Contains(groupId))
                throw new Exception($"Group already added");
            this.groupIds.Add(groupId);
        }

        public static void RemoveFragmentExtensions(String dir)
        {
            foreach (String filePath in Directory.GetFiles(dir, "*.json"))
            {
                FhirJsonParser parser = new FhirJsonParser();
                DomainResource dr = parser.Parse<DomainResource>(File.ReadAllText(filePath));
                RemoveFragmentExtensions(dr);
                dr.SaveJson(filePath);
            }

            foreach (String subDir in Directory.GetDirectories(dir))
                RemoveFragmentExtensions(subDir);
        }


        public static void RemoveFragmentExtensions(DomainResource r)
        {
            void Rem(List<Extension> extensions)
            {
                Int32 i = 0;
                while (i < extensions.Count)
                {
                    Extension e = extensions[i];
                    if (
                        (e.Url.StartsWith(Global.BaseFragmentUrl, new StringComparison())) ||
                        (e.Url.CompareTo("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status") == 0) ||
                        (e.Url.CompareTo("http://hl7.org/fhir/StructureDefinition/structuredefinition-normative-version") == 0)
                        )
                        extensions.RemoveAt(i);
                    else
                        i += 1;
                }
            }

            Rem(r.Extension);

            StructureDefinition sd = r as StructureDefinition;
            if (sd != null)
            {
                foreach (ElementDefinition ed in sd.Snapshot.Element)
                    Rem(ed.Extension);
                foreach (ElementDefinition ed in sd.Differential.Element)
                    Rem(ed.Extension);
            }
        }


        public void AddResources(params String[] inputDirs)
        {
            const String fcn = "AddResources";

            String Group(DomainResource resource)
            {
                Extension groupExtension = resource.GetExtension(Global.GroupExtensionUrl);
                if (groupExtension == null)
                    throw new Exception($"StructureDefinition {resource.Id} lacks group extension");
                FhirString value = groupExtension.Value as FhirString;
                if (value == null)
                    throw new Exception($"StructureDefinition {resource.Id} lacks group extension value");
                return value.Value;
            }

            String GetGroupPath(DomainResource resource)
            {
                String groupPath = Group(resource);

                String groupId = groupPath.BaseUriPart();
                if (this.groupIds.Contains(groupId) == false)
                {
                    this.ConversionError(this.GetType().Name,
                        fcn,
                        $"Group {groupId} not defined");
                    return null;
                }

                return groupId;
            }

            void Save(DomainResource r, String outputName)
            {
                RemoveFragmentExtensions(r);
                String outputPath = Path.Combine(this.resourceDir, outputName);
                r.SaveJson(outputPath);
                this.fcGuide?.Mark(outputPath);
            }

            List<StructureDefinition> structureDefinitions = new List<StructureDefinition>();
            List<ValueSet> valueSets = new List<ValueSet>();
            List<CodeSystem> codeSystems = new List<CodeSystem>();

            foreach (String inputDir in inputDirs)
            {
                foreach (String file in Directory.GetFiles(inputDir))
                {
                    String fhirText = File.ReadAllText(file);
                    FhirJsonParser parser = new FhirJsonParser();
                    var resource = parser.Parse(fhirText, typeof(Resource));
                    switch (resource)
                    {
                        case StructureDefinition structureDefinition:
                            structureDefinitions.Add(structureDefinition);
                            break;

                        case CodeSystem codeSystem:
                            codeSystems.Add(codeSystem);
                            break;

                        case ValueSet valueSet:
                            valueSets.Add(valueSet);
                            break;

                        default:
                            throw new NotImplementedException($"Unknown resource type '{file}'");
                    }
                }
            }

            structureDefinitions.Sort((a, b) => String.Compare(Group(a), Group(b), new System.StringComparison()));
            valueSets.Sort((a, b) => String.Compare(a.Name, b.Name, new System.StringComparison()));
            codeSystems.Sort((a, b) => String.Compare(a.Name, b.Name, new System.StringComparison()));

            foreach (CodeSystem codeSystem in codeSystems)
            {
                String groupId = GetGroupPath(codeSystem);
                Save(codeSystem, $"CodeSystem-{codeSystem.Name}.json");
                this.implementationGuide.AddIGResource($"CodeSystem/{codeSystem.Name}", codeSystem.Title,
                    codeSystem.Description.ToString(), groupId, false);
            }

            foreach (ValueSet valueSet in valueSets)
            {
                String groupId = GetGroupPath(valueSet);
                Save(valueSet, $"ValueSet-{valueSet.Name}.json");
                this.implementationGuide.AddIGResource($"ValueSet/{valueSet.Name}", valueSet.Title,
                    valueSet.Description.ToString(), groupId, false);
            }

            foreach (StructureDefinition structureDefinition in structureDefinitions)
            {
                String fixedName = $"StructureDefinition-{structureDefinition.Name}";

                if (structureDefinition.Snapshot == null)
                    SnapshotCreator.Create(structureDefinition);

                Extension isFragmentExtension = structureDefinition.GetExtension(Global.IsFragmentExtensionUrl);
                // Dont add fragments to IG.
                if (isFragmentExtension == null)
                {
                    String groupId = GetGroupPath(structureDefinition);
                    Save(structureDefinition, $"{fixedName}.json");
                    String shortDescription = structureDefinition.Snapshot.Element[0].Short;

                    this.implementationGuide.AddIGResource($"StructureDefinition/{structureDefinition.Name}",
                        structureDefinition.Title,
                        shortDescription,
                        groupId,
                        false);
                }
                else
                {
                }
            }
        }

        public void AddFragments(String inputDir)
        {
            //const String fcn = "AddFragments";

            void Save(DomainResource r, String outputName)
            {
                RemoveFragmentExtensions(r);

                String outputPath = Path.Combine(this.resourceDir, outputName);
                r.SaveJson(outputPath);
                this.fcGuide?.Mark(outputPath);
            }

            List<StructureDefinition> structureDefinitions = new List<StructureDefinition>();
            foreach (String file in Directory.GetFiles(inputDir))
            {
                String fhirText = File.ReadAllText(file);
                FhirJsonParser parser = new FhirJsonParser();
                var resource = parser.Parse(fhirText, typeof(Resource));
                switch (resource)
                {
                    case StructureDefinition structureDefinition:
                        Extension isFragmentExtension = structureDefinition.GetExtension(Global.IsFragmentExtensionUrl);
                        // Onlu add fragments to IG.
                        if (isFragmentExtension != null)
                        {
                            Int32 index = structureDefinition.Url.LastIndexOf('/');
                            structureDefinitions.Add(structureDefinition);
                        }

                        break;
                }
            }

            structureDefinitions.Sort((a, b) => String.Compare(a.Url, b.Url, new System.StringComparison()));

            foreach (StructureDefinition structureDefinition in structureDefinitions)
            {
                String fixedName = $"StructureDefinition-{structureDefinition.Name}";

                if (structureDefinition.Snapshot == null)
                    SnapshotCreator.Create(structureDefinition);
                Extension isFragmentExtension = structureDefinition.GetExtension(Global.IsFragmentExtensionUrl);
                {
                    String groupId = "Fragments";
                    Save(structureDefinition, $"{fixedName}.json");
                    String shortDescription = $"Fragment '{structureDefinition.Snapshot.Element[0].Short}'";

                    this.implementationGuide.AddIGResource($"StructureDefinition/{structureDefinition.Name}",
                        structureDefinition.Title,
                        shortDescription,
                        groupId,
                        false);
                }
            }
        }

        public void AddExamples(String inputDir)
        {
            void Save(Resource r, String outputName)
            {
                String outputPath = Path.Combine(this.exampleDir, outputName);
                r.SaveJson(outputPath);
                this.fcGuide?.Mark(outputPath);
            }

            void DoFile(String file)
            {
                String fhirText = File.ReadAllText(file);
                FhirJsonParser parser = new FhirJsonParser();
                Resource resource = parser.Parse<Resource>(fhirText);

                String groupId = ResourcesMaker.Group_Examples;
                Save(resource, Path.GetFileName(file));
                String shortDescription = $"'{resource.TypeName}' example.";

                Meta m = resource.Meta;
                if ((m != null) && (m.Profile != null) && (m.Profile.Any()))
                {
                    if (m.Profile.Count() != 1)
                        throw new NotImplementedException($"Dont know how to handle multiple profiles");
                    String profile = m.Profile.First();
                    if (profile.StartsWith(Global.BreastRadBaseUrl))
                    {
                        this.implementationGuide.AddIGResource($"{resource.TypeName}/{resource.Id}",
                            shortDescription,
                            shortDescription,
                            groupId,
                            profile);
                        return;
                    }
                }

                this.implementationGuide.AddIGResource($"{resource.TypeName}/{resource.Id}",
                    shortDescription,
                    shortDescription,
                    groupId,
                    true);
            }

            foreach (String file in Directory.GetFiles(inputDir, "*.json"))
                DoFile(file);
        }
    }
}