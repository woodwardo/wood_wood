using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class GameButton : Button
    {
        private Game gameForm;
        // button array 
        public Game GameForm { get => gameForm; set => gameForm = value; }

        public GameButton(Game gameForm, char displayLetter, int x, int y, int buttonWidth, int buttonHieght)
            :base()
        {
            this.gameForm = gameForm;
            this.Left = x;
            this.Top = y;

            this.Width = buttonWidth;
            this.Height = buttonHieght;

            this.BackColor = Color.Gray;
            this.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Text = displayLetter.ToString();

            this.Click += new EventHandler(onClick);



            //add the button to the panel on the form
            gameForm.panel1.Controls.Add(this);//add the button to the panel






        }
        public void onClick(Object sender, System.EventArgs e)
        {

            gameForm.lblGame1.Text = gameForm.lblGame1.Text + this.Text;

        }//end of onClick
    }
}
