namespace WindowsFormsApp16
{
    partial class Home
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
            this.About = new System.Windows.Forms.Button();
            this.Pendaftaran = new System.Windows.Forms.Button();
            this.Peraturan = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Kendaraan = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(0, 73);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(140, 40);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Pendaftaran
            // 
            this.Pendaftaran.Location = new System.Drawing.Point(0, 107);
            this.Pendaftaran.Name = "Pendaftaran";
            this.Pendaftaran.Size = new System.Drawing.Size(140, 37);
            this.Pendaftaran.TabIndex = 3;
            this.Pendaftaran.Text = "Pendaftaran";
            this.Pendaftaran.UseVisualStyleBackColor = true;
            this.Pendaftaran.Click += new System.EventHandler(this.Pendaftaran_Click);
            // 
            // Peraturan
            // 
            this.Peraturan.Location = new System.Drawing.Point(0, 141);
            this.Peraturan.Name = "Peraturan";
            this.Peraturan.Size = new System.Drawing.Size(140, 37);
            this.Peraturan.TabIndex = 4;
            this.Peraturan.Text = "Peraturan";
            this.Peraturan.UseVisualStyleBackColor = true;
            this.Peraturan.Click += new System.EventHandler(this.Peraturan_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(31, 355);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Kendaraan
            // 
            this.Kendaraan.Location = new System.Drawing.Point(0, 175);
            this.Kendaraan.Name = "Kendaraan";
            this.Kendaraan.Size = new System.Drawing.Size(140, 37);
            this.Kendaraan.TabIndex = 6;
            this.Kendaraan.Text = "Kendaraan";
            this.Kendaraan.UseVisualStyleBackColor = true;
            this.Kendaraan.Click += new System.EventHandler(this.Kendaraan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 453);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp16.Properties.Resources.Desain_tanpa_judul__7_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kendaraan);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Peraturan);
            this.Controls.Add(this.Pendaftaran);
            this.Controls.Add(this.About);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Pendaftaran;
        private System.Windows.Forms.Button Peraturan;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Kendaraan;
    }
}