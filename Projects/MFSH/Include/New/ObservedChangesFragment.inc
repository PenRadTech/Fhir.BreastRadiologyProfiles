
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// ObservedChanges Fragment
// <b>Fragment that adds 'Observed Changes' element to profile.</b>

#macro ObservedChangesFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Fragment that adds 'Observed Changes' element to profile.",
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
    //         "id": "Observation.component:obsChanges",
    //         "path": "Observation.component",
    //         "sliceName": "obsChanges",
    //         "short": "Observed Change In Abnormality component.",
    //         "definition": "This slice contains the optional components that define observed changes in this abnormality.\n The value of this component is a codeable concept chosen from the ObservedChangesVS valueset.",
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
    //         "id": "Observation.component:obsChanges.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "obsChanges",
    //                   "display": "Component code for 'Observed Changes' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Observed Changes' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Observed Change In Abnormality component code",
    //         "definition": "This code identifies the Observed Change In Abnormality components.\n Its value shall always be the concept 'Component code for 'Observed Changes' slice'",
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
    //               "code": "obsChanges"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsChanges.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Observed Change In Abnormality component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/ObservedChangesVS"
    //         }
    //       }
    //     ]
    //   }
    // }
