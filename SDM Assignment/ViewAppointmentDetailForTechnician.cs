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
    public partial class ViewAppointmentDetailForTechnician : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formAppointmentId = 0;
        private int formTechnicianId = 0;
        public ViewAppointmentDetailForTechnician()
        {
            InitializeComponent();
        }

        public void updateViewAppointmentDetailForTechnicianForm(int appointmentId, int technicianId)
        {
            formAppointmentId = appointmentId;
            formTechnicianId = technicianId;
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
                        if (Convert.ToInt32(dataReader["AppointmentPartyRequested"]) == 0)
                        {
                            textBoxPartyRequested.Text = "Patient";
                        }
                        else
                        {
                            textBoxPartyRequested.Text = "Doctor";
                        }

                        switch (Convert.ToInt32(dataReader["AppointmentStatus"]))
                        {
                            case 1:
                                textBoxAppointmentStatus.Text = "Pending";
                                break;
                            case 2:
                                textBoxAppointmentStatus.Text = "Accepted";
                                break;
                            case 3:
                                textBoxAppointmentStatus.Text = "Present";
                                break;
                            case 4:
                                textBoxAppointmentStatus.Text = "Absent";
                                break;
                            case 5:
                                textBoxAppointmentStatus.Text = "Postpone";
                                break;
                            case 6:
                                textBoxAppointmentStatus.Text = "Rejected";
                                break;
                        }

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
    }
}
