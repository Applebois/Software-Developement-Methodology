using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SDM_Assignment
{
    public partial class fmcMainForm : MaterialForm
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        private int wrongAttempt = 0;
        private bool ctrlKeyDown = false;
        public fmcMainForm()
        {
            InitializeComponent();
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void fmcMainForm_Load(object sender, EventArgs e)
        {
            loginForm.Show();
            itManagerMainMenu.Hide();
            frontCounterMainMenu.Hide();
            technicianMainMenu.Hide();
            doctorMainMenu.Hide();
           
            loginForm.buttonLoginClickEvent += new EventHandler(buttonLogin_Click);
        }
        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (wrongAttempt < 3)
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT AccountId, AccountRoleId FROM Account WHERE AccountUsername = @username AND AccountPasswordHash = @password", con);
                    if (!string.IsNullOrEmpty(loginForm.textBoxUsername.Text))
                    {
                        cmd.Parameters.AddWithValue("@username", loginForm.textBoxUsername.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@username", "");
                    }
                    if (!string.IsNullOrEmpty(loginForm.textBoxPassword.Text))
                    {
                        cmd.Parameters.AddWithValue("@password", md5.getMD5FromString(loginForm.textBoxPassword.Text));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@password", "");
                    }
                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            switch (Convert.ToInt32(rdr["AccountRoleId"]))
                            {
                                case 1:
                                    frontCounterMainMenu.Show();
                                    break;
                                case 2:
                                    doctorMainMenu.updateDoctorMainMenu(Convert.ToInt32(rdr["AccountId"]));
                                    doctorMainMenu.Show();
                                    break;
                                case 3:
                                    technicianMainMenu.updateTechnicianMainMenu(Convert.ToInt32(rdr["AccountId"]));
                                    technicianMainMenu.Show();
                                    break;
                                case 4:
                                    itManagerMainMenu.Show();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found");
                            wrongAttempt++;
                        }
                    }
                }
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE Account SET AccountActive = 0 WHERE AccountUsername = @username", con);
                    cmd.Parameters.AddWithValue("@username", loginForm.textBoxUsername.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("More than 3 wrong attempt, " + loginForm.textBoxUsername.Text + " account is locked");
                }
            }
        }

        private void fmcMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    ctrlKeyDown = true;
                    break;
                case Keys.Oemtilde:
                    if (ctrlKeyDown)
                    {
                        loginForm.Show();
                        itManagerMainMenu.Hide();
                        frontCounterMainMenu.Hide();
                        technicianMainMenu.Hide();
                        doctorMainMenu.Hide();
                        loginForm.textBoxPassword.Text = string.Empty;
                        loginForm.textBoxUsername.Text = string.Empty;
                    }
                    break;
            }
        }

        private void fmcMainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey)
            {
                ctrlKeyDown = false;
            }
        }
    }
}
