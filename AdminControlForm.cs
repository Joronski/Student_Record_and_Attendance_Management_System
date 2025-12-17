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
    public partial class AdminControlForm : Form
    {
        private string loggedUser;
        public AdminControlForm(String user)
        {
            InitializeComponent();
            loggedUser = user;
        }

        private void AdminControlForm_Load(object sender, EventArgs e)
        {
            // This is a blank form for admin controls.
            // You can later add features like managing users, resetting passwords, etc.
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(loggedUser);
            settings.Show();
            this.Close();
        }
    }
}
