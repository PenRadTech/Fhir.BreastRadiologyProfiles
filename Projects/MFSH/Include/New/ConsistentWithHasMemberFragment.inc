
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// ConsistentWith HasMember Fragment
// <b>ConsistentWith HasMember fragment</b>
// 
// This fragment adds the references for the ConsistentWith HasMember.

#macro ConsistentWithHasMemberFragment()
    #apply HeaderFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "ConsistentWith HasMember fragment",
    //         "definition": "This fragment adds the references for the ConsistentWith HasMember.",
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
    //         "id": "Observation.hasMember:consistentWith",
    //         "path": "Observation.hasMember",
    //         "sliceName": "consistentWith",
    //         "short": "'Consistent With' reference.",
    //         "definition": "This slice references the target 'Consistent With'.",
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
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith"
    //             ]
    //           }
    //         ]
    //       }
    //     ]
    //   }
    // }
