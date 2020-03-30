using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Create graphic of all resources.
    /// </summary>
    class ResourceMapMaker : MapMaker
    {
        public SvgEditor SvgEditor = new SvgEditor();
        FileCleaner fc;

        public ResourceMapMaker(FileCleaner fc,
            ResourceMap map) : base(map)
        {
            this.fc = fc;
        }

        public void Create(String baseUrl, String outputPath)
        {
            SENodeGroup rootGroup = this.CreateNodes(baseUrl);
            this.SvgEditor.Render(rootGroup, true);
            this.SvgEditor.Save(outputPath);
            this.fc?.Mark(outputPath);
        }


        SENodeGroup CreateNodes(String reportUrl)
        {
            ResourceMap.Node mapNode = this.map.GetNode(reportUrl);
            SENodeGroup rootGroup = new SENodeGroup("root", false);
            SENode rootNode = this.CreateResourceNode(mapNode, this.focusColor, null);
            rootGroup.AppendNode(rootNode);
            this.AddChildren(mapNode, rootGroup);
            return rootGroup;
        }
    }
}