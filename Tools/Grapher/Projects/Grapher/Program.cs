using System;
using System.IO;
using Hl7.Fhir.Model;

namespace Grapher
{
    class Program
    {
        private String[] args;
        private Int32 argIndex;
        GraphMaker maker = new GraphMaker();

        public Program(String[] args)
        {
            this.args = args;
        }

        void Usage()
        {
            Console.WriteLine("usage: -o 'oDir' -i {iPath} -g {graph}");
            Console.WriteLine("where:");
            Console.WriteLine("oDir is the graphic output directory.");
            Console.WriteLine("iPath is a file or directory path to fhir file(s).");
            Console.WriteLine("graph is the name of the graph to process.");
            throw new Exception("Usage error");
        }

        String GetArg()
        {
            if (argIndex >= args.Length)
                this.Usage();
            String retVal = args[argIndex++];
            if (retVal[0] == '"')
                retVal = retVal.Substring(1);
            if (retVal[retVal.Length - 1] == '"')
                retVal = retVal.Substring(0, retVal.Length - 1);
            return retVal;
        }

        void ParseArgs()
        {
            Int32 i = 0;
            while (i < args.Length)
            {
                String arg = this.GetArg();
                switch (arg)
                {
                    case "-g":
                        this.maker.Graph = this.GetArg();
                        break;

                    case "-i":
                        this.maker.AddResources(this.GetArg());
                        break;

                    case "-o":
                        this.maker.GraphicsOutputDir = this.GetArg();
                        break;

                    default:
                        this.Usage();
                        break;
                }
                i += 1;
            }
        }

        Int32 Execute()
        {
            try
            {
                this.ParseArgs();
                //String optionsFile = Path.Combine(DirHelper.FindParentDir("FriendlyFhir.Maker"), "Options.txt");
                //if (File.Exists(optionsFile))
                //{
                //    String optionsTxt = File.ReadAllText(optionsFile);
                //    String[] optionsArr = optionsTxt.ToArgs();
                //    this.ParseArgs(optionsArr, maker);
                //}
                maker.StatusErrors += this.Dfg_StatusErrors;
                maker.StatusInfo += this.Dfg_StatusInfo;
                maker.StatusWarnings += this.Dfg_StatusWarnings;

                Int32 retVal = maker.Process();
                return retVal;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return -1;
            }
}

private void Message(ConsoleColor color, string className, string method, string msg)
{
    Console.ForegroundColor = color;
    Console.WriteLine($"{className}.{method}: {msg}");
    Console.ForegroundColor = ConsoleColor.Black;
}
private bool Dfg_StatusWarnings(string className, string method, string msg)
{
    this.Message(ConsoleColor.Yellow, className, method, msg);
    return true;
}
private bool Dfg_StatusInfo(string className, string method, string msg)
{
    this.Message(ConsoleColor.White, className, method, msg);
    return true;
}
private bool Dfg_StatusErrors(string className, string method, string msg)
{
    this.Message(ConsoleColor.Red, className, method, msg);
    return true;
}

static Int32 Main(string[] args)
{
    Program p = new Program(args);
    return p.Execute();

    //const String BaseDir = @"C:\Development\covid-19\input";
    //const String PageContentDir = BaseDir + @"\pagecontent";
    //const String GraphicsDir = BaseDir + @"\images";
    //const String ResourceDir = BaseDir + @"\profiles";
    //const String VocabDir = BaseDir + @"\vocabulary";
    //const String structureBaseUrl =
    //    "http://fhir.logicahealth.org/covid19/StructureDefinition/c19-laboratory-observation-base";

    //ResourceMap map = new ResourceMap();
    //map.AddDir(ResourceDir, "*.json");
    //map.AddDir(VocabDir, "*.json");
    //{
    //    HierarchyMapMaker g = new HierarchyMapMaker(map);
    //    g.CreateGraph(structureBaseUrl,
    //        Path.Combine(GraphicsDir, "IntroGraphic.svg"));
    //}
    //{
    //    FocusMapMaker g = new FocusMapMaker(map, GraphicsDir, PageContentDir);
    //    g.Create();
    //}
}
    }
}
