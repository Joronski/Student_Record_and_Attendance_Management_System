using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsProject
{
    public partial class SettingsForm2 : Form
    {
        private string loggedUser;
        public SettingsForm2(String user)
        {
            InitializeComponent();
            loggedUser = user;
        }
        private void SettingsForm2_Load(object sender, EventArgs e)
        {
            Button[] disabledButtons = { btnAutoScan, btnFlashlight, btnVibrateOnScan };

            foreach (Button btn in disabledButtons)
            {
                btn.Enabled = false;
                btn.BackColor = Color.LightGray;
                btn.Cursor = Cursors.Default;
            }
        }

        private void Date_And_Records_Click(object sender, EventArgs e)
        {
            SettingsForm3 settings3 = new SettingsForm3(loggedUser);
            settings3.Show();
            this.Hide();
        }

        private void Scan_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm2 settings2 = new SettingsForm2(loggedUser);
            settings2.Show();
            this.Hide();
        }

        private void btnAutoScan_Click(object sender, EventArgs e)
        {

        }

        private void System_General_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(loggedUser);
            settings.Show();
            this.Hide();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            SettingsForm4 settings4 = new SettingsForm4(loggedUser);
            settings4.Show();
            this.Hide();
        }

        private void Security_And_Privacy_Click(object sender, EventArgs e)
        {
            SettingsForm5 settings5 = new SettingsForm5(loggedUser);
            settings5.Show();
            this.Hide();
        }

        private void btnFlashlight_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveScanHistory_Click(object sender, EventArgs e)
        {
            //ScanHistory historyForm = new ScanHistory(loggedUser);
            //historyForm.SaveHistory();

            MessageBox.Show("Scan History has been successfully saved!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVibrateOnScan_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Open MainDashboard
            MainDashboard main = new MainDashboard(loggedUser);
            main.Show();

            // Close or hide the current settings form
            this.Close(); // use Close() instead of Hide() to fully go back
        }
    }
}
