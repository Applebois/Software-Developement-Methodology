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
    public partial class ViewMachineScheduleBlockForTechnician : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formTechnicianId = 0;
        private int formMachineId = 0;
        public ViewMachineScheduleBlockForTechnician()
        {
            InitializeComponent();
            newMachineScheduleBlockForTechnician.Hide();
            newMachineScheduleBlockForTechnician.buttonBack.Click += new EventHandler(newMachineScheduleBlockForTechnicianButtonBack_Click);
            newMachineScheduleBlockForTechnician.buttonNewScheduleBlock.Click += new EventHandler(newMachineScheduleBlockForTechnicianButtonNewScheduleBlock_Click);
        }

        public void updateViewMachineScheduleBlockForTechnician(int machineId, int technicianId)
        {
            formMachineId = machineId;
            formTechnicianId = technicianId;
            listViewMachineScheduleBlock.Items.Clear();
           
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineScheduleBlockId, MachineScheduleBlockStartDate, MachineScheduleBlockEndDate, " +
                    "MachineScheduleBlockComment FROM MachineScheduleBlock WHERE MachineId = @machineId;", con);
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["MachineScheduleBlockId"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(dataReader["MachineScheduleBlockStartDate"]).ToString("dd-MM-yyyy"));
                        item.SubItems.Add(Convert.ToDateTime(dataReader["MachineScheduleBlockEndDate"]).ToString("dd-MM-yyyy"));
                        item.SubItems.Add(dataReader["MachineScheduleBlockComment"].ToString());
                        listViewMachineScheduleBlock.Items.Add(item);
                    }

                }

                cmd.CommandText = "SELECT COUNT(TechnicianId) FROM MachineTechnician WHERE MachineId = @machineId AND TechnicianId = @technicianId;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@machineId", formMachineId);
                cmd.Parameters.AddWithValue("@technicianId", formTechnicianId);
                if (Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    buttonNewScheduleBlock.Show();
                }
                else
                {
                    buttonNewScheduleBlock.Hide();
                }
            }
        }

        private void newMachineScheduleBlockForTechnicianButtonBack_Click(object sender, EventArgs e)
        {
            updateViewMachineScheduleBlockForTechnician(formMachineId, formTechnicianId);
            newMachineScheduleBlockForTechnician.Hide();
        }

        private void newMachineScheduleBlockForTechnicianButtonNewScheduleBlock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO MachineScheduleBlock (MachineId, MachineScheduleBlockStartDate, " +
                    "MachineScheduleBlockEndDate, MachineScheduleBlockComment) VALUES(@machineId, @startDate, @endDate, @comment);", con);
                cmd.Parameters.AddWithValue("@machineId", newMachineScheduleBlockForTechnician.formMachineId);
                cmd.Parameters.AddWithValue("@startDate", newMachineScheduleBlockForTechnician.dateTimePickerMachineScheduleBlockStartDate.Value);
                cmd.Parameters.AddWithValue("@endDate", newMachineScheduleBlockForTechnician.dateTimePickerMachineScheduleBlockEndDate.Value);
                cmd.Parameters.AddWithValue("@comment", newMachineScheduleBlockForTechnician.textBoxMachineScheduleBlockComment.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "UPDATE Appointment JOIN DigitalImagingAppointment ON Appointment.AppointmentId = DigitalImagingAppointment.AppointmentId " +
                    "SET AppointmentStatus = 5 WHERE DigitalImagingAppointment.MachineId = @machineId AND ((@startDate BETWEEN Appointment.AppointmentStartDateTime " +
                    "AND Appointment.AppointmentEndDateTime) OR (@endDate BETWEEN Appointment.AppointmentStartDateTime AND Appointment.AppointmentEndDateTime) OR " +
                    "(Appointment.AppointmentStartDateTime BETWEEN @startDate AND @endDate) OR (Appointment.AppointmentEndDateTime BETWEEN @startDate AND @endDate)) AND (Appointment.AppointmentStatus BETWEEN 1 AND 2)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@machineId", newMachineScheduleBlockForTechnician.formMachineId);
                cmd.Parameters.AddWithValue("@startDate", newMachineScheduleBlockForTechnician.dateTimePickerMachineScheduleBlockStartDate.Value);
                cmd.Parameters.AddWithValue("@endDate", newMachineScheduleBlockForTechnician.dateTimePickerMachineScheduleBlockEndDate.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New machine schedule block created");
            }
            updateViewMachineScheduleBlockForTechnician(formMachineId, formTechnicianId);
            newMachineScheduleBlockForTechnician.Hide();
        }

        private void buttonNewScheduleBlock_Click(object sender, EventArgs e)
        {
            newMachineScheduleBlockForTechnician.Show();
            newMachineScheduleBlockForTechnician.updateNewMachineScheduleBlockForTechnician(formMachineId);
        }
    }
}
