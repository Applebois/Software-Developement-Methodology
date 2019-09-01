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
    public partial class SearchTechnician : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public SearchTechnician()
        {
            InitializeComponent();
            comboBoxSearchBy.SelectedIndex = 0;
            updateListViewListTechnician(0);
        }

        private void updateListViewListTechnician(int queryCondition)
        {
            listViewTechnician.Items.Clear();
            string[] sql =
            {
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3",
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3 AND AccountId LIKE @filter",
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3 AND AccountUsername LIKE @filter",
                "SELECT AccountId, AccountUsername, AccountDisplayName FROM Account WHERE AccountRoleId = 3 AND AccountDisplayName LIKE @filter"
            };
            listViewTechnician.Items.Clear();
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
                        ListViewItem item = new ListViewItem(dataReader["AccountId"].ToString());
                        item.SubItems.Add(dataReader["AccountUsername"].ToString());
                        item.SubItems.Add(dataReader["AccountDisplayName"].ToString());
                        listViewTechnician.Items.Add(item);
                    }

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || string.IsNullOrEmpty(textBoxSearch.Text))
            {
                updateListViewListTechnician(0);
            }
            else
            {
                updateListViewListTechnician(comboBoxSearchBy.SelectedIndex + 1);
            }
        }
    }
}
