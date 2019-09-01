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
    public partial class SearchMachineForm : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public SearchMachineForm()
        {
            InitializeComponent();
            comboBoxSearchBy.SelectedIndex = 0;
            updateListViewListMachine(0);
        }

        public void updateListViewListMachine(int queryCondition)
        {
            string[] sql =
            {
                "SELECT Machine.MachineId, Machine.MachineBrand, Machine.MachineModel, Machine.MachineStatus, " + 
                    "MAX(Appointment.AppointmentEndDateTime) AS MachineLastUsed, Machine.MachineCooldownMin FROM Machine LEFT JOIN DigitalImagingAppointment ON " + 
                    "Machine.MachineId = DigitalImagingAppointment.MachineId LEFT JOIN Appointment ON DigitalImagingAppointment.AppointmentId = Appointment.AppointmentId " +
                    "WHERE Appointment.AppointmentEndDateTime < CURRENT_TIMESTAMP() OR Appointment.AppointmentEndDateTime IS NULL GROUP BY Machine.MachineId",
                "SELECT Machine.MachineId, Machine.MachineBrand, Machine.MachineModel, Machine.MachineStatus, " +
                    "MAX(Appointment.AppointmentEndDateTime) AS MachineLastUsed, Machine.MachineCooldownMin FROM Machine LEFT JOIN DigitalImagingAppointment ON " +
                    "Machine.MachineId = DigitalImagingAppointment.MachineId LEFT JOIN Appointment ON DigitalImagingAppointment.AppointmentId = Appointment.AppointmentId " +
                    "WHERE Appointment.AppointmentEndDateTime < CURRENT_TIMESTAMP() OR Appointment.AppointmentEndDateTime IS NULL AND Machine.MachineId LIKE @filter GROUP BY Machine.MachineId",
                "SELECT Machine.MachineId, Machine.MachineBrand, Machine.MachineModel, Machine.MachineStatus, " +
                    "MAX(Appointment.AppointmentEndDateTime) AS MachineLastUsed, Machine.MachineCooldownMin FROM Machine LEFT JOIN DigitalImagingAppointment ON " +
                    "Machine.MachineId = DigitalImagingAppointment.MachineId LEFT JOIN Appointment ON DigitalImagingAppointment.AppointmentId = Appointment.AppointmentId " +
                    "WHERE Appointment.AppointmentEndDateTime < CURRENT_TIMESTAMP() OR Appointment.AppointmentEndDateTime IS NULL AND Machine.MachineBrand LIKE @filter GROUP BY Machine.MachineId",
                "SELECT Machine.MachineId, Machine.MachineBrand, Machine.MachineModel, Machine.MachineStatus, " +
                    "MAX(Appointment.AppointmentEndDateTime) AS MachineLastUsed, Machine.MachineCooldownMin FROM Machine LEFT JOIN DigitalImagingAppointment ON " +
                    "Machine.MachineId = DigitalImagingAppointment.MachineId LEFT JOIN Appointment ON DigitalImagingAppointment.AppointmentId = Appointment.AppointmentId " +
                    "WHERE Appointment.AppointmentEndDateTime < CURRENT_TIMESTAMP() OR Appointment.AppointmentEndDateTime IS NULL AND Machine.MachineModel LIKE @filter GROUP BY Machine.MachineId"
            };
            listViewListMachine.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand(sql[queryCondition], con);
                if (queryCondition != 0)
                {
                    cmd.Parameters.AddWithValue("@filter", "%" + textBoxSearch.Text + "%");
                }
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["MachineId"].ToString());
                        item.SubItems.Add(dataReader["MachineBrand"].ToString());
                        item.SubItems.Add(dataReader["MachineModel"].ToString());
                        item.SubItems.Add(dataReader["MachineStatus"].ToString());
                        if (dataReader["MachineLastUsed"] != DBNull.Value)
                        {
                            item.SubItems.Add(dataReader["MachineLastUsed"].ToString());
                        }
                        else
                        {
                            item.SubItems.Add("Never used");
                        }
                        item.SubItems.Add(dataReader["MachineCooldownMin"].ToString());
                        listViewListMachine.Items.Add(item);
                    }

                }
            }
        }
        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || string.IsNullOrEmpty(textBoxSearch.Text))
            {
                updateListViewListMachine(0);
            }
            else
            {
                updateListViewListMachine(comboBoxSearchBy.SelectedIndex + 1);
            }
        }
    }
}
