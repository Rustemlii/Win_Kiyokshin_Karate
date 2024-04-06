namespace Win_Kiyokshin_Karate
{
    partial class Telebe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnGet = new Button();
            txtAxtar = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtYas = new TextBox();
            txtCins = new TextBox();
            txtOdenis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnUpdate = new Button();
            btnAxtar = new Button();
            btnSil = new Button();
            label7 = new Label();
            btnEvvele = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(217, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(924, 377);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // btnGet
            // 
            btnGet.BackColor = Color.FromArgb(0, 192, 0);
            btnGet.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGet.Location = new Point(830, 115);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(138, 43);
            btnGet.TabIndex = 1;
            btnGet.Text = "Göstər";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // txtAxtar
            // 
            txtAxtar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAxtar.Location = new Point(830, 69);
            txtAxtar.Name = "txtAxtar";
            txtAxtar.Size = new Size(138, 30);
            txtAxtar.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAd.Location = new Point(50, 192);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(138, 30);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSoyad.Location = new Point(50, 253);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(138, 30);
            txtSoyad.TabIndex = 2;
            // 
            // txtYas
            // 
            txtYas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtYas.Location = new Point(50, 314);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(138, 30);
            txtYas.TabIndex = 2;
            // 
            // txtCins
            // 
            txtCins.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtCins.Location = new Point(50, 375);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(138, 30);
            txtCins.TabIndex = 2;
            // 
            // txtOdenis
            // 
            txtOdenis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtOdenis.Location = new Point(50, 436);
            txtOdenis.Name = "txtOdenis";
            txtOdenis.Size = new Size(138, 30);
            txtOdenis.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(99, 161);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 3;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(80, 222);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(92, 283);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 3;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(85, 344);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 3;
            label4.Text = "Cins";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(74, 405);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 3;
            label5.Text = "Ödəniş";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 192);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdate.Location = new Point(50, 483);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 44);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Redaktə et";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAxtar
            // 
            btnAxtar.BackColor = Color.FromArgb(255, 128, 0);
            btnAxtar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAxtar.Location = new Point(985, 63);
            btnAxtar.Name = "btnAxtar";
            btnAxtar.Size = new Size(138, 36);
            btnAxtar.TabIndex = 4;
            btnAxtar.Text = "Axtar";
            btnAxtar.UseVisualStyleBackColor = false;
            btnAxtar.Click += btnAxtar_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSil.Location = new Point(985, 115);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(138, 43);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(163, 29);
            label7.Name = "label7";
            label7.Size = new Size(608, 50);
            label7.TabIndex = 3;
            label7.Text = "Kiyokshin Karate Fight Club";
            // 
            // btnEvvele
            // 
            btnEvvele.BackColor = Color.FromArgb(255, 128, 255);
            btnEvvele.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEvvele.Location = new Point(985, 12);
            btnEvvele.Name = "btnEvvele";
            btnEvvele.Size = new Size(134, 39);
            btnEvvele.TabIndex = 5;
            btnEvvele.Text = "Qeydiyyat";
            btnEvvele.UseVisualStyleBackColor = false;
            btnEvvele.Click += btnEvvele_Click;
            // 
            // Telebe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1144, 551);
            Controls.Add(btnEvvele);
            Controls.Add(btnSil);
            Controls.Add(btnAxtar);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtOdenis);
            Controls.Add(txtCins);
            Controls.Add(txtYas);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtAxtar);
            Controls.Add(btnGet);
            Controls.Add(dataGridView1);
            Name = "Telebe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telebe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGet;
        private TextBox txtAxtar;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtYas;
        private TextBox txtCins;
        private TextBox txtOdenis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnUpdate;
        private Button btnAxtar;
        private Button btnSil;
        private Label label7;
        private Button btnEvvele;
    }
}