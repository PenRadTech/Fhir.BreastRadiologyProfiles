using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Specification.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using PreFhir;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using System.Collections.Generic;
using BreastRadiology.XUnitTests;
using System.Drawing;
using ExcelDataReader;
using System.Data;
using System.Globalization;
using System.Linq;
using BreastRadiology.Shared;
using Newtonsoft.Json.Linq;

namespace BreastRadiology.XUnitTests
{
    class Info : IConversionInfo
    {
        void Msg(String import, string className, string method, string msg)
        {
            Trace.WriteLine($"{import} [{className}.{method}] '{msg}'");
        }

        public void ConversionError(string className, string method, string msg) => Msg("Err", className, method, msg);

        public void ConversionInfo(string className, string method, string msg) => Msg("Info", className, method, msg);

        public void ConversionWarn(string className, string method, string msg) => Msg("Warn", className, method, msg);
    }

    [TestClass]
    public sealed class BuildGG
    {
        const String BaseDirName = "BreastRadiologyProfiles";

        String BaseDir
        {
            get
            {
                if (this.baseDirFull == null)
                    this.baseDirFull = DirHelper.FindParentDir(BaseDirName);
                return this.baseDirFull;
            }
        }

        String baseDirFull;

        ExcelData spreadSheetData;

        Int32 ICD10Col => this.spreadSheetData.icd10Col;
        Int32 DicomCol => this.spreadSheetData.dicomCol;
        Int32 SnomedCol => this.spreadSheetData.snoMedCol;
        Int32 SnomedDescriptionCol => this.spreadSheetData.snoMedDescriptionCol;
        Int32 ACRCol => this.spreadSheetData.acrCol;
        Int32 UMLSCol => this.spreadSheetData.umlsCol;

        public BuildGG()
        {
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding enc1252 = CodePagesEncodingProvider.Instance.GetEncoding(1252);
        }

        String CodeValue(String value)
        {
            {
                Int32 index = value.IndexOf('(');
                if (index > 0)
                    value = value.Substring(0, index);
            }

            value = value.Trim();
            value = Char.ToUpper(value[0], CultureInfo.InvariantCulture) + value.Substring(1);
            while (true)
            {
                Int32 j = value.IndexOf(' ', new StringComparison());
                if (j < 0)
                    break;
                String temp = value.Substring(0, j);
                while (value[j] == ' ')
                    j += 1;
                temp += Char.ToUpper(value[j], CultureInfo.InvariantCulture);
                temp += value.Substring(j + 1);
                value = temp;
            }

            return value;
        }

        bool AppIfNotNull(CodeBlockNested concept,
            String penId,
            String name,
            Object value)
        {
            if (value is System.DBNull)
                return false;

            String sValue = value.ToString();
            sValue = sValue.Trim()
                    .Replace("\r", "")
                ;
            if (String.IsNullOrEmpty(sValue) == false)
            {
                String[] lines = FormatMultiLineText(sValue).ToArray();
                concept.AppendLine($"    .{name}(\"{penId}\",");
                Int32 i = 0;
                while (i < lines.Length - 1)
                    concept.AppendLine($"        {lines[i++]}");
                concept.AppendLine($"        {lines[i]})");
            }

            return true;
        }

