using Hl7.Fhir.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    internal static class StructureDefinitionExtensions
    {
        public static StructureDefinition AddExtensionLink(this StructureDefinition sd, 
            String url,
            SDefEditor.Cardinality cardinalityLeft,
            String localName,
            String componentRef,
            bool showChildren)
        {
            //dynamic packet = new JObject();
            //packet.LinkType = SVGGlobal.ExtensionType;
            //packet.ShowChildren = showChildren;
            //packet.CardinalityLeft = cardinalityLeft.ToString();
            //packet.ComponentHRef = componentRef;
            //packet.LocalName = localName;
            //packet.LinkTarget = url;
            //sd.AddExtension(Global.ResourceMapLinkUrl, new FhirString(packet.ToString()));

            return sd;
        }

        public static StructureDefinition AddTargetLink(this StructureDefinition sd, 
            String url,
            SDefEditor.Cardinality cardinalityLeft, 
            bool showChildren)
        {
            //dynamic packet = new JObject();
            //packet.LinkType = SVGGlobal.TargetType;
            //packet.ShowChildren = showChildren;
            //packet.CardinalityLeft = cardinalityLeft.ToString();
            //packet.LinkTarget = url;
            //sd.AddExtension(Global.ResourceMapLinkUrl, new FhirString(packet.ToString()));
            return sd;
        }

        public static StructureDefinition AddValueSetLink(this StructureDefinition sd, 
            ValueSet vs, 
            bool showChildren)
        {
            //dynamic packet = new JObject();
            //packet.LinkType = SVGGlobal.ValueSetType;
            //packet.ShowChildren = showChildren;
            //packet.LinkTarget = vs.Url;
            //sd.AddExtension(Global.ResourceMapLinkUrl, new FhirString(packet.ToString()));

            return sd;
        }

        internal static StructureDefinition AddComponentLink(this StructureDefinition sd,
            String url,
            SDefEditor.Cardinality cardinalityLeft,
            SDefEditor.Cardinality cardinalityRight,
            String componentRef,
            String types,
            params String[] targets)
        {
            //dynamic packet = new JObject();
            //packet.LinkType = SVGGlobal.ComponentType;
            //packet.ShowChildren = false;
            //if (cardinalityLeft != null)
            //    packet.CardinalityLeft = cardinalityLeft.ToString();
            //packet.LinkTarget = url;
            //packet.ComponentHRef = componentRef;
            //packet.Types = types;
            //packet.References = new JArray(targets);
            //if (cardinalityRight != null)
            //    packet.CardinalityRight = cardinalityRight.ToString();
            //sd.AddExtension(Global.ResourceMapLinkUrl, new FhirString(packet.ToString()));
            return sd;
        }
    }
}