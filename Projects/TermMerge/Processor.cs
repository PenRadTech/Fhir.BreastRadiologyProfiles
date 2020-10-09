using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TermMerge
{
    class Processor
    {
        FhirResources fhirResources = new FhirResources();
        FSHFiles fshFiles = new FSHFiles();


        public void AddResources(params String[] inputDirs) => this.fhirResources.AddResources(inputDirs);
        public void AddFSHFiles(params String[] inputDirs) => this.fshFiles.AddFiles(inputDirs);

        void Process(String codeSystemName,
            CodeSystem.ConceptDefinitionComponent concept, 
            FSHFile f)
        {
            if (String.IsNullOrEmpty(concept.Definition) == true)
                return;
            Int32 i = f.FindConcept(codeSystemName, concept.Code);
            if (i < 0)
            {
                Console.WriteLine($"Error finding codesystem '{codeSystemName}' in FSH file {Path.GetFileName(f.Path)}");
                return;
            }
        }

        void Process(CodeSystem codeSystem)
        {
            String name = codeSystem.Name;
            switch (name)
            {
                case "BiRadsAssessmentCategoriesCS":
                    name = "BiRadsAssessmentCategoryCS";
                    break;


                case "BreastLocationClockCS":
                    name = "BreastBodyLocationClockPositionsCS";
                    break;

                case "BreastLocationDepthCS":
                    name = "BreastBodyLocationDepthCS";
                    break;

                case "BreastLocationQuadrantCS":
                    name = "BreastBodyLocationQuadrantCS";
                    break;

                case "BreastLocationRegionCS":
                    name = "BreastBodyLocationRegionCS";
                    break;

                case "CompositionSectionSliceCodes":
                    name = "CompositionSectionSliceCodesCS";
                    break;

                case "ConsistentWithCodeSystemCS":
                    name = "ConsistentWithCS";
                    break;

                case "FibroadenomaCodeSystemCS":
                    name = "AbnormalityFibroadenomaTypeCS";
                    break;

                case "ForeignObjectCS":
                    name = "AbnormalityForeignObjectTypeCS";
                    break;

                case "GraphicTypeCS":
                    name = "";
                    break;

                case "MammoCalcificationTypeCS":
                    name = "CalcificationTypeCS";
                    break;

                case "MGAbnormalityAsymmetryTypeCS":
                    name = "AbnormalityAsymmetryTypeCS";
                    break;

                case "MGAbnormalityDensityTypeCS":
                    name = "AbnormalityDensityTypeCS";
                    break;

                case "MGDensityCS":
                    name = "MGBreastDensityCS";
                    break;

                case "NotPreviouslySeenCodeSystemCS":
                    name = "NotPreviouslySeenCS";
                    break;

                case "ObservationCodes":
                    name = "ObservationCodesCS";
                    break;

                case "ObservationComponentSliceCodes":
                    name = "ObservationComponentSliceCodesCS";
                    break;

                case "PreviouslyDemonstratedByCodeSystemCS":
                    name = "PreviouslyDemonstratedByCS";
                    break;

                case "RecommendationsCodeSystemCS":
                    name = "ServiceRecommendationsCS";
                    break;
            }

            if (String.IsNullOrEmpty(name) == true)
                return;

            if (this.fshFiles.TryGetCodeSystem(name, out FSHFile f) == false)
            {
                Console.WriteLine($"Cant find code system {name}");
                return;
            }

            foreach (CodeSystem.ConceptDefinitionComponent concept in codeSystem.Concept)
            {
                Process(name, concept, f);
            }
        }

        public void Process()
        {
            foreach (CodeSystem codeSystem in fhirResources.CodeSystems)
                Process(codeSystem);
        }
    }
}
