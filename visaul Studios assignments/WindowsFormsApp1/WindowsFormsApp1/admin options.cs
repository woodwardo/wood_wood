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
    public partial class admin_options : Form
    {


        public admin_options()
        {
            InitializeComponent();
        }

        WordRecordings1[] wordArray = new WordRecordings1[5];
        int words1 = 0;
        int editwords1 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            //hide the delete groupbox
            lblAdd1.Visible = true;
            textBoxAddAna.Visible = true;
            textBoxAddSol.Visible = true;
            textBoxAddHint.Visible = true;
            anagramAddlbl.Visible = true;
            SolutionAddLbl.Visible = true;
            HintAddlbl.Visible = true;
            addUserBtn.Visible = true;
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            editLbl1.Visible = true;
            editboxNum.Visible = true;
            anagramAddlbl.Visible = true;
            SolutionAddLbl.Visible = true;
            HintAddlbl.Visible = true;
            editboxAna.Visible = true;
            editboxSol.Visible = true;
            editboxHint.Visible = true;
            editUserBtn.Visible = true;
            editBtn1.Visible = true;
        }

        private void admin_options_Load(object sender, EventArgs e)
        {
            addDataToForm();
        }

        private void addDataToForm()
        {
            //READ IN GAME DATA FROM TEXT FILE AND ADD TO THE ARRAY
            //string variable to store each line of text from the file
            string line = null;
            /*string array to hold the data once the line has been split into 
              separate fields using the commas*/
            string[] lineArray;


            words1 = 0;
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
                    wordArray[words1] = new WordRecordings1(lineArray[0], lineArray[1], lineArray[2]);

                    /*add 1 to numStudents so we can put the next Student at the correct 
                      position in the array*/
                    words1++;

                    // read the next line of text using the reader
                    line = reader.ReadLine();
                }//end while
                reader.Close();

                richTextBox1.Clear();
                for (int i = 0; i < words1; i++)
                {
                    //if the item at the specified index is not null
                    if (wordArray[i] != null)
                    {
                        /*Set the text of the label on the form to the text that is already there plus
                           the name and ID of the student object at index i in the array - using PadRight/PadLeft 
                           for spacing and formatting*/
                        richTextBox1.Text = richTextBox1.Text +
                                              "\n" + (i + 1).ToString() + ". "
                                                   + wordArray[i].Anagram1.PadRight(16)
                                                   + wordArray[i].Solution1.ToString().PadLeft(5)
                                                   + wordArray[i].Hint.PadRight(10);

                 
                    }//end if

                }//end for 

            }
            catch
            {	//message to inform user about error
                richTextBox1.Text = "Error in data file";
            }//catch
        }

        private void lblAdd1_Click(object sender, EventArgs e)
        {

        }

        private void SolutionAddLbl_Click(object sender, EventArgs e)
        {

        }

        private void anagramAddlbl_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddHint_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddSol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddAna_TextChanged(object sender, EventArgs e)
        {

        }

        private void HintAddlbl_Click(object sender, EventArgs e)
        {

        }

        private void editLbl1_Click(object sender, EventArgs e)
        {

        }

        private void del1_Click(object sender, EventArgs e)
        {
            delLbl1.Visible = true;
            delbox1.Visible = true;
            delbtn1.Visible = true;

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            /*create a new student object in the array at position "words1" using the data that
              the user has entered into the textboxes on the form*/
            wordArray[words1] = new WordRecordings1 (textBoxAddAna.Text, textBoxAddSol.Text, textBoxAddHint.Text);
            //add 1 to words1 in case the user decides to add another anagram
            words1++;

            //Save all records to the text file using a stream writer 
            StreamWriter writer = new StreamWriter("Game.txt");
            for (int i = 0; i < words1; i++) //loop from 0 to the words1
            {	// write the the object that will be displayed ie, anagram, solution and hint 
                writer.WriteLine("{0}, {1}, {2}", wordArray[i].Anagram1, wordArray[i].Solution1, wordArray[i].Hint);
            }//end for

            // close the stream
            writer.Close();

            addDataToForm();
            //hide the add groupbox
            lblAdd1.Visible = false;
            textBoxAddAna.Visible = false;
            textBoxAddSol.Visible = false;
            textBoxAddHint.Visible = false;
            anagramAddlbl.Visible = false;
            SolutionAddLbl.Visible = false;
            HintAddlbl.Visible = false;
            addUserBtn.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                //try to parse the number entered into the textbox to an integer
                editwords1 = Int32.Parse(editboxNum.Text);
                editwords1--; //subtract one for array numbering

                //load the selected record details (editNumber) from the arrays into the textboxes
                editboxAna.Text = wordArray[editwords1].Anagram1;
                editboxSol.Text = wordArray[editwords1].Solution1;
                editboxHint.Text = wordArray[editwords1].Hint;

                pnlEdit.Visible = true;

                
            }
            catch
            {
                MessageBox.Show("Enter a valid number");//output error message
            }
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            //Save user input (name/ID) from text boxes into the record in the array (at editNumber position) 
            wordArray[editwords1].Anagram1 = editboxAna.Text;
            wordArray[editwords1].Solution1 = editboxSol.Text;
            wordArray[editwords1].Hint = editboxHint.Text;
            


            //Save all records to the text file using a stream writer 
            StreamWriter writer = new StreamWriter("Game.txt");
            for (int i = 0; i < words1; i++) //loop from 0 to the words1
            {	// write the student object's name and ID at index i in the studentArray to the file
                writer.WriteLine("{0}, {1}, {2}", wordArray[i].Anagram1, wordArray[i].Solution1, wordArray[i].Hint);
            }//end for

            // close the stream
            writer.Close();
            addDataToForm();
            //hide the edit groupbox
            editLbl1.Visible = false;
            editboxNum.Visible = false;
            anagramAddlbl.Visible = false;
            SolutionAddLbl.Visible = false;
            HintAddlbl.Visible = false;
            editboxAna.Visible = false;
            editboxSol.Visible = false;
            editboxHint.Visible = false;
            editUserBtn.Visible = false;
            editBtn1.Visible = false;
        }

        private void delbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delbtn1_Click(object sender, EventArgs e)
        {
            int deleteNum = 0;

            try
            {
                deleteNum = Int32.Parse(delbox1.Text);//try to parse the number entered to an integer
                deleteNum--; //subtract one for array numbering


                //delete the selected record details in the array (set string values to null, int values to 0)
                wordArray[deleteNum].Anagram1= null;
                wordArray[deleteNum].Solution1 = null;
                wordArray[deleteNum].Hint = null;

                StreamWriter writer = new StreamWriter("Game.txt");
                for (int i = 0; i < words1; i++)
                {
                    //if the record is NOT null (this will ensure the deleted record is not saved to the file)
                    if (wordArray[i].Anagram1 != null)
                    {
                        // write a line of text to the file
                        writer.WriteLine("{0}, {1}, {2}", wordArray[i].Anagram1,
                                             wordArray[i].Solution1,
                                             wordArray[i].Hint);
                    }//end if
                }//end for
                // close the stream
                writer.Close();

                addDataToForm();

            }
            catch
            {
                MessageBox.Show("Enter a valid number");//output error message
            }

            //hide the delete groupbox
            delbtn1.Visible = false;
            delbox1.Visible = false;
            delLbl1.Visible = false;


        }
    }
}