        IEnumerable<String> FormatMultiLineText(String text)
        {
            const Int32 Maxlen = 48;
            Int32 i = 0;
            Int32 len = 0;

            StringBuilder sb = new StringBuilder();

            void PutEoln()
            {
                sb.Append("\",\n\"");
                len = 0;
            }

            sb.Append("\"");
            while (i < text.Length)
            {
                void Add(Char c)
                {
                    sb.Append(c);
                    len += 1;
                }

                Char c = text[i++];
                switch (c)
                {
                    case '“':
                    case '”':
                    case '\"':
                        sb.Append("\\\"");
                        break;

                    case '›':
                        sb.Append(">");
                        break;

                    case '‘':
                    case '’':
                        sb.Append("'");
                        break;

                    case '\r':
                        break;

                    case '.':
                        Add(c);
                        if ((i < text.Length) && (text[i] == ' '))
                        {
                            i += 1;
                            Add(' ');
                            PutEoln();
                        }

                        break;

                    case (char)65533: // unicode REPLACEMENT CHARACTER - ignore it.
                        break;

                    case (char)8211: // en dash
                    case (char)8212: // em dash
                        Add('-');
                        break;

                    case (char)8804:
                        Add('<');
                        Add('=');
                        break;

                    case '\n':
                        if (len > 0)
                            PutEoln();
                        break;

                    case '°':
                        sb.Append("degrees");
                        break;

                    case ' ':
                    case (Char)160: // non breaking space - break anyways :-)
                        Add(c);
                        if (len > Maxlen)
                        {
                            sb.Append("\",\n\"");
                            len = 0;
                        }

                        break;

                    default:
                        Int32 cNum = (Int32)c;
                        if ((cNum < 0x20) || (cNum > 0x7e))
                        {
                            String s = $"Invalid char '{c}' {cNum}";
                            throw new Exception(s);
                        }

                        Add(c);
                        break;
                }
            }

            sb.Append("\"");
            return sb.ToString().Split('\n');
        }

        void WriteIds(String className,
            String outputCodePath,
            String csBlockName,
            params String[] penIds)
        {
            WriteIds(className, outputCodePath, csBlockName, (IEnumerable<String>)penIds);
        }

        public IEnumerable<String> RemovePlurals(IEnumerable<String> values)
        {
            List<String> items = values.ToList();
            Int32 i = 0;

            String PenCode(String penId)
            {
                if (this.spreadSheetData.TryGetRow(penId, out DataRow row) == false)
                    throw new Exception($"Missing value for penid '{penId}'");

                return FormatCode(row[this.spreadSheetData.itemNameCol].ToString());
            }

            bool IsPlural(String id)
            {
                String idCode = PenCode(id).Trim();
                if (idCode.EndsWith("es"))
                    idCode = idCode.Substring(0, idCode.Length - 2);
                else if (idCode.EndsWith("s"))
                    idCode = idCode.Substring(0, idCode.Length - 1);
                else
                    return false;
                for (Int32 j = 0; j < items.Count; j++)
                {
                    String otherValue = PenCode(items[j]).Trim();
                    if (String.Compare(idCode, otherValue, true) == 0)
                        return true;
                }

                return false;
            }

            while (i < items.Count)
            {
                String id = items[i];
                String value = PenCode(id);
                if (IsPlural(items[i]) == false)
                    yield return id;
                i += 1;
            }
        }

        String FormatCode(String s)
        {
            Int32 index = s.ToUpper().IndexOf(" ADD PREFIX");
            if (index >= 0)
            {
                String text = s.Substring(0, index);
                String prefix = s.Substring(index + 11).Trim();
                prefix = prefix.ToMachineName();
                s = $"{prefix} {text}";
            }

            index = s.ToUpper().IndexOf("(SPELL");
            if (index >= 0)
                s = s.Substring(0, index);

            index = s.ToUpper().IndexOf("SPELL");
            if (index >= 0)
                s = s.Substring(0, index);

            s = Char.ToUpper(s[0], CultureInfo.InvariantCulture) + s.Substring(1);
            return s.Trim();
        }

        void UpdateClass(String className,
            String penId)
        {
            if (this.spreadSheetData.TryGetRow(penId, out DataRow row) == false)
                throw new Exception($"Missing value for penid '{penId}'");

            // Update row[Class] with name of class that used row. Used for validation.
            {
                String classText = row[this.spreadSheetData.classCol].ToString();
                if (classText.Length > 0)
                    classText += ", ";
                classText += className;
                row[this.spreadSheetData.classCol] = classText;
            }
        }

