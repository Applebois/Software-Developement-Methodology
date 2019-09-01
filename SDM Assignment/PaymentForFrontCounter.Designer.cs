namespace SDM_Assignment
{
    partial class PaymentForFrontCounter
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.numericUpDownItemAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonAddItem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.richTextBoxPaymentNote = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxMiscItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numericUpDownMiscItemPrice = new System.Windows.Forms.NumericUpDown();
            this.labelRM = new MaterialSkin.Controls.MaterialLabel();
            this.labelItemName = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPatientName = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSearchPatient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonMakePayment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.searchPatientForm = new SDM_Assignment.SearchPatientForm();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiscItemPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(100, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Patient";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(100, 210);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Note";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(100, 90);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Date";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(100, 409);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Amount";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(100, 130);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(39, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Item";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(208, 126);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(247, 28);
            this.comboBoxItem.TabIndex = 5;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // numericUpDownItemAmount
            // 
            this.numericUpDownItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownItemAmount.Location = new System.Drawing.Point(461, 127);
            this.numericUpDownItemAmount.Name = "numericUpDownItemAmount";
            this.numericUpDownItemAmount.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownItemAmount.TabIndex = 6;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.AutoSize = true;
            this.buttonAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddItem.Depth = 0;
            this.buttonAddItem.Icon = null;
            this.buttonAddItem.Location = new System.Drawing.Point(517, 122);
            this.buttonAddItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Primary = true;
            this.buttonAddItem.Size = new System.Drawing.Size(83, 36);
            this.buttonAddItem.TabIndex = 7;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // richTextBoxPaymentNote
            // 
            this.richTextBoxPaymentNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPaymentNote.Location = new System.Drawing.Point(208, 206);
            this.richTextBoxPaymentNote.Name = "richTextBoxPaymentNote";
            this.richTextBoxPaymentNote.ReadOnly = true;
            this.richTextBoxPaymentNote.Size = new System.Drawing.Size(392, 193);
            this.richTextBoxPaymentNote.TabIndex = 8;
            this.richTextBoxPaymentNote.Text = "";
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.CustomFormat = "dd-MM-yyyy hh:mm";
            this.dateTimePickerPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(208, 84);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(177, 26);
            this.dateTimePickerPaymentDate.TabIndex = 9;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(208, 405);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(392, 26);
            this.textBoxAmount.TabIndex = 10;
            // 
            // textBoxMiscItemName
            // 
            this.textBoxMiscItemName.Depth = 0;
            this.textBoxMiscItemName.Hint = "";
            this.textBoxMiscItemName.Location = new System.Drawing.Point(226, 167);
            this.textBoxMiscItemName.MaxLength = 32767;
            this.textBoxMiscItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMiscItemName.Name = "textBoxMiscItemName";
            this.textBoxMiscItemName.PasswordChar = '\0';
            this.textBoxMiscItemName.SelectedText = "";
            this.textBoxMiscItemName.SelectionLength = 0;
            this.textBoxMiscItemName.SelectionStart = 0;
            this.textBoxMiscItemName.Size = new System.Drawing.Size(185, 23);
            this.textBoxMiscItemName.TabIndex = 11;
            this.textBoxMiscItemName.TabStop = false;
            this.textBoxMiscItemName.UseSystemPasswordChar = false;
            // 
            // numericUpDownMiscItemPrice
            // 
            this.numericUpDownMiscItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMiscItemPrice.Location = new System.Drawing.Point(461, 164);
            this.numericUpDownMiscItemPrice.Name = "numericUpDownMiscItemPrice";
            this.numericUpDownMiscItemPrice.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownMiscItemPrice.TabIndex = 12;
            // 
            // labelRM
            // 
            this.labelRM.AutoSize = true;
            this.labelRM.Depth = 0;
            this.labelRM.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRM.Location = new System.Drawing.Point(424, 167);
            this.labelRM.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRM.Name = "labelRM";
            this.labelRM.Size = new System.Drawing.Size(31, 19);
            this.labelRM.TabIndex = 13;
            this.labelRM.Text = "RM";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Depth = 0;
            this.labelItemName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelItemName.Location = new System.Drawing.Point(100, 171);
            this.labelItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(120, 19);
            this.labelItemName.TabIndex = 14;
            this.labelItemName.Text = "Misc Item Name";
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.AutoSize = true;
            this.textBoxPatientName.Depth = 0;
            this.textBoxPatientName.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxPatientName.Location = new System.Drawing.Point(204, 50);
            this.textBoxPatientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(149, 19);
            this.textBoxPatientName.TabIndex = 15;
            this.textBoxPatientName.Text = "Please select patient";
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.AutoSize = true;
            this.buttonSearchPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchPatient.Depth = 0;
            this.buttonSearchPatient.Icon = null;
            this.buttonSearchPatient.Location = new System.Drawing.Point(378, 42);
            this.buttonSearchPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Primary = true;
            this.buttonSearchPatient.Size = new System.Drawing.Size(133, 36);
            this.buttonSearchPatient.TabIndex = 16;
            this.buttonSearchPatient.Text = "Search Patient";
            this.buttonSearchPatient.UseVisualStyleBackColor = true;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonSearchPatient_Click);
            // 
            // buttonMakePayment
            // 
            this.buttonMakePayment.AutoSize = true;
            this.buttonMakePayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMakePayment.Depth = 0;
            this.buttonMakePayment.Icon = null;
            this.buttonMakePayment.Location = new System.Drawing.Point(649, 409);
            this.buttonMakePayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMakePayment.Name = "buttonMakePayment";
            this.buttonMakePayment.Primary = true;
            this.buttonMakePayment.Size = new System.Drawing.Size(126, 36);
            this.buttonMakePayment.TabIndex = 17;
            this.buttonMakePayment.Text = "Make Payment";
            this.buttonMakePayment.UseVisualStyleBackColor = true;
            this.buttonMakePayment.Click += new System.EventHandler(this.buttonMakePayment_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReset.Depth = 0;
            this.buttonReset.Icon = null;
            this.buttonReset.Location = new System.Drawing.Point(672, 3);
            this.buttonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Primary = true;
            this.buttonReset.Size = new System.Drawing.Size(103, 36);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "Reset Form";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // searchPatientForm
            // 
            this.searchPatientForm.BackColor = System.Drawing.Color.White;
            this.searchPatientForm.Location = new System.Drawing.Point(0, 0);
            this.searchPatientForm.Name = "searchPatientForm";
            this.searchPatientForm.Size = new System.Drawing.Size(778, 449);
            this.searchPatientForm.TabIndex = 19;
            // 
            // PaymentForFrontCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPatientForm);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMakePayment);
            this.Controls.Add(this.buttonSearchPatient);
            this.Controls.Add(this.textBoxPatientName);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.labelRM);
            this.Controls.Add(this.numericUpDownMiscItemPrice);
            this.Controls.Add(this.textBoxMiscItemName);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.dateTimePickerPaymentDate);
            this.Controls.Add(this.richTextBoxPaymentNote);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.numericUpDownItemAmount);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PaymentForFrontCounter";
            this.Size = new System.Drawing.Size(778, 449);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiscItemPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.NumericUpDown numericUpDownItemAmount;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAddItem;
        private System.Windows.Forms.RichTextBox richTextBoxPaymentNote;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxMiscItemName;
        private System.Windows.Forms.NumericUpDown numericUpDownMiscItemPrice;
        private MaterialSkin.Controls.MaterialLabel labelRM;
        private MaterialSkin.Controls.MaterialLabel labelItemName;
        private MaterialSkin.Controls.MaterialLabel textBoxPatientName;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchPatient;
        private MaterialSkin.Controls.MaterialRaisedButton buttonMakePayment;
        private MaterialSkin.Controls.MaterialRaisedButton buttonReset;
        private SearchPatientForm searchPatientForm;
    }
}
