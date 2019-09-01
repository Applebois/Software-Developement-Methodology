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
    public partial class ViewPatientRecordDetailForDoctor : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formPatientRecordId = 0;
        private int formDoctorId = 0;
        public ViewPatientRecordDetailForDoctor()
        {
            InitializeComponent();
            viewPatientRecordDigitalImageForDoctor.Hide();
            viewPatientRecordDigitalImageForDoctor.buttonBack.Click += new EventHandler(viewPatientRecordDigitalImageForDoctorButtonBack_Click);
        }

        public void updateViewPatientRecordDetailForDoctor(int patientRecordId, int doctorId)
        {
            formPatientRecordId = patientRecordId;
            formDoctorId = doctorId;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PatientRecord.PatientRecordId, Patient.PatientName, PatientRecord.DoctorId, Account.AccountDisplayName, " +
                    "PatientRecord.PatientRecordStartDateTime, PatientRecord.PatientRecordEndDateTime, PatientRecord.PatientRecordComment " +
                    "FROM PatientRecord JOIN Patient ON PatientRecord.PatientId = Patient.PatientId JOIN Account ON PatientRecord.DoctorId = " +
                    "Account.AccountId WHERE PatientRecord.PatientRecordId = @patientRecordId", con);
                cmd.Parameters.AddWithValue("@patientRecordId", formPatientRecordId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        textBoxPatientRecordId.Text = dataReader["PatientRecordId"].ToString();
                        textBoxPatientName.Text = dataReader["PatientName"].ToString();
                        if (Convert.ToInt32(dataReader["DoctorId"]) == formDoctorId)
                        {
                            buttonUpdateComment.Show();
                        }
                        else
                        {
                            buttonUpdateComment.Hide();
                        }
                        textBoxDoctorName.Text = dataReader["AccountDisplayName"].ToString();
                        textBoxStartDateTime.Text = Convert.ToDateTime(dataReader["PatientRecordStartDateTime"]).ToString("dd-MM-yyyy HH:mm");
                        if (dataReader["PatientRecordEndDateTime"] != DBNull.Value)
                        {
                            textBoxEndDateTime.Text = Convert.ToDateTime(dataReader["PatientRecordEndDateTime"]).ToString("dd-MM-yyyy HH:mm");
                        }
                        else
                        {
                            textBoxEndDateTime.Text = string.Empty;
                        }
                        if (dataReader["PatientRecordComment"] != DBNull.Value)
                        {
                            textBoxComment.Text = dataReader["PatientRecordComment"].ToString();
                        }
                        else
                        {
                            textBoxComment.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void buttonUpdateComment_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE PatientRecord SET PatientRecordComment = @recordComment WHERE PatientRecordId = @recordId AND DoctorId = @doctorId", con);
                cmd.Parameters.AddWithValue("@recordComment", textBoxComment.Text);
                cmd.Parameters.AddWithValue("@recordId", formPatientRecordId);
                cmd.Parameters.AddWithValue("@doctorId", formDoctorId);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comment updated");
            }
        }

        private void buttonViewDigitalImages_Click(object sender, EventArgs e)
        {
            viewPatientRecordDigitalImageForDoctor.updateViewPatientRecordDigitalImageForDoctorForm(formPatientRecordId, formDoctorId);
            viewPatientRecordDigitalImageForDoctor.Show();
        }

        private void viewPatientRecordDigitalImageForDoctorButtonBack_Click(object sender, EventArgs e)
        {
            updateViewPatientRecordDetailForDoctor(formPatientRecordId, formDoctorId);
            viewPatientRecordDigitalImageForDoctor.Hide();
        }
    }
}
