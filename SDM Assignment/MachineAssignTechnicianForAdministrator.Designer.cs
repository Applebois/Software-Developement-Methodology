namespace SDM_Assignment
{
    partial class MachineAssignTechnicianForAdministrator
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
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonFilter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listViewTechnician = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "By ID",
            "By Username",
            "By Display Name"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(422, 8);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchBy.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "";
            this.textBoxSearch.Location = new System.Drawing.Point(549, 16);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(156, 23);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            // 
            // buttonFilter
            // 
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFilter.Depth = 0;
            this.buttonFilter.Icon = null;
            this.buttonFilter.Location = new System.Drawing.Point(711, 3);
            this.buttonFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Primary = true;
            this.buttonFilter.Size = new System.Drawing.Size(64, 36);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listViewTechnician
            // 
            this.listViewTechnician.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTechnician.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTechnician.Depth = 0;
            this.listViewTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTechnician.FullRowSelect = true;
            this.listViewTechnician.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTechnician.HideSelection = false;
            this.listViewTechnician.Location = new System.Drawing.Point(3, 45);
            this.listViewTechnician.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewTechnician.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewTechnician.Name = "listViewTechnician";
            this.listViewTechnician.OwnerDraw = true;
            this.listViewTechnician.Size = new System.Drawing.Size(772, 401);
            this.listViewTechnician.TabIndex = 5;
            this.listViewTechnician.UseCompatibleStateImageBehavior = false;
            this.listViewTechnician.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Display Name";
            this.columnHeader3.Width = 600;
            // 
            // MachineAssignTechnicianForAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.listViewTechnician);
            this.Name = "MachineAssignTechnicianForAdministrator";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFilter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal MaterialSkin.Controls.MaterialListView listViewTechnician;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
    }
}
