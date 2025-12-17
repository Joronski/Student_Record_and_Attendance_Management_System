using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FinalsProject
{
    public partial class SettingsForm4 : Form
    {
        private string loggedUser;
        public SettingsForm4(String user)
        {
            InitializeComponent();
            loggedUser = user;
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

        // Temporary variable to store user preference (inside SettingsForm4 class)
        private string userNotificationPreference = "In-App"; // default

        private void btnDeliveryMethod_Click(object sender, EventArgs e)
        {
            // Ask user for their preferred notification method
            DialogResult result = MessageBox.Show(
                "Choose your preferred notification method:\n\n" +
                "Yes = Email\n" +
                "No = SMS\n" +
                "Cancel = In-App Notification",
                "Notification Delivery Method",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            // Store the selected preference
            switch (result)
            {
                case DialogResult.Yes:
                    userNotificationPreference = "Email";
                    break;
                case DialogResult.No:
                    userNotificationPreference = "SMS";
                    break;
                case DialogResult.Cancel:
                    userNotificationPreference = "In-App";
                    break;
            }

            // Inform the user
            MessageBox.Show(
                "Your notification preference has been set to: " + userNotificationPreference,
                "Preference Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private string userNotificationFrequency = "Immediate"; // default

        private void btnFrequency_Click(object sender, EventArgs e)
        {    // Ask user for their preferred notification frequency
            DialogResult result = MessageBox.Show(
                "Choose your preferred notification frequency:\n\n" +
                "Yes = Immediate\n" +
                "No = Daily Summary\n" +
                "Cancel = Weekly Summary",
                "Notification Frequency",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            // Store the selected frequency
            switch (result)
            {
                case DialogResult.Yes:
                    userNotificationFrequency = "Immediate";
                    break;
                case DialogResult.No:
                    userNotificationFrequency = "Daily";
                    break;
                case DialogResult.Cancel:
                    userNotificationFrequency = "Weekly";
                    break;
            }

            // Inform the user
            MessageBox.Show(
                "Your notification frequency has been set to: " + userNotificationFrequency,
                "Frequency Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btnUserPreference_Click(object sender, EventArgs e)
        {
            // Determine display values
            string delivery = string.IsNullOrEmpty(userNotificationPreference)
                                ? "Not Set"
                                : userNotificationPreference;
            string frequency = string.IsNullOrEmpty(userNotificationFrequency)
                                ? "Not Set"
                                : userNotificationFrequency;

            // Show a summary of the current notification preferences
            string summary = "Your current notification preferences are:\n\n" +
                             "Delivery Method: " + delivery + "\n" +
                             "Frequency: " + frequency;

            MessageBox.Show(summary, "User Preferences",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdminControl_Click(object sender, EventArgs e)
        {
            string currentUser = MainDashboard.GetLoggedUser();

            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("No user is currently logged in.",
                                "Access Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            
            using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;"))

            {
                try
                {
                    connection.Open();

                    string query = "SELECT password FROM students_account WHERE student_id = @student_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@student_id", currentUser);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result.ToString() == "admin")
                        {
                            // User is admin – open AdminControlForm
                            AdminControlForm adminForm = new AdminControlForm(loggedUser);
                            adminForm.StartPosition = FormStartPosition.Manual;
                            adminForm.Location = this.Location;
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You do not have permission to access this feature.",
                                            "Access Denied",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error connecting to the database.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Open MainDashboard
            MainDashboard main = new MainDashboard(loggedUser);
            main.Show();

            // Close or hide the current settings form
            this.Hide(); // use Close() instead of Hide() to fully go back
        }
    }
}
