using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class IntroDocPatcher : ConverterBase
    {
        ResourceMap map;
        String pageDir;

        public IntroDocPatcher(String pageDir)
        {
            this.pageDir = pageDir;
            this.map = new ResourceMap();
        }

        public void AddResourceDir(String dir)
        {
            this.map.AddDir(dir, "StructureDefinition-*.json");
        }

        public void AddFragDir(String dir)
        {
            this.map.AddDir(dir, "StructureDefinition-*.json",
                (r) =>
                {
                    switch (r)
                    {
                        case StructureDefinition sd:
                            return sd.IsFragment();
                    }

                    return false;
                });
        }

        public void Patch()
        {
            foreach (ResourceMap.Node node in this.map.Nodes)
                this.PatchStructDef(node);
        }

        public void PatchStructDef(ResourceMap.Node node)
        {
            if (this.map.TryGetResource(node.ResourceUrl, out DomainResource resource) == false)
                throw new Exception($"Resource {node.ResourceUrl} not found in map");
            switch (resource)
            {
                case StructureDefinition sd:
                    this.PatchStructDef(sd);
                    break;
            }
        }

        public void PatchStructDef(StructureDefinition sd)
        {
            //const String fcn = "PatchStructDefObservation";

            CodeEditorXml c = new CodeEditorXml();
            c.IgnoreMacrosInQuotedStrings = false;

            ElementTreeLoader l = new ElementTreeLoader(this);
            ElementTreeNode diffNode = null;
            if (sd?.Differential?.Element != null)
                diffNode = l.Create(sd.Differential.Element);

            String[] CollateComponents()
            {
                SortedList<String, String> items = new SortedList<String, String>();
                if (diffNode == null)
                    return items.Values.ToArray();

                if (diffNode.TryGetElementNode("Observation.component", out ElementTreeNode node) == false)
                    return items.Values.ToArray();

                if (node.Slices.Count <= 1)
                    return items.Values.ToArray();

                foreach (ElementTreeSlice slice in node.Slices.Skip(1))
                {
                    String shortDesc =
                        $"{slice.ElementDefinition.Short} [{slice.ElementDefinition.Min}..{slice.ElementDefinition.Max}]";
                    String anchor = Global.ElementAnchor(slice.ElementDefinition).Replace("{SDName}", sd.Name);
                    items.Add(shortDesc, $"<a href=\"{anchor}\">{shortDesc}</a>");
                }

                return items.Values.ToArray();
            }

            String[] CollateFragments()
            {
                SortedList<String, String> items = new SortedList<String, String>();

                foreach (Extension frag in sd.GetExtensions(Global.FragmentUrl))
                {
                    FhirUrl fragmentUrl = (FhirUrl) frag.Value;
                    if (this.map.TryGetNode(fragmentUrl.Value, out ResourceMap.Node fragNode) == false)
                        throw new Exception($"Can not find fragment {frag.Url}");
                    String hRef = $"./{fragNode.StructureName}-{fragNode.Name}.html";
                    items.Add(fragNode.Title, $"<a href=\"{hRef}\">{fragNode.Title}</a>");
                }

                return items.Values.ToArray();
            }

            String[] CollateHasMembers()
            {
                SortedList<String, String> items = new SortedList<String, String>();

                if (diffNode == null)
                    return items.Values.ToArray();

                if (diffNode.TryGetElementNode("Observation.hasMember", out ElementTreeNode node) == false)
                    return items.Values.ToArray();

                if (node.Slices.Count <= 1)
                    return items.Values.ToArray();

                foreach (ElementTreeSlice slice in node.Slices.Skip(1))
                {
                    String shortDesc =
                        $"{slice.ElementDefinition.Short} [{slice.ElementDefinition.Min}..{slice.ElementDefinition.Max}]";
                    String anchor =
                        $"StructureDefinition-{sd.Name}-definitions.html#Observation.hasMember:{slice.ElementDefinition.SliceName}";
                    items.Add(shortDesc, $"<a href=\"{anchor}\">{shortDesc}</a>");
                }

                return items.Values.ToArray();
            }

            String introName = sd.Url.LastUriPart();

            String introPath = Path.Combine(this.pageDir,
                $"StructureDefinition-{introName}-intro.xml");

            // Load and save will expand the macros.
            c.Load(introPath);
            {
                CodeBlockNested componentBlock = c.Blocks.Find("components");
                if (componentBlock != null)
                {
                    String[] componentItems = CollateComponents();
                    if (componentItems.Length > 0)
                    {
                        c.TryAddUserMacro("ComponentList", componentItems);
                        componentBlock.Reload();
                    }
                    else
                        componentBlock.Clear();
                }
            }
            {
                CodeBlockNested hasMemberBlock = c.Blocks.Find("hasMember");
                if (hasMemberBlock != null)
                {
                    String[] hasMembersItems = CollateHasMembers();
                    if (hasMembersItems.Length > 0)
                    {
                        c.TryAddUserMacro("HasMemberList", hasMembersItems);
                        hasMemberBlock.Reload();
                    }
                    else
                        hasMemberBlock.Clear();
                }
            }

            {
                CodeBlockNested fragBlock = c.Blocks.Find("profileFragments");
                if (fragBlock != null)
                {
                    String[] fragments = CollateFragments();
                    if (fragments.Length > 0)
                    {
                        c.TryAddUserMacro("FragmentList", fragments);
                        fragBlock.Reload();
                    }
                    else
                        fragBlock.Clear();
                }
            }

            c.Save();
        }
    }
}