using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_s_Desk
{
    class softwaresettings
    {
        public static string connection()
        {
            string con= "Server=localhost;Database=gd;Convert Zero Datetime=True;Uid=root;Pwd=''"; ;
            return con;
        }
    }
}
