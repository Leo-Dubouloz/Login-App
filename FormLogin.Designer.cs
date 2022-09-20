namespace Dashboard
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnSignUP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExitLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUP
            // 
            this.btnSignUP.BackColor = System.Drawing.Color.DarkGray;
            this.btnSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUP.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignUP.ForeColor = System.Drawing.Color.Black;
            this.btnSignUP.Location = new System.Drawing.Point(519, 358);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.Size = new System.Drawing.Size(180, 41);
            this.btnSignUP.TabIndex = 4;
            this.btnSignUP.Text = "SIGN UP";
            this.btnSignUP.UseVisualStyleBackColor = false;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.DarkGray;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(507, 174);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 21);
            this.tbName.TabIndex = 6;
            this.tbName.Text = "Your name";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.DarkGray;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(507, 236);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(207, 21);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.Text = "password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(114)))), ((int)(((byte)(49)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(519, 298);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 41);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.BackColor = System.Drawing.Color.Black;
            this.btnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitLogin.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitLogin.ForeColor = System.Drawing.Color.White;
            this.btnExitLogin.Location = new System.Drawing.Point(772, 0);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(28, 32);
            this.btnExitLogin.TabIndex = 9;
            this.btnExitLogin.Text = "x";
            this.btnExitLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExitLogin.UseVisualStyleBackColor = false;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSignUP);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSignUP;
        private PictureBox pictureBox1;
        private TextBox tbName;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnExitLogin;
    }
}