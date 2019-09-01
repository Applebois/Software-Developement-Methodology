namespace SDM_Assignment
{
    partial class ViewMachineDetailForTechnician
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
            this.buttonUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxMachineActive = new System.Windows.Forms.ComboBox();
            this.buttonViewMachineMaintenance = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineId = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonViewFollowUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxMachineBrand = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineModel = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineCooldownMin = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineSupplier = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineSupplierContact = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineManufactureDate = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMachineNote = new MaterialSkin.Controls.MaterialLabel();
            this.viewMaintenanceListForTechnician = new SDM_Assignment.ViewMaintenanceListForTechnician();
            this.viewFollowUpMaintenanceForTechnician = new SDM_Assignment.ViewFollowUpMaintenanceForTechnician();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdate.Depth = 0;
            this.buttonUpdate.Icon = null;
            this.buttonUpdate.Location = new System.Drawing.Point(306, 397);
            this.buttonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Primary = true;
            this.buttonUpdate.Size = new System.Drawing.Size(73, 36);
            this.buttonUpdate.TabIndex = 50;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxMachineActive
            // 
            this.comboBoxMachineActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMachineActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMachineActive.FormattingEnabled = true;
            this.comboBoxMachineActive.Items.AddRange(new object[] {
            "Inactive",
            "Active"});
            this.comboBoxMachineActive.Location = new System.Drawing.Point(306, 368);
            this.comboBoxMachineActive.Name = "comboBoxMachineActive";
            this.comboBoxMachineActive.Size = new System.Drawing.Size(154, 26);
            this.comboBoxMachineActive.TabIndex = 49;
            // 
            // buttonViewMachineMaintenance
            // 
            this.buttonViewMachineMaintenance.AutoSize = true;
            this.buttonViewMachineMaintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonViewMachineMaintenance.Depth = 0;
            this.buttonViewMachineMaintenance.Icon = null;
            this.buttonViewMachineMaintenance.Location = new System.Drawing.Point(609, 354);
            this.buttonViewMachineMaintenance.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonViewMachineMaintenance.Name = "buttonViewMachineMaintenance";
            this.buttonViewMachineMaintenance.Primary = true;
            this.buttonViewMachineMaintenance.Size = new System.Drawing.Size(153, 36);
            this.buttonViewMachineMaintenance.TabIndex = 40;
            this.buttonViewMachineMaintenance.Text = "View Maintenance";
            this.buttonViewMachineMaintenance.UseVisualStyleBackColor = true;
            this.buttonViewMachineMaintenance.Click += new System.EventHandler(this.buttonViewMachineMaintenance_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(17, 16);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(56, 36);
            this.buttonBack.TabIndex = 39;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(157, 171);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(106, 19);
            this.materialLabel11.TabIndex = 38;
            this.materialLabel11.Text = "Cooldown Min";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(157, 211);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(63, 19);
            this.materialLabel9.TabIndex = 37;
            this.materialLabel9.Text = "Supplier";
            // 
            // textBoxMachineId
            // 
            this.textBoxMachineId.AutoSize = true;
            this.textBoxMachineId.Depth = 0;
            this.textBoxMachineId.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineId.Location = new System.Drawing.Point(302, 51);
            this.textBoxMachineId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineId.Name = "textBoxMachineId";
            this.textBoxMachineId.Size = new System.Drawing.Size(108, 19);
            this.textBoxMachineId.TabIndex = 36;
            this.textBoxMachineId.Text = "materialLabel8";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(157, 251);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(120, 19);
            this.materialLabel7.TabIndex = 35;
            this.materialLabel7.Text = "Supplier Contact";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(157, 371);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 34;
            this.materialLabel6.Text = "Status";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(157, 131);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 33;
            this.materialLabel5.Text = "Model";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(157, 331);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 32;
            this.materialLabel4.Text = "Note";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(157, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 31;
            this.materialLabel3.Text = "Brand";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(157, 291);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(128, 19);
            this.materialLabel2.TabIndex = 30;
            this.materialLabel2.Text = "Manufacture Date";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(157, 51);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Machine ID";
            // 
            // buttonViewFollowUp
            // 
            this.buttonViewFollowUp.AutoSize = true;
            this.buttonViewFollowUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonViewFollowUp.Depth = 0;
            this.buttonViewFollowUp.Icon = null;
            this.buttonViewFollowUp.Location = new System.Drawing.Point(630, 397);
            this.buttonViewFollowUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonViewFollowUp.Name = "buttonViewFollowUp";
            this.buttonViewFollowUp.Primary = true;
            this.buttonViewFollowUp.Size = new System.Drawing.Size(132, 36);
            this.buttonViewFollowUp.TabIndex = 51;
            this.buttonViewFollowUp.Text = "View Follow Up";
            this.buttonViewFollowUp.UseVisualStyleBackColor = true;
            this.buttonViewFollowUp.Click += new System.EventHandler(this.buttonViewFollowUp_Click);
            // 
            // textBoxMachineBrand
            // 
            this.textBoxMachineBrand.AutoSize = true;
            this.textBoxMachineBrand.Depth = 0;
            this.textBoxMachineBrand.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineBrand.Location = new System.Drawing.Point(302, 91);
            this.textBoxMachineBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineBrand.Name = "textBoxMachineBrand";
            this.textBoxMachineBrand.Size = new System.Drawing.Size(154, 19);
            this.textBoxMachineBrand.TabIndex = 52;
            this.textBoxMachineBrand.Text = "textBoxMachineBrand";
            // 
            // textBoxMachineModel
            // 
            this.textBoxMachineModel.AutoSize = true;
            this.textBoxMachineModel.Depth = 0;
            this.textBoxMachineModel.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineModel.Location = new System.Drawing.Point(302, 131);
            this.textBoxMachineModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineModel.Name = "textBoxMachineModel";
            this.textBoxMachineModel.Size = new System.Drawing.Size(158, 19);
            this.textBoxMachineModel.TabIndex = 53;
            this.textBoxMachineModel.Text = "textBoxMachineModel";
            // 
            // textBoxMachineCooldownMin
            // 
            this.textBoxMachineCooldownMin.AutoSize = true;
            this.textBoxMachineCooldownMin.Depth = 0;
            this.textBoxMachineCooldownMin.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineCooldownMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineCooldownMin.Location = new System.Drawing.Point(302, 171);
            this.textBoxMachineCooldownMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineCooldownMin.Name = "textBoxMachineCooldownMin";
            this.textBoxMachineCooldownMin.Size = new System.Drawing.Size(116, 19);
            this.textBoxMachineCooldownMin.TabIndex = 54;
            this.textBoxMachineCooldownMin.Text = "materialLabel12";
            // 
            // textBoxMachineSupplier
            // 
            this.textBoxMachineSupplier.AutoSize = true;
            this.textBoxMachineSupplier.Depth = 0;
            this.textBoxMachineSupplier.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineSupplier.Location = new System.Drawing.Point(302, 211);
            this.textBoxMachineSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineSupplier.Name = "textBoxMachineSupplier";
            this.textBoxMachineSupplier.Size = new System.Drawing.Size(116, 19);
            this.textBoxMachineSupplier.TabIndex = 55;
            this.textBoxMachineSupplier.Text = "materialLabel13";
            // 
            // textBoxMachineSupplierContact
            // 
            this.textBoxMachineSupplierContact.AutoSize = true;
            this.textBoxMachineSupplierContact.Depth = 0;
            this.textBoxMachineSupplierContact.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineSupplierContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineSupplierContact.Location = new System.Drawing.Point(302, 251);
            this.textBoxMachineSupplierContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineSupplierContact.Name = "textBoxMachineSupplierContact";
            this.textBoxMachineSupplierContact.Size = new System.Drawing.Size(116, 19);
            this.textBoxMachineSupplierContact.TabIndex = 56;
            this.textBoxMachineSupplierContact.Text = "materialLabel14";
            // 
            // textBoxMachineManufactureDate
            // 
            this.textBoxMachineManufactureDate.AutoSize = true;
            this.textBoxMachineManufactureDate.Depth = 0;
            this.textBoxMachineManufactureDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineManufactureDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineManufactureDate.Location = new System.Drawing.Point(302, 291);
            this.textBoxMachineManufactureDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineManufactureDate.Name = "textBoxMachineManufactureDate";
            this.textBoxMachineManufactureDate.Size = new System.Drawing.Size(116, 19);
            this.textBoxMachineManufactureDate.TabIndex = 57;
            this.textBoxMachineManufactureDate.Text = "materialLabel15";
            // 
            // textBoxMachineNote
            // 
            this.textBoxMachineNote.AutoSize = true;
            this.textBoxMachineNote.Depth = 0;
            this.textBoxMachineNote.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxMachineNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMachineNote.Location = new System.Drawing.Point(302, 331);
            this.textBoxMachineNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMachineNote.Name = "textBoxMachineNote";
            this.textBoxMachineNote.Size = new System.Drawing.Size(116, 19);
            this.textBoxMachineNote.TabIndex = 58;
            this.textBoxMachineNote.Text = "materialLabel16";
            // 
            // viewMaintenanceListForTechnician
            // 
            this.viewMaintenanceListForTechnician.Location = new System.Drawing.Point(0, 0);
            this.viewMaintenanceListForTechnician.Name = "viewMaintenanceListForTechnician";
            this.viewMaintenanceListForTechnician.Size = new System.Drawing.Size(778, 449);
            this.viewMaintenanceListForTechnician.TabIndex = 59;
            // 
            // viewFollowUpMaintenanceForTechnician
            // 
            this.viewFollowUpMaintenanceForTechnician.Location = new System.Drawing.Point(0, 0);
            this.viewFollowUpMaintenanceForTechnician.Name = "viewFollowUpMaintenanceForTechnician";
            this.viewFollowUpMaintenanceForTechnician.Size = new System.Drawing.Size(778, 449);
            this.viewFollowUpMaintenanceForTechnician.TabIndex = 60;
            // 
            // ViewMachineDetailForTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewFollowUpMaintenanceForTechnician);
            this.Controls.Add(this.viewMaintenanceListForTechnician);
            this.Controls.Add(this.textBoxMachineNote);
            this.Controls.Add(this.textBoxMachineManufactureDate);
            this.Controls.Add(this.textBoxMachineSupplierContact);
            this.Controls.Add(this.textBoxMachineSupplier);
            this.Controls.Add(this.textBoxMachineCooldownMin);
            this.Controls.Add(this.textBoxMachineModel);
            this.Controls.Add(this.textBoxMachineBrand);
            this.Controls.Add(this.buttonViewFollowUp);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxMachineActive);
            this.Controls.Add(this.buttonViewMachineMaintenance);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.textBoxMachineId);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ViewMachineDetailForTechnician";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxMachineActive;
        private MaterialSkin.Controls.MaterialRaisedButton buttonViewMachineMaintenance;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineId;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonViewFollowUp;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineBrand;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineModel;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineCooldownMin;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineSupplier;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineSupplierContact;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineManufactureDate;
        private MaterialSkin.Controls.MaterialLabel textBoxMachineNote;
        private ViewMaintenanceListForTechnician viewMaintenanceListForTechnician;
        private ViewFollowUpMaintenanceForTechnician viewFollowUpMaintenanceForTechnician;
    }
}
