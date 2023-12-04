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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kendaraan kendaraan = new Kendaraan(); 
            kendaraan.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Peraturan peraturan = new Peraturan();
            peraturan.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pendaftaran pendaftaran = new pendaftaran();
            pendaftaran.Show();

            this.Hide();
        }
    }
}
