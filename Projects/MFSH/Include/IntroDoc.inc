//
// Write out an intro doc.
// The output of this gets automatically put at the start of the profile
// web page.
//
#macro IntroDocGraph(%Description%) > text("%PageContent%\\StructureDefinition-%Profile%-intro.xml")
  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   %Description%
  `   <p>
  `     <u style="font-size:large;">Graphical Overview</u>
  `   </p>
  `   <p>
  `     This graph provides an overview of this profile, and its dependencies.
  `   </p>
  `   <p>
  `     Click on any of the elements of the graph to go to a section describing that element.
  `   </p>
  `   <object data="FocusGraph-%Profile%.svg" type="image/svg+xml">
  `     <img src="FocusGraph-%Profile%.svg" alt="image/svg+xml" />
  `   </object>
  ` </div>
#end

