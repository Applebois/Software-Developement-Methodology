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
using MaterialSkin.Controls;

namespace SDM_Assignment
{
    public partial class ViewMaintenanceListForAdministator : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formMachineId = 0;
        public ViewMaintenanceListForAdministator()
        {
            InitializeComponent();
            viewFollowUpMaintenanceForAdministrator.Hide();
            viewFollowUpMaintenanceForAdministrator.buttonBack.Click += new EventHandler(viewFollowUpMaintenanceForAdministratorButtonBack_Click);
        }

        public void updateViewMaintenanceListForAdministator(int machineId)
        {
            formMachineId = machineId;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineMaintenanceHistoryId, MachineMaintenanceHistoryDateTime, " +
                    "MachineMaintenanceHistoryComment, MachineFollowUpMaintenanceId FROM MachineMaintenanceHistory WHERE MachineId = @machineId", con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["MachineMaintenanceHistoryId"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(dataReader["MachineMaintenanceHistoryDateTime"]).ToString("dd-MM-yyyy"));
                        item.SubItems.Add(dataReader["MachineMaintenanceHistoryComment"].ToString());
                        item.SubItems.Add(dataReader["MachineFollowUpMaintenanceId"].ToString());
                        listViewMachineMaintenance.Items.Add(item);
                    }
                }
            }
        }

        private void listViewMachineMaintenance_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null && !string.IsNullOrEmpty(info.Item.SubItems[3].Text))
            {
                viewFollowUpMaintenanceForAdministrator.updateViewFollowUpMaintenanceForAdministrator(Convert.ToInt32(info.Item.SubItems[3].Text));
                viewFollowUpMaintenanceForAdministrator.Show();
            }
        }

        private void viewFollowUpMaintenanceForAdministratorButtonBack_Click(object sender, EventArgs e)
        {
            viewFollowUpMaintenanceForAdministrator.Hide();
        }
    }
}
