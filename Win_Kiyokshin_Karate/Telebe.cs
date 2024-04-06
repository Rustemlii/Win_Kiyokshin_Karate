using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Kiyokshin_Karate.Crud;
using Win_Kiyokshin_Karate.SqlConnect;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Win_Kiyokshin_Karate
{
    public partial class Telebe : Form
    {

        public Telebe()
        {
            InitializeComponent();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {

            GetAll get = new GetAll(dataGridView1);
            txtAxtar.Text = string.Empty;

        }
        void Sifirlama()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtYas.Text = string.Empty;
            txtCins.Text = string.Empty;
            txtOdenis.Text = string.Empty;

        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            int a = 0;
            a = e.RowIndex;           
            txtAd.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
            txtYas.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
            txtCins.Text = dataGridView1.Rows[a].Cells[4].Value.ToString();
            txtOdenis.Text = dataGridView1.Rows[a].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                Update update = new Update(txtAd.Text, txtSoyad.Text, txtYas.Text, txtCins.Text, txtOdenis.Text, id.ToString(), dataGridView1);
                Sifirlama();
            }






        }

        private void btnAxtar_Click(object sender, EventArgs e)
        {

            Search search = new Search(txtAxtar.Text, dataGridView1);
            Sifirlama();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                Delete delete = new Delete(id);
                GetAll get = new GetAll(dataGridView1);
                Sifirlama();
            }




        }

        private void btnEvvele_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
