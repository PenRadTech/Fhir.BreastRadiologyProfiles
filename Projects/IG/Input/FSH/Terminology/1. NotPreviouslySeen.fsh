ValueSet:  NotPreviouslySeenVS
Title: "NotPreviouslySeen ValueSet"
Description:  "NotPreviouslySeen Value Set"

// Outside exam
// $FIXME Have GG validate that this ok code for outside exam.
* include SNOMED#386053000 "Evaluation procedure (procedure)"

* include codes from system $SCT where concept Is-A #420131003 "Fluoroscopic mammary ductography (Procedure)"
* include codes from system $SCT where concept Is-A #71651007 "Mammography (procedure)"
* include codes from system $SCT where concept Is-A #241615005 "Magnetic resonance imaging of breast (Procedure)"
* include codes from system $SCT where concept Is-A #418432003 "Scintimammography (procedure)"
* include codes from system $SCT where concept Is-A #47079000 "Ultrasonography of breast (Procedure)"