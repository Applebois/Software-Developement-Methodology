using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;

namespace SDM_Assignment
{
    public partial class ViewPatientRecordDigitalImageForDoctor : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        List<string> fileNames = new List<string>();
        private int formPatientRecordId = 0;
        private int formDoctorId = 0; 
        public ViewPatientRecordDigitalImageForDoctor()
        {
            InitializeComponent();
            viewDigitalImageDetailForDoctor.Hide();
            viewDigitalImageDetailForDoctor.buttonBack.Click += new EventHandler(viewDigitalImageDetailForDoctorButtonBack_Click);
            viewDigitalImageDetailForDoctor.buttonDelete.Click += new EventHandler(viewDigitalImageDetailForDoctorButtonDelete_Click);
        }

        public void updateViewPatientRecordDigitalImageForDoctorForm(int patientRecordId, int doctorId)
        {
            formPatientRecordId = patientRecordId;
            formDoctorId = doctorId;
            listViewListPatientDigitalImage.Items.Clear();
            textBoxComment.Text = string.Empty;
            textBoxDigitalImage.Text = string.Empty;
            fileNames.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PatientDigitalImage.PatientDigitalImageId, PatientDigitalImage.PatientDigitalImageComment, " +
                    "PatientDigitalImage.PatientDigitalImageDate FROM PatientDigitalImage WHERE PatientDigitalImage.PatientRecordId = @recordId;", con);
                cmd.Parameters.AddWithValue("@recordId", formPatientRecordId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["PatientDigitalImageId"].ToString());
                        if (dataReader["PatientDigitalImageComment"] != DBNull.Value)
                        {
                            item.SubItems.Add(dataReader["PatientDigitalImageComment"].ToString());
                        }
                        else
                        {
                            item.SubItems.Add(string.Empty);
                        }
                        item.SubItems.Add(dataReader["PatientDigitalImageDate"].ToString());
                        listViewListPatientDigitalImage.Items.Add(item);
                    }
                }
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT COUNT(PatientRecord.DoctorId) FROM PatientRecord WHERE PatientRecord.PatientRecordId = @recordId AND PatientRecord.DoctorId = @doctorId";
                cmd.Parameters.AddWithValue("@recordId", formPatientRecordId);
                cmd.Parameters.AddWithValue("@doctorId", formDoctorId);
                bool doctorInCharge = Convert.ToBoolean(cmd.ExecuteScalar());
                if (doctorInCharge)
                {
                    labelComment.Show();
                    labelDigitalImage.Show();
                    textBoxComment.Show();
                    textBoxDigitalImage.Show();
                    buttonBrowse.Show();
                    buttonNewPatientDigitalImage.Show();
                }
                else
                {
                    labelComment.Hide();
                    labelDigitalImage.Hide();
                    textBoxComment.Hide();
                    textBoxDigitalImage.Hide();
                    buttonBrowse.Hide();
                    buttonNewPatientDigitalImage.Hide();
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            
            if (openFileDigitalImageDialog.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDigitalImageDialog.FileNames.ToList();
                foreach (var fileName in fileNames)
                {
                    textBoxDigitalImage.Text += Path.GetFileName(fileName) + " ";
                }
            }
        }

        private void buttonNewPatientDigitalImage_Click(object sender, EventArgs e)
        {
            if (fileNames.Any())
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO PatientDigitalImage (PatientRecordId, PatientDigitalImageBlob, " +
                        "PatientDigitalImageExt, PatientDigitalImageComment, PatientDigitalImageDate) VALUES(@recordId, @imageBlob, @imageExt, @imageComment, @imageDate)", con);
                    con.Open();
                    foreach (var fileName in fileNames)
                    {
                        byte[] file;
                        using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = new BinaryReader(stream))
                            {
                                file = reader.ReadBytes((int)stream.Length);
                            }
                        }
                        string fileNameExt = Path.GetExtension(fileName);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@recordId", formPatientRecordId);
                        cmd.Parameters.AddWithValue("@imageExt", fileNameExt);
                        cmd.Parameters.Add("@imageBlob", MySqlDbType.LongBlob, file.Length).Value = file;
                        cmd.Parameters.AddWithValue("@imageComment", textBoxComment.Text);
                        cmd.Parameters.AddWithValue("@imageDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Digital image uploaded");
                }
                updateViewPatientRecordDigitalImageForDoctorForm(formPatientRecordId, formDoctorId);
            }
            else
            {
                MessageBox.Show("Please specify the image to upload");
            }
        }

        private void listViewListPatientDigitalImage_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewDigitalImageDetailForDoctor.updateViewDigitalImageDetailForDoctor(Convert.ToInt32(info.Item.SubItems[0].Text), formDoctorId);
                viewDigitalImageDetailForDoctor.Show();
            }
        }

        private void viewDigitalImageDetailForDoctorButtonBack_Click(object sender, EventArgs e)
        {
            updateViewPatientRecordDigitalImageForDoctorForm(formPatientRecordId, formDoctorId);
            viewDigitalImageDetailForDoctor.Hide();
        }

        private void viewDigitalImageDetailForDoctorButtonDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM PatientDigitalImage WHERE PatientDigitalImageId = @patientDigitalImageId;", con);
                cmd.Parameters.AddWithValue("@patientDigitalImageId", viewDigitalImageDetailForDoctor.formPatientDigitalImageId);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Digital image deleted");
                
            }
            updateViewPatientRecordDigitalImageForDoctorForm(formPatientRecordId, formDoctorId);
            viewDigitalImageDetailForDoctor.Hide();
        }
        
    }
}
