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
using MaterialSkin.Controls;

namespace SDM_Assignment
{
    public partial class ITManagerMainMenu : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        AccountClass currentViewAccount = null;
        public ITManagerMainMenu()
        {
            InitializeComponent();
            updateGridViewListAccount();
            comboBoxActive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegisterActive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActive.SelectedIndex = 0;
            comboBoxRole.SelectedIndex = 0;
            comboBoxRegisterActive.SelectedIndex = 0;
            comboBoxRegisterRole.SelectedIndex = 0;
            comboBoxFirstQuestion.SelectedIndex = 0;
            comboBoxSecondQuestion.SelectedIndex = 0;
            comboBoxThirdQuestion.SelectedIndex = 0;
            viewMachineDetailForAdministrator.Hide();
            viewMachineListForAdministrator.listViewListMachine.MouseDown += new MouseEventHandler(viewMachineListForAdministratorListViewListMachine_MouseDown);
            viewMachineDetailForAdministrator.buttonBack.Click += new EventHandler(viewMachineDetailForAdministratorButtonBack_Click);
            viewPatientListForAdministrator.listViewListPatient.MouseDown += new MouseEventHandler(viewPatientListForAdministratorListViewListPatient_MouseDown);
            viewPatientDetailForAdministrator.Hide();
            viewPatientDetailForAdministrator.buttonBack.Click += new EventHandler(viewPatientDetailForAdministratorButtonBack_Click);
        }

        private void updateGridViewListAccount()
        {
            listViewListAccount.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Account.AccountId, Account.AccountUsername, Account.AccountDisplayName, AccountRoleTrans.AccountRoleTrans, Account.AccountActive FROM Account JOIN AccountRoleTrans ON Account.AccountRoleId = AccountRoleTrans.AccountRoleId", con);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ListViewItem item = new ListViewItem(dataReader["AccountId"].ToString());
                        item.SubItems.Add(dataReader["AccountUsername"].ToString());
                        item.SubItems.Add(dataReader["AccountDisplayName"].ToString());
                        item.SubItems.Add(dataReader["AccountRoleTrans"].ToString());
                        item.SubItems.Add(dataReader["AccountActive"].ToString());
                        listViewListAccount.Items.Add(item);
                    }
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string passwordHash = null;
            if (!textBoxRegisterPassword.Text.Equals(textBoxRegisterConfirmPassword.Text))
            {
                MessageBox.Show("Password not match!");
                return;
            }
            else
            {
                if (!UnitTest.checkPassword(textBoxRegisterPassword.Text))
                {
                    MessageBox.Show("Password length more than 4 character");
                    return;
                }
                try
                {
                    passwordHash = md5.getMD5FromString(textBoxRegisterPassword.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            bool accountExist = true;
            if (string.IsNullOrEmpty(textBoxFirstAnswer.Text) && string.IsNullOrEmpty(textBoxSecondAnswer.Text) && string.IsNullOrEmpty(textBoxThirdAnswer.Text))
            {
                MessageBox.Show("Please answer all secret question");
                return;
            }
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(AccountUsername) FROM Account WHERE AccountUsername = @username", con);
                cmd.Parameters.AddWithValue("@username", textBoxRegisterUsername.Text);
                con.Open();
                accountExist = Convert.ToBoolean(cmd.ExecuteScalar());
            }

            if (accountExist)
            {
                MessageBox.Show("Username taken!");
                return;
            }
            else
            {
                if (!UnitTest.checkRoles(comboBoxRegisterRole.Text))
                {
                    MessageBox.Show("Role not found");
                    return;
                }
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Account (AccountUsername, AccountPasswordHash, " +
                        "AccountDisplayName, AccountRoleId, AccountActive) VALUES (@username, @passwordHash, @displayName, @role, @active); SELECT LAST_INSERT_ID();", con);
                    cmd.Parameters.AddWithValue("@username", textBoxRegisterUsername.Text);
                    cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@displayName", textBoxRegisterDisplayName.Text);
                    cmd.Parameters.AddWithValue("@role", comboBoxRegisterRole.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@active", Convert.ToBoolean(comboBoxRegisterActive.Text));
                    con.Open();
                    int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = "INSERT INTO AccountSecretQuestion (AccountId, AccountSecretQuestionIndex, AccountSecretQuestionAnswer) VALUES (@accountId, @index, @answer);";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@accountId", lastInsertedId);
                    cmd.Parameters.AddWithValue("@index", comboBoxFirstQuestion.SelectedIndex);
                    cmd.Parameters.AddWithValue("@answer", textBoxFirstAnswer.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@accountId", lastInsertedId);
                    cmd.Parameters.AddWithValue("@index", comboBoxSecondQuestion.SelectedIndex + 3);
                    cmd.Parameters.AddWithValue("@answer", textBoxSecondAnswer.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@accountId", lastInsertedId);
                    cmd.Parameters.AddWithValue("@index", comboBoxThirdQuestion.SelectedIndex + 6);
                    cmd.Parameters.AddWithValue("@answer", textBoxThirdAnswer.Text);
                    cmd.ExecuteNonQuery();
                    clearRegisterForm();
                    updateGridViewListAccount();
                    MessageBox.Show("Account created");
                }
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (currentViewAccount != null)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Account SET AccountDisplayName = @displayName, AccountRoleId = @role, AccountActive = @active WHERE AccountId = @id", con);
                    cmd.Parameters.AddWithValue("@displayName", textBoxDisplayName.Text);
                    cmd.Parameters.AddWithValue("@role", comboBoxRole.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@active", Convert.ToBoolean(comboBoxActive.Text));
                    cmd.Parameters.AddWithValue("@id", currentViewAccount.AccountId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    currentViewAccount = null;
                    clearUpdateForm();
                    updateGridViewListAccount();
                    MessageBox.Show("Account updated");

                }
            }
            else
            {
                MessageBox.Show("Select an account from the list first to update");
                return;
            }
        }
        private void clearRegisterForm()
        {
            textBoxRegisterUsername.Text = string.Empty;
            textBoxRegisterPassword.Text = string.Empty;
            textBoxRegisterConfirmPassword.Text = string.Empty;
            textBoxRegisterDisplayName.Text = string.Empty;
            comboBoxRegisterRole.Text = string.Empty;
            comboBoxRegisterActive.Text = string.Empty;
            comboBoxFirstQuestion.SelectedIndex = 0;
            comboBoxSecondQuestion.SelectedIndex = 0;
            comboBoxThirdQuestion.SelectedIndex = 0;
            textBoxFirstAnswer.Text = string.Empty;
            textBoxSecondAnswer.Text = string.Empty;
            textBoxThirdAnswer.Text = string.Empty;
        }
        private void clearUpdateForm()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxDisplayName.Text = "";
            comboBoxRole.Text = "";
            comboBoxActive.Text = "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                string passwordHash = md5.getMD5FromString(textBoxPassword.Text);
                if (currentViewAccount != null)
                {
                    using (MySqlConnection con = new MySqlConnection(cs))
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE ACCOUNT SET AccountPasswordHash = @passwordHash WHERE AccountId = @id", con);
                        cmd.Parameters.AddWithValue("@passwordHash", passwordHash); ;
                        cmd.Parameters.AddWithValue("@id", currentViewAccount.AccountId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        currentViewAccount = null;
                        clearUpdateForm();
                        updateGridViewListAccount();
                        MessageBox.Show("Account password updated");

                    }
                }
                else
                {
                    MessageBox.Show("Select an account from the list first to update");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Password not match!");
            }
        }

        private void listViewListAccount_MouseDown(object sender, MouseEventArgs e)
        {
            var info = listViewListAccount.HitTest(e.X, e.Y);
            currentViewAccount = new AccountClass()
            {
                AccountId = Convert.ToInt32(info.Item.SubItems[0].Text),
                AccountUsername = info.Item.SubItems[1].Text,
                AccountDisplayName = info.Item.SubItems[2].Text,
                AccountRole = info.Item.SubItems[3].Text,
                AccountActive = Convert.ToBoolean(info.Item.SubItems[4].Text)
            };

            if (currentViewAccount != null)
            {
                textBoxUsername.Text = currentViewAccount.AccountUsername;
                textBoxDisplayName.Text = currentViewAccount.AccountDisplayName;
                comboBoxRole.Text = currentViewAccount.AccountRole;
                comboBoxActive.Text = currentViewAccount.AccountActive.ToString();
            }
        }
        
        private void viewMachineListForAdministratorListViewListMachine_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewMachineDetailForAdministrator.updateViewMachineDetailForAdministratorForm(Convert.ToInt32(info.Item.SubItems[0].Text));
                viewMachineDetailForAdministrator.Show();
            }
        }

        private void ITManagerMainMenuTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((MaterialTabControl)sender).SelectedIndex == 2)
            {
                viewMachineListForAdministrator.updateListViewListMachine(0);
            }
        }

        private void viewMachineDetailForAdministratorButtonBack_Click(object sender, EventArgs e)
        {
            viewMachineListForAdministrator.updateListViewListMachine(0);
            viewMachineDetailForAdministrator.Hide();
        }

        private void viewPatientListForAdministratorListViewListPatient_MouseDown(object sender, MouseEventArgs e)
        {
            var info = ((MaterialListView)sender).HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                viewPatientDetailForAdministrator.updatePatientDetailForAdministrator(Convert.ToInt32(info.Item.SubItems[0].Text));
                viewPatientDetailForAdministrator.Show();
            }
        }

        private void viewPatientDetailForAdministratorButtonBack_Click(object sender, EventArgs e)
        {
            viewPatientDetailForAdministrator.Hide();
        }
    }
}
