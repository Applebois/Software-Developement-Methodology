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
    public partial class SearchDoctorForm : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public SearchDoctorForm()
        {
            InitializeComponent();
            
            comboBoxSearchBy.SelectedIndex = 0;
            updateListViewListDoctor("SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountActive = 1 AND AccountRoleId = 2", null);
        }

        private void updateListViewListDoctor(string sql, string filter)
        {
            listViewListDoctor.Items.Clear();
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
                        ListViewItem item = new ListViewItem(dataReader["AccountId"].ToString());
                        item.SubItems.Add(dataReader["AccountUsername"].ToString());
                        item.SubItems.Add(dataReader["AccountDisplayName"].ToString());
                        listViewListDoctor.Items.Add(item);
                    }

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || string.IsNullOrEmpty(textBoxSearch.Text))
            {
                updateListViewListDoctor("SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountActive = 1 AND AccountRoleId = 2", null);
            }
            else
            {
                switch (comboBoxSearchBy.SelectedIndex)
                {
                    case 0:
                        updateListViewListDoctor("SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountActive = 1 AND AccountRoleId = 2 AND AccountDisplayName LIKE @filter", textBoxSearch.Text);
                        break;
                    case 1:
                        updateListViewListDoctor("SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountActive = 1 AND AccountRoleId = 2 AND AccountUsername LIKE @filter", textBoxSearch.Text);
                        break;
                }
            }
        }
    }
}
