namespace SDM_Assignment
{
    partial class NewMaintenanceForTechnician
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineId = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMaintenanceComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePickerMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.buttonNewMaintenance = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxIsFollowUp = new MaterialSkin.Controls.MaterialCheckBox();
            this.buttonSearchFollowUpMaintenance = new MaterialSkin.Controls.MaterialRaisedButton();
            this.searchFollowUpByMachineId = new SDM_Assignment.SearchFollowUpByMachineId();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(15, 15);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(56, 36);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(186, 136);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 18);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Date";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(186, 80);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 18);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Machine ID";
            // 
            // textBoxMachineId
            // 
            this.textBoxMachineId.AutoSize = true;
            this.textBoxMachineId.Depth = 0;
            this.textBoxMachineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxMachineId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineId.Location = new System.Drawing.Point(329, 80);
            this.textBoxMachineId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineId.Name = "textBoxMachineId";
            this.textBoxMachineId.Size = new System.Drawing.Size(103, 18);
            this.textBoxMachineId.TabIndex = 4;
            this.textBoxMachineId.Text = "materialLabel3";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(186, 193);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(74, 18);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Comment";
            // 
            // textBoxMaintenanceComment
            // 
            this.textBoxMaintenanceComment.Depth = 0;
            this.textBoxMaintenanceComment.Hint = "";
            this.textBoxMaintenanceComment.Location = new System.Drawing.Point(333, 189);
            this.textBoxMaintenanceComment.MaxLength = 32767;
            this.textBoxMaintenanceComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMaintenanceComment.Name = "textBoxMaintenanceComment";
            this.textBoxMaintenanceComment.PasswordChar = '\0';
            this.textBoxMaintenanceComment.SelectedText = "";
            this.textBoxMaintenanceComment.SelectionLength = 0;
            this.textBoxMaintenanceComment.SelectionStart = 0;
            this.textBoxMaintenanceComment.Size = new System.Drawing.Size(132, 23);
            this.textBoxMaintenanceComment.TabIndex = 6;
            this.textBoxMaintenanceComment.TabStop = false;
            this.textBoxMaintenanceComment.UseSystemPasswordChar = false;
            // 
            // dateTimePickerMaintenanceDate
            // 
            this.dateTimePickerMaintenanceDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerMaintenanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMaintenanceDate.Location = new System.Drawing.Point(333, 130);
            this.dateTimePickerMaintenanceDate.Name = "dateTimePickerMaintenanceDate";
            this.dateTimePickerMaintenanceDate.Size = new System.Drawing.Size(132, 26);
            this.dateTimePickerMaintenanceDate.TabIndex = 7;
            // 
            // buttonNewMaintenance
            // 
            this.buttonNewMaintenance.AutoSize = true;
            this.buttonNewMaintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewMaintenance.Depth = 0;
            this.buttonNewMaintenance.Icon = null;
            this.buttonNewMaintenance.Location = new System.Drawing.Point(690, 401);
            this.buttonNewMaintenance.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewMaintenance.Name = "buttonNewMaintenance";
            this.buttonNewMaintenance.Primary = true;
            this.buttonNewMaintenance.Size = new System.Drawing.Size(71, 36);
            this.buttonNewMaintenance.TabIndex = 8;
            this.buttonNewMaintenance.Text = "Create";
            this.buttonNewMaintenance.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(186, 252);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 18);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Maintenance Type";
            // 
            // checkBoxIsFollowUp
            // 
            this.checkBoxIsFollowUp.AutoSize = true;
            this.checkBoxIsFollowUp.Depth = 0;
            this.checkBoxIsFollowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxIsFollowUp.Location = new System.Drawing.Point(333, 248);
            this.checkBoxIsFollowUp.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxIsFollowUp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxIsFollowUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxIsFollowUp.Name = "checkBoxIsFollowUp";
            this.checkBoxIsFollowUp.Ripple = true;
            this.checkBoxIsFollowUp.Size = new System.Drawing.Size(89, 30);
            this.checkBoxIsFollowUp.TabIndex = 10;
            this.checkBoxIsFollowUp.Text = "Follow up";
            this.checkBoxIsFollowUp.UseVisualStyleBackColor = true;
            this.checkBoxIsFollowUp.CheckedChanged += new System.EventHandler(this.checkBoxIsFollowUp_CheckedChanged);
            // 
            // buttonSearchFollowUpMaintenance
            // 
            this.buttonSearchFollowUpMaintenance.AutoSize = true;
            this.buttonSearchFollowUpMaintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchFollowUpMaintenance.Depth = 0;
            this.buttonSearchFollowUpMaintenance.Icon = null;
            this.buttonSearchFollowUpMaintenance.Location = new System.Drawing.Point(454, 244);
            this.buttonSearchFollowUpMaintenance.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearchFollowUpMaintenance.Name = "buttonSearchFollowUpMaintenance";
            this.buttonSearchFollowUpMaintenance.Primary = true;
            this.buttonSearchFollowUpMaintenance.Size = new System.Drawing.Size(151, 36);
            this.buttonSearchFollowUpMaintenance.TabIndex = 11;
            this.buttonSearchFollowUpMaintenance.Text = "Search Follow Up";
            this.buttonSearchFollowUpMaintenance.UseVisualStyleBackColor = true;
            this.buttonSearchFollowUpMaintenance.Click += new System.EventHandler(this.buttonSearchFollowUpMaintenance_Click);
            // 
            // searchFollowUpByMachineId
            // 
            this.searchFollowUpByMachineId.Location = new System.Drawing.Point(0, 0);
            this.searchFollowUpByMachineId.Name = "searchFollowUpByMachineId";
            this.searchFollowUpByMachineId.Size = new System.Drawing.Size(778, 449);
            this.searchFollowUpByMachineId.TabIndex = 12;
            // 
            // NewMaintenanceForTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchFollowUpByMachineId);
            this.Controls.Add(this.buttonSearchFollowUpMaintenance);
            this.Controls.Add(this.checkBoxIsFollowUp);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.buttonNewMaintenance);
            this.Controls.Add(this.dateTimePickerMaintenanceDate);
            this.Controls.Add(this.textBoxMaintenanceComment);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.textBoxMachineId);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonBack);
            this.Name = "NewMaintenanceForTechnician";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineId;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearchFollowUpMaintenance;
        private SearchFollowUpByMachineId searchFollowUpByMachineId;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonNewMaintenance;
        internal MaterialSkin.Controls.MaterialCheckBox checkBoxIsFollowUp;
        internal System.Windows.Forms.DateTimePicker dateTimePickerMaintenanceDate;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxMaintenanceComment;
    }
}
