namespace SDM_Assignment
{
    partial class SearchMachineForm
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
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listViewListMachine = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "By Id",
            "By Brand",
            "By Model"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(352, 9);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchBy.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.Depth = 0;
            this.buttonSearch.Icon = null;
            this.buttonSearch.Location = new System.Drawing.Point(702, 4);
            this.buttonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Primary = true;
            this.buttonSearch.Size = new System.Drawing.Size(73, 36);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "";
            this.textBoxSearch.Location = new System.Drawing.Point(479, 12);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(217, 23);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            // 
            // listViewListMachine
            // 
            this.listViewListMachine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewListMachine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewListMachine.Depth = 0;
            this.listViewListMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewListMachine.FullRowSelect = true;
            this.listViewListMachine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListMachine.HideSelection = false;
            this.listViewListMachine.Location = new System.Drawing.Point(0, 54);
            this.listViewListMachine.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewListMachine.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewListMachine.Name = "listViewListMachine";
            this.listViewListMachine.OwnerDraw = true;
            this.listViewListMachine.Size = new System.Drawing.Size(778, 396);
            this.listViewListMachine.TabIndex = 4;
            this.listViewListMachine.UseCompatibleStateImageBehavior = false;
            this.listViewListMachine.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Brand";
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Model";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Last Used";
            this.columnHeader10.Width = 190;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Cooldown";
            this.columnHeader11.Width = 95;
            // 
            // SearchMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewListMachine);
            this.Name = "SearchMachineForm";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        internal MaterialSkin.Controls.MaterialListView listViewListMachine;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}
