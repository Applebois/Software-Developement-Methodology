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
    public partial class ViewMaintenanceListForTechnician : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formMachineId = 0;
        private int formTechnicianId = 0;
        public ViewMaintenanceListForTechnician()
        {
            InitializeComponent();
            newMaintenanceForTechnician.Hide();
            newMaintenanceForTechnician.buttonBack.Click += new EventHandler(newMaintenanceForTechnicianButtonBack_Click);
            newMaintenanceForTechnician.buttonNewMaintenance.Click += new EventHandler(newMaintenanceForTechnicianButtonNewMaintenance_Click);
        }

        public void updateViewMaintenanceListForTechnicianForm(int machineId, int technicianId)
        {
            formMachineId = machineId;
            formTechnicianId = technicianId;
            listViewMachineMaintenance.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineMaintenanceHistoryId, MachineMaintenanceHistoryDateTime, " +
                    "MachineMaintenanceHistoryComment FROM MachineMaintenanceHistory WHERE MachineId = @machineId", con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["MachineMaintenanceHistoryId"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(dataReader["MachineMaintenanceHistoryDateTime"]).ToString("dd-MM-yyyy"));
                        item.SubItems.Add(dataReader["MachineMaintenanceHistoryComment"].ToString());
                        listViewMachineMaintenance.Items.Add(item);
                    }
                }
                cmd.CommandText = "SELECT COUNT(TechnicianId) FROM MachineTechnician WHERE MachineId = @machineId AND TechnicianId = @technicianId;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                cmd.Parameters.AddWithValue("@technicianId", formTechnicianId);
                if (Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    buttonNewMaintenance.Show();
                }
                else
                {
                    buttonNewMaintenance.Hide();
                }
            }
        }

        private void buttonNewMaintenance_Click(object sender, EventArgs e)
        {
            newMaintenanceForTechnician.updateNewMaintenanceForTechnicianForm(formMachineId, formTechnicianId);
            newMaintenanceForTechnician.Show();
        }

        private void newMaintenanceForTechnicianButtonBack_Click(object sender, EventArgs e)
        {
            newMaintenanceForTechnician.Hide();
        }

        private void newMaintenanceForTechnicianButtonNewMaintenance_Click(object sender, EventArgs e)
        {
            if (newMaintenanceForTechnician.followUpId == 0 && newMaintenanceForTechnician.checkBoxIsFollowUp.Checked)
            {
                MessageBox.Show("Please select a follow up maintenance");
            }
            string[] sql =
            {
                "INSERT INTO MachineMaintenanceHistory (MachineId, TechnicianId, MachineMaintenanceHistoryDateTime, " +
                    "MachineMaintenanceHistoryComment) VALUES (@machineId, @technicianId, @date, @comment);",
                "INSERT INTO MachineMaintenanceHistory (MachineId, TechnicianId, MachineMaintenanceHistoryDateTime, " +
                    "MachineMaintenanceHistoryComment, MachineFollowUpMaintenanceId) VALUES (@machineId, @technicianId, @date, @comment, @followUpId);"
            };
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand(sql[Convert.ToInt32(newMaintenanceForTechnician.checkBoxIsFollowUp.Checked)], con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                cmd.Parameters.AddWithValue("@technicianId", formTechnicianId);
                cmd.Parameters.AddWithValue("@date", newMaintenanceForTechnician.dateTimePickerMaintenanceDate.Value);
                cmd.Parameters.AddWithValue("@comment", newMaintenanceForTechnician.textBoxMaintenanceComment.Text);
                if (newMaintenanceForTechnician.checkBoxIsFollowUp.Checked)
                {
                    cmd.Parameters.AddWithValue("@followUpId", newMaintenanceForTechnician.followUpId);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("New maintenance record added");
            }
            updateViewMaintenanceListForTechnicianForm(formMachineId, formTechnicianId);
            newMaintenanceForTechnician.Hide();
        }
    }
}
