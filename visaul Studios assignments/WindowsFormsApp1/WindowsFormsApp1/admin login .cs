using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void pass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login1_Click(object sender, EventArgs e)
        {
            String userName = user1.Text;
            String passWord = pass1.Text;


            if (userName.ToUpper() == "SWCADMIN" && passWord == "sWc123")
            {
                admin_options adminForm = new admin_options();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and/or Password");
                user1.Clear();
                pass1.Text = String.Empty;
            }
        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }
    }
}
