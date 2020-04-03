using System;
using System.IO;

namespace Grapher
{
    class Program
    {
        static void Main(string[] args)
        {
            const String BaseDir = @"C:\Development\covid-19\input";
            const String PageContentDir = BaseDir + @"\pagecontent";
            const String GraphicsDir = BaseDir + @"\images";
            const String ResourceDir = BaseDir + @"\profiles";
            const String VocabDir = BaseDir + @"\vocabulary";
            const String structureBaseUrl =
                "http://fhir.logicahealth.org/covid19/StructureDefinition/c19-laboratory-observation-base";

            ResourceMap map = new ResourceMap();
            map.AddDir(ResourceDir, "*.json");
            map.AddDir(VocabDir, "*.json");
            {
                HierarchyMapMaker g = new HierarchyMapMaker(map);
                g.CreateGraph(structureBaseUrl,
                    Path.Combine(GraphicsDir, "IntroGraphic.svg"));
            }
            {
                FocusMapMaker g = new FocusMapMaker(map, GraphicsDir, PageContentDir);
                g.Create();
            }
        }
    }
}
