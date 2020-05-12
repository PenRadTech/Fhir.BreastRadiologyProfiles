
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// Tumor Satellite Fragment
// <b>Tumor Satellite fragment</b>
// 
// This fragment adds the references for the Tumor Satellite extension.

#macro TumorSatelliteFragment()
    #apply HeaderFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Tumor Satellite fragment",
    //         "definition": "This fragment adds the references for the Tumor Satellite extension.",
    //         "base": {
    //           "path": "Observation",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.hasMember",
    //         "path": "Observation.hasMember",
    //         "slicing": {
    //           "discriminator": [
    //             {
    //               "type": "value",
    //               "path": "url"
    //             }
    //           ],
    //           "ordered": true,
    //           "rules": "openAtEnd"
    //         },
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.hasMember:tumorSatellite",
    //         "path": "Observation.hasMember",
    //         "sliceName": "tumorSatellite",
    //         "short": "'Tumor Satellite' reference.",
    //         "definition": "This slice references the target 'Tumor Satellite'.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.hasMember",
    //           "min": 0,
    //           "max": "*"
    //         },
    //         "type": [
    //           {
    //             "code": "Reference",
    //             "targetProfile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite"
    //             ]
    //           }
    //         ]
    //       }
    //     ]
    //   }
    // }
