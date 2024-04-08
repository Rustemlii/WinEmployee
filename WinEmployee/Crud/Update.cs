using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinEmployee.SqlConnecttion;

namespace WinEmployee.Crud
{
    public class Update
    {
        SqlConnection con = new SqlConnection(ConnectSql.conSql);
        public Update(int id,string name,string surname,object birthday,int experience,object position,object department,object status,decimal salary,DataGridView d)
        {
            try
            {
                con.Open();
                string script = "UPDATE EMPLOYEE SET NAME=@NAME,SURNAME=@SURNAME,BIRTHDAY=@BIRTHDAY,EXPERIENCE=@EXPERIENCE,POSITION=@POSITION,DEPARTMENT=@DEPARTMENT,STATUS=@STATUS,SALARY=@SALARY WHERE EMP_ID=@ID";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@SURNAME", surname);
                cmd.Parameters.AddWithValue("@BIRTHDAY", birthday);
                cmd.Parameters.AddWithValue("@EXPERIENCE", experience);
                cmd.Parameters.AddWithValue("@POSITION", position);
                cmd.Parameters.AddWithValue("@DEPARTMENT", department);
                cmd.Parameters.AddWithValue("@STATUS", status);
                cmd.Parameters.AddWithValue("@SALARY", salary);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Succesfully Updated");
                d.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