        void WriteIntroDocDescription(String className,
            String blockName,
            String outputCodePath,
            String penId)
        {
            CodeEditor editor = new CodeEditor();
            editor.Load(Path.Combine(DirHelper.FindParentDir("BreastRadiology.XUnitTests"),
                "ResourcesMaker",
                outputCodePath));

            UpdateClass(className, penId);

            if (this.spreadSheetData.TryGetRow(penId, out DataRow row) == false)
                throw new Exception($"Missing value for penid '{penId}'");

            CodeBlockNested description = editor.Blocks.Find(blockName);
            if (description == null)
                throw new Exception($"Can not find editor block {blockName}");

            description.Clear();
            AppIfNotNull(description, penId, "Description", row[UMLSCol]);
            editor.Save();
        }

        void WriteIds(String className,
            String outputCodePath,
            String csBlockName,
            IEnumerable<String> penIdsEnum)
        {
            String[] penIds = penIdsEnum.ToArray();

            CodeEditor editor = new CodeEditor();
            editor.Load(Path.Combine(DirHelper.FindParentDir("BreastRadiology.XUnitTests"),
                "ResourcesMaker",
                outputCodePath));

            CodeBlockNested concepts = editor.Blocks.Find(csBlockName);
            if (concepts == null)
                throw new Exception($"Can not find editor block {csBlockName}");

            concepts.Clear();
            concepts.AppendLine($"#region Codes");
            for (Int32 i = 0; i < penIds.Length; i++)
            {
                String penId = penIds[i];
                UpdateClass(className, penId);

                if (this.spreadSheetData.TryGetRow(penId, out DataRow row) == false)
                    throw new Exception($"Missing value for penid '{penId}'");

                String code = FormatCode(row[this.spreadSheetData.itemNameCol].ToString());
                String conceptBlockName = CodeValue(code);

                String App(String s, Object t, String sb)
                {
                    switch (t)
                    {
                        case DBNull dbNullValue:
                            return s;

                        case String stringValue:
                            // verify we have correct column.
                            if (stringValue != sb)
                                Trace.WriteLine($"Invalid Modality '{stringValue}'. Expected {sb}");
                            if (String.IsNullOrEmpty(s) == false)
                                s += " | ";
                            s += $"Modalities.{sb}";
                            return s;

                        default:
                            throw new Exception("Invalid excel cell value");
                    }
                }

                String validWith = App("", row[this.spreadSheetData.mgCol], "MG");
                ;
                validWith = App(validWith, row[this.spreadSheetData.mriCol], "MRI");
                validWith = App(validWith, row[this.spreadSheetData.nmCol], "NM");
                validWith = App(validWith, row[this.spreadSheetData.usCol], "US");

                concepts
                    .AppendLine($"new ConceptDef()")
                    .AppendLine($"    .SetCode(\"{conceptBlockName}\")")
                    .AppendLine($"    .SetDisplay(\"{code}\")")
                    //.AppendLine($"    .SetDefinition(\"[PR] {code}\")")
                    .AppendLine($"    .MammoId(\"{penId}\")")
                    ;
                if (String.IsNullOrEmpty(validWith) == false)
                    concepts.AppendLine($"    .ValidModalities({validWith})");

                AppIfNotNull(concepts, penId, "SetDicom", row[DicomCol]);
                AppIfNotNull(concepts, penId, "SetSnomedCode", row[SnomedCol]);
                //AppIfNotNull(concepts, penId, "SetOneToMany", row[13]);
                AppIfNotNull(concepts, penId, "SetSnomedDescription", row[SnomedDescriptionCol]);
                //AppIfNotNull(concepts, "SetICD10", row[ICD10Col]);
                if (AppIfNotNull(concepts, penId, "SetUMLS", row[UMLSCol]) == false)
                    AppIfNotNull(concepts, penId, "SetACR", row[ACRCol]);
                if (i < penIds.Length - 1)
                    concepts
                        .AppendLine($",");
            }

            concepts.AppendLine($"#endregion // Codes");
            editor.Save();
        }

