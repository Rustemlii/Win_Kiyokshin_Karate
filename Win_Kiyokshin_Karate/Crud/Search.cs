using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Kiyokshin_Karate.SqlConnect;

namespace Win_Kiyokshin_Karate.Crud
{
    public class Search
    {
        SqlConnection connection=new SqlConnection(SQLConn.ConSql);

        public Search(string axtar,DataGridView d)
        {
            try
            {
                connection.Open();
                string script = $"SELECT * FROM KARATE WHERE Ad=@Ad";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.Parameters.AddWithValue("@Ad", axtar);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
