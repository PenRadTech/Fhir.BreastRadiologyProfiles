using System;
using System.IO;
using Hl7.Fhir.Model;
using Markdig;
using Markdig.Extensions.Tables;

namespace Grapher
{
    class Program
    {
        static void CovertIndexMd()
        {
            //String inputMd = File.ReadAllText(@"C:\Development\covid-19\fsh\ig-data\input\pagecontent\index.md");
            //var pipeline = new Markdig.MarkdownPipelineBuilder()
            //    .UseAdvancedExtensions()
            //    .Build();
            //String outputHtml = Markdig.Markdown.ToHtml(inputMd, pipeline);
            //File.WriteAllText(@"C:\Development\covid-19\fsh\ig-data\input\pagecontent\index.txt",
            //    outputHtml);
        }

        static void Main(string[] args)
        {
            const String BaseDir = @"C:\Development\covid-19\input";
            const String PageContentDir = BaseDir + @"\pagecontent";
            const String GraphicsDir = BaseDir + @"\images";
            const String ResourceDir = BaseDir + @"\profiles";
            const String VocabDir = BaseDir + @"\vocabulary";
            const String structureBaseUrl =
                "http://fhir.logicahealth.org/covid19/StructureDefinition/c19-laboratory-observation-base";

            CovertIndexMd();
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
