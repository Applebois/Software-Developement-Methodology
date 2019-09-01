namespace SDM_Assignment
{
    partial class ViewMaintenanceListForTechnician
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
            this.listViewMachineMaintenance = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewMaintenance = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newMaintenanceForTechnician = new SDM_Assignment.NewMaintenanceForTechnician();
            this.SuspendLayout();
            // 
            // listViewMachineMaintenance
            // 
            this.listViewMachineMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMachineMaintenance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewMachineMaintenance.Depth = 0;
            this.listViewMachineMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewMachineMaintenance.FullRowSelect = true;
            this.listViewMachineMaintenance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMachineMaintenance.HideSelection = false;
            this.listViewMachineMaintenance.Location = new System.Drawing.Point(3, 49);
            this.listViewMachineMaintenance.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewMachineMaintenance.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewMachineMaintenance.Name = "listViewMachineMaintenance";
            this.listViewMachineMaintenance.OwnerDraw = true;
            this.listViewMachineMaintenance.Size = new System.Drawing.Size(772, 397);
            this.listViewMachineMaintenance.TabIndex = 0;
            this.listViewMachineMaintenance.UseCompatibleStateImageBehavior = false;
            this.listViewMachineMaintenance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Comment";
            this.columnHeader3.Width = 600;
            // 
            // buttonNewMaintenance
            // 
            this.buttonNewMaintenance.AutoSize = true;
            this.buttonNewMaintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewMaintenance.Depth = 0;
            this.buttonNewMaintenance.Icon = null;
            this.buttonNewMaintenance.Location = new System.Drawing.Point(625, 3);
            this.buttonNewMaintenance.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewMaintenance.Name = "buttonNewMaintenance";
            this.buttonNewMaintenance.Primary = true;
            this.buttonNewMaintenance.Size = new System.Drawing.Size(150, 36);
            this.buttonNewMaintenance.TabIndex = 1;
            this.buttonNewMaintenance.Text = "New Maintenance";
            this.buttonNewMaintenance.UseVisualStyleBackColor = true;
            this.buttonNewMaintenance.Click += new System.EventHandler(this.buttonNewMaintenance_Click);
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
            // newMaintenanceForTechnician
            // 
            this.newMaintenanceForTechnician.Location = new System.Drawing.Point(0, 0);
            this.newMaintenanceForTechnician.Name = "newMaintenanceForTechnician";
            this.newMaintenanceForTechnician.Size = new System.Drawing.Size(778, 449);
            this.newMaintenanceForTechnician.TabIndex = 3;
            // 
            // ViewMaintenanceListForTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newMaintenanceForTechnician);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNewMaintenance);
            this.Controls.Add(this.listViewMachineMaintenance);
            this.Name = "ViewMaintenanceListForTechnician";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewMachineMaintenance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNewMaintenance;
        private NewMaintenanceForTechnician newMaintenanceForTechnician;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
    }
}
