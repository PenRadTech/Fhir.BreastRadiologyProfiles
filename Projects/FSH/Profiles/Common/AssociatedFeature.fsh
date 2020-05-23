Profile: AssociatedFeature
Parent: Observation
Title: "Associated Feature"
Description: """
    Associated Feature
    """



  * . ^definition = """
    This resource and referenced child resources contain 
    information about a associated feature observations
     
    The feature observed is defined by the codeable concept in the value[x] field.
    """

  * code 1..1
  * code = ObservationCodesCS#associatedFeaturesObservation

  * hasMember 0..0
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  * device 0..0
  * dataAbsentReason 0..0
  * value[x] 0..0
  * interpretation 0..0
  * referenceRange 0..0
  //$#apply LocationRequiredFragment()

  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"

  * component contains observedCount 0..1
  * component[observedCount] ^short = "Observed Count component. component."
  * component[observedCount] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[observedCount] ^definition = """
  This component slice contains the number of items observed.
  This can be a quantity (i.e. 5), or a range (1 to 5).

  If the lower bound of the range is set but not the upper bound,
  then it means {lower bound} or more.

  If the lower bound of the range is not set but the upper bound is,
  then it means {upper bound} or less.
    """
  * component[observedCount].code 1..1
  * component[observedCount].code ^short = "Observed Count component. component code."
  * component[observedCount].code ^definition = """
    This code identifies the Observed Count component. component.
	"""
  * component[observedCount].code = ObservationComponentSliceCodesCS#obsCount
	
  * component[observedCount].value[x] 1..1
  * component[observedCount].value[x] only Quantity or Range



  * component contains featureType 1..1
  * component[featureType] ^short = "Associated Feature Type component."
  * component[featureType] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[featureType] ^definition = """
This slice contains the required component that 
defines the observed feature. The value of this 
component is a codeable concept chosen from the 
AssociatedFeatureVS valueset.",
    """
  * component[featureType].code 1..1
  * component[featureType].code ^short = "Associated Feature Type component code."
  * component[featureType].code ^definition = """
    This code identifies the Associated Feature Type component.
	"""
  * component[featureType].code = ObservationComponentSliceCodesCS#featureType
  

  * component[featureType].value[x] 1..1
  * component[featureType].value[x] only CodeableConcept
  * component[featureType].value[x] from AssociatedFeatureVS


ValueSet:  AssociatedFeatureVS
Title: "AssociatedFeature ValueSet"
Description:  "AssociatedFeature Value Set"
  * codes from system AssociatedFeatureCS


CodeSystem: AssociatedFeatureCS
Title: "Associated Feature CodeSystem"
Description: "Associated Feature seen during a breast examination."
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