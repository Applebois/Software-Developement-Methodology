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
using MySql.Data.MySqlClient;
using System.Globalization;

namespace SDM_Assignment
{
    public partial class DoctorMainMenu : UserControl
    {
        int formDoctorId = 0;
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public DoctorMainMenu()
        {
            InitializeComponent();
            patientDetail.Hide();
            newAppointmentFormForDoctor.Hide();
            
            viewPatientListForm.listViewListPatient.MouseDown += new MouseEventHandler(viewPatientListFormListViewListPatient_MouseDown);
            viewAppointmentByTimeForDoctor.buttonNewAppointment.Click += new EventHandler(viewAppointmentByTimeForDoctorButtonNewAppointment_Click);
            patientDetail.buttonBack.Click += new EventHandler(patientDetailButtonBack_Click);
            newAppointmentFormForDoctor.buttonNewAppointment.Click += new EventHandler(newAppointmentFormButtonNewAppointment_Click);
        }

        public void updateDoctorMainMenu(int doctorId)
        {
            formDoctorId = doctorId;
            viewAppointmentByTimeForDoctor.resetViewAppointmentFormForDoctor(formDoctorId);
        }

        private void viewPatientListFormListViewListPatient_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                patientDetail.updatePatientDetailForDoctor(Convert.ToInt32(info.Item.SubItems[0].Text), formDoctorId);
                patientDetail.Show();
            }
        }

        private void patientDetailButtonBack_Click(object sender, EventArgs e)
        {
            patientDetail.Hide();
        }

        private void newAppointmentFormButtonNewAppointment_Click(object sender, EventArgs e)
        {
            List<string> formValidationMessages = new List<string>();
            if (newAppointmentFormForDoctor.comboBoxAppointmentType.SelectedIndex == 1 && newAppointmentFormForDoctor.selectedMachineId == 0)
            {
                formValidationMessages.Add("Please select machine");
            }
            if (newAppointmentFormForDoctor.selectedPatientId == 0)
            {
                formValidationMessages.Add("Please select patient");
            }
            if (string.IsNullOrEmpty(newAppointmentFormForDoctor.textBoxAppointmentDuration.Text))
            {
                formValidationMessages.Add("Please specify estimated duration for the appointment");
            }

            if (formValidationMessages.Count > 0)
            {
                string formValidationDialog = "";
                foreach (var formValidationMessage in formValidationMessages)
                {
                    formValidationDialog += formValidationMessage + Environment.NewLine;
                }

                MessageBox.Show(formValidationDialog);
                return;
            }

            int lastInsertedId = 0;

            if (newAppointmentFormForDoctor.comboBoxAppointmentType.SelectedIndex == 1)
            {
                string machineBusyDialog = isMachineBusy();
                DialogResult ignoreMachine;
                if (!string.IsNullOrEmpty(machineBusyDialog))
                {
                    ignoreMachine = MessageBox.Show(machineBusyDialog, "Machine appointment conflicted", MessageBoxButtons.YesNo);
                    if (ignoreMachine == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string doctorBusyDialog = isDoctorBusy();
            DialogResult ignoreDoctor;
            if (!string.IsNullOrEmpty(doctorBusyDialog))
            {
                ignoreDoctor = MessageBox.Show(doctorBusyDialog, "Doctor appointment conflicted", MessageBoxButtons.YesNo);
                if (ignoreDoctor == DialogResult.No)
                {
                    return;
                }
            }

            string patientBusyDialog = isPatientBusy();
            DialogResult ignorePatient;
            if (!string.IsNullOrEmpty(patientBusyDialog))
            {
                ignorePatient = MessageBox.Show(patientBusyDialog, "Patient appointment conflicted", MessageBoxButtons.YesNo);
                if (ignorePatient == DialogResult.No)
                {
                    return;
                }
            }

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Appointment (AppointmentPatientId, AppointmentDoctorId, AppointmentPartyRequested, " +
                    "AppointmentStatus, AppointmentStartDateTime, AppointmentEndDateTime, AppointmentComment, AppointmentType) " +
                    "VALUES (@patientId, @doctorId, 1, 1, @startDate, @endDate, @comment, @type); SELECT LAST_INSERT_ID();", con);
                cmd.Parameters.AddWithValue("@patientId", newAppointmentFormForDoctor.selectedPatientId);
                cmd.Parameters.AddWithValue("@doctorId", formDoctorId);
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentFormForDoctor.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@comment", newAppointmentFormForDoctor.textBoxComment.Text);
                cmd.Parameters.AddWithValue("@type", newAppointmentFormForDoctor.comboBoxAppointmentType.SelectedIndex);
                con.Open();
                lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            if (newAppointmentFormForDoctor.comboBoxAppointmentType.SelectedIndex == 1)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO DigitalImagingAppointment (AppointmentId, MachineId) VALUES (@appointmentId, @machineId);", con);
                    cmd.Parameters.AddWithValue("@appointmentId", lastInsertedId);
                    cmd.Parameters.AddWithValue("@machineId", newAppointmentFormForDoctor.selectedMachineId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            newAppointmentFormForDoctor.resetNewAppointmentForm();

            newAppointmentFormForDoctor.Hide();
            viewAppointmentByTimeForDoctor.Show();
        }

        private string isMachineBusy()
        {
            List<string> conflictedMessages = new List<string>();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Appointment.AppointmentStartDateTime, Appointment.AppointmentEndDateTime, " +
                    "DigitalImagingAppointment.MachineId, Machine.MachineCooldownMin, Appointment.AppointmentDoctorId, Appointment.AppointmentPatientId " +
                    "FROM Appointment JOIN DigitalImagingAppointment ON Appointment.AppointmentId = DigitalImagingAppointment.AppointmentId JOIN " +
                    "Machine ON DigitalImagingAppointment.MachineId = Machine.MachineId WHERE ((DATE_ADD(@startDate, INTERVAL - Machine.MachineCooldownMin MINUTE) " +
                    "BETWEEN Appointment.AppointmentStartDateTime AND Appointment.AppointmentEndDateTime) OR (DATE_ADD(@endDate, INTERVAL + Machine.MachineCooldownMin MINUTE) " +
                    "BETWEEN Appointment.AppointmentStartDateTime AND Appointment.AppointmentEndDateTime) OR (Appointment.AppointmentStartDateTime BETWEEN DATE_ADD(@startDate, INTERVAL - " +
                    "Machine.MachineCooldownMin MINUTE) AND DATE_ADD(@endDate, INTERVAL + Machine.MachineCooldownMin MINUTE)) OR (Appointment.AppointmentEndDateTime BETWEEN " +
                    "DATE_ADD(@startDate, INTERVAL - Machine.MachineCooldownMin MINUTE) AND DATE_ADD(@endDate, INTERVAL + Machine.MachineCooldownMin MINUTE))) AND Machine.MachineId = " +
                    "@machineId AND (AppointmentStatus BETWEEN 1 AND 3);", con);
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentFormForDoctor.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@machineId", newAppointmentFormForDoctor.selectedMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        conflictedMessages.Add("Machine ID: " + dataReader["MachineId"].ToString() + " Doctor ID: " + dataReader["AppointmentDoctorId"].ToString() + " Patient ID: " + dataReader["AppointmentPatientId"].ToString() + " Start: " + dataReader["AppointmentStartDateTime"].ToString() + " End: " + dataReader["AppointmentEndDateTime"].ToString());
                    }
                }
            }
            string dialogMessage = null;
            if (conflictedMessages.Count > 0)
            {
                dialogMessage = "";
                foreach (var conflictedMessage in conflictedMessages)
                {
                    dialogMessage += conflictedMessage + Environment.NewLine;
                }
            }
            return dialogMessage;
        }

        private string isDoctorBusy()
        {
            List<string> conflictedMessages = new List<string>();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT AppointmentStartDateTime, AppointmentEndDateTime, AppointmentDoctorId, AppointmentPatientId " +
                    "FROM Appointment WHERE ((@startDate BETWEEN AppointmentStartDateTime AND AppointmentEndDateTime) OR (@endDate BETWEEN AppointmentStartDateTime " +
                    "AND AppointmentEndDateTime) OR (AppointmentStartDateTime BETWEEN @startDate AND @endDate) OR (AppointmentEndDateTime BETWEEN @startDate AND @endDate)) " +
                    "AND AppointmentDoctorId = @doctorId AND (AppointmentStatus BETWEEN 1 AND 3);", con);
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentFormForDoctor.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@doctorId", formDoctorId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        conflictedMessages.Add("Doctor ID: " + dataReader["AppointmentDoctorId"].ToString() + " Patient ID: " + dataReader["AppointmentPatientId"].ToString() + " Start: " + dataReader["AppointmentStartDateTime"].ToString() + " End: " + dataReader["AppointmentEndDateTime"].ToString());
                    }
                }
            }
            string dialogMessage = null;
            if (conflictedMessages.Count > 0)
            {
                dialogMessage = "";
                foreach (var conflictedMessage in conflictedMessages)
                {
                    dialogMessage += conflictedMessage + Environment.NewLine;
                }
            }
            return dialogMessage;
        }
        private string isPatientBusy()
        {
            List<string> conflictedMessages = new List<string>();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT AppointmentStartDateTime, AppointmentEndDateTime, AppointmentDoctorId, AppointmentPatientId " +
                    "FROM Appointment WHERE ((@startDate BETWEEN AppointmentStartDateTime AND AppointmentEndDateTime) OR (@endDate BETWEEN AppointmentStartDateTime " +
                    "AND AppointmentEndDateTime) OR (AppointmentStartDateTime BETWEEN @startDate AND @endDate) OR (AppointmentEndDateTime BETWEEN @startDate AND @endDate)) " +
                    "AND AppointmentPatientId = @patientId AND (AppointmentStatus BETWEEN 1 AND 3);", con);
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentFormForDoctor.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentFormForDoctor.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@patientId", newAppointmentFormForDoctor.selectedPatientId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        conflictedMessages.Add("Doctor ID: " + dataReader["AppointmentDoctorId"].ToString() + " Patient ID: " + dataReader["AppointmentPatientId"].ToString() + " Start: " + dataReader["AppointmentStartDateTime"].ToString() + " End: " + dataReader["AppointmentEndDateTime"].ToString());
                    }
                }
            }
            string dialogMessage = null;
            if (conflictedMessages.Count > 0)
            {
                dialogMessage = "";
                foreach (var conflictedMessage in conflictedMessages)
                {
                    dialogMessage += conflictedMessage + Environment.NewLine;
                }
            }
            return dialogMessage;
        }
        
        private void viewAppointmentByTimeForDoctorButtonNewAppointment_Click(object sender, EventArgs e)
        {
            newAppointmentFormForDoctor.Show();
        }
    }
}
