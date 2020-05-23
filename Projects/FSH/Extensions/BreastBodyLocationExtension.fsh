/*
  Extension that defined Breast Body Location
*/
Extension: BreastBodyLocationExtension
Parent: Extension
Title: "Breast Body Location Extension"
Description: """
    Breast Body Location Extension
    """


  * . ^short = "Breast Body Location extension"
/*
    {
    {
      "id": "Extension.extension:laterality",
      "path": "Extension.extension",
      "sliceName": "laterality",
      "short": "Body side",
      "definition": "The side of the body being examined.",
      "min": 0,
      "max": "1",
      "base": {
        "path": "Extension.extension",
        "min": 0,
        "max": "*"
      }
    },
    {
      "id": "Extension.extension:laterality.extension",
      "path": "Extension.extension.extension",
      "min": 0,
      "max": "0"
    },
    {
      "id": "Extension.extension:laterality.url",
      "path": "Extension.extension.url",
      "definition": "Url for laterality complex extension item.",
      "type": [
        {
          "code": "uri"
        }
      ],
      "fixedUri": "laterality"
    },
    {
      "id": "Extension.extension:laterality.value[x]",
      "path": "Extension.extension.value[x]",
      "min": 1,
      "max": "1",
      "type": [
        {
          "code": "CodeableConcept"
        }
      ],
      "binding": {
        "strength": "required",
        "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/LateralityVS"
      }
    },
    {
      "id": "Extension.extension:quadrant",
      "path": "Extension.extension",
      "sliceName": "quadrant",
      "short": "Quadrant of the body location",
      "definition": "The quadrant  of the body location.",
      "min": 0,
      "max": "1",
      "base": {
        "path": "Extension.extension",
        "min": 0,
        "max": "*"
      }
    },
    {
      "id": "Extension.extension:quadrant.extension",
      "path": "Extension.extension.extension",
      "min": 0,
      "max": "0"
    },
    {
      "id": "Extension.extension:quadrant.url",
      "path": "Extension.extension.url",
      "definition": "Url for quadrant complex extension item.",
      "type": [
        {
          "code": "uri"
        }
      ],
      "fixedUri": "quadrant"
    },
    {
      "id": "Extension.extension:quadrant.value[x]",
      "path": "Extension.extension.value[x]",
      "min": 1,
      "max": "1",
      "type": [
        {
          "code": "CodeableConcept"
        }
      ],
      "binding": {
        "strength": "required",
        "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/BreastLocationQuadrantVS"
      }
    },
    {
      "id": "Extension.extension:region",
      "path": "Extension.extension",
      "sliceName": "region",
      "short": "Region of the body location",
      "definition": "The region  of the body location.",
      "min": 0,
      "max": "*",
      "base": {
        "path": "Extension.extension",
        "min": 0,
        "max": "*"
      }
    },
    {
      "id": "Extension.extension:region.extension",
      "path": "Extension.extension.extension",
      "min": 0,
      "max": "0"
    },
    {
      "id": "Extension.extension:region.url",
      "path": "Extension.extension.url",
      "definition": "Url for region complex extension item.",
      "type": [
        {
          "code": "uri"
        }
      ],
      "fixedUri": "region"
    },
    {
      "id": "Extension.extension:region.value[x]",
      "path": "Extension.extension.value[x]",
      "min": 1,
      "max": "1",
      "type": [
        {
          "code": "CodeableConcept"
        }
      ],
      "binding": {
        "strength": "required",
        "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/BreastLocationRegionVS"
      }
    },
    {
      "id": "Extension.extension:clockDirection",
      "path": "Extension.extension",
      "sliceName": "clockDirection",
      "short": "Clock direction of the body location",
      "definition": "The clock direction of the body location.",
      "min": 0,
      "max": "1",
      "base": {
        "path": "Extension.extension",
        "min": 0,
        "max": "*"
      }
    },
    {
      "id": "Extension.extension:clockDirection.extension",
      "path": "Extension.extension.extension",
      "min": 0,
      "max": "0"
    },
    {
      "id": "Extension.extension:clockDirection.url",
      "path": "Extension.extension.url",
      "definition": "Url for clockDirection complex extension item.",
      "type": [
        {
          "code": "uri"
        }
      ],
      "fixedUri": "clockDirection"
    },
    {
      "id": "Extension.extension:clockDirection.value[x]",
      "path": "Extension.extension.value[x]",
      "min": 1,
      "max": "1",
      "type": [
        {
          "code": "CodeableConcept"
        }
      ],
      "binding": {
        "strength": "required",
        "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/BreastLocationClockVS"
      }
    },
    {
      "id": "Extension.extension:depth",
      "path": "Extension.extension",
      "sliceName": "depth",
      "short": "Depth of the body location",
      "definition": "The depth of the body location.",
      "min": 0,
      "max": "1",
      "base": {
        "path": "Extension.extension",
        "min": 0,
        "max": "*"
      }
    },
    {
      "id": "Extension.extension:depth.extension",
      "path": "Extension.extension.extension",
      "min": 0,
      "max": "0"
    },
    {
      "id": "Extension.extension:depth.url",
      "path": "Extension.extension.url",
      "definition": "Url for depth complex extension item.",
      "type": [
        {
          "code": "uri"
        }
      ],
      "fixedUri": "depth"
    },
    {
      "id": "Extension.extension:depth.value[x]",
      "path": "Extension.extension.value[x]",
      "min": 1,
      "max": "1",
      "type": [
        {
          "code": "CodeableConcept"
        }
      ],
      "binding": {
        "strength": "required",
        "valueSet": "http://hl7.org/fhir/us/breast-radiology/ValueSet/BreastLocationDepthVS"
      }
    },
    {
      "id": "Extension.extension:distanceFromLandmark",
      "path": "Extension.extension",
      "sliceName": "distanceFromLandmark",
      "short": "distanceFromLandmark extension.",
      "definition": "This extension slice contains the distanceFromLandmark extension.",
      "comment": "This is one component of a group of components that are part of the observation.",
      "min": 0,
      "max": "*",
      "base": {
        "path": "Extension.extension",
        "min": 0,
        "max": "*"
      },
      "type": [
        {
          "code": "Extension",
          "profile": [
            "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BodyDistanceFromExtension"
          ]
        }
      ],
      "isModifier": false
    },
    {
      "id": "Extension.url",
      "path": "Extension.url",
      "base": {
        "path": "Extension.url",
        "min": 1,
        "max": "1"
      },
      "type": [
        {
          "code": "uri"
        }
      ],
      "fixedUri": "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension"
    },
    {
      "id": "Extension.value[x]",
      "path": "Extension.value[x]",
      "min": 0,
      "max": "0",
      "base": {
        "path": "Extension.value[x]",
        "min": 0,
        "max": "1"
      }
    }
  ]
*/