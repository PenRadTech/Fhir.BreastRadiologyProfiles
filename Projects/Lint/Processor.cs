using Eir.DevTools;
using Eir.FhirKhit.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lint
{
    class Processor : IConversionInfo
    {
        FhirResources fhirResources = new FhirResources();


        public void AddResources(params String[] inputDirs) => this.fhirResources.AddResources(inputDirs);

        public Processor()
        {
        }

        void Process(CodeSystem codeSystem)
        {
        }

        public void Process()
        {
            foreach (StructureDefinition sd in this.fhirResources.StructureDefinitions.Values)
            {
                LinterStructureDefinition linter = new LinterStructureDefinition(this, sd);
                linter.FindLint();
            }
        }

        void Msg(ConsoleColor import, string className, string method, string msg)
        {
            Console.ForegroundColor = import;
            Console.WriteLine($"{import} [{className}.{method}] '{msg}'");
        }

        public void ConversionError(string className, string method, string msg) => Msg(ConsoleColor.Red, className, method, msg);

        public void ConversionInfo(string className, string method, string msg) => Msg(ConsoleColor.Black, className, method, msg);

        public void ConversionWarn(string className, string method, string msg) => Msg(ConsoleColor.DarkYellow, className, method, msg);
    }
}
