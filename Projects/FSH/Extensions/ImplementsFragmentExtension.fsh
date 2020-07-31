/*
  Extension that defined Breast Body Location
*/
Extension: ImplementsFragmentExtension
Parent: Extension
Title: "Implements Fragment Extension"
Description: """
    Implements FragmentExtension
    """
  * extension contains ImplementsFragment 0..*
  * extension[ImplementsFragment] ^short = "Short"
  * extension[ImplementsFragment] ^definition =
    """
	Definition
	"""
  * extension[ImplementsFragment].value[x] 1..1
  * extension[ImplementsFragment].value[x] only url