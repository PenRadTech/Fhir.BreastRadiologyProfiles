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

Profile: ConsistentWith
Parent: Observation
Title: "Consistent With"
Description: """
    Consistent With
    """



	* code 1..1
	* code = ObservationCodes#consistentWithObservation

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

	// Define Consistent With Slice
  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
    * component contains featureType 1..1

	* component[featureType] ^short = "Consistent With component."
	* component[featureType] ^comment = """
      This is one component of a group of components that are part of the observation.
	  """
	* component[featureType] ^definition = """
	   This slice contains the required component that defines what this 
   observation is consistent with.

   The value of this component is a codeable concept chosen from the 
   ConsistentWithVS valueset.
	"""
	
	
	* component[featureType].code 1..1
	* component[featureType].code ^short = "Consistent With component code."
	* component[featureType].code ^definition = """
      This code identifies the Consistent With component.
	  """
	* component[featureType].code = ObservationComponentSliceCodes#consistentWithValue
	

	* component[featureType].value[x] 1..1
	* component[featureType].value[x] only CodeableConcept
	* component[featureType].value[x] from ConsistentWithVS


	// Define Consistent With Qualifier Slice
  * component ^slicing.discriminator.type = #pattern
  * component ^slicing.discriminator.path = "code"
  * component ^slicing.rules = #open
  * component ^slicing.ordered = false
  * component ^slicing.description = "Component slicing"
    * component contains qualifier 0..*

	* component[qualifier] ^short = "Consistent With Qualifier component."
	* component[qualifier] ^comment = """
      This is one component of a group of components that are part of the observation.
	  """
	* component[qualifier] ^definition = """
	   This slice contains the optional components that qualify the 'consistentWith' slice component value.
   The value of this component is a codeable concept chosen from the ConsistentWithQualifierVS valueset.
	"""
	
	
	* component[qualifier].code 1..1
	* component[qualifier].code ^short = "Consistent With Qualifier component code."
	* component[qualifier].code ^definition = """
      This code identifies the Consistent With Qualifier component.
	  """
	* component[qualifier].code = ObservationComponentSliceCodes#consistentWithQualifier
	

	* component[qualifier].value[x] 0..1
	* component[qualifier].value[x] only CodeableConcept
	* component[qualifier].value[x] from ConsistentWithQualifierVS




ValueSet:  ConsistentWithVS
Title: "ConsistentWith ValueSet"
Description:  "ConsistentWith Value Set"
//+ Codes
  * codes from system ConsistentWithCS
//- Codes




