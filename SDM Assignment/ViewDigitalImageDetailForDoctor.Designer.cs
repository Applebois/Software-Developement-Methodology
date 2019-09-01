namespace SDM_Assignment
{
    partial class ViewDigitalImageDetailForDoctor
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonViewImage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonSaveAs = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonUpdateComment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxPatientDigitalImageId = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPatientRecordId = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDate = new MaterialSkin.Controls.MaterialLabel();
            this.saveFileDigitalImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(236, 221);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Image";
            // 
            // buttonViewImage
            // 
            this.buttonViewImage.AutoSize = true;
            this.buttonViewImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonViewImage.Depth = 0;
            this.buttonViewImage.Icon = null;
            this.buttonViewImage.Location = new System.Drawing.Point(292, 213);
            this.buttonViewImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonViewImage.Name = "buttonViewImage";
            this.buttonViewImage.Primary = true;
            this.buttonViewImage.Size = new System.Drawing.Size(54, 36);
            this.buttonViewImage.TabIndex = 1;
            this.buttonViewImage.Text = "View";
            this.buttonViewImage.UseVisualStyleBackColor = true;
            this.buttonViewImage.Click += new System.EventHandler(this.buttonViewImage_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.AutoSize = true;
            this.buttonSaveAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSaveAs.Depth = 0;
            this.buttonSaveAs.Icon = null;
            this.buttonSaveAs.Location = new System.Drawing.Point(352, 213);
            this.buttonSaveAs.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Primary = true;
            this.buttonSaveAs.Size = new System.Drawing.Size(76, 36);
            this.buttonSaveAs.TabIndex = 2;
            this.buttonSaveAs.Text = "Save As";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(236, 171);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Date";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(236, 125);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(145, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Patient Dig.Image ID";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(236, 84);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(125, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Patient Record ID";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(236, 267);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Comment";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Depth = 0;
            this.textBoxComment.Hint = "";
            this.textBoxComment.Location = new System.Drawing.Point(317, 263);
            this.textBoxComment.MaxLength = 32767;
            this.textBoxComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.PasswordChar = '\0';
            this.textBoxComment.SelectedText = "";
            this.textBoxComment.SelectionLength = 0;
            this.textBoxComment.SelectionStart = 0;
            this.textBoxComment.Size = new System.Drawing.Size(152, 23);
            this.textBoxComment.TabIndex = 7;
            this.textBoxComment.TabStop = false;
            this.textBoxComment.UseSystemPasswordChar = false;
            // 
            // buttonUpdateComment
            // 
            this.buttonUpdateComment.AutoSize = true;
            this.buttonUpdateComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdateComment.Depth = 0;
            this.buttonUpdateComment.Icon = null;
            this.buttonUpdateComment.Location = new System.Drawing.Point(475, 250);
            this.buttonUpdateComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdateComment.Name = "buttonUpdateComment";
            this.buttonUpdateComment.Primary = true;
            this.buttonUpdateComment.Size = new System.Drawing.Size(73, 36);
            this.buttonUpdateComment.TabIndex = 8;
            this.buttonUpdateComment.Text = "Update";
            this.buttonUpdateComment.UseVisualStyleBackColor = true;
            this.buttonUpdateComment.Click += new System.EventHandler(this.buttonUpdateComment_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.Icon = null;
            this.buttonDelete.Location = new System.Drawing.Point(694, 401);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Primary = true;
            this.buttonDelete.Size = new System.Drawing.Size(69, 36);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
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
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // textBoxPatientDigitalImageId
            // 
            this.textBoxPatientDigitalImageId.AutoSize = true;
            this.textBoxPatientDigitalImageId.Depth = 0;
            this.textBoxPatientDigitalImageId.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxPatientDigitalImageId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxPatientDigitalImageId.Location = new System.Drawing.Point(393, 125);
            this.textBoxPatientDigitalImageId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPatientDigitalImageId.Name = "textBoxPatientDigitalImageId";
            this.textBoxPatientDigitalImageId.Size = new System.Drawing.Size(27, 19);
            this.textBoxPatientDigitalImageId.TabIndex = 11;
            this.textBoxPatientDigitalImageId.Text = "IID";
            // 
            // textBoxPatientRecordId
            // 
            this.textBoxPatientRecordId.AutoSize = true;
            this.textBoxPatientRecordId.Depth = 0;
            this.textBoxPatientRecordId.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxPatientRecordId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxPatientRecordId.Location = new System.Drawing.Point(393, 84);
            this.textBoxPatientRecordId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPatientRecordId.Name = "textBoxPatientRecordId";
            this.textBoxPatientRecordId.Size = new System.Drawing.Size(32, 19);
            this.textBoxPatientRecordId.TabIndex = 12;
            this.textBoxPatientRecordId.Text = "RID";
            // 
            // textBoxDate
            // 
            this.textBoxDate.AutoSize = true;
            this.textBoxDate.Depth = 0;
            this.textBoxDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDate.Location = new System.Drawing.Point(393, 171);
            this.textBoxDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(40, 19);
            this.textBoxDate.TabIndex = 13;
            this.textBoxDate.Text = "Date";
            // 
            // ViewDigitalImageDetailForDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxPatientRecordId);
            this.Controls.Add(this.textBoxPatientDigitalImageId);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdateComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonViewImage);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ViewDigitalImageDetailForDoctor";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonViewImage;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSaveAs;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxComment;
        private MaterialSkin.Controls.MaterialRaisedButton buttonUpdateComment;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialLabel textBoxPatientDigitalImageId;
        private MaterialSkin.Controls.MaterialLabel textBoxPatientRecordId;
        private MaterialSkin.Controls.MaterialLabel textBoxDate;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonDelete;
        private System.Windows.Forms.SaveFileDialog saveFileDigitalImageDialog;
    }
}
