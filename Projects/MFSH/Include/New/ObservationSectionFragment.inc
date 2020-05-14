
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
#use "ObservationMacros.inc"

// Observation Section Fragment
// <b>Observation section fragment</b>
// 
// this fragment constrains a generic observation to be a observation section.

#macro ObservationSectionFragment()
    #apply once ObservationFragment()
    #apply once ObservationNoComponentFragment()
    #apply once ObservationNoValueFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Observation section fragment",
    //         "definition": "this fragment constrains a generic observation to be a observation section.",
    //         "base": {
    //           "path": "Observation",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.interpretation",
    //         "path": "Observation.interpretation",
    //         "min": 0,
    //         "max": "0",
    //         "base": {
    //           "path": "Observation.interpretation",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.method",
    //         "path": "Observation.method",
    //         "min": 0,
    //         "max": "0",
    //         "base": {
    //           "path": "Observation.method",
    //           "min": 0,
    //           "max": "1"
    //         }
    //       }
    //     ]
    //   }
    // }
