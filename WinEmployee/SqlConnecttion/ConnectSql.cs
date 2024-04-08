using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinEmployee.SqlConnecttion
{
    public class ConnectSql
    {
        public static string conSql = @"Server=DESKTOP-L12NAJ2\SQLEXPRESS;Database=EMPLOYEEDB;Trusted_Connection=true;Encrypt=false;";
        //public static string conSql = @"Server=DESKTOP-L12NAJ2\SQLEXPRESS;DataBase=EMPLOYEEDB;
        //Trusted_Connection=true;Encrypt=false;";//aralarindaki " ; " mutleqdir yoxsa iwlemiyecek...
    }
}
