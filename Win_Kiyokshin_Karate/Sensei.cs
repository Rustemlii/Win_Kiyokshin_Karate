using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Kiyokshin_Karate
{
    public partial class Sensei : Form
    {
        public Sensei()
        {
            InitializeComponent();
        }

        private void btnDaxilol_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && txtUser.Text.ToLower() == "demo" && txtPassword.Text.ToLower() == "123")
            {
                Telebe t = new Telebe();
                t.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Parol veya User yanlishdir", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
