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
    public partial class SettingsForm5 : Form
    {
        private static string loggedUser;
        public SettingsForm5(String user)
        {
            InitializeComponent();
            loggedUser = user;
        }

        // Temporary variable to store the passcode (inside SettingsForm5 class)
        private string appPasscode = "";

        private void btnAppLock_Passcode_Click(object sender, EventArgs e)
        {
            // Ask user to enter a new passcode
            string newPasscode = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter a new passcode:", "Set App Lock Passcode", "");

            if (string.IsNullOrWhiteSpace(newPasscode))
            {
                MessageBox.Show("Passcode cannot be empty.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask user to confirm the passcode
            string confirmPasscode = Microsoft.VisualBasic.Interaction.InputBox(
                "Confirm your passcode:", "Confirm Passcode", "");

            if (newPasscode != confirmPasscode)
            {
                MessageBox.Show("Passcodes do not match. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Store passcode temporarily
            appPasscode = newPasscode;

            MessageBox.Show("Passcode has been successfully set.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Temporary variable to track encryption status (inside SettingsForm5 class)
        private bool isDataEncrypted = false;

        private void btnDataEncryption_Click(object sender, EventArgs e)
        {
            if (!isDataEncrypted)
            {
                // Simulate encryption process
                System.Threading.Thread.Sleep(500); // pretend processing time
                isDataEncrypted = true;
                MessageBox.Show("Data has been successfully encrypted.", "Data Encryption",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data is already encrypted.", "Data Encryption",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnPermissionManagement_Click(object sender, EventArgs e)
        {
            string currentUser = MainDashboard.GetLoggedUser();

            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("No user is currently logged in.", "Permissions",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        if (result != null)
                        {
                            string role = result.ToString();

                            if (role == "admin")
                            {
                                MessageBox.Show("You are an admin and have full permissions for all features.",
                                                "Permissions",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("You are a student.\nPermissions:\n- View Scan History\n- Access basic notifications\n- Cannot modify security or admin settings",
                                                "Permissions",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found in the database.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error connecting to the database.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearHistory_Data_Click(object sender, EventArgs e)
        {
            string currentUser = MainDashboard.GetLoggedUser();

            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("No user is currently logged in.", "Clear History",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to clear all scan history? This action cannot be undone.",
                "Confirm Clear History",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;"))
            {
                try
                {
                    connection.Open();

                    // Check if the user is admin
                    string queryRole = "SELECT password FROM students_account WHERE student_id = @student_id";
                    using (MySqlCommand cmdRole = new MySqlCommand(queryRole, connection))
                    {
                        cmdRole.Parameters.AddWithValue("@student_id", currentUser);
                        object result = cmdRole.ExecuteScalar();

                        if (result != null && result.ToString() == "admin")
                        {
                            // Simulate clearing scan history
                            string deleteQuery = "TRUNCATE TABLE scan_history";
                            using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, connection))
                            {
                                cmdDelete.ExecuteNonQuery();
                            }

                            MessageBox.Show("All scan history has been cleared successfully.", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("You do not have permission to clear scan history.", "Access Denied",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error connecting to the database.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
