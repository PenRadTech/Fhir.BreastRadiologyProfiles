Alias: LOINC = http://loinc.org 
Alias: SNOMED = http://snomed.info/sct 
Alias: BREASTRADBASEURL = http://hl7.org/fhir/us/breast-radiology
Alias: COMPOSITIONURL = http://hl7.org/fhir/StructureDefinition/Composition
Alias: CLINICALIMPRESSIONURL = http://hl7.org/fhir/StructureDefinition/ClinicalImpression
Alias: DIAGNOSTICREPORTURL = http://hl7.org/fhir/StructureDefinition/DiagnosticReport
Alias: DOMAINRESOURCEURL = http://hl7.org/fhir/StructureDefinition/DomainResource
Alias: EXTENSIONURL = http://hl7.org/fhir/StructureDefinition/Extension
Alias: IMAGINGSTUDYURL = http://hl7.org/fhir/StructureDefinition/ImagingStudy
Alias: MEDICATIONREQUESTURL = http://hl7.org/fhir/StructureDefinition/MedicationRequest
Alias: OBSERVATIONURL = http://hl7.org/fhir/StructureDefinition/Observation
Alias: RESOURCEURL = http://hl7.org/fhir/StructureDefinition/Resource
Alias: RISKASSESSMENTURL = http://hl7.org/fhir/StructureDefinition/RiskAssessment
Alias: SERVICEREQUESTURL = http://hl7.org/fhir/StructureDefinition/ServiceRequest

Alias: CONTACTURL = http://hl7.org/Special/committees/cic

Profile: AssociatedFeature
Parent: Observation
Title: "Associated Feature"
Description: """
    Associated Feature
    """




  * hasMember 0..0
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * dataAbsentReason 0..0
  * value[x] 0..0
  * interpretation 0..0
  * referenceRange 0..0
    //#apply LocationRequiredFragment()

  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"

  * component contains observedCount 0..1
  * component ^short = "Observed Count component."
  * component ^comment = "This is one component of a group of components that are part of the observation."
  * component ^definition = """
    This component slice contains the number of items observed.
	This can be a quantity (i.e. 5), or a range (1 to 5).
	
	If the lower bound of the range is set but not the upper bound,
	then it means {lower bound} or more.
	
	If the lower bound of the range is not set but the upper bound is,
	then it means {upper bound} or less.
	"""


    * . ^definition = """
      This resource and referenced child resources contain 
      information about a associated feature observations
		 
	  The feature observed is defined by the codeable concept in the value[x] field.
	  """
	  
	* code = ObservationCodes#associatedFeaturesObservation

    * component contains featureType 1..1

	* component[featureType] ^short = "Associated Feature Type component."
	* component[featureType] ^comment = "This is one component of a group of components that are part of the observation."
	* component[featureType] ^definition = """
      This slice contains the required component that 
	  define the observed feature. The value of this 
	  component is a codeable concept chosen from the 
	  AssociatedFeatureVS valueset.",
	  """

	* component[featureType].code 1..1
	* component[featureType].code ^short = "Associated Feature Type component code"
	* component[featureType].code ^definition = """
      This code identifies the Associated Feature Type component.
      Its value shall always be the concept 'Component code for 'Feature Type' slice'",
	  """
	* component[featureType].code = ObservationComponentSliceCodes#featureType
	
	* component[featureType].value[x] 1..1
	* component[featureType].value[x] only CodeableConcept
	* component[featureType].value[x] from AssociatedFeatureVS




ValueSet:  AssociatedFeatureVS
Title: "AssociatedFeature ValueSet"
Description:  "AssociatedFeature Value Set"
//+ Codes
  * codes from system AssociatedFeatureCS
//- Codes


CodeSystem: AssociatedFeatureCS
Title: "Associated Feature CodeSystem"
Description: "Associated Feature seen during a breast examination."
//+ Codes
  * #ArchitecturalDistortion "Architectural distortion"
  * #AxillaryAdenopathy "Axillary adenopathy"
  * #BiopsyClip "Biopsy clip"
  * #BrachytherapyTube "Brachytherapy tube"
  * #ChestWallInvasion "Chest wall invasion"
  * #CooperDistorted "Cooper distorted"
  * #CooperThickened "Cooper thickened"
  * #Edema "Edema"
  * #EdemaAdj "Edema adj"
  * #GoldSeed "Gold Seed"
  * #Hematoma "Hematoma"
  * #NippleRetraction "Nipple retraction"
  * #NOChestWallInvasion "NO Chest wall invasion"
  * #PectoralisMuscleInvasion "Pectoralis muscle invasion"
  * #PectoralisMuscleInvolvement "Pectoralis muscle involvement"
  * #PectoralisMuscleTenting "Pectoralis muscle tenting"
  * #PostSurgicalScar "Post surgical scar"
  * #Seroma "Seroma"
  * #SkinInvolvement "Skin involvement"
  * #SkinLesion "Skin lesion"
  * #SkinRetraction "Skin retraction"
  * #SkinThickening "Skin thickening"
  * #SurgicalClip "Surgical clip"
  * #TrabecularThickening "Trabecular thickening"
  * #CalcificationInMass "Calcification in mass"
  * #CalcificationNotOnMammogarm "Calcification Not on mammogarm"
  * #CalcificationOnMammogram "Calcification on mammogram"
  * #Calcifications "Calcifications"
  * #MicroCalcifications "Micro calcifications"
  * #MilkOfCalcium "Milk of calcium"
  * #RimCalcifications "Rim calcifications"
//- Codes