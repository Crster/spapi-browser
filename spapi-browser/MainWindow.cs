using FikaAmazonAPI;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Reports;
using FikaAmazonAPI.Utils;
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

namespace spapi_browser
{
    public partial class MainWindow : Form
    {
        private AmazonConnection amazonConnection;
        public MainWindow()
        {
            InitializeComponent();
        }

        async private void BtnViewReport_Click(object sender, EventArgs e)
        {
            if (TxtReportId.Text != String.Empty)
            {
                if (this.amazonConnection == null)
                {
                    AskAccount askAccount = new AskAccount();
                    if (askAccount.ShowDialog(this) == DialogResult.OK)
                    {
                        this.amazonConnection = new AmazonConnection(new AmazonCredential()
                        {
                            AccessKey = Properties.Settings.Default.AccessKey,
                            SecretKey = Properties.Settings.Default.SecretKey,
                            RoleArn = Properties.Settings.Default.RoleArn,
                            ClientId = Properties.Settings.Default.ClientId,
                            ClientSecret = Properties.Settings.Default.ClientSecret,
                            RefreshToken = Properties.Settings.Default.RefreshToken,
                            MarketPlace = MarketPlace.GetMarketPlaceByID(Properties.Settings.Default.MarketPlace)
                        });
                    }
                }

                if (this.amazonConnection != null)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        string reportFile = await this.amazonConnection.Reports.GetReportFileAsync(TxtReportId.Text);

                        ReportViewer reportViewer = new ReportViewer();
                        reportViewer.Dock = DockStyle.Fill;
                        reportViewer.ReportFile = reportFile;

                        TabPage newTab = new TabPage(TxtReportId.Text);
                        newTab.Controls.Add(reportViewer);

                        TabReportViewer.TabPages.Add(newTab);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Failed to download report" + Environment.NewLine + "(" + err.Message + ")", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("Account not set", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please input report id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtReportId.Focus();
            }
        }
    }
}
