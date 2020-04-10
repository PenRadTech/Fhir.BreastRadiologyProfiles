using FhirKhit.Tools;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System.Net;
using System.Net.Http;
using Eir.DevTools;

namespace Grapher
{
    /// <summary>
    /// Create graphic for each resourece showing fragment parents and children..
    /// </summary>
    public class FocusMapMaker : MapMaker
    {
        public const Int32 TextLen = 16;
        public const String LoincBase = "https://loinc.org";
        public const String Loinc2Base = "http://loinc.org";

        public static String LoincCodeLink(String loincCode) => $"{LoincBase}/{loincCode}";

        String pageContentDir;
        String graphicsDir;
        private StringBuilder loincLongName;
        private StringBuilder loincTermDescription;
        private String loincCode;

        public FocusMapMaker(ResourceMap map,
            String graphicsDir,
            String pageContentDir) : base(map)
        {
            this.Map = map;
            this.pageContentDir = pageContentDir;
            this.graphicsDir = graphicsDir;
        }

        public static String FocusMapName(ResourceMap.Node mapNode) => $"Focus-{mapNode.Name}.svg";

        void CreateIntroDoc(ResourceMap.Node focusNode)
        {
            if (this.Map.TryGetResource(focusNode.ResourceUrl, out DomainResource r) == false)
                throw new Exception($"Cant find mapped item {focusNode.ResourceUrl}");
            StructureDefinition focusSDef = (StructureDefinition)r;

            String introDocPath = Path.Combine(
                this.pageContentDir,
                $"StructureDefinition-{focusNode.ResourceUrl.LastUriPart()}-intro.xml");
            CodeEditorXml introEditor = new CodeEditorXml();
            introEditor.IgnoreMacrosInQuotedStrings = false;
            introEditor.AddUserMacro("FocusPath", FocusMapName(focusNode));
            introEditor.TryAddUserMacro("Title", focusSDef.Title);
            introEditor.Load("introDoc.template");
            CodeBlockNested b = introEditor.Blocks.Find("LoincData");
            if (b != null)
            {
                if (this.loincLongName?.Length > 0)
                {
                    b.AppendRaw("<u style=\"font-size:large;\">LOINC Code</u>");
                    b.AppendRaw($"<p>{this.loincCode}</p>");
                    {
                        b.AppendRaw("<u style=\"font-size:large;\">LOINC Long Common Name</u>");
                        String[] lines = this.loincLongName.ToString().Replace("\r", "").Split("\n");
                        foreach (String line in lines)
                            if (line.Trim().Length > 0)
                                b.AppendRaw(line);
                    }
                    {
                        b.AppendRaw("<u style=\"font-size:large;\">LOINC Term Description</u>");
                        String[] lines = this.loincTermDescription.ToString().Replace("\r", "").Split("\n");
                        foreach (String line in lines)
                        {
                            if (line.Trim().Length > 0)
                                b.AppendRaw(line);
                        }
                    }
                    b.AppendRaw(
                        $"<p><a href=\"https://loinc.org/{loincCode}\">Courtesy of Regenstrief Institute</a></p>");
                }
            }
            introEditor.Save(introDocPath);
        }

        public static String ResourceAnchor(DomainResource r)
        {
            //String resourceName = r.GetUrl().LastUriPart();
            //return $"{r.TypeName}-{resourceName}.html";
            return null;
        }

        public static String ElementAnchor(DomainResource r, ElementDefinition e)
        {
            return null;
            //String resourceName = r.GetUrl().LastUriPart();
            //return $"{r.TypeName}-{resourceName}-definitions.html#{e.ElementId}";
        }

        bool GraphNode(ResourceMap.Node focusNode)
        {
            SvgEditor e = new SvgEditor();
            SENodeGroup parentsGroup = new SENodeGroup("parents", true);
            SENodeGroup focusGroup = new SENodeGroup("focus", true);
            SENodeGroup childrenGroup = new SENodeGroup("children", true);
            parentsGroup.AppendChild(focusGroup);
            focusGroup.AppendChild(childrenGroup);

            if (this.Map.TryGetResource(focusNode.ResourceUrl, out DomainResource r) == false)
                throw new Exception($"Cant find mapped item {focusNode.ResourceUrl}");
            StructureDefinition focusSDef = r as StructureDefinition;
            if (focusSDef == null)
                return false;

            {
                String parentUrl = focusSDef.BaseDefinition;
                if (parentUrl.StartsWith("http://hl7.org/fhir/us/core/StructureDefinition"))
                {
                    //var parentNode = this.CreateResourceNode(parentMapNode, Color.LightCyan, null, true);
                    //parentsGroup.AppendNode(parentNode);
                }
                else
                {
                    if (this.Map.TryGetNode(parentUrl, out ResourceMap.Node parentMapNode) == false)
                        throw new Exception($"Cant find mapped item {parentUrl}");
                    StructureDefinition parentSDef = (StructureDefinition)r;
                    var parentNode = this.CreateResourceNode(parentMapNode,
                        this.SplitTitle(parentMapNode.Title, TextLen),
                        Color.LightCyan,
                        null,
                        true);
                    parentsGroup.AppendNode(parentNode);
                }
            }
            {
                SENode node = this.CreateResourceNode(focusNode,
                    this.SplitTitle(focusNode.Title, FocusMapMaker.TextLen),
                    Color.White,
                    null,
                    false);
                focusGroup.AppendNode(node);
            }

            IEnumerable<String> children = this.Map.Children(focusNode.ResourceUrl);
            if (children.Any())
            {
                FocusMapChildren fm = new FocusMapChildren(this, childrenGroup);
                fm.AddChildren(children);
            }
            else
            {
                FocusMapDiffNode fm = new FocusMapDiffNode(this, childrenGroup);
                fm.AddDiffChildren(focusSDef);
            }


            e.Render(parentsGroup, true);
            String outputPath = Path.Combine(this.graphicsDir, FocusMapName(focusNode));
            e.Save(outputPath);
            return true;
        }

        public void Create()
        {
            foreach (ResourceMap.Node focusNode in this.Map.Nodes)
            {
                if (this.GraphNode(focusNode) == true)
                    this.CreateIntroDoc(focusNode);
            }
        }
    }
}