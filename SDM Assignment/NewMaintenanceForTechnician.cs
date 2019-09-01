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
    public partial class NewMaintenanceForTechnician : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formMachineId = 0;
        private int formTechnicianId = 0;
        public int followUpId = 0;
        public NewMaintenanceForTechnician()
        {
            InitializeComponent();
            
            searchFollowUpByMachineId.Hide();
            searchFollowUpByMachineId.buttonBack.Click += new EventHandler(searchFollowUpByMachineIdButtonBack_Click);
            searchFollowUpByMachineId.listViewFollowUp.MouseDown += new MouseEventHandler(searchFollowUpByMachineIdListViewFollowUp_MouseDown);
        }

        public void updateNewMaintenanceForTechnicianForm(int machineId, int technicianId)
        {
            formMachineId = machineId;
            formTechnicianId = technicianId;
            textBoxMachineId.Text = formMachineId.ToString();
            checkBoxIsFollowUp.Checked = false;
            buttonSearchFollowUpMaintenance.Hide();
            textBoxMaintenanceComment.Text = string.Empty;
        }
        

        private void buttonSearchFollowUpMaintenance_Click(object sender, EventArgs e)
        {
            searchFollowUpByMachineId.updateSearchFollowUpByMachineIdForm(formMachineId);
            searchFollowUpByMachineId.Show();
        }

        private void checkBoxIsFollowUp_CheckedChanged(object sender, EventArgs e)
        {
            if (((MaterialSkin.Controls.MaterialCheckBox)sender).Checked)
            {
                buttonSearchFollowUpMaintenance.Show();
            }
            else
            {
                buttonSearchFollowUpMaintenance.Hide();
            }
        }

        private void searchFollowUpByMachineIdButtonBack_Click(object sender, EventArgs e)
        {
            searchFollowUpByMachineId.Hide();
        }

        private void searchFollowUpByMachineIdListViewFollowUp_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                followUpId = Convert.ToInt32(info.Item.SubItems[0].Text);
            }
            else
            {
                followUpId = 0;
            }
            searchFollowUpByMachineId.Hide();
        }
    }
}
