
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
#use "BreastBodyLocationRequiredFragment.inc"
// Not Previously Seen Component Fragment
// <b>Not Previously Seen component slice fragment</b>
// 
// Adds NotPreviously Seen Component slice.

#macro NotPreviouslySeenComponentFragment()
    #apply once BreastBodyLocationRequiredFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Not Previously Seen component slice fragment",
    //         "definition": "Adds NotPreviously Seen Component slice.",
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
    //         "id": "Observation.component:notPreviouslySeen",
    //         "path": "Observation.component",
    //         "sliceName": "notPreviouslySeen",
    //         "short": "Not Previously Seen component.",
    //         "definition": "This slice contains the optional components that define prevous encounters in which this abnormality was not seen.\n The value of this component is a codeable concept chosen from the NotPreviouslySeenVS valueset.",
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
    //         "id": "Observation.component:notPreviouslySeen.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "notPreviouslySeen",
    //                   "display": "Component code for 'Not Previously Seen' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Not Previously Seen' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Not Previously Seen component code",
    //         "definition": "This code identifies the Not Previously Seen components.\n Its value shall always be the concept 'Component code for 'Not Previously Seen' slice'",
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
    //               "code": "notPreviouslySeen"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:notPreviouslySeen.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Not Previously Seen component value",
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
    //           "strength": "required",
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/NotPreviouslySeenVS"
    //         }
    //       }
    //     ]
    //   }
    // }
