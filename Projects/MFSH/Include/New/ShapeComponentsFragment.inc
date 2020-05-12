
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
#use "BreastBodyLocationRequiredFragment.inc"
// Shape Components Fragment
// <b>Shape component slice fragment</b>
// 
// Adds Orientation, Shape, Margin, and Density Components

#macro ShapeComponentsFragment()
    #apply BreastBodyLocationRequiredFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Shape component slice fragment",
    //         "definition": "Adds Orientation, Shape, Margin, and Density Components",
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
    //         "id": "Observation.component:orientation",
    //         "path": "Observation.component",
    //         "sliceName": "orientation",
    //         "short": "Orientation component.",
    //         "definition": "This slice contains the optional component that define the orientation of the abnormality.\n The value of this component is a codeable concept chosen from the OrientationVS valueset.",
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
    //         "id": "Observation.component:orientation.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "orientation",
    //                   "display": "Component code for 'Orientation' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Orientation' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Orientation component code",
    //         "definition": "This code identifies the Orientation component.\n Its value shall always be the concept 'Component code for 'Orientation' slice'",
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
    //               "code": "orientation"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:orientation.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Orientation component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/OrientationVS"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:shape",
    //         "path": "Observation.component",
    //         "sliceName": "shape",
    //         "short": "Shape component.",
    //         "definition": "This slice contains the optional component that define the shape of the abnormality.\n The value of this component is a codeable concept chosen from the ShapeVS valueset.",
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
    //         "id": "Observation.component:shape.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "shape",
    //                   "display": "Component code for 'Shape' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Shape' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Shape component code",
    //         "definition": "This code identifies the Shape component.\n Its value shall always be the concept 'Component code for 'Shape' slice'",
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
    //               "code": "shape"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:shape.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Shape component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/ShapeVS"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:margin",
    //         "path": "Observation.component",
    //         "sliceName": "margin",
    //         "short": "Margin component.",
    //         "definition": "This slice contains the optional component that define the observed margin of the abnormality.\n The value of this component is a codeable concept chosen from the MarginVS valueset.",
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
    //         "id": "Observation.component:margin.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "margin",
    //                   "display": "Component code for 'Margin' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'Margin' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Margin component code",
    //         "definition": "This code identifies the Margin component.\n Its value shall always be the concept 'Component code for 'Margin' slice'",
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
    //               "code": "margin"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:margin.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Margin component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/MarginVS"
    //         }
    //       },
    //       {
    //         "id": "Observation.component:mgDensity",
    //         "path": "Observation.component",
    //         "sliceName": "mgDensity",
    //         "short": "Density component.",
    //         "definition": "This slice contains the optional component that define the observed density of the breast tissue.\n The value of this component is a codeable concept chosen from the MGDensityVS valueset.",
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
    //         "id": "Observation.component:mgDensity.code",
    //         "extension": [
    //           {
    //             "url": "http://www.fragment.com/DefaultValue",
    //             "valueCodeableConcept": {
    //               "coding": [
    //                 {
    //                   "system": "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes",
    //                   "code": "mgDensity",
    //                   "display": "Component code for 'MG Density' slice"
    //                 }
    //               ],
    //               "text": "Component code for 'MG Density' slice"
    //             }
    //           }
    //         ],
    //         "path": "Observation.component.code",
    //         "short": "Density component code",
    //         "definition": "This code identifies the Density component.\n Its value shall always be the concept 'Component code for 'MG Density' slice'",
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
    //               "code": "mgDensity"
    //             }
    //           ]
    //         }
    //       },
    //       {
    //         "id": "Observation.component:mgDensity.value[x]",
    //         "path": "Observation.component.value[x]",
    //         "short": "Density component value",
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
    //           "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/MGDensityVS"
    //         }
    //       }
    //     ]
    //   }
    // }
