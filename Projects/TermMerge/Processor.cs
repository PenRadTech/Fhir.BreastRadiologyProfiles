using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TermMerge
{
    class Processor
    {
        FhirResources fhirResources = new FhirResources();
        FSHFiles fshFiles = new FSHFiles();


        public void AddResources(params String[] inputDirs) => this.fhirResources.AddResources(inputDirs);
        public void AddFSHFiles(params String[] inputDirs) => this.fshFiles.AddFiles(inputDirs);

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
                    name = "";
                    break;

                case "ConsistentWithCodeSystemCS":
                    name = "";
                    break;

                case "FibroadenomaCodeSystemCS":
                    name = "";
                    break;

                case "ForeignObjectCS":
                    name = "";
                    break;

                case "GraphicTypeCS":
                    name = "";
                    break;

                case "MammoCalcificationTypeCS":
                    name = "";
                    break;

                case "MGAbnormalityAsymmetryTypeCS":
                    name = "";
                    break;

                case "MGAbnormalityDensityTypeCS":
                    name = "";
                    break;

                case "MGDensityCS":
                    name = "";
                    break;

                case "NotPreviouslySeenCodeSystemCS":
                    name = "";
                    break;

                case "ObservationCodes":
                    name = "";
                    break;

                case "ObservationComponentSliceCodes":
                    name = "";
                    break;

                case "PreviouslyDemonstratedByCodeSystemCS":
                    name = "";
                    break;

                case "RecommendationsCodeSystemCS":
                    name = "";
                    break;
            }

            if (String.IsNullOrEmpty(name) == true)
                return;

            if (this.fshFiles.TryGetCodeSystem(name, out FSHFile f) == false)
            {
                Console.WriteLine($"Cant find code system {name}");
                return;
            }
        }

        public void Process()
        {
            foreach (CodeSystem codeSystem in fhirResources.CodeSystems)
                Process(codeSystem);
        }
    }
}
