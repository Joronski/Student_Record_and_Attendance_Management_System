using MySqlConnector;
using System.Data;

namespace FinalsProject
{
    public partial class LoginForm : Form
    {
        String con = "";
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            con = "Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;";
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Connection: " + ex.Message + "\nExit and try again.");
                this.Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult confirm = MessageBox.Show(
                    "Exit application?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (studentId == "" || password == "")
            {
                MessageBox.Show("Please enter Student ID and Password.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                // Find student account
                string query = "SELECT * FROM students_account WHERE student_id = @student_id AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login Successful!");

                        // Clear Text
                        txtStudentID.Text = "";
                        txtPassword.Text = "";

                        // Open Main Dashboard form
                        MainDashboard frmMain = new MainDashboard(studentId);
                        frmMain.Show();

                        // Hide Login form
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student ID or Password.");
                    }

                    connection.Close();
                }
            }
        }
    }
}