namespace WindowsFormsApp1
{
    partial class admin_options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_options));
            this.edit1 = new System.Windows.Forms.Button();
            this.add1 = new System.Windows.Forms.Button();
            this.del1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richLbl1 = new System.Windows.Forms.Label();
            this.richLbl2 = new System.Windows.Forms.Label();
            this.richLbl3 = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.textBoxAddAna = new System.Windows.Forms.TextBox();
            this.textBoxAddSol = new System.Windows.Forms.TextBox();
            this.textBoxAddHint = new System.Windows.Forms.TextBox();
            this.anagramAddlbl = new System.Windows.Forms.Label();
            this.SolutionAddLbl = new System.Windows.Forms.Label();
            this.HintAddlbl = new System.Windows.Forms.Label();
            this.editLbl1 = new System.Windows.Forms.Label();
            this.editboxAna = new System.Windows.Forms.TextBox();
            this.editboxSol = new System.Windows.Forms.TextBox();
            this.editboxHint = new System.Windows.Forms.TextBox();
            this.editboxNum = new System.Windows.Forms.TextBox();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.delLbl1 = new System.Windows.Forms.Label();
            this.delbox1 = new System.Windows.Forms.TextBox();
            this.delbtn1 = new System.Windows.Forms.Button();
            this.editBtn1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(225, 242);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(75, 23);
            this.edit1.TabIndex = 0;
            this.edit1.Text = "Edit";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(144, 242);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(75, 23);
            this.add1.TabIndex = 1;
            this.add1.Text = "Add";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // del1
            // 
            this.del1.Location = new System.Drawing.Point(306, 242);
            this.del1.Name = "del1";
            this.del1.Size = new System.Drawing.Size(75, 23);
            this.del1.TabIndex = 2;
            this.del1.Text = "Delete";
            this.del1.UseVisualStyleBackColor = true;
            this.del1.Click += new System.EventHandler(this.del1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(105, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 103);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richLbl1
            // 
            this.richLbl1.AutoSize = true;
            this.richLbl1.Location = new System.Drawing.Point(114, 114);
            this.richLbl1.Name = "richLbl1";
            this.richLbl1.Size = new System.Drawing.Size(61, 13);
            this.richLbl1.TabIndex = 4;
            this.richLbl1.Text = "Ananagram";
            // 
            // richLbl2
            // 
            this.richLbl2.AutoSize = true;
            this.richLbl2.Location = new System.Drawing.Point(238, 114);
            this.richLbl2.Name = "richLbl2";
            this.richLbl2.Size = new System.Drawing.Size(45, 13);
            this.richLbl2.TabIndex = 5;
            this.richLbl2.Text = "Solution";
            // 
            // richLbl3
            // 
            this.richLbl3.AutoSize = true;
            this.richLbl3.Location = new System.Drawing.Point(346, 114);
            this.richLbl3.Name = "richLbl3";
            this.richLbl3.Size = new System.Drawing.Size(26, 13);
            this.richLbl3.TabIndex = 6;
            this.richLbl3.Text = "Hint";
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Location = new System.Drawing.Point(38, 356);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(74, 13);
            this.lblAdd1.TabIndex = 7;
            this.lblAdd1.Text = "Add new User";
            this.lblAdd1.Visible = false;
            this.lblAdd1.Click += new System.EventHandler(this.lblAdd1_Click);
            // 
            // textBoxAddAna
            // 
            this.textBoxAddAna.Location = new System.Drawing.Point(26, 372);
            this.textBoxAddAna.Name = "textBoxAddAna";
            this.textBoxAddAna.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddAna.TabIndex = 1;
            this.textBoxAddAna.Visible = false;
            this.textBoxAddAna.TextChanged += new System.EventHandler(this.textBoxAddAna_TextChanged);
            // 
            // textBoxAddSol
            // 
            this.textBoxAddSol.Location = new System.Drawing.Point(26, 399);
            this.textBoxAddSol.Name = "textBoxAddSol";
            this.textBoxAddSol.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddSol.TabIndex = 2;
            this.textBoxAddSol.Visible = false;
            this.textBoxAddSol.TextChanged += new System.EventHandler(this.textBoxAddSol_TextChanged);
            // 
            // textBoxAddHint
            // 
            this.textBoxAddHint.Location = new System.Drawing.Point(26, 426);
            this.textBoxAddHint.Name = "textBoxAddHint";
            this.textBoxAddHint.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddHint.TabIndex = 3;
            this.textBoxAddHint.Visible = false;
            this.textBoxAddHint.TextChanged += new System.EventHandler(this.textBoxAddHint_TextChanged);
            // 
            // anagramAddlbl
            // 
            this.anagramAddlbl.AutoSize = true;
            this.anagramAddlbl.Location = new System.Drawing.Point(489, 375);
            this.anagramAddlbl.Name = "anagramAddlbl";
            this.anagramAddlbl.Size = new System.Drawing.Size(49, 13);
            this.anagramAddlbl.TabIndex = 11;
            this.anagramAddlbl.Text = "Anagram";
            this.anagramAddlbl.Visible = false;
            this.anagramAddlbl.Click += new System.EventHandler(this.anagramAddlbl_Click);
            // 
            // SolutionAddLbl
            // 
            this.SolutionAddLbl.AutoSize = true;
            this.SolutionAddLbl.Location = new System.Drawing.Point(489, 402);
            this.SolutionAddLbl.Name = "SolutionAddLbl";
            this.SolutionAddLbl.Size = new System.Drawing.Size(45, 13);
            this.SolutionAddLbl.TabIndex = 12;
            this.SolutionAddLbl.Text = "Solution";
            this.SolutionAddLbl.Visible = false;
            this.SolutionAddLbl.Click += new System.EventHandler(this.SolutionAddLbl_Click);
            // 
            // HintAddlbl
            // 
            this.HintAddlbl.AutoSize = true;
            this.HintAddlbl.Location = new System.Drawing.Point(489, 429);
            this.HintAddlbl.Name = "HintAddlbl";
            this.HintAddlbl.Size = new System.Drawing.Size(26, 13);
            this.HintAddlbl.TabIndex = 13;
            this.HintAddlbl.Text = "Hint";
            this.HintAddlbl.Visible = false;
            this.HintAddlbl.Click += new System.EventHandler(this.HintAddlbl_Click);
            // 
            // editLbl1
            // 
            this.editLbl1.AutoSize = true;
            this.editLbl1.Location = new System.Drawing.Point(197, 356);
            this.editLbl1.Name = "editLbl1";
            this.editLbl1.Size = new System.Drawing.Size(68, 13);
            this.editLbl1.TabIndex = 14;
            this.editLbl1.Text = "Edit User no.";
            this.editLbl1.Visible = false;
            this.editLbl1.Click += new System.EventHandler(this.editLbl1_Click);
            // 
            // editboxAna
            // 
            this.editboxAna.Location = new System.Drawing.Point(12, 2);
            this.editboxAna.Name = "editboxAna";
            this.editboxAna.Size = new System.Drawing.Size(100, 20);
            this.editboxAna.TabIndex = 4;
            this.editboxAna.Visible = false;
            // 
            // editboxSol
            // 
            this.editboxSol.Location = new System.Drawing.Point(12, 28);
            this.editboxSol.Name = "editboxSol";
            this.editboxSol.Size = new System.Drawing.Size(100, 20);
            this.editboxSol.TabIndex = 5;
            this.editboxSol.Visible = false;
            // 
            // editboxHint
            // 
            this.editboxHint.Location = new System.Drawing.Point(12, 54);
            this.editboxHint.Name = "editboxHint";
            this.editboxHint.Size = new System.Drawing.Size(100, 20);
            this.editboxHint.TabIndex = 6;
            this.editboxHint.Visible = false;
            // 
            // editboxNum
            // 
            this.editboxNum.Location = new System.Drawing.Point(271, 349);
            this.editboxNum.Name = "editboxNum";
            this.editboxNum.Size = new System.Drawing.Size(29, 20);
            this.editboxNum.TabIndex = 18;
            this.editboxNum.Visible = false;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(41, 452);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(57, 23);
            this.addUserBtn.TabIndex = 19;
            this.addUserBtn.Text = "add ";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Visible = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // editUserBtn
            // 
            this.editUserBtn.Location = new System.Drawing.Point(28, 80);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(58, 23);
            this.editUserBtn.TabIndex = 20;
            this.editUserBtn.Text = "edit";
            this.editUserBtn.UseVisualStyleBackColor = true;
            this.editUserBtn.Visible = false;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // delLbl1
            // 
            this.delLbl1.AutoSize = true;
            this.delLbl1.Location = new System.Drawing.Point(346, 356);
            this.delLbl1.Name = "delLbl1";
            this.delLbl1.Size = new System.Drawing.Size(79, 13);
            this.delLbl1.TabIndex = 21;
            this.delLbl1.Text = "Delete user no.";
            this.delLbl1.Visible = false;
            // 
            // delbox1
            // 
            this.delbox1.Location = new System.Drawing.Point(367, 372);
            this.delbox1.Name = "delbox1";
            this.delbox1.Size = new System.Drawing.Size(30, 20);
            this.delbox1.TabIndex = 22;
            this.delbox1.Visible = false;
            this.delbox1.TextChanged += new System.EventHandler(this.delbox1_TextChanged);
            // 
            // delbtn1
            // 
            this.delbtn1.Location = new System.Drawing.Point(349, 450);
            this.delbtn1.Name = "delbtn1";
            this.delbtn1.Size = new System.Drawing.Size(58, 23);
            this.delbtn1.TabIndex = 23;
            this.delbtn1.Text = "Delete";
            this.delbtn1.UseVisualStyleBackColor = true;
            this.delbtn1.Visible = false;
            this.delbtn1.Click += new System.EventHandler(this.delbtn1_Click);
            // 
            // editBtn1
            // 
            this.editBtn1.Location = new System.Drawing.Point(306, 347);
            this.editBtn1.Name = "editBtn1";
            this.editBtn1.Size = new System.Drawing.Size(31, 23);
            this.editBtn1.TabIndex = 24;
            this.editBtn1.Text = "ok";
            this.editBtn1.UseVisualStyleBackColor = true;
            this.editBtn1.Visible = false;
            this.editBtn1.Click += new System.EventHandler(this.editBtn1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.editboxSol);
            this.pnlEdit.Controls.Add(this.editboxAna);
            this.pnlEdit.Controls.Add(this.editboxHint);
            this.pnlEdit.Controls.Add(this.editUserBtn);
            this.pnlEdit.Location = new System.Drawing.Point(200, 375);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(124, 100);
            this.pnlEdit.TabIndex = 26;
            this.pnlEdit.Visible = false;
            // 
            // admin_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 492);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editBtn1);
            this.Controls.Add(this.delbtn1);
            this.Controls.Add(this.delbox1);
            this.Controls.Add(this.delLbl1);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.editboxNum);
            this.Controls.Add(this.editLbl1);
            this.Controls.Add(this.HintAddlbl);
            this.Controls.Add(this.SolutionAddLbl);
            this.Controls.Add(this.anagramAddlbl);
            this.Controls.Add(this.textBoxAddHint);
            this.Controls.Add(this.textBoxAddSol);
            this.Controls.Add(this.textBoxAddAna);
            this.Controls.Add(this.lblAdd1);
            this.Controls.Add(this.richLbl3);
            this.Controls.Add(this.richLbl2);
            this.Controls.Add(this.richLbl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.del1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.edit1);
            this.Name = "admin_options";
            this.Text = "admin_options";
            this.Load += new System.EventHandler(this.admin_options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button del1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label richLbl1;
        private System.Windows.Forms.Label richLbl2;
        private System.Windows.Forms.Label richLbl3;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.TextBox textBoxAddAna;
        private System.Windows.Forms.TextBox textBoxAddSol;
        private System.Windows.Forms.TextBox textBoxAddHint;
        private System.Windows.Forms.Label anagramAddlbl;
        private System.Windows.Forms.Label SolutionAddLbl;
        private System.Windows.Forms.Label HintAddlbl;
        private System.Windows.Forms.Label editLbl1;
        private System.Windows.Forms.TextBox editboxAna;
        private System.Windows.Forms.TextBox editboxSol;
        private System.Windows.Forms.TextBox editboxHint;
        private System.Windows.Forms.TextBox editboxNum;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Label delLbl1;
        private System.Windows.Forms.TextBox delbox1;
        private System.Windows.Forms.Button delbtn1;
        private System.Windows.Forms.Button editBtn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlEdit;
    }
}