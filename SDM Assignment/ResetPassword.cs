using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Assignment
{
    public partial class ResetPassword : UserControl
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        public void updateResetPasswordForm()
        {
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPassword.Text = string.Empty;
        }
    }
}
