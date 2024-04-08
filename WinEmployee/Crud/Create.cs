using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinEmployee.SqlConnecttion;

namespace WinEmployee.Crud
{
    public class Create
    {
        SqlConnection con=new SqlConnection(ConnectSql.conSql);
        public  Create(string name,string surname,object birthday,int experience,object position,object department,object status,decimal salary)
        {
            try
            {
                con.Open();
                string script = "INSERT INTO EMPLOYEE VALUES (@NAME,@SURNAME,@BIRTHDAY,@EXPERIENCE,@POSITION,@DEPARTMENT,@STATUS,@SALARY)";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@SURNAME", surname);
                cmd.Parameters.AddWithValue("@BIRTHDAY", birthday);
                cmd.Parameters.AddWithValue("@EXPERIENCE", experience);
                cmd.Parameters.AddWithValue("@POSITION", position);
                cmd.Parameters.AddWithValue("@DEPARTMENT", department);
                cmd.Parameters.AddWithValue("@STATUS", status);
                cmd.Parameters.AddWithValue("@SALARY", salary);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter();
                MessageBox.Show("Ugurla elave olundu");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
