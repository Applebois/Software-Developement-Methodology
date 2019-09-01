namespace SDM_Assignment
{
    partial class NewPatientRecord
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
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDoctorName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPatientName = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxStartDateTime = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSearchDoctor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.searchDoctorForm = new SDM_Assignment.SearchDoctorForm();
            this.buttonNewPatientRecord = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(16, 15);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(56, 36);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(198, 238);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(110, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Start DateTime";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(198, 188);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "Doctor";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(198, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Patient";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Depth = 0;
            this.textBoxDoctorName.Hint = "";
            this.textBoxDoctorName.Location = new System.Drawing.Point(326, 188);
            this.textBoxDoctorName.MaxLength = 32767;
            this.textBoxDoctorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.PasswordChar = '\0';
            this.textBoxDoctorName.SelectedText = "";
            this.textBoxDoctorName.SelectionLength = 0;
            this.textBoxDoctorName.SelectionStart = 0;
            this.textBoxDoctorName.Size = new System.Drawing.Size(140, 23);
            this.textBoxDoctorName.TabIndex = 26;
            this.textBoxDoctorName.TabStop = false;
            this.textBoxDoctorName.UseSystemPasswordChar = false;
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.AutoSize = true;
            this.textBoxPatientName.Depth = 0;
            this.textBoxPatientName.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxPatientName.Location = new System.Drawing.Point(322, 138);
            this.textBoxPatientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(0, 19);
            this.textBoxPatientName.TabIndex = 27;
            // 
            // textBoxStartDateTime
            // 
            this.textBoxStartDateTime.AutoSize = true;
            this.textBoxStartDateTime.Depth = 0;
            this.textBoxStartDateTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxStartDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxStartDateTime.Location = new System.Drawing.Point(322, 238);
            this.textBoxStartDateTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxStartDateTime.Name = "textBoxStartDateTime";
            this.textBoxStartDateTime.Size = new System.Drawing.Size(0, 19);
            this.textBoxStartDateTime.TabIndex = 28;
            // 
            // buttonSearchDoctor
            // 
            this.buttonSearchDoctor.AutoSize = true;
            this.buttonSearchDoctor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchDoctor.Depth = 0;
            this.buttonSearchDoctor.Icon = null;
            this.buttonSearchDoctor.Location = new System.Drawing.Point(481, 180);
            this.buttonSearchDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchDoctor.Name = "buttonSearchDoctor";
            this.buttonSearchDoctor.Primary = true;
            this.buttonSearchDoctor.Size = new System.Drawing.Size(131, 36);
            this.buttonSearchDoctor.TabIndex = 29;
            this.buttonSearchDoctor.Text = "Search Doctor";
            this.buttonSearchDoctor.UseVisualStyleBackColor = true;
            this.buttonSearchDoctor.Click += new System.EventHandler(this.buttonSearchDoctor_Click);
            // 
            // searchDoctorForm
            // 
            this.searchDoctorForm.BackColor = System.Drawing.Color.White;
            this.searchDoctorForm.Location = new System.Drawing.Point(0, 0);
            this.searchDoctorForm.Name = "searchDoctorForm";
            this.searchDoctorForm.Size = new System.Drawing.Size(778, 449);
            this.searchDoctorForm.TabIndex = 30;
            // 
            // buttonNewPatientRecord
            // 
            this.buttonNewPatientRecord.AutoSize = true;
            this.buttonNewPatientRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewPatientRecord.Depth = 0;
            this.buttonNewPatientRecord.Icon = null;
            this.buttonNewPatientRecord.Location = new System.Drawing.Point(691, 399);
            this.buttonNewPatientRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewPatientRecord.Name = "buttonNewPatientRecord";
            this.buttonNewPatientRecord.Primary = true;
            this.buttonNewPatientRecord.Size = new System.Drawing.Size(71, 36);
            this.buttonNewPatientRecord.TabIndex = 31;
            this.buttonNewPatientRecord.Text = "Create";
            this.buttonNewPatientRecord.UseVisualStyleBackColor = true;
            // 
            // NewPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchDoctorForm);
            this.Controls.Add(this.buttonSearchDoctor);
            this.Controls.Add(this.textBoxStartDateTime);
            this.Controls.Add(this.textBoxPatientName);
            this.Controls.Add(this.textBoxDoctorName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.buttonNewPatientRecord);
            this.Name = "NewPatientRecord";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDoctorName;
        private MaterialSkin.Controls.MaterialLabel textBoxPatientName;
        private MaterialSkin.Controls.MaterialLabel textBoxStartDateTime;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchDoctor;
        private SearchDoctorForm searchDoctorForm;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonNewPatientRecord;
    }
}
