#macro GraphNode(GraphName, NodeName, %Path%, DisplayName, CssClass) > jsonArray("%GraphDir%\\%BasePath%.json")
  {
    #json "graphNode" : {
	#json   "graphName" : "GraphName",
	#json   "nodeName" : "NodeName",
	#json   "displayName" : "DisplayName",
	#json   "cssClass" : "CssClass"
	#json },
  },
#end


#macro GraphLinkByName(GraphName, LinkName, SourceName, TargetName) > jsonArray("%GraphDir%\\%BasePath%.json")
  {
    #json "graphLinkByName" : {
	#json   "graphName" : "GraphName",
	#json   "source" : "ParentName",
	#json   "target" : "TargetName"
	#json   },
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
