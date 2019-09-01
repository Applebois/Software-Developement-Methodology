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
    public partial class ViewPatientRecordForAdministrator : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formPatientId = 0;
        public ViewPatientRecordForAdministrator()
        {
            InitializeComponent();
            viewPatientRecordDetailForAdministrator.Hide();
            listViewListPatientRecord.MouseDown += new MouseEventHandler(listViewListPatientRecord_MouseDown);
            viewPatientRecordDetailForAdministrator.buttonBack.Click += new EventHandler(viewPatientRecordDetailButtonBack_Click);
        }

        public void updateListViewListPatientRecord(int patientId)
        {
            formPatientId = patientId;
            listViewListPatientRecord.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PatientRecord.PatientRecordId, Account.AccountDisplayName, " +
                    "PatientRecord.PatientRecordStartDateTime, PatientRecord.PatientRecordEndDateTime, PatientRecord.PatientRecordComment " +
                    "FROM PatientRecord JOIN Account ON PatientRecord.DoctorId = Account.AccountId WHERE PatientRecord.PatientId = @patientId " +
                    "ORDER BY PatientRecord.PatientRecordStartDateTime DESC", con);
                cmd.Parameters.AddWithValue("@patientId", formPatientId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["PatientRecordId"].ToString());
                        item.SubItems.Add(dataReader["AccountDisplayName"].ToString());
                        if (dataReader["PatientRecordStartDateTime"] != DBNull.Value)
                        {
                            item.SubItems.Add(Convert.ToDateTime(dataReader["PatientRecordStartDateTime"]).ToString("dd-MM-yyyy HH:mm"));
                        }
                        else
                        {
                            item.SubItems.Add(string.Empty);
                        }
                        if (dataReader["PatientRecordEndDateTime"] != DBNull.Value)
                        {
                            item.SubItems.Add(Convert.ToDateTime(dataReader["PatientRecordEndDateTime"]).ToString("dd-MM-yyyy HH:mm"));
                        }
                        else
                        {
                            item.SubItems.Add(string.Empty);
                        }
                        item.SubItems.Add(dataReader["PatientRecordComment"].ToString());
                        listViewListPatientRecord.Items.Add(item);
                    }
                }
            }
        }

        private void listViewListPatientRecord_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewPatientRecordDetailForAdministrator.updateViewPatientRecordDetailForAdministrator(Convert.ToInt32(info.Item.SubItems[0].Text));
                viewPatientRecordDetailForAdministrator.Show();
            }
        }

        private void viewPatientRecordDetailButtonBack_Click(object sender, EventArgs e)
        {
            viewPatientRecordDetailForAdministrator.Hide();
        }
    }
}
