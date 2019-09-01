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
using System.Globalization;
using MaterialSkin.Controls;

namespace SDM_Assignment
{
    public partial class FrontCounterMainMenu : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public FrontCounterMainMenu()
        {
            InitializeComponent();
            newAppointmentForm.Hide();
            viewPatientRecordByPatient.Hide();
            logPatientForm.listViewListPatient.MouseDown += new MouseEventHandler(listViewListPatientRecord_MouseDown);
            viewAppointmentByTimeForFrontCounter.buttonNewAppointment.Click += new EventHandler(appointmentFormButtonNewAppointment_Click);
            newAppointmentForm.buttonNewAppointment.Click += new EventHandler(newAppointmentFormButtonNewAppointment_Click);
            viewPatientRecordByPatient.buttonBack.Click += new EventHandler(viewPatientRecordByPatientButtonBack_Click);
        }

        private void appointmentFormButtonNewAppointment_Click(object sender, EventArgs e)
        {
            viewAppointmentByTimeForFrontCounter.Hide();
            newAppointmentForm.Show();
        }

        private void newAppointmentFormButtonNewAppointment_Click(object sender, EventArgs e)
        {
            List<string> formValidationMessages = new List<string>();
            if (newAppointmentForm.comboBoxAppointmentType.SelectedIndex == 1 && newAppointmentForm.selectedMachineId == 0)
            {
                formValidationMessages.Add("Please select machine");
            }
            if (newAppointmentForm.selectedDoctorId == 0)
            {
                formValidationMessages.Add("Please select doctor");
            }
            if (newAppointmentForm.selectedPatientId == 0)
            {
                formValidationMessages.Add("Please select patient");
            }
            if (string.IsNullOrEmpty(newAppointmentForm.textBoxAppointmentDuration.Text))
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

            if (newAppointmentForm.comboBoxAppointmentType.SelectedIndex == 1)
            {
                //string machineBlockDialog = isMachineBlock();
                //if (!string.IsNullOrEmpty(machineBlockDialog))
                //{
                //    MessageBox.Show(machineBlockDialog, "Machine blocked");
                //    return;
                //}
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
                    "VALUES (@patientId, @doctorId, 0, 1, @startDate, @endDate, @comment, @type); SELECT LAST_INSERT_ID();", con);
                cmd.Parameters.AddWithValue("@patientId", newAppointmentForm.selectedPatientId);
                cmd.Parameters.AddWithValue("@doctorId", newAppointmentForm.selectedDoctorId);
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentForm.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@comment", newAppointmentForm.textBoxComment.Text);
                cmd.Parameters.AddWithValue("@type", newAppointmentForm.comboBoxAppointmentType.SelectedIndex);
                con.Open();
                lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            
            if (newAppointmentForm.comboBoxAppointmentType.SelectedIndex == 1)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO DigitalImagingAppointment (AppointmentId, MachineId) VALUES (@appointmentId, @machineId);", con);
                    cmd.Parameters.AddWithValue("@appointmentId", lastInsertedId);
                    cmd.Parameters.AddWithValue("@machineId", newAppointmentForm.selectedMachineId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            newAppointmentForm.resetNewAppointmentForm();
            
            newAppointmentForm.Hide();
            viewAppointmentByTimeForFrontCounter.Show();
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
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentForm.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@machineId", newAppointmentForm.selectedMachineId);
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
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentForm.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@doctorId", newAppointmentForm.selectedDoctorId);
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
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentForm.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@patientId", newAppointmentForm.selectedPatientId);
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

        private string isMachineBlock()
        {
            List<string> conflictedMessages = new List<string>();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineScheduleBlockStartDate, MachineScheduleBlockEndDate, MachineScheduleBlockComment,  " +
                    "FROM MachineScheduleBlock WHERE ((@startDate BETWEEN MachineScheduleBlockStartDate AND MachineScheduleBlockEndDate) OR (@endDate BETWEEN MachineScheduleBlockStartDate " +
                    "AND MachineScheduleBlockEndDate) OR (MachineScheduleBlockStartDate BETWEEN @startDate AND @endDate) OR (MachineScheduleBlockEndDate BETWEEN @startDate AND @endDate)) " +
                    "AND MachineId = @machineId;", con);
                cmd.Parameters.AddWithValue("@startDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@endDate", DateTime.ParseExact(newAppointmentForm.dateTimePickerAppointmentDate.Text, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture).AddMinutes(Convert.ToInt32(newAppointmentForm.textBoxAppointmentDuration.Text)));
                cmd.Parameters.AddWithValue("@machineId", newAppointmentForm.selectedMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        conflictedMessages.Add("Start: " + Convert.ToDateTime(dataReader["AppointmentStartDateTime"]).ToString("dd-MM-yyyy") + " End: " + Convert.ToDateTime(dataReader["AppointmentEndDateTime"]).ToString("dd-MM-yyyy") + " Comment: " + dataReader["MachineScheduleBlockComment"].ToString());
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

        private void listViewListPatientRecord_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewPatientRecordByPatient.updateListViewListPatientRecord(Convert.ToInt32(info.Item.SubItems[0].Text));
                viewPatientRecordByPatient.Show();
            }
        }

        private void viewPatientRecordByPatientButtonBack_Click(object sender, EventArgs e)
        {
            viewPatientRecordByPatient.Hide();
        }
    }
}
