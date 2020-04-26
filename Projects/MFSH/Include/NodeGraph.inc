#macro GraphNode(GraphName, NodeName, %Path%, DisplayName, CssClass) > jsonArray("%GraphDir%\\%BasePath%.json")
  {
    "graphNode" : {
	  "graphName" : "GraphName",
	  "nodeName" : "%CurrentClass%/NodeName",
	  "displayName" : "DisplayName",
	  "cssClass" : "CssClass"
	}
  },
#end


#macro GraphLinkByName(GraphName, LinkName, SourceName, TargetName) > jsonArray("%GraphDir%\\%BasePath%.json")
  {
    "graphLinkByName" : {
	  "graphName" : "GraphName",
	  "source" : "ParentName",
	  "target" : "TargetName"
	  }
	}
  },
#end

#macro ComponentLink(Title, CardLeft, CardRight, ComponentRef, Types, Targets)
    //        e.AddComponentLink("Report",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
#end
