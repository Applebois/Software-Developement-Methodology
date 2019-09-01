namespace SDM_Assignment
{
    partial class LoginForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonForgetPassword = new MaterialSkin.Controls.MaterialRaisedButton();
            this.secretQuestion = new SDM_Assignment.SecretQuestion();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Depth = 0;
            this.textBoxUsername.Hint = "";
            this.textBoxUsername.Location = new System.Drawing.Point(333, 190);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.SelectionLength = 0;
            this.textBoxUsername.SelectionStart = 0;
            this.textBoxUsername.Size = new System.Drawing.Size(182, 23);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.TabStop = false;
            this.textBoxUsername.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(333, 233);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(182, 23);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(226, 233);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 18);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Password:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(454, 294);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = true;
            this.buttonLogin.Size = new System.Drawing.Size(61, 36);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(226, 190);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(81, 18);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Username:";
            // 
            // buttonForgetPassword
            // 
            this.buttonForgetPassword.AutoSize = true;
            this.buttonForgetPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonForgetPassword.Depth = 0;
            this.buttonForgetPassword.Icon = null;
            this.buttonForgetPassword.Location = new System.Drawing.Point(230, 294);
            this.buttonForgetPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonForgetPassword.Name = "buttonForgetPassword";
            this.buttonForgetPassword.Primary = true;
            this.buttonForgetPassword.Size = new System.Drawing.Size(149, 36);
            this.buttonForgetPassword.TabIndex = 11;
            this.buttonForgetPassword.Text = "Forget Password";
            this.buttonForgetPassword.UseVisualStyleBackColor = true;
            this.buttonForgetPassword.Click += new System.EventHandler(this.buttonForgetPassword_Click);
            // 
            // secretQuestion
            // 
            this.secretQuestion.Location = new System.Drawing.Point(0, 0);
            this.secretQuestion.Name = "secretQuestion";
            this.secretQuestion.Size = new System.Drawing.Size(782, 498);
            this.secretQuestion.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secretQuestion);
            this.Controls.Add(this.buttonForgetPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(782, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxUsername;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private MaterialSkin.Controls.MaterialRaisedButton buttonForgetPassword;
        private SecretQuestion secretQuestion;
    }
}
