using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spapi_browser
{
    public partial class AskAccount : Form
    {
        public AskAccount()
        {
            InitializeComponent();
        }
        
        private void AskAccount_Load(object sender, EventArgs e)
        {
            this.AccessKey.Text = Properties.Settings.Default.AccessKey;
            this.SecretKey.Text = Properties.Settings.Default.SecretKey;
            this.RoleArn.Text = Properties.Settings.Default.RoleArn;
            this.ClientId.Text = Properties.Settings.Default.ClientId;
            this.ClientSecret.Text = Properties.Settings.Default.ClientSecret;
            this.RefreshToken.Text = Properties.Settings.Default.RefreshToken;
            this.MarketPlace.Text = Properties.Settings.Default.MarketPlace;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccessKey = this.AccessKey.Text;
            Properties.Settings.Default.SecretKey = this.SecretKey.Text;
            Properties.Settings.Default.RoleArn = this.RoleArn.Text;
            Properties.Settings.Default.ClientId = this.ClientId.Text;
            Properties.Settings.Default.ClientSecret = this.ClientSecret.Text;
            Properties.Settings.Default.RefreshToken = this.RefreshToken.Text;
            Properties.Settings.Default.MarketPlace = this.MarketPlace.Text;

            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
