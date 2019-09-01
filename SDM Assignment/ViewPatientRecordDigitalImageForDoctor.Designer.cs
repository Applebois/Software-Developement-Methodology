namespace SDM_Assignment
{
    partial class ViewPatientRecordDigitalImageForDoctor
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
            this.listViewListPatientDigitalImage = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelComment = new MaterialSkin.Controls.MaterialLabel();
            this.buttonNewPatientDigitalImage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxDigitalImage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonBrowse = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelDigitalImage = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.openFileDigitalImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.viewDigitalImageDetailForDoctor = new SDM_Assignment.ViewDigitalImageDetailForDoctor();
            this.SuspendLayout();
            // 
            // listViewListPatientDigitalImage
            // 
            this.listViewListPatientDigitalImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewListPatientDigitalImage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewListPatientDigitalImage.Depth = 0;
            this.listViewListPatientDigitalImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewListPatientDigitalImage.FullRowSelect = true;
            this.listViewListPatientDigitalImage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewListPatientDigitalImage.HideSelection = false;
            this.listViewListPatientDigitalImage.Location = new System.Drawing.Point(3, 136);
            this.listViewListPatientDigitalImage.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewListPatientDigitalImage.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewListPatientDigitalImage.Name = "listViewListPatientDigitalImage";
            this.listViewListPatientDigitalImage.OwnerDraw = true;
            this.listViewListPatientDigitalImage.Size = new System.Drawing.Size(772, 310);
            this.listViewListPatientDigitalImage.TabIndex = 0;
            this.listViewListPatientDigitalImage.UseCompatibleStateImageBehavior = false;
            this.listViewListPatientDigitalImage.View = System.Windows.Forms.View.Details;
            this.listViewListPatientDigitalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewListPatientDigitalImage_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Comment";
            this.columnHeader2.Width = 573;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 143;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Depth = 0;
            this.labelComment.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelComment.Location = new System.Drawing.Point(5, 60);
            this.labelComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(75, 19);
            this.labelComment.TabIndex = 1;
            this.labelComment.Text = "Comment";
            // 
            // buttonNewPatientDigitalImage
            // 
            this.buttonNewPatientDigitalImage.AutoSize = true;
            this.buttonNewPatientDigitalImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewPatientDigitalImage.Depth = 0;
            this.buttonNewPatientDigitalImage.Icon = null;
            this.buttonNewPatientDigitalImage.Location = new System.Drawing.Point(613, 90);
            this.buttonNewPatientDigitalImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewPatientDigitalImage.Name = "buttonNewPatientDigitalImage";
            this.buttonNewPatientDigitalImage.Primary = true;
            this.buttonNewPatientDigitalImage.Size = new System.Drawing.Size(152, 36);
            this.buttonNewPatientDigitalImage.TabIndex = 2;
            this.buttonNewPatientDigitalImage.Text = "Upload New Image";
            this.buttonNewPatientDigitalImage.UseVisualStyleBackColor = true;
            this.buttonNewPatientDigitalImage.Click += new System.EventHandler(this.buttonNewPatientDigitalImage_Click);
            // 
            // textBoxDigitalImage
            // 
            this.textBoxDigitalImage.Depth = 0;
            this.textBoxDigitalImage.Hint = "";
            this.textBoxDigitalImage.Location = new System.Drawing.Point(86, 98);
            this.textBoxDigitalImage.MaxLength = 32767;
            this.textBoxDigitalImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDigitalImage.Name = "textBoxDigitalImage";
            this.textBoxDigitalImage.PasswordChar = '\0';
            this.textBoxDigitalImage.SelectedText = "";
            this.textBoxDigitalImage.SelectionLength = 0;
            this.textBoxDigitalImage.SelectionStart = 0;
            this.textBoxDigitalImage.Size = new System.Drawing.Size(154, 23);
            this.textBoxDigitalImage.TabIndex = 3;
            this.textBoxDigitalImage.TabStop = false;
            this.textBoxDigitalImage.UseSystemPasswordChar = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBrowse.Depth = 0;
            this.buttonBrowse.Icon = null;
            this.buttonBrowse.Location = new System.Drawing.Point(246, 85);
            this.buttonBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Primary = true;
            this.buttonBrowse.Size = new System.Drawing.Size(76, 36);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelDigitalImage
            // 
            this.labelDigitalImage.AutoSize = true;
            this.labelDigitalImage.Depth = 0;
            this.labelDigitalImage.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDigitalImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDigitalImage.Location = new System.Drawing.Point(5, 98);
            this.labelDigitalImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDigitalImage.Name = "labelDigitalImage";
            this.labelDigitalImage.Size = new System.Drawing.Size(50, 19);
            this.labelDigitalImage.TabIndex = 5;
            this.labelDigitalImage.Text = "Image";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Depth = 0;
            this.textBoxComment.Hint = "";
            this.textBoxComment.Location = new System.Drawing.Point(86, 61);
            this.textBoxComment.MaxLength = 32767;
            this.textBoxComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.PasswordChar = '\0';
            this.textBoxComment.SelectedText = "";
            this.textBoxComment.SelectionLength = 0;
            this.textBoxComment.SelectionStart = 0;
            this.textBoxComment.Size = new System.Drawing.Size(679, 23);
            this.textBoxComment.TabIndex = 6;
            this.textBoxComment.TabStop = false;
            this.textBoxComment.UseSystemPasswordChar = false;
            // 
            // openFileDigitalImageDialog
            // 
            this.openFileDigitalImageDialog.FileName = "openFileDialog1";
            this.openFileDigitalImageDialog.Multiselect = true;
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
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // viewDigitalImageDetailForDoctor
            // 
            this.viewDigitalImageDetailForDoctor.Location = new System.Drawing.Point(0, 0);
            this.viewDigitalImageDetailForDoctor.Name = "viewDigitalImageDetailForDoctor";
            this.viewDigitalImageDetailForDoctor.Size = new System.Drawing.Size(778, 449);
            this.viewDigitalImageDetailForDoctor.TabIndex = 8;
            // 
            // ViewPatientRecordDigitalImageForDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewDigitalImageDetailForDoctor);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDigitalImage);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxDigitalImage);
            this.Controls.Add(this.buttonNewPatientDigitalImage);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.listViewListPatientDigitalImage);
            this.Name = "ViewPatientRecordDigitalImageForDoctor";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewListPatientDigitalImage;
        private MaterialSkin.Controls.MaterialLabel labelComment;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNewPatientDigitalImage;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDigitalImage;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBrowse;
        private MaterialSkin.Controls.MaterialLabel labelDigitalImage;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxComment;
        private System.Windows.Forms.OpenFileDialog openFileDigitalImageDialog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private ViewDigitalImageDetailForDoctor viewDigitalImageDetailForDoctor;
    }
}
