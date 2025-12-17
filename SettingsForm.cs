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
    public partial class SettingsForm : Form
    {
        private string loggedUser;
        public SettingsForm(String user)
        {
            InitializeComponent();
            loggedUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Open MainDashboard
            MainDashboard main = new MainDashboard(loggedUser);
            main.Show();

            // Close or hide the current settings form
            this.Close(); // use Close() instead of Hide() to fully go back
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {

        }

        private void System_General_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(loggedUser);
            settings.Show();
            this.Hide();
        }

        private void Scan_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm2 settings2 = new SettingsForm2(loggedUser);
            settings2.Show();
            this.Hide();
        }

        private void Date_And_Records_Click(object sender, EventArgs e)
        {
            SettingsForm3 settings3 = new SettingsForm3(loggedUser);
            settings3.Show();
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

        private void btnLanguage_Click(object sender, EventArgs e)
        {

        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {

        }

        private void btnFileLocation_Click(object sender, EventArgs e)
        {

        }

        private void btnDataAndTime_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Button[] disabledButtons = { btnSystem, btnLanguage, btnAppearance, btnFileLocation, btnDataAndTime };

            foreach (Button btn in disabledButtons)
            {
                btn.Enabled = false;
                btn.BackColor = Color.LightGray;
                btn.Cursor = Cursors.Default;
            }
        }
    }
}
