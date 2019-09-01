namespace SDM_Assignment
{
    partial class ITManagerMainMenu
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.ITManagerMainMenuTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabViewAccount = new System.Windows.Forms.TabPage();
            this.listViewListAccount = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDisplayName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxActive = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabRegisterAccount = new System.Windows.Forms.TabPage();
            this.buttonRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxRegisterConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxRegisterPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxRegisterUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxRegisterDisplayName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxRegisterActive = new System.Windows.Forms.ComboBox();
            this.comboBoxRegisterRole = new System.Windows.Forms.ComboBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tabMachine = new System.Windows.Forms.TabPage();
            this.viewMachineDetailForAdministrator = new SDM_Assignment.ViewMachineDetailForAdministrator();
            this.viewMachineListForAdministrator = new SDM_Assignment.SearchMachineForm();
            this.tabNewMachine = new System.Windows.Forms.TabPage();
            this.newMachineForAdministrator1 = new SDM_Assignment.NewMachineForAdministrator();
            this.tabAppointment = new System.Windows.Forms.TabPage();
            this.viewAppointmentByTimeForAdministrator = new SDM_Assignment.ViewAppointmentByTimeForAdministrator();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.viewPatientDetailForAdministrator = new SDM_Assignment.ViewPatientDetailForAdministrator();
            this.viewPatientListForAdministrator = new SDM_Assignment.SearchPatientForm();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxFirstAnswer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxSecondAnswer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxThirdAnswer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxFirstQuestion = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondQuestion = new System.Windows.Forms.ComboBox();
            this.comboBoxThirdQuestion = new System.Windows.Forms.ComboBox();
            this.ITManagerMainMenuTab.SuspendLayout();
            this.tabViewAccount.SuspendLayout();
            this.tabRegisterAccount.SuspendLayout();
            this.tabMachine.SuspendLayout();
            this.tabNewMachine.SuspendLayout();
            this.tabAppointment.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.ITManagerMainMenuTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(782, 30);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // ITManagerMainMenuTab
            // 
            this.ITManagerMainMenuTab.Controls.Add(this.tabViewAccount);
            this.ITManagerMainMenuTab.Controls.Add(this.tabRegisterAccount);
            this.ITManagerMainMenuTab.Controls.Add(this.tabMachine);
            this.ITManagerMainMenuTab.Controls.Add(this.tabNewMachine);
            this.ITManagerMainMenuTab.Controls.Add(this.tabAppointment);
            this.ITManagerMainMenuTab.Controls.Add(this.tabPatient);
            this.ITManagerMainMenuTab.Depth = 0;
            this.ITManagerMainMenuTab.Location = new System.Drawing.Point(0, 28);
            this.ITManagerMainMenuTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.ITManagerMainMenuTab.Name = "ITManagerMainMenuTab";
            this.ITManagerMainMenuTab.SelectedIndex = 0;
            this.ITManagerMainMenuTab.Size = new System.Drawing.Size(782, 470);
            this.ITManagerMainMenuTab.TabIndex = 1;
            this.ITManagerMainMenuTab.SelectedIndexChanged += new System.EventHandler(this.ITManagerMainMenuTab_SelectedIndexChanged);
            // 
            // tabViewAccount
            // 
            this.tabViewAccount.BackColor = System.Drawing.Color.White;
            this.tabViewAccount.Controls.Add(this.listViewListAccount);
            this.tabViewAccount.Controls.Add(this.buttonReset);
            this.tabViewAccount.Controls.Add(this.buttonUpdate);
            this.tabViewAccount.Controls.Add(this.textBoxConfirmPassword);
            this.tabViewAccount.Controls.Add(this.textBoxPassword);
            this.tabViewAccount.Controls.Add(this.materialLabel8);
            this.tabViewAccount.Controls.Add(this.materialLabel7);
            this.tabViewAccount.Controls.Add(this.materialLabel6);
            this.tabViewAccount.Controls.Add(this.textBoxDisplayName);
            this.tabViewAccount.Controls.Add(this.textBoxUsername);
            this.tabViewAccount.Controls.Add(this.comboBoxActive);
            this.tabViewAccount.Controls.Add(this.comboBoxRole);
            this.tabViewAccount.Controls.Add(this.materialLabel5);
            this.tabViewAccount.Controls.Add(this.materialLabel4);
            this.tabViewAccount.Controls.Add(this.materialLabel3);
            this.tabViewAccount.Controls.Add(this.materialLabel2);
            this.tabViewAccount.Controls.Add(this.materialLabel1);
            this.tabViewAccount.Location = new System.Drawing.Point(4, 22);
            this.tabViewAccount.Name = "tabViewAccount";
            this.tabViewAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAccount.Size = new System.Drawing.Size(774, 444);
            this.tabViewAccount.TabIndex = 0;
            this.tabViewAccount.Text = "View Accounts";
            // 
            // listViewListAccount
            // 
            this.listViewListAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewListAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewListAccount.Depth = 0;
            this.listViewListAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewListAccount.FullRowSelect = true;
            this.listViewListAccount.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListAccount.HideSelection = false;
            this.listViewListAccount.Location = new System.Drawing.Point(-4, 228);
            this.listViewListAccount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewListAccount.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewListAccount.Name = "listViewListAccount";
            this.listViewListAccount.OwnerDraw = true;
            this.listViewListAccount.Size = new System.Drawing.Size(782, 222);
            this.listViewListAccount.TabIndex = 18;
            this.listViewListAccount.UseCompatibleStateImageBehavior = false;
            this.listViewListAccount.View = System.Windows.Forms.View.Details;
            this.listViewListAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewListAccount_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Display Name";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Role";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lock";
            this.columnHeader5.Width = 70;
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReset.Depth = 0;
            this.buttonReset.Icon = null;
            this.buttonReset.Location = new System.Drawing.Point(428, 186);
            this.buttonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Primary = true;
            this.buttonReset.Size = new System.Drawing.Size(62, 36);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdate.Depth = 0;
            this.buttonUpdate.Icon = null;
            this.buttonUpdate.Location = new System.Drawing.Point(32, 186);
            this.buttonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Primary = true;
            this.buttonUpdate.Size = new System.Drawing.Size(73, 36);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Depth = 0;
            this.textBoxConfirmPassword.Hint = "";
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(543, 71);
            this.textBoxConfirmPassword.MaxLength = 32767;
            this.textBoxConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.SelectedText = "";
            this.textBoxConfirmPassword.SelectionLength = 0;
            this.textBoxConfirmPassword.SelectionStart = 0;
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(187, 23);
            this.textBoxConfirmPassword.TabIndex = 15;
            this.textBoxConfirmPassword.TabStop = false;
            this.textBoxConfirmPassword.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(543, 42);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(187, 23);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(402, 75);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(133, 19);
            this.materialLabel8.TabIndex = 13;
            this.materialLabel8.Text = "Confirm Password";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(402, 46);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Password";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(373, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(117, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Reset Password";
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Depth = 0;
            this.textBoxDisplayName.Hint = "";
            this.textBoxDisplayName.Location = new System.Drawing.Point(139, 75);
            this.textBoxDisplayName.MaxLength = 32767;
            this.textBoxDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.PasswordChar = '\0';
            this.textBoxDisplayName.SelectedText = "";
            this.textBoxDisplayName.SelectionLength = 0;
            this.textBoxDisplayName.SelectionStart = 0;
            this.textBoxDisplayName.Size = new System.Drawing.Size(187, 23);
            this.textBoxDisplayName.TabIndex = 10;
            this.textBoxDisplayName.TabStop = false;
            this.textBoxDisplayName.UseSystemPasswordChar = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Depth = 0;
            this.textBoxUsername.Enabled = false;
            this.textBoxUsername.Hint = "";
            this.textBoxUsername.Location = new System.Drawing.Point(139, 46);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.SelectionLength = 0;
            this.textBoxUsername.SelectionStart = 0;
            this.textBoxUsername.Size = new System.Drawing.Size(187, 23);
            this.textBoxUsername.TabIndex = 9;
            this.textBoxUsername.TabStop = false;
            this.textBoxUsername.UseSystemPasswordChar = false;
            // 
            // comboBoxActive
            // 
            this.comboBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActive.FormattingEnabled = true;
            this.comboBoxActive.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxActive.Location = new System.Drawing.Point(139, 136);
            this.comboBoxActive.Name = "comboBoxActive";
            this.comboBoxActive.Size = new System.Drawing.Size(187, 26);
            this.comboBoxActive.TabIndex = 8;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Front Counter",
            "Doctor",
            "Technician",
            "Administrator"});
            this.comboBoxRole.Location = new System.Drawing.Point(139, 104);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(187, 26);
            this.comboBoxRole.TabIndex = 7;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(28, 139);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Active";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 107);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(39, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Role";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Display Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 46);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Username";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(116, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Account Details";
            // 
            // tabRegisterAccount
            // 
            this.tabRegisterAccount.BackColor = System.Drawing.Color.White;
            this.tabRegisterAccount.Controls.Add(this.comboBoxThirdQuestion);
            this.tabRegisterAccount.Controls.Add(this.comboBoxSecondQuestion);
            this.tabRegisterAccount.Controls.Add(this.comboBoxFirstQuestion);
            this.tabRegisterAccount.Controls.Add(this.textBoxThirdAnswer);
            this.tabRegisterAccount.Controls.Add(this.textBoxSecondAnswer);
            this.tabRegisterAccount.Controls.Add(this.textBoxFirstAnswer);
            this.tabRegisterAccount.Controls.Add(this.materialLabel21);
            this.tabRegisterAccount.Controls.Add(this.materialLabel20);
            this.tabRegisterAccount.Controls.Add(this.materialLabel19);
            this.tabRegisterAccount.Controls.Add(this.materialLabel18);
            this.tabRegisterAccount.Controls.Add(this.materialLabel17);
            this.tabRegisterAccount.Controls.Add(this.materialLabel16);
            this.tabRegisterAccount.Controls.Add(this.buttonRegister);
            this.tabRegisterAccount.Controls.Add(this.textBoxRegisterConfirmPassword);
            this.tabRegisterAccount.Controls.Add(this.textBoxRegisterPassword);
            this.tabRegisterAccount.Controls.Add(this.textBoxRegisterUsername);
            this.tabRegisterAccount.Controls.Add(this.textBoxRegisterDisplayName);
            this.tabRegisterAccount.Controls.Add(this.comboBoxRegisterActive);
            this.tabRegisterAccount.Controls.Add(this.comboBoxRegisterRole);
            this.tabRegisterAccount.Controls.Add(this.materialLabel15);
            this.tabRegisterAccount.Controls.Add(this.materialLabel14);
            this.tabRegisterAccount.Controls.Add(this.materialLabel13);
            this.tabRegisterAccount.Controls.Add(this.materialLabel12);
            this.tabRegisterAccount.Controls.Add(this.materialLabel11);
            this.tabRegisterAccount.Controls.Add(this.materialLabel10);
            this.tabRegisterAccount.Controls.Add(this.materialLabel9);
            this.tabRegisterAccount.Location = new System.Drawing.Point(4, 22);
            this.tabRegisterAccount.Name = "tabRegisterAccount";
            this.tabRegisterAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegisterAccount.Size = new System.Drawing.Size(774, 444);
            this.tabRegisterAccount.TabIndex = 1;
            this.tabRegisterAccount.Text = "Register Account";
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegister.Depth = 0;
            this.buttonRegister.Icon = null;
            this.buttonRegister.Location = new System.Drawing.Point(32, 391);
            this.buttonRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Primary = true;
            this.buttonRegister.Size = new System.Drawing.Size(83, 36);
            this.buttonRegister.TabIndex = 15;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxRegisterConfirmPassword
            // 
            this.textBoxRegisterConfirmPassword.Depth = 0;
            this.textBoxRegisterConfirmPassword.Hint = "";
            this.textBoxRegisterConfirmPassword.Location = new System.Drawing.Point(543, 75);
            this.textBoxRegisterConfirmPassword.MaxLength = 32767;
            this.textBoxRegisterConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRegisterConfirmPassword.Name = "textBoxRegisterConfirmPassword";
            this.textBoxRegisterConfirmPassword.PasswordChar = '*';
            this.textBoxRegisterConfirmPassword.SelectedText = "";
            this.textBoxRegisterConfirmPassword.SelectionLength = 0;
            this.textBoxRegisterConfirmPassword.SelectionStart = 0;
            this.textBoxRegisterConfirmPassword.Size = new System.Drawing.Size(187, 23);
            this.textBoxRegisterConfirmPassword.TabIndex = 14;
            this.textBoxRegisterConfirmPassword.TabStop = false;
            this.textBoxRegisterConfirmPassword.UseSystemPasswordChar = false;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Depth = 0;
            this.textBoxRegisterPassword.Hint = "";
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(543, 46);
            this.textBoxRegisterPassword.MaxLength = 32767;
            this.textBoxRegisterPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.SelectedText = "";
            this.textBoxRegisterPassword.SelectionLength = 0;
            this.textBoxRegisterPassword.SelectionStart = 0;
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(187, 23);
            this.textBoxRegisterPassword.TabIndex = 13;
            this.textBoxRegisterPassword.TabStop = false;
            this.textBoxRegisterPassword.UseSystemPasswordChar = false;
            // 
            // textBoxRegisterUsername
            // 
            this.textBoxRegisterUsername.Depth = 0;
            this.textBoxRegisterUsername.Hint = "";
            this.textBoxRegisterUsername.Location = new System.Drawing.Point(139, 46);
            this.textBoxRegisterUsername.MaxLength = 32767;
            this.textBoxRegisterUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRegisterUsername.Name = "textBoxRegisterUsername";
            this.textBoxRegisterUsername.PasswordChar = '\0';
            this.textBoxRegisterUsername.SelectedText = "";
            this.textBoxRegisterUsername.SelectionLength = 0;
            this.textBoxRegisterUsername.SelectionStart = 0;
            this.textBoxRegisterUsername.Size = new System.Drawing.Size(187, 23);
            this.textBoxRegisterUsername.TabIndex = 11;
            this.textBoxRegisterUsername.TabStop = false;
            this.textBoxRegisterUsername.UseSystemPasswordChar = false;
            // 
            // textBoxRegisterDisplayName
            // 
            this.textBoxRegisterDisplayName.Depth = 0;
            this.textBoxRegisterDisplayName.Hint = "";
            this.textBoxRegisterDisplayName.Location = new System.Drawing.Point(139, 75);
            this.textBoxRegisterDisplayName.MaxLength = 32767;
            this.textBoxRegisterDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRegisterDisplayName.Name = "textBoxRegisterDisplayName";
            this.textBoxRegisterDisplayName.PasswordChar = '\0';
            this.textBoxRegisterDisplayName.SelectedText = "";
            this.textBoxRegisterDisplayName.SelectionLength = 0;
            this.textBoxRegisterDisplayName.SelectionStart = 0;
            this.textBoxRegisterDisplayName.Size = new System.Drawing.Size(187, 23);
            this.textBoxRegisterDisplayName.TabIndex = 9;
            this.textBoxRegisterDisplayName.TabStop = false;
            this.textBoxRegisterDisplayName.UseSystemPasswordChar = false;
            // 
            // comboBoxRegisterActive
            // 
            this.comboBoxRegisterActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegisterActive.FormattingEnabled = true;
            this.comboBoxRegisterActive.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxRegisterActive.Location = new System.Drawing.Point(139, 136);
            this.comboBoxRegisterActive.Name = "comboBoxRegisterActive";
            this.comboBoxRegisterActive.Size = new System.Drawing.Size(187, 26);
            this.comboBoxRegisterActive.TabIndex = 8;
            // 
            // comboBoxRegisterRole
            // 
            this.comboBoxRegisterRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegisterRole.FormattingEnabled = true;
            this.comboBoxRegisterRole.Items.AddRange(new object[] {
            "Front Counter",
            "Doctor",
            "Technician",
            "Administrator"});
            this.comboBoxRegisterRole.Location = new System.Drawing.Point(139, 104);
            this.comboBoxRegisterRole.Name = "comboBoxRegisterRole";
            this.comboBoxRegisterRole.Size = new System.Drawing.Size(187, 26);
            this.comboBoxRegisterRole.TabIndex = 7;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(402, 75);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(133, 19);
            this.materialLabel15.TabIndex = 6;
            this.materialLabel15.Text = "Confirm Password";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(402, 46);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(75, 19);
            this.materialLabel14.TabIndex = 5;
            this.materialLabel14.Text = "Password";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(28, 139);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(51, 19);
            this.materialLabel13.TabIndex = 4;
            this.materialLabel13.Text = "Active";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(28, 107);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(39, 19);
            this.materialLabel12.TabIndex = 3;
            this.materialLabel12.Text = "Role";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(28, 75);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(102, 19);
            this.materialLabel11.TabIndex = 2;
            this.materialLabel11.Text = "Display Name";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(28, 46);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(77, 19);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Username";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(158, 19);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "Register New Account";
            // 
            // tabMachine
            // 
            this.tabMachine.BackColor = System.Drawing.Color.White;
            this.tabMachine.Controls.Add(this.viewMachineDetailForAdministrator);
            this.tabMachine.Controls.Add(this.viewMachineListForAdministrator);
            this.tabMachine.Location = new System.Drawing.Point(4, 22);
            this.tabMachine.Name = "tabMachine";
            this.tabMachine.Size = new System.Drawing.Size(774, 444);
            this.tabMachine.TabIndex = 2;
            this.tabMachine.Text = "Machine";
            // 
            // viewMachineDetailForAdministrator
            // 
            this.viewMachineDetailForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.viewMachineDetailForAdministrator.Name = "viewMachineDetailForAdministrator";
            this.viewMachineDetailForAdministrator.Size = new System.Drawing.Size(774, 444);
            this.viewMachineDetailForAdministrator.TabIndex = 1;
            // 
            // viewMachineListForAdministrator
            // 
            this.viewMachineListForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.viewMachineListForAdministrator.Name = "viewMachineListForAdministrator";
            this.viewMachineListForAdministrator.Size = new System.Drawing.Size(774, 444);
            this.viewMachineListForAdministrator.TabIndex = 0;
            // 
            // tabNewMachine
            // 
            this.tabNewMachine.BackColor = System.Drawing.Color.White;
            this.tabNewMachine.Controls.Add(this.newMachineForAdministrator1);
            this.tabNewMachine.Location = new System.Drawing.Point(4, 22);
            this.tabNewMachine.Name = "tabNewMachine";
            this.tabNewMachine.Size = new System.Drawing.Size(774, 444);
            this.tabNewMachine.TabIndex = 3;
            this.tabNewMachine.Text = "New Machine";
            // 
            // newMachineForAdministrator1
            // 
            this.newMachineForAdministrator1.Location = new System.Drawing.Point(0, 0);
            this.newMachineForAdministrator1.Name = "newMachineForAdministrator1";
            this.newMachineForAdministrator1.Size = new System.Drawing.Size(774, 444);
            this.newMachineForAdministrator1.TabIndex = 0;
            // 
            // tabAppointment
            // 
            this.tabAppointment.BackColor = System.Drawing.Color.White;
            this.tabAppointment.Controls.Add(this.viewAppointmentByTimeForAdministrator);
            this.tabAppointment.Location = new System.Drawing.Point(4, 22);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.Size = new System.Drawing.Size(774, 444);
            this.tabAppointment.TabIndex = 4;
            this.tabAppointment.Text = "Appointment";
            // 
            // viewAppointmentByTimeForAdministrator
            // 
            this.viewAppointmentByTimeForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.viewAppointmentByTimeForAdministrator.Name = "viewAppointmentByTimeForAdministrator";
            this.viewAppointmentByTimeForAdministrator.Size = new System.Drawing.Size(774, 444);
            this.viewAppointmentByTimeForAdministrator.TabIndex = 0;
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.viewPatientDetailForAdministrator);
            this.tabPatient.Controls.Add(this.viewPatientListForAdministrator);
            this.tabPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Size = new System.Drawing.Size(774, 444);
            this.tabPatient.TabIndex = 5;
            this.tabPatient.Text = "Patient";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // viewPatientDetailForAdministrator
            // 
            this.viewPatientDetailForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.viewPatientDetailForAdministrator.Name = "viewPatientDetailForAdministrator";
            this.viewPatientDetailForAdministrator.Size = new System.Drawing.Size(774, 444);
            this.viewPatientDetailForAdministrator.TabIndex = 1;
            // 
            // viewPatientListForAdministrator
            // 
            this.viewPatientListForAdministrator.BackColor = System.Drawing.Color.White;
            this.viewPatientListForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.viewPatientListForAdministrator.Name = "viewPatientListForAdministrator";
            this.viewPatientListForAdministrator.Size = new System.Drawing.Size(774, 444);
            this.viewPatientListForAdministrator.TabIndex = 0;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(28, 179);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(150, 19);
            this.materialLabel16.TabIndex = 16;
            this.materialLabel16.Text = "First Secret Question";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(28, 209);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(140, 19);
            this.materialLabel17.TabIndex = 17;
            this.materialLabel17.Text = "First Secret Answer";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(28, 239);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(170, 19);
            this.materialLabel18.TabIndex = 18;
            this.materialLabel18.Text = "Second Secret Question";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(28, 269);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(160, 19);
            this.materialLabel19.TabIndex = 19;
            this.materialLabel19.Text = "Second Secret Answer";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(28, 299);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(154, 19);
            this.materialLabel20.TabIndex = 20;
            this.materialLabel20.Text = "Third Secret Question";
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(28, 329);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(144, 19);
            this.materialLabel21.TabIndex = 21;
            this.materialLabel21.Text = "Third Secret Answer";
            // 
            // textBoxFirstAnswer
            // 
            this.textBoxFirstAnswer.Depth = 0;
            this.textBoxFirstAnswer.Hint = "";
            this.textBoxFirstAnswer.Location = new System.Drawing.Point(221, 209);
            this.textBoxFirstAnswer.MaxLength = 32767;
            this.textBoxFirstAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxFirstAnswer.Name = "textBoxFirstAnswer";
            this.textBoxFirstAnswer.PasswordChar = '\0';
            this.textBoxFirstAnswer.SelectedText = "";
            this.textBoxFirstAnswer.SelectionLength = 0;
            this.textBoxFirstAnswer.SelectionStart = 0;
            this.textBoxFirstAnswer.Size = new System.Drawing.Size(314, 23);
            this.textBoxFirstAnswer.TabIndex = 22;
            this.textBoxFirstAnswer.TabStop = false;
            this.textBoxFirstAnswer.UseSystemPasswordChar = false;
            // 
            // textBoxSecondAnswer
            // 
            this.textBoxSecondAnswer.Depth = 0;
            this.textBoxSecondAnswer.Hint = "";
            this.textBoxSecondAnswer.Location = new System.Drawing.Point(221, 265);
            this.textBoxSecondAnswer.MaxLength = 32767;
            this.textBoxSecondAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSecondAnswer.Name = "textBoxSecondAnswer";
            this.textBoxSecondAnswer.PasswordChar = '\0';
            this.textBoxSecondAnswer.SelectedText = "";
            this.textBoxSecondAnswer.SelectionLength = 0;
            this.textBoxSecondAnswer.SelectionStart = 0;
            this.textBoxSecondAnswer.Size = new System.Drawing.Size(314, 23);
            this.textBoxSecondAnswer.TabIndex = 23;
            this.textBoxSecondAnswer.TabStop = false;
            this.textBoxSecondAnswer.UseSystemPasswordChar = false;
            // 
            // textBoxThirdAnswer
            // 
            this.textBoxThirdAnswer.Depth = 0;
            this.textBoxThirdAnswer.Hint = "";
            this.textBoxThirdAnswer.Location = new System.Drawing.Point(221, 329);
            this.textBoxThirdAnswer.MaxLength = 32767;
            this.textBoxThirdAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxThirdAnswer.Name = "textBoxThirdAnswer";
            this.textBoxThirdAnswer.PasswordChar = '\0';
            this.textBoxThirdAnswer.SelectedText = "";
            this.textBoxThirdAnswer.SelectionLength = 0;
            this.textBoxThirdAnswer.SelectionStart = 0;
            this.textBoxThirdAnswer.Size = new System.Drawing.Size(314, 23);
            this.textBoxThirdAnswer.TabIndex = 24;
            this.textBoxThirdAnswer.TabStop = false;
            this.textBoxThirdAnswer.UseSystemPasswordChar = false;
            // 
            // comboBoxFirstQuestion
            // 
            this.comboBoxFirstQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirstQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFirstQuestion.FormattingEnabled = true;
            this.comboBoxFirstQuestion.Items.AddRange(new object[] {
            "What was the house number and street name you lived in as a child?",
            "What were the last four digits of your childhood telephone number?",
            "What primary school did you attend?"});
            this.comboBoxFirstQuestion.Location = new System.Drawing.Point(221, 177);
            this.comboBoxFirstQuestion.Name = "comboBoxFirstQuestion";
            this.comboBoxFirstQuestion.Size = new System.Drawing.Size(314, 26);
            this.comboBoxFirstQuestion.TabIndex = 25;
            // 
            // comboBoxSecondQuestion
            // 
            this.comboBoxSecondQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSecondQuestion.FormattingEnabled = true;
            this.comboBoxSecondQuestion.Items.AddRange(new object[] {
            "In what town or city was your first full time job?",
            "In what town or city did you meet your spouse/partner?",
            "What is the middle name of your oldest child?"});
            this.comboBoxSecondQuestion.Location = new System.Drawing.Point(221, 237);
            this.comboBoxSecondQuestion.Name = "comboBoxSecondQuestion";
            this.comboBoxSecondQuestion.Size = new System.Drawing.Size(314, 26);
            this.comboBoxSecondQuestion.TabIndex = 26;
            // 
            // comboBoxThirdQuestion
            // 
            this.comboBoxThirdQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThirdQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThirdQuestion.FormattingEnabled = true;
            this.comboBoxThirdQuestion.Items.AddRange(new object[] {
            "What are the last five digits of your driver\'s licence number?",
            "What is your grandmother\'s (on your mother\'s side) maiden name?",
            "In what town or city did your mother and father meet?"});
            this.comboBoxThirdQuestion.Location = new System.Drawing.Point(221, 297);
            this.comboBoxThirdQuestion.Name = "comboBoxThirdQuestion";
            this.comboBoxThirdQuestion.Size = new System.Drawing.Size(314, 26);
            this.comboBoxThirdQuestion.TabIndex = 27;
            // 
            // ITManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.ITManagerMainMenuTab);
            this.Name = "ITManagerMainMenu";
            this.Size = new System.Drawing.Size(782, 498);
            this.ITManagerMainMenuTab.ResumeLayout(false);
            this.tabViewAccount.ResumeLayout(false);
            this.tabViewAccount.PerformLayout();
            this.tabRegisterAccount.ResumeLayout(false);
            this.tabRegisterAccount.PerformLayout();
            this.tabMachine.ResumeLayout(false);
            this.tabNewMachine.ResumeLayout(false);
            this.tabAppointment.ResumeLayout(false);
            this.tabPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl ITManagerMainMenuTab;
        private System.Windows.Forms.TabPage tabViewAccount;
        private MaterialSkin.Controls.MaterialListView listViewListAccount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialRaisedButton buttonReset;
        private MaterialSkin.Controls.MaterialRaisedButton buttonUpdate;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxConfirmPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDisplayName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxUsername;
        private System.Windows.Forms.ComboBox comboBoxActive;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabRegisterAccount;
        private MaterialSkin.Controls.MaterialRaisedButton buttonRegister;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRegisterConfirmPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRegisterPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRegisterUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRegisterDisplayName;
        private System.Windows.Forms.ComboBox comboBoxRegisterActive;
        private System.Windows.Forms.ComboBox comboBoxRegisterRole;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.TabPage tabMachine;
        private ViewMachineDetailForAdministrator viewMachineDetailForAdministrator;
        private SearchMachineForm viewMachineListForAdministrator;
        private System.Windows.Forms.TabPage tabNewMachine;
        private NewMachineForAdministrator newMachineForAdministrator1;
        private System.Windows.Forms.TabPage tabAppointment;
        private ViewAppointmentByTimeForAdministrator viewAppointmentByTimeForAdministrator;
        private System.Windows.Forms.TabPage tabPatient;
        private ViewPatientDetailForAdministrator viewPatientDetailForAdministrator;
        private SearchPatientForm viewPatientListForAdministrator;
        private System.Windows.Forms.ComboBox comboBoxThirdQuestion;
        private System.Windows.Forms.ComboBox comboBoxSecondQuestion;
        private System.Windows.Forms.ComboBox comboBoxFirstQuestion;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxThirdAnswer;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSecondAnswer;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxFirstAnswer;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
    }
}
