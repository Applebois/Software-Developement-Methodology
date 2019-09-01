namespace SDM_Assignment
{
    partial class ViewPatientRecordForFrontCounter
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
            this.listViewListPatientRecord = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewPatientRecord = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newPatientRecord = new SDM_Assignment.NewPatientRecord();
            this.viewPatientRecordDetail = new SDM_Assignment.ViewPatientRecordDetailForFrontCounter();
            this.SuspendLayout();
            // 
            // listViewListPatientRecord
            // 
            this.listViewListPatientRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewListPatientRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewListPatientRecord.Depth = 0;
            this.listViewListPatientRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewListPatientRecord.FullRowSelect = true;
            this.listViewListPatientRecord.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListPatientRecord.HideSelection = false;
            this.listViewListPatientRecord.Location = new System.Drawing.Point(0, 69);
            this.listViewListPatientRecord.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewListPatientRecord.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewListPatientRecord.Name = "listViewListPatientRecord";
            this.listViewListPatientRecord.OwnerDraw = true;
            this.listViewListPatientRecord.Size = new System.Drawing.Size(778, 380);
            this.listViewListPatientRecord.TabIndex = 0;
            this.listViewListPatientRecord.UseCompatibleStateImageBehavior = false;
            this.listViewListPatientRecord.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doctor";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start DateTime";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "End DateTime";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Comment";
            this.columnHeader5.Width = 315;
            // 
            // buttonNewPatientRecord
            // 
            this.buttonNewPatientRecord.AutoSize = true;
            this.buttonNewPatientRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewPatientRecord.Depth = 0;
            this.buttonNewPatientRecord.Icon = null;
            this.buttonNewPatientRecord.Location = new System.Drawing.Point(595, 16);
            this.buttonNewPatientRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewPatientRecord.Name = "buttonNewPatientRecord";
            this.buttonNewPatientRecord.Primary = true;
            this.buttonNewPatientRecord.Size = new System.Drawing.Size(166, 36);
            this.buttonNewPatientRecord.TabIndex = 1;
            this.buttonNewPatientRecord.Text = "New Patient Record";
            this.buttonNewPatientRecord.UseVisualStyleBackColor = true;
            this.buttonNewPatientRecord.Click += new System.EventHandler(this.buttonNewPatientRecord_Click);
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
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // newPatientRecord
            // 
            this.newPatientRecord.Location = new System.Drawing.Point(0, 0);
            this.newPatientRecord.Name = "newPatientRecord";
            this.newPatientRecord.Size = new System.Drawing.Size(778, 449);
            this.newPatientRecord.TabIndex = 4;
            // 
            // viewPatientRecordDetail
            // 
            this.viewPatientRecordDetail.Location = new System.Drawing.Point(0, 0);
            this.viewPatientRecordDetail.Name = "viewPatientRecordDetail";
            this.viewPatientRecordDetail.Size = new System.Drawing.Size(778, 449);
            this.viewPatientRecordDetail.TabIndex = 3;
            // 
            // ViewPatientRecordForFrontCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newPatientRecord);
            this.Controls.Add(this.viewPatientRecordDetail);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNewPatientRecord);
            this.Controls.Add(this.listViewListPatientRecord);
            this.Name = "ViewPatientRecordForFrontCounter";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewListPatientRecord;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNewPatientRecord;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private ViewPatientRecordDetailForFrontCounter viewPatientRecordDetail;
        private NewPatientRecord newPatientRecord;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
    }
}
