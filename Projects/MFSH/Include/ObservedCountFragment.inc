
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// ObservedCount Fragment
// Fragment that adds 'Observed Count' element to profile.

#macro ObservedCountFragment()
  #incompatible ObservationNoComponentFragment
  #apply once ComponentSlicing()

  * component contains observedCount 0..1
  * component ^short = "Observed Count component."
  * component ^comment = "This is one component of a group of components that are part of the observation."
  * component ^definition = """
    This component slice contains the number of items observed.
	This can be a quantity (i.e. 5), or a range (1 to 5).
	
	If the lower bound of the range is set but not the upper bound,
	then it means {lower bound} or more.
	
	If the lower bound of the range is not set but the upper bound is,
	then it means {upper bound} or less.
	"""

#end
    //       {
    //         "id": "Observation.component:obsCount.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "obsCount",
    //                   "display": "Component code for 'Observed Count' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Observed Count' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "min": 1,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.code",
    //           "min": 1,
    //           "max": "1"
    //         },
    //         "patternCodeableConcept": {
    //           "coding": [
    //             {
    //               "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //               "code": "obsCount"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsCount.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "slicing": {
    //           "discriminator": [
    //             {
    //               "type": "type",
    //               "path": "$this"
    //             }
    //           ],
    //           "rules": "closed"
    //         },
    //         "min": 1,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.value[x]",
    //           "min": 0,
    //           "max": "1"
    //         },
    //         "type": [
    //           {
    //             "code": "Quantity"
    //           },
    //           {
    //             "code": "Range"
    //           }
    //         ]
    //       }
    //     ]
    //   }
    // }
