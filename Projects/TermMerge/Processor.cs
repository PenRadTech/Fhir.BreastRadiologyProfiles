using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

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

            String code = concept.Code;
            switch (code)
            {
                case "mgBreastDensityObservation":
                    break;
                case "mgFindingObservationObservation":
                    code = "mgFindingObservation";
                    break;
                case "mgDensity":
                    code = "mgBreastDensity";
                    break;
                case "EqualDensity":
                    code = "HeterogeneouslyDense";
                    break;
                case "FatContaining":
                    code = "AlmostEntirelyFat";
                    break;
                case "HighDensity":
                    code = "ExtremelyDense";
                    break;
                case "LowDensity":
                    code = "ScatteredAreasOfFibroglandularDensity";
                    break;
                case "mgCalcificationDistribution":
                case "CentralLucent":
                    return;
                default:
                    code = code.Replace("Quadrent", "Quadrant");
                    if (code.StartsWith("sectionCode"))
                        code = code.Substring(11);
                    if (code.StartsWith("section"))
                        code = code.Substring(7);
                    if (code.StartsWith("mg"))
                        code = code.Substring(2);
                    break;

            }
            Int32 i = f.FindConcept(codeSystemName, code);
            if (i < 0)
            {
                Console.WriteLine($"Error finding concept '{codeSystemName}#{code}' in FSH file {Path.GetFileName(f.Path)}");
                return;
            }
            void InsertLine(String s)
            {
                i += 1;
                f.Lines.Insert(i, s);
            }

            void RemoveBlanks()
            {
                Int32 j = i + 1;
                while (j < f.Lines.Count)
                {
                    if (String.IsNullOrEmpty(f.Lines[j].Trim()) == false)
                        return;
                    f.Lines.RemoveAt(j);
                }
            }

            bool HasMLComment()
            {
                if (i >= f.Lines.Count)
                    return false;
                return f.Lines[i + 1].Trim().StartsWith("\"\"\"");
            }
            if (HasMLComment())
                return;

            InsertLine("    \"\"\"");
            bool blankLineFlag = false;
            foreach (String s in concept.Definition.Split('\n'))
            {
                String line = s.Trim()
                    .Replace("\r", "")
                    .Replace("\"", "'")
                    ;
                bool thisBlanksLine = String.IsNullOrEmpty(line);
                if ((blankLineFlag == false) || (thisBlanksLine == false))
                    InsertLine($"    {line}");
                blankLineFlag = thisBlanksLine;
            }

            InsertLine("    \"\"\"");
            InsertLine("");
            RemoveBlanks();
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

                case "CorrespondsWithCodeSystemCS":
                    name = "CorrespondsWithCS";
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
            this.fshFiles.Save();
        }
    }
}
