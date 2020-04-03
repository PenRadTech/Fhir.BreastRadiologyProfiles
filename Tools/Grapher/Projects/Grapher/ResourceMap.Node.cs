using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Grapher
{
    partial class ResourceMap
    {
        [DebuggerDisplay("{Name}")]
        public class Node
        {
            public String Name => this.ResourceUrl.LastUriPart();
            public String StructureName { get; }
            public String Title { get; }

            /// <summary>
            /// Url of the resource this represents.
            /// </summary>
            public String ResourceUrl { get; }

            /// <summary>
            /// Links from this resource to an other resource.
            /// </summary>
            public IEnumerable<dynamic> Links => this.links.Values;

            Dictionary<String, dynamic> links = new Dictionary<String, dynamic>();

            public Node(String resourceUrl,
                String title,
                String structureName)
            {
                this.ResourceUrl = resourceUrl;
                this.StructureName = structureName;
                this.Title = title;
            }

            public IEnumerable<dynamic> LinksByLinkType(params String[] linkTypes)
            {
                foreach (String linkType in linkTypes)
                {
                    foreach (dynamic link in this.Links)
                    {
                        String linkTypeval = link.LinkType.ToObject<String>();
                        if (linkTypeval == linkType)
                            yield return link;
                    }
                }
            }

            public void AddLink(dynamic link)
            {
                String linkTarget = (string) link.LinkTarget;

                if (this.links.TryGetValue(linkTarget, out dynamic temp) == true)
                    return;
                this.links.Add(linkTarget, link);
            }
        }
    }
}