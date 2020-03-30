using FhirKhit.Tools;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace BreastRadiology.XUnitTests
{
    class Global
    {
        public const String BreastRadBaseUrl = "http://hl7.org/fhir/us/breast-radiology/";

        public const String Loinc = "http://loinc.org";
        public const String Snomed = "http://snomed.info/sct";

        public const String CompositionUrl = "http://hl7.org/fhir/StructureDefinition/Composition";
        public const String ClinicalImpressionUrl = "http://hl7.org/fhir/StructureDefinition/ClinicalImpression";
        public const String DiagnosticReportUrl = "http://hl7.org/fhir/StructureDefinition/DiagnosticReport";
        public const String DomainResourceUrl = "http://hl7.org/fhir/StructureDefinition/DomainResource";
        public const String ExtensionUrl = "http://hl7.org/fhir/StructureDefinition/Extension";
        public const String ImagingStudyUrl = "http://hl7.org/fhir/StructureDefinition/ImagingStudy";
        public const String MedicationRequestUrl = "http://hl7.org/fhir/StructureDefinition/MedicationRequest";
        public const String ObservationUrl = "http://hl7.org/fhir/StructureDefinition/Observation";
        public const String ResourceUrl = "http://hl7.org/fhir/StructureDefinition/Resource";
        public const String RiskAssessmentUrl = "http://hl7.org/fhir/StructureDefinition/RiskAssessment";
        public const String ServiceRequestUrl = "http://hl7.org/fhir/StructureDefinition/ServiceRequest";

        public const String ContactUrl = "http://www.hl7.org/Special/committees/cic";

        public const String BaseFragmentUrl = "http://www.fragment.com/";
        public static String FragmentUrl = $"{BaseFragmentUrl}fragment";
        public static String IsFragmentExtensionUrl = $"{BaseFragmentUrl}isFragment";
        public static String IncompatibleFragmentUrl = $"{BaseFragmentUrl}incompatibleFragment";
        public static String GroupExtensionUrl = $"{BaseFragmentUrl}Group";
        public static String DefaultValueExtensionUrl = $"{BaseFragmentUrl}DefaultValue";

        public static String ResourceMapNameUrl = $"{BaseFragmentUrl}mapname";
        public static String ResourceMapLinkUrl = $"{BaseFragmentUrl}maplink";

        public static String ElementAnchor(ElementDefinition e)
        {
            Int32 pIndex = e.ElementId.IndexOf('.');
            if (pIndex < 0)
                pIndex = e.ElementId.Length;
            String id = "{SDName}" + e.ElementId.Substring(pIndex);

            return $"StructureDefinition-" + "{SDName}" + $"-definitions.html#{e.ElementId}";
        }
    }
}