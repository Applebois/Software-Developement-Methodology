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
    public partial class ViewFollowUpMaintenanceForAdministrator : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formFollowUpId = 0;
        public ViewFollowUpMaintenanceForAdministrator()
        {
            InitializeComponent();
        }

        public void updateViewFollowUpMaintenanceForAdministrator(int followUpId)
        {
            formFollowUpId = followUpId;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MachineId, MachineFollowUpMaintenanceDate, MachineFollowUpMaintenanceComment " +
                    "FROM MachineFollowUpMaintenance WHERE MachineFollowUpMaintenanceId = @followUpId", con);
                cmd.Parameters.AddWithValue("@followUpId", formFollowUpId);
                con.Open();
                using(MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        textBoxMachineId.Text = dataReader["MachineId"].ToString();
                        textBoxFollowUpDate.Text = Convert.ToDateTime(dataReader["MachineFollowUpMaintenanceDate"]).ToString("dd-MM-yyyy");
                        textBoxComment.Text = dataReader["MachineFollowUpMaintenanceComment"].ToString();
                    }
                }
            }
        }
    }
}
