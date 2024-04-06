using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win_Kiyokshin_Karate.SqlConnect;

namespace Win_Kiyokshin_Karate.Crud
{
    public class GetAll
    {
        SqlConnection connection = new SqlConnection(SQLConn.ConSql);

        public GetAll(DataGridView d)
        {
            try
            {
                connection.Open();
                string script = "SELECT * FROM KARATE";
                SqlCommand cmd = new SqlCommand(script, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }
    }
}
