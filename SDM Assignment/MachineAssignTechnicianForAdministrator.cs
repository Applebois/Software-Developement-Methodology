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
    public partial class MachineAssignTechnicianForAdministrator : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formMachineId = 0;
        public MachineAssignTechnicianForAdministrator()
        {
            InitializeComponent();
            comboBoxSearchBy.SelectedIndex = 0;
            updateListViewListTechnician(0, formMachineId);
        }

        public void updateListViewListTechnician(int queryCondition, int machineId)
        {
            formMachineId = machineId;
            listViewTechnician.Items.Clear();
            string[] sql =
            {
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3 AND AccountId NOT IN (SELECT TechnicianId FROM MachineTechnician WHERE MachineId = @machineId)",
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3 AND AccountId LIKE @filter AND AccountId NOT IN (SELECT TechnicianId FROM MachineTechnician WHERE MachineId = @machineId)",
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3 AND AccountUsername LIKE @filter AND AccountId NOT IN (SELECT TechnicianId FROM MachineTechnician WHERE MachineId = @machineId)",
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3 AND AccountDisplayName LIKE @filter AND AccountId NOT IN (SELECT TechnicianId FROM MachineTechnician WHERE MachineId = @machineId)"
            };
            listViewTechnician.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand(sql[queryCondition], con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                if (queryCondition != 0)
                {
                    cmd.Parameters.AddWithValue("@filter", "%" + textBoxSearch.Text + "%");
                }
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["AccountId"].ToString());
                        item.SubItems.Add(dataReader["AccountUsername"].ToString());
                        item.SubItems.Add(dataReader["AccountDisplayName"].ToString());
                        listViewTechnician.Items.Add(item);
                    }

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || string.IsNullOrEmpty(textBoxSearch.Text))
            {
                updateListViewListTechnician(0, formMachineId);
            }
            else
            {
                updateListViewListTechnician(comboBoxSearchBy.SelectedIndex + 1, formMachineId);
            }
        }
    }
}
