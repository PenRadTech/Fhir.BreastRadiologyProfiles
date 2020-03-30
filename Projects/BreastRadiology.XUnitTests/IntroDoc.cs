using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Helper class for making xxx-intro.xml files.
    /// These files provide the html verbage for the introduction of a fhir class
    /// html page in the IG.
    /// </summary>
    class IntroDoc
    {
        public String OutputPath { get; set; }
        CodeEditorXml codeEditor;

        public IntroDoc()
        {
            this.codeEditor = new CodeEditorXml();
            this.codeEditor.IgnoreMacrosInQuotedStrings = false;
        }

        public bool TryAddUserMacro(String name, String value)
        {
            return this.codeEditor.TryAddUserMacro(name, value);
        }

        public void Load(String templateName,
            String outputPath)
        {
            this.OutputPath = outputPath;
            String fullPath = Path.Combine("IntroDocTemplates", $"{templateName}.template");
            this.codeEditor.Load(fullPath);
        }

        //CodeBlockNested reviewStatusBlock = null;
        CodeBlockNested descriptionBlock = null;

        public IntroDoc ReviewedStatus(String reviewer)
        {
            //if (this.reviewStatusBlock == null)
            //{
            //    this.reviewStatusBlock = this.codeEditor.Blocks.Find("reviewStatus");
            //    if (this.reviewStatusBlock == null)
            //        throw new Exception($"reviewStatus block missing");
            //    this.reviewStatusBlock
            //        .AppendRaw($"<p>")
            //        .AppendRaw($"  <u style=\"font-size:large;\">Review Status</u>")
            //        .AppendRaw($"</p>")
            //        .AppendRaw($"<p>")
            //        .AppendRaw($"Comments and Suggested changes to this implementation guide can be made ")
            //        .AppendRaw($"<a href=\"https://github.com/HL7/fhir-breast-radiology-ig/projects/1\">here</a>")
            //        .AppendRaw($"</p>")
            //        ;
            //}

            //this.reviewStatusBlock
            //    .AppendRaw($"<p>{reviewer}</p>")
            //    ;

            return this;
        }

        CodeBlockNested CreateDescriptionBlock()
        {
            if (this.descriptionBlock != null)
                return this.descriptionBlock;
            this.descriptionBlock = this.codeEditor.Blocks.Find("descriptions");
            if (this.descriptionBlock == null)
                throw new Exception($"'descriptions' block missing");
            ;
            return this.descriptionBlock;
        }

        void WriteParagraphs(CodeBlockNested d,
            String[] lines)
        {
            bool newParagraph = true;

            void Line(String line)
            {
                line = line.Trim();
                if (
                    (line.Length == 0) &&
                    (newParagraph == false)
                )
                {
                    d.AppendRaw($"</p>\n");
                    newParagraph = true;
                    return;
                }

                if (newParagraph == true)
                {
                    d.AppendRaw($"<p>\n");
                    newParagraph = false;
                }

                d.AppendRaw($"{line}\n");
            }

            foreach (String line in lines)
                Line(line);
            if (newParagraph == false)
                d.AppendRaw($"</p>\n");
        }

        String Title()
        {
            if (this.codeEditor.TryGetUserMacro("Title", out object value) == false)
                throw new Exception("Error accessing title macro");
            return (String) value;
        }

        public IntroDoc ACRDescription(params String[] lines)
        {
            CodeBlockNested d = CreateDescriptionBlock();
            d
                .AppendRaw($"<p>")
                .AppendRaw($"  <u style=\"font-size:large;\">ACR {Title()} Definition</u>")
                .AppendRaw($"</p>")
                ;
            WriteParagraphs(d, lines);
            return this;
        }

        [Obsolete]
        public IntroDoc MissingDescription()
        {
            //CodeBlockNested d = CreateDescriptionBlock();
            //d
            //    .AppendRaw($"<p>")
            //    .AppendRaw($"  <u style=\"font-size:large;color:red;\">{Title()} Missing Description</u>")
            //    .AppendRaw($"</p>")
            //    ;
            return this;
        }

        public IntroDoc Description(params String[] lines)
        {
            CodeBlockNested d = CreateDescriptionBlock();
            d
                .AppendRaw($"<p>")
                .AppendRaw($"  <u style=\"font-size:large\">{Title()} Definition</u>")
                .AppendRaw($"</p>")
                ;
            String[] citedLines = ResourcesMaker.FormatUmls(lines.ToList(), true);
            WriteParagraphs(d, citedLines);
            return this;
        }

        public String Render()
        {
            return this.codeEditor.ToString();
        }

        public String Save()
        {
            String introHtml = this.Render();
            FileTools.WriteAllText(this.OutputPath, introHtml);
            return this.OutputPath;
        }
    }
}