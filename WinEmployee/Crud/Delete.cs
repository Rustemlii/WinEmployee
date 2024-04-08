using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinEmployee.SqlConnecttion;

namespace WinEmployee.Crud
{
    public class Delete
    {
        SqlConnection con = new SqlConnection(ConnectSql.conSql);

        public Delete(int id, DataGridView d)
        {
            try
            {
                con.Open();               
                string script = $"DELETE FROM EMPLOYEE WHERE EMP_ID=@ID";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
