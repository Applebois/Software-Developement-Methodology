using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SDM_Assignment
{
    public class UnitTest
    {
        public static Boolean checkIC(string IC)
        {
            Regex rx = new Regex("[0-9]{12}");
            return (rx.Match(IC).Success);
        }

        public static Boolean checkRoles(string roles)
        {

            if (roles == "Administrator")
            {
                return true;
            }
            else if (roles == "Technician")
            {
                return true;
            }
            else if (roles == "Doctor")
            {
                return true;
            }
            else if (roles == "Front Counter")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean checkPassword(string pass)
        {
            return pass.Length > 4;
        }
    }
}
