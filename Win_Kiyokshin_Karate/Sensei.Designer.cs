namespace Win_Kiyokshin_Karate
{
    partial class Sensei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sensei));
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDaxilol = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(154, 113);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(184, 29);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(154, 154);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 30);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(74, 111);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(74, 154);
            label2.Name = "label2";
            label2.Size = new Size(71, 31);
            label2.TabIndex = 1;
            label2.Text = "Parol";
            // 
            // btnDaxilol
            // 
            btnDaxilol.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDaxilol.Location = new Point(171, 198);
            btnDaxilol.Name = "btnDaxilol";
            btnDaxilol.Size = new Size(141, 43);
            btnDaxilol.TabIndex = 2;
            btnDaxilol.Text = "Daxil ol";
            btnDaxilol.UseVisualStyleBackColor = true;
            btnDaxilol.Click += btnDaxilol_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 362);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 4;
            label3.Text = "Login: Demo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 32);
            label4.Name = "label4";
            label4.Size = new Size(126, 23);
            label4.TabIndex = 4;
            label4.Text = "Password: 123";
            // 
            // Sensei
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(690, 441);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnDaxilol);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Name = "Sensei";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sensei";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnDaxilol;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}