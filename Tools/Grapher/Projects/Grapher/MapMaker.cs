using FhirKhit.Tools;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Grapher
{
    class MapMaker
    {
        protected ResourceMap map;
        protected bool showCardinality = true;

        protected Color focusColor = Color.White;
        protected Color fhirColor = Color.LightGray;

        protected Color extensionColor = Color.LightSalmon;
        protected Color valueSetColor = Color.LightGreen;
        protected Color targetColor = Color.LightCyan;
        protected Color componentColor = Color.LightYellow;
        protected Color extensionReferenceColor = Color.LightBlue;

        // these are use to determine if children of a node can be
        // grouped with the children of the last parent node, or if a new group need to be created
        // to group the current children seperately.
        dynamic[] previousChildLinks = new Object[0];

        protected bool DifferentChildren(dynamic[] links1, dynamic[] links2)
        {
            if (links1 == null)
                return true;
            if (links2 == null)
                return true;
            if (links1.Length != links2.Length)
                return true;
            for (Int32 i = 0; i < links1.Length; i++)
            {
                dynamic link1 = links1[i];
                dynamic link2 = links2[i];
                if (link1.LinkType.ToObject<String>() != link2.LinkType.ToObject<String>())
                    return true;
                if (link1.LinkTarget.ToObject<String>() != (String) link2.LinkTarget.ToObject<String>())
                    return true;
            }

            return false;
        }

        String[] linkTypes = new string[] {SVGGlobal.ExtensionType, SVGGlobal.TargetType, SVGGlobal.ComponentType};

        /*
         * Add children. If two adjacent children have same children, then dont create each in a seperate
         * group. Have the two nodes point to the same group of children.
         */
        protected void AddChildren(ResourceMap.Node mapNode,
            SENodeGroup group)
        {
            dynamic[] links = mapNode.LinksByLinkType(this.linkTypes).ToArray();
            this.AddChildren(mapNode, links, group);
        }

        protected SENode CreateResourceNode(ResourceMap.Node mapNode,
            dynamic link,
            bool linkFlag = true)
        {
            return CreateResourceNode(mapNode,
                this.LinkTypeColor(link),
                new String[] {link.CardinalityLeft?.ToString()},
                linkFlag);
        }

        protected SENode CreateResourceNode(ResourceMap.Node mapNode,
            Color color,
            String[] annotations,
            bool linkFlag = true)
        {
            String hRef = null;
            if (linkFlag)
                hRef = this.HRef(mapNode);
            SENode node = new SENode(0, color, annotations, hRef);
            node.AddTextLine(mapNode.Title, hRef);


            return node;
        }

        public bool AlwaysShowChildren = false;
        bool ShowChildren(dynamic link)
        {
            if (this.AlwaysShowChildren == true)
                return true;
            return link.ShowChildren.ToObject<Boolean>();
        }

        protected void DirectLink(SENodeGroup group,
            ResourceMap.Node mapNode,
            dynamic link)
        {
            String linkTargetUrl = link.LinkTarget.ToObject<String>();

            void CreateDirectNode(SENodeGroup g)
            {
                if (this.map.TryGetNode(linkTargetUrl, out ResourceMap.Node linkTargetNode) == true)
                {
                    SENode node = this.CreateResourceNode(linkTargetNode, link);
                    g.AppendNode(node);
                }
            }

            dynamic[] childMapLinks = new Object[0];

            ResourceMap.Node childMapNode = null;

            bool linkToLastGroup = false;
            if (ShowChildren(link))
            {
                if (this.map.TryGetNode(linkTargetUrl, out childMapNode) == true)
                {
                    childMapNode = this.map.GetNode(linkTargetUrl);
                    childMapLinks = childMapNode.LinksByLinkType(this.linkTypes).ToArray();
                    if (childMapLinks.Length > 0)
                        linkToLastGroup = !this.DifferentChildren(this.previousChildLinks, childMapLinks);
                }
            }

            if ((linkToLastGroup) & (group.Children.Count() > 0))
            {
                SENodeGroup groupChild = group.Children.Last();
                CreateDirectNode(groupChild);
            }
            else
            {
                SENodeGroup groupChild = group.AppendChild("", this.showCardinality);
                CreateDirectNode(groupChild);
                if (ShowChildren(link))
                    this.AddChildren(childMapNode,
                        childMapLinks,
                        groupChild);
                this.previousChildLinks = childMapLinks;
            }
        }

        protected void AddChildren(ResourceMap.Node mapNode,
            dynamic[] links,
            SENodeGroup group)
        {
            if (links.Length == 0)
                return;
            foreach (dynamic link in links)
            {
                switch (link.LinkType.ToObject<String>())
                {
                    case SVGGlobal.ComponentType:
                        MakeComponent(link, group);
                        break;

                    default:
                        DirectLink(group, mapNode, link);
                        break;
                }
            }
        }


        public MapMaker(ResourceMap map)
        {
            this.map = map;
        }

        protected String HRef(ResourceMap.Node mapNode)
        {
            if (mapNode.ResourceUrl.StartsWith("http://hl7.org/fhir/StructureDefinition/"))
                return mapNode.ResourceUrl;
            return $"./{mapNode.StructureName}-{mapNode.Name}.html";
        }


        protected Color LinkTypeColor(dynamic link)
        {
            switch (link.LinkType.ToObject<String>())
            {
                case SVGGlobal.ExtensionType: return this.extensionColor;
                case SVGGlobal.ComponentType: return this.componentColor;
                case SVGGlobal.ValueSetType: return this.valueSetColor;
                case SVGGlobal.TargetType: return this.targetColor;
                default: throw new NotImplementedException();
            }
        }

        protected Color ReferenceColor(ResourceMap.Node refNode)
        {
            switch (refNode.StructureName)
            {
                case "StructureDefinition": return this.targetColor;
                case "ValueSet": return this.valueSetColor;
                case "Extension": return this.extensionReferenceColor;
                default: throw new NotImplementedException();
            }
        }

        protected void MakeComponent(dynamic link,
            SENodeGroup group)
        {
            // we never link components to previous child links, not should next item
            // link to this items children. Each component stands alone.
            this.previousChildLinks = new Object[0];
            String linkTargetUrl = link.LinkTarget.ToObject<String>();
            String linkSource = link.LinkSource.ToObject<String>();
            String componentHRef = link.ComponentHRef.ToObject<String>().Replace("{SDName}", linkSource.LastUriPart());

            SENode node = new SENode(0,
                this.componentColor,
                new String[] {link.CardinalityLeft?.ToString(), link.CardinalityRight?.ToString()},
                componentHRef);
            node.AddTextLine(linkTargetUrl, componentHRef);

            String types = link.Types?.ToObject<String>();
            if (String.IsNullOrEmpty(types) == false)
                node.AddTextLine(types, componentHRef);
            SENodeGroup componentGroup = new SENodeGroup(node.AllText(), this.showCardinality);
            group.AppendChild(componentGroup);
            componentGroup.AppendNode(node);

            JArray references = (JArray) link.References;
            if (references != null)
            {
                SENodeGroup refGroup = new SENodeGroup("ref", true);
                componentGroup.AppendChild(refGroup);

                foreach (JValue item in references)
                {
                    String reference = item.ToObject<String>();
                    SENode refNode;
                    //$if (reference.ToLower().StartsWith(Global.BreastRadBaseUrl))
                    if (true)
                    {
                        if (this.map.TryGetNode(reference, out ResourceMap.Node refMapNode) == false)
                            throw new Exception($"Component resource '{reference}' not found!");
                        refNode = this.CreateResourceNode(refMapNode,
                            this.ReferenceColor(refMapNode),
                            new String[0],
                            true);

                        if (ShowChildren(link))
                        {
                            var childMapNode = this.map.GetNode(reference);
                            this.AddChildren(childMapNode, refGroup);
                        }
                    }
                    else
                    {
                        refNode = new SENode(0,
                            this.fhirColor,
                            new String[0],
                            reference);
                        refNode.AddTextLine(reference.LastUriPart(), reference);
                    }

                    refGroup.AppendNode(refNode);
                }
            }
        }
    }
}