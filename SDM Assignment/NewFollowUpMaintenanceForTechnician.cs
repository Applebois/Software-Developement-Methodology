using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Assignment
{
    public partial class NewFollowUpMaintenanceForTechnician : UserControl
    {
        private int formMachineId = 0;
        public NewFollowUpMaintenanceForTechnician()
        {
            InitializeComponent();
        }

        public void updateNewFollowUpMaintenanceForTechnician(int machineId)
        {
            formMachineId = machineId;
            textBoxMachineId.Text = formMachineId.ToString();
            textBoxFollowUpMaintenanceComment.Text = string.Empty;
        }
    }
}
