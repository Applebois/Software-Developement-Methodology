namespace SDM_Assignment
{
    partial class FrontCounterMainMenu
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
            this.FrontCounterMainMenuTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabRegisterPatient = new System.Windows.Forms.TabPage();
            this.patientRegisterForm = new SDM_Assignment.PatientRegisterForm();
            this.tabLogPatient = new System.Windows.Forms.TabPage();
            this.viewPatientRecordByPatient = new SDM_Assignment.ViewPatientRecordForFrontCounter();
            this.logPatientForm = new SDM_Assignment.SearchPatientForm();
            this.tabViewAppointment = new System.Windows.Forms.TabPage();
            this.newAppointmentForm = new SDM_Assignment.NewAppointmentFormForFrontCounter();
            this.viewAppointmentByTimeForFrontCounter = new SDM_Assignment.ViewAppointmentByTimeForFrontCounter();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.paymentForFrontCounter1 = new SDM_Assignment.PaymentForFrontCounter();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.FrontCounterMainMenuTab.SuspendLayout();
            this.tabRegisterPatient.SuspendLayout();
            this.tabLogPatient.SuspendLayout();
            this.tabViewAppointment.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrontCounterMainMenuTab
            // 
            this.FrontCounterMainMenuTab.Controls.Add(this.tabRegisterPatient);
            this.FrontCounterMainMenuTab.Controls.Add(this.tabLogPatient);
            this.FrontCounterMainMenuTab.Controls.Add(this.tabViewAppointment);
            this.FrontCounterMainMenuTab.Controls.Add(this.tabPayment);
            this.FrontCounterMainMenuTab.Depth = 0;
            this.FrontCounterMainMenuTab.Location = new System.Drawing.Point(0, 27);
            this.FrontCounterMainMenuTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.FrontCounterMainMenuTab.Name = "FrontCounterMainMenuTab";
            this.FrontCounterMainMenuTab.SelectedIndex = 0;
            this.FrontCounterMainMenuTab.Size = new System.Drawing.Size(782, 471);
            this.FrontCounterMainMenuTab.TabIndex = 3;
            // 
            // tabRegisterPatient
            // 
            this.tabRegisterPatient.Controls.Add(this.patientRegisterForm);
            this.tabRegisterPatient.Location = new System.Drawing.Point(4, 22);
            this.tabRegisterPatient.Name = "tabRegisterPatient";
            this.tabRegisterPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegisterPatient.Size = new System.Drawing.Size(774, 445);
            this.tabRegisterPatient.TabIndex = 0;
            this.tabRegisterPatient.Text = "Register Patient";
            // 
            // patientRegisterForm
            // 
            this.patientRegisterForm.Location = new System.Drawing.Point(0, 0);
            this.patientRegisterForm.Name = "patientRegisterForm";
            this.patientRegisterForm.Size = new System.Drawing.Size(778, 449);
            this.patientRegisterForm.TabIndex = 0;
            // 
            // tabLogPatient
            // 
            this.tabLogPatient.BackColor = System.Drawing.Color.White;
            this.tabLogPatient.Controls.Add(this.viewPatientRecordByPatient);
            this.tabLogPatient.Controls.Add(this.logPatientForm);
            this.tabLogPatient.Location = new System.Drawing.Point(4, 22);
            this.tabLogPatient.Name = "tabLogPatient";
            this.tabLogPatient.Size = new System.Drawing.Size(774, 445);
            this.tabLogPatient.TabIndex = 2;
            this.tabLogPatient.Text = "Log Patient";
            // 
            // viewPatientRecordByPatient
            // 
            this.viewPatientRecordByPatient.Location = new System.Drawing.Point(0, 0);
            this.viewPatientRecordByPatient.Name = "viewPatientRecordByPatient";
            this.viewPatientRecordByPatient.Size = new System.Drawing.Size(780, 449);
            this.viewPatientRecordByPatient.TabIndex = 1;
            // 
            // logPatientForm
            // 
            this.logPatientForm.BackColor = System.Drawing.Color.White;
            this.logPatientForm.Location = new System.Drawing.Point(0, 0);
            this.logPatientForm.Name = "logPatientForm";
            this.logPatientForm.Size = new System.Drawing.Size(778, 449);
            this.logPatientForm.TabIndex = 0;
            // 
            // tabViewAppointment
            // 
            this.tabViewAppointment.BackColor = System.Drawing.Color.White;
            this.tabViewAppointment.Controls.Add(this.newAppointmentForm);
            this.tabViewAppointment.Controls.Add(this.viewAppointmentByTimeForFrontCounter);
            this.tabViewAppointment.Location = new System.Drawing.Point(4, 22);
            this.tabViewAppointment.Name = "tabViewAppointment";
            this.tabViewAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAppointment.Size = new System.Drawing.Size(774, 445);
            this.tabViewAppointment.TabIndex = 1;
            this.tabViewAppointment.Text = "Appointment";
            // 
            // newAppointmentForm
            // 
            this.newAppointmentForm.BackColor = System.Drawing.Color.White;
            this.newAppointmentForm.Location = new System.Drawing.Point(-4, 0);
            this.newAppointmentForm.Name = "newAppointmentForm";
            this.newAppointmentForm.Size = new System.Drawing.Size(784, 449);
            this.newAppointmentForm.TabIndex = 1;
            // 
            // viewAppointmentByTimeForFrontCounter
            // 
            this.viewAppointmentByTimeForFrontCounter.Location = new System.Drawing.Point(-4, 0);
            this.viewAppointmentByTimeForFrontCounter.Name = "viewAppointmentByTimeForFrontCounter";
            this.viewAppointmentByTimeForFrontCounter.Size = new System.Drawing.Size(784, 449);
            this.viewAppointmentByTimeForFrontCounter.TabIndex = 0;
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.paymentForFrontCounter1);
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Size = new System.Drawing.Size(774, 445);
            this.tabPayment.TabIndex = 3;
            this.tabPayment.Text = "Payment";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // paymentForFrontCounter1
            // 
            this.paymentForFrontCounter1.Location = new System.Drawing.Point(0, 0);
            this.paymentForFrontCounter1.Name = "paymentForFrontCounter1";
            this.paymentForFrontCounter1.Size = new System.Drawing.Size(784, 449);
            this.paymentForFrontCounter1.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.FrontCounterMainMenuTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(784, 30);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // FrontCounterMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.FrontCounterMainMenuTab);
            this.Name = "FrontCounterMainMenu";
            this.Size = new System.Drawing.Size(784, 498);
            this.FrontCounterMainMenuTab.ResumeLayout(false);
            this.tabRegisterPatient.ResumeLayout(false);
            this.tabLogPatient.ResumeLayout(false);
            this.tabViewAppointment.ResumeLayout(false);
            this.tabPayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl FrontCounterMainMenuTab;
        private System.Windows.Forms.TabPage tabRegisterPatient;
        private System.Windows.Forms.TabPage tabViewAppointment;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabLogPatient;
        private PatientRegisterForm patientRegisterForm;
        private SearchPatientForm logPatientForm;
        private NewAppointmentFormForFrontCounter newAppointmentForm;
        private ViewPatientRecordForFrontCounter viewPatientRecordByPatient;
        private SDM_Assignment.ViewAppointmentByTimeForFrontCounter viewAppointmentByTimeForFrontCounter;
        private System.Windows.Forms.TabPage tabPayment;
        private PaymentForFrontCounter paymentForFrontCounter1;
    }
}
