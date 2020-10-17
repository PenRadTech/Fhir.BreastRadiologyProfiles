using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lint
{
    static class Program
    {
        static void ParseParams(Processor processor,
            String[] args)
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
                        processor.AddResources(Next());
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
            while (true)
            {
                try
                {
                    Processor processor = new Processor();
                    ParseParams(processor, args);
                    processor.Process();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("enter to re-run");
                Console.ReadLine();
            }
        }
    }
}