CodeSystem:  ConsistentWithCS
Title: "ConsistentWith CodeSystem"
Description:  "ConsistentWith CodeSystem"
//+ Codes
  * #Abscess "Abscess"

  // .Snomed 404057003
  // .SnomedDescription ClinicalFinding | Angiolipoma (Disorder)
  * #Angiolipoma "Angiolipoma"

  // .SnomedDescription ClinicalFinding | 37009001 | Apocrine metaplasia of breast (Disorder) | [0/0] | N60.89
  * #ApocrineMetaplasia "Apocrine metaplasia"

  * #Artifact "Artifact"

  * #AtypicalHyperplasia "Atypical hyperplasia"

  // .SnomedDescription BodyStructure | 245269009 | Axillary lymph node group (Bodypart)
  * #AxillaryLymphNode "Axillary lymph node"

  // .SnomedDescription ClinicalFinding | 254838004 | Carcinoma of breast (Disorder) | [4/33] | C50.929
  * #Carcinoma "Carcinoma"

  // .SnomedDescription ClinicalFinding | 254838004 | Carcinoma of breast (Disorder) | [4/33] | C50.929
  * #CarcinomaKnown "Carcinoma known"

  // .Snomed 399294002
  // .SnomedDescription ClinicalFinding |Cyst of breast (Disorder) ++++++
  * #ClusterOfCysts "Cluster of cysts"

  // .Snomed 399294002
  // .SnomedDescription ClinicalFinding |Cyst of breast (Disorder)
  * #Cyst "Cyst"

  // .Snomed 449837001
  // .SnomedDescription ClinicalFinding | Complex cyst of breast (Disorder)
  * #CystComplex "Cyst complex"

  * #CystComplicated "Cyst complicated"

  * #CystOil "Cyst oil"

  // .Snomed 76649007
  // .SnomedDescription ClinicalFinding | Sebaceous cyst of skin of breast (Disorder)
  * #CystSebaceous "Cyst sebaceous"

  // .Snomed 399253005
  // .SnomedDescription ClinicalFinding | Simple cyst of breast (Disorder)
  * #CystSimple "Cyst simple"

  // .Snomed 449837001
  // .SnomedDescription ClinicalFinding | Complex cyst of breast (Disorder)
  * #CystsComplex "Cysts complex"

  * #CystsComplicated "Cysts complicated"

  * #CystsMicroClustered "Cysts micro clustered"

  // .SnomedDescription BodyStructure | 399935008 | Ductal carcinoma in situ - category (Morphologic-Abnormality)
  * #DCIS "DCIS"

  * #Debris "Debris"

  // .Snomed 39432004
  // .SnomedDescription PharmaceuticalBiologicProduct | Deodorant (Product)
  * #Deodorant "Deodorant"

  * #DermalCalcification "Dermal calcification"

  // .SnomedDescription ClinicalFinding | 22049009 | Mammary duct ectasia (Disorder) | [0/0] | N60.49
  * #DuctEctasia "Duct ectasia"

  // .Snomed 290077003
  // .SnomedDescription ClinicalFinding | Edema of breast (Finding)
  * #Edema "Edema"

  // .SnomedDescription no direct match possible fat necrosis?
  * #FatLobule "Fat lobule"

  // .Snomed 21381006
  // .SnomedDescription ClinicalFinding | Fat necrosis of breast (Disorder)
  * #FatNecrosis "Fat necrosis"

  * #Fibroadenolipoma "Fibroadenolipoma"

  * #Fibroadenoma "Fibroadenoma"

  * #FibroadenomaDegenerating "Fibroadenoma degenerating"

  // .Snomed 367647000
  // .SnomedDescription BodyStructure | Fibrocystic change
  * #FibrocysticChange "Fibrocystic change"

  * #FibroglandularTissue "Fibroglandular tissue"

  // .SnomedDescription ???????????
  * #Fibrosis "Fibrosis"

  * #FibrousRidge "Fibrous ridge"

  // .SnomedDescription ClinicalFinding | 13600006 | Folliculitis (Disorder) | [6/113] | L73.9
  * #Folliculitis "Folliculitis"

  * #Gynecomastia "Gynecomastia"

  // .Snomed 51398009
  // .SnomedDescription BodyStructure | Hamartoma (Morphologic-Abnormality)
  * #Hamartoma "Hamartoma"

  // .Snomed 302924003
  // .SnomedDescription ClinicalFinding | Breast hematoma (Disorder) | N64.89
  * #Hematoma "Hematoma"

  * #HormonalStimulation "Hormonal stimulation"

  * #IntracysticLesion "Intracystic lesion"

  // .SnomedDescription BodyStructure | 443159006 | Intramammary lymph node group (Bodypart)
  * #IntramammaryNode "Intramammary node"

  // .Snomed 276891009
  // .SnomedDescription ClinicalFinding | Lipoma of breast (Disorder)
  * #Lipoma "Lipoma"

  // .SnomedDescription BodyStructure | 261719000 | Breast cavity (Morphologic-Abnormality)
  * #LumpectomyCavity "Lumpectomy cavity"

  // .SnomedDescription BodyStructure | 261719000 | Breast cavity (Morphologic-Abnormality)
  * #LumpectomySite "Lumpectomy site"

  * #LymphNode "Lymph node"

  // .Snomed 274741002
  // .SnomedDescription ClinicalFinding | Generalized enlarged lymph nodes (Disorder) | [0/0] | R59.1
  * #LymphNodeEnlarged "Lymph node enlarged"

  * #LymphNodeNormal "Lymph node normal"

  * #LymphNodePathological "Lymph node pathological"

  * #MassSolid "Mass solid"

  * #MassSolidW/tumorVasc "Mass solid w/tumor vasc"

  // .SnomedDescription ClinicalFinding | 45198002 | Mastitis (Disorder) | [3/51] | P39.0 | Neonatal infective mastitis | N61 | Inflammatory disorders of breast |
  * #Mastitis "Mastitis"

  // .Dicom F-01765
  // .Snomed 129753004
  // .SnomedDescription ClinicalFinding | 129753004 | Milk of calcium radiographic calcification (Finding)
  * #MilkOfCalcium "Milk of calcium"

  * #Multi-focalCancer "Multi-focal cancer"

  // .SnomedDescription need help
  * #PapillaryLesion "Papillary lesion"

  // .Snomed 99571000119102
  // .SnomedDescription ClinicalFinding | Papilloma of breast (Disorder)
  * #Papilloma "Papilloma"

  // .SnomedDescription ClinicalFinding | 712989008 | Phyllodes tumor of breast (Disorder) | D48.6 |
  * #PhyllodesTumor "Phyllodes tumor"

  // .SnomedDescription BodyStructure | 63130001 | Surgical scar (Morphologic-Abnormality)
  * #PostLumpectomyScar "Post lumpectomy scar"

  // .SnomedDescription BodyStructure | 63130001 | Surgical scar (Morphologic-Abnormality)
  * #PostSurgicalScar "Post surgical scar"

  * #PreviousBiopsy "Previous biopsy"

  * #PreviousSurgery "Previous surgery"

  // .SnomedDescription ClinicalFinding | 62112002 | Injury of breast (Disorder) | [4/41] | S29.9XX?
  * #PreviousTrauma "Previous trauma"

  // .Snomed 390787006
  // .SnomedDescription ClinicalFinding | Radial scar of breast (Finding)
  * #RadialScar "Radial scar"

  // .Snomed 143501000119107
  // .SnomedDescription SituationWithExplicitContext  | History of radiation therapy to breast area (Situation)
  * #RadiationChanges "Radiation changes"

  // .Snomed 429479009
  // .SnomedDescription SituationWithExplicitContext | History of radiation therapy (Situation)
  * #RadiationTherapy "Radiation therapy"

  * #Scar "Scar"

  * #ScarWithShadowing "Scar with shadowing"

  * #SclerosingAdenosis "Sclerosing adenosis"

  // .SnomedDescription ??????????????
  * #SecretoryCalcification "Secretory calcification"

  * #SentinelNode "Sentinel node"

  // .Snomed 297178008
  // .SnomedDescription ClinicalFinding | Breast seroma (Disorder)
  * #Seroma "Seroma"

  // .Snomed 126510002
  // .SnomedDescription ClinicalFinding | Neoplasm of skin of breast (Disorder)
  * #SkinLesion "Skin lesion"

  * #Surgery "Surgery"

  // .SnomedDescription ClinicalFinding | 62112002 | Injury of breast (Disorder)
  * #Trauma "Trauma"

  // .SnomedDescription ClinicalFinding | 396779001 | Breast arterial calcification (Finding) | [0/0] | R92.1
  * #VascularCalcifications "Vascular calcifications"

  // .SnomedDescription ClinicalFinding | 71897006 | Venous stasis (Finding) | [0/0] | I87.8
  * #VenousStasis "Venous stasis"

//- Codes


ValueSet:  ConsistentWithQualifierVS
Title: "ConsistentWithQualifier ValueSet"
Description:  "ConsistentWithQualifier Value Set"
//+ Codes
  * codes from system ConsistentWithQualifierCS
//- Codes


CodeSystem: ConsistentWithQualifierCS
Title: "ConsistentWith Qualifier CodeSystem"
Description: "ConsistentWithQualifier  code system"
//+ Codes
  * #DifferentialDiagnosis "Differential diagnosis"
  * #LikelyRepresents "Likely represents"
  * #MostLikely "Most likely"
  * #Resembles "Resembles"
//- Codes