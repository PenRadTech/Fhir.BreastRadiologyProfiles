/*
   Value set that defines consistent with qualifier codes.
 */
ValueSet:  ConsistentWithQualifierVS
Title: "ConsistentWith Qualifier ValueSet"
Description:  "ConsistentWith Qualifier Value Set"
  * codes from system ConsistentWithQualifierCS



  
/*
   Code system that defines consistent with qualifier codes.
 */
CodeSystem: ConsistentWithQualifierCS
Title: "ConsistentWith Qualifier CodeSystem"
Description: "ConsistentWithQualifier  code system"
  * #DifferentialDiagnosis "Differential diagnosis"
    """
    More than one possibility for a diagnosis.
    The process of weighing the probability of one disease
    versus that of other diseases
    possibly accounting for a patient's illness.
    
    Valid for the following modalities: MG US MRI NM.
    """

  * #LikelyRepresents "Likely represents"
    """
    Likely represents
    
    Valid for the following modalities: MG US MRI NM.
    """

  * #MostLikely "Most likely"
    """
    Most likely
    
    Valid for the following modalities: MG US.
    """

  * #Resembles "Resembles"
    """
    Resembles
    
    Valid for the following modalities: MG US MRI NM.
    """