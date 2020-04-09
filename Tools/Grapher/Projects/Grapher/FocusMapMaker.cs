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
using Hl7.Fhir.Specification.Navigation;
using System.Net;
using System.Net.Http;

namespace Grapher
{
    /// <summary>
    /// Create graphic for each resourece showing fragment parents and children..
    /// </summary>
    class FocusMapMaker : MapMaker
    {
        const Int32 TextLen = 16;
        private const String LoincBase = "https://loinc.org";
        private const String Loinc2Base = "http://loinc.org";

        String LoincCodeLink(String loincCode) => $"{LoincBase}/{loincCode}";

        String pageContentDir;
        String graphicsDir;
        private StringBuilder loincLongName;
        private StringBuilder loincTermDescription;
        private String loincCode;

        public FocusMapMaker(ResourceMap map,
            String graphicsDir,
            String pageContentDir) : base(map)
        {
            this.map = map;
            this.pageContentDir = pageContentDir;
            this.graphicsDir = graphicsDir;
        }

        public static String FocusMapName(ResourceMap.Node mapNode) => $"Focus-{mapNode.Name}.svg";

        void CreateIntroDoc(ResourceMap.Node focusNode)
        {
            if (this.map.TryGetResource(focusNode.ResourceUrl, out DomainResource r) == false)
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

        String ResourceAnchor(DomainResource r)
        {
            //String resourceName = r.GetUrl().LastUriPart();
            //return $"{r.TypeName}-{resourceName}.html";
            return null;
        }

        String ElementAnchor(DomainResource r, ElementDefinition e)
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

            if (this.map.TryGetResource(focusNode.ResourceUrl, out DomainResource r) == false)
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
                    if (this.map.TryGetNode(parentUrl, out ResourceMap.Node parentMapNode) == false)
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

            void AddChildren(IEnumerable<String> children)
            {
                foreach (String childUrl in children)
                {
                    if (this.map.TryGetNode(childUrl, out var childNode) == false)
                        throw new Exception($"Error finding mapped node {childUrl}");
                    SENode node = this.CreateResourceNode(childNode,
                        this.SplitTitle(childNode.Title, FocusMapMaker.TextLen),
                        Color.LightCyan,
                        null,
                        true);
                    childrenGroup.AppendNode(node);
                }
            }

            // Requires nget package HTMLAgilityPack 
            //void ProcessLoincCode(ElementDefinition e,
            //    CodeableConcept codeableConcept)
            //{
            //    this.loincCode = codeableConcept.Coding[0].Code;
            //    if (codeableConcept.Coding[0].System != "http://loinc.org")
            //        throw new Exception("Expecting loinc code");
            //    String htmlData = GetLoincData(codeableConcept.Coding[0].Code);
            //    var doc = new HtmlDocument();
            //    doc.LoadHtml(htmlData);

            //    void ParseLoinc()
            //    {
            //        this.loincLongName = new StringBuilder();
            //        this.loincTermDescription = new StringBuilder();
            //        HtmlNode node = doc.DocumentNode.SelectSingleNode("//h1[@data-label=\"LOINC Code\"]").ParentNode;
            //        if (node == null)
            //            throw new Exception($"Cant find 'LOINC Code' node");
            //        Int32 i = 0;
            //        StringBuilder c = null;
            //        while (i < node.ChildNodes.Count())
            //        {
            //            HtmlNode child = node.ChildNodes[i++];
            //            switch (child.Name)
            //            {
            //                case "div":
            //                case "h1":
            //                case "h2":
            //                    c = null;
            //                    break;

            //                case "h3":
            //                    c = null;
            //                    if (child.ChildNodes.Count == 1)
            //                    {
            //                        switch (child.ChildNodes[0].InnerText)
            //                        {
            //                            case "Long Common Name":
            //                                c = this.loincLongName;
            //                                break;
            //                            case "Term Description":
            //                                c = this.loincTermDescription;
            //                                break;
            //                        }
            //                    }
            //                    break;

            //                default:
            //                    if (c != null)
            //                        c.AppendLine(child.OuterHtml);
            //                    break;
            //            }
            //        }
            //    }

            //    ParseLoinc();
            //}

            //String GetLoincData(String loincCode)
            //{
            //    string url = @"https://loinc.org/94562-6/";

            //    try
            //    {
            //        using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            //        {
            //            client.BaseAddress = new Uri(url);
            //            HttpResponseMessage response = client.GetAsync(url).Result;
            //            string result = response.Content.ReadAsStringAsync().Result;
            //            return result;
            //        }
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception);
            //        throw;
            //    }
            //}

