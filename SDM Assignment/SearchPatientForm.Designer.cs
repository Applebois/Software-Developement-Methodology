namespace SDM_Assignment
{
    partial class SearchPatientForm
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
            this.listViewListPatient = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewListPatient
            // 
            this.listViewListPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewListPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewListPatient.Depth = 0;
            this.listViewListPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewListPatient.FullRowSelect = true;
            this.listViewListPatient.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListPatient.HideSelection = false;
            this.listViewListPatient.Location = new System.Drawing.Point(0, 53);
            this.listViewListPatient.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewListPatient.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewListPatient.Name = "listViewListPatient";
            this.listViewListPatient.OwnerDraw = true;
            this.listViewListPatient.Size = new System.Drawing.Size(778, 396);
            this.listViewListPatient.TabIndex = 0;
            this.listViewListPatient.UseCompatibleStateImageBehavior = false;
            this.listViewListPatient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Identity";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 340;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Age";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gender";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phone";
            this.columnHeader6.Width = 140;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "";
            this.textBoxSearch.Location = new System.Drawing.Point(479, 11);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(217, 23);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.Depth = 0;
            this.buttonSearch.Icon = null;
            this.buttonSearch.Location = new System.Drawing.Point(702, 3);
            this.buttonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Primary = true;
            this.buttonSearch.Size = new System.Drawing.Size(73, 36);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "By Name",
            "By Identity"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(355, 8);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchBy.TabIndex = 3;
            // 
            // SearchPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewListPatient);
            this.Name = "SearchPatientForm";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        internal MaterialSkin.Controls.MaterialListView listViewListPatient;
    }
}
