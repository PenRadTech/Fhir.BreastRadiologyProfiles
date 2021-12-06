ValueSet:  ObservedChangesVS
Title: "ObservedChanges ValueSet"
Description:  "ObservedChanges Value Set"
* insert Terminology_SnomedCopyright
* include codes from system $SCT where concept descendent-of #129720009 " Finding of change since previous mammogram (finding)"

/*
  DecreaseInNumber "Decrease in number"
  There is an decrease in the number of items being observed. This decrease is from the previous observation of this item.
  */
* $SCT#42915007  "Abnormal decrease in number (Finding)"
  

/*
  IncreaseInNumber "Increase in number"
  There is an increase in the number of items being observed.
  This increase is from the previous observation of this item.
  */
* $SCT#61515005 "Abnormal increase in number (Finding)"


/*
  $FIXME missing

  NoLongerSeen "No longer seen"
  RepresentsChange "Represents change"
  Stable "Stable"
  */