using Eir.DevTools;
using Eir.FhirKhit.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lint
{
    class Processor : IConversionInfo
    {
        FhirResources fhirResources = new FhirResources();

        public void AddResources(params String[] inputDirs) => this.fhirResources.AddResources(inputDirs);

        List<Regex> lintIgnore = new List<Regex>();
        public Processor()
        {
            foreach (String lintLine in File.ReadAllLines("LintStuff.txt"))
            {
                String s = lintLine.Trim();
                if (String.IsNullOrEmpty(s) == false)
                    this.lintIgnore.Add(new Regex(s));
            }
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

        void Msg(ConsoleColor import, string url, string msg)
        {
            Console.ForegroundColor = import;
            Console.WriteLine($"[{url.LastUriPart()}] '{msg}'");
        }

        void Msg(ConsoleColor import, string msg)
        {
            Console.ForegroundColor = import;
            Console.WriteLine(msg);
        }

        public void LintMsg(LinkNumbers linkNumber, String url, String path, String msg)
        {
            String lintLine = $"{((Int32)linkNumber).ToString()}-{url.LastUriPart()}-{path}";
            bool Ignore()
            {
                foreach (Regex r in this.lintIgnore)
                {
                    if (r.IsMatch(lintLine))
                        return true;
                }
                return false;
            }

            if (Ignore())
                return;

            Msg(ConsoleColor.Green, lintLine);
            Msg(ConsoleColor.Green,
                msg);
        }

        public void ConversionError(string className, string method, string msg) => Msg(ConsoleColor.Red, className, msg);

        public void ConversionInfo(string className, string method, string msg) => Msg(ConsoleColor.Black, className, msg);

        public void ConversionWarn(string className, string method, string msg) => Msg(ConsoleColor.DarkYellow, className, msg);
    }
}
