
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// CorrespondsWith Fragment
// <b>Observation 'Consistent With' Component Fragment</b>

#macro CorrespondsWithFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Observation 'Consistent With' Component Fragment",
    //         "base": {
    //           "path": "Observation",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component",
    //         "path": "Observation.component",
    //         "slicing": {
    //           "discriminator": [
    //             {
    //               "type": "pattern",
    //               "path": "code"
    //             }
    //           ],
    //           "rules": "open"
    //         },
    //         "base": {
    //           "path": "Observation.component",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:correspondsWith",
    //         "path": "Observation.component",
    //         "sliceName": "correspondsWith",
    //         "short": "Corresponds With component.",
    //         "definition": "This slice contains the optional components that define what this observation corresponds with.\n The value of this component is a codeable concept chosen from the CorrespondsWithVS valueset.",
    //         "comment": "This is one component of a group of components that are part of the observation.",
    //         "min": 0,
    //         "max": "*",
    //         "base": {
    //           "path": "Observation.component",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:correspondsWith.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "correspondsWith",
    //                   "display": "Component code for 'Corresponds With' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Corresponds With' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Corresponds With component code",
    //         "definition": "This code identifies the Corresponds With components.\n Its value shall always be the concept 'Component code for 'Corresponds With' slice'",
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
    //               "code": "correspondsWith"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:correspondsWith.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Corresponds With component value",
    //         "definition": "Value is a codeable concept.",
    //         "min": 1,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.value[x]",
    //           "min": 0,
    //           "max": "1"
    //         },
    //         "type": [
    //           {
    //             "code": "CodeableConcept"
    //           }
    //         ],
    //         "binding": {
    //           "strength": "extensible",
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/CorrespondsWithVS"
    //         }
    //       }
    //     ]
    //   }
    // }
