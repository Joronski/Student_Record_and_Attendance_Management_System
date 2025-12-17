using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalsProject
{
    public partial class ScanForm : Form
    {
        String con = "";
        private string loggedUser;

        public ScanForm(string user)
        {
            InitializeComponent();
            loggedUser = user;

            this.Load += ScanForm_Load;

        }

        private void ScanForm_Load(object sender, EventArgs e)
        {
            GenerateQR(loggedUser);
        }

        private void GenerateQR(string studentId)
        {
            con = "Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;";
            string studentName = GetStudentName(studentId);
            string qrContent = $"Student ID: {studentId}\nName: {studentName}";

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrImage = qrCode.GetGraphic(20);

                    // Display QR code
                    pictureBoxQR.Image = qrImage;
                }
            }
        }

        private string GetStudentName(string studentId)
        {
            string name = null;

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name FROM students_account WHERE student_id=@studentId LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            name = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }

            return name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Open Main Dashboard form
            MainDashboard frmMain = new MainDashboard(loggedUser);
            frmMain.Show();

            // Hide Student Record form
            this.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;";
            string studentId = loggedUser;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // First get student name
                    string getNameQuery = "SELECT name FROM students_account WHERE student_id=@id LIMIT 1";
                    string studentName = "";

                    using (MySqlCommand cmd = new MySqlCommand(getNameQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            studentName = result.ToString();
                    }

                    // Insert into scan_history Table
                    string insertQuery =
                        "INSERT INTO scan_history (name, student_id, date, transaction) VALUES (" +
                        "'" + studentName + "', " +
                        "'" + studentId + "', " +
                        "NOW(), " +
                        "'Attendance'" +
                        ")";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Attendance recorded successfully!");


                    // Move to Scan History Form
                    ScanHistory history = new ScanHistory(loggedUser);
                    history.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving attendance:\n" + ex.Message);
                }
            }
        }
    }
}