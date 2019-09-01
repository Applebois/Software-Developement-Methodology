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
    public partial class NewAppointmentFormForFrontCounter : UserControl
    {
        public int selectedDoctorId = 0;
        public int selectedPatientId = 0;
        public int selectedMachineId = 0;
        public NewAppointmentFormForFrontCounter()
        {
            InitializeComponent();
            comboBoxAppointmentType.SelectedIndex = 0;
            searchDoctorForm.Hide();
            searchPatientForm.Hide();
            searchMachineForm.Hide();
            searchPatientForm.listViewListPatient.MouseDown += new MouseEventHandler(listViewListPatient_MouseDown);
            searchDoctorForm.listViewListDoctor.MouseDown += new MouseEventHandler(listViewListDoctor_MouseDown);
            searchMachineForm.listViewListMachine.MouseDown += new MouseEventHandler(listViewListMachine_MouseDown);
        }

        public void resetNewAppointmentForm()
        {
            comboBoxAppointmentType.SelectedIndex = 0;
            textBoxDoctor.Text = string.Empty;
            textBoxPatient.Text = string.Empty;
            textBoxMachineId.Text = string.Empty;
            textBoxComment.Text = string.Empty;
            textBoxAppointmentDuration.Text = string.Empty;
            selectedDoctorId = 0;
            selectedPatientId = 0;
            selectedMachineId = 0;
        }

        private void textBoxAppointmentDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonSearchPatient_Click(object sender, EventArgs e)
        {
            searchDoctorForm.Hide();
            searchMachineForm.Hide();
            searchPatientForm.Show();
        }

        private void buttonSearchDoctor_Click(object sender, EventArgs e)
        {
            searchPatientForm.Hide();
            searchMachineForm.Hide();
            searchDoctorForm.Show();
        }

        private void buttonSearchMachine_Click(object sender, EventArgs e)
        {
            searchPatientForm.Hide();
            searchDoctorForm.Hide();
            searchMachineForm.Show();
        }

        private void listViewListPatient_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                selectedPatientId = Convert.ToInt32(info.Item.SubItems[0].Text);
                textBoxPatient.Text = info.Item.SubItems[2].Text;
            }
            else
            {
                selectedPatientId = 0;
                textBoxPatient.Text = string.Empty;
            }
            searchDoctorForm.Hide();
            searchPatientForm.Hide();
            searchMachineForm.Hide();
        }

        private void listViewListDoctor_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                selectedDoctorId = Convert.ToInt32(info.Item.SubItems[0].Text);
                textBoxDoctor.Text = info.Item.SubItems[2].Text;
            }
            else
            {
                selectedDoctorId = 0;
                textBoxDoctor.Text = string.Empty;
            }
            searchDoctorForm.Hide();
            searchPatientForm.Hide();
            searchMachineForm.Hide();
        }

        private void listViewListMachine_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null && info.Item.SubItems[3].Text.Equals("True"))
            {
                selectedMachineId = Convert.ToInt32(info.Item.SubItems[0].Text);
                textBoxMachineId.Text = info.Item.SubItems[0].Text + " " + info.Item.SubItems[1].Text + " " + info.Item.SubItems[2].Text;
            }
            else
            {
                if (info.Item.SubItems[3].Text.Equals("False"))
                {
                    MessageBox.Show("Machine unavailable, please choose other machine");
                }
                selectedMachineId = 0;
                textBoxMachineId.Text = string.Empty;
            }
            searchDoctorForm.Hide();
            searchPatientForm.Hide();
            searchMachineForm.Hide();
        }

        private void comboBoxAppointmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    materialLabel6.Hide();
                    textBoxMachineId.Hide();
                    buttonSearchMachine.Hide();
                    break;
                case 1:
                    materialLabel6.Show();
                    textBoxMachineId.Show();
                    buttonSearchMachine.Show();
                    break;
            }
        }
    }
}
