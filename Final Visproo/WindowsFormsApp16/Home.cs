using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pendaftaran_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pendaftaran pendaftaran = new pendaftaran();
            pendaftaran.Show();

            this.Hide();
        }

        private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();

            this.Hide();
        }

        private void Pendaftaran_Click(object sender, EventArgs e)
        {
            pendaftaran pendaftaran = new pendaftaran;
            pendaftaran.Show();

            this.Hide();
        }

        private void Peraturan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            
        }

        private void Kendaraan_Click(object sender, EventArgs e)
        {
            Kendaraan kendaraan = new Kendaraan();
            kendaraan.Show();

            this.Hide();
        }
    }
}
