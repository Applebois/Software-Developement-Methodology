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
    public partial class ViewPatientRecordForFrontCounter : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int formPatientId = 0;
        public ViewPatientRecordForFrontCounter()
        {
            InitializeComponent();
            viewPatientRecordDetail.Hide();
            newPatientRecord.Hide();
            listViewListPatientRecord.MouseDown += new MouseEventHandler(listViewListPatientRecord_MouseDown);
            viewPatientRecordDetail.buttonBack.Click += new EventHandler(viewPatientRecordDetailButtonBack_Click);
            newPatientRecord.buttonBack.Click += new EventHandler(newPatientRecordButtonBack_Click);
            newPatientRecord.buttonNewPatientRecord.Click += new EventHandler(newPatientRecordButtonNewPatientRecord_Click);
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
                viewPatientRecordDetail.updateViewPatientRecordDetail(Convert.ToInt32(info.Item.SubItems[0].Text));
                newPatientRecord.Hide();
                viewPatientRecordDetail.Show();
            }
        }

        private void viewPatientRecordDetailButtonBack_Click(object sender, EventArgs e)
        {
            viewPatientRecordDetail.Hide();
            newPatientRecord.Hide();
        }

        private void newPatientRecordButtonBack_Click(object sender, EventArgs e)
        {
            viewPatientRecordDetail.Hide();
            newPatientRecord.Hide();
        }

        private void buttonNewPatientRecord_Click(object sender, EventArgs e)
        {
            viewPatientRecordDetail.Hide();
            newPatientRecord.updateNewPatientRecord(formPatientId);
            newPatientRecord.Show();
        }


        private void newPatientRecordButtonNewPatientRecord_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO PatientRecord (PatientId, DoctorId, PatientRecordStartDateTime) " +
                    "VALUE (@patientId, @doctorId, @startDate);", con);
                cmd.Parameters.AddWithValue("@patientId", newPatientRecord.formPatientId);
                cmd.Parameters.AddWithValue("@doctorId", newPatientRecord.formDoctorId);
                cmd.Parameters.AddWithValue("@startDate", newPatientRecord.startDateTime);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("New patient record created");
            }
            newPatientRecord.Hide();
            updateListViewListPatientRecord(formPatientId);
        }
    }
}
