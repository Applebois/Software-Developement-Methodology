namespace SDM_Assignment
{
    partial class ResetPassword
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
            this.textBoxConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Depth = 0;
            this.textBoxConfirmPassword.Hint = "";
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(366, 227);
            this.textBoxConfirmPassword.MaxLength = 32767;
            this.textBoxConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.SelectedText = "";
            this.textBoxConfirmPassword.SelectionLength = 0;
            this.textBoxConfirmPassword.SelectionStart = 0;
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(187, 23);
            this.textBoxConfirmPassword.TabIndex = 18;
            this.textBoxConfirmPassword.TabStop = false;
            this.textBoxConfirmPassword.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(366, 198);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(187, 23);
            this.textBoxPassword.TabIndex = 17;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(225, 227);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(133, 19);
            this.materialLabel15.TabIndex = 16;
            this.materialLabel15.Text = "Confirm Password";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(225, 198);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(75, 19);
            this.materialLabel14.TabIndex = 15;
            this.materialLabel14.Text = "Password";
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReset.Depth = 0;
            this.buttonReset.Icon = null;
            this.buttonReset.Location = new System.Drawing.Point(697, 438);
            this.buttonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Primary = true;
            this.buttonReset.Size = new System.Drawing.Size(62, 36);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.materialLabel14);
            this.Name = "ResetPassword";
            this.Size = new System.Drawing.Size(782, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonReset;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxConfirmPassword;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
    }
}
