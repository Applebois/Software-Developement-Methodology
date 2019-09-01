namespace SDM_Assignment
{
    partial class DoctorMainMenu
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.DoctorMainMenuTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabViewPatient = new System.Windows.Forms.TabPage();
            this.patientDetail = new SDM_Assignment.PatientDetail();
            this.viewPatientListForm = new SDM_Assignment.SearchPatientForm();
            this.tabViewAppointment = new System.Windows.Forms.TabPage();
            this.viewAppointmentByTimeForDoctor = new SDM_Assignment.ViewAppointmentByTimeForDoctor();
            this.newAppointmentFormForDoctor = new SDM_Assignment.NewAppointmentFormForDoctor();
            this.DoctorMainMenuTab.SuspendLayout();
            this.tabViewPatient.SuspendLayout();
            this.tabViewAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.DoctorMainMenuTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(784, 30);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // DoctorMainMenuTab
            // 
            this.DoctorMainMenuTab.Controls.Add(this.tabViewPatient);
            this.DoctorMainMenuTab.Controls.Add(this.tabViewAppointment);
            this.DoctorMainMenuTab.Depth = 0;
            this.DoctorMainMenuTab.Location = new System.Drawing.Point(0, 27);
            this.DoctorMainMenuTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoctorMainMenuTab.Name = "DoctorMainMenuTab";
            this.DoctorMainMenuTab.SelectedIndex = 0;
            this.DoctorMainMenuTab.Size = new System.Drawing.Size(782, 471);
            this.DoctorMainMenuTab.TabIndex = 6;
            // 
            // tabViewPatient
            // 
            this.tabViewPatient.Controls.Add(this.patientDetail);
            this.tabViewPatient.Controls.Add(this.viewPatientListForm);
            this.tabViewPatient.Location = new System.Drawing.Point(4, 22);
            this.tabViewPatient.Name = "tabViewPatient";
            this.tabViewPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewPatient.Size = new System.Drawing.Size(774, 445);
            this.tabViewPatient.TabIndex = 0;
            this.tabViewPatient.Text = "Patients";
            this.tabViewPatient.UseVisualStyleBackColor = true;
            // 
            // patientDetail
            // 
            this.patientDetail.Location = new System.Drawing.Point(0, 0);
            this.patientDetail.Name = "patientDetail";
            this.patientDetail.Size = new System.Drawing.Size(778, 449);
            this.patientDetail.TabIndex = 1;
            // 
            // viewPatientListForm
            // 
            this.viewPatientListForm.BackColor = System.Drawing.Color.White;
            this.viewPatientListForm.Location = new System.Drawing.Point(0, 0);
            this.viewPatientListForm.Name = "viewPatientListForm";
            this.viewPatientListForm.Size = new System.Drawing.Size(778, 449);
            this.viewPatientListForm.TabIndex = 0;
            // 
            // tabViewAppointment
            // 
            this.tabViewAppointment.BackColor = System.Drawing.Color.White;
            this.tabViewAppointment.Controls.Add(this.newAppointmentFormForDoctor);
            this.tabViewAppointment.Controls.Add(this.viewAppointmentByTimeForDoctor);
            this.tabViewAppointment.Location = new System.Drawing.Point(4, 22);
            this.tabViewAppointment.Name = "tabViewAppointment";
            this.tabViewAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAppointment.Size = new System.Drawing.Size(774, 445);
            this.tabViewAppointment.TabIndex = 1;
            this.tabViewAppointment.Text = "View Appointment";
            // 
            // viewAppointmentByTimeForDoctor
            // 
            this.viewAppointmentByTimeForDoctor.Location = new System.Drawing.Point(0, 0);
            this.viewAppointmentByTimeForDoctor.Name = "viewAppointmentByTimeForDoctor";
            this.viewAppointmentByTimeForDoctor.Size = new System.Drawing.Size(784, 449);
            this.viewAppointmentByTimeForDoctor.TabIndex = 0;
            // 
            // newAppointmentFormForDoctor
            // 
            this.newAppointmentFormForDoctor.Location = new System.Drawing.Point(0, 0);
            this.newAppointmentFormForDoctor.Name = "newAppointmentFormForDoctor";
            this.newAppointmentFormForDoctor.Size = new System.Drawing.Size(777, 449);
            this.newAppointmentFormForDoctor.TabIndex = 1;
            // 
            // DoctorMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.DoctorMainMenuTab);
            this.Name = "DoctorMainMenu";
            this.Size = new System.Drawing.Size(784, 498);
            this.DoctorMainMenuTab.ResumeLayout(false);
            this.tabViewPatient.ResumeLayout(false);
            this.tabViewAppointment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl DoctorMainMenuTab;
        private System.Windows.Forms.TabPage tabViewPatient;
        private System.Windows.Forms.TabPage tabViewAppointment;
        private SearchPatientForm viewPatientListForm;
        private PatientDetail patientDetail;
        private ViewAppointmentByTimeForDoctor viewAppointmentByTimeForDoctor;
        private NewAppointmentFormForDoctor newAppointmentFormForDoctor;
    }
}
