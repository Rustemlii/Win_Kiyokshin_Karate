using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win_Kiyokshin_Karate.SqlConnect;

namespace Win_Kiyokshin_Karate.Crud
{
    public class Insert
    {
        SqlConnection connection = new SqlConnection(SQLConn.ConSql);
        public Insert(string ad,string soyad,int yas,object cins,int odenis,string tarix)
        {
            try
            {
                connection.Open();
                string script = "INSERT INTO KARATE VALUES (@Ad,@Soyad,@Yas,@Cins,@Odenis,@Tarix)";

                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.Parameters.AddWithValue("@Ad",ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Yas", yas);
                cmd.Parameters.AddWithValue("@Cins", cins);
                cmd.Parameters.AddWithValue("@Odenis",odenis);
                cmd.Parameters.AddWithValue("@Tarix", tarix);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni telebe ugurla elave olundu");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
