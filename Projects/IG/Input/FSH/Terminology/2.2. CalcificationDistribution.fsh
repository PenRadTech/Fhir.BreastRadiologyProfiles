// $FIXME
ValueSet:  CalcificationDistributionVS
Title: "CalcificationDistribution ValueSet"
Description:  "CalcificationDistribution Value Set"
* ^copyright = """
	This value set includes content from SNOMED CT, 
	which is copyright © 2002+ International Health 
	Terminology Standards Development Organisation (IHTSDO), 
	and distributed by agreement between IHTSDO and HL7. 
	Implementer use of SNOMED CT is not covered by this agreement"
    """

// Branching Distribution
* include SNOMED#129762002 "Fine, linear, branching (casting) radiographic calcification (Finding)"

//#ClusteredDistribution "Clustered distribution"
* include SNOMED#129769006 " Radiographic calcification with clustered distribution (Finding)"

// #DiffuseDistribution "Diffuse distribution"
* include SNOMED#129764001 "Radiographic calcification with diffuse distribution (Finding)"

// #GroupedDistribution "Grouped distribution"
* include SNOMED#129766004 "Radiographic calcification with grouped distribution (Finding) "

// #LinearDistribution "Linear distribution"
* include SNOMED#129765000 "Radiographic calcification with linear distribution (Finding)"

// #RegionalDistribution "Regional distribution"
* include SNOMED#129767008 "Radiographic calcification with regional distribution (Finding)"

// #ScatteredDistribution "Scattered distribution"
// $FIXME
//* include SNOMED# ""

// #SegmentalDistribution "Segmental distribution"
* include SNOMED#129768003 "Radiographic calcification with segmental distribution (Finding)"