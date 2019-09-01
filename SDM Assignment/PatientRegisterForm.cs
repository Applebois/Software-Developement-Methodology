using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SDM_Assignment
{
    public partial class PatientRegisterForm : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public PatientRegisterForm()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            comboBoxEmployment.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
            comboBoxMaritalStatus.SelectedIndex = 0;
            comboBoxEmployment.SelectedIndex = 0;
        }
        private void clearPatientRegisterForm()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxEmployment.SelectedIndex = 0;
            textBoxName.Text = "";
            textBoxId.Text = "";
            textBoxAge.Text = "";
            comboBoxGender.SelectedIndex = 0;
            comboBoxMaritalStatus.SelectedIndex = 0;
            textBoxAddress.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxRefHospital.Text = "";
            textBoxRefDoctor.Text = "";
            comboBoxEmployment.SelectedIndex = 0;
            textBoxEmployer.Text = "";
            textBoxOccupation.Text = "";
            textBoxEmployerAddress.Text = "";
            textBoxEmployerPhoneNumber.Text = "";
            textBoxEmail.Text = "";
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    textBoxRefHospital.Hide();
                    textBoxRefDoctor.Hide();
                    dateTimePickerRefDate.Hide();
                    labelRefHospital.Hide();
                    labelRefDoctor.Hide();
                    labelRefDate.Hide();
                    break;
                case 1:
                    textBoxRefHospital.Show();
                    textBoxRefDoctor.Show();
                    dateTimePickerRefDate.Show();
                    labelRefHospital.Show();
                    labelRefDoctor.Show();
                    labelRefDate.Show();
                    break;
            }
        }

        private void comboBoxEmployment_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                case 4:
                case 5:
                    textBoxEmployer.Hide();
                    textBoxOccupation.Hide();
                    textBoxEmployerAddress.Hide();
                    textBoxEmployerPhoneNumber.Hide();
                    textBoxEmail.Hide();
                    labelEmployer.Hide();
                    labelOccupation.Hide();
                    labelEmployerAddress.Hide();
                    labelEmployerPhoneNumber.Hide();
                    labelEmail.Hide();
                    break;
                default:
                    textBoxEmployer.Show();
                    textBoxOccupation.Show();
                    textBoxEmployerAddress.Show();
                    textBoxEmployerPhoneNumber.Show();
                    textBoxEmail.Show();
                    labelEmployer.Show();
                    labelOccupation.Show();
                    labelEmployerAddress.Show();
                    labelEmployerPhoneNumber.Show();
                    labelEmail.Show();
                    break;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int lastInsertedId;
            List<string> errorMessages = new List<string>();
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                errorMessages.Add("Name cannot be empty");
            }
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                errorMessages.Add("IC/Passport cannot be empty");
            }
            if (!UnitTest.checkIC(textBoxId.Text))
            {
                errorMessages.Add("IC wrong format");
            }

            if (errorMessages.Count == 0)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Patient (PatientIdentity, PatientName, PatientAge, PatientDOB, " +
                        "PatientMaritalStatus, PatientGender, PatientAddress, PatientPhoneNumber, PatientIsReferral) " +
                        "VALUES (@patientId, @patientName, @patientAge, @patientDOB, @patientMaritalStatus, @patientGender, @patientAddress, " +
                        "@patientPhoneNumber, @patientIsReferral); SELECT LAST_INSERT_ID();", con);
                    cmd.Parameters.AddWithValue("@patientId", textBoxId.Text);
                    cmd.Parameters.AddWithValue("@patientName", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@patientAge", textBoxAge.Text);
                    cmd.Parameters.AddWithValue("@patientDOB", dateTimePickerDOB.Text);
                    cmd.Parameters.AddWithValue("@patientMaritalStatus", comboBoxMaritalStatus.Text);
                    cmd.Parameters.AddWithValue("@patientGender", comboBoxGender.Text);
                    cmd.Parameters.AddWithValue("@patientAddress", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@patientPhoneNumber", textBoxPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@patientIsReferral", comboBoxType.SelectedIndex);
                    con.Open();
                    try
                    {
                        lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    

                    if (comboBoxType.SelectedIndex == 1)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO ReferralPatient (PatientId, ReferralPatientHospital, ReferralPatientDoctor, ReferralPatientDate) " + 
                            "VALUES (@patientId, @refPatientHospital, @refPatientDoctor, @refPatientDate)";
                        cmd.Parameters.AddWithValue("@patientId", lastInsertedId);
                        cmd.Parameters.AddWithValue("@refPatientHospital", textBoxRefHospital.Text);
                        cmd.Parameters.AddWithValue("@refPatientDoctor", textBoxRefDoctor.Text);
                        cmd.Parameters.AddWithValue("@refPatientDate", (dateTimePickerRefDate.Text));
                    }

                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO PatientEmployment (PatientId, PatientEmploymentId, PatientEmployer, PatientOccupation, PatientEmployerAddress, " + 
                        "PatientEmployerPhoneNumber, PatientEmployerEmail) VALUES (@patientId, @patientEmploymentId, @patientEmployer, @patientOccupation, @patientEmployerAddress, " + 
                        "@patientEmployerPhoneNumber, @patientEmployerEmail)";
                    cmd.Parameters.AddWithValue("@patientId", lastInsertedId);
                    cmd.Parameters.AddWithValue("@patientEmploymentId", comboBoxEmployment.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@patientEmployer", textBoxEmployer.Text);
                    cmd.Parameters.AddWithValue("@patientOccupation", textBoxOccupation.Text);
                    cmd.Parameters.AddWithValue("@patientEmployerAddress", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@patientEmployerPhoneNumber", textBoxEmployerPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@patientEmployerEmail", textBoxEmail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient registered");
                }

            }
            else
            {
                string errorDialog = "";
                foreach (var errorMessage in errorMessages)
                {
                    errorDialog += errorMessage + Environment.NewLine;
                }
                MessageBox.Show(errorDialog);
            }
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
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
