using System;
using System.Data.SqlClient;
using Win_Kiyokshin_Karate.Crud;
using Win_Kiyokshin_Karate.SqlConnect;


namespace Win_Kiyokshin_Karate
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(SQLConn.ConSql);
        public Form1()
        {
            InitializeComponent();
        }

        void Sifirlama()
        {
            txtad.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtOdenish.Text = string.Empty;
            txtyas.Text = string.Empty;
            cmbCins.Text = string.Empty;
            datetimerrrr.Text = string.Empty;
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Sensei s = new Sensei();
            s.Show();
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert(txtad.Text, txtSoyad.Text, Convert.ToInt32(txtyas.Text),
                cmbCins.SelectedItem.ToString(), Convert.ToInt32(txtOdenish.Text), datetimerrrr.Value.ToString());
            Sifirlama();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}