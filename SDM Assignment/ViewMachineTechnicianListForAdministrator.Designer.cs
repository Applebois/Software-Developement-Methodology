namespace SDM_Assignment
{
    partial class ViewMachineTechnicianListForAdministrator
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
            this.listViewMachineTechnician = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewTechnician = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonRemoveTechnician = new MaterialSkin.Controls.MaterialRaisedButton();
            this.machineAssignTechnicianForAdministrator = new SDM_Assignment.MachineAssignTechnicianForAdministrator();
            this.machineUnassignTechnicianForAdministrator = new SDM_Assignment.MachineUnassignTechnicianForAdministrator();
            this.SuspendLayout();
            // 
            // listViewMachineTechnician
            // 
            this.listViewMachineTechnician.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMachineTechnician.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewMachineTechnician.Depth = 0;
            this.listViewMachineTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewMachineTechnician.FullRowSelect = true;
            this.listViewMachineTechnician.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMachineTechnician.HideSelection = false;
            this.listViewMachineTechnician.Location = new System.Drawing.Point(3, 53);
            this.listViewMachineTechnician.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewMachineTechnician.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewMachineTechnician.Name = "listViewMachineTechnician";
            this.listViewMachineTechnician.OwnerDraw = true;
            this.listViewMachineTechnician.Size = new System.Drawing.Size(775, 396);
            this.listViewMachineTechnician.TabIndex = 0;
            this.listViewMachineTechnician.UseCompatibleStateImageBehavior = false;
            this.listViewMachineTechnician.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "T.ID";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Technician Name";
            this.columnHeader3.Width = 646;
            // 
            // buttonNewTechnician
            // 
            this.buttonNewTechnician.AutoSize = true;
            this.buttonNewTechnician.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewTechnician.Depth = 0;
            this.buttonNewTechnician.Icon = null;
            this.buttonNewTechnician.Location = new System.Drawing.Point(622, 3);
            this.buttonNewTechnician.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewTechnician.Name = "buttonNewTechnician";
            this.buttonNewTechnician.Primary = true;
            this.buttonNewTechnician.Size = new System.Drawing.Size(153, 36);
            this.buttonNewTechnician.TabIndex = 1;
            this.buttonNewTechnician.Text = "Assign Technician";
            this.buttonNewTechnician.UseVisualStyleBackColor = true;
            this.buttonNewTechnician.Click += new System.EventHandler(this.buttonNewTechnician_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(3, 3);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(56, 36);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTechnician
            // 
            this.buttonRemoveTechnician.AutoSize = true;
            this.buttonRemoveTechnician.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRemoveTechnician.Depth = 0;
            this.buttonRemoveTechnician.Icon = null;
            this.buttonRemoveTechnician.Location = new System.Drawing.Point(444, 3);
            this.buttonRemoveTechnician.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRemoveTechnician.Name = "buttonRemoveTechnician";
            this.buttonRemoveTechnician.Primary = true;
            this.buttonRemoveTechnician.Size = new System.Drawing.Size(172, 36);
            this.buttonRemoveTechnician.TabIndex = 3;
            this.buttonRemoveTechnician.Text = "Unassign Technician";
            this.buttonRemoveTechnician.UseVisualStyleBackColor = true;
            this.buttonRemoveTechnician.Click += new System.EventHandler(this.buttonRemoveTechnician_Click);
            // 
            // machineAssignTechnicianForAdministrator
            // 
            this.machineAssignTechnicianForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.machineAssignTechnicianForAdministrator.Name = "machineAssignTechnicianForAdministrator";
            this.machineAssignTechnicianForAdministrator.Size = new System.Drawing.Size(778, 449);
            this.machineAssignTechnicianForAdministrator.TabIndex = 4;
            // 
            // machineUnassignTechnicianForAdministrator
            // 
            this.machineUnassignTechnicianForAdministrator.Location = new System.Drawing.Point(0, 0);
            this.machineUnassignTechnicianForAdministrator.Name = "machineUnassignTechnicianForAdministrator";
            this.machineUnassignTechnicianForAdministrator.Size = new System.Drawing.Size(778, 449);
            this.machineUnassignTechnicianForAdministrator.TabIndex = 5;
            // 
            // ViewMachineTechnicianListForAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.machineUnassignTechnicianForAdministrator);
            this.Controls.Add(this.machineAssignTechnicianForAdministrator);
            this.Controls.Add(this.buttonRemoveTechnician);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNewTechnician);
            this.Controls.Add(this.listViewMachineTechnician);
            this.Name = "ViewMachineTechnicianListForAdministrator";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewMachineTechnician;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNewTechnician;
        private MaterialSkin.Controls.MaterialRaisedButton buttonRemoveTechnician;
        private MachineAssignTechnicianForAdministrator machineAssignTechnicianForAdministrator;
        private MachineUnassignTechnicianForAdministrator machineUnassignTechnicianForAdministrator;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
    }
}