            void AddDiffChildren()
            {
                foreach (ElementDefinition diff in focusSDef.Differential.Element)
                {
                    String hRef = this.ElementAnchor(focusSDef, diff);

                    SENode node = new SENode(0, Color.Cornsilk, null, hRef);
                    SENodeGroup childGroup = new SENodeGroup("child", true);
                    childGroup.AppendNode(node);
                    childrenGroup.AppendChild(childGroup);

                    String type = diff.Path.LastPathPart();
                    if (type.StartsWith("value"))
                        type = $"Value[{type.Substring(5)}]";
                    else
                        type = type.ToMachineName();

                    //Debug.Assert(type != "HasMember");
                    node.AddTextLine(type, hRef);
                    if (diff.Binding != null)
                    {
                        node.OutgoingAnnotation = "bind";
                        String vsUrl = diff.Binding.ValueSet;
                        if (this.map.TryGetResource(vsUrl, out var resource))
                        {
                            String hRefVs = this.ResourceAnchor(resource);
                            SENodeGroup vsGroup = new SENodeGroup("vs", true);
                            childGroup.AppendChild(vsGroup);
                            SENode vsNode = new SENode(0, Color.LightGreen, null, hRefVs);
                            String vsName = vsUrl.LastUriPart();
                            if (this.map.TryGetResource(vsUrl, out DomainResource vsResource) == true)
                            {
                                ValueSet vs = (ValueSet) vsResource;
                                vsName = vs.Name;
                            }
                            vsNode.AddTextLine(vsName, hRefVs);
                            vsGroup.AppendNode(vsNode);
                        }
                    }

                    void AddIfNotNull(String value)
                    {
                        if (value != null)
                            node.AddTextLine(value, hRef);
                    }

                    if (diff.Pattern != null)
                    {
                        Element p = diff.Pattern;
                        switch (p)
                        {
                            case CodeableConcept codeableConcept:
                                //if (diff.Path == "Observation.code")
                                //    ProcessLoincCode(diff, codeableConcept);
                                AddIfNotNull(codeableConcept.Coding[0].Code);
                                AddIfNotNull(codeableConcept.Coding[0].System);
                                if (
                                    (codeableConcept.Coding[0].System == FocusMapMaker.LoincBase) ||
                                    (codeableConcept.Coding[0].System == FocusMapMaker.Loinc2Base)
                                    )
                                {
                                    node.OutgoingAnnotation = "bind";
                                    String hRefVs = LoincCodeLink(codeableConcept.Coding[0].Code);
                                    SENodeGroup vsGroup = new SENodeGroup("vs", true);
                                    childGroup.AppendChild(vsGroup);
                                    SENode vsNode = new SENode(0, Color.LightGreen, null, hRefVs);
                                    vsNode.AddTextLine(codeableConcept.Coding[0].Code, hRefVs);
                                    vsNode.AddTextLine(codeableConcept.Coding[0].System, hRefVs);
                                    vsGroup.AppendNode(vsNode);
                                }
                                break;

                            case Quantity quantity:
                                AddIfNotNull(quantity.Code);
                                AddIfNotNull(quantity.System);
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            IEnumerable<String> children = this.map.Children(focusNode.ResourceUrl);
            if (children.Any())
                AddChildren(children);
            else
                AddDiffChildren();

            e.Render(parentsGroup, true);
            String outputPath = Path.Combine(this.graphicsDir, FocusMapName(focusNode));
            e.Save(outputPath);
            return true;
        }

        public void Create()
        {
            foreach (ResourceMap.Node focusNode in this.map.Nodes)
            {
                if (this.GraphNode(focusNode) == true)
                    this.CreateIntroDoc(focusNode);
            }
        }
    }
}