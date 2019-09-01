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
    public partial class ViewMachineDetailForAdministrator : UserControl
    {
        private int formMachineId = 0;
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public ViewMachineDetailForAdministrator()
        {
            InitializeComponent();
            viewMaintenanceListForAdministator.Hide();
            viewMaintenanceListForAdministator.buttonBack.Click += new EventHandler(viewMaintenanceListForAdministatorButtonBack_Click);
            viewMachineTechnicianListForAdministrator.Hide();
            viewMachineTechnicianListForAdministrator.buttonBack.Click += new EventHandler(viewMachineTechnicianListForAdministratorButtonBack_Click);
        }

        public void updateViewMachineDetailForAdministratorForm(int machineId)
        {
            formMachineId = machineId;
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
                        dateTimePickerMachineManufactureDate.Value = Convert.ToDateTime(dataReader["MachineManufactureDate"]);
                        textBoxMachineNote.Text = dataReader["MachineNote"].ToString();
                        comboBoxMachineActive.SelectedIndex = Convert.ToInt32(dataReader["MachineStatus"]);
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Machine SET MachineBrand = @machineBrand, MachineModel = @machineModel, " +
                    "MachineCooldownMin = @machineCooldown, MachineSupplier = @supplier, MachineSupplierContact = @supplierContact, " +
                    "MachineManufactureDate = @manufactureDate, MachineNote = @note, MachineStatus = @status WHERE MachineId = @machineId", con);
                cmd.Parameters.AddWithValue("@machineBrand", textBoxMachineBrand.Text);
                cmd.Parameters.AddWithValue("@machineModel", textBoxMachineModel.Text);
                cmd.Parameters.AddWithValue("@machineCooldown", textBoxMachineCooldownMin.Text);
                cmd.Parameters.AddWithValue("@supplier", textBoxMachineSupplier.Text);
                cmd.Parameters.AddWithValue("@supplierContact", textBoxMachineSupplierContact.Text);
                cmd.Parameters.AddWithValue("@manufactureDate", dateTimePickerMachineManufactureDate.Value);
                cmd.Parameters.AddWithValue("@note", textBoxMachineNote.Text);
                cmd.Parameters.AddWithValue("@status", comboBoxMachineActive.SelectedIndex);
                cmd.Parameters.AddWithValue("@machineId", textBoxMachineId.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
        }

        private void viewMaintenanceListForAdministatorButtonBack_Click(object sender, EventArgs e)
        {
            viewMaintenanceListForAdministator.Hide();
        }

        private void buttonViewMachineMaintenance_Click(object sender, EventArgs e)
        {
            viewMaintenanceListForAdministator.updateViewMaintenanceListForAdministator(formMachineId);
            viewMaintenanceListForAdministator.Show();
        }

        private void viewMachineTechnicianListForAdministratorButtonBack_Click(object sender, EventArgs e)
        {
            viewMachineTechnicianListForAdministrator.Hide();
        }

        private void buttonViewMachineTechnician_Click(object sender, EventArgs e)
        {
            viewMachineTechnicianListForAdministrator.updateViewMachineTechnicianListForAdministratorForm(formMachineId);
            viewMachineTechnicianListForAdministrator.Show();
        }
    }
}
