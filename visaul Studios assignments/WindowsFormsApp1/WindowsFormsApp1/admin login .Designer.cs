namespace WindowsFormsApp1
{
    partial class admin_login
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
            this.login1 = new System.Windows.Forms.Button();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.user1 = new System.Windows.Forms.TextBox();
            this.userName1 = new System.Windows.Forms.Label();
            this.passWord1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(185, 201);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(89, 34);
            this.login1.TabIndex = 0;
            this.login1.Text = "Login";
            this.login1.UseVisualStyleBackColor = true;
            this.login1.Click += new System.EventHandler(this.login1_Click);
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(143, 159);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(167, 20);
            this.pass1.TabIndex = 1;
            this.pass1.TextChanged += new System.EventHandler(this.pass1_TextChanged);
            // 
            // user1
            // 
            this.user1.Location = new System.Drawing.Point(143, 122);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(167, 20);
            this.user1.TabIndex = 2;
            // 
            // userName1
            // 
            this.userName1.AutoSize = true;
            this.userName1.Location = new System.Drawing.Point(82, 125);
            this.userName1.Name = "userName1";
            this.userName1.Size = new System.Drawing.Size(55, 13);
            this.userName1.TabIndex = 3;
            this.userName1.Text = "Username";
            // 
            // passWord1
            // 
            this.passWord1.AutoSize = true;
            this.passWord1.Location = new System.Drawing.Point(85, 165);
            this.passWord1.Name = "passWord1";
            this.passWord1.Size = new System.Drawing.Size(53, 13);
            this.passWord1.TabIndex = 4;
            this.passWord1.Text = "Password";
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 345);
            this.Controls.Add(this.passWord1);
            this.Controls.Add(this.userName1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.login1);
            this.Name = "admin_login";
            this.Text = "admin_login";
            this.Load += new System.EventHandler(this.admin_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login1;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.TextBox user1;
        private System.Windows.Forms.Label userName1;
        private System.Windows.Forms.Label passWord1;
    }
}