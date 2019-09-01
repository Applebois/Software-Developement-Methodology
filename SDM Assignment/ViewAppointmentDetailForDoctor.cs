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
    public partial class ViewAppointmentDetailForDoctor : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formAppointmentId = 0;
        private int formDoctorId = 0;
        public ViewAppointmentDetailForDoctor()
        {
            InitializeComponent();
        }

        private class AppoinmentStatusCode
        {
            public string Status;
            public int Code;

            public override string ToString()
            {
                return Status;
            }
        }

        public void updateViewAppointmentDetailForm(int appointmentId, int doctorId)
        {
            formAppointmentId = appointmentId;
            formDoctorId = doctorId;
            comboBoxAppointmentStatus.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Appointment.AppointmentId, Patient.PatientName, Account.AccountDisplayName, Appointment.AppointmentPartyRequested, " +
                    "Appointment.AppointmentStatus, Appointment.AppointmentStartDateTime, Appointment.AppointmentEndDateTime, Appointment.AppointmentComment, " +
                    "Appointment.AppointmentType, DigitalImagingAppointment.MachineId FROM Appointment LEFT JOIN DigitalImagingAppointment ON Appointment.AppointmentId = " +
                    "DigitalImagingAppointment.AppointmentId JOIN Patient ON Appointment.AppointmentPatientId = Patient.PatientId JOIN Account ON Appointment.AppointmentDoctorId = " +
                    "Account.AccountId JOIN AppointmentStatusTrans ON Appointment.AppointmentStatus = AppointmentStatusTrans.AppointmentStatusTransId WHERE Appointment.AppointmentId = @appointmentId", con);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        textBoxAppointmentId.Text = dataReader["AppointmentId"].ToString();
                        textBoxPatientName.Text = dataReader["PatientName"].ToString();
                        textBoxDoctorName.Text = dataReader["AccountDisplayName"].ToString();
                        textBoxPartyRequested.Text = Convert.ToInt32(dataReader["AppointmentPartyRequested"]) == 0 ? "Patient" : "Doctor";

                        switch (Convert.ToInt32(dataReader["AppointmentStatus"]))
                        {
                            case 1:
                                if (Convert.ToInt32(dataReader["AppointmentPartyRequested"]) == 1)
                                {
                                    comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Pending", Code = 1 });
                                    comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Postpone", Code = 5 });
                                }
                                else
                                {
                                    comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Pending", Code = 1 });
                                    comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Accept", Code = 2 });
                                    comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Reject", Code = 6 });
                                }
                                buttonUpdate.Show();
                                break;
                            case 2:
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Accept", Code = 2 });
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Present", Code = 3 });
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Absent", Code = 4 });
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Postpone", Code = 5 });
                                buttonUpdate.Show();
                                break;
                            case 3:
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Present", Code = 3 });
                                buttonUpdate.Hide();
                                break;
                            case 4:
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Absent", Code = 4 });
                                buttonUpdate.Hide();
                                break;
                            case 5:
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Postponed", Code = 5 });
                                buttonUpdate.Hide();
                                break;
                            case 6:
                                comboBoxAppointmentStatus.Items.Add(new AppoinmentStatusCode { Status = "Rejected", Code = 6 });
                                buttonUpdate.Hide();
                                break;
                        }
                        comboBoxAppointmentStatus.SelectedIndex = 0;

                        textBoxStartTime.Text = Convert.ToDateTime(dataReader["AppointmentStartDateTime"]).ToString("dd-MM-yyyy HH:mm");
                        textBoxEndDateTime.Text = Convert.ToDateTime(dataReader["AppointmentEndDateTime"]).ToString("dd-MM-yyyy HH:mm");
                        textBoxComment.Text = dataReader["AppointmentComment"].ToString();
                        if (Convert.ToInt32(dataReader["AppointmentType"]) == 0)
                        {
                            textBoxType.Text = "Doctor Consultation";
                            labelMachineId.Hide();
                            textBoxMachineId.Hide();
                        }
                        else
                        {
                            textBoxType.Text = "Digital Imaging Service";
                            labelMachineId.Show();
                            textBoxMachineId.Show();
                        }
                        if (dataReader["MachineId"] != DBNull.Value)
                        {
                            textBoxMachineId.Text = dataReader["MachineId"].ToString();
                        }
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (formAppointmentId != 0)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Appointment SET AppointmentStatus = @appointmentStatus WHERE AppointmentId = @appointmentId AND AppointmentDoctorID = @doctorId", con);
                    cmd.Parameters.AddWithValue("@appointmentId", formAppointmentId);
                    cmd.Parameters.AddWithValue("@doctorId", formDoctorId);
                    cmd.Parameters.AddWithValue("@appointmentStatus", ((AppoinmentStatusCode)comboBoxAppointmentStatus.SelectedItem).Code);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    updateViewAppointmentDetailForm(formAppointmentId, formDoctorId);
                }
            }
        }
    }
}
