//
// Make a graph node that refers to a profile.
//
#macro IGGroup(%Id%, %Name%, %Description%) > jsonArray("%GraphDir%\\IGFile.cmds")
  `  {
  `    "group" : {
  `      "id" : "%Id%",
  `      "name" : "%Name%",
  `      "description" : "%Description%"
  `    }
  `  },
#end

#macro IGGroupMemberProfile(%Id%, %Sort%) > jsonArray("%GraphDir%\\IGFile.cmds")
  `  {
  `    "member" : {
  `      "groupingId" : "%Id%",
  `      "sort": "%Sort%",
  `      "reference" : "StructureDefinition/%Profile%"
  `    }
  `  },
#end
