
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// PreviouslyDemonstratedBy Fragment
// <b>Observation 'Demonstrated By' Component Fragment</b>

#macro PreviouslyDemonstratedByFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Observation 'Demonstrated By' Component Fragment",
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
    //         "id": "Observation.component:PreviouslyDemonstratedBy",
    //         "path": "Observation.component",
    //         "sliceName": "PreviouslyDemonstratedBy",
    //         "short": "Previously Demonstrated By component.",
    //         "definition": "This slice contains the optional components that specifies what this observation has been previously demonstrated by.\n The value of this component is a codeable concept chosen from the PreviouslyDemonstratedByVS valueset.",
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
    //         "id": "Observation.component:PreviouslyDemonstratedBy.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "prevDemBy",
    //                   "display": "Component code for 'Previously Demonstrated By' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Previously Demonstrated By' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Previously Demonstrated By component code",
    //         "definition": "This code identifies the Previously Demonstrated By components.\n Its value shall always be the concept 'Component code for 'Previously Demonstrated By' slice'",
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
    //               "code": "prevDemBy"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:PreviouslyDemonstratedBy.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Previously Demonstrated By component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/PreviouslyDemonstratedByVS"
    //         }
    //       }
    //     ]
    //   }
    // }
