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
            String outputPath = Path.Combine(this.OutputDir, cs.Name.ToMachineName());
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
