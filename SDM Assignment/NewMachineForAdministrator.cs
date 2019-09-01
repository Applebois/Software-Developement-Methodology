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
    public partial class NewMachineForAdministrator : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public NewMachineForAdministrator()
        {
            InitializeComponent();
            comboBoxMachineStatus.SelectedIndex = 0;
        }

        public void resetNewMachineForAdministratorForm()
        {
            textBoxMachineBrand.Text = string.Empty;
            textBoxMachineModel.Text = string.Empty;
            textBoxMachineCooldownMin.Text = string.Empty;
            textBoxMachineSupplier.Text = string.Empty;
            textBoxMachineSupplierContact.Text = string.Empty;
            textBoxMachineNote.Text = string.Empty;
            comboBoxMachineStatus.SelectedIndex = 0;
        }

        private void buttonNewMachine_Click(object sender, EventArgs e)
        {
            List<string> errorMessages = new List<string>();
            if (string.IsNullOrEmpty(textBoxMachineBrand.Text))
            {
                errorMessages.Add("Machine brand cannot be empty");
            }
            if (string.IsNullOrEmpty(textBoxMachineModel.Text))
            {
                errorMessages.Add("Machine model cannot be empty");
            }
            if (string.IsNullOrEmpty(textBoxMachineCooldownMin.Text))
            {
                errorMessages.Add("Machine cooldown minute cannot be empty");
            }
            if (string.IsNullOrEmpty(textBoxMachineSupplier.Text))
            {
                errorMessages.Add("Machine supplier cannot be empty");
            }
            if (string.IsNullOrEmpty(textBoxMachineSupplierContact.Text))
            {
                errorMessages.Add("Machine supplier contact cannot be empty");
            }
            if (errorMessages.Count == 0)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Machine (MachineBrand, MachineModel, MachineCooldownMin, MachineSupplier, " +
                        "MachineSupplierContact, MachineManufactureDate, MachineNote, MachineStatus) VALUES (@brand, @model, @cooldownMin, @supplier, " +
                        "@supplierContact, @manufactureDate, @note, @status);", con);
                    cmd.Parameters.AddWithValue("@brand", textBoxMachineBrand.Text);
                    cmd.Parameters.AddWithValue("@model", textBoxMachineModel.Text);
                    cmd.Parameters.AddWithValue("@cooldownMin", textBoxMachineCooldownMin.Text);
                    cmd.Parameters.AddWithValue("@supplier", textBoxMachineSupplier.Text);
                    cmd.Parameters.AddWithValue("@supplierContact", textBoxMachineSupplierContact.Text);
                    cmd.Parameters.AddWithValue("@manufactureDate", dateTimePickerMachineManufactureDate.Value);
                    cmd.Parameters.AddWithValue("@note", textBoxMachineNote.Text);
                    cmd.Parameters.AddWithValue("@status", comboBoxMachineStatus.SelectedIndex);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New machine created");
                    resetNewMachineForAdministratorForm();
                }
            }
            else
            {
                string message = "";
                foreach (var errorMessage in errorMessages)
                {
                    message += errorMessage + Environment.NewLine;
                }
                MessageBox.Show(message);
            }
        }

        private void textBoxMachineCooldownMin_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
