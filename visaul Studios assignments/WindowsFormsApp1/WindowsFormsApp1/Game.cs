using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        GameButton[] btnArray = new GameButton[26];
        WordRecordings1[] wordArray = new WordRecordings1[5];
        int words1 = 0;
        int gameanagram = 0;
        bool tick = true;
        bool cross = true;
        int counter = 120;
        private void Game_Load(object sender, EventArgs e)
        {
            //SET UP BUTTONS
            //get the height of the button (we need 5 rows of buttons in the panel)
            int buttonHeight = this.panel1.Height / 6;
            //get the height of the button (we need 5 columns of buttons in the panel)
            int buttonWidth = this.panel1.Width / 5;
            //int number = 1; //the number to be displayed for the calculator
            char letter = 'A';
            int x = 0, y = 0;//co-ordinates of the button

            // Create (25) GameButtons for the Calculator 
            for (int i = 0; i < btnArray.Length; i++)
            {
                //first button
                if (i == 0)
                {
                    x = 0; //set the x co-ordinate for the first button
                }
                //add the GameButton to a new row (new row for 5th, 10th, 15th and 20th number)
                else if (i == 5 || i == 10 || i == 15 || i == 20 || i == 26) // Location of next line of buttons (after 3, 6 and 9)
                {
                    x = 0;//start at the left side of panel
                    y = y + buttonHeight;//go to next line
                }
                else if (i == 25)
                {
                    x = buttonWidth * 2;//start at the middle of panel
                    y = y + buttonHeight;//go to next line
                }

                else //add the GameButton to the same row
                {
                    x = x + buttonWidth;//add next GameButton on same row 
                }//end if

                //create the GameButtons object in the array of buttons
                btnArray[i] = new GameButton(this, letter, x, y, buttonWidth, buttonHeight);
                letter++;//add one to number to be displayed on the GameButton
            } //end for

            //READ IN GAME DATA FROM TEXT FILE AND ADD TO THE ARRAY
            //string variable to store each line of text from the file
            string line = null;
            /*string array to hold the data once the line has been split into 
              separate fields using the commas*/
            string[] lineArray;

            

            try		//When loading lineArray from file, errors such as file not found may occur
            {
                // create reader & open file
                StreamReader reader = new StreamReader("Game.txt");

                // read a line of text from the file using the reader
                line = reader.ReadLine();

                //1.  READ IN THE DATA FROM THE TEXT FILE (LINE_BY_LINE) AND STORE IN THE STUDENT ARRAY
                while (line != null)//while the line exists it is not null (empty)
                {
                    /*split the line read into the lineArray variable (the array of strings)
                    using the comma character as separator*/
                    lineArray = line.Split(',');
                    //create the object in the array at  position
                    wordArray[words1] = new WordRecordings1  (lineArray[0],lineArray[1], lineArray[2]);

                    /*add 1 to numStudents so we can put the next Student at the correct 
                      position in the array*/
                    words1++;

                    // read the next line of text using the reader
                    line = reader.ReadLine();
                }//end while

            }
            catch
            {	//message to inform user about error
                lblGame1.Text = "Error in data file";
            }//catch

            //display an anagram on form
            lblAna.Text = wordArray[gameanagram].Anagram1;
        }

            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int score = 0;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //if the text that the user has entered on the label lblAna is equal to the anagram displayed Solution property
            if (lblGame1.Text.Trim().Equals(wordArray[gameanagram].Solution1.Trim()))
            {
                tick1.Visible = true;
                cross1.Visible = false;




                //add 1 to score
                score++;
                //update score label
                lblUserScore.Text = score.ToString();
                //add 1 to gameanagram
                gameanagram++;
                //display an anagram on form
                lblAna.Text = wordArray[gameanagram].Anagram1;
                lblGame1.Text = String.Empty;
                //else
            } else 
                    {
                //show a symbol to the user to tell them their answer was incorrect
                tick1.Visible = false;
                cross1.Visible = true;

                //clear user's label
                lblGame1.Text = String.Empty;
            }




          
           

              

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void time2Left_Click(object sender, EventArgs e)
        {

        }

        private void time1Left_Tick(object sender, EventArgs e)
        {
            counter--;//take one away from the counter (represents the number of seconds)
            time2Left.Text = counter.ToString();//update the label on the form
            //if the time has run out (counter has reached zero)
            if (counter == 0)
            {
                //stop the timer
                time1Left.Stop();
                //ask the user do they want to play again using messagebox
                DialogResult dialogResult = MessageBox.Show("Would you like to play again?", "Play Again", MessageBoxButtons.YesNo);
                //if the user has selected Yes
                if (dialogResult == DialogResult.Yes)
                {
                    //reset the counter
                    counter = 120;
                    //update the label
                    time2Left.Text = counter.ToString();
                    //restart the timer
                    time1Left.Start();

                    //clear score label 
                    lblUserScore.Text = String.Empty;
                    //clear input label

                    //display the next anagram

                }
                else //if the user has selected No
                {
                    //output a message to the user
                    MessageBox.Show("Thanks for playing!");
                    //exit the application
                    Application.Exit();
                }//end if
            }//end if
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wordArray[gameanagram].Hint);
        }
    }
}

