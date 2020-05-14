
#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"
// Breast Body Location (Required) Fragment
// <b>Required Breast Body Location fragment</b>
// 
// This fragment adds the references for the breast body location extension.
// 
// The references are required, meaning that the breast body location must exist.

#macro BreastBodyLocationRequiredFragment()
    #apply once HeaderFragment()
#end
    //   "differential": {
    //     "element": [
    //       {
    //         "id": "Observation",
    //         "path": "Observation",
    //         "short": "Required Breast Body Location fragment",
    //         "definition": "This fragment adds the references for the breast body location extension.\n\nThe references are required, meaning that the breast body location must exist.",
    //         "base": {
    //           "path": "Observation",
    //           "min": 0,
    //           "max": "*"
    //         }
    //       },
    //       {
    //         "id": "Observation.bodySite",
    //         "path": "Observation.bodySite",
    //         "min": 1,
    //         "max": "1",
    //         "base": {
    //           "path": "Observation.bodySite",
    //           "min": 0,
    //           "max": "1"
    //         }
    //       },
    //       {
    //         "id": "Observation.bodySite.extension",
    //         "path": "Observation.bodySite.extension",
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
    //         "min": 0,
    //         "max": "*",
    //         "type": [
    //           {
    //             "code": "Extension"
    //           }
    //         ]
    //       },
    //       {
    //         "id": "Observation.bodySite.extension:breastBodyLocation",
    //         "path": "Observation.bodySite.extension",
    //         "sliceName": "breastBodyLocation",
    //         "short": "breastBodyLocation extension.",
    //         "definition": "This extension slice contains the breastBodyLocation extension.",
    //         "comment": "This is one component of a group of components that are part of the observation.",
    //         "min": 1,
    //         "max": "1",
    //         "type": [
    //           {
    //             "code": "Extension",
    //             "profile": [
    //               "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension"
    //             ]
    //           }
    //         ],
    //         "isModifier": false
    //       }
    //     ]
    //   }
    // }
