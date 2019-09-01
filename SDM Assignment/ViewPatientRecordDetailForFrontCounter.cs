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
    public partial class ViewPatientRecordDetailForFrontCounter : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formPatientRecordId = 0;
        public ViewPatientRecordDetailForFrontCounter()
        {
            InitializeComponent();
        }

        public void updateViewPatientRecordDetail(int patientRecordId)
        {
            formPatientRecordId = patientRecordId;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PatientRecord.PatientRecordId, Patient.PatientName, Account.AccountDisplayName, " +
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
                        textBoxDoctorName.Text = dataReader["AccountDisplayName"].ToString();
                        textBoxStartDateTime.Text = Convert.ToDateTime(dataReader["PatientRecordStartDateTime"]).ToString("dd-MM-yyyy HH:mm");
                        if (dataReader["PatientRecordEndDateTime"] != DBNull.Value)
                        {
                            textBoxEndDateTime.Text = Convert.ToDateTime(dataReader["PatientRecordEndDateTime"]).ToString("dd-MM-yyyy HH:mm");
                            buttonMarkTime.Hide();
                        }
                        else
                        {
                            textBoxEndDateTime.Text = string.Empty;
                            buttonMarkTime.Show();
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

        private void buttonMarkTime_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE PatientRecord SET PatientRecordEndDateTime = @endDateTime WHERE PatientRecordId = @patientRecordId;", con);
                cmd.Parameters.AddWithValue("@patientRecordId", formPatientRecordId);
                cmd.Parameters.AddWithValue("@endDateTime", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            updateViewPatientRecordDetail(formPatientRecordId);
        }
    }
}
