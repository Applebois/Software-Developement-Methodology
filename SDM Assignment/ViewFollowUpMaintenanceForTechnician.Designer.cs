namespace SDM_Assignment
{
    partial class ViewFollowUpMaintenanceForTechnician
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
            this.listViewFollowUp = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonNewFollowUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newFollowUpMaintenanceForTechnician = new SDM_Assignment.NewFollowUpMaintenanceForTechnician();
            this.SuspendLayout();
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
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // listViewFollowUp
            // 
            this.listViewFollowUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFollowUp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewFollowUp.Depth = 0;
            this.listViewFollowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewFollowUp.FullRowSelect = true;
            this.listViewFollowUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFollowUp.HideSelection = false;
            this.listViewFollowUp.Location = new System.Drawing.Point(3, 48);
            this.listViewFollowUp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewFollowUp.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewFollowUp.Name = "listViewFollowUp";
            this.listViewFollowUp.OwnerDraw = true;
            this.listViewFollowUp.Size = new System.Drawing.Size(772, 398);
            this.listViewFollowUp.TabIndex = 2;
            this.listViewFollowUp.UseCompatibleStateImageBehavior = false;
            this.listViewFollowUp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Follow Up Date";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Comment";
            this.columnHeader3.Width = 560;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Incomplete",
            "Completed"});
            this.comboBoxFilter.Location = new System.Drawing.Point(65, 7);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 28);
            this.comboBoxFilter.TabIndex = 4;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // buttonNewFollowUp
            // 
            this.buttonNewFollowUp.AutoSize = true;
            this.buttonNewFollowUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewFollowUp.Depth = 0;
            this.buttonNewFollowUp.Icon = null;
            this.buttonNewFollowUp.Location = new System.Drawing.Point(646, 3);
            this.buttonNewFollowUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewFollowUp.Name = "buttonNewFollowUp";
            this.buttonNewFollowUp.Primary = true;
            this.buttonNewFollowUp.Size = new System.Drawing.Size(129, 36);
            this.buttonNewFollowUp.TabIndex = 5;
            this.buttonNewFollowUp.Text = "New Follow Up";
            this.buttonNewFollowUp.UseVisualStyleBackColor = true;
            this.buttonNewFollowUp.Click += new System.EventHandler(this.buttonNewFollowUp_Click);
            // 
            // newFollowUpMaintenanceForTechnician
            // 
            this.newFollowUpMaintenanceForTechnician.Location = new System.Drawing.Point(0, 0);
            this.newFollowUpMaintenanceForTechnician.Name = "newFollowUpMaintenanceForTechnician";
            this.newFollowUpMaintenanceForTechnician.Size = new System.Drawing.Size(778, 449);
            this.newFollowUpMaintenanceForTechnician.TabIndex = 6;
            // 
            // ViewFollowUpMaintenanceForTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newFollowUpMaintenanceForTechnician);
            this.Controls.Add(this.buttonNewFollowUp);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewFollowUp);
            this.Name = "ViewFollowUpMaintenanceForTechnician";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        internal MaterialSkin.Controls.MaterialListView listViewFollowUp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNewFollowUp;
        private NewFollowUpMaintenanceForTechnician newFollowUpMaintenanceForTechnician;
    }
}
