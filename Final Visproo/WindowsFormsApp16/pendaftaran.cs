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
    public partial class pendaftaran : Form
    {
        public pendaftaran()
        {
            InitializeComponent();
        }

        private void nama_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Peraturan peraturan = new Peraturan();
            peraturan.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kendaraan kendaraan = new Kendaraan();
            kendaraan.Show();

            this.Hide();
        }
    }
}
