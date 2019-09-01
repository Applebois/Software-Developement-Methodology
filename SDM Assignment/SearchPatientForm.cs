using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SDM_Assignment
{
    public partial class SearchPatientForm : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public SearchPatientForm()
        {
            InitializeComponent();
            comboBoxSearchBy.SelectedIndex = 0;
            updateListViewListPatient("SELECT PatientId, PatientIdentity, PatientName, PatientAge, PatientGender, PatientPhoneNumber FROM Patient", null);
        }

        private void updateListViewListPatient(string sql, string filter)
        {
            listViewListPatient.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                if (!string.IsNullOrEmpty(filter))
                {
                    cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                }
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["PatientId"].ToString());
                        item.SubItems.Add(dataReader["PatientIdentity"].ToString());
                        item.SubItems.Add(dataReader["PatientName"].ToString());
                        item.SubItems.Add(dataReader["PatientAge"].ToString());
                        item.SubItems.Add(dataReader["PatientGender"].ToString());
                        item.SubItems.Add(dataReader["PatientPhoneNumber"].ToString());
                        listViewListPatient.Items.Add(item);
                    }
                    
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || string.IsNullOrEmpty(textBoxSearch.Text))
            {
                updateListViewListPatient("SELECT PatientId, PatientIdentity, PatientName, PatientAge, PatientGender, PatientPhoneNumber FROM Patient", null);
            }
            else
            {
                switch (comboBoxSearchBy.SelectedIndex)
                {
                    case 0:
                        updateListViewListPatient("SELECT PatientId, PatientIdentity, PatientName, PatientAge, PatientGender, PatientPhoneNumber FROM Patient WHERE PatientName LIKE @filter", textBoxSearch.Text);
                        break;
                    case 1:
                        updateListViewListPatient("SELECT PatientId, PatientIdentity, PatientName, PatientAge, PatientGender, PatientPhoneNumber FROM Patient WHERE PatientIdentity LIKE @filter", textBoxSearch.Text);
                        break;
                }
            }
        }
    }
}
