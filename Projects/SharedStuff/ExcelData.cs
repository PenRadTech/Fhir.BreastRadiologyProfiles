using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using FhirKhit.Tools;
using ClosedXML.Excel;

namespace BreastRadiology.Shared
{
    public class ExcelData
    {
        DataTable dataTable;
        public Dictionary<String, DataRow> rows = new Dictionary<string, DataRow>();
        String filePath;

        public Int32 classCol = -1;
        public Int32 mgCol = -1;
        public Int32 mriCol = -1;
        public Int32 nmCol = -1;
        public Int32 usCol = -1;
        public Int32 idMammoCol = -1;
        public Int32 listBoxNameCol = -1;
        public Int32 structureCol = -1;
        public Int32 itemNameCol = -1;
        public Int32 dicomCol = -1;
        public Int32 snoMedCol = -1;
        public Int32 snoMedDescriptionCol = -1;
        public Int32 icd10Col = -1;
        public Int32 umlsCol = -1;
        public Int32 acrCol = -1;
        IConversionInfo converter;

        public ExcelData(IConversionInfo converter,
            String filePath,
            String sheetName)
        {
            this.converter = converter;
            this.filePath = filePath;
            DataSet dataSet = this.ReadSpreadSheet(filePath);
            DataTable originalTable = dataSet.Tables[sheetName];
            this.dataTable = CreateTableWithHeadings(originalTable);
            this.LoadRows(originalTable);
        }

        DataTable CreateTableWithHeadings(DataTable tblSource)
        {
            DataTable retVal = new DataTable("Sheet3");

            void Read()
            {
                DataRow row = tblSource.Rows[0];
                object[] items = row.ItemArray;
                for (Int32 i = 0; i < tblSource.Columns.Count; i++)
                {
                    String colName = tblSource.Columns[i].ColumnName;
                    if (colName.StartsWith("Column"))
                        colName = row.ItemArray[i].ToString();
                    if (colName.ToUpper() == "ID10CT")
                        colName = "ICD10CM";
                    DataColumn newCol = new DataColumn(colName, typeof(String));
                    retVal.Columns.Add(newCol);
                }
            }

            Read();

            Int32 GetColumn(String name)
            {
                Int32 index = 0;
                foreach (DataColumn col in retVal.Columns)
                {
                    if (String.Compare(col.ColumnName, name, true) == 0)
                        return index;
                    index += 1;
                }

                throw new Exception($"Column {name} not found ");
            }

            this.classCol = GetColumn("CLASS");
            this.mgCol = GetColumn("MG");
            this.mriCol = GetColumn("MRI");
            this.nmCol = GetColumn("NM");
            this.usCol = GetColumn("US");
            this.idMammoCol = GetColumn("ID_MAMMO");
            this.listBoxNameCol = GetColumn("LISTBOX_NAME");
            this.structureCol = GetColumn("STRUCTURE");
            this.itemNameCol = GetColumn("ITEM_NAME");
            this.dicomCol = GetColumn("DICOM_CODE");
            this.snoMedCol = GetColumn("SNOMED");
            this.snoMedDescriptionCol = GetColumn("SNOMED DESCRIPTION");
            this.icd10Col = GetColumn("ICD10CM");
            this.umlsCol = GetColumn("UMLS");
            this.acrCol = GetColumn("ACR");

            return retVal;
        }

        public String[] GetHeadings()
        {
            List<String> retVal = new List<string>();
            foreach (var col in this.dataTable.Columns)
            {
                retVal.Add(col.ToString());
            }

            return retVal.ToArray();
        }

        void LoadRows(DataTable originalData)
        {
            for (Int32 rowIndex = 1; rowIndex < originalData.Rows.Count; rowIndex++)
            {
                DataRow originalRow = originalData.Rows[rowIndex];
                object[] items = originalRow.ItemArray;
                items[this.classCol] = "";
                DataRow newRow = this.dataTable.Rows.Add(items);

                String key;
                switch (newRow[this.idMammoCol])
                {
                    case DBNull dbNullValue:
                        newRow[this.idMammoCol] = key = $"Row{rowIndex}";
                        break;
                    default:
                        key = newRow[this.idMammoCol].ToString();
                        break;
                }

                if (rows.ContainsKey(key))
                {
                    this.converter.ConversionWarn("ExcelData",
                        "LoadRows",
                        $"Mammo id {key} already exists");
                }
                else
                    rows.Add(key, newRow);
            }
        }

        public bool TryGetRow(String mammoId, out DataRow row)
        {
            return this.rows.TryGetValue(mammoId, out row);
        }

        public void PatchACRText(String mammoId, String[] lines)
        {
            StringBuilder sb = new StringBuilder();
            foreach (String line in lines)
                sb.AppendLine(line);
            if (this.rows.TryGetValue(mammoId, out DataRow row) == false)
            {
                this.converter.ConversionWarn("ExcelData",
                    "PatchACRText",
                    $"Cant find row for Mammo id {mammoId}");
                return;
            }

            row[acrCol] = sb.ToString();
        }

        public void Save()
        {
            Save(this.filePath);

            {
                Int32 i = 0;
                while (i < this.dataTable.Rows.Count)
                {
                    DataRow r = this.dataTable.Rows[i];

                    bool Delete()
                    {
                        if (String.IsNullOrWhiteSpace(r[this.classCol].ToString()) == false)
                            return true;
                        if (String.IsNullOrWhiteSpace(r[this.mgCol].ToString()) == true)
                            return true;
                        return false;
                    }

                    if (Delete())
                        this.dataTable.Rows.RemoveAt(i);
                    else
                        i += 1;
                }

                String unusedPath = Path.Combine(Path.GetDirectoryName(this.filePath), "BreastData.unused.xlsx");
                Save(unusedPath);
            }
        }

        public void Save(String filePath)
        {
            XLWorkbook workbook = new XLWorkbook();
            IXLWorksheet sheet = workbook.Worksheets.Add(this.dataTable);
            sheet.Columns().AdjustToContents();
            sheet.Columns().Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Border.TopBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Border.RightBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            //sheet.Columns().Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Alignment.WrapText = true;
            sheet.Columns().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            sheet.Columns().Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;

            File.Delete(filePath);
            workbook.SaveAs(filePath);
        }

        DataSet ReadSpreadSheet(String filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    return reader.AsDataSet();
                }
            }
        }
    }
}