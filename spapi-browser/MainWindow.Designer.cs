namespace spapi_browser
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TabReportViewer = new System.Windows.Forms.TabControl();
            this.LblInputReportId = new System.Windows.Forms.Label();
            this.TxtReportId = new System.Windows.Forms.TextBox();
            this.BtnViewReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TabReportViewer
            // 
            this.TabReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabReportViewer.Location = new System.Drawing.Point(12, 32);
            this.TabReportViewer.Name = "TabReportViewer";
            this.TabReportViewer.SelectedIndex = 0;
            this.TabReportViewer.Size = new System.Drawing.Size(781, 407);
            this.TabReportViewer.TabIndex = 4;
            // 
            // LblInputReportId
            // 
            this.LblInputReportId.AutoSize = true;
            this.LblInputReportId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInputReportId.Location = new System.Drawing.Point(13, 9);
            this.LblInputReportId.Name = "LblInputReportId";
            this.LblInputReportId.Size = new System.Drawing.Size(99, 13);
            this.LblInputReportId.TabIndex = 5;
            this.LblInputReportId.Text = "Input Report ID:";
            // 
            // TxtReportId
            // 
            this.TxtReportId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReportId.Location = new System.Drawing.Point(118, 6);
            this.TxtReportId.Name = "TxtReportId";
            this.TxtReportId.Size = new System.Drawing.Size(522, 20);
            this.TxtReportId.TabIndex = 6;
            // 
            // BtnViewReport
            // 
            this.BtnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViewReport.Location = new System.Drawing.Point(646, 4);
            this.BtnViewReport.Name = "BtnViewReport";
            this.BtnViewReport.Size = new System.Drawing.Size(147, 23);
            this.BtnViewReport.TabIndex = 7;
            this.BtnViewReport.Text = "View Report";
            this.BtnViewReport.UseVisualStyleBackColor = true;
            this.BtnViewReport.Click += new System.EventHandler(this.BtnViewReport_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.BtnViewReport);
            this.Controls.Add(this.TxtReportId);
            this.Controls.Add(this.LblInputReportId);
            this.Controls.Add(this.TabReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabReportViewer;
        private System.Windows.Forms.Label LblInputReportId;
        private System.Windows.Forms.TextBox TxtReportId;
        private System.Windows.Forms.Button BtnViewReport;
    }
}

