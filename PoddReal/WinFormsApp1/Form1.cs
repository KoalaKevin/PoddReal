using BL;
using Models;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PoddHanterare poddHanterare;
        private KategoriHanterare kategoriHanterare;

        public Form1()
        {
            InitializeComponent();
            poddHanterare = new PoddHanterare();
            kategoriHanterare = new KategoriHanterare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UppdateraDataGridView();
            UppdateraKategoriListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAllaPoddar_Click(object sender, EventArgs e)
        {
            lbPoddar.DataSource = poddHanterare.getAllPodd();
            lbPoddar.DisplayMember = "Name";
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraPodd_Click(object sender, EventArgs e)
        {

        }

        private void btnLaggTillPodd_Click(object sender, EventArgs e)
        {

            string url = txtRssInput.Text;
<<<<<<< Updated upstream
            string titel = poddHanterare.HamtaTitel(url);
=======
            string titel = poddHanterare.HamtaTitel(url); // string titel = ??????????? hur får man fram titel på podcast
>>>>>>> Stashed changes
            string namn = txtNamn.Text;
            string kategori = cbKategori.SelectedItem.ToString(); // Kategori kategori = (Kategori)cbKategori.SelectedItem; Funkar ej än
            poddHanterare.SkapaPodd(url, titel, namn, kategori);

            UppdateraDataGridView();
            //txtTest.Text = poddHanterare.GetRss(txtRssInput.Text);
        }

        private void DgvPoddar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rad = dgvPoddar.Rows[e.RowIndex];
                txtNamn.Text = (string)rad.Cells["Column1"].Value;
                cbKategori.Text = (string)rad.Cells["Column3"].Value;
                txtRssInput.Text = poddHanterare.HamtaPodd((string)rad.Cells["Column2"].Value).Url; // Hämta URL på ett annat sätt?
            }
        }

        private void UppdateraDataGridView()
        {
            dgvPoddar.Rows.Clear();

            foreach (Podd enPodd in poddHanterare.HamtaPoddar())
            {
                dgvPoddar.Rows.Add(enPodd.Namn, enPodd.Titel, enPodd.Kategori);
            }
        }

<<<<<<< Updated upstream
        private void txtTest_TextChanged(object sender, EventArgs e)
        {
=======
        private void UppdateraKategoriListBox()
        {
            lbKategorier.Items.Clear();

            //List<Kategori> kategorier = kategoriHanterare.HamtaKategorier();
            foreach (Kategori enKategori in kategoriHanterare.HamtaKategorier())
            {
                lbKategorier.Items.Add(enKategori.Name);
            }
        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e) 
        {
            string name = txtKategoriNamn.Text;
            kategoriHanterare.SkapaKategori(name);

            UppdateraKategoriListBox();
>>>>>>> Stashed changes

        }
    }
}

