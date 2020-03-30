namespace GGMerge
{
    partial class FormMergeSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbnSelSource = new System.Windows.Forms.Button();
            this.btnSelDest = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.tbMammoId = new System.Windows.Forms.TextBox();
            this.tbColumnName = new System.Windows.Forms.TextBox();
            this.tbSourceData = new System.Windows.Forms.TextBox();
            this.tbDestData = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.cbQuery = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(75, 9);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(392, 20);
            this.tbSource.TabIndex = 0;
            this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(75, 35);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(392, 20);
            this.tbDestination.TabIndex = 2;
            this.tbDestination.TextChanged += new System.EventHandler(this.tbDestination_TextChanged);
            // 
            // tbnSelSource
            // 
            this.tbnSelSource.Location = new System.Drawing.Point(473, 7);
            this.tbnSelSource.Name = "tbnSelSource";
            this.tbnSelSource.Size = new System.Drawing.Size(75, 23);
            this.tbnSelSource.TabIndex = 4;
            this.tbnSelSource.Text = "Select";
            this.tbnSelSource.UseVisualStyleBackColor = true;
            this.tbnSelSource.Click += new System.EventHandler(this.tbnSelSource_Click);
            // 
            // btnSelDest
            // 
            this.btnSelDest.Location = new System.Drawing.Point(473, 35);
            this.btnSelDest.Name = "btnSelDest";
            this.btnSelDest.Size = new System.Drawing.Size(75, 23);
            this.btnSelDest.TabIndex = 5;
            this.btnSelDest.Text = "Select";
            this.btnSelDest.UseVisualStyleBackColor = true;
            this.btnSelDest.Click += new System.EventHandler(this.btnSelDest_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(713, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Enabled = false;
            this.btnMerge.Location = new System.Drawing.Point(594, 7);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 44);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // tbMammoId
            // 
            this.tbMammoId.Location = new System.Drawing.Point(75, 111);
            this.tbMammoId.Name = "tbMammoId";
            this.tbMammoId.Size = new System.Drawing.Size(100, 20);
            this.tbMammoId.TabIndex = 9;
            // 
            // tbColumnName
            // 
            this.tbColumnName.Location = new System.Drawing.Point(206, 111);
            this.tbColumnName.Name = "tbColumnName";
            this.tbColumnName.Size = new System.Drawing.Size(100, 20);
            this.tbColumnName.TabIndex = 10;
            // 
            // tbSourceData
            // 
            this.tbSourceData.Location = new System.Drawing.Point(42, 156);
            this.tbSourceData.Multiline = true;
            this.tbSourceData.Name = "tbSourceData";
            this.tbSourceData.Size = new System.Drawing.Size(288, 236);
            this.tbSourceData.TabIndex = 11;
            // 
            // tbDestData
            // 
            this.tbDestData.Location = new System.Drawing.Point(355, 156);
            this.tbDestData.Multiline = true;
            this.tbDestData.Name = "tbDestData";
            this.tbDestData.Size = new System.Drawing.Size(288, 236);
            this.tbDestData.TabIndex = 12;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(355, 111);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(288, 20);
            this.tbInfo.TabIndex = 13;
            // 
            // cbQuery
            // 
            this.cbQuery.AutoSize = true;
            this.cbQuery.Location = new System.Drawing.Point(661, 156);
            this.cbQuery.Name = "cbQuery";
            this.cbQuery.Size = new System.Drawing.Size(57, 17);
            this.cbQuery.TabIndex = 14;
            this.cbQuery.Text = "Query ";
            this.cbQuery.UseVisualStyleBackColor = true;
            // 
            // FormMergeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbQuery);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbDestData);
            this.Controls.Add(this.tbSourceData);
            this.Controls.Add(this.tbColumnName);
            this.Controls.Add(this.tbMammoId);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSelDest);
            this.Controls.Add(this.tbnSelSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSource);
            this.Name = "FormMergeSheet";
            this.Text = "SelectSpreadSheets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbnSelSource;
        private System.Windows.Forms.Button btnSelDest;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tbSource;
        public System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox tbMammoId;
        private System.Windows.Forms.TextBox tbColumnName;
        private System.Windows.Forms.TextBox tbSourceData;
        private System.Windows.Forms.TextBox tbDestData;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.CheckBox cbQuery;
    }
}