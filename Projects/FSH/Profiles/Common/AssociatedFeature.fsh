Profile: AssociatedFeature
Parent: Observation
Title: "Associated Feature"
Description: """
  Associated Feature
  """

  `  {
  `    "member" : {
  `      "groupingId" : "CommonResources/AssociatedFeature",
  `      "sort": "",
  `      "reference" : "StructureDefinition/AssociatedFeature"
  `    }
  `  },

  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   <p>
<b>Associated Feature Observation</b>
</p>
<p>
This resource and referenced child resources contain 
information about a associated feature observations
</p>
<p>
The feature observed is defined by the codeable concept in the value[x] field.
</p>
  `   <p>
  `     <u style="font-size:large;">Graphical Overview</u>
  `   </p>
  `   <p>
  `     This graph provides an overview of this profile, and its dependencies.
  `   </p>
  `   <p>
  `     Click on any of the elements of the graph to go to a section describing that element.
  `   </p>
  `   <object data="FocusGraph-AssociatedFeature.svg" type="image/svg+xml">
  `     <img src="FocusGraph-AssociatedFeature.svg" alt="image/svg+xml" />
  `   </object>
  ` </div>

  * . ^definition = """
    This resource and referenced child resources contain 
    information about a associated feature observations
     
  The feature observed is defined by the codeable concept in the value[x] field.
  """

  `  {
  `    "graphNode" : {
  `      "nodeName" : "AssociatedFeature/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%"
  `      },
  `      "displayName" : "AssociatedFeature",
  `      "cssClass" : "profile"
  `    }
  `  },
  `  {
  `    "graphLinkByName" : {
  `      "traversalName" : "focus",
  `      "source" : "^AssociatedFeature/$",
  `      "target" : "^AssociatedFeature/",
  `      "depth": 0
  `    }
  `  },

  * code 1..1
  * code = ObservationCodes#associatedFeaturesObservation

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
  `  {
  `    "graphNode" : {
  `      "nodeName" : "AssociatedFeature/component:observedCount/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "component:observedCount"
  `      },
  `      "displayName" : "Observed Count/Component",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^AssociatedFeature.component:observedCount"
  `    }
  `  },

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
  * component[observedCount].code = ObservationComponentSliceCodes#obsCount
	
  * component[observedCount].value[x] 1..1
  * component[observedCount].value[x] only Quantity or Range


  `  {
  `    "graphNode" : {
  `      "nodeName" : "AssociatedFeature/component:featureType/",
  `      "anchor" : {
  `        "url" : "%ProfileUrl%",
  `        "item" : "component:featureType"
  `      },
  `      "displayName" : "Feature Type/Component",
  `      "cssClass" : "element",
  `      "lhsAnnotationText": "^AssociatedFeature.component:featureType"
  `    }
  `  },

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
  * component[featureType].code = ObservationComponentSliceCodes#featureType
  
  `  {
  `    "graphLinkByBinding" : {
  `      "traversalName" : "focus",
  `      "source" : "^AssociatedFeature/component:featureType/$",
  `      "item" : ".value[x]",
  `    }
  `  },

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