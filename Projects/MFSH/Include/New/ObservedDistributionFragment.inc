
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// ObservedDistribution Fragment
// <b>Fragment that adds 'Observed Distribution' components to Observation.</b>

#macro ObservedDistributionFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Fragment that adds 'Observed Distribution' components to Observation.",
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
    //         "id": "Observation.component:obsDistribution",
    //         "path": "Observation.component",
    //         "sliceName": "obsDistribution",
    //         "short": "Observed distribution of abnormalities component.",
    //         "definition": "This slice contains the optional components that describe the distribution of a group of abnormalities.\n The value of this component is a codeable concept chosen from the CalcificationDistributionVS valueset.",
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
    //         "id": "Observation.component:obsDistribution.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "obsDistribution",
    //                   "display": "Component code for 'Observed Distribution' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Observed Distribution' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Observed distribution of abnormalities component code",
    //         "definition": "This code identifies the Observed distribution of abnormalities components.\n Its value shall always be the concept 'Component code for 'Observed Distribution' slice'",
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
    //               "code": "obsDistribution"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsDistribution.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Observed distribution of abnormalities component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/CalcificationDistributionVS"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsDistRegionSize",
    //         "path": "Observation.component",
    //         "sliceName": "obsDistRegionSize",
    //         "short": "Observed Distribution Region Size component.",
    //         "definition": "This component slice contains the size of an region inside of which there \nis a distribution of abnormalities.\n\nThere may be one, two, or three values indicating a size of\n one dimension (length), two dimensions (area), or three dimensions (volume).\n\nEach dimension can be a quantity (i.e. 5), or a range (1 to 5).\n\nIf the lower bound of the range is set but not the upper bound, \nthen the size is {lower bound} or greater.\n\nIf the upper bound of the range is set but not the lower bound, \nthen the size is {upper bound} or less.",
    //         "comment": "This is one component of a group of components that are part of the observation.",
    //         "min": 0,
    //         "max": "3",
    //         "base": {
    //           "path": "Observation.component",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsDistRegionSize.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "obsSize",
    //                   "display": "Component code for 'Observed Size' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Observed Size' slice"
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
    //               "code": "obsSize"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsDistRegionSize.value[x]",
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
    //       },
    //       {
    //         "id": "Observation.component:obsDistRegionSize.value[x]:valueQuantity",
    //         "path": "Observation.component.value[x]",
    //         "sliceName": "valueQuantity",
    //         "min": 0,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.value[x]",
    //           "min": 0,
    //           "max": "1"
    //         },
    //         "type": [
    //           {
    //             "code": "Quantity"
    //           }
    //         ],
    //         "patternQuantity": {
    //           "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:obsDistRegionSize.value[x]:valueRange",
    //         "path": "Observation.component.value[x]",
    //         "sliceName": "valueRange",
    //         "min": 0,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.component.value[x]",
    //           "min": 0,
    //           "max": "1"
    //         },
    //         "type": [
    //           {
    //             "code": "Range"
    //           }
    //         ],
    //         "patternRange": {
    //           "low": {
    //             "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
    //           },
    //           "high": {
    //             "system": "http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS"
    //           }
    //         }
    //       }
    //     ]
    //   }
    // }
