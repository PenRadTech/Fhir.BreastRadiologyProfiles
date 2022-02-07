/*
   Value set that defines consistent with qualifier codes.
*/
ValueSet:  ConsistentWithQualifierVS
Title: "ConsistentWith Qualifier ValueSet"
Description:  "ConsistentWith Qualifier Value Set"
* ^copyright = """
	This value set includes content from SNOMED CT, 
	which is copyright © 2002+ International Health 
	Terminology Standards Development Organisation (IHTSDO), 
	and distributed by agreement between IHTSDO and HL7. 
	Implementer use of SNOMED CT is not covered by this agreement"
    """

  * #DifferentialDiagnosis "Differential diagnosis"
    """
    More than one possibility for a diagnosis.
    The process of weighing the probability of one disease
    versus that of other diseases
    possibly accounting for a patient's illness.
    """

  * #LikelyRepresents "Likely represents"
    """
    Likely represents
    """

  * #MostLikely "Most likely"
    """
    Most likely
    """

  * #Resembles "Resembles"
    """
    Resembles
    """
	
// * include codes from system $SCT where concept descendent-of #106230009 "Qualifier for certainty of diagnosis (qualifier value)"
// * include $SCT#47965005 "Differential diagnosis (contextual qualifier) (qualifier value)"

// #Resembles "Resembles"
// $FIXME
// * include $SCT# ""