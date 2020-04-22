#macro GraphNode(GraphName, DisplayName, Group, Targets, Lhs, Rhs)
  // * section[reportSection].extension contains GNode named nodeSection 1..1
  // * section[reportSection].extension[nodeSection].extension[graph].valueString = "%graphName%"
  // * section[reportSection].extension[nodeSection].extension[display].valueString = "%displayName%"
  // * section[reportSection].extension[nodeSection].extension[group].valueString = "%group%"
  // * section[reportSection].extension[nodeSection].extension[targets].valueString = "%target%"
  // * section[reportSection].extension[nodeSection].extension[lhsText].valueString = "%lhs%"
  // * section[reportSection].extension[nodeSection].extension[rhsText].valueString = "%rhs%"
#end

#macro ComponentLink(Title, CardLeft, CardRight, ComponentRef, Types, Targets)
    //        e.AddComponentLink("Report",
    //            new SDefEditor.Cardinality(sectionSlice.ElementDefinition),
    //            new SDefEditor.Cardinality(entry),
    //            Global.ElementAnchor(sectionSlice.ElementDefinition),
    //            "Section",
    //            targets);
#end
