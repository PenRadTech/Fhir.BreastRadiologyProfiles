Profile: AbnormalityCalcification
Parent: Observation
Title: "Mammography Calcification"
Description: """
    Mammography Calcification
    """
  * code = ObservationCodesCS#abnormalityCalcificationObservation
  
  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains calcificationType 1..1
  * component[calcificationType] ^short = "Calcification Type component."
  * component[calcificationType] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[calcificationType] ^definition = """
    This slice contains the optional component that refines the calcification type.
    The value of this component is a codeable concept chosen from the CalcificationTypeVS valueset.
    """
  * component[calcificationType].code 1..1
  * component[calcificationType].code ^short = "Calcification Type component code."
  * component[calcificationType].code ^definition = """
    This code identifies the Calcification Type component.
	"""
  * component[calcificationType].code = ObservationComponentSliceCodesCS#calcificationType

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[calcificationType].value[x] 1..1
  * component[calcificationType].value[x] only CodeableConcept
  * component[calcificationType].value[x] from CalcificationTypeVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * category ^slicing.discriminator.type = #pattern
  * category ^slicing.discriminator.path = "$this"
  * category ^slicing.rules = #open
  * category ^slicing.ordered = false
  * category ^slicing.description = "Observation Category = imaging"
  * category contains categoryImaging 1..1
  * category[categoryImaging] = http://terminology.hl7.org/CodeSystem/observation-category#imaging
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
  * bodySite 1..1
  * bodySite.extension contains BreastBodyLocationExtension named breastBodyLocation 1..1
  * bodySite.extension[breastBodyLocation] ^short = "breastBodyLocation extension."
  * bodySite.extension[breastBodyLocation] ^definition = "This extension slice contains the breastBodyLocation extension."

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component contains obsChanges 0..*
  * component[obsChanges] ^short = "Observed Change In Abnormality component."
  * component[obsChanges] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsChanges] ^definition = """
    This slice contains the optional components that define observed changes in this abnormality.
    The value of this component is a codeable concept chosen from the ObservedChangesVS valueset.
    """
  * component[obsChanges].code 1..1
  * component[obsChanges].code ^short = "Observed Change In Abnormality component code."
  * component[obsChanges].code ^definition = """
    This code identifies the Observed Change In Abnormality component.
	"""
  * component[obsChanges].code = ObservationComponentSliceCodesCS#obsChanges

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[obsChanges].value[x] 1..1
  * component[obsChanges].value[x] only CodeableConcept
  * component[obsChanges].value[x] from ObservedChangesVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  * component contains biRadsAssessmentCategory 0..1
  * component[biRadsAssessmentCategory] ^short = "BiRads Assessment Category component. component."
  * component[biRadsAssessmentCategory] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[biRadsAssessmentCategory] ^definition = """
    This slice contains the optional component that define the BiRAD risk code.
    The value of this component is a codeable concept chosen from the BiRadsAssessmentCategoriesVS valueset.
    """
  * component[biRadsAssessmentCategory].code 1..1
  * component[biRadsAssessmentCategory].code ^short = "BiRads Assessment Category component. component code."
  * component[biRadsAssessmentCategory].code ^definition = """
    This code identifies the BiRads Assessment Category component. component.
	"""
  * component[biRadsAssessmentCategory].code = ObservationComponentSliceCodesCS#targetBiRads

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[biRadsAssessmentCategory].value[x] 1..1
  * component[biRadsAssessmentCategory].value[x] only CodeableConcept
  * component[biRadsAssessmentCategory].value[x] from BiRadsAssessmentCategoryVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------


  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  * component contains notPreviouslySeen 0..*
  * component[notPreviouslySeen] ^short = "Not Previously Seen component."
  * component[notPreviouslySeen] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[notPreviouslySeen] ^definition = """
    This slice contains the optional components that define prevous encounters in which this abnormality was not seen.
    The value of this component is a codeable concept chosen from the NotPreviouslySeenVS valueset.
    """
  * component[notPreviouslySeen].code 1..1
  * component[notPreviouslySeen].code ^short = "Not Previously Seen component code."
  * component[notPreviouslySeen].code ^definition = """
    This code identifies the Not Previously Seen component.
	"""
  * component[notPreviouslySeen].code = ObservationComponentSliceCodesCS#notPreviouslySeen

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[notPreviouslySeen].value[x] 1..1
  * component[notPreviouslySeen].value[x] only CodeableConcept
  * component[notPreviouslySeen].value[x] from NotPreviouslySeenVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
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

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[observedCount].value[x] 1..1
  * component[observedCount].value[x] only Quantity or Range

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  // Define distribution region size.
  * component contains obsSize 0..3
  * component[obsSize] ^short = "Observed size. component."
  * component[obsSize] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsSize] ^definition = """
      This component slice contains the size of an item observed.
    There may be one, two, or three values indicating a size of
    one dimension (length), two dimensions (area), or three dimensions (volume).
    
    Each dimension can be a quantity (i.e. 5), or a range (1 to 5).
    
    If the lower bound of the range is set but not the upper bound, 
    then the size is {lower bound} or greater.
    
    If the upper bound of the range is set but not the lower bound,
    then the size is {upper bound} or less.
    """
  * component[obsSize].code 1..1
  * component[obsSize].code ^short = "Observed size. component code."
  * component[obsSize].code ^definition = """
    This code identifies the Observed size. component.
	"""
  * component[obsSize].code = ObservationComponentSliceCodesCS#obsSize

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.component[obsSize].value[x] 1..1
  * Observation.component[obsSize].value[x] only Quantity or Range
  * Observation.component[obsSize].valueQuantity from UNITSOFLENGTH
  * Observation.component[obsSize].valueRange.low from UNITSOFLENGTH
  * Observation.component[obsSize].valueRange.high from UNITSOFLENGTH

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  // define calcification distribution slice
  * component contains obsDistribution 0..*
  * component[obsDistribution] ^short = "Observed distribution of abnormalities component."
  * component[obsDistribution] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsDistribution] ^definition = """
    This slice contains the optional components that describe the distribution of
    a group of abnormalities.
    The value of this component is a codeable concept chosen from the 
    CalcificationDistributionVS valueset.
    """
  * component[obsDistribution].code 1..1
  * component[obsDistribution].code ^short = "Observed distribution of abnormalities component code."
  * component[obsDistribution].code ^definition = """
    This code identifies the Observed distribution of abnormalities component.
	"""
  * component[obsDistribution].code = ObservationComponentSliceCodesCS#obsDistribution

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[obsDistribution].value[x] 1..1
  * component[obsDistribution].value[x] only CodeableConcept
  * component[obsDistribution].value[x] from CalcificationDistributionVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  // Define distribution region size.
  * component contains obsDistRegionSize 0..1
  * component[obsDistRegionSize] ^short = "Observed size of distribution region. component."
  * component[obsDistRegionSize] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[obsDistRegionSize] ^definition = """
    This component slice contains the size of an region inside of which there 
    is a distribution of abnormalities. This is not the size of one specific distinct abnormality, but is the size of
    the region in which a one or more abnormalities are found.
    
    There may be one, two, or three values indicating a size of
    one dimension (length), two dimensions (area), or three dimensions (volume).
    
    Each dimension can be a quantity (i.e. 5), or a range (1 to 5).
    
    If the lower bound of the range is set but not the upper bound, 
    then the size is {lower bound} or greater.
    
    If the upper bound of the range is set but not the lower bound, 
    
    then the size is {upper bound} or less.
    """
  * component[obsDistRegionSize].code 1..1
  * component[obsDistRegionSize].code ^short = "Observed size of distribution region. component code."
  * component[obsDistRegionSize].code ^definition = """
    This code identifies the Observed size of distribution region. component.
	"""
  * component[obsDistRegionSize].code = ObservationComponentSliceCodesCS#obsDistRegionSize

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  * component[obsDistRegionSize].value[x] 1..1
  * component[obsDistRegionSize].value[x] only Quantity or Range
  * component[obsDistRegionSize].valueQuantity from UNITSOFLENGTH
  * component[obsDistRegionSize].valueRange.low from UNITSOFLENGTH
  * component[obsDistRegionSize].valueRange.high from UNITSOFLENGTH

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  
  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  * component contains correspondsWith 0..*
  * component[correspondsWith] ^short = "Abnormality Corresponds With component."
  * component[correspondsWith] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[correspondsWith] ^definition = """
    This slice contains the optional components that define what this observation corresponds with.
    The value of this component is a codeable concept chosen from the CorrespondsWithVS valueset.
    """
  * component[correspondsWith].code 1..1
  * component[correspondsWith].code ^short = "Abnormality Corresponds With component code."
  * component[correspondsWith].code ^definition = """
    This code identifies the Abnormality Corresponds With component.
	"""
  * component[correspondsWith].code = ObservationComponentSliceCodesCS#correspondsWith

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[correspondsWith].value[x] 1..1
  * component[correspondsWith].value[x] only CodeableConcept
  * component[correspondsWith].value[x] from CorrespondsWithVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------


  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  * component contains prevDemBy 0..*
  * component[prevDemBy] ^short = "Previously Demonstrated by component."
  * component[prevDemBy] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[prevDemBy] ^definition = """
    This slice contains the optional components that specifies what this observation 
    has been previously demonstrated by.
    The value of this component is a codeable concept chosen from the 
    PreviouslyDemonstratedByVS valueset.  
    """
  * component[prevDemBy].code 1..1
  * component[prevDemBy].code ^short = "Previously Demonstrated by component code."
  * component[prevDemBy].code ^definition = """
    This code identifies the Previously Demonstrated by component.
	"""
  * component[prevDemBy].code = ObservationComponentSliceCodesCS#prevDemBy

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * component[prevDemBy].value[x] 1..1
  * component[prevDemBy].value[x] only CodeableConcept
  * component[prevDemBy].value[x] from PreviouslyDemonstratedByVS

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  * Observation.hasMember contains associatedFeature 0..*
  * Observation.hasMember[associatedFeature] ^short = "'Associated Feature' reference. hasMember."
  * Observation.hasMember[associatedFeature] only Reference(AssociatedFeature)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------
  
  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------
  * Observation.hasMember contains consistentWith 0..*
  * Observation.hasMember[consistentWith] ^short = "'Consistent With' reference. hasMember."
  * Observation.hasMember[consistentWith] only Reference(ConsistentWith)

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------

  // -----------------------------------------
  // IG Macros
  // -----------------------------------------





  // -----------------------------------------
  // IG Macros
  // -----------------------------------------

  // -----------------------------------------
  // Graph Macros
  // -----------------------------------------