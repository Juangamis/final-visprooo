using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp16
{
    public partial class Kendaraan : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;



        public Kendaraan()
        {
            alamat = "server=localhost; database= juang; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void Pendaftaran_Click(object sender, EventArgs e)
        {

        }

        private void Peraturan_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void About_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from dbparkiran where NAMA = '{0}'", NAMA.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        NAMA.Text = kolom["Nama"].ToString();
                        NIM.Text = kolom["NIM"].ToString();
                        Fakultas.Text = kolom["Fakultas"].ToString();
                        jurusan.Text = kolom["Jurusan"].ToString();
                        txkendaraan.Text = kolom["Kendaraan"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("data tidak ditemukan");
                    Kendaraan_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Pendaftaran_Click_1(object sender, EventArgs e)
        {
            pendaftaran penfataran = new pendaftaran();
            penfataran.Show();

            this.Hide();
        }

        private void Peraturan_Click_1(object sender, EventArgs e)
        {
            Peraturan peraturan = new Peraturan();
            peraturan.Show();

            this.Hide();
        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void Kendaraan_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from dbparkiran");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "NAME";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "NIM";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "FAKULTAS";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[0].HeaderText = "JURUSAN";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "KENDARAAN";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[0].HeaderText = "PARKIRAN";
                dataGridView1.Columns[0].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
