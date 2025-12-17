using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FinalsProject
{
    public partial class ScanHistory : Form
    {
        private string loggedUser;
        public ScanHistory(String user)
        {
            InitializeComponent();
            loggedUser = user;

            // Hook up the refresh button click event
            btnRefresh.Click += BtnRefresh_Click;
        }

        private void ScanHistory_Load(object sender, EventArgs e)
        {
            LoadScanHistory();
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadScanHistory(); // reload data when button is clicked
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

                    dataTable.DataSource = table;
                    dataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Style the Status column green
                    if (dataTable.Columns.Contains("Status"))
                    {
                        dataTable.Columns["Status"].DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading scan history:\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Optional: handle cell clicks if needed
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Example: show clicked cell value
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string value = dataTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
                MessageBox.Show("You clicked: " + value);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open Main Dashboard form
            MainDashboard frmMain = new MainDashboard(loggedUser);
            frmMain.Show();

            // Hide Student Record form
            this.Close();
        }
    }
}