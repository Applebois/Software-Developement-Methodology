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
using System.IO;
using System.Diagnostics;

namespace SDM_Assignment
{
    public partial class ViewDigitalImageDetailForDoctor : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public int formPatientDigitalImageId = 0;
        private int formDoctorId = 0;
        private string formDigitalImageExt = null;
        public ViewDigitalImageDetailForDoctor()
        {
            InitializeComponent();
            saveFileDigitalImageDialog.Title = "Save Digital Image File";
        }

        public void updateViewDigitalImageDetailForDoctor(int patientDigitalImageId, int doctorId)
        {
            formPatientDigitalImageId = patientDigitalImageId;
            formDoctorId = doctorId;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PatientRecord.DoctorId, PatientDigitalImage.PatientDigitalImageId, PatientDigitalImage.PatientRecordId, " +
                    "PatientDigitalImage.PatientDigitalImageExt, PatientDigitalImage.PatientDigitalImageDate, PatientDigitalImage.PatientDigitalImageComment FROM " +
                    "PatientDigitalImage JOIN PatientRecord ON PatientDigitalImage.PatientRecordId = PatientRecord.PatientRecordId WHERE " +
                    "PatientDigitalImage.PatientDigitalImageId = @patientDigitalImageId", con);
                cmd.Parameters.AddWithValue("@patientDigitalImageId", formPatientDigitalImageId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        textBoxPatientDigitalImageId.Text = dataReader["PatientDigitalImageId"].ToString();
                        textBoxPatientRecordId.Text = dataReader["PatientRecordId"].ToString();
                        formDigitalImageExt = dataReader["PatientDigitalImageExt"].ToString();
                        textBoxDate.Text = Convert.ToDateTime(dataReader["PatientDigitalImageDate"]).ToString("dd-MM-yyyy HH:mm");
                        textBoxComment.Text = dataReader["PatientDigitalImageComment"].ToString();

                        if (Convert.ToInt32(dataReader["DoctorId"]) == formDoctorId)
                        {
                            buttonUpdateComment.Show();
                            buttonDelete.Show();
                        }
                        else
                        {
                            buttonUpdateComment.Hide();
                            buttonDelete.Hide();
                        }
                    }
                }
            }
        }

        private void buttonUpdateComment_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE PatientDigitalImage SET PatientDigitalImageComment = " +
                    "@patientDigitalImageComment WHERE PatientDigitalImageId = @patientDigitalImageId", con);
                cmd.Parameters.AddWithValue("@patientDigitalImageComment", textBoxComment.Text);
                cmd.Parameters.AddWithValue("@patientDigitalImageId", formPatientDigitalImageId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comment updated");
                updateViewDigitalImageDetailForDoctor(formPatientDigitalImageId, formDoctorId);
            }
        }

        private void buttonViewImage_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PatientDigitalImageBlob, PatientDigitalImageExt " +
                    "FROM PatientDigitalImage WHERE PatientDigitalImageId = @digitalImageId", con);
                cmd.Parameters.AddWithValue("@digitalImageId", formPatientDigitalImageId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        byte[] blob = new byte[dataReader.GetBytes(0, 0, null, 0, int.MaxValue)];
                        dataReader.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream("1" + dataReader["PatientDigitalImageExt"].ToString(), FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                        Process.Start("1" + dataReader["PatientDigitalImageExt"].ToString());
                    }
                }
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDigitalImageDialog.Filter = "Digital Image|*" + formDigitalImageExt;
            saveFileDigitalImageDialog.DefaultExt = formDigitalImageExt.Substring(1, formDigitalImageExt.Length - 1);
            if (saveFileDigitalImageDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDigitalImageDialog.FileName))
                {
                    using (MySqlConnection con = new MySqlConnection(cs))
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT PatientDigitalImageBlob, PatientDigitalImageExt " +
                            "FROM PatientDigitalImage WHERE PatientDigitalImageId = @digitalImageId", con);
                        cmd.Parameters.AddWithValue("@digitalImageId", formPatientDigitalImageId);
                        con.Open();
                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                byte[] blob = new byte[dataReader.GetBytes(0, 0, null, 0, int.MaxValue)];
                                dataReader.GetBytes(0, 0, blob, 0, blob.Length);
                                using (var fs = new FileStream(saveFileDigitalImageDialog.FileName, FileMode.Create, FileAccess.Write))
                                    fs.Write(blob, 0, blob.Length);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please specify the file name");
                }
            }
        }
    }
}
