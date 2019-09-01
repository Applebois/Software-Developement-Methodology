using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SDM_Assignment
{
    public partial class TechnicianMainMenu : UserControl
    {
        private int formTechnicianId = 0;
        public TechnicianMainMenu()
        {
            InitializeComponent();
            viewMachineDetailForTechnician.Hide();
            viewMachineDetailForTechnician.buttonBack.Click += new EventHandler(viewMachineDetailForTechnicianButtonBack_Click);
            viewMachineListForTechnician.listViewListMachine.MouseDown += new MouseEventHandler(viewMachineListForTechnicianListViewListMachine_MouseDown);
            viewMachineScheduleBlock.listViewListMachine.MouseDown += new MouseEventHandler(viewMachineScheduleBlockListViewListMachine_MouseDown);
            viewMachineScheduleBlockForTechnician.Hide();
            viewMachineScheduleBlockForTechnician.buttonBack.Click += new EventHandler(viewMachineScheduleBlockForTechnicianButtonBack_Click);
        }

        public void updateTechnicianMainMenu(int technicianId)
        {
            formTechnicianId = technicianId;
        }

        private void viewMachineListForTechnicianListViewListMachine_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewMachineDetailForTechnician.updateViewMachineDetailForTechnicianForm(Convert.ToInt32(info.Item.SubItems[0].Text), formTechnicianId);
                viewMachineDetailForTechnician.Show();
            }
        }

        private void viewMachineDetailForTechnicianButtonBack_Click(object sender, EventArgs e)
        {
            viewMachineListForTechnician.updateListViewListMachine(0);
            viewMachineDetailForTechnician.Hide();
        }

        private void viewMachineScheduleBlockListViewListMachine_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewMachineScheduleBlockForTechnician.updateViewMachineScheduleBlockForTechnician(Convert.ToInt32(info.Item.SubItems[0].Text), formTechnicianId);
                viewMachineScheduleBlockForTechnician.Show();
            }
        }

        private void viewMachineScheduleBlockForTechnicianButtonBack_Click(object sender, EventArgs e)
        {
            viewMachineScheduleBlockForTechnician.Hide();
        }
    }
}
