//
// Make a graph node that refers to a profile.
//
#macro GraphNodeProfile(DisplayName) > "%GraphDir%\\%BasePath%.nodeGraph"
  `  {
  `    "graphNode" : {
  `      "nodeName" : "%Profile%/",
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
#macro GraphNodeElement(%Path%, DisplayName) > "%GraphDir%\\%BasePath%.nodeGraph"
  `  {
  `    "graphNode" : {
  `      "nodeName" : "%Profile%/%Path%/",
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

#macro GraphLinkByName(TraversalName, SourceName, TargetName, Depth) > "%GraphDir%\\%BasePath%.nodeGraph"
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "TraversalName",
  `      "source" : "SourceName",
  `      "target" : "TargetName",
  `      "depth": Depth
  `    }
  `  },
#end

#macro GraphLinkByBinding(TraversalName, SourceName, Item) > "%GraphDir%\\%BasePath%.nodeGraph"
  `  {
  `    "graphLinkByBinding" : {
  `      "traversalName" : "TraversalName",
  `      "source" : "SourceName",
  `      "item" : "Item",
  `    }
  `  },
#end

#macro GraphLinkByReference(TraversalName, SourceName, Item, Depth) > "%GraphDir%\\%BasePath%.nodeGraph"
  `  {
  `    "graphLinkByReference" : {
  `      "traversalName" : "TraversalName",
  `      "source" : "SourceName",
  `      "item" : "Item",
  `      "depth": Depth
  `    }
  `  },
#end
