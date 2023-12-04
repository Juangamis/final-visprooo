namespace WindowsFormsApp16
{
    partial class Kendaraan
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
            this.button1 = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Peraturan = new System.Windows.Forms.Button();
            this.Pendaftaran = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.NAMA = new System.Windows.Forms.TextBox();
            this.NIM = new System.Windows.Forms.TextBox();
            this.Fakultas = new System.Windows.Forms.TextBox();
            this.jurusan = new System.Windows.Forms.TextBox();
            this.txkendaraan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(34, 355);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click_1);
            // 
            // Peraturan
            // 
            this.Peraturan.Location = new System.Drawing.Point(3, 141);
            this.Peraturan.Name = "Peraturan";
            this.Peraturan.Size = new System.Drawing.Size(140, 37);
            this.Peraturan.TabIndex = 11;
            this.Peraturan.Text = "Peraturan";
            this.Peraturan.UseVisualStyleBackColor = true;
            this.Peraturan.Click += new System.EventHandler(this.Peraturan_Click_1);
            // 
            // Pendaftaran
            // 
            this.Pendaftaran.Location = new System.Drawing.Point(3, 107);
            this.Pendaftaran.Name = "Pendaftaran";
            this.Pendaftaran.Size = new System.Drawing.Size(140, 37);
            this.Pendaftaran.TabIndex = 10;
            this.Pendaftaran.Text = "Pendaftaran";
            this.Pendaftaran.UseVisualStyleBackColor = true;
            this.Pendaftaran.Click += new System.EventHandler(this.Pendaftaran_Click_1);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(3, 73);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(140, 40);
            this.About.TabIndex = 9;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 208);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cari";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NAMA
            // 
            this.NAMA.Location = new System.Drawing.Point(349, 30);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(193, 22);
            this.NAMA.TabIndex = 19;
            // 
            // NIM
            // 
            this.NIM.Location = new System.Drawing.Point(349, 66);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(193, 22);
            this.NIM.TabIndex = 19;
            // 
            // Fakultas
            // 
            this.Fakultas.Location = new System.Drawing.Point(349, 107);
            this.Fakultas.Name = "Fakultas";
            this.Fakultas.Size = new System.Drawing.Size(193, 22);
            this.Fakultas.TabIndex = 19;
            // 
            // jurusan
            // 
            this.jurusan.Location = new System.Drawing.Point(349, 149);
            this.jurusan.Name = "jurusan";
            this.jurusan.Size = new System.Drawing.Size(193, 22);
            this.jurusan.TabIndex = 19;
            // 
            // txkendaraan
            // 
            this.txkendaraan.Location = new System.Drawing.Point(349, 190);
            this.txkendaraan.Name = "txkendaraan";
            this.txkendaraan.Size = new System.Drawing.Size(193, 22);
            this.txkendaraan.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(180, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(180, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(180, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fakultas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(180, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Jurusan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(180, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kendaraan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 453);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Kendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txkendaraan);
            this.Controls.Add(this.Fakultas);
            this.Controls.Add(this.jurusan);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Peraturan);
            this.Controls.Add(this.Pendaftaran);
            this.Controls.Add(this.About);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Kendaraan";
            this.Text = "Kendaraan";
            this.Load += new System.EventHandler(this.Kendaraan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Peraturan;
        private System.Windows.Forms.Button Pendaftaran;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NAMA;
        private System.Windows.Forms.TextBox NIM;
        private System.Windows.Forms.TextBox Fakultas;
        private System.Windows.Forms.TextBox jurusan;
        private System.Windows.Forms.TextBox txkendaraan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}