namespace SDM_Assignment
{
    partial class NewAppointmentFormForDoctor
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
            this.buttonSearchMachine = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxMachineId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonNewAppointment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxAppointmentDuration = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSearchPatient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxPatient = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.searchPatientForm = new SDM_Assignment.SearchPatientForm();
            this.searchMachineForm = new SDM_Assignment.SearchMachineForm();
            this.SuspendLayout();
            // 
            // buttonSearchMachine
            // 
            this.buttonSearchMachine.AutoSize = true;
            this.buttonSearchMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchMachine.Depth = 0;
            this.buttonSearchMachine.Icon = null;
            this.buttonSearchMachine.Location = new System.Drawing.Point(373, 169);
            this.buttonSearchMachine.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchMachine.Name = "buttonSearchMachine";
            this.buttonSearchMachine.Primary = true;
            this.buttonSearchMachine.Size = new System.Drawing.Size(138, 36);
            this.buttonSearchMachine.TabIndex = 36;
            this.buttonSearchMachine.Text = "Search Machine";
            this.buttonSearchMachine.UseVisualStyleBackColor = true;
            this.buttonSearchMachine.Click += new System.EventHandler(this.buttonSearchMachine_Click);
            // 
            // textBoxMachineId
            // 
            this.textBoxMachineId.Depth = 0;
            this.textBoxMachineId.Hint = "";
            this.textBoxMachineId.Location = new System.Drawing.Point(154, 182);
            this.textBoxMachineId.MaxLength = 32767;
            this.textBoxMachineId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineId.Name = "textBoxMachineId";
            this.textBoxMachineId.PasswordChar = '\0';
            this.textBoxMachineId.SelectedText = "";
            this.textBoxMachineId.SelectionLength = 0;
            this.textBoxMachineId.SelectionStart = 0;
            this.textBoxMachineId.Size = new System.Drawing.Size(200, 23);
            this.textBoxMachineId.TabIndex = 35;
            this.textBoxMachineId.TabStop = false;
            this.textBoxMachineId.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(23, 186);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 34;
            this.materialLabel6.Text = "Machine";
            // 
            // buttonNewAppointment
            // 
            this.buttonNewAppointment.AutoSize = true;
            this.buttonNewAppointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewAppointment.Depth = 0;
            this.buttonNewAppointment.Icon = null;
            this.buttonNewAppointment.Location = new System.Drawing.Point(686, 388);
            this.buttonNewAppointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewAppointment.Name = "buttonNewAppointment";
            this.buttonNewAppointment.Primary = true;
            this.buttonNewAppointment.Size = new System.Drawing.Size(71, 36);
            this.buttonNewAppointment.TabIndex = 33;
            this.buttonNewAppointment.Text = "Create";
            this.buttonNewAppointment.UseVisualStyleBackColor = true;
            // 
            // textBoxAppointmentDuration
            // 
            this.textBoxAppointmentDuration.Depth = 0;
            this.textBoxAppointmentDuration.Hint = "";
            this.textBoxAppointmentDuration.Location = new System.Drawing.Point(154, 141);
            this.textBoxAppointmentDuration.MaxLength = 32767;
            this.textBoxAppointmentDuration.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAppointmentDuration.Name = "textBoxAppointmentDuration";
            this.textBoxAppointmentDuration.PasswordChar = '\0';
            this.textBoxAppointmentDuration.SelectedText = "";
            this.textBoxAppointmentDuration.SelectionLength = 0;
            this.textBoxAppointmentDuration.SelectionStart = 0;
            this.textBoxAppointmentDuration.Size = new System.Drawing.Size(200, 23);
            this.textBoxAppointmentDuration.TabIndex = 32;
            this.textBoxAppointmentDuration.TabStop = false;
            this.textBoxAppointmentDuration.UseSystemPasswordChar = false;
            this.textBoxAppointmentDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAppointmentDuration_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(23, 145);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(127, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Est.Duration(min)";
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.AutoSize = true;
            this.buttonSearchPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchPatient.Depth = 0;
            this.buttonSearchPatient.Icon = null;
            this.buttonSearchPatient.Location = new System.Drawing.Point(373, 86);
            this.buttonSearchPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Primary = true;
            this.buttonSearchPatient.Size = new System.Drawing.Size(133, 36);
            this.buttonSearchPatient.TabIndex = 29;
            this.buttonSearchPatient.Text = "Search Patient";
            this.buttonSearchPatient.UseVisualStyleBackColor = true;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonSearchPatient_Click);
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Depth = 0;
            this.textBoxPatient.Hint = "";
            this.textBoxPatient.Location = new System.Drawing.Point(154, 99);
            this.textBoxPatient.MaxLength = 32767;
            this.textBoxPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.PasswordChar = '\0';
            this.textBoxPatient.SelectedText = "";
            this.textBoxPatient.SelectionLength = 0;
            this.textBoxPatient.SelectionStart = 0;
            this.textBoxPatient.Size = new System.Drawing.Size(200, 23);
            this.textBoxPatient.TabIndex = 27;
            this.textBoxPatient.TabStop = false;
            this.textBoxPatient.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 99);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Patient";
            // 
            // comboBoxAppointmentType
            // 
            this.comboBoxAppointmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAppointmentType.FormattingEnabled = true;
            this.comboBoxAppointmentType.Items.AddRange(new object[] {
            "Doctor Consultation",
            "Digital Imaging Service"});
            this.comboBoxAppointmentType.Location = new System.Drawing.Point(154, 54);
            this.comboBoxAppointmentType.Name = "comboBoxAppointmentType";
            this.comboBoxAppointmentType.Size = new System.Drawing.Size(200, 26);
            this.comboBoxAppointmentType.TabIndex = 24;
            this.comboBoxAppointmentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppointmentType_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(41, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Type";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "DateTime";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dateTimePickerAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(154, 24);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerAppointmentDate.TabIndex = 21;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(22, 226);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 19);
            this.materialLabel7.TabIndex = 37;
            this.materialLabel7.Text = "Comment";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Depth = 0;
            this.textBoxComment.Hint = "";
            this.textBoxComment.Location = new System.Drawing.Point(154, 226);
            this.textBoxComment.MaxLength = 32767;
            this.textBoxComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.PasswordChar = '\0';
            this.textBoxComment.SelectedText = "";
            this.textBoxComment.SelectionLength = 0;
            this.textBoxComment.SelectionStart = 0;
            this.textBoxComment.Size = new System.Drawing.Size(200, 23);
            this.textBoxComment.TabIndex = 38;
            this.textBoxComment.TabStop = false;
            this.textBoxComment.UseSystemPasswordChar = false;
            // 
            // searchPatientForm
            // 
            this.searchPatientForm.BackColor = System.Drawing.Color.White;
            this.searchPatientForm.Location = new System.Drawing.Point(0, 0);
            this.searchPatientForm.Name = "searchPatientForm";
            this.searchPatientForm.Size = new System.Drawing.Size(778, 449);
            this.searchPatientForm.TabIndex = 39;
            // 
            // searchMachineForm
            // 
            this.searchMachineForm.Location = new System.Drawing.Point(0, 0);
            this.searchMachineForm.Name = "searchMachineForm";
            this.searchMachineForm.Size = new System.Drawing.Size(778, 449);
            this.searchMachineForm.TabIndex = 40;
            // 
            // NewAppointmentFormForDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchMachineForm);
            this.Controls.Add(this.searchPatientForm);
            this.Controls.Add(this.buttonSearchMachine);
            this.Controls.Add(this.textBoxMachineId);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.buttonNewAppointment);
            this.Controls.Add(this.textBoxAppointmentDuration);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.buttonSearchPatient);
            this.Controls.Add(this.textBoxPatient);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboBoxAppointmentType);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePickerAppointmentDate);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.textBoxComment);
            this.Name = "NewAppointmentFormForDoctor";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchMachine;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxMachineId;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonNewAppointment;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxAppointmentDuration;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchPatient;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPatient;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        internal System.Windows.Forms.ComboBox comboBoxAppointmentType;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        internal System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxComment;
        private SearchPatientForm searchPatientForm;
        private SearchMachineForm searchMachineForm;
    }
}
