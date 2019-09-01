using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDM_Assignment
{
    public partial class ViewMachineDetailForTechnician : UserControl
    {
        private int formMachineId = 0;
        private int formTechnicianId = 0;
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public ViewMachineDetailForTechnician()
        {
            InitializeComponent();
            viewMaintenanceListForTechnician.Hide();
            viewMaintenanceListForTechnician.buttonBack.Click += new EventHandler(viewMaintenanceListForTechnicianButtonBack_Click);
            viewFollowUpMaintenanceForTechnician.Hide();
            viewFollowUpMaintenanceForTechnician.buttonBack.Click += new EventHandler(viewFollowUpMaintenanceForTechnicianButtonBack_Click);
        }

        public void updateViewMachineDetailForTechnicianForm(int machineId, int technicianId)
        {
            formMachineId = machineId;
            formTechnicianId = technicianId;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineId, MachineBrand, MachineModel, MachineCooldownMin, " +
                    "MachineSupplier, MachineSupplierContact, MachineManufactureDate, MachineNote, MachineStatus FROM Machine " +
                    "WHERE MachineId = @machineId", con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        textBoxMachineId.Text = dataReader["MachineId"].ToString();
                        textBoxMachineBrand.Text = dataReader["MachineBrand"].ToString();
                        textBoxMachineModel.Text = dataReader["MachineModel"].ToString();
                        textBoxMachineCooldownMin.Text = dataReader["MachineCooldownMin"].ToString();
                        textBoxMachineSupplier.Text = dataReader["MachineSupplier"].ToString();
                        textBoxMachineSupplierContact.Text = dataReader["MachineSupplierContact"].ToString();
                        textBoxMachineManufactureDate.Text = Convert.ToDateTime(dataReader["MachineManufactureDate"]).ToString("dd-MM-yyyy");
                        textBoxMachineNote.Text = dataReader["MachineNote"].ToString();
                        comboBoxMachineActive.SelectedIndex = Convert.ToInt32(dataReader["MachineStatus"]);
                    }
                }
                cmd.CommandText = "SELECT COUNT(TechnicianId) FROM MachineTechnician WHERE MachineId = @machineId AND TechnicianId = @technicianId;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                cmd.Parameters.AddWithValue("@technicianId", formTechnicianId);
                if (Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    buttonUpdate.Show();
                }
                else
                {
                    buttonUpdate.Hide();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Machine SET MachineStatus = @status WHERE MachineId = @machineId", con);
                cmd.Parameters.AddWithValue("@status", comboBoxMachineActive.SelectedIndex);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
        }

        private void viewMaintenanceListForTechnicianButtonBack_Click(object sender, EventArgs e)
        {
            viewMaintenanceListForTechnician.Hide();
        }

        private void buttonViewMachineMaintenance_Click(object sender, EventArgs e)
        {
            viewMaintenanceListForTechnician.updateViewMaintenanceListForTechnicianForm(formMachineId, formTechnicianId);
            viewMaintenanceListForTechnician.Show();
        }

        private void buttonViewFollowUp_Click(object sender, EventArgs e)
        {
            viewFollowUpMaintenanceForTechnician.updateViewFollowUpMaintenanceForTechnician(0, formMachineId, formTechnicianId);
            viewFollowUpMaintenanceForTechnician.Show();
        }

        private void viewFollowUpMaintenanceForTechnicianButtonBack_Click(object sender, EventArgs e)
        {
            viewFollowUpMaintenanceForTechnician.Hide();
        }
    }
}
