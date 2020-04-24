using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grapher
{
    class NodeInfo
    {
        public String FullName;
        public StructureDefinition SDef;

        public String NodeName;
        public String DisplayName;
        public String CssClass;

        public List<LinkInfo> IncomingConnections = new List<LinkInfo>();
        public List<LinkInfo> OutgoingConnections = new List<LinkInfo>();
    };
}
