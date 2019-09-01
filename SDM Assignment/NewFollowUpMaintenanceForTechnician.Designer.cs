namespace SDM_Assignment
{
    partial class NewFollowUpMaintenanceForTechnician
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
            this.textBoxMachineId = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxFollowUpMaintenanceComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePickerFollowUpMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.buttonNewFollowUp = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(160, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "MID";
            // 
            // textBoxMachineId
            // 
            this.textBoxMachineId.AutoSize = true;
            this.textBoxMachineId.Depth = 0;
            this.textBoxMachineId.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineId.Location = new System.Drawing.Point(296, 80);
            this.textBoxMachineId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineId.Name = "textBoxMachineId";
            this.textBoxMachineId.Size = new System.Drawing.Size(108, 19);
            this.textBoxMachineId.TabIndex = 2;
            this.textBoxMachineId.Text = "materialLabel2";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(160, 120);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Follow Up Date";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(160, 160);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Comment";
            // 
            // textBoxFollowUpMaintenanceComment
            // 
            this.textBoxFollowUpMaintenanceComment.Depth = 0;
            this.textBoxFollowUpMaintenanceComment.Hint = "";
            this.textBoxFollowUpMaintenanceComment.Location = new System.Drawing.Point(300, 160);
            this.textBoxFollowUpMaintenanceComment.MaxLength = 32767;
            this.textBoxFollowUpMaintenanceComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxFollowUpMaintenanceComment.Name = "textBoxFollowUpMaintenanceComment";
            this.textBoxFollowUpMaintenanceComment.PasswordChar = '\0';
            this.textBoxFollowUpMaintenanceComment.SelectedText = "";
            this.textBoxFollowUpMaintenanceComment.SelectionLength = 0;
            this.textBoxFollowUpMaintenanceComment.SelectionStart = 0;
            this.textBoxFollowUpMaintenanceComment.Size = new System.Drawing.Size(192, 23);
            this.textBoxFollowUpMaintenanceComment.TabIndex = 5;
            this.textBoxFollowUpMaintenanceComment.TabStop = false;
            this.textBoxFollowUpMaintenanceComment.UseSystemPasswordChar = false;
            // 
            // dateTimePickerFollowUpMaintenanceDate
            // 
            this.dateTimePickerFollowUpMaintenanceDate.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerFollowUpMaintenanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFollowUpMaintenanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFollowUpMaintenanceDate.Location = new System.Drawing.Point(300, 114);
            this.dateTimePickerFollowUpMaintenanceDate.Name = "dateTimePickerFollowUpMaintenanceDate";
            this.dateTimePickerFollowUpMaintenanceDate.Size = new System.Drawing.Size(192, 26);
            this.dateTimePickerFollowUpMaintenanceDate.TabIndex = 6;
            // 
            // buttonNewFollowUp
            // 
            this.buttonNewFollowUp.AutoSize = true;
            this.buttonNewFollowUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewFollowUp.Depth = 0;
            this.buttonNewFollowUp.Icon = null;
            this.buttonNewFollowUp.Location = new System.Drawing.Point(631, 396);
            this.buttonNewFollowUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewFollowUp.Name = "buttonNewFollowUp";
            this.buttonNewFollowUp.Primary = true;
            this.buttonNewFollowUp.Size = new System.Drawing.Size(129, 36);
            this.buttonNewFollowUp.TabIndex = 7;
            this.buttonNewFollowUp.Text = "New Follow Up";
            this.buttonNewFollowUp.UseVisualStyleBackColor = true;
            // 
            // NewFollowUpMaintenanceForTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNewFollowUp);
            this.Controls.Add(this.dateTimePickerFollowUpMaintenanceDate);
            this.Controls.Add(this.textBoxFollowUpMaintenanceComment);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxMachineId);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonBack);
            this.Name = "NewFollowUpMaintenanceForTechnician";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineId;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonNewFollowUp;
        internal MaterialSkin.Controls.MaterialSingleLineTextField textBoxFollowUpMaintenanceComment;
        internal System.Windows.Forms.DateTimePicker dateTimePickerFollowUpMaintenanceDate;
    }
}
