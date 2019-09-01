namespace SDM_Assignment
{
    partial class TechnicianMainMenu
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
            this.TechnicianMainMenuTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMachine = new System.Windows.Forms.TabPage();
            this.viewMachineDetailForTechnician = new SDM_Assignment.ViewMachineDetailForTechnician();
            this.viewMachineListForTechnician = new SDM_Assignment.SearchMachineForm();
            this.tabAppointment = new System.Windows.Forms.TabPage();
            this.viewAppointmentByTimeForTechnician1 = new SDM_Assignment.ViewAppointmentByTimeForTechnician();
            this.tabScheduleBlock = new System.Windows.Forms.TabPage();
            this.viewMachineScheduleBlock = new SDM_Assignment.SearchMachineForm();
            this.viewMachineScheduleBlockForTechnician = new SDM_Assignment.ViewMachineScheduleBlockForTechnician();
            this.TechnicianMainMenuTab.SuspendLayout();
            this.tabMachine.SuspendLayout();
            this.tabAppointment.SuspendLayout();
            this.tabScheduleBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TechnicianMainMenuTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(782, 30);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // TechnicianMainMenuTab
            // 
            this.TechnicianMainMenuTab.Controls.Add(this.tabMachine);
            this.TechnicianMainMenuTab.Controls.Add(this.tabAppointment);
            this.TechnicianMainMenuTab.Controls.Add(this.tabScheduleBlock);
            this.TechnicianMainMenuTab.Depth = 0;
            this.TechnicianMainMenuTab.Location = new System.Drawing.Point(0, 28);
            this.TechnicianMainMenuTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.TechnicianMainMenuTab.Name = "TechnicianMainMenuTab";
            this.TechnicianMainMenuTab.SelectedIndex = 0;
            this.TechnicianMainMenuTab.Size = new System.Drawing.Size(782, 470);
            this.TechnicianMainMenuTab.TabIndex = 1;
            // 
            // tabMachine
            // 
            this.tabMachine.BackColor = System.Drawing.Color.White;
            this.tabMachine.Controls.Add(this.viewMachineDetailForTechnician);
            this.tabMachine.Controls.Add(this.viewMachineListForTechnician);
            this.tabMachine.Location = new System.Drawing.Point(4, 22);
            this.tabMachine.Name = "tabMachine";
            this.tabMachine.Size = new System.Drawing.Size(774, 444);
            this.tabMachine.TabIndex = 0;
            this.tabMachine.Text = "Machine";
            // 
            // viewMachineDetailForTechnician
            // 
            this.viewMachineDetailForTechnician.Location = new System.Drawing.Point(0, 0);
            this.viewMachineDetailForTechnician.Name = "viewMachineDetailForTechnician";
            this.viewMachineDetailForTechnician.Size = new System.Drawing.Size(774, 444);
            this.viewMachineDetailForTechnician.TabIndex = 1;
            // 
            // viewMachineListForTechnician
            // 
            this.viewMachineListForTechnician.Location = new System.Drawing.Point(0, 0);
            this.viewMachineListForTechnician.Name = "viewMachineListForTechnician";
            this.viewMachineListForTechnician.Size = new System.Drawing.Size(774, 444);
            this.viewMachineListForTechnician.TabIndex = 0;
            // 
            // tabAppointment
            // 
            this.tabAppointment.BackColor = System.Drawing.Color.White;
            this.tabAppointment.Controls.Add(this.viewAppointmentByTimeForTechnician1);
            this.tabAppointment.Location = new System.Drawing.Point(4, 22);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.Size = new System.Drawing.Size(774, 444);
            this.tabAppointment.TabIndex = 1;
            this.tabAppointment.Text = "Appointment";
            // 
            // viewAppointmentByTimeForTechnician1
            // 
            this.viewAppointmentByTimeForTechnician1.Location = new System.Drawing.Point(0, 0);
            this.viewAppointmentByTimeForTechnician1.Name = "viewAppointmentByTimeForTechnician1";
            this.viewAppointmentByTimeForTechnician1.Size = new System.Drawing.Size(774, 444);
            this.viewAppointmentByTimeForTechnician1.TabIndex = 0;
            // 
            // tabScheduleBlock
            // 
            this.tabScheduleBlock.BackColor = System.Drawing.Color.White;
            this.tabScheduleBlock.Controls.Add(this.viewMachineScheduleBlockForTechnician);
            this.tabScheduleBlock.Controls.Add(this.viewMachineScheduleBlock);
            this.tabScheduleBlock.Location = new System.Drawing.Point(4, 22);
            this.tabScheduleBlock.Name = "tabScheduleBlock";
            this.tabScheduleBlock.Size = new System.Drawing.Size(774, 444);
            this.tabScheduleBlock.TabIndex = 2;
            this.tabScheduleBlock.Text = "Schdl Block";
            // 
            // viewMachineScheduleBlock
            // 
            this.viewMachineScheduleBlock.Location = new System.Drawing.Point(0, 0);
            this.viewMachineScheduleBlock.Name = "viewMachineScheduleBlock";
            this.viewMachineScheduleBlock.Size = new System.Drawing.Size(774, 444);
            this.viewMachineScheduleBlock.TabIndex = 0;
            // 
            // viewMachineScheduleBlockForTechnician
            // 
            this.viewMachineScheduleBlockForTechnician.Location = new System.Drawing.Point(0, 0);
            this.viewMachineScheduleBlockForTechnician.Name = "viewMachineScheduleBlockForTechnician";
            this.viewMachineScheduleBlockForTechnician.Size = new System.Drawing.Size(774, 444);
            this.viewMachineScheduleBlockForTechnician.TabIndex = 1;
            // 
            // TechnicianMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TechnicianMainMenuTab);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "TechnicianMainMenu";
            this.Size = new System.Drawing.Size(782, 498);
            this.TechnicianMainMenuTab.ResumeLayout(false);
            this.tabMachine.ResumeLayout(false);
            this.tabAppointment.ResumeLayout(false);
            this.tabScheduleBlock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl TechnicianMainMenuTab;
        private System.Windows.Forms.TabPage tabMachine;
        private System.Windows.Forms.TabPage tabAppointment;
        private System.Windows.Forms.TabPage tabScheduleBlock;
        private SearchMachineForm viewMachineListForTechnician;
        private ViewMachineDetailForTechnician viewMachineDetailForTechnician;
        private ViewAppointmentByTimeForTechnician viewAppointmentByTimeForTechnician1;
        private SearchMachineForm viewMachineScheduleBlock;
        private ViewMachineScheduleBlockForTechnician viewMachineScheduleBlockForTechnician;
    }
}
