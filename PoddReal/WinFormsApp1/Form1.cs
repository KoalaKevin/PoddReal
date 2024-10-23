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
        private int poddIndex = -1;

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

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            bool godkandUrl = poddHanterare.RaderaPodd(txtRssInput.Text);

            if (!godkandUrl)
            {
                MessageBox.Show("Vänligen tryck på den podcast du vill ta bort och ändra inte rss länken!");
            }

            UppdateraDataGridView();
            RensaFalt();
        }

        private void btnRedigeraPodd_Click(object sender, EventArgs e)
        {
            string url = txtRssInput.Text;
            string titel = poddHanterare.HamtaTitel(url);
            string namn = txtNamn.Text;
            string kategori = cbKategori.SelectedItem.ToString();
            Podd redigeradPodd = new Podd(url, titel, namn, kategori); // samma kod som i LaggTillPodd, lösa det bättre?
            poddHanterare.RedigeraPodd(poddIndex, redigeradPodd);
            UppdateraDataGridView();
            RensaFalt();
        }

        private void btnLaggTillPodd_Click(object sender, EventArgs e)
        {

            string url = txtRssInput.Text;
            string titel = poddHanterare.HamtaTitel(url);
            string namn = txtNamn.Text;
            string kategori = cbKategori.SelectedItem.ToString(); // Kategori kategori = (Kategori)cbKategori.SelectedItem; Funkar ej än
            poddHanterare.SkapaPodd(url, titel, namn, kategori);

            UppdateraDataGridView();
            RensaFalt();
        }

        private void DgvPoddar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rad = dgvPoddar.Rows[e.RowIndex];
                txtNamn.Text = (string)rad.Cells["Column1"].Value;
                cbKategori.Text = (string)rad.Cells["Column3"].Value;
                txtRssInput.Text = poddHanterare.HamtaPodd((string)rad.Cells["Column2"].Value).Url; // Hämta URL på ett annat sätt?
                poddIndex = e.RowIndex;
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

        private void UppdateraKategoriListBox()
        {
            lbKategorier.Items.Clear();

            //List<Kategori> kategorier = kategoriHanterare.HamtaKategorier();
            foreach (Kategori enKategori in kategoriHanterare.HamtaKategorier())
            {
                lbKategorier.Items.Add(enKategori.Name);
            }

        }

        private void RensaFalt()
        {
            txtNamn.Clear();
            txtRssInput.Clear();
            cbKategori.SelectedIndex = -1;
            cbKategori.Text = "Kategori";
        }

        private void btnLaggTillKategori_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine("test");
            string name = txtKategoriNamn.Text;
            Debug.WriteLine(name);
            kategoriHanterare.SkapaKategori(name);

            UppdateraKategoriListBox();
        }  
    }
}