        IEnumerable<String> Filter(String listBoxNameName,
            String structureName,
            String className = null)
        {
            List<String> retVal = new List<string>();

            bool IsMatch(DataRow dr)
            {
                if (dr[this.spreadSheetData.listBoxNameCol].ToString() != listBoxNameName)
                    return false;
                if (dr[this.spreadSheetData.structureCol].ToString() != structureName)
                    return false;
                if (className != null)
                {
                    String[] classValue = dr[this.spreadSheetData.classCol].ToString().Split(",");
                    if ((classValue.Length > 0) && (classValue[0] != className))
                        return false;
                }

                return true;
            }

            foreach (KeyValuePair<String, DataRow> item in this.spreadSheetData.rows)
            {
                if (IsMatch(item.Value))
                    retVal.Add(item.Key);
            }

            return retVal.ToArray();
        }

        List<String> FormatText(String text)
        {
            const Int32 Maxlen = 80;
            Int32 i = 0;
            Int32 len = 0;

            StringBuilder sb = new StringBuilder();

            void PutEoln()
            {
                sb.Append("\n");
                len = 0;
            }

            while (i < text.Length)
            {
                void Add(Char c)
                {
                    sb.Append(c);
                    len += 1;
                }

                Char c = text[i++];
                switch (c)
                {
                    case '“':
                    case '”':
                    case '\"':
                        sb.Append("\"");
                        break;

                    case '\r':
                        break;

                    case '.':
                        Add(c);
                        if ((i < text.Length) && (text[i] == ' '))
                        {
                            i += 1;
                            Add(' ');
                            PutEoln();
                        }

                        break;

                    case '\n':
                        if (len > 0)
                            PutEoln();
                        break;

                    case ' ':
                        Add(c);
                        if (len > Maxlen)
                            PutEoln();

                        break;

                    default:
                        Add(c);
                        break;
                }
            }

            List<String> retVal = sb.ToString().Split('\n').ToList();
            while ((retVal.Count > 0) && (String.IsNullOrWhiteSpace(retVal[^1])))
                retVal.RemoveAt(retVal.Count - 1);
            return retVal;
        }

        //[TestMethod]
        //public void Cleanup()
        //{
        //    ExcelData source;

        //    bool IsGargage(String text)
        //    {
        //        text = text.ToUpper();
        //        if ((text.Length == 0) || (text[0] != 'C'))
        //            return false;
        //        for (Int32 i = 1; i < text.Length; i++)
        //            if (Char.IsDigit(text[i]) == false)
        //                return false;
        //        return true;
        //    }

        //    bool FixCitations(String text, out String text2, out String citation)
        //    {
        //        bool FindAnchor(String anchor, out String t2, out String c)
        //        {
        //            t2 = null;
        //            c = null;
        //            Int32 i = text.ToUpper().IndexOf(anchor);
        //            if (i < 0)
        //                return false;
        //            t2 = text.Substring(0, i);
        //            c = text.Substring(i).Trim();
        //            return true;
        //        }

        //        if (FindAnchor("HTTP://", out text2, out citation))
        //        {
        //            citation = $"###URL#{citation}";
        //        }
        //        else if (FindAnchor("HTTPS://", out text2, out citation))
        //        {
        //            citation = $"###URL#{citation}";
        //            return true;
        //        }
        //        else if (FindAnchor("FIFTH EDITION", out text2, out citation))
        //        {
        //            Int32 index = citation.ToUpper().IndexOf("PG");
        //            if (index > 0)
        //                citation = $"###ACRMG#{citation.Substring(index + 2).Trim()}";
        //            else
        //                citation = $"###ACRMG#";
        //            return true;
        //        }
        //        else if (FindAnchor("SECOND ADDITION", out text2, out citation))
        //        {
        //            String name = null;
        //            if (citation.Contains("Ultrasound"))
        //                name = "ACRUS";
        //            else if (citation.Contains("Magnetic Resonance Imaging"))
        //                name = "ACRMRI";
        //            else
        //                Debugger.Break();

        //            Int32 index = citation.ToUpper().IndexOf("PG");
        //            if (index > 0)
        //                citation = $"###{name}#{citation.Substring(index + 2).Trim()}";
        //            else
        //                citation = $"###{name}#";
        //            return true;
        //        }
        //        return false;
        //    }

        //    void CleanupUMLS(DataRow row)
        //    {
        //        String text = row[source.umlsCol].ToString();
        //        if (IsGargage(text))
        //            text = "";

