namespace SDM_Assignment
{
    partial class ViewAppointmentByTimeForDoctor
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
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listViewListAppointment = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFilter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.buttonNewAppointment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.viewAppointmentDetailForDoctor = new SDM_Assignment.ViewAppointmentDetailForDoctor();
            this.SuspendLayout();
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "By Patient Name",
            "By Patient Identity",
            "By Doctor Name",
            "By Doctor Username",
            "By Machine Identity"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(9, 59);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(111, 26);
            this.comboBoxSearchBy.TabIndex = 16;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "";
            this.textBoxSearch.Location = new System.Drawing.Point(126, 61);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(150, 23);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            // 
            // listViewListAppointment
            // 
            this.listViewListAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewListAppointment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewListAppointment.Depth = 0;
            this.listViewListAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewListAppointment.FullRowSelect = true;
            this.listViewListAppointment.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListAppointment.HideSelection = false;
            this.listViewListAppointment.Location = new System.Drawing.Point(0, 90);
            this.listViewListAppointment.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewListAppointment.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewListAppointment.Name = "listViewListAppointment";
            this.listViewListAppointment.OwnerDraw = true;
            this.listViewListAppointment.Size = new System.Drawing.Size(778, 359);
            this.listViewListAppointment.TabIndex = 14;
            this.listViewListAppointment.UseCompatibleStateImageBehavior = false;
            this.listViewListAppointment.View = System.Windows.Forms.View.Details;
            this.listViewListAppointment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewListMachine_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patient";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doctor";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time Start";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time End";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Status";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MID";
            // 
            // buttonFilter
            // 
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFilter.Depth = 0;
            this.buttonFilter.Icon = null;
            this.buttonFilter.Location = new System.Drawing.Point(707, 54);
            this.buttonFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Primary = true;
            this.buttonFilter.Size = new System.Drawing.Size(64, 36);
            this.buttonFilter.TabIndex = 13;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(503, 63);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(26, 18);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "To";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(282, 62);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 18);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "From";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(536, 60);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(165, 24);
            this.dateTimePickerToDate.TabIndex = 10;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFromDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(332, 60);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(165, 24);
            this.dateTimePickerFromDate.TabIndex = 9;
            // 
            // buttonNewAppointment
            // 
            this.buttonNewAppointment.AutoSize = true;
            this.buttonNewAppointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewAppointment.Depth = 0;
            this.buttonNewAppointment.Icon = null;
            this.buttonNewAppointment.Location = new System.Drawing.Point(621, 12);
            this.buttonNewAppointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewAppointment.Name = "buttonNewAppointment";
            this.buttonNewAppointment.Primary = true;
            this.buttonNewAppointment.Size = new System.Drawing.Size(150, 36);
            this.buttonNewAppointment.TabIndex = 17;
            this.buttonNewAppointment.Text = "New Appointment";
            this.buttonNewAppointment.UseVisualStyleBackColor = true;
            // 
            // viewAppointmentDetailForDoctor
            // 
            this.viewAppointmentDetailForDoctor.Location = new System.Drawing.Point(0, 0);
            this.viewAppointmentDetailForDoctor.Name = "viewAppointmentDetailForDoctor";
            this.viewAppointmentDetailForDoctor.Size = new System.Drawing.Size(778, 449);
            this.viewAppointmentDetailForDoctor.TabIndex = 18;
            // 
            // ViewAppointmentByTimeForDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewAppointmentDetailForDoctor);
            this.Controls.Add(this.buttonNewAppointment);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewListAppointment);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Name = "ViewAppointmentByTimeForDoctor";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private MaterialSkin.Controls.MaterialListView listViewListAppointment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFilter;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonNewAppointment;
        private ViewAppointmentDetailForDoctor viewAppointmentDetailForDoctor;
    }
}
