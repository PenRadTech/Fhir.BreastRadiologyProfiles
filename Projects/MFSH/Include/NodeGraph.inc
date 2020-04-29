#macro GraphNode(GraphName, NodeName, %Path%, DisplayName, CssClass) > jsonArray("%GraphDir%\\%BasePath%.nodeGraph")
  `  {
  `    "graphNode" : {
  `      "graphName" : "GraphName",
  `      "nodeName" : "NodeName",
  `      "anchorPath" : "%Profile%%Path%",
  `      "displayName" : "DisplayName",
  `      "cssClass" : "CssClass"
  `    }
  `  },
#end

#macro GraphLinkByName(GraphName, LinkName, SourceName, TargetName) > jsonArray("%GraphDir%\\%BasePath%.nodeGraph")
  `  {
  `    "graphLinkByName" : {
  `      "graphName" : "GraphName",
  `      "source" : "SourceName",
  `      "target" : "TargetName"
  `    }
  `  },
#end

#macro ComponentLink(Title, CardLeft, CardRight, ComponentRef, Types, Targets)
    //        e.AddComponentLink("Report",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
#end
