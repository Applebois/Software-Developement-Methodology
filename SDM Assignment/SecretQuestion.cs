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
    public partial class SecretQuestion : UserControl
    {
        string cs = "datasource=auth-db152.hostinger.my;port=3306;username=u845574455_sam;pwd=qwertyuiop;database=u845574455_oscp;";
        public int formAccountId = 0;
        public int firstQuestionIndex = 0;
        public int secondQuestionIndex = 3;
        public int thirdQuestionIndex = 6;
        public SecretQuestion()
        {
            InitializeComponent();
            resetPassword.Hide();
        }

        public void updateSecretQuestion(string username)
        {
            textBoxUsername.Text = username;
            textBoxFirstAnswer.Text = string.Empty;
            textBoxSecondAnswer.Text = string.Empty;
            textBoxThirdAnswer.Text = string.Empty;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT AccountId FROM Account WHERE AccountUsername = @username", con);
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                using(MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        formAccountId = Convert.ToInt32(dataReader["AccountId"]);
                    }
                    else
                    {
                        formAccountId = 0;
                    }
                }
            }

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT AccountSecretQuestionIndex FROM AccountSecretQuestion WHERE AccountId = @accountId AND AccountSecretQuestionIndex BETWEEN 0 AND 2", con);
                cmd.Parameters.AddWithValue("@accountId", formAccountId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        firstQuestionIndex = Convert.ToInt32(dataReader["AccountSecretQuestionIndex"]);
                    }
                    else
                    {
                        firstQuestionIndex = 0;
                    }
                }
            }

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT AccountSecretQuestionIndex FROM AccountSecretQuestion WHERE AccountId = @accountId AND AccountSecretQuestionIndex BETWEEN 3 AND 5", con);
                cmd.Parameters.AddWithValue("@accountId", formAccountId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        secondQuestionIndex = Convert.ToInt32(dataReader["AccountSecretQuestionIndex"]);
                    }
                    else
                    {
                        secondQuestionIndex = 3;
                    }
                }
            }

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT AccountSecretQuestionIndex FROM AccountSecretQuestion WHERE AccountId = @accountId AND AccountSecretQuestionIndex BETWEEN 6 AND 8", con);
                cmd.Parameters.AddWithValue("@accountId", formAccountId);
                con.Open();
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        thirdQuestionIndex = Convert.ToInt32(dataReader["AccountSecretQuestionIndex"]);
                    }
                    else
                    {
                        thirdQuestionIndex = 6;
                    }
                }
            }

            string[] question =
            {
                "What was the house number and street name you lived in as a child?",
                "What were the last four digits of your childhood telephone number?",
                "What primary school did you attend?",
                "In what town or city was your first full time job?",
                "In what town or city did you meet your spouse/partner?",
                "What is the middle name of your oldest child?",
                "What are the last five digits of your driver's licence number?",
                "What is your grandmother's (on your mother's side) maiden name?",
                "In what town or city did your mother and father meet?"
            };

            textBoxFirstQuestion.Text = question[firstQuestionIndex];
            textBoxSecondQuestion.Text = question[secondQuestionIndex];
            textBoxThirdQuestion.Text = question[thirdQuestionIndex];
        }
        
    }
}
