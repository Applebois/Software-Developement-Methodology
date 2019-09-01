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
    public partial class NewMachineScheduleBlockForTechnician : UserControl
    {
        public int formMachineId = 0;
        public NewMachineScheduleBlockForTechnician()
        {
            InitializeComponent();
        }

        public void updateNewMachineScheduleBlockForTechnician(int machineId)
        {
            formMachineId = machineId;
            textBoxMachineId.Text = formMachineId.ToString();
            textBoxMachineScheduleBlockComment.Text = string.Empty;
        }
    }
}
