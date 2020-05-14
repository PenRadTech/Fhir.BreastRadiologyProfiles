//
// Make a graph node that refers to a profile.
//
#macro IGGroup(%Id%, %Name%, %Description%) > "%GraphDir%\\IGFile.cmds"
  `  {
  `    "group" : {
  `      "id" : "%Id%",
  `      "name" : "%Name%",
  `      "description" : "%Description%"
  `    }
  `  },
#end

#macro IGGroupMemberProfile(%Id%, %Sort%) > "%GraphDir%\\IGFile.cmds"
  `  {
  `    "member" : {
  `      "groupingId" : "%Id%",
  `      "sort": "%Sort%",
  `      "reference" : "StructureDefinition/%Profile%"
  `    }
  `  },
#end
