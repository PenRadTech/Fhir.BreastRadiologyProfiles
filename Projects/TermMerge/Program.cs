using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermMerge
{
    static class Program
    {
        public static FhirResources fhirResources = new FhirResources();


        static void ParseParams(String[] args)
        {
            Int32 i = 0;

            String Next()
            {
                if (i >= args.Length)
                    throw new Exception("Command line argument parse error");
                return args[i++];
            }

            while (i < args.Length)
            {
                string cmd = Next().Trim().ToLower();
                switch (cmd)
                {
                    case "-fhir":
                        fhirResources.AddResources(Next());
                        break;

                    default:
                        throw new NotImplementedException($"Unknown command line parameter '{cmd}'");
                }
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            ParseParams(args);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
