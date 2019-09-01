namespace SDM_Assignment
{
    partial class ViewMachineScheduleBlockForTechnician
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
            this.listViewMachineScheduleBlock = new MaterialSkin.Controls.MaterialListView();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonNewScheduleBlock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newMachineScheduleBlockForTechnician = new SDM_Assignment.NewMachineScheduleBlockForTechnician();
            this.SuspendLayout();
            // 
            // listViewMachineScheduleBlock
            // 
            this.listViewMachineScheduleBlock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMachineScheduleBlock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMachineScheduleBlock.Depth = 0;
            this.listViewMachineScheduleBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewMachineScheduleBlock.FullRowSelect = true;
            this.listViewMachineScheduleBlock.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMachineScheduleBlock.HideSelection = false;
            this.listViewMachineScheduleBlock.Location = new System.Drawing.Point(0, 45);
            this.listViewMachineScheduleBlock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewMachineScheduleBlock.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewMachineScheduleBlock.Name = "listViewMachineScheduleBlock";
            this.listViewMachineScheduleBlock.OwnerDraw = true;
            this.listViewMachineScheduleBlock.Size = new System.Drawing.Size(778, 404);
            this.listViewMachineScheduleBlock.TabIndex = 0;
            this.listViewMachineScheduleBlock.UseCompatibleStateImageBehavior = false;
            this.listViewMachineScheduleBlock.View = System.Windows.Forms.View.Details;
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
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNewScheduleBlock
            // 
            this.buttonNewScheduleBlock.AutoSize = true;
            this.buttonNewScheduleBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewScheduleBlock.Depth = 0;
            this.buttonNewScheduleBlock.Icon = null;
            this.buttonNewScheduleBlock.Location = new System.Drawing.Point(607, 3);
            this.buttonNewScheduleBlock.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewScheduleBlock.Name = "buttonNewScheduleBlock";
            this.buttonNewScheduleBlock.Primary = true;
            this.buttonNewScheduleBlock.Size = new System.Drawing.Size(168, 36);
            this.buttonNewScheduleBlock.TabIndex = 2;
            this.buttonNewScheduleBlock.Text = "New Schedule Block";
            this.buttonNewScheduleBlock.UseVisualStyleBackColor = true;
            this.buttonNewScheduleBlock.Click += new System.EventHandler(this.buttonNewScheduleBlock_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start Date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "End Date";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comment";
            this.columnHeader4.Width = 510;
            // 
            // newMachineScheduleBlockForTechnician
            // 
            this.newMachineScheduleBlockForTechnician.Location = new System.Drawing.Point(0, 0);
            this.newMachineScheduleBlockForTechnician.Name = "newMachineScheduleBlockForTechnician";
            this.newMachineScheduleBlockForTechnician.Size = new System.Drawing.Size(778, 449);
            this.newMachineScheduleBlockForTechnician.TabIndex = 3;
            // 
            // ViewMachineScheduleBlockForTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newMachineScheduleBlockForTechnician);
            this.Controls.Add(this.buttonNewScheduleBlock);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewMachineScheduleBlock);
            this.Name = "ViewMachineScheduleBlockForTechnician";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewMachineScheduleBlock;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNewScheduleBlock;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private NewMachineScheduleBlockForTechnician newMachineScheduleBlockForTechnician;
        internal MaterialSkin.Controls.MaterialRaisedButton buttonBack;
    }
}
