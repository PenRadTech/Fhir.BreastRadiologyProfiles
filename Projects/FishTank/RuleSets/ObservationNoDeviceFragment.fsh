// ObservationNoDeviceFragment
// Fragment for all observations that have no device.

RuleSet: ObservationNoDeviceFragment
//+Mixins: ObservationFragment
  * interpretation 0..0
  * referenceRange 0..0
  * basedOn 0..0
  * partOf 0..0
  * focus 0..0
  * specimen 0..0
  * contained 0..0
  //- Mixins:
  * device 0..0
