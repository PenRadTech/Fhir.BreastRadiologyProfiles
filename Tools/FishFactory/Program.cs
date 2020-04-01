using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FishFactory
{
    class Program
    {
        public Program()
        {
        }

        void ParseArguments(String[] args)
        {
            Int32 i = 0;

            String GetArg(String errorMsg)
            {
                if (i >= args.Length)
                    throw new Exception($"Missing {errorMsg} parameter");

                String arg = args[i++].Trim();
                if ((arg[0] == '"') && (arg[arg.Length - 1] == '"'))
                    arg = arg.Substring(1, arg.Length - 2);
                return arg;
            }
            Converter em = new Converter();

            while (i < args.Length)
            {
                String arg = GetArg("arg").ToUpper();
                switch (arg)
                {
                    case "-O":
                        em.OutputDir = GetArg("-o");
                        break;

                    case "-M":
                        em.ConvertDir(GetArg("-m"));
                        break;

                    default:
                        throw new Exception($"Unknown arg {arg}");
                }
            }
        }

        static Int32 Main(string[] args)
        {
            try
            {
                Program p = new Program();
                p.ParseArguments(args);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }
    }
}
