namespace SDM_Assignment
{
    partial class PatientRegisterForm
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
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRefDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployment = new System.Windows.Forms.ComboBox();
            this.textBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxRefDoctor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxRefHospital = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEmployer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxOccupation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEmployerAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEmployerPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.labelRefHospital = new MaterialSkin.Controls.MaterialLabel();
            this.labelRefDoctor = new MaterialSkin.Controls.MaterialLabel();
            this.labelRefDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmployer = new MaterialSkin.Controls.MaterialLabel();
            this.labelOccupation = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmployerAddress = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmployerPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmail = new MaterialSkin.Controls.MaterialLabel();
            this.openFileRefDigitalImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxAge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(146, 136);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(252, 26);
            this.dateTimePickerDOB.TabIndex = 4;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "New patient",
            "Referral patient"});
            this.comboBoxType.Location = new System.Drawing.Point(146, 6);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(252, 28);
            this.comboBoxType.TabIndex = 9;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // dateTimePickerRefDate
            // 
            this.dateTimePickerRefDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerRefDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRefDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRefDate.Location = new System.Drawing.Point(146, 364);
            this.dateTimePickerRefDate.Name = "dateTimePickerRefDate";
            this.dateTimePickerRefDate.Size = new System.Drawing.Size(252, 26);
            this.dateTimePickerRefDate.TabIndex = 18;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(147, 202);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(252, 28);
            this.comboBoxGender.TabIndex = 30;
            // 
            // comboBoxMaritalStatus
            // 
            this.comboBoxMaritalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaritalStatus.FormattingEnabled = true;
            this.comboBoxMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Divorced"});
            this.comboBoxMaritalStatus.Location = new System.Drawing.Point(146, 168);
            this.comboBoxMaritalStatus.Name = "comboBoxMaritalStatus";
            this.comboBoxMaritalStatus.Size = new System.Drawing.Size(252, 28);
            this.comboBoxMaritalStatus.TabIndex = 31;
            // 
            // comboBoxEmployment
            // 
            this.comboBoxEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployment.FormattingEnabled = true;
            this.comboBoxEmployment.Items.AddRange(new object[] {
            "Unemployed",
            "Full-time",
            "Part-time",
            "Self employed",
            "School/College",
            "Retired"});
            this.comboBoxEmployment.Location = new System.Drawing.Point(512, 6);
            this.comboBoxEmployment.Name = "comboBoxEmployment";
            this.comboBoxEmployment.Size = new System.Drawing.Size(252, 28);
            this.comboBoxEmployment.TabIndex = 32;
            this.comboBoxEmployment.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployment_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Depth = 0;
            this.textBoxName.Hint = "";
            this.textBoxName.Location = new System.Drawing.Point(146, 43);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.Size = new System.Drawing.Size(252, 23);
            this.textBoxName.TabIndex = 33;
            this.textBoxName.TabStop = false;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Depth = 0;
            this.textBoxAddress.Hint = "";
            this.textBoxAddress.Location = new System.Drawing.Point(146, 239);
            this.textBoxAddress.MaxLength = 32767;
            this.textBoxAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.SelectionLength = 0;
            this.textBoxAddress.SelectionStart = 0;
            this.textBoxAddress.Size = new System.Drawing.Size(252, 23);
            this.textBoxAddress.TabIndex = 36;
            this.textBoxAddress.TabStop = false;
            this.textBoxAddress.UseSystemPasswordChar = false;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Depth = 0;
            this.textBoxPhoneNumber.Hint = "";
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(146, 271);
            this.textBoxPhoneNumber.MaxLength = 32767;
            this.textBoxPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.PasswordChar = '\0';
            this.textBoxPhoneNumber.SelectedText = "";
            this.textBoxPhoneNumber.SelectionLength = 0;
            this.textBoxPhoneNumber.SelectionStart = 0;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(252, 23);
            this.textBoxPhoneNumber.TabIndex = 37;
            this.textBoxPhoneNumber.TabStop = false;
            this.textBoxPhoneNumber.UseSystemPasswordChar = false;
            // 
            // textBoxRefDoctor
            // 
            this.textBoxRefDoctor.Depth = 0;
            this.textBoxRefDoctor.Hint = "";
            this.textBoxRefDoctor.Location = new System.Drawing.Point(146, 335);
            this.textBoxRefDoctor.MaxLength = 32767;
            this.textBoxRefDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRefDoctor.Name = "textBoxRefDoctor";
            this.textBoxRefDoctor.PasswordChar = '\0';
            this.textBoxRefDoctor.SelectedText = "";
            this.textBoxRefDoctor.SelectionLength = 0;
            this.textBoxRefDoctor.SelectionStart = 0;
            this.textBoxRefDoctor.Size = new System.Drawing.Size(252, 23);
            this.textBoxRefDoctor.TabIndex = 39;
            this.textBoxRefDoctor.TabStop = false;
            this.textBoxRefDoctor.UseSystemPasswordChar = false;
            // 
            // textBoxRefHospital
            // 
            this.textBoxRefHospital.Depth = 0;
            this.textBoxRefHospital.Hint = "";
            this.textBoxRefHospital.Location = new System.Drawing.Point(146, 303);
            this.textBoxRefHospital.MaxLength = 32767;
            this.textBoxRefHospital.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRefHospital.Name = "textBoxRefHospital";
            this.textBoxRefHospital.PasswordChar = '\0';
            this.textBoxRefHospital.SelectedText = "";
            this.textBoxRefHospital.SelectionLength = 0;
            this.textBoxRefHospital.SelectionStart = 0;
            this.textBoxRefHospital.Size = new System.Drawing.Size(252, 23);
            this.textBoxRefHospital.TabIndex = 40;
            this.textBoxRefHospital.TabStop = false;
            this.textBoxRefHospital.UseSystemPasswordChar = false;
            // 
            // textBoxEmployer
            // 
            this.textBoxEmployer.Depth = 0;
            this.textBoxEmployer.Hint = "";
            this.textBoxEmployer.Location = new System.Drawing.Point(512, 46);
            this.textBoxEmployer.MaxLength = 32767;
            this.textBoxEmployer.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmployer.Name = "textBoxEmployer";
            this.textBoxEmployer.PasswordChar = '\0';
            this.textBoxEmployer.SelectedText = "";
            this.textBoxEmployer.SelectionLength = 0;
            this.textBoxEmployer.SelectionStart = 0;
            this.textBoxEmployer.Size = new System.Drawing.Size(252, 23);
            this.textBoxEmployer.TabIndex = 41;
            this.textBoxEmployer.TabStop = false;
            this.textBoxEmployer.UseSystemPasswordChar = false;
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.Depth = 0;
            this.textBoxOccupation.Hint = "";
            this.textBoxOccupation.Location = new System.Drawing.Point(512, 78);
            this.textBoxOccupation.MaxLength = 32767;
            this.textBoxOccupation.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.PasswordChar = '\0';
            this.textBoxOccupation.SelectedText = "";
            this.textBoxOccupation.SelectionLength = 0;
            this.textBoxOccupation.SelectionStart = 0;
            this.textBoxOccupation.Size = new System.Drawing.Size(252, 23);
            this.textBoxOccupation.TabIndex = 42;
            this.textBoxOccupation.TabStop = false;
            this.textBoxOccupation.UseSystemPasswordChar = false;
            // 
            // textBoxEmployerAddress
            // 
            this.textBoxEmployerAddress.Depth = 0;
            this.textBoxEmployerAddress.Hint = "";
            this.textBoxEmployerAddress.Location = new System.Drawing.Point(512, 110);
            this.textBoxEmployerAddress.MaxLength = 32767;
            this.textBoxEmployerAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmployerAddress.Name = "textBoxEmployerAddress";
            this.textBoxEmployerAddress.PasswordChar = '\0';
            this.textBoxEmployerAddress.SelectedText = "";
            this.textBoxEmployerAddress.SelectionLength = 0;
            this.textBoxEmployerAddress.SelectionStart = 0;
            this.textBoxEmployerAddress.Size = new System.Drawing.Size(252, 23);
            this.textBoxEmployerAddress.TabIndex = 43;
            this.textBoxEmployerAddress.TabStop = false;
            this.textBoxEmployerAddress.UseSystemPasswordChar = false;
            // 
            // textBoxEmployerPhoneNumber
            // 
            this.textBoxEmployerPhoneNumber.Depth = 0;
            this.textBoxEmployerPhoneNumber.Hint = "";
            this.textBoxEmployerPhoneNumber.Location = new System.Drawing.Point(512, 142);
            this.textBoxEmployerPhoneNumber.MaxLength = 32767;
            this.textBoxEmployerPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmployerPhoneNumber.Name = "textBoxEmployerPhoneNumber";
            this.textBoxEmployerPhoneNumber.PasswordChar = '\0';
            this.textBoxEmployerPhoneNumber.SelectedText = "";
            this.textBoxEmployerPhoneNumber.SelectionLength = 0;
            this.textBoxEmployerPhoneNumber.SelectionStart = 0;
            this.textBoxEmployerPhoneNumber.Size = new System.Drawing.Size(252, 23);
            this.textBoxEmployerPhoneNumber.TabIndex = 44;
            this.textBoxEmployerPhoneNumber.TabStop = false;
            this.textBoxEmployerPhoneNumber.UseSystemPasswordChar = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Hint = "";
            this.textBoxEmail.Location = new System.Drawing.Point(512, 174);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.Size = new System.Drawing.Size(252, 23);
            this.textBoxEmail.TabIndex = 45;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 46;
            this.materialLabel1.Text = "Type";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 47;
            this.materialLabel2.Text = "Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 48;
            this.materialLabel3.Text = "IC/Passport";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(14, 107);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(35, 19);
            this.materialLabel4.TabIndex = 49;
            this.materialLabel4.Text = "Age";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(14, 142);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 50;
            this.materialLabel5.Text = "Date of Birth";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(14, 175);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(103, 19);
            this.materialLabel6.TabIndex = 51;
            this.materialLabel6.Text = "Marital Status";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(14, 206);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 52;
            this.materialLabel7.Text = "Gender";
            // 
            // labelRefHospital
            // 
            this.labelRefHospital.AutoSize = true;
            this.labelRefHospital.Depth = 0;
            this.labelRefHospital.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRefHospital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRefHospital.Location = new System.Drawing.Point(14, 303);
            this.labelRefHospital.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRefHospital.Name = "labelRefHospital";
            this.labelRefHospital.Size = new System.Drawing.Size(122, 19);
            this.labelRefHospital.TabIndex = 53;
            this.labelRefHospital.Text = "Referral Hospital";
            // 
            // labelRefDoctor
            // 
            this.labelRefDoctor.AutoSize = true;
            this.labelRefDoctor.Depth = 0;
            this.labelRefDoctor.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRefDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRefDoctor.Location = new System.Drawing.Point(14, 335);
            this.labelRefDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRefDoctor.Name = "labelRefDoctor";
            this.labelRefDoctor.Size = new System.Drawing.Size(111, 19);
            this.labelRefDoctor.TabIndex = 54;
            this.labelRefDoctor.Text = "Referral Doctor";
            // 
            // labelRefDate
            // 
            this.labelRefDate.AutoSize = true;
            this.labelRefDate.Depth = 0;
            this.labelRefDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRefDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRefDate.Location = new System.Drawing.Point(14, 370);
            this.labelRefDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRefDate.Name = "labelRefDate";
            this.labelRefDate.Size = new System.Drawing.Size(96, 19);
            this.labelRefDate.TabIndex = 55;
            this.labelRefDate.Text = "Referral Date";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(14, 239);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(64, 19);
            this.materialLabel11.TabIndex = 56;
            this.materialLabel11.Text = "Address";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(14, 271);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(108, 19);
            this.materialLabel12.TabIndex = 57;
            this.materialLabel12.Text = "Phone Number";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(404, 10);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(93, 19);
            this.materialLabel13.TabIndex = 58;
            this.materialLabel13.Text = "Employment";
            // 
            // labelEmployer
            // 
            this.labelEmployer.AutoSize = true;
            this.labelEmployer.Depth = 0;
            this.labelEmployer.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmployer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployer.Location = new System.Drawing.Point(405, 43);
            this.labelEmployer.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmployer.Name = "labelEmployer";
            this.labelEmployer.Size = new System.Drawing.Size(72, 19);
            this.labelEmployer.TabIndex = 59;
            this.labelEmployer.Text = "Employer";
            // 
            // labelOccupation
            // 
            this.labelOccupation.Depth = 0;
            this.labelOccupation.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOccupation.Location = new System.Drawing.Point(404, 75);
            this.labelOccupation.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(102, 19);
            this.labelOccupation.TabIndex = 0;
            this.labelOccupation.Text = "Occupation";
            // 
            // labelEmployerAddress
            // 
            this.labelEmployerAddress.Depth = 0;
            this.labelEmployerAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmployerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployerAddress.Location = new System.Drawing.Point(404, 110);
            this.labelEmployerAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmployerAddress.Name = "labelEmployerAddress";
            this.labelEmployerAddress.Size = new System.Drawing.Size(102, 19);
            this.labelEmployerAddress.TabIndex = 0;
            this.labelEmployerAddress.Text = "Employer Add";
            // 
            // labelEmployerPhoneNumber
            // 
            this.labelEmployerPhoneNumber.Depth = 0;
            this.labelEmployerPhoneNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmployerPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployerPhoneNumber.Location = new System.Drawing.Point(404, 142);
            this.labelEmployerPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmployerPhoneNumber.Name = "labelEmployerPhoneNumber";
            this.labelEmployerPhoneNumber.Size = new System.Drawing.Size(102, 19);
            this.labelEmployerPhoneNumber.TabIndex = 0;
            this.labelEmployerPhoneNumber.Text = "Office Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Depth = 0;
            this.labelEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmail.Location = new System.Drawing.Point(404, 172);
            this.labelEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 19);
            this.labelEmail.TabIndex = 60;
            this.labelEmail.Text = "Email";
            // 
            // openFileRefDigitalImage
            // 
            this.openFileRefDigitalImage.FileName = "openFileDialog1";
            this.openFileRefDigitalImage.Multiselect = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegister.Depth = 0;
            this.buttonRegister.Icon = null;
            this.buttonRegister.Location = new System.Drawing.Point(681, 396);
            this.buttonRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Primary = true;
            this.buttonRegister.Size = new System.Drawing.Size(83, 36);
            this.buttonRegister.TabIndex = 64;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Depth = 0;
            this.textBoxId.Hint = "";
            this.textBoxId.Location = new System.Drawing.Point(147, 75);
            this.textBoxId.MaxLength = 32767;
            this.textBoxId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PasswordChar = '\0';
            this.textBoxId.SelectedText = "";
            this.textBoxId.SelectionLength = 0;
            this.textBoxId.SelectionStart = 0;
            this.textBoxId.Size = new System.Drawing.Size(251, 23);
            this.textBoxId.TabIndex = 34;
            this.textBoxId.TabStop = false;
            this.textBoxId.UseSystemPasswordChar = false;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Depth = 0;
            this.textBoxAge.Hint = "";
            this.textBoxAge.Location = new System.Drawing.Point(147, 107);
            this.textBoxAge.MaxLength = 32767;
            this.textBoxAge.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.PasswordChar = '\0';
            this.textBoxAge.SelectedText = "";
            this.textBoxAge.SelectionLength = 0;
            this.textBoxAge.SelectionStart = 0;
            this.textBoxAge.Size = new System.Drawing.Size(251, 23);
            this.textBoxAge.TabIndex = 35;
            this.textBoxAge.TabStop = false;
            this.textBoxAge.UseSystemPasswordChar = false;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // PatientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelEmployerPhoneNumber);
            this.Controls.Add(this.labelEmployerAddress);
            this.Controls.Add(this.labelOccupation);
            this.Controls.Add(this.labelEmployer);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.labelRefDate);
            this.Controls.Add(this.labelRefDoctor);
            this.Controls.Add(this.labelRefHospital);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxEmployerPhoneNumber);
            this.Controls.Add(this.textBoxEmployerAddress);
            this.Controls.Add(this.textBoxOccupation);
            this.Controls.Add(this.textBoxEmployer);
            this.Controls.Add(this.textBoxRefHospital);
            this.Controls.Add(this.textBoxRefDoctor);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxEmployment);
            this.Controls.Add(this.comboBoxMaritalStatus);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePickerRefDate);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Name = "PatientRegisterForm";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePickerRefDate;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxMaritalStatus;
        private System.Windows.Forms.ComboBox comboBoxEmployment;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPhoneNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRefDoctor;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRefHospital;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmployer;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxOccupation;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmployerAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmployerPhoneNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel labelRefHospital;
        private MaterialSkin.Controls.MaterialLabel labelRefDoctor;
        private MaterialSkin.Controls.MaterialLabel labelRefDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel labelEmployer;
        private MaterialSkin.Controls.MaterialLabel labelOccupation;
        private MaterialSkin.Controls.MaterialLabel labelEmployerAddress;
        private MaterialSkin.Controls.MaterialLabel labelEmployerPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel labelEmail;
        private System.Windows.Forms.OpenFileDialog openFileRefDigitalImage;
        private MaterialSkin.Controls.MaterialRaisedButton buttonRegister;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxId;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAge;
    }
}
