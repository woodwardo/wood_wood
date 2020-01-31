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
    public partial class Splash1 : Form
    {

        int counter = 6;

        public Splash1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Splash1_Load(object sender, EventArgs e)
        {

        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                tmrCountDown.Stop();//stop the timer
                Options mainForm = new Options();//create a new MainForm object
                mainForm.Show();//show the MainForm
                this.Hide(); //close this form (SplashScreen)
            }//end the if statement

        }
    }
}
