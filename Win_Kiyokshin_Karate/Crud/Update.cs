using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Kiyokshin_Karate.SqlConnect;

namespace Win_Kiyokshin_Karate.Crud
{
    public class Update
    {
        SqlConnection connection=new SqlConnection(SQLConn.ConSql);

        public Update(string ad,string soyad,string yas,string cins,string odenis,string id,DataGridView d)
        {
            try
            {
                connection.Open();
                string script = "UPDATE KARATE SET Ad=@Ad,Soyad=@Soyad,Yas=@Yas,Cins=@Cins,Odenis=@Odenis WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.Parameters.AddWithValue("@Ad",ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Yas",yas);
                cmd.Parameters.AddWithValue("@Cins", cins);
                cmd.Parameters.AddWithValue("@Odenis", odenis);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                GetAll get = new GetAll(d);
                MessageBox.Show("Deyisiklikler qeyde alindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
