using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinEmployee.SqlConnecttion;

namespace WinEmployee.Crud
{
    public class Search
    {
        SqlConnection con=new SqlConnection(ConnectSql.conSql);

        public Search(string search,DataGridView d)
        {
            try
            {
                con.Open();
                string script = "SELECT * FROM EMPLOYEE WHERE NAME=@NAME";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@NAME", search);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
