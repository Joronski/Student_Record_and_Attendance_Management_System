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
    public partial class SettingsForm3 : Form
    {
        private string loggedUser;
        public SettingsForm3(String user)
        {
            InitializeComponent();
            loggedUser = user;
        }
        private void label1_Click(object sender, EventArgs e)
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

        private void btnDataStorage_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult confirm = MessageBox.Show(
                "Open phpMyAdmin to manage the student database?",
                "Open Database",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            // 2. Attempt to open phpMyAdmin
            try
            {
                var url = "http://localhost/phpmyadmin/index.php?route=/database/structure&db=student_db";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // required for browser launching
                });
            }
            catch (Exception ex)
            {
                // 3. Fallback message
                MessageBox.Show(
                    "Failed to open phpMyAdmin. Make sure Apache/MySQL (XAMPP) are running.\n\nError: " + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRecordManagement_Click(object sender, EventArgs e)
        {
            StudentRecord recordForm = new StudentRecord(loggedUser);
            recordForm.Show();
            this.Hide();
        }

        private void btnDataRetentionPolicy_Click(object sender, EventArgs e)
        {
            string policy = "Data Retention Policy:\n\n" +
                "All student records and scan history are securely stored in the system.\n" +
                "Records are retained for a period of 1 year from the date of creation.\n" +
                "After this period, data will be automatically archived or deleted in accordance with privacy standards.\n\n" +
                "Access to student data is strictly controlled and only authorized personnel can view or modify records.";

            MessageBox.Show(policy, "Data Retention Policy",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAuditTrail_Click(object sender, EventArgs e)
        {
            string currentUser = MainDashboard.GetLoggedUser();

            if (!string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("Currently logged in user: " + currentUser,
                                "Audit Trail",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No user is currently logged in.",
                                "Audit Trail",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
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
