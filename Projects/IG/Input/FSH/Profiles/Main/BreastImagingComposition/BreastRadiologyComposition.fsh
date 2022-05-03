Profile: BreastRadiologyComposition
Parent: Composition
Title: "Breast Imaging Composition"
Description: """
    Composition instance for the Breast Imaging FHIR Document.
"""
* ^contact[0].telecom.system = http://hl7.org/fhir/contact-point-system#url
* ^contact[0].telecom.value = "http://hl7.org/Special/committees/cic"
* ^date = "2019-11-01"
* ^status = PUBLICATIONSTATUS#draft
* ^publisher = "Hl7-Clinical Interoperability Council"
* ^version = "0.0.2"
* ^jurisdiction.coding = urn:iso:std:iso:3166#US "United States of America"
* . ^short = "US Core Race Extension"
* type = $LOINC#42132-1 "US Breast screening"
* section ^slicing.discriminator.type = #pattern
* section ^slicing.discriminator.path = "code"
* section ^slicing.rules = #open
* section ^slicing.ordered = false
* section ^slicing.description = "Breast Imaging Report Section"

* section contains findingsBiLateralBreast 0..1 MS
* section contains findingsRightBreast 0..1 MS
* section contains findingsLeftBreast 0..1 MS
* section contains relatedResources 0..1 MS
* section contains recommendations 0..1 MS
* section contains admin 0..1 MS

* section contains report 1..1 MS
* section[report] ^short = "Report Section."
* section[report].code = CompositionSectionSliceCodesCS#report
* section[report].title = "Breast Imaging Report"

* section[report].entry 1..1
* section[report].entry only Reference(BreastRadiologyReport)
* section[report].entry ^short = "Breast Imaging Report reference"
* section[report].entry ^definition = """
    Reference to the Breast Imaging Report.
	"""

* section contains impressions 0..1 MS
* section[impressions] ^definition = """
    This section contains references to the report's clinical impressions.
    """
* section[impressions] ^short = "Clinical Impressions Section."
* section[impressions].code = CompositionSectionSliceCodesCS#report
* section[impressions].title = "Clinical Impressions"


* section[impressions].entry 0..*
* section[impressions].entry only Reference(ClinicalImpression)
* section[impressions].entry ^short = "Clinical Impression reference"
* section[impressions].entry ^definition = """
    Reference to the clinical impression(s).
    """
  //#apply FindingsRightBreastSection("findingsRightBreast")
  //#apply FindingsLeftBreastSection("findingsLeftBreast")
  //#apply FindingsBiLateralBreastSection("findingsBiLateralBreast")
  //#apply RelatedResourcesSection("relatedResources")
  //#apply RecommendationsSection("recommendations")
    //#apply LinkByName("focus", "^BreastRadiologyComposition/$", "^BreastRadiologyComposition/section:impressions", "0", "Bas,Ovr")
    //#apply LinkByReference("focus", "^BreastRadiologyComposition/section:impressions", ".entry", "1", "Bas")
    //#apply LinkByName("focus", "^BreastRadiologyComposition/$", "^BreastRadiologyComposition/section:", "0", "Cmp,Ovr")
    //#apply LinkByReference("focus", "^BreastRadiologyComposition/section:", ".entry", "1", "Cmp,Ovr")