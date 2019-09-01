namespace SDM_Assignment
{
    partial class fmcMainForm
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
            this.technicianMainMenu = new SDM_Assignment.TechnicianMainMenu();
            this.doctorMainMenu = new SDM_Assignment.DoctorMainMenu();
            this.frontCounterMainMenu = new SDM_Assignment.FrontCounterMainMenu();
            this.itManagerMainMenu = new SDM_Assignment.ITManagerMainMenu();
            this.loginForm = new SDM_Assignment.LoginForm();
            this.SuspendLayout();
            // 
            // technicianMainMenu
            // 
            this.technicianMainMenu.Location = new System.Drawing.Point(0, 63);
            this.technicianMainMenu.Name = "technicianMainMenu";
            this.technicianMainMenu.Size = new System.Drawing.Size(784, 498);
            this.technicianMainMenu.TabIndex = 6;
            // 
            // doctorMainMenu
            // 
            this.doctorMainMenu.Location = new System.Drawing.Point(0, 63);
            this.doctorMainMenu.Name = "doctorMainMenu";
            this.doctorMainMenu.Size = new System.Drawing.Size(784, 498);
            this.doctorMainMenu.TabIndex = 5;
            // 
            // frontCounterMainMenu
            // 
            this.frontCounterMainMenu.Location = new System.Drawing.Point(0, 63);
            this.frontCounterMainMenu.Name = "frontCounterMainMenu";
            this.frontCounterMainMenu.Size = new System.Drawing.Size(784, 498);
            this.frontCounterMainMenu.TabIndex = 4;
            // 
            // itManagerMainMenu
            // 
            this.itManagerMainMenu.Location = new System.Drawing.Point(0, 63);
            this.itManagerMainMenu.Name = "itManagerMainMenu";
            this.itManagerMainMenu.Size = new System.Drawing.Size(784, 498);
            this.itManagerMainMenu.TabIndex = 1;
            // 
            // loginForm
            // 
            this.loginForm.Location = new System.Drawing.Point(0, 63);
            this.loginForm.Name = "loginForm";
            this.loginForm.Size = new System.Drawing.Size(782, 498);
            this.loginForm.TabIndex = 0;
            // 
            // fmcMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.technicianMainMenu);
            this.Controls.Add(this.doctorMainMenu);
            this.Controls.Add(this.frontCounterMainMenu);
            this.Controls.Add(this.itManagerMainMenu);
            this.Controls.Add(this.loginForm);
            this.KeyPreview = true;
            this.Name = "fmcMainForm";
            this.Text = "Forest Medical Center System";
            this.Load += new System.EventHandler(this.fmcMainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmcMainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fmcMainForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginForm loginForm;
        private ITManagerMainMenu itManagerMainMenu;
        private FrontCounterMainMenu frontCounterMainMenu;
        private DoctorMainMenu doctorMainMenu;
        private TechnicianMainMenu technicianMainMenu;
    }
}

