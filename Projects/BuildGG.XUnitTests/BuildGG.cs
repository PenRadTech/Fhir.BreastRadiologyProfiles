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
using DocumentFormat.OpenXml.ExtendedProperties;
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
        String TerminologyPath(String fileName) =>
            Path.Combine(DirHelper.FindParentDir("BreastRadiologyProfilesV3"),
                "Projects",
                "FishTank",
                "Terminology",
                fileName);

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

        void AppLine(CodeBlockNested concept,
            String name,
            Object value)
        {
            if (value is System.DBNull)
                return;

            String sValue = value.ToString();
            sValue = sValue.Trim()
                    .Replace("\r", "")
                ;

            if (String.IsNullOrEmpty(sValue) == false)
                concept.AppendLine($"  // .{name} {sValue}");
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
            params String[] penIds)
        {
            IEnumerable<String> penIds2 = penIds;
            WriteIds(className, 
                outputCodePath,
                penIds2);
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

        //void WriteIntroDocDescription(String className,
        //    String blockName,
        //    String outputCodePath,
        //    String penId)
        //{
        //    CodeEditor editor = new CodeEditor();
        //    editor.Load(Path.Combine(DirHelper.FindParentDir("BreastRadiologyProfilesV3"),
        //        "Projects",
        //        "FishTank",
        //        "Terminology",
        //        outputCodePath));

        //    UpdateClass(className, penId);

        //    if (this.spreadSheetData.TryGetRow(penId, out DataRow row) == false)
        //        throw new Exception($"Missing value for penid '{penId}'");

        //    CodeBlockNested description = editor.Blocks.Find(blockName);
        //    if (description == null)
        //        throw new Exception($"Can not find editor block {blockName}");

        //    description.Clear();
        //    AppIfNotNull(description, penId, "Description", row[UMLSCol]);
        //    editor.Save();
        //}

        void WriteIds(String className,
            String outputCodePath,
            IEnumerable<String> penIdsEnum)
        {
            String[] penIds = penIdsEnum.ToArray();

            CodeEditor csEditor = new CodeEditor();
            CodeEditor vsEditor = new CodeEditor();
            String csOutputPath = $"{TerminologyPath(outputCodePath)}CS.fsh";
            String vsOutputPath = $"{TerminologyPath(outputCodePath)}VS.fsh";
            File.Delete(csOutputPath);
            File.Delete(vsOutputPath);

            if (File.Exists(csOutputPath) == true)
                csEditor.Load(csOutputPath);
            else
            {
                csEditor.IgnoreMacrosInQuotedStrings = false;
                csEditor.AddUserMacro("Name", $"{className}CS");
                csEditor.AddUserMacro("Title", $"{className} CodeSystem");
                csEditor.AddUserMacro("Description", $"{className} CodeSystem");
                csEditor.Load(TerminologyPath("Template.cs.txt"));
                csEditor.SavePath = csOutputPath;
            }

            if (File.Exists(vsOutputPath) == true)
                vsEditor.Load(vsOutputPath);
            else
            {
                vsEditor.IgnoreMacrosInQuotedStrings = false;
                vsEditor.AddUserMacro("Name", $"{className}VS");
                vsEditor.AddUserMacro("Title", $"{className} CodeSystem");
                vsEditor.AddUserMacro("Description", $"{className} Value Set");
                vsEditor.Load(TerminologyPath("Template.vs.txt"));
                vsEditor.SavePath = vsOutputPath;
            }

            CodeBlockNested csCodes = csEditor.Blocks.Find("Codes");
            if (csCodes == null)
                throw new Exception($"Can not find editor block Codes");

            CodeBlockNested vsCodes = vsEditor.Blocks.Find("Codes");
            if (vsCodes == null)
                throw new Exception($"Can not find editor block Codes");

            csCodes.Clear();
            vsCodes.Clear();

            vsCodes
                .AppendRaw($"  * codes from system {className}CS")
                ;

            for (Int32 i = 0; i < penIds.Length; i++)
            {
                String penId = penIds[i];
                UpdateClass(className, penId);

                if (this.spreadSheetData.TryGetRow(penId, out DataRow row) == false)
                    throw new Exception($"Missing value for penid '{penId}'");

                String Value(Object value)
                {
                    if (value is System.DBNull)
                        return null;
                    return value.ToString();
                }

                String displayName = FormatCode(row[this.spreadSheetData.itemNameCol].ToString());
                String code = CodeValue(displayName);

                String description = Value(row[ACRCol]);
                if (String.IsNullOrWhiteSpace(description))
                    description = Value(row[UMLSCol]);
                description = description.Trim().Replace("\r", "");
                String descStart = "";
                //$if (description.Length > 0)
                //$    descStart = " \"\"\"";

                AppLine(csCodes, "Dicom", row[DicomCol]);
                AppLine(csCodes, "Snomed", row[SnomedCol]);
                AppLine(csCodes, "SnomedDescription", row[SnomedDescriptionCol]);

                csCodes
                    .AppendRaw($"  * #{code} \"{displayName}\"{descStart}")
                    ;
                if (descStart.Length > 0)
                {
                    foreach (String desciptionLine in description.Split('\n'))
                        csCodes.AppendRaw($"    {desciptionLine}");
                    csCodes.AppendRaw($"    \"\"\"");
                }
                csCodes.AppendRaw($"");
            }
            csEditor.Save();
            vsEditor.Save();
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

            //WriteIntroDocDescription("AbnormalityCyst", "IntroDocDescription",
            //    @"Common\Abnormalities\AbnormalityCyst.cs", "69");
            //WriteIntroDocDescription("AbnormalityArchitecturalDistortion", "IntroDocDescription",
            //    @"FindingMG\MGAbnormalityArchitecturalDistortion.cs", "642");
            //WriteIntroDocDescription("MGAbnormalityAsymmetry", "IntroDocDescription",
            //    @"FindingMG\MGAbnormalityAsymmetry.cs", "691");
            //WriteIntroDocDescription("MGAbnormalityCalcification", "IntroDocDescription",
            //    @"FindingMG\MGAbnormalityCalcification.cs", "690");
            //WriteIntroDocDescription("MGAbnormalityDensity", "IntroDocDescription",
            //    @"FindingMG\MGAbnormalityDensity.cs", "686");
            //WriteIntroDocDescription("MGAbnormalityFatNecrosis", "IntroDocDescription",
            //    @"FindingMG\MGAbnormalityFatNecrosis.cs", "688");
            //WriteIntroDocDescription("TumorSatellite", "IntroDocDescription", @"Common\TumorSatellite.cs", "623");

            WriteIds("BiRads",
                @"BiRadsAssessmentCategory",
                Filter("Impression", "Birads").Remove("790", "791", "174", "173"));

            WriteIds("AbnormalityCyst",
                @"AbnormalityCyst",
                "69", "610", "657", "617", "636", "609", "661");
            WriteIds("AbnormalityDuct",
                @"AbnormalityDuct",
                "692", "694.602", "693.614");
            WriteIds("AbnormalityFibroAdenoma",
                @"AbnormalityFibroAdenoma",
                "70", "695");
            WriteIds("AbnormalityLymphNode",
                @"AbnormalityLymphNode",
                "648", "649", "662", "665", "650", "651", "652", "666", "663");
            WriteIds("AbnormalityMass",
                @"AbnormalityMass",
                "58", "621", "697", "613", "608");
            WriteIds("AbnormalityForeignObject",
                @"AbnormalityForeignObject",
                Filter("Finding foreign body", "foreign body"));

            WriteIds("ServiceRecommendation",
                @"ServiceRecommendation",
                Filter("Recommendations", "Recommendation"));

            WriteIds("CorrespondsWith",
                @"CorrespondsWith",
                Filter("Corresponds", "Corresponds with"));
            WriteIds("ConsistentWith",
                @"ConsistentWith",
                Filter("Classification Consistent with", "Consistent with"));
            WriteIds("ConsistentWithQualifier",
                @"ConsistentWithQualifier",
                Filter("Classification Consistent with", "Consistent qualifier"));
            WriteIds("NotPreviouslySeen",
                @"NotPreviouslySeen",
                Filter("Not Prev Seen On", "not previous seen"));
            WriteIds("Margin",
                @"Margin",
                Filter("Profile Abnormality", "margin"));
            WriteIds("Orientation",
                @"Orientation",
                Filter("Size and Distance", "Orientation"));
            WriteIds("PreviouslyDemonstratedBy",
                @"PreviouslyDemonstratedBy",
                Filter("Dem. By Prior", "previous demostrated by"));
            WriteIds("Shape",
                @"Shape",
                Filter("Profile Abnormality", "shape"));
            WriteIds("ObservedChanges",
                @"ObservedChanges",
                Filter("Change From Prior", "Change From Prior"));
            WriteIds("CalcificationDistribution",
                @"CalcificationDistribution",
                Filter("Assoc Calcs distribution", "calcification distribution"));

            WriteIds("MGAbnormalityAsymmetry",
                @"MGAbnormalityAsymmetry",
                "691", "643", "644", "Row542");
            WriteIds("MGAbnormalityDensity",
                @"MGAbnormalityDensity",
                "686", "645", "646", "647");
            WriteIds("MGAbnormalityCalcification",
                @"MGAbnormalityCalcification",
                Filter("Assoc Cal", "calcification type"));
            WriteIds("MGDensity",
                @"MGDensity",
                Filter("Profile Abnormality", "density"));
            WriteIds("MGBreastDensity",
                @"MGBreastDensity",
                Filter("", "MG Breast Density"));

            WriteIds("BreastBodyLocation_ClockPositions",
                @"BreastBodyLocationExtension",
                "1001", "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009", "1010", "1011", "1012");
            WriteIds("BreastBodyLocation_Depth",
                @"BreastBodyLocationExtension",
                "1017", "1018", "1019");
            WriteIds("BreastBodyLocation_Quadrants",
                @"BreastBodyLocationExtension",
                "1024", "1025", "1022", "1023");
            WriteIds("BreastBodyLocation_Regions",
                @"BreastBodyLocationExtension",
                "1015", "1014", "AxillaI", "AxillaII", "AxillaIII", "1515", "1511", "1013");
            WriteIds("AssociatedFeature",
                @"AssociatedFeature",
                RemovePlurals(Filter("Associated findings", "Associated findings")));
            WriteIds("AssociatedFeature",
                @"AssociatedFeature",
                Filter("Associated findings", "Associated findings cal"));

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