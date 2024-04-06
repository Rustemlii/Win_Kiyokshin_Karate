namespace Win_Kiyokshin_Karate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtad = new TextBox();
            txtSoyad = new TextBox();
            txtyas = new TextBox();
            txtOdenish = new TextBox();
            cmbCins = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            datetimerrrr = new DateTimePicker();
            ımageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label9 = new Label();
            btnElaveEt = new Button();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtad
            // 
            txtad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtad.Location = new Point(119, 101);
            txtad.Name = "txtad";
            txtad.Size = new Size(173, 30);
            txtad.TabIndex = 0;
            txtad.TextChanged += txtad_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSoyad.Location = new Point(119, 147);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(173, 30);
            txtSoyad.TabIndex = 1;
            // 
            // txtyas
            // 
            txtyas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtyas.Location = new Point(119, 196);
            txtyas.Name = "txtyas";
            txtyas.Size = new Size(173, 30);
            txtyas.TabIndex = 2;
            // 
            // txtOdenish
            // 
            txtOdenish.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtOdenish.Location = new Point(119, 286);
            txtOdenish.Name = "txtOdenish";
            txtOdenish.Size = new Size(173, 30);
            txtOdenish.TabIndex = 4;
            // 
            // cmbCins
            // 
            cmbCins.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbCins.FormattingEnabled = true;
            cmbCins.Items.AddRange(new object[] { "Kişi", "Qadın" });
            cmbCins.Location = new Point(119, 241);
            cmbCins.Name = "cmbCins";
            cmbCins.Size = new Size(173, 31);
            cmbCins.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(62, 97);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(30, 143);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(55, 192);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 2;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(24, 282);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 2;
            label4.Text = "Ödəniş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(48, 241);
            label5.Name = "label5";
            label5.Size = new Size(52, 28);
            label5.TabIndex = 2;
            label5.Text = "Cins";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(30, 333);
            label7.Name = "label7";
            label7.Size = new Size(61, 28);
            label7.TabIndex = 2;
            label7.Text = "Tarix";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(360, 9);
            label8.Name = "label8";
            label8.Size = new Size(260, 41);
            label8.TabIndex = 2;
            label8.Text = "Kiyokshin Karate";
            // 
            // datetimerrrr
            // 
            datetimerrrr.Location = new Point(119, 335);
            datetimerrrr.Name = "datetimerrrr";
            datetimerrrr.Size = new Size(250, 27);
            datetimerrrr.TabIndex = 5;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 372);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(108, 53);
            label9.Name = "label9";
            label9.Size = new Size(184, 28);
            label9.TabIndex = 2;
            label9.Text = "Yeni Telebe Formu";
            // 
            // btnElaveEt
            // 
            btnElaveEt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnElaveEt.Location = new Point(119, 387);
            btnElaveEt.Name = "btnElaveEt";
            btnElaveEt.Size = new Size(173, 38);
            btnElaveEt.TabIndex = 6;
            btnElaveEt.Text = "Əlavə et";
            btnElaveEt.UseVisualStyleBackColor = true;
            btnElaveEt.Click += btnElaveEt_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdmin.Location = new Point(524, 448);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(173, 44);
            btnAdmin.TabIndex = 7;
            btnAdmin.Text = "Sensei";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(720, 504);
            Controls.Add(btnAdmin);
            Controls.Add(btnElaveEt);
            Controls.Add(pictureBox1);
            Controls.Add(datetimerrrr);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(cmbCins);
            Controls.Add(txtOdenish);
            Controls.Add(txtyas);
            Controls.Add(txtSoyad);
            Controls.Add(txtad);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtad;
        private TextBox txtSoyad;
        private TextBox txtyas;
        private TextBox txtOdenish;
        private ComboBox cmbCins;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private DateTimePicker datetimerrrr;
        private ImageList ımageList1;
        private PictureBox pictureBox1;
        private Label label9;
        private Button btnElaveEt;
        private Button btnAdmin;
    }
}