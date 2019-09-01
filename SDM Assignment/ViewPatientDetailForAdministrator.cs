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
    public partial class ViewPatientDetailForAdministrator : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        int formPatientId = 0;
        public ViewPatientDetailForAdministrator()
        {
            InitializeComponent();
            viewPatientRecordForAdministrator.Hide();
            viewPatientRecordForAdministrator.buttonBack.Click += new EventHandler(viewPatientRecordForAdministratorButtonBack_Click);
        }

        public void updatePatientDetailForAdministrator(int patientId)
        {
            formPatientId = patientId;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Patient.PatientIsReferral, Patient.PatientName, " +
                    "Patient.PatientIdentity, Patient.PatientAge, Patient.PatientDOB, Patient.PatientMaritalStatus, " +
                    "Patient.PatientGender, Patient.PatientAddress, Patient.PatientPhoneNumber, PatientReferral.PatientReferralHospital, " +
                    "PatientReferral.PatientReferralDoctor, PatientReferral.PatientReferralDate, PatientEmploymentTrans.PatientEmploymentTrans, PatientEmployment.PatientEmployer, " +
                    "PatientEmployment.PatientOccupation, PatientEmployment.PatientEmployerAddress, PatientEmployment.PatientEmployerPhoneNumber, " +
                    "PatientEmployment.PatientEmployerEmail FROM Patient LEFT JOIN PatientReferral ON Patient.PatientId = PatientReferral.PatientId " +
                    "LEFT JOIN PatientEmployment ON Patient.PatientId = PatientEmployment.PatientId JOIN PatientEmploymentTrans ON " +
                    "PatientEmployment.PatientEmploymentId = PatientEmploymentTrans.PatientEmploymentId WHERE Patient.PatientId = @patientId", con);

                cmd.Parameters.AddWithValue("@patientId", formPatientId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        textBoxType.Text = Convert.ToBoolean(dataReader["PatientIsReferral"]) ? "Referral Patient" : "Patient";
                        textBoxName.Text = dataReader["PatientName"].ToString();
                        textBoxIdentity.Text = dataReader["PatientIdentity"].ToString();
                        textBoxAge.Text = dataReader["PatientAge"].ToString();
                        textBoxDOB.Text = Convert.ToDateTime(dataReader["PatientDOB"]).ToString("dd-MM-yyyy");
                        textBoxMaritalStatus.Text = dataReader["PatientMaritalStatus"].ToString();
                        textBoxGender.Text = dataReader["PatientGender"].ToString();
                        textBoxAddress.Text = dataReader["PatientAddress"].ToString();
                        textBoxPhoneNumber.Text = dataReader["PatientPhoneNumber"].ToString();
                        if (Convert.ToBoolean(dataReader["PatientIsReferral"]))
                        {
                            labelRefHospital.Show();
                            labelRefDoctor.Show();
                            labelRefDate.Show();
                            textBoxRefHospital.Text = dataReader["PatientReferralHospital"].ToString();
                            textBoxRefDoctor.Text = dataReader["PatientReferralDoctor"].ToString();
                            textBoxRefDate.Text = Convert.ToDateTime(dataReader["PatientReferralDate"]).ToString("dd-MM-yyyy");
                            textBoxRefHospital.Show();
                            textBoxRefDoctor.Show();
                            textBoxRefDate.Show();
                        }
                        else
                        {
                            labelRefHospital.Hide();
                            labelRefDoctor.Hide();
                            labelRefDate.Hide();
                            textBoxRefHospital.Text = string.Empty;
                            textBoxRefDoctor.Text = string.Empty;
                            textBoxRefDate.Text = string.Empty;
                            textBoxRefHospital.Hide();
                            textBoxRefDoctor.Hide();
                            textBoxRefDate.Hide();
                        }
                        textBoxEmployment.Text = dataReader["PatientEmploymentTrans"].ToString();
                        switch (dataReader["PatientEmploymentTrans"].ToString())
                        {
                            case "Unemployed":
                            case "School/College":
                            case "Retired":
                                labelEmployer.Hide();
                                labelOccupation.Hide();
                                labelEmployerAddress.Hide();
                                labelEmployerPhoneNumber.Hide();
                                labelEmail.Hide();
                                textBoxEmployer.Hide();
                                textBoxOccupation.Hide();
                                textBoxEmployerAddress.Hide();
                                textBoxEmployerPhoneNumber.Hide();
                                textBoxEmail.Hide();
                                textBoxEmployer.Text = string.Empty;
                                textBoxOccupation.Text = string.Empty;
                                textBoxEmployerAddress.Text = string.Empty;
                                textBoxEmployerPhoneNumber.Text = string.Empty;
                                textBoxEmail.Text = string.Empty;
                                break;
                            default:
                                labelEmployer.Show();
                                labelOccupation.Show();
                                labelEmployerAddress.Show();
                                labelEmployerPhoneNumber.Show();
                                labelEmail.Show();
                                textBoxEmployer.Show();
                                textBoxOccupation.Show();
                                textBoxEmployerAddress.Show();
                                textBoxEmployerPhoneNumber.Show();
                                textBoxEmail.Show();
                                textBoxEmployer.Text = dataReader["PatientEmployer"].ToString();
                                textBoxOccupation.Text = dataReader["PatientOccupation"].ToString();
                                textBoxEmployerAddress.Text = dataReader["PatientEmployerAddress"].ToString();
                                textBoxEmployerPhoneNumber.Text = dataReader["PatientEmployerPhoneNumber"].ToString();
                                textBoxEmail.Text = dataReader["PatientEmployerEmail"].ToString();
                                break;
                        }
                    }
                }
            }
        }

        private void buttonViewRecords_Click(object sender, EventArgs e)
        {
            viewPatientRecordForAdministrator.updateListViewListPatientRecord(formPatientId);
            viewPatientRecordForAdministrator.Show();
        }

        private void viewPatientRecordForAdministratorButtonBack_Click(object sender, EventArgs e)
        {
            updatePatientDetailForAdministrator(formPatientId);
            viewPatientRecordForAdministrator.Hide();
        }
    }
}
