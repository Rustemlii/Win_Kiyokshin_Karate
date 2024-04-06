using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win_Kiyokshin_Karate.SqlConnect;

namespace Win_Kiyokshin_Karate.Crud
{
    public class Delete
    {
        SqlConnection connection=new SqlConnection(SQLConn.ConSql);
        public Delete(int id)
        {
            try
            {
                connection.Open();
                string script = "DELETE FROM KARATE WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");
                connection.Close();            
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
