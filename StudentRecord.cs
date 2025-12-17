using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
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
    public partial class StudentRecord : Form
    {
        String con = "";
        private string loggedUser;
        public StudentRecord(string user)
        {
            InitializeComponent();
            con = "Server=127.0.0.1;Port=3307;Database=student_db;User=root;Password=;";
            loggedUser = user;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if any input is empty
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtScore.Text) ||
                string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please fill in all fields before submitting.");
                return;
            }

            // Inserting data
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand(); command.Connection = connection;
            try
            {
                command.CommandText =
                    "INSERT INTO students (name, student_id, score, grade) VALUES (" +
                    "'" + txtName.Text + "', " +
                    "'" + txtStudentID.Text + "', " +
                    txtScore.Text + ", " +
                    txtGrade.Text + ")";
                command.ExecuteNonQuery(); MessageBox.Show("Data has been successfully recorded!");

                // Clear User Input
                txtName.Text = "";
                txtStudentID.Text = "";
                txtScore.Text = "";
                txtGrade.Text = "";
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }

            // Display Table
            try
            {
                // Table Visible
                panelTable.Visible = true;
                panelForm.Visible = false;

                // Functions
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * From students";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                // Header Name
                dataGridView1.Columns["student_number"].HeaderText = "Log #";
                dataGridView1.Columns["name"].HeaderText = "Name";
                dataGridView1.Columns["student_id"].HeaderText = "ID";
                dataGridView1.Columns["score"].HeaderText = "Score";
                dataGridView1.Columns["grade"].HeaderText = "Grade";
            }
            catch (Exception z)
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Table Visible
            panelTable.Visible = false;
            panelForm.Visible = true;
        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(con);

            // Display Table
            try
            {
                // Table Visible
                panelTable.Visible = true;
                panelForm.Visible = false;

                // Functions
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * From students";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                // Header Name
                dataGridView1.Columns["student_number"].HeaderText = "Log #";
                dataGridView1.Columns["name"].HeaderText = "Name";
                dataGridView1.Columns["student_id"].HeaderText = "ID";
                dataGridView1.Columns["score"].HeaderText = "Score";
                dataGridView1.Columns["grade"].HeaderText = "Grade";
            }
            catch (Exception z)
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
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
