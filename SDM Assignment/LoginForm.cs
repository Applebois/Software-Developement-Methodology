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
    public partial class LoginForm : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public event EventHandler buttonLoginClickEvent;
        public LoginForm()
        {
            InitializeComponent();
            secretQuestion.Hide();
            secretQuestion.buttonBack.Click += new EventHandler(secretQuestionButtonBack_Click);
            secretQuestion.buttonSubmit.Click += new EventHandler(secretQuestionButtonSubmit_Click);
            secretQuestion.resetPassword.buttonReset.Click += new EventHandler(secretQuestionResetPasswordButtonReset_Click);
        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLoginClickEvent?.Invoke(this, e);
        }

        private void buttonForgetPassword_Click(object sender, EventArgs e)
        {
            secretQuestion.updateSecretQuestion(textBoxUsername.Text);
            secretQuestion.Show();
        }

        private void secretQuestionButtonBack_Click(object sender, EventArgs e)
        {
            secretQuestion.Hide();
        }

        private void secretQuestionResetPasswordButtonReset_Click(object sender, EventArgs e)
        {
            if (!secretQuestion.resetPassword.textBoxPassword.Text.Equals(secretQuestion.resetPassword.textBoxConfirmPassword.Text))
            {
                MessageBox.Show("Password not match with confirm password");
                return;
            }
            string passwordHash = md5.getMD5FromString(secretQuestion.resetPassword.textBoxPassword.Text);
            using(MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Account SET AccountPasswordHash = @passwordHash WHERE AccountId = @accountId", con);
                cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
                cmd.Parameters.AddWithValue("@accountId", secretQuestion.formAccountId);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password changed");
                secretQuestion.resetPassword.updateResetPasswordForm();
                secretQuestion.resetPassword.Hide();
                secretQuestion.Hide();
            }
        }

        private void secretQuestionButtonSubmit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(AccountSecretQuestionAnswer) FROM AccountSecretQuestion WHERE (AccountSecretQuestionIndex BETWEEN 0 AND 2) AND AccountSecretQuestionAnswer = @answer AND AccountId = @accountId", con);
                cmd.Parameters.AddWithValue("@answer", secretQuestion.textBoxFirstAnswer.Text);
                cmd.Parameters.AddWithValue("@accountId", secretQuestion.formAccountId);
                con.Open();
                if (!Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    MessageBox.Show("Invalid answer");
                    return;
                }
            }

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(AccountSecretQuestionAnswer) FROM AccountSecretQuestion WHERE (AccountSecretQuestionIndex BETWEEN 3 AND 5) AND AccountSecretQuestionAnswer = @answer AND AccountId = @accountId", con);
                cmd.Parameters.AddWithValue("@answer", secretQuestion.textBoxSecondAnswer.Text);
                cmd.Parameters.AddWithValue("@accountId", secretQuestion.formAccountId);
                con.Open();
                if (!Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    MessageBox.Show("Invalid answer");
                    return;
                }
            }

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(AccountSecretQuestionAnswer) FROM AccountSecretQuestion WHERE (AccountSecretQuestionIndex BETWEEN 6 AND 8) AND AccountSecretQuestionAnswer = @answer AND AccountId = @accountId", con);
                cmd.Parameters.AddWithValue("@answer", secretQuestion.textBoxThirdAnswer.Text);
                cmd.Parameters.AddWithValue("@accountId", secretQuestion.formAccountId);
                con.Open();
                if (!Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    MessageBox.Show("Invalid answer");
                    return;
                }
            }

            secretQuestion.resetPassword.Show();
        }
        
    }
}