        //        if (FixCitations(text, out String text2, out String citation) == true)
        //            text = text2;
        //        List<String> lines = FormatText(text).ToList();
        //        StringBuilder sb = new StringBuilder();
        //        for (Int32 i = 0; i < lines.Count; i++)
        //            sb.AppendLine(lines[i]);
        //        if (String.IsNullOrEmpty(citation) == false)
        //            sb.AppendLine(citation);
        //        row[source.umlsCol] = sb.ToString();
        //    }

        //    String baseDir = DirHelper.FindParentDir("BreastRadiologyProfiles");
        //    String filePath = Path.Combine(baseDir,
        //        "..",
        //        "BRDocs",
        //        "BreastData.xlsx");
        //    source = new ExcelData(new Info(), filePath, "Sheet3");

        //    foreach (DataRow row in source.rows.Values)
        //    {
        //        CleanupUMLS(row);
        //    }
        //    source.Save();
        //}


        [TestMethod]
        public void WriteCode()
        {
            String filePath = Path.Combine(BaseDir,
                "..",
                "BRDocs",
                "BreastData.xlsx");
            this.spreadSheetData = new ExcelData(new Info(), filePath, "Sheet3");

            WriteIntroDocDescription("AbnormalityCyst", "IntroDocDescription",
                @"Common\Abnormalities\AbnormalityCyst.cs", "69");
            WriteIntroDocDescription("AbnormalityArchitecturalDistortion", "IntroDocDescription",
                @"FindingMG\MGAbnormalityArchitecturalDistortion.cs", "642");
            WriteIntroDocDescription("MGAbnormalityAsymmetry", "IntroDocDescription",
                @"FindingMG\MGAbnormalityAsymmetry.cs", "691");
            WriteIntroDocDescription("MGAbnormalityCalcification", "IntroDocDescription",
                @"FindingMG\MGAbnormalityCalcification.cs", "690");
            WriteIntroDocDescription("MGAbnormalityDensity", "IntroDocDescription",
                @"FindingMG\MGAbnormalityDensity.cs", "686");
            WriteIntroDocDescription("MGAbnormalityFatNecrosis", "IntroDocDescription",
                @"FindingMG\MGAbnormalityFatNecrosis.cs", "688");
            WriteIntroDocDescription("TumorSatellite", "IntroDocDescription", @"Common\TumorSatellite.cs", "623");

            WriteIds("BiRads",
                @"Common\BiRadsAssessmentCategoryCS.cs",
                "Codes",
                Filter("Impression", "Birads").Remove("790", "791", "174", "173"));

            WriteIds("AbnormalityCyst",
                @"Common\Abnormalities\AbnormalityCyst.cs",
                "Type",
                "69", "610", "657", "617", "636", "609", "661");
            WriteIds("AbnormalityDuct",
                @"Common\Abnormalities\AbnormalityDuct.cs",
                "Type",
                "692", "694.602", "693.614");
            WriteIds("AbnormalityFibroAdenoma",
                @"Common\Abnormalities\AbnormalityFibroAdenoma.cs",
                "Type",
                "70", "695");
            WriteIds("AbnormalityLymphNode",
                @"Common\Abnormalities\AbnormalityLymphNode.cs",
                "Type",
                "648", "649", "662", "665", "650", "651", "652", "666", "663");
            WriteIds("AbnormalityMass",
                @"Common\Abnormalities\AbnormalityMass.cs",
                "Type",
                "58", "621", "697", "613", "608");
            WriteIds("AbnormalityForeignObject",
                @"Common\Abnormalities\AbnormalityForeignObject.cs",
                "Type",
                Filter("Finding foreign body", "foreign body"));

            WriteIds("ServiceRecommendation",
                @"Common\ServiceRecommendation.cs",
                "Codes",
                Filter("Recommendations", "Recommendation"));
            WriteIds("CorrespondsWithCS",
                @"Common\CorrespondsWithCS.cs",
                "Codes",
                Filter("Corresponds", "Corresponds with"));
            WriteIds("ConsistentWith",
                @"Common\ConsistentWith.cs",
                "Codes",
                Filter("Classification Consistent with", "Consistent with"));
            WriteIds("ConsistentWith",
                @"Common\ConsistentWith.cs",
                "Qualifiers",
                Filter("Classification Consistent with", "Consistent qualifier"));
            WriteIds("NotPreviouslySeenCS",
                @"Common\NotPreviouslySeenCS.cs",
                "Codes",
                Filter("Not Prev Seen On", "not previous seen"));
            WriteIds("MarginCS",
                @"Common\MarginCS.cs",
                "Codes",
                Filter("Profile Abnormality", "margin"));
            WriteIds("OrientationCS",
                @"Common\OrientationCS.cs",
                "Codes",
                Filter("Size and Distance", "Orientation"));
            WriteIds("PreviouslyDemonstratedBy",
                @"Common\PreviouslyDemonstratedBy.cs",
                "Codes",
                Filter("Dem. By Prior", "previous demostrated by"));
            WriteIds("ShapeCS",
                @"Common\ShapeCS.cs",
                "Codes",
                Filter("Profile Abnormality", "shape"));
            WriteIds("ObservedChangesCS",
                @"Common\ObservedChangesCS.cs",
                "Codes",
                Filter("Change From Prior", "Change From Prior"));
            WriteIds("CalcificationDistributionCS",
                @"Common\CalcificationDistributionCS.cs",
                "Codes",
                Filter("Assoc Calcs distribution", "calcification distribution"));

            WriteIds("MGAbnormalityAsymmetry",
                @"FindingMG\MGAbnormalityAsymmetry.cs",
                "Type",
                "691", "643", "644", "Row542");
            WriteIds("MGAbnormalityDensity",
                @"FindingMG\MGAbnormalityDensity.cs",
                "Type",
                "686", "645", "646", "647");
            WriteIds("MGAbnormalityCalcification",
                @"FindingMG\MGAbnormalityCalcification.cs",
                "Type",
                Filter("Assoc Calcs", "calcification type"));
            WriteIds("MGDensity",
                @"FindingMG\MGDensity.cs",
                "Codes",
                Filter("Profile Abnormality", "density"));
            WriteIds("MGBreastDensity",
                @"FindingMG\MGBreastDensity.cs",
                "Codes",
                Filter("", "MG Breast Density"));

            WriteIds("BreastBodyLocation-ClockPositions",
                @"Extensions\BreastBodyLocationExtension.cs",
                "ClockPositions",
                "1001", "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009", "1010", "1011", "1012");
            WriteIds("BreastBodyLocation-Depth",
                @"Extensions\BreastBodyLocationExtension.cs",
                "Depth",
                "1017", "1018", "1019");
            WriteIds("BreastBodyLocation-Quadrants",
                @"Extensions\BreastBodyLocationExtension.cs",
                "Quadrants",
                "1024", "1025", "1022", "1023");
            WriteIds("BreastBodyLocation-Regions",
                @"Extensions\BreastBodyLocationExtension.cs",
                "Regions",
                "1015", "1014", "AxillaI", "AxillaII", "AxillaIII", "1515", "1511", "1013");
            WriteIds("AssociatedFeature",
                @"Common\AssociatedFeature.cs",
                "AssociatedFeatureCS",
                RemovePlurals(Filter("Associated findings", "Associated findings")));
            WriteIds("AssociatedFeature",
                @"Common\AssociatedFeature.cs",
                "AssociatedFeature2CS",
                Filter("Associated findings", "Associated findings calcs"));

            this.spreadSheetData.Save();
        }
    }

    public static class Extensions
    {
        public static IEnumerable<String> Remove(this IEnumerable<String> values,
            params String[] itemsToIgnore)
        {
            return Remove(values, itemsToIgnore.ToList());
        }

        public static IEnumerable<String> Remove(this IEnumerable<String> values,
            List<String> itemsToIgnore)
        {
            foreach (String value in values)
            {
                if (itemsToIgnore.Contains(value.Trim().ToUpper()) == false)
                    yield return value;
            }
        }
    }
}