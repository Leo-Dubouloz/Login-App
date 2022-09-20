namespace Dashboard
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNameRegister = new System.Windows.Forms.TextBox();
            this.btnNewSignUp = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnExitSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbNameRegister
            // 
            this.tbNameRegister.BackColor = System.Drawing.Color.DarkGray;
            this.tbNameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNameRegister.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNameRegister.ForeColor = System.Drawing.Color.White;
            this.tbNameRegister.Location = new System.Drawing.Point(507, 174);
            this.tbNameRegister.Name = "tbNameRegister";
            this.tbNameRegister.Size = new System.Drawing.Size(207, 21);
            this.tbNameRegister.TabIndex = 1;
            this.tbNameRegister.Text = "Your name";
            this.tbNameRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNameRegister.Enter += new System.EventHandler(this.tbNameRegister_Enter);
            this.tbNameRegister.Leave += new System.EventHandler(this.tbNameRegister_Leave);
            // 
            // btnNewSignUp
            // 
            this.btnNewSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(114)))), ((int)(((byte)(49)))));
            this.btnNewSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSignUp.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSignUp.ForeColor = System.Drawing.Color.White;
            this.btnNewSignUp.Location = new System.Drawing.Point(519, 298);
            this.btnNewSignUp.Name = "btnNewSignUp";
            this.btnNewSignUp.Size = new System.Drawing.Size(180, 41);
            this.btnNewSignUp.TabIndex = 2;
            this.btnNewSignUp.Text = "SIGN UP";
            this.btnNewSignUp.UseVisualStyleBackColor = false;
            this.btnNewSignUp.Click += new System.EventHandler(this.btnNewSignUp_Click);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BackColor = System.Drawing.Color.DarkGray;
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPassword.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNewPassword.ForeColor = System.Drawing.Color.White;
            this.tbNewPassword.Location = new System.Drawing.Point(507, 236);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(207, 21);
            this.tbNewPassword.TabIndex = 3;
            this.tbNewPassword.Text = "Your password";
            this.tbNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNewPassword.Enter += new System.EventHandler(this.tbNewPassword_Enter);
            this.tbNewPassword.Leave += new System.EventHandler(this.tbNewPassword_Leave);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(519, 358);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(180, 41);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnExitSignIn
            // 
            this.btnExitSignIn.BackColor = System.Drawing.Color.Black;
            this.btnExitSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitSignIn.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitSignIn.ForeColor = System.Drawing.Color.White;
            this.btnExitSignIn.Location = new System.Drawing.Point(772, 0);
            this.btnExitSignIn.Name = "btnExitSignIn";
            this.btnExitSignIn.Size = new System.Drawing.Size(28, 32);
            this.btnExitSignIn.TabIndex = 10;
            this.btnExitSignIn.Text = "x";
            this.btnExitSignIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExitSignIn.UseVisualStyleBackColor = false;
            this.btnExitSignIn.Click += new System.EventHandler(this.btnExitSignIn_Click);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitSignIn);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.btnNewSignUp);
            this.Controls.Add(this.tbNameRegister);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbNameRegister;
        private Button btnNewSignUp;
        private TextBox tbNewPassword;
        private Button btnSignIn;
        private Button btnExitSignIn;
    }
}