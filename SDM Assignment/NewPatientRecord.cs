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

namespace SDM_Assignment
{
    public partial class NewPatientRecord : UserControl
    {
        public int formDoctorId = 0;
        public int formPatientId = 0;
        public DateTime startDateTime;
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public NewPatientRecord()
        {
            InitializeComponent();
            searchDoctorForm.Hide();
            searchDoctorForm.listViewListDoctor.MouseDown += new MouseEventHandler(listViewListDoctor_MouseDown);
        }

        public void updateNewPatientRecord(int patientId)
        {
            formPatientId = patientId;
            using (MySqlConnection con =  new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PatientName FROM Patient WHERE PatientId = @patientId", con);
                cmd.Parameters.AddWithValue("@patientId", formPatientId);
                con.Open();
                textBoxPatientName.Text = cmd.ExecuteScalar().ToString();
            }
            textBoxStartDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            startDateTime = DateTime.Now;
        }
        private void buttonSearchDoctor_Click(object sender, EventArgs e)
        {
            searchDoctorForm.Show();
        }

        private void listViewListDoctor_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                formDoctorId = Convert.ToInt32(info.Item.SubItems[0].Text);
                textBoxDoctorName.Text = info.Item.SubItems[2].Text;
            }
            searchDoctorForm.Hide();
        }
        
    }
}
