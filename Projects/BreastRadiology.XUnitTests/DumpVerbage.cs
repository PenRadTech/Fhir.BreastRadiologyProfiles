using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Specification.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using PreFhir;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using System.Collections.Generic;
using BreastRadiology.XUnitTests;
using System.Drawing;
using ExcelDataReader;
using System.Data;
using System.Globalization;
using System.Linq;
using BreastRadiology.Shared;
using ClosedXML.Excel;

namespace BreastRadiology.XUnitTests
{
    [TestClass]
    public class DumpVerbage
    {
        StructureDefinition baseDef = null;
        ElementTreeNode snapNode;


        void SetBaseDef(String baseDefinition)
        {
            if (
                (this.baseDef != null) &&
                (this.baseDef.Url == baseDefinition)
            )
                return;
            this.baseDef = FhirStructureDefinitions.Self.GetResource(baseDefinition);

            ElementTreeLoader l = new ElementTreeLoader();
            this.snapNode = l.Create(this.baseDef.Snapshot.Element);
        }

        const String BaseDirName = "BreastRadiologyProfiles";
        Int32 anchorNum = 1;

        void DumpHeader(CodeBlockNested b,
            String level,
            String header)
        {
            b
                .AppendRaw($"<a name=\"{this.anchorNum++.ToString()}\">  </a>")
                .AppendRaw($"<{level}>{header}</{level}>")
                ;
        }

        void DumpLines(CodeBlockNested b,
            String level,
            String header,
            String s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return;

            DumpHeader(b, level, header);
            s = s
                    .Replace("\r", "")
                    .Replace("\n\n", "</p><p>")
                ;
            b.AppendRaw($"<p>{s}</p>");
        }

        void DumpElement(CodeBlockNested b,
            StructureDefinition sd,
            ElementDefinition e)
        {
            String Diff(String a, String b)
            {
                if (a == null)
                    return a;
                if (b == null)
                    return a;
                if (String.Compare(a, b) == 0)
                    return null;
                return a;
            }

            ElementDefinition baseE = null;
            if (this.snapNode != null)
            {
                this.snapNode.TryGetElementNode(e.Path, out ElementTreeNode baseElement);
                baseE = baseElement?.ElementDefinition;
            }

            String shortText = Diff(e?.Short, baseE?.Short);
            String definitionText = Diff(e.Definition?.Value, baseE?.Definition?.Value);
            String commentText = Diff(e.Comment?.Value, baseE?.Comment?.Value);

            if (
                (String.IsNullOrWhiteSpace(shortText)) &&
                (String.IsNullOrWhiteSpace(definitionText)) &&
                 (String.IsNullOrWhiteSpace(commentText))
            )
                return;

            DumpHeader(b, "h3", $"{sd.Name}:{e.ElementId}");
            DumpLines(b, "h4", "Short", shortText);
            DumpLines(b, "h4", "Definition", definitionText);
            DumpLines(b, "h4", "Comment", commentText);
        }


        void Dump(CodeBlockNested b, StructureDefinition sd)
        {
            this.SetBaseDef(sd.BaseDefinition);
            b
                .AppendRaw($"<a name=\"{sd.Name}\">  </a>")
                .AppendRaw($"<h1>StructureDefinition: '{sd.Name}'</h1>")
                ;
            DumpLines(b, "h2", "Description", sd.Description.Value);
            foreach (ElementDefinition e in sd.Differential.Element.Skip(1))
                DumpElement(b, sd, e);
        }


        void Dump(CodeBlockNested b, ValueSet vs)
        {
            b
                .AppendRaw($"<a name=\"{vs.Name}\">  </a>")
                .AppendRaw($"<h1>ValueSet: '{vs.Name}'</h1>")
                ;
            DumpLines(b, "h2", "Description", vs.Description.Value);
        }

        void Dump(CodeBlockNested b, CodeSystem cs)
        {
            b
                .AppendRaw($"<a name=\"{cs.Name}\">  </a>")
                .AppendRaw($"<h1>CodeSystem: '{cs.Name}'</h1>")
                ;
            DumpLines(b, "h2", "Description", cs.Description.Value);

            foreach (CodeSystem.ConceptDefinitionComponent e in cs.Concept)
            {
                DumpHeader(b, "h2", $"Code: {e.Code}");
                DumpLines(b, "h3", "Display", e.Display);
                DumpLines(b, "h3", "Definition", e.Definition);
            }
        }

        void Dump(CodeBlockNested b)
        {
            String dir = Path.Combine(
                DirHelper.FindParentDir(BaseDirName),
                "IG",
                "Content",
                "Resources"
            );

            foreach (String file in Directory.GetFiles(dir, "*.json"))
            {
                String fhirText = File.ReadAllText(file);
                FhirJsonParser parser = new FhirJsonParser();
                var resource = parser.Parse(fhirText, typeof(Resource));
                switch (resource)
                {
                    case StructureDefinition structureDefinition:
                        this.Dump(b, structureDefinition);
                        break;

                    case CodeSystem codeSystem:
                        this.Dump(b, codeSystem);
                        break;

                    case ValueSet valueSet:
                        this.Dump(b, valueSet);
                        break;

                    default:
                        throw new NotImplementedException($"Unknown resource type '{file}'");
                }
            }
        }

        [TestMethod]
        public void Dump()
        {
            String baseDir = DirHelper.FindParentDir("BreastRadiology.XUnitTests");
            String rDir = Path.Combine(baseDir, "Resources");
            String path = Path.Combine(rDir, "Template.html");

            String cacheDir = Path.Combine(baseDir, "Cache");
            FhirStructureDefinitions.Create(cacheDir);

            CodeEditor ce = new CodeEditor();

            ce.Load(path);
            CodeBlockNested b = ce.Blocks.Find("Body");
            this.Dump(b);
            ce.Save(Path.Combine(DirHelper.FindParentDir(BaseDirName), "IG", "Content", "Dump.html"));
        }
    }
}