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
    public partial class ViewAppointmentByTimeForTechnician : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formTechnicianId = 0;
        public ViewAppointmentByTimeForTechnician()
        {
            InitializeComponent();
            updateListViewAppointment(0);
            viewAppointmentDetailForTechnician.Hide();
            viewAppointmentDetailForTechnician.buttonBack.Click += new EventHandler(viewAppointmentDetailForTechnicianButtonBack_Click);
        }

        public void resetViewAppointmentFormForTechnician(int technicianId)
        {
            formTechnicianId = technicianId;
            comboBoxSearchBy.SelectedIndex = 0;
            dateTimePickerFromDate.Value = DateTime.Today;
            dateTimePickerToDate.Value = DateTime.Today;
        }

        private void updateListViewAppointment(int queryCondition)
        {
            listViewListAppointment.Items.Clear();
            string[] sql =
            {
                "SELECT Appointment.AppointmentId, Patient.PatientName, Account.AccountDisplayName, Appointment.AppointmentStartDateTime, " +
                    "Appointment.AppointmentEndDateTime, AppointmentStatusTrans.AppointmentStatusTrans, DigitalImagingAppointment.MachineId FROM Appointment " +
                    "JOIN DigitalImagingAppointment ON Appointment.AppointmentId = DigitalImagingAppointment.AppointmentId JOIN AppointmentStatusTrans " +
                    "ON Appointment.AppointmentStatus = AppointmentStatusTrans.AppointmentStatusTransId JOIN Patient ON Appointment.AppointmentPatientId = " +
                    "Patient.PatientId JOIN Account ON Appointment.AppointmentDoctorId = Account.AccountId WHERE Appointment.AppointmentStartDateTime BETWEEN " +
                    "@fromDate AND @toDate;",
                "SELECT Appointment.AppointmentId, Patient.PatientName, Account.AccountDisplayName, Appointment.AppointmentStartDateTime, " +
                    "Appointment.AppointmentEndDateTime, AppointmentStatusTrans.AppointmentStatusTrans, DigitalImagingAppointment.MachineId FROM Appointment " +
                    "JOIN DigitalImagingAppointment ON Appointment.AppointmentId = DigitalImagingAppointment.AppointmentId JOIN AppointmentStatusTrans " +
                    "ON Appointment.AppointmentStatus = AppointmentStatusTrans.AppointmentStatusTransId JOIN Patient ON Appointment.AppointmentPatientId = " +
                    "Patient.PatientId JOIN Account ON Appointment.AppointmentDoctorId = Account.AccountId WHERE Appointment.AppointmentStartDateTime BETWEEN " +
                    "@fromDate AND @toDate AND Patient.PatientName LIKE @filter",
                "SELECT Appointment.AppointmentId, Patient.PatientName, Account.AccountDisplayName, Appointment.AppointmentStartDateTime, " +
                    "Appointment.AppointmentEndDateTime, AppointmentStatusTrans.AppointmentStatusTrans, DigitalImagingAppointment.MachineId FROM Appointment " +
                    "JOIN DigitalImagingAppointment ON Appointment.AppointmentId = DigitalImagingAppointment.AppointmentId JOIN AppointmentStatusTrans " +
                    "ON Appointment.AppointmentStatus = AppointmentStatusTrans.AppointmentStatusTransId JOIN Patient ON Appointment.AppointmentPatientId = " +
                    "Patient.PatientId JOIN Account ON Appointment.AppointmentDoctorId = Account.AccountId WHERE Appointment.AppointmentStartDateTime BETWEEN " +
                    "@fromDate AND @toDate AND Patient.PatientIdentity LIKE @filter",
                "SELECT Appointment.AppointmentId, Patient.PatientName, Account.AccountDisplayName, Appointment.AppointmentStartDateTime, " +
                    "Appointment.AppointmentEndDateTime, AppointmentStatusTrans.AppointmentStatusTrans, DigitalImagingAppointment.MachineId FROM Appointment " +
                    "JOIN DigitalImagingAppointment ON Appointment.AppointmentId = DigitalImagingAppointment.AppointmentId JOIN AppointmentStatusTrans " +
                    "ON Appointment.AppointmentStatus = AppointmentStatusTrans.AppointmentStatusTransId JOIN Patient ON Appointment.AppointmentPatientId = " +
                    "Patient.PatientId JOIN Account ON Appointment.AppointmentDoctorId = Account.AccountId WHERE Appointment.AppointmentStartDateTime BETWEEN " +
                    "@fromDate AND @toDate AND Account.AccountDisplayName LIKE @filter",
                "SELECT Appointment.AppointmentId, Patient.PatientName, Account.AccountDisplayName, Appointment.AppointmentStartDateTime, " +
                    "Appointment.AppointmentEndDateTime, AppointmentStatusTrans.AppointmentStatusTrans, DigitalImagingAppointment.MachineId FROM Appointment " +
                    "JOIN DigitalImagingAppointment ON Appointment.AppointmentId = DigitalImagingAppointment.AppointmentId JOIN AppointmentStatusTrans " +
                    "ON Appointment.AppointmentStatus = AppointmentStatusTrans.AppointmentStatusTransId JOIN Patient ON Appointment.AppointmentPatientId = " +
                    "Patient.PatientId JOIN Account ON Appointment.AppointmentDoctorId = Account.AccountId WHERE Appointment.AppointmentStartDateTime BETWEEN " +
                    "@fromDate AND @toDate AND Account.AccountUsername LIKE @filter",
            };

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand(sql[queryCondition], con);
                if (queryCondition != 0)
                {
                    cmd.Parameters.AddWithValue("@filter", "%" + textBoxSearch.Text + "%");
                }
                cmd.Parameters.AddWithValue("@fromDate", Convert.ToDateTime(dateTimePickerFromDate.Value));
                cmd.Parameters.AddWithValue("@toDate", Convert.ToDateTime(dateTimePickerToDate.Value).AddDays(1));
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["AppointmentId"].ToString());
                        item.SubItems.Add(dataReader["PatientName"].ToString());
                        item.SubItems.Add(dataReader["AccountDisplayName"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(dataReader["AppointmentStartDateTime"]).ToString("dd-MM-yyyy HH:mm"));
                        item.SubItems.Add(Convert.ToDateTime(dataReader["AppointmentEndDateTime"]).ToString("dd-MM-yyyy HH:mm"));
                        item.SubItems.Add(dataReader["AppointmentStatusTrans"].ToString());
                        item.SubItems.Add(dataReader["MachineId"].ToString());
                        listViewListAppointment.Items.Add(item);
                    }

                }
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                updateListViewAppointment(0);
            }
            else
            {
                updateListViewAppointment(comboBoxSearchBy.SelectedIndex + 1);
            }
        }

        private void viewAppointmentDetailForTechnicianButtonBack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                updateListViewAppointment(0);
            }
            else
            {
                updateListViewAppointment(comboBoxSearchBy.SelectedIndex + 1);
            }
            viewAppointmentDetailForTechnician.Hide();
        }
        private void listViewListMachine_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewAppointmentDetailForTechnician.updateViewAppointmentDetailForTechnicianForm(Convert.ToInt32(info.Item.SubItems[0].Text), formTechnicianId);
                viewAppointmentDetailForTechnician.Show();
            }
        }
    }
}
