#macro GraphNode(GraphName, NodeName, %Path%, DisplayName, CssClass)
   * %Path%extension contains GraphNode named NodeName 1..1
   * %Path%extension[NodeName].extension[graphName].valueString = "GraphName"
   * %Path%extension[NodeName].extension[nodeName].valueString = "NodeName"
   * %Path%extension[NodeName].extension[displayName].valueString = "DisplayName"
   * %Path%extension[NodeName].extension[cssClass].valueString = "CssClass"
  // * section[reportSection].extension[nodeSection].extension[display].valueString = "%displayName%"
  // * section[reportSection].extension[nodeSection].extension[group].valueString = "%group%"
  // * section[reportSection].extension[nodeSection].extension[targets].valueString = "%target%"
  // * section[reportSection].extension[nodeSection].extension[lhsText].valueString = "%lhs%"
  // * section[reportSection].extension[nodeSection].extension[rhsText].valueString = "%rhs%"
#end

#macro GraphLinkByName(GraphName, LinkName, ParentName, ChildName)
   * extension contains GraphLinkByName named LinkName 1..1
   * extension[LinkName].extension[graphName].valueString = "GraphName"
   * extension[LinkName].extension[parentName].valueString = "ParentName"
   * extension[LinkName].extension[childName].valueString = "ChildName"
#end

#macro ComponentLink(Title, CardLeft, CardRight, ComponentRef, Types, Targets)
    //        e.AddComponentLink("Report",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
#end
