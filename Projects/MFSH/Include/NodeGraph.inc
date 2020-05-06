//
// Make a graph node that refers to a profile.
//
#macro GraphNodeProfile(DisplayName) > jsonArray("%GraphDir%\\%BasePath%.nodeGraph")
  `  {
  `    "graphNode" : {
  `      "nodeName" : "%Profile%",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "DisplayName",
  `      "cssClass" : "profile"
  `    }
  `  },
#end

//
// Make a graph node that refers to an element in a profile.
//
#macro GraphNodeElement(%Path%, DisplayName) > jsonArray("%GraphDir%\\%BasePath%.nodeGraph")
  `  {
  `    "graphNode" : {
  `      "nodeName" : "%Profile%/%Path%",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "%Path%"
  `      },
  `      "displayName" : "DisplayName",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^%Profile%.%Path%"
  `    }
  `  },
#end

#macro GraphLinkByName(TraversalName, SourceName, TargetName) > jsonArray("%GraphDir%\\%BasePath%.nodeGraph")
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "TraversalName",
  `      "source" : "SourceName",
  `      "target" : "TargetName",
  `      "depth": 1
  `    }
  `  },
#end

#macro GraphLinkByReference(TraversalName, SourceName, Item) > jsonArray("%GraphDir%\\%BasePath%.nodeGraph")
  `  {
  `    "graphLinkByReference" : {
  `      "traversalName" : "TraversalName",
  `      "source" : "SourceName",
  `      "item" : "Item",
  `      "depth": 1
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
