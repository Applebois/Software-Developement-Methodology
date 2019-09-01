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
    public partial class SearchFollowUpByMachineId : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formMachineId = 0;
        public SearchFollowUpByMachineId()
        {
            InitializeComponent();
        }

        public void updateSearchFollowUpByMachineIdForm(int machineId)
        {
            formMachineId = machineId;
            listViewFollowUp.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineFollowUpMaintenanceId, MachineFollowUpMaintenanceDate, " +
                    "MachineFollowUpMaintenanceComment FROM MachineFollowUpMaintenance WHERE MachineFollowUpMaintenanceId " +
                    "NOT IN (SELECT MachineFollowUpMaintenanceId FROM MachineMaintenanceHistory WHERE MachineFollowUpMaintenanceId IS NOT NULL AND MachineId = @machineId) AND MachineId = @machineId", con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["MachineFollowUpMaintenanceId"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(dataReader["MachineFollowUpMaintenanceDate"]).ToString("dd-MM-yyyy"));
                        item.SubItems.Add(dataReader["MachineFollowUpMaintenanceComment"].ToString());
                        listViewFollowUp.Items.Add(item);
                    }
                }
            }
        }
    }
}
