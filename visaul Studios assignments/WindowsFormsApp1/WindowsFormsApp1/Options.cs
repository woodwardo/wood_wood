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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void start1_Click(object sender, EventArgs e)
        {
            Game gameForm = new Game();//create a new MainForm object
            gameForm.Show();//show the MainForm
            this.Hide(); //close this form (SplashScreen)
        }

        private void admin1_Click(object sender, EventArgs e)
        {
            admin_login adminForm = new admin_login();
            adminForm.Show();
            this.Hide();
        }

        private void ext1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
