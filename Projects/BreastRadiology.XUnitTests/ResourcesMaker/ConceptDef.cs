using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FhirKhit.Tools.R4;

namespace BreastRadiology.XUnitTests
{
    class ConceptDef
    {
        public String Code { get; set; }
        public String Display { get; set; }

        public String Definition
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                void WriteParagraphs(String[] lines)
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
                            newParagraph = true;
                            return;
                        }

                        if (newParagraph == true)
                        {
                            sb.AppendLine("");
                            newParagraph = false;
                        }

                        sb.AppendLine($"{line} ");
                    }

                    if (lines == null)
                        return;

                    foreach (String line in lines)
                        Line(line);
                    if (newParagraph == false)
                        sb.AppendLine("");
                }

                WriteParagraphs(this.definitionText);

                if (this.umlsText != null)
                {
                    WriteParagraphs(this.umlsText);
                }
                else if (this.biRadsText != null)
                {
                    WriteParagraphs(this.biRadsText);
                    sb.AppendLine($"-- {ResourcesMaker.BiRadCitation}");
                }

                if (String.IsNullOrEmpty(this.modalities) == false)
                    WriteParagraphs(new string[] { this.modalities });
                return sb.ToString();
            }
        }

        String modalities { get; set; }

        String[] definitionText;
        String[] biRadsText;
        String[] umlsText;
        String mammoId = null;

        public ConceptDef()
        {
        }

        public ConceptDef SetCode(String code, String display)
        {
            this.Code = code;
            this.Display = display;
            return this;
        }

        public ConceptDef SetCode(Coding code)
        {
            this.Code = code.Code;
            this.Display = code.Display;

            return this;
        }

        public ConceptDef SetCode(params String[] lines)
        {
            this.Code = lines.Collate();
            return this;
        }

        public ConceptDef SetDisplay(params String[] lines)
        {
            this.Display = lines.Collate();
            return this;
        }

        public ConceptDef SetDefinition(params String[] def)
        {
            this.definitionText = def;
            return this;
        }

        public ConceptDef ValidModalities(Modalities modalities)
        {
            StringBuilder sb = new StringBuilder();

            void Add(Modalities flag)
            {
                if ((modalities & flag) == flag)
                    sb.Append($" {flag.ToString()}");
            }

            sb.Append("Valid for the following modalities:");
            Add(Modalities.MG);
            Add(Modalities.US);
            Add(Modalities.MRI);
            Add(Modalities.NM);
            sb.AppendLine(".");
            this.modalities = sb.ToString();
            return this;
        }

        public ConceptDef SetDicom(String penId, params String[] lines)
        {
            return this;
        }

        public ConceptDef SetACR(params String[] lines)
        {
            this.biRadsText = lines;
            return this;
        }

        public ConceptDef MammoId(String id)
        {
            this.mammoId = id;
            return this;
        }

        public ConceptDef SetSnomedCode(String penId, params String[] lines)
        {
            return this;
        }

        public ConceptDef SetOneToMany(params String[] lines)
        {
            return this;
        }

        public ConceptDef SetSnomedDescription(String penId, params String[] lines)
        {
            return this;
        }

        public ConceptDef SetICD10(params String[] lines)
        {
            return this;
        }

        public ConceptDef SetComment(params String[] lines)
        {
            return this;
        }

        public ConceptDef SetUMLS(String penId,
            params String[] value)
        {
            this.umlsText = ResourcesMaker.FormatUmls(value.ToList(), false);
            return this;
        }
    }
}