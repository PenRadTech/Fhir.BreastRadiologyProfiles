using FhirKhit.Tools.R4;
using System;
using FhirKhit.Tools;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace AutoValidate
{
    class Program
    {
        String ValidationPath = @"C:\Development\HL7\BreastRadiologyProfiles\Cache\validation.xml";
        String ResourcesPath = @"C:\Development\HL7\BreastRadiologyProfiles\IG\Content\Resources";
        String ExamplesPath = @"C:\Development\HL7\BreastRadiologyProfiles\IG\Content\Examples";
        String JarPath = @"C:\Development\HL7\BreastRadiologyProfiles\Projects\BreastRadiology.XUnitTests\org.hl7.fhir.validator.jar";

        FileSystemWatcher watcher;

        public Program()
        {
        }

        private bool StatusWarnings(string className, string method, string msg)
        {
            this.Message(ConsoleColor.Yellow, className, method, msg);
            return true;
        }

        private void Message(ConsoleColor import, string className, string method, string msg)
        {

            Console.ForegroundColor = import;
            Console.WriteLine($"{className}.{method}: {msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private bool StatusInfo(string className, string method, string msg)
        {
            //this.Message("Info", className, method, msg);
            return true;
        }

        private bool StatusErrors(string className, string method, string msg)
        {
            this.Message(ConsoleColor.Red, className, method, msg);
            return true;
        }

        void RunValidate()
        {
            Console.Clear();
            Thread.Sleep(500);

            Console.WriteLine("Starting validation");
            FhirValidator fv = new FhirValidator(ValidationPath);
            fv.JarPath = this.JarPath;
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;
            fv.ValidatorArgs = $" -ig {this.ResourcesPath} ";
            fv.ValidateDir(this.ExamplesPath, "*.json", "4.0.0");
            Console.WriteLine("Validation complete");
            Console.WriteLine("Press 'q' to quit the sample.");
        }

        void Run()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = this.ExamplesPath;

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite
                                   | NotifyFilters.FileName
                                   | NotifyFilters.DirectoryName;

            // Only watch text files.
            watcher.Filter = "*.json";

            // Add event handlers.
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnChanged;

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            do
            {
                RunValidate();
            } while (Console.Read() != 'q');
        }

        void OnChanged(object source, FileSystemEventArgs e)
        {
            this.watcher.EnableRaisingEvents = false;
            RunValidate();
            this.watcher.EnableRaisingEvents = true;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
    }
}
