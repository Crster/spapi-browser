namespace spapi_browser
{
    partial class ReportViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvReport = new System.Windows.Forms.DataGridView();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnFormat = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.GroupBox();
            this.TxtReport = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvReport
            // 
            this.DgvReport.AllowUserToAddRows = false;
            this.DgvReport.AllowUserToDeleteRows = false;
            this.DgvReport.AllowUserToOrderColumns = true;
            this.DgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReport.Location = new System.Drawing.Point(6, 19);
            this.DgvReport.Name = "DgvReport";
            this.DgvReport.ReadOnly = true;
            this.DgvReport.Size = new System.Drawing.Size(226, 135);
            this.DgvReport.TabIndex = 0;
            // 
            // TxtFilter
            // 
            this.TxtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFilter.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFilter.Location = new System.Drawing.Point(3, 8);
            this.TxtFilter.Multiline = true;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(398, 36);
            this.TxtFilter.TabIndex = 1;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(407, 7);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(89, 39);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Image = global::spapi_browser.Properties.Resources.icons8_download_from_cloud_30;
            this.BtnSave.Location = new System.Drawing.Point(573, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(48, 39);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnFormat
            // 
            this.BtnFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFormat.Image = global::spapi_browser.Properties.Resources.icons8_txt_30;
            this.BtnFormat.Location = new System.Drawing.Point(519, 7);
            this.BtnFormat.Name = "BtnFormat";
            this.BtnFormat.Size = new System.Drawing.Size(48, 39);
            this.BtnFormat.TabIndex = 3;
            this.BtnFormat.UseVisualStyleBackColor = true;
            this.BtnFormat.Click += new System.EventHandler(this.BtnFormat_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMain.Controls.Add(this.TxtReport);
            this.PanelMain.Controls.Add(this.DgvReport);
            this.PanelMain.Location = new System.Drawing.Point(3, 52);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(618, 328);
            this.PanelMain.TabIndex = 5;
            this.PanelMain.TabStop = false;
            // 
            // TxtReport
            // 
            this.TxtReport.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReport.Location = new System.Drawing.Point(6, 160);
            this.TxtReport.Name = "TxtReport";
            this.TxtReport.ReadOnly = true;
            this.TxtReport.Size = new System.Drawing.Size(226, 136);
            this.TxtReport.TabIndex = 1;
            this.TxtReport.Text = "";
            this.TxtReport.WordWrap = false;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnFormat);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.TxtFilter);
            this.Name = "ReportViewer";
            this.Size = new System.Drawing.Size(627, 383);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReport;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button BtnFormat;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox PanelMain;
        private System.Windows.Forms.RichTextBox TxtReport;
    }
}
