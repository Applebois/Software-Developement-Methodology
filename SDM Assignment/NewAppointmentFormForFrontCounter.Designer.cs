namespace SDM_Assignment
{
    partial class NewAppointmentFormForFrontCounter
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
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPatient = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxDoctor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxAppointmentDuration = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSearchDoctor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonSearchPatient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonNewAppointment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSearchMachine = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.searchDoctorForm = new SDM_Assignment.SearchDoctorForm();
            this.searchPatientForm = new SDM_Assignment.SearchPatientForm();
            this.searchMachineForm = new SDM_Assignment.SearchMachineForm();
            this.SuspendLayout();
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dateTimePickerAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(157, 34);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerAppointmentDate.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "DateTime";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(26, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(41, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Type";
            // 
            // comboBoxAppointmentType
            // 
            this.comboBoxAppointmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAppointmentType.FormattingEnabled = true;
            this.comboBoxAppointmentType.Items.AddRange(new object[] {
            "Doctor Consultation",
            "Digital Imaging Service"});
            this.comboBoxAppointmentType.Location = new System.Drawing.Point(157, 64);
            this.comboBoxAppointmentType.Name = "comboBoxAppointmentType";
            this.comboBoxAppointmentType.Size = new System.Drawing.Size(200, 26);
            this.comboBoxAppointmentType.TabIndex = 3;
            this.comboBoxAppointmentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppointmentType_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(26, 109);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Patient";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(26, 151);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Doctor";
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Depth = 0;
            this.textBoxPatient.Hint = "";
            this.textBoxPatient.Location = new System.Drawing.Point(157, 109);
            this.textBoxPatient.MaxLength = 32767;
            this.textBoxPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.PasswordChar = '\0';
            this.textBoxPatient.SelectedText = "";
            this.textBoxPatient.SelectionLength = 0;
            this.textBoxPatient.SelectionStart = 0;
            this.textBoxPatient.Size = new System.Drawing.Size(200, 23);
            this.textBoxPatient.TabIndex = 6;
            this.textBoxPatient.TabStop = false;
            this.textBoxPatient.UseSystemPasswordChar = false;
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.Depth = 0;
            this.textBoxDoctor.Hint = "";
            this.textBoxDoctor.Location = new System.Drawing.Point(157, 151);
            this.textBoxDoctor.MaxLength = 32767;
            this.textBoxDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.PasswordChar = '\0';
            this.textBoxDoctor.SelectedText = "";
            this.textBoxDoctor.SelectionLength = 0;
            this.textBoxDoctor.SelectionStart = 0;
            this.textBoxDoctor.Size = new System.Drawing.Size(200, 23);
            this.textBoxDoctor.TabIndex = 7;
            this.textBoxDoctor.TabStop = false;
            this.textBoxDoctor.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(26, 196);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(127, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Est.Duration(min)";
            // 
            // textBoxAppointmentDuration
            // 
            this.textBoxAppointmentDuration.Depth = 0;
            this.textBoxAppointmentDuration.Hint = "";
            this.textBoxAppointmentDuration.Location = new System.Drawing.Point(157, 192);
            this.textBoxAppointmentDuration.MaxLength = 32767;
            this.textBoxAppointmentDuration.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAppointmentDuration.Name = "textBoxAppointmentDuration";
            this.textBoxAppointmentDuration.PasswordChar = '\0';
            this.textBoxAppointmentDuration.SelectedText = "";
            this.textBoxAppointmentDuration.SelectionLength = 0;
            this.textBoxAppointmentDuration.SelectionStart = 0;
            this.textBoxAppointmentDuration.Size = new System.Drawing.Size(200, 23);
            this.textBoxAppointmentDuration.TabIndex = 11;
            this.textBoxAppointmentDuration.TabStop = false;
            this.textBoxAppointmentDuration.UseSystemPasswordChar = false;
            this.textBoxAppointmentDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAppointmentDuration_KeyPress);
            // 
            // buttonSearchDoctor
            // 
            this.buttonSearchDoctor.AutoSize = true;
            this.buttonSearchDoctor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchDoctor.Depth = 0;
            this.buttonSearchDoctor.Icon = null;
            this.buttonSearchDoctor.Location = new System.Drawing.Point(376, 138);
            this.buttonSearchDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchDoctor.Name = "buttonSearchDoctor";
            this.buttonSearchDoctor.Primary = true;
            this.buttonSearchDoctor.Size = new System.Drawing.Size(131, 36);
            this.buttonSearchDoctor.TabIndex = 9;
            this.buttonSearchDoctor.Text = "Search Doctor";
            this.buttonSearchDoctor.UseVisualStyleBackColor = true;
            this.buttonSearchDoctor.Click += new System.EventHandler(this.buttonSearchDoctor_Click);
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.AutoSize = true;
            this.buttonSearchPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchPatient.Depth = 0;
            this.buttonSearchPatient.Icon = null;
            this.buttonSearchPatient.Location = new System.Drawing.Point(376, 96);
            this.buttonSearchPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Primary = true;
            this.buttonSearchPatient.Size = new System.Drawing.Size(133, 36);
            this.buttonSearchPatient.TabIndex = 8;
            this.buttonSearchPatient.Text = "Search Patient";
            this.buttonSearchPatient.UseVisualStyleBackColor = true;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonSearchPatient_Click);
            // 
            // buttonNewAppointment
            // 
            this.buttonNewAppointment.AutoSize = true;
            this.buttonNewAppointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewAppointment.Depth = 0;
            this.buttonNewAppointment.Icon = null;
            this.buttonNewAppointment.Location = new System.Drawing.Point(689, 398);
            this.buttonNewAppointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewAppointment.Name = "buttonNewAppointment";
            this.buttonNewAppointment.Primary = true;
            this.buttonNewAppointment.Size = new System.Drawing.Size(71, 36);
            this.buttonNewAppointment.TabIndex = 12;
            this.buttonNewAppointment.Text = "Create";
            this.buttonNewAppointment.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(26, 237);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Machine";
            // 
            // textBoxMachineId
            // 
            this.textBoxMachineId.Depth = 0;
            this.textBoxMachineId.Hint = "";
            this.textBoxMachineId.Location = new System.Drawing.Point(157, 233);
            this.textBoxMachineId.MaxLength = 32767;
            this.textBoxMachineId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineId.Name = "textBoxMachineId";
            this.textBoxMachineId.PasswordChar = '\0';
            this.textBoxMachineId.SelectedText = "";
            this.textBoxMachineId.SelectionLength = 0;
            this.textBoxMachineId.SelectionStart = 0;
            this.textBoxMachineId.Size = new System.Drawing.Size(200, 23);
            this.textBoxMachineId.TabIndex = 16;
            this.textBoxMachineId.TabStop = false;
            this.textBoxMachineId.UseSystemPasswordChar = false;
            // 
            // buttonSearchMachine
            // 
            this.buttonSearchMachine.AutoSize = true;
            this.buttonSearchMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchMachine.Depth = 0;
            this.buttonSearchMachine.Icon = null;
            this.buttonSearchMachine.Location = new System.Drawing.Point(376, 220);
            this.buttonSearchMachine.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchMachine.Name = "buttonSearchMachine";
            this.buttonSearchMachine.Primary = true;
            this.buttonSearchMachine.Size = new System.Drawing.Size(138, 36);
            this.buttonSearchMachine.TabIndex = 17;
            this.buttonSearchMachine.Text = "Search Machine";
            this.buttonSearchMachine.UseVisualStyleBackColor = true;
            this.buttonSearchMachine.Click += new System.EventHandler(this.buttonSearchMachine_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(25, 277);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Comment";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Depth = 0;
            this.textBoxComment.Hint = "";
            this.textBoxComment.Location = new System.Drawing.Point(157, 277);
            this.textBoxComment.MaxLength = 32767;
            this.textBoxComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.PasswordChar = '\0';
            this.textBoxComment.SelectedText = "";
            this.textBoxComment.SelectionLength = 0;
            this.textBoxComment.SelectionStart = 0;
            this.textBoxComment.Size = new System.Drawing.Size(200, 23);
            this.textBoxComment.TabIndex = 20;
            this.textBoxComment.TabStop = false;
            this.textBoxComment.UseSystemPasswordChar = false;
            // 
            // searchDoctorForm
            // 
            this.searchDoctorForm.BackColor = System.Drawing.Color.White;
            this.searchDoctorForm.Location = new System.Drawing.Point(0, 0);
            this.searchDoctorForm.Name = "searchDoctorForm";
            this.searchDoctorForm.Size = new System.Drawing.Size(778, 449);
            this.searchDoctorForm.TabIndex = 13;
            // 
            // searchPatientForm
            // 
            this.searchPatientForm.BackColor = System.Drawing.Color.White;
            this.searchPatientForm.Location = new System.Drawing.Point(0, 0);
            this.searchPatientForm.Name = "searchPatientForm";
            this.searchPatientForm.Size = new System.Drawing.Size(778, 449);
            this.searchPatientForm.TabIndex = 14;
            // 
            // searchMachineForm
            // 
            this.searchMachineForm.Location = new System.Drawing.Point(0, 0);
            this.searchMachineForm.Name = "searchMachineForm";
            this.searchMachineForm.Size = new System.Drawing.Size(778, 449);
            this.searchMachineForm.TabIndex = 18;
            // 
            // NewAppointmentFormForFrontCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchMachineForm);
            this.Controls.Add(this.searchPatientForm);
            this.Controls.Add(this.searchDoctorForm);
            this.Controls.Add(this.buttonSearchMachine);
            this.Controls.Add(this.textBoxMachineId);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.buttonNewAppointment);
            this.Controls.Add(this.textBoxAppointmentDuration);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.buttonSearchDoctor);
            this.Controls.Add(this.buttonSearchPatient);
            this.Controls.Add(this.textBoxDoctor);
            this.Controls.Add(this.textBoxPatient);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboBoxAppointmentType);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePickerAppointmentDate);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.textBoxComment);
            this.Name = "NewAppointmentFormForFrontCounter";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPatient;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDoctor;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchDoctor;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchPatient;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonNewAppointment;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxMachineId;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchMachine;
        internal System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxAppointmentDuration;
        internal System.Windows.Forms.ComboBox comboBoxAppointmentType;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxComment;
        private SearchDoctorForm searchDoctorForm;
        private SearchPatientForm searchPatientForm;
        private SearchMachineForm searchMachineForm;
    }
}
