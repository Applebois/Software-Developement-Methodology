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
    public partial class ViewFollowUpMaintenanceForTechnician : UserControl
    {
        private int formMachineId = 0;
        private int formTechnicianId = 0;
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public ViewFollowUpMaintenanceForTechnician()
        {
            InitializeComponent();
            comboBoxFilter.SelectedIndex = 0;
            newFollowUpMaintenanceForTechnician.Hide();
            newFollowUpMaintenanceForTechnician.buttonBack.Click += new EventHandler(newFollowUpMaintenanceForTechnicianButtonBack_Click);
            newFollowUpMaintenanceForTechnician.buttonNewFollowUp.Click += new EventHandler(newFollowUpMaintenanceForTechnicianButtonNewFollowUp_Click);
        }

        public void updateViewFollowUpMaintenanceForTechnician(int filterCondition, int machineId, int technicianId)
        {
            formMachineId = machineId;
            formTechnicianId = technicianId;
            string[] sql =
            {
                "SELECT MachineFollowUpMaintenanceId, MachineFollowUpMaintenanceDate, MachineFollowUpMaintenanceComment " +
                    "FROM MachineFollowUpMaintenance WHERE MachineFollowUpMaintenanceId NOT IN (SELECT MachineFollowUpMaintenanceId " +
                    "FROM MachineMaintenanceHistory WHERE MachineFollowUpMaintenanceId IS NOT NULL AND MachineId = @machineId) AND MachineId = @machineId",
                "SELECT MachineFollowUpMaintenanceId, MachineFollowUpMaintenanceDate, MachineFollowUpMaintenanceComment FROM " +
                    "MachineFollowUpMaintenance WHERE MachineFollowUpMaintenanceId IN (SELECT MachineFollowUpMaintenanceId FROM " +
                    "MachineMaintenanceHistory WHERE MachineFollowUpMaintenanceId IS NOT NULL AND MachineId = @machineId) AND MachineId = @machineId"
            };

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                listViewFollowUp.Items.Clear();
                MySqlCommand cmd = new MySqlCommand(sql[filterCondition], con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                using(MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["MachineFollowUpMaintenanceId"].ToString());
                        item.SubItems.Add(dataReader["MachineFollowUpMaintenanceDate"].ToString());
                        item.SubItems.Add(dataReader["MachineFollowUpMaintenanceComment"].ToString());
                        listViewFollowUp.Items.Add(item);
                    }
                }
                cmd.CommandText = "SELECT COUNT(TechnicianId) FROM MachineTechnician WHERE MachineId = @machineId AND TechnicianId = @technicianId;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                cmd.Parameters.AddWithValue("@technicianId", formTechnicianId);
                if (Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    buttonNewFollowUp.Show();
                }
                else
                {
                    buttonNewFollowUp.Hide();
                }
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateViewFollowUpMaintenanceForTechnician(((ComboBox)sender).SelectedIndex, formMachineId, formTechnicianId);
        }

        private void buttonNewFollowUp_Click(object sender, EventArgs e)
        {
            newFollowUpMaintenanceForTechnician.updateNewFollowUpMaintenanceForTechnician(formMachineId);
            newFollowUpMaintenanceForTechnician.Show();
        }

        private void newFollowUpMaintenanceForTechnicianButtonBack_Click(object sender , EventArgs e)
        {
            updateViewFollowUpMaintenanceForTechnician(0, formMachineId, formTechnicianId);
            newFollowUpMaintenanceForTechnician.Hide();
        }

        private void newFollowUpMaintenanceForTechnicianButtonNewFollowUp_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO MachineFollowUpMaintenance (MachineId, " +
                    "MachineFollowUpMaintenanceDate, MachineFollowUpMaintenanceComment) VALUES (@machineId, @date, @comment);", con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                cmd.Parameters.AddWithValue("@date", newFollowUpMaintenanceForTechnician.dateTimePickerFollowUpMaintenanceDate.Value);
                cmd.Parameters.AddWithValue("@comment", newFollowUpMaintenanceForTechnician.textBoxFollowUpMaintenanceComment.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Follow Up Inserted");
            }
            comboBoxFilter.SelectedIndex = 0;
            updateViewFollowUpMaintenanceForTechnician(0, formMachineId, formTechnicianId);
            newFollowUpMaintenanceForTechnician.Hide();
        }
    }
}
