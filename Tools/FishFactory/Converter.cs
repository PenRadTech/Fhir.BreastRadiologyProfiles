using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FhirKhit.Tools;

namespace FishFactory
{
    class Converter
    {
        public String OutputDir;

        void ConvertCodeSystem(String fileName,
            CodeSystem cs)
        {
            String outputPath = Path.Combine(this.OutputDir, 
                $"{cs.Name.ToMachineName()}.fsh");
            CodeEditor ce = new CodeEditor();
            CodeBlockNested code = ce.Blocks.AppendBlock();
            code
                .AppendRaw($"CodeSystem: {cs.Name}")
                .AppendRaw($"Title: {cs.Title}")
                .AppendRaw($"Description: {cs.Description}")
                .DefineBlock(out CodeBlockNested concepts, "Codes")
                ;

            foreach (var concept in cs.Concept)
            {
                String codeStr = concept.Code;
                String display = concept.Display;
                String definition = concept.Definition.Replace("\r", "");
                concepts.AppendRaw($"#{codeStr} \"{display}\"");
                //$if (String.IsNullOrWhiteSpace(definition) == false)
                //{
                //    concepts.AppendRaw($"    \"\"\"");
                //    foreach (String line in definition.Split("\n"))
                //        concepts.AppendRaw($"    {line}");
                //    concepts.AppendRaw($"    \"\"\"");
                //}
            }

            ce.Save(outputPath);
        }


        void ConvertFile(String fileName)
        {
            FhirJsonParser parser = new FhirJsonParser();
            DomainResource dr = parser.Parse<DomainResource>(File.ReadAllText(fileName));
            switch (dr)
            {
                case CodeSystem cs:
                    ConvertCodeSystem(fileName, cs);
                    break;
            }
        }

        public void ConvertDir(String dir)
        {
            Console.WriteLine($"note Converting {dir}");
            foreach (String fileName in Directory.GetFiles(dir, "*.json"))
            {
                ConvertFile(fileName);
            }
        }
    }
}
