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
    public partial class ViewMachineTechnicianListForAdministrator : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formMachineId = 0;
        public ViewMachineTechnicianListForAdministrator()
        {
            InitializeComponent();
            machineAssignTechnicianForAdministrator.Hide();
            machineUnassignTechnicianForAdministrator.Hide();
            machineAssignTechnicianForAdministrator.listViewTechnician.MouseDown += new MouseEventHandler(machineAssignTechnicianForAdministratorListViewTechnician_MouseDown);
            machineAssignTechnicianForAdministrator.buttonBack.Click += new EventHandler(machineAssignTechnicianForAdministratorButtonBack_Click);
            machineUnassignTechnicianForAdministrator.listViewTechnician.MouseDown += new MouseEventHandler(machineUnassignTechnicianForAdministratorListViewTechnician_MouseDown);
            machineUnassignTechnicianForAdministrator.buttonBack.Click += new EventHandler(machineUnassignTechnicianForAdministratorButtonBack_Click);
        }

        public void updateViewMachineTechnicianListForAdministratorForm(int machineId)
        {
            formMachineId = machineId;
            listViewMachineTechnician.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineTechnician.MachineTechnicianId, MachineTechnician.TechnicianId, " +
                    "Account.AccountDisplayName FROM MachineTechnician JOIN Account ON MachineTechnician.TechnicianId = Account.AccountId WHERE MachineId = @machineId", con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["MachineTechnicianId"].ToString());
                        item.SubItems.Add(dataReader["TechnicianId"].ToString());
                        item.SubItems.Add(dataReader["AccountDisplayName"].ToString());
                        listViewMachineTechnician.Items.Add(item);
                    }
                }
            }
        }

        private void buttonNewTechnician_Click(object sender, EventArgs e)
        {
            machineAssignTechnicianForAdministrator.updateListViewListTechnician(0, formMachineId);
            machineAssignTechnicianForAdministrator.Show();
        }

        private void buttonRemoveTechnician_Click(object sender, EventArgs e)
        {
            machineUnassignTechnicianForAdministrator.updateListViewListTechnician(0, formMachineId);
            machineUnassignTechnicianForAdministrator.Show();
        }

        private void machineAssignTechnicianForAdministratorListViewTechnician_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            int technicianId = 0;
            if (info.Item != null)
            {
                technicianId = Convert.ToInt32(info.Item.SubItems[0].Text);
            }

            if (technicianId != 0)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO MachineTechnician (TechnicianId, MachineId) VALUES (@technicianId, @machineId);", con);
                    cmd.Parameters.AddWithValue("@technicianId", technicianId);
                    cmd.Parameters.AddWithValue("@machineId", formMachineId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Technician Assigned");
                }
            }
            updateViewMachineTechnicianListForAdministratorForm(formMachineId);
            machineAssignTechnicianForAdministrator.Hide();
        }

        private void machineAssignTechnicianForAdministratorButtonBack_Click(object sender, EventArgs e)
        {
            machineAssignTechnicianForAdministrator.Hide();
        }

        private void machineUnassignTechnicianForAdministratorListViewTechnician_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            int technicianId = 0;
            if (info.Item != null)
            {
                technicianId = Convert.ToInt32(info.Item.SubItems[0].Text);
            }

            if (technicianId != 0)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM MachineTechnician WHERE TechnicianId = @technicianId AND MachineId = @machineId;", con);
                    cmd.Parameters.AddWithValue("@technicianId", technicianId);
                    cmd.Parameters.AddWithValue("@machineId", formMachineId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Technician Unassigned");
                }
            }
            updateViewMachineTechnicianListForAdministratorForm(formMachineId);
            machineUnassignTechnicianForAdministrator.Hide();
            
        }
        private void machineUnassignTechnicianForAdministratorButtonBack_Click(object sender, EventArgs e)
        {
            machineUnassignTechnicianForAdministrator.Hide();
        }
    }
}
