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
    public partial class PaymentForFrontCounter : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int selectedPatientId = 0;
        class Item
        {
            public string Name;
            public int Price;
            public override string ToString()
            {
                return Name;
            }
        }
        public PaymentForFrontCounter()
        {
            InitializeComponent();
            searchPatientForm.Hide();
            resetPaymentForFrontCounter();
            searchPatientForm.listViewListPatient.MouseDown += new MouseEventHandler(searchPatientFormListViewListPatient_MouseDown);
        }

        private void resetPaymentForFrontCounter()
        {
            comboBoxItem.Items.Clear();
            comboBoxItem.Items.Add(new Item { Name = "General consultation and appointment", Price = 100 });
            comboBoxItem.Items.Add(new Item { Name = "Special consultation and appointment", Price = 500 });
            comboBoxItem.Items.Add(new Item { Name = "Digital File", Price = 400 });
            comboBoxItem.Items.Add(new Item { Name = "Digital DVD Imaging 2D", Price = 800 });
            comboBoxItem.Items.Add(new Item { Name = "Digital DVD Imaging 3D/4D", Price = 1250 });
            comboBoxItem.Items.Add(new Item { Name = "MRI Imaging File", Price = 1400 });
            comboBoxItem.Items.Add(new Item { Name = "MRI Imaging DVD", Price = 2500 });
            comboBoxItem.Items.Add(new Item { Name = "Miscellaneous item", Price = 0 });
            comboBoxItem.SelectedIndex = 0;
            textBoxAmount.Text = 0.ToString();
            numericUpDownItemAmount.Value = 1;
            textBoxMiscItemName.Text = string.Empty;
            numericUpDownMiscItemPrice.Value = 0;
            richTextBoxPaymentNote.Text = string.Empty;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedIndex == 7)
            {
                richTextBoxPaymentNote.Text += textBoxMiscItemName.Text + " x " + numericUpDownItemAmount.Value + " = RM " + (numericUpDownItemAmount.Value * numericUpDownMiscItemPrice.Value) + Environment.NewLine;
                textBoxAmount.Text = (Convert.ToDecimal(textBoxAmount.Text) + (numericUpDownItemAmount.Value * numericUpDownMiscItemPrice.Value)).ToString();
            }
            else
            {
                richTextBoxPaymentNote.Text += ((Item)comboBoxItem.SelectedItem).Name + " x " + numericUpDownItemAmount.Value + " = RM " + (numericUpDownItemAmount.Value * ((Item)comboBoxItem.SelectedItem).Price) + Environment.NewLine;
                textBoxAmount.Text = (Convert.ToDecimal(textBoxAmount.Text) + (numericUpDownItemAmount.Value * ((Item)comboBoxItem.SelectedItem).Price)).ToString();
            }
            comboBoxItem.SelectedIndex = 0;
            numericUpDownItemAmount.Value = 1;
            textBoxMiscItemName.Text = string.Empty;
            numericUpDownMiscItemPrice.Value = 0;
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 7)
            {
                labelItemName.Show();
                labelRM.Show();
                textBoxMiscItemName.Show();
                numericUpDownMiscItemPrice.Show();
            }
            else
            {
                labelItemName.Hide();
                labelRM.Hide();
                textBoxMiscItemName.Hide();
                numericUpDownMiscItemPrice.Hide();
            }
        }

        private void buttonSearchPatient_Click(object sender, EventArgs e)
        {
            searchPatientForm.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetPaymentForFrontCounter();
        }

        private void buttonMakePayment_Click(object sender, EventArgs e)
        {
            List<string> errorMessages = new List<string>();
            if (selectedPatientId == 0)
            {
                errorMessages.Add("Please select patient");
            }
            if (string.IsNullOrEmpty(richTextBoxPaymentNote.Text))
            {
                errorMessages.Add("Cannot make payment without item");
            }
            if (errorMessages.Count == 0)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Payment (PatientId, PaymentDate, PaymentNote, PaymentAmount) VALUES (@patientId, @date, @note, @amount)", con);
                    cmd.Parameters.AddWithValue("@patientId", selectedPatientId);
                    cmd.Parameters.AddWithValue("@date", dateTimePickerPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@note", richTextBoxPaymentNote.Text);
                    cmd.Parameters.AddWithValue("@amount", textBoxAmount.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New payment record added");
                    resetPaymentForFrontCounter();
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

        private void searchPatientFormListViewListPatient_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                selectedPatientId = Convert.ToInt32(info.Item.SubItems[0].Text);
                textBoxPatientName.Text = info.Item.SubItems[2].Text;
                searchPatientForm.Hide();
            }
        }
    }
}
