namespace WindowsFormsApp1
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGame1 = new System.Windows.Forms.Label();
            this.lblAna = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tick1 = new System.Windows.Forms.PictureBox();
            this.cross1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.time1Left = new System.Windows.Forms.Timer(this.components);
            this.timeLeft1 = new System.Windows.Forms.Label();
            this.time2Left = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(47, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 231);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblGame1
            // 
            this.lblGame1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame1.Location = new System.Drawing.Point(115, 143);
            this.lblGame1.Name = "lblGame1";
            this.lblGame1.Size = new System.Drawing.Size(311, 42);
            this.lblGame1.TabIndex = 1;
            // 
            // lblAna
            // 
            this.lblAna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAna.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAna.Location = new System.Drawing.Point(115, 77);
            this.lblAna.Name = "lblAna";
            this.lblAna.Size = new System.Drawing.Size(311, 42);
            this.lblAna.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(450, 143);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(81, 42);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tick1
            // 
            this.tick1.Image = ((System.Drawing.Image)(resources.GetObject("tick1.Image")));
            this.tick1.Location = new System.Drawing.Point(450, 68);
            this.tick1.Name = "tick1";
            this.tick1.Size = new System.Drawing.Size(55, 50);
            this.tick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tick1.TabIndex = 4;
            this.tick1.TabStop = false;
            this.tick1.Visible = false;
            this.tick1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cross1
            // 
            this.cross1.Image = ((System.Drawing.Image)(resources.GetObject("cross1.Image")));
            this.cross1.Location = new System.Drawing.Point(511, 68);
            this.cross1.Name = "cross1";
            this.cross1.Size = new System.Drawing.Size(55, 50);
            this.cross1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cross1.TabIndex = 5;
            this.cross1.TabStop = false;
            this.cross1.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(142, 446);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(44, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score : ";
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(193, 446);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(13, 13);
            this.lblUserScore.TabIndex = 7;
            this.lblUserScore.Text = "0";
            // 
            // time1Left
            // 
            this.time1Left.Enabled = true;
            this.time1Left.Interval = 1000;
            this.time1Left.Tick += new System.EventHandler(this.time1Left_Tick);
            // 
            // timeLeft1
            // 
            this.timeLeft1.AutoSize = true;
            this.timeLeft1.Location = new System.Drawing.Point(12, 20);
            this.timeLeft1.Name = "timeLeft1";
            this.timeLeft1.Size = new System.Drawing.Size(86, 13);
            this.timeLeft1.TabIndex = 8;
            this.timeLeft1.Text = "Time Remaining ";
            // 
            // time2Left
            // 
            this.time2Left.AutoSize = true;
            this.time2Left.Location = new System.Drawing.Point(35, 50);
            this.time2Left.Name = "time2Left";
            this.time2Left.Size = new System.Drawing.Size(13, 13);
            this.time2Left.TabIndex = 9;
            this.time2Left.Text = "0";
            this.time2Left.Click += new System.EventHandler(this.time2Left_Click);
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(17, 143);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(81, 42);
            this.btnHint.TabIndex = 10;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.time2Left);
            this.Controls.Add(this.timeLeft1);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.cross1);
            this.Controls.Add(this.tick1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAna);
            this.Controls.Add(this.lblGame1);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblGame1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblAna;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox tick1;
        private System.Windows.Forms.PictureBox cross1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblUserScore;
        public System.Windows.Forms.Timer time1Left;
        private System.Windows.Forms.Label timeLeft1;
        private System.Windows.Forms.Label time2Left;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}