ValueSet:  ObservedChangesVS
Title: "ObservedChanges ValueSet"
Description:  "ObservedChanges Value Set"

/*DecreaseInCalcifications "Decrease in calcifications"
  There is an decrease in the number of calcifications associated with the item being observed.
  This decrease is from the previous observation of this item.
  */
* $SCT#129727007 "Decrease in number of calcifications since previous mammogram (Finding)"
 
/*
  DecreaseInNumber "Decrease in number"
  There is an decrease in the number of items being observed. This decrease is from the previous observation of this item.
  */
* $SCT#42915007  "Abnormal decrease in number (Finding)"
  
/*
  DecreaseInSize "Decrease in size"
  The lesion/mass has decreased in size since. This decrease is from the previous observation of this item.
  */
* $SCT#19776001 "Decreased size (Finding)"

/*
  IncreaseInCalcifications "Increase in calcifications"
  There is an increase in the number of calcifications associated with the item being observed.
  This increase is from the previous observation of this item.
  */
* $SCT#129726003 "Increase in number of calcifications since previous mammogram (Finding)"

/*
  IncreaseInNumber "Increase in number"
  There is an increase in the number of items being observed.
  This increase is from the previous observation of this item.
  */
* $SCT#61515005 "Abnormal increase in number (Finding)"

/*
  IncreaseInSize "Increase in size"
  The item being observed has increased in size.
  This increase is from the previous observation of this item.
  */
* $SCT#15454001 "Increased size (Finding)"

/*
  LessProminent "Less prominent"
  The item being observed has decreased in prominance.
  This decrease is from the previous observation of this item.
  */
* $SCT#129728002 "Finding less well defined since previous mammogram (Finding)"

/*
  MoreProminent "More prominent"
  The item being observed has increased in prominance.
  This increase is from the previous observation of this item.
  */
* $SCT#129729005 "Finding more defined since previous mammogram (Finding)"

/*
  New "New"
  There are new items being observed present.
  This increase is from the previous observation of this item.
  */
* $SCT#129721008 "New finding since previous mammogram (Finding)"

/*
  NoLongerSeen "No longer seen"
  The item being observed is no longer visible.
  It was visible on previous observations.
  $FIXME
  */

/*
  NotSignificantChanged "Not significant changed"
  The item being observed has not significantly changed since the last Mammogram.
  */
* $SCT#129723006 "No significant change since previous mammogram (Finding)"

/*
  PartiallyRemoved "Partially removed"
  The item being observed was partially removed since last observation.
  */
* $SCT#129722001 "Finding partially removed since previous mammogram (Finding)"

/*
  RepresentsChange "Represents change"
  The item being observed has changed since the last observation.
  $FIXME
  */

/*
  Stable "Stable"
  The item being observed has remained stable since the last observation.
  $FIXME
  */


CodeSystem: ObservedChangesCS
Title: "Observed Changes CodeSystem"
Description: "Observed changes in an abnormality code system."
* ^caseSensitive = false