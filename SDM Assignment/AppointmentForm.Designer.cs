namespace SDM_Assignment
{
    partial class AppointmentForm
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
            this.viewAppointmentByTime = new SDM_Assignment.ViewAppointmentByTimeForFrontCounter();
            this.SuspendLayout();
            // 
            // viewAppointmentByTime
            // 
            this.viewAppointmentByTime.Location = new System.Drawing.Point(0, 0);
            this.viewAppointmentByTime.Name = "viewAppointmentByTime";
            this.viewAppointmentByTime.Size = new System.Drawing.Size(778, 449);
            this.viewAppointmentByTime.TabIndex = 7;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewAppointmentByTime);
            this.Name = "AppointmentForm";
            this.Size = new System.Drawing.Size(778, 449);
            this.ResumeLayout(false);

        }

        #endregion

        internal ViewAppointmentByTimeForFrontCounter viewAppointmentByTime;
    }
}
