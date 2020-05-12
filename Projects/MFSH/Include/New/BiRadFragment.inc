
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// BiRad Fragment
// <b>Fragment that adds 'BiRad code' element to profile.</b>

#macro BiRadFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Fragment that adds 'BiRad code' element to profile.",
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
    //         "id": "Observation.component:biRadsAssessmentCategory",
    //         "path": "Observation.component",
    //         "sliceName": "biRadsAssessmentCategory",
    //         "short": "BiRads Assessment Category component.",
    //         "definition": "This slice contains the optional component that define the BiRAD risk code.\n The value of this component is a codeable concept chosen from the BiRadsAssessmentCategoriesVS valueset.",
    //         "comment": "This is one component of a group of components that are part of the observation.",
    //         "min": 0,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:biRadsAssessmentCategory.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "targetBiRads",
    //                   "display": "Component code for 'BiRads Code' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'BiRads Code' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "BiRads Assessment Category component code",
    //         "definition": "This code identifies the BiRads Assessment Category component.\n Its value shall always be the concept 'Component code for 'BiRads Code' slice'",
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
    //               "code": "targetBiRads"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:biRadsAssessmentCategory.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "BiRads Assessment Category component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/BiRadsAssessmentCategoriesVS"
    //         }
    //       }
    //     ]
    //   }
    // }
