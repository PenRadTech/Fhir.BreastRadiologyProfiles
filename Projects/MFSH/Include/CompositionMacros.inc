#macro StartSectionSlicing(Type, Path, Description)
  * section ^slicing.discriminator.type = #Type
  * section ^slicing.discriminator.path = "path"
  * section ^slicing.rules = #open
  * section ^slicing.ordered = false
  * section ^slicing.description = """
Description
  """
#end

#macro DefineSectionSlice(SliceName, Short, Code, Title, Definition)
  * section[SliceName] ^definition = """
Definition
  """
  * section[SliceName] ^short = "Short"
  * section[SliceName].code = Code
  * section[SliceName].title = "Title"
#end

#macro DefineSectionSliceEntry(SliceName, Card, Target, Short, Definition)
  * section[SliceName].entry Card
  * section[SliceName].entry only Target
  * section[SliceName].entry ^short = "Short"
  * section[SliceName].entry ^definition = """
  Definition
  """
#end
