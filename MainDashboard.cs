using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalsProject
{
    public partial class MainDashboard : Form
    {
        private static string loggedUser;

        public MainDashboard(string user)
        {
            InitializeComponent();
            loggedUser = user;

            this.Load += MainDashboard_Load;
        }

        public static string GetLoggedUser()
        {
            return loggedUser;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            LoadScanHistory(); // load database into DataGridView
        }

        private void LoadScanHistory()
        {
            string connectionString = "Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;";

            string query = @"
                SELECT 
                    name AS 'Name',
                    student_id AS 'Student ID',
                    DATE_FORMAT(date, '%m-%d-%Y %h:%i %p') AS 'Date & Time',
                    transaction AS 'Transaction'
                FROM scan_history
                ORDER BY date DESC";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    guna2DataGridView1.DataSource = table;
                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading scan history:\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string value = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
                MessageBox.Show("You clicked: " + value);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScanForm scan = new ScanForm(loggedUser);
            scan.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentRecord record = new StudentRecord(loggedUser);
            record.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScanHistory history = new ScanHistory(loggedUser);
            history.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettingsForm settings = new SettingsForm(loggedUser);
            settings.Show();
            this.Hide();
        }
    }
}