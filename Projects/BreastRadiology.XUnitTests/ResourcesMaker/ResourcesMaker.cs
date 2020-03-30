using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        public static List<String> UniqueCitations = new List<String>();

        public static ResourcesMaker Self { get; set; }

        public const String Group_BaseResources = "BaseResources";
        public const String Group_CommonResources = "CommonResources";
        public const String Group_CommonCodesCS = "CommonCodesCS";
        public const String Group_CommonCodesVS = "CommonCodesVS";

        public const String Group_Fragments = "Fragments";

        public const String Group_AimResources = "AimResources";
        public const String Group_AimCodesCS = "AimCodesCS";
        public const String Group_AimCodesVS = "AimCodesVS";

        public const String Group_MGResources = "MGResources";
        public const String Group_MGCodesVS = "MGCodesVS";
        public const String Group_MGCodesCS = "MGCodesCS";

        public const String Group_MRIResources = "MRIResources";
        public const String Group_MRICodesVS = "MRICodesVS";
        public const String Group_MRICodesCS = "MRICodesCS";

        public const String Group_NMResources = "NMResources";
        public const String Group_NMCodesVS = "NMCodesVS";
        public const String Group_NMCodesCS = "NMCodesCS";

        public const String Group_USResources = "USResources";
        public const String Group_USCodesVS = "USCodesVS";
        public const String Group_USCodesCS = "USCodesCS";

        public const String Group_ExtensionResources = "ExtensionResources";

        public const String Group_Examples = "Examples";

        public static String BiRadCitation = "-- Bi-Rads® Atlas — Mammography Fifth Ed. 2013";
        //#const FHIRVersion FVersion = FHIRVersion.N4_0_0;

        const String ProfileVersion = "0.0.2";
        const PublicationStatus ProfileStatus = PublicationStatus.Draft;

        public static Markdown componentDefinition = new Markdown()
            .Paragraph($"This is one component of a group of components that are part of the observation.");

        Dictionary<String, Resource> resources = new Dictionary<string, Resource>();

        FileCleaner fc;
        String resourceDir;
        String pageDir;
        FhirDateTime date = new FhirDateTime(2019, 11, 1);
        public Dictionary<String, SDefEditor> Editors = new Dictionary<String, SDefEditor>();

        public static String CreateUrl(String name)
        {
            return $"http://hl7.org/fhir/us/breast-radiology/StructureDefinition/{name}";
        }

        public ResourcesMaker(FileCleaner fc,
            String resourceDir,
            String pageDir,
            String cacheDir)
        {
            const String fcn = "ResourcesMaker";

            Self = this;

            this.fc = fc;
            this.resourceDir = resourceDir;
            this.pageDir = pageDir;

            if (Directory.Exists(this.resourceDir) == false)
                Directory.CreateDirectory(this.resourceDir);

            if (Directory.Exists(this.pageDir) == false)
                Directory.CreateDirectory(this.pageDir);

            if (FhirStructureDefinitions.Self == null)
            {
                this.ConversionInfo(this.GetType().Name, fcn, $"Init'g 'FhirStructureDefinitions'");
                FhirStructureDefinitions.Create(cacheDir);
            }
        }

        SDefEditor CreateEditor(String name,
            String title,
            String mapName,
            String baseDefinition,
            String groupPath)
        {
            if (name.Contains(" ", new StringComparison()))
                throw new Exception("Structure Def name can not contains spaces");

            title = title.Trim();
            SDefEditor retVal = new SDefEditor(this, name, CreateUrl(name), baseDefinition, mapName, this.resourceDir,
                        this.pageDir)
                    .Title(title)
                    .Derivation(StructureDefinition.TypeDerivationRule.Constraint)
                    .Abstract(false)
                    .Type(baseDefinition.LastUriPart())
                    .Kind(StructureDefinition.StructureDefinitionKind.Resource)
                    .Status(PublicationStatus.Draft)
                ;

            retVal.SDef.FhirVersion = FHIRVersion.N4_0_0;

            this.Editors.Add(retVal.SDef.Url, retVal);

            // store groupPath as an extension. This is an unregistered extension that will be removed before
            // processing is complete.
            retVal.SDef.Extension.Add(new Extension
            {
                Url = Global.GroupExtensionUrl,
                Value = new FhirString(groupPath)
            });

            return retVal;
        }

        String Article(String title)
        {
            switch (Char.ToLower(title[0]))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return "an";

                default:
                    return "a";
            }
        }

        SDefEditor CreateEditor(String name,
            String title,
            String mapName,
            String baseDefinition,
            String groupPath,
            String docTemplateName)
        {
            title = title.Trim();
            SDefEditor retVal = this.CreateEditor(name, title, mapName, baseDefinition, groupPath);

            retVal.IntroDoc = new IntroDoc();
            retVal.IntroDoc.TryAddUserMacro("FocusPath", FocusMapMaker.FocusMapName(retVal.SDef.Url.LastUriPart()));
            retVal.IntroDoc.TryAddUserMacro("TitleArticle", this.Article(title));
            retVal.IntroDoc.TryAddUserMacro("Title", title);
            retVal.IntroDoc.Load(docTemplateName, Path.Combine(this.pageDir, $"StructureDefinition-{name}-intro.xml"));

            return retVal;
        }

        SDefEditor CreateFragment(String name,
            String title,
            String mapName,
            String baseDefinition)
        {
            SDefEditor retVal = this.CreateEditor(name,
                title,
                mapName,
                baseDefinition,
                $"Fragment/{name}");
            retVal.SetIsFrag();
            retVal.SDef.Abstract = true;

            retVal.IntroDoc = new IntroDoc();
            retVal.IntroDoc.TryAddUserMacro("FragPath",
                FragmentMapMaker.FragmentMapName(retVal.SDef.Url.LastUriPart()));
            retVal.IntroDoc.TryAddUserMacro("TitleArticle", this.Article(title));
            retVal.IntroDoc.TryAddUserMacro("Title", title);
            retVal.IntroDoc.Load("Fragment",
                Path.Combine(this.pageDir, $"StructureDefinition-{name}-intro.xml"));

            retVal.SDef.Version = "Fragment"; // this will get stripped out when unfrag'd.

            return retVal;
        }

        String CodeSystemUrl(String name) => $"{Global.BreastRadBaseUrl}CodeSystem/{name}";

        CodeSystem CreateCodeSystem(String name,
            String title,
            String mapName,
            String description,
            String groupPath,
            IEnumerable<ConceptDef> codes)
        {
            CodeSystem cs = new CodeSystem
            {
                Id = name,
                Url = this.CodeSystemUrl(name),
                Name = name,
                Title = title,
                Description = new Markdown(description),
                CaseSensitive = true,
                Content = CodeSystem.CodeSystemContentMode.Complete,
                Count = codes.Count(),
            };
            cs.AddFragRef(this.HeaderFragment);

            // store groupPath as an extension. This is an unregistered extension that will be removed before
            // processing is complete.
            cs.Extension.Add(new Extension
            {
                Url = Global.GroupExtensionUrl,
                Value = new FhirString(groupPath)
            });

            foreach (ConceptDef code in codes)
            {
                cs.Concept.Add(new CodeSystem.ConceptDefinitionComponent
                {
                    Code = code.Code,
                    Display = code.Display,
                    Definition = code.Definition
                });
            }

            this.resources.Add(Path.Combine(this.resourceDir, $"CodeSystem-{name}.json"), cs);
            return cs;
        }

        /// <summary>
        /// Create a value set of all the codes in the passed code system.
        /// </summary>
        ValueSet CreateValueSet(String name,
            String title,
            String mapName,
            String description,
            String groupPath,
            CodeSystem cs = null)
        {
            ValueSet vs = new ValueSet
            {
                Id = name,
                Url = $"http://hl7.org/fhir/us/breast-radiology/ValueSet/{name}",
                Name = name,
                Title = title,
                Description = new Markdown(description)
            };
            vs.AddFragRef(this.HeaderFragment);

            // store groupPath as an extension. This is an unregistered extension that will be removed before
            // processing is complete.
            vs.Extension.Add(new Extension
            {
                Url = Global.GroupExtensionUrl,
                Value = new FhirString(groupPath)
            });

            this.resources.Add(Path.Combine(this.resourceDir, $"ValueSet-{name}.json"), vs);
            Debug.Assert(mapName.Contains("Tumor Satellite") == false);
            vs.AddExtension(Global.ResourceMapNameUrl, new FhirString(mapName));

            if (cs == null)
                return vs;

            ValueSet.ConceptSetComponent vsComp = new ValueSet.ConceptSetComponent
            {
                System = cs.Url
            };

            vs.Compose = new ValueSet.ComposeComponent();
            vs.Compose.Include.Add(vsComp);

            foreach (var code in cs.Concept)
            {
                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = code.Code,
                    Display = code.Display
                });
            }

            return vs;
        }

        public void CreateResources()
        {
            if (Directory.Exists(this.resourceDir) == false)
                Directory.CreateDirectory(this.resourceDir);
            if (Directory.Exists(this.pageDir) == false)
                Directory.CreateDirectory(this.pageDir);

            // we have to manually force the creation of the following to get
            // all the necessary objects to be created.
            this.HeaderFragment = BRHeaderFragment.Value();
            this.ObservationCodesCS.Value();
            this.CompositionSectionSliceCodesCS.Value();
            this.ComponentSliceCodesCS.Value();
            this.BreastRadiologyDocument.Value();
            this.BreastRadiologyReport.Value();
            this.UnitsOfLengthVS.Value();

            this.SaveAll();
        }

        public void CreateAcrResources()
        {
            if (Directory.Exists(this.resourceDir) == false)
                Directory.CreateDirectory(this.resourceDir);
            if (Directory.Exists(this.pageDir) == false)
                Directory.CreateDirectory(this.pageDir);

            // we have to manually force the creation of the following to get
            // all the necessary objects to be created.
            this.HeaderFragment = AcrHeaderFragment.Value();
            this.ImagingContextExtension.Value();
            this.ImageRegionExtension.Value();

            this.SaveAll();
        }

        public void SaveAll()
        {
            foreach (KeyValuePair<string, Resource> resourceItem in this.resources)
            {
                resourceItem.Value.SaveJson(resourceItem.Key);
                this.fc?.Mark(resourceItem.Key);
            }

            foreach (SDefEditor sDefEditor in this.Editors.Values)
            {
                if (sDefEditor.Write(out String fragmentName))
                    this.fc?.Mark(fragmentName);
                if (sDefEditor.IntroDoc != null)
                {
                    String path = sDefEditor.IntroDoc.Save();
                    this.fc?.Mark(path);
                }
            }

            //Self.Data.BreastData.Save();
        }

        IntroDoc CreateIntroDocVS(ValueSet binding)
        {
            IntroDoc doc = new IntroDoc();
            doc.TryAddUserMacro("TitleArticle", this.Article(binding.Title));
            doc.TryAddUserMacro("Title", binding.Title);
            doc.TryAddUserMacro("FocusPath", FocusMapMaker.FocusMapName(binding.Name));
            doc.Load("ValueSet",
                Path.Combine(Self.pageDir, $"ValueSet-{binding.Name}-intro.xml"));
            return doc;
        }

        public static String[] FormatUmls(List<String> lines, bool paragraphTag)
        {
            // Make sure all '###'s are on new line.
            {
                Int32 i = 0;
                while (i < lines.Count)
                {
                    String line = lines[i];
                    Int32 index = line.IndexOf("###");
                    if (index == 0)
                    {
                        i += 1;
                    }
                    else if (index > 0)
                    {
                        String oldLine = line.Substring(0, index);
                        String newLine = line.Substring(index);
                        lines.RemoveAt(i);
                        lines.Insert(i++, "");
                        lines.Insert(i++, oldLine);
                        lines.Insert(i++, newLine);
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }
            {
                StringBuilder sb = new StringBuilder();

                if (lines.Count > 0)
                    while ((lines.Count > 0) && String.IsNullOrWhiteSpace(lines[^1]))
                        lines.RemoveAt(lines.Count - 1);
                if (lines.Count == 0)
                    return new string[0];

                void Citation(String citation)
                {
                    String cleanCit = citation;
                    if (cleanCit.StartsWith("https://"))
                        cleanCit = cleanCit.Substring(8);
                    if (cleanCit.StartsWith("http://"))
                        cleanCit = cleanCit.Substring(7);
                    Int32 index = cleanCit.IndexOf('/');
                    if (index > 0)
                        cleanCit = cleanCit.Substring(0, index);

                    index = cleanCit.IndexOf('#');
                    if (index > 0)
                        cleanCit = cleanCit.Substring(0, index);

                    if (UniqueCitations.Contains(cleanCit) == false)
                        UniqueCitations.Add(cleanCit);
                    //citation = citation
                    //    .Replace(" ", "&nbsp;")
                    //    ;
                    sb
                        .AppendLine($" [{citation}]")
                        .AppendLine("")
                        ;
                }

                void AcrCitation(String name, String page)
                {
                    string pageStr = "";
                    if (String.IsNullOrEmpty(page) == false)
                        pageStr = $" page {page}";
                    Citation($"{name}{pageStr}");
                }

                Int32 i = 0;
                while (i < lines.Count)
                {
                    String line = lines[i++];
                    if (line.StartsWith("###") == true)
                    {
                        line = line.Substring(3);
                        Int32 index = line.IndexOf('#');
                        String citationType = line.Substring(0, index);
                        String page = line.Substring(index + 1);
                        switch (citationType)
                        {
                            case "URL":
                                Citation(line.Substring(index + 1));
                                break;
                            case "ACRUS":
                                AcrCitation("Breast Imaging Reporting and Data System—Mammography, Fifth Edition",
                                    page);
                                break;
                            case "ACRMG":
                                AcrCitation("Breast Imaging Reporting and Data System—Ultrasound, Second Edition",
                                    page);
                                break;
                            default:
                                throw new Exception("");
                        }
                    }
                    else
                    {
                        Debug.Assert(line.Contains("###") == false);
                        sb.AppendLine(line);
                    }
                }

                return sb.ToString().ToLines();
            }
        }

        public static String FormatLines(IEnumerable<String> iLines)
        {
            List<String> lines = iLines.ToList();

            StringBuilder sb = new StringBuilder();

            void CopyLines(Int32 count)
            {
                for (Int32 i = 0; i < count; i++)
                    sb.Append(lines[i]);
            }

            if (lines.Count > 0)
                while ((lines.Count > 0) && String.IsNullOrWhiteSpace(lines[^1]))
                    lines.RemoveAt(lines.Count - 1);
            if (lines.Count == 0)
                return "";

            CopyLines(lines.Count);
            return sb.ToString();
        }
    }
}