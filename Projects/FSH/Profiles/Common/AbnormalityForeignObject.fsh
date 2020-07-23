Profile: AbnormalityForeignObject
Parent: Observation
Title: "Foreign Object"
Description: """
  Foreign Object
  """



  * code 1..1
  * code = ObservationCodesCS#abnormalityForeignObjectObservation



  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
  * component contains abnormalityForeignObjectType 1..1
  * component[abnormalityForeignObjectType] ^short = "Foreign Object Type component."
  * component[abnormalityForeignObjectType] ^comment = """
    This is one component of a group of components that are part of the observation.
    """
  * component[abnormalityForeignObjectType] ^definition = """
    This slice contains the optional component that refine the foreign object type.
    The value of this component is a codeable concept chosen from the AbnormalityForeignObjectTypeVS valueset.
    """
  * component[abnormalityForeignObjectType].code 1..1
  * component[abnormalityForeignObjectType].code ^short = "Foreign Object Type component code."
  * component[abnormalityForeignObjectType].code ^definition = """
    This code identifies the Foreign Object Type component.
	"""
  * component[abnormalityForeignObjectType].code = ObservationComponentSliceCodesCS#abnormalityForeignObjectType


  * component[abnormalityForeignObjectType].value[x] 1..1
  * component[abnormalityForeignObjectType].value[x] only CodeableConcept
  * component[abnormalityForeignObjectType].value[x] from AbnormalityForeignObjectTypeVS

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


  * component[obsChanges].value[x] 1..1
  * component[obsChanges].value[x] only CodeableConcept
  * component[obsChanges].value[x] from ObservedChangesVS


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
	

  * component[biRadsAssessmentCategory].value[x] 1..1
  * component[biRadsAssessmentCategory].value[x] only CodeableConcept
  * component[biRadsAssessmentCategory].value[x] from BiRadsAssessmentCategoryVS


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


  * component[notPreviouslySeen].value[x] 1..1
  * component[notPreviouslySeen].value[x] only CodeableConcept
  * component[notPreviouslySeen].value[x] from NotPreviouslySeenVS


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
 

  * component[correspondsWith].value[x] 1..1
  * component[correspondsWith].value[x] only CodeableConcept
  * component[correspondsWith].value[x] from CorrespondsWithVS
 


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


  * component[prevDemBy].value[x] 1..1
  * component[prevDemBy].value[x] only CodeableConcept
  * component[prevDemBy].value[x] from PreviouslyDemonstratedByVS




  * hasMember ^slicing.discriminator.type = #value
  * hasMember ^slicing.discriminator.path = "url"
  * hasMember ^slicing.rules = #open
  * hasMember ^slicing.ordered = false
  * hasMember ^slicing.description = "Component slicing"
  * hasMember contains associatedFeature 0..*
  * hasMember[associatedFeature] ^short = "'Associated Feature' reference. hasMember."
  * hasMember[associatedFeature] only Reference(AssociatedFeature)


  * hasMember contains consistentWith 0..*
  * hasMember[consistentWith] ^short = "'Consistent With' reference. hasMember."
  * hasMember[consistentWith] only Reference(ConsistentWith)