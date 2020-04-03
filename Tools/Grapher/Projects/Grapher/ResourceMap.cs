using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Grapher
{
    partial class ResourceMap
    {
        Dictionary<String, DomainResource> resources = new Dictionary<string, DomainResource>();

        public IEnumerable<ResourceMap.Node> Nodes => this.nodes.Values;
        Dictionary<String, ResourceMap.Node> nodes = new Dictionary<string, ResourceMap.Node>();

        public ResourceMap()
        {
        }

        public delegate bool VerifyDel(DomainResource r);

        public void AddDir(String path,
            String searchPattern,
            VerifyDel verifyDel = null)
        {
            foreach (String filePath in Directory.GetFiles(path, searchPattern))
                this.AddResource(filePath, verifyDel);

            foreach (String subDir in Directory.GetDirectories(path))
                this.AddDir(subDir, searchPattern, verifyDel);
        }

        public void AddResource(String path,
            VerifyDel verifyDel)
        {
            DomainResource domainResource;
            switch (Path.GetExtension(path).ToUpper(CultureInfo.InvariantCulture))
            {
                case ".XML":
                    {
                        FhirXmlParser parser = new FhirXmlParser();
                        domainResource = parser.Parse<DomainResource>(File.ReadAllText(path));
                        break;
                    }

                case ".JSON":
                    {
                        FhirJsonParser parser = new FhirJsonParser();
                        domainResource = parser.Parse<DomainResource>(File.ReadAllText(path));
                        break;
                    }

                default:
                    throw new Exception($"Unknown extension for serialized fhir resource '{path}'");
            }

            if (verifyDel != null)
            {
                if (verifyDel(domainResource) == false)
                    return;
            }

            ResourceMap.Node node = this.CreateMapNode(domainResource);
            if (node == null)
                return;
            this.nodes.Add(node.ResourceUrl, node);
            this.resources.Add(domainResource.GetUrl(), domainResource);
        }

        public bool TryGetResource(String url, out DomainResource resource)
        {
            return this.resources.TryGetValue(url, out resource);
        }

        public bool TryGetNode(String url, out ResourceMap.Node node)
        {
            if (this.nodes.TryGetValue(url, out node) == true)
                return true;
            if (url.StartsWith("http://hl7.org/fhir/StructureDefinition"))
            {
                StructureDefinition fhirResource = ZipFhirSource.Source.ResolveByUri(url) as StructureDefinition;
                if (fhirResource != null)
                {
                    String name = fhirResource.Url.LastUriPart();
                    node = this.CreateMapNode(fhirResource.Url,
                        name,
                        "StructureDefinition");

                    return true;
                }
            }

            return false;
        }

        public ResourceMap.Node GetNode(String url)
        {
            if (this.TryGetNode(url, out ResourceMap.Node node) == false)
                throw new Exception($"Map node {url} not found");
            return node;
        }

        ResourceMap.Node CreateMapNode(DomainResource r)
        {
            String structureName = r.TypeName;
            String resourceUrl;
            String baseName = null;
            String title;
            switch (r)
            {
                case ValueSet vs:
                    resourceUrl = vs.Url;
                    title = vs.Title;
                    break;

                case StructureDefinition sd:
                    resourceUrl = sd.Url;
                    baseName = sd.BaseDefinition.LastUriPart();
                    title = sd.Title;
                    break;

                default:
                    return null;
            }

            //Extension isFragmentExtension = r.GetExtension(Global.IsFragmentExtensionUrl);

            ResourceMap.Node retVal = this.CreateMapNode(resourceUrl,
                title,
                structureName);

            //$foreach (Extension link in r.GetExtensions(Global.ResourceMapLinkUrl))
            //{
            //    FhirString s = (FhirString)link.Value;

            //    dynamic mapLink = JObject.Parse(s.Value);
            //    mapLink.LinkSource = resourceUrl;
            //    this.links.Add(mapLink);
            //    retVal.AddLink(mapLink);
            //}

            return retVal;
        }


        public ResourceMap.Node CreateMapNode(String url,
            String title,
            String structureName)
        {
            if (this.nodes.TryGetValue(url, out ResourceMap.Node retVal) == true)
                throw new Exception($"Map node {url} already exists");
            retVal = new Node(url, title, structureName);
            return retVal;
        }

        public IEnumerable<String> Children(String baseName)
        {
            foreach (ResourceMap.Node childNode in this.Nodes)
            {
                if (this.TryGetResource(childNode.ResourceUrl,
                        out DomainResource resource) == false)
                    throw new Exception($"Cant find resource {childNode.ResourceUrl}");
                StructureDefinition parentDef = resource as StructureDefinition;
                if (parentDef?.BaseDefinition == baseName)
                    yield return parentDef.Url;
            }
        }
    }
}