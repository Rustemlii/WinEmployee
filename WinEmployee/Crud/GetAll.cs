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
    public class GetAll
    {
        SqlConnection con = new SqlConnection(ConnectSql.conSql);
        public GetAll(DataGridView d)
        {
            try
            {
                con.Open();
                string script = "SELECT * FROM EMPLOYEE";
                SqlCommand cmd = new SqlCommand(script, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
