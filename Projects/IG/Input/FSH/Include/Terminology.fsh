/*
 Observation.Fragment
 constraints used in all breast radiology observations.
*/
 
RuleSet: CodeSystem_Common
* ^caseSensitive = false

RuleSet: Terminology_UCUMCopyright
* ^copyright =
    """
    This material contains content from UCUM (https://ucum.org/). 
	UCUM is Copyright © 1999-2014 Regenstrief Institute, Inc. 
	and The UCUM Organization, Indianapolis, IN. 
	All rights reserved. See https://ucum.org/trac/wiki/TermsOfUse for details.
    """

RuleSet: Terminology_SnomedCopyright
* ^copyright = """
	This value set includes content from SNOMED CT, 
	which is copyright © 2002+ International Health 
	Terminology Standards Development Organisation (IHTSDO), 
	and distributed by agreement between IHTSDO and HL7. 
	Implementer use of SNOMED CT is not covered by this agreement"
    """

RuleSet: Terminology_DICOMCopyright
* ^copyright = """
	DICOM codes are excerpted from Digital Imaging and 
	Communications in Medicine (DICOM) Standard, 
	Part 16: Content Mapping Resource, 
	Copyright © 2011 by the National Electrical Manufacturers Association."
    """