using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spapi_browser
{
    public partial class ReportViewer : UserControl
    {
        private List<SearchResultItem> previousSelection = new List<SearchResultItem>();
        private string previousFilter;
        private int previousSelectedIndex;
        private Color defaultBackColor;
        private string reportFile;
        public string ReportFile
        {
            get { return reportFile; }
            set {
                reportFile = value;
                TxtReport.Text = File.ReadAllText(reportFile);
                using (var reader = new StringReader(TxtReport.Text))
                {
                    var csvReaderConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        DetectDelimiter = true,
                        BadDataFound = null
                    };

                    using (var csv = new CsvReader(reader, csvReaderConfig))
                    {
                        var dr = new CsvDataReader(csv);
                        var dt = new DataTable();
                        dt.Load(dr);

                        DgvReport.DataSource= dt;
                    }
                }
            }
        }
        private bool isTextView = true;
        public ReportViewer()
        {
            InitializeComponent();

            TxtReport.Show();
            TxtReport.Dock = DockStyle.Fill;
            defaultBackColor = TxtReport.BackColor;

            DgvReport.Hide();
            DgvReport.Dock = DockStyle.Fill;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                TxtFilter.Focus();
                TxtFilter.SelectAll();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Enter))
            {
                FilterButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                BtnSave.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnFormat_Click(object sender, EventArgs e)
        {
            if (isTextView)
            {
                isTextView = false;
                BtnFormat.Image = Properties.Resources.icons8_data_sheet_30;

                TxtReport.Hide();
                DgvReport.Show();
            }
            else
            {
                isTextView = true;
                BtnFormat.Image = Properties.Resources.icons8_txt_30;

                TxtReport.Show();
                DgvReport.Hide();
            }
        }

        private void ResetMatch()
        {
            if (previousSelectedIndex > -1 && previousSelection.Count > previousSelectedIndex)
            {
                // Reset the previous selection color
                var found = previousSelection[previousSelectedIndex];
                TxtReport.Select(found.StartIndex, found.Length);
                TxtReport.SelectionColor = Color.Black;
                TxtReport.SelectionBackColor = Color.Yellow;
            }
        }

        private void ShowMatch()
        {
            int index = previousSelectedIndex + 1;

            int selectedIndex = 0;
            if (previousSelection.Count > index)
            {
                selectedIndex = index;
            }

            FilterButton.Text = "Filter (" + ((int)selectedIndex + 1) + "/" + previousSelection.Count + ")";

            ResetMatch();

            // Hightlight current selected index
            var found = previousSelection[selectedIndex];
            TxtReport.Select(found.StartIndex, found.Length);
            TxtReport.SelectionColor = Color.Cornsilk;
            TxtReport.SelectionBackColor = Color.Navy;

            TxtReport.ScrollToCaret();

            previousSelectedIndex = selectedIndex;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string filter = TxtFilter.Text;

            if (isTextView)
            {
                if (previousFilter == filter)
                {
                    ShowMatch();
                }
                else
                {
                    int index = 0;
                    int pointer = 0;
                    previousFilter = filter;
                    string[] keywords = previousFilter.Split(',');

                    foreach (var item in previousSelection)
                    {
                        TxtReport.Select(item.StartIndex, item.Length);
                        TxtReport.SelectionBackColor = defaultBackColor;
                    }
                    ResetMatch();
                    previousSelectedIndex = -1;
                    previousSelection.Clear();

                    foreach (string keyword in keywords)
                    {
                        while (true)
                        {
                            index = TxtReport.Text.IndexOf(keyword, pointer, StringComparison.InvariantCultureIgnoreCase);
                            if (index == -1)
                            {
                                break;
                            }

                            previousSelection.Add(new SearchResultItem() { StartIndex = index, Length = keyword.Length });
                            TxtReport.Select(index, keyword.Length);
                            TxtReport.SelectionBackColor = Color.Yellow;

                            pointer = index + keyword.Length;
                        }

                        if (previousSelection.Count > 0)
                        {
                            ShowMatch();
                        }
                        else
                        {
                            MessageBox.Show("No match found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FilterButton.Text = "Filter";
                        }
                    }
                }
            }
            else
            {
                try
                {
                    DataTable dtReport = DgvReport.DataSource as DataTable;
                    dtReport.DefaultView.RowFilter = TxtFilter.Text;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var askFilePath = new SaveFileDialog())
            {
                askFilePath.Title = "Save report to";
                askFilePath.Filter = "CSV File|*.csv|XML File|*.xml|Text File|*.txt";
                if (askFilePath.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    File.Copy(reportFile, askFilePath.FileName);
                }
            }
        }
    }
}
