namespace WindowsFormsApp1
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.admin1 = new System.Windows.Forms.Button();
            this.start1 = new System.Windows.Forms.Button();
            this.ext1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin1
            // 
            this.admin1.Location = new System.Drawing.Point(6, 33);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(122, 40);
            this.admin1.TabIndex = 5;
            this.admin1.Text = "Admin Login";
            this.admin1.UseVisualStyleBackColor = true;
            this.admin1.Click += new System.EventHandler(this.admin1_Click);
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(6, 427);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(105, 40);
            this.start1.TabIndex = 4;
            this.start1.Text = "Start";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            // 
            // ext1
            // 
            this.ext1.Location = new System.Drawing.Point(530, 430);
            this.ext1.Name = "ext1";
            this.ext1.Size = new System.Drawing.Size(120, 37);
            this.ext1.TabIndex = 3;
            this.ext1.Text = "Exit";
            this.ext1.UseVisualStyleBackColor = true;
            this.ext1.Click += new System.EventHandler(this.ext1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.ext1);
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin1;
        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.Button ext1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}