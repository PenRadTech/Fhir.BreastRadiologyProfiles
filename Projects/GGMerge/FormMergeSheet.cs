using ClosedXML.Excel;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreastRadiology.Shared;
using DocumentFormat.OpenXml.Wordprocessing;
using FhirKhit.Tools;

namespace GGMerge
{
    public partial class FormMergeSheet : Form, IConversionInfo
    {
        ExcelData source;
        ExcelData destination;
        String[] headings;

        public FormMergeSheet()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbDestination_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void tbSource_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        void EnableButtons()
        {
            this.btnOk.Enabled = false;
            this.btnMerge.Enabled = false;
            if (String.IsNullOrEmpty(this.tbDestination.Text))
                return;
            if (String.IsNullOrEmpty(this.tbSource.Text))
                return;
            if (File.Exists(this.tbDestination.Text) == false)
                return;
            if (File.Exists(this.tbSource.Text) == false)
                return;

            this.btnOk.Enabled = true;
            this.btnMerge.Enabled = true;
        }

        bool SelectSpreadSheetFile(String startPath, out String path)
        {
            path = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = startPath;
            ofd.Filter = "Excel Files | *.xlsx";
            ofd.Title = "Select excel file";

            switch (ofd.ShowDialog())
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    path = ofd.FileName;
                    return true;
                default:
                    return false;
            }
        }

        private void tbnSelSource_Click(object sender, EventArgs e)
        {
            if (SelectSpreadSheetFile(this.tbSource.Text, out String path) == false)
                return;
            this.tbSource.Text = path;
        }

        private void btnSelDest_Click(object sender, EventArgs e)
        {
            if (SelectSpreadSheetFile(this.tbDestination.Text, out String path) == false)
                return;
            this.tbDestination.Text = path;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                Merge(this.tbSource.Text, this.tbDestination.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public bool Merge(String pathSource,
            String pathDestination)
        {
            this.source = new ExcelData(this, pathSource, "Sheet3");
            this.destination = new ExcelData(this, pathDestination, "Sheet3");

            String[] headingSource = this.source.GetHeadings();
            String[] headingDestination = this.destination.GetHeadings();
            Compare(headingSource, headingDestination);

            this.headings = headingDestination;

            if (MergeRows() == false)
                return false;
            this.destination.Save();
            return true;
        }

        bool MergeRows()
        {
            foreach (KeyValuePair<String, DataRow> item in this.source.rows)
            {
                if (MergeRow(item) == false)
                    return false;
            }

            return true;
        }

        bool MergeRow(KeyValuePair<String, DataRow> item)
        {
            if (this.destination.TryGetRow(item.Key, out DataRow rowDest) == false)
            {
                DialogResult res = MessageBox.Show($"Can not find row {item.Key} in destination table",
                    "Error",
                    MessageBoxButtons.OKCancel);
                switch (res)
                {
                    case DialogResult.OK:
                        return true;

                    case DialogResult.Cancel:
                        return false;

                    default:
                        throw new NotImplementedException();
                }
            }

            return this.MergeCols(item.Key, item.Value, rowDest);
        }

        bool MergeCols(String mammoId,
            DataRow rowSource,
            DataRow rowDest)
        {
            for (Int32 i = 0; i < this.headings.Length; i++)
            {
                if (i != this.source.idMammoCol)
                    MergeCol(mammoId, i, rowSource, rowDest);
            }
            return true;
        }

        bool MergeCol(String mammoId,
            Int32 i,
            DataRow rowSource,
            DataRow rowDest)
        {
            String sourceText = rowSource[i].ToString().Trim();
            String destText = rowDest[i].ToString().Trim();
            if (String.Compare(sourceText, destText) == 0)
                return true;

            if (sourceText.Length == 0)
                return true;

            if (destText.Length == 0)
            {
                rowDest[i] = rowSource[i];
                return true;
            }

            this.tbMammoId.Text = mammoId;
            this.tbColumnName.Text = this.headings[i];
            this.tbInfo.Text = $"{rowDest[this.destination.listBoxNameCol]}:{rowDest[this.destination.itemNameCol]}";
            this.tbSourceData.Text = sourceText;
            this.tbDestData.Text = destText;

            bool MergeQuery()
            {
                if (this.cbQuery.Checked == true)
                    return true;
                DialogResult res = MessageBox.Show($"Overwrite destination?",
                    "Query",
                    MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        return true;

                    case DialogResult.No:
                        return true;

                    default:
                        throw new NotImplementedException();
                }
            }
            if (MergeQuery() == false)
                return false;
            rowDest[i] = rowSource[i];
            return true;
        }

        void Compare(String[] headingSource, String[] headingDestination)
        {
            String FixedName(String s)
            {
                if (s.StartsWith("Column"))
                    s = "";
                return s;
            }

            if (headingSource.Length != headingDestination.Length)
                throw new Exception("Header's do not match");

            for (Int32 i = 0; i < headingSource.Length; i++)
            {
                if (FixedName(headingSource[i]) != FixedName(headingDestination[i]))
                    throw new Exception($"Heading's{i} {headingSource[i]} and {headingDestination[i]} do not match");
            }
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

        void Msg(String import, string className, string method, string msg)
        {
        }

        public void ConversionError(string className, string method, string msg) => Msg("Err", className, method, msg);

        public void ConversionInfo(string className, string method, string msg) => Msg("Info", className, method, msg);

        public void ConversionWarn(string className, string method, string msg) => Msg("Warn", className, method, msg);
    }
}
