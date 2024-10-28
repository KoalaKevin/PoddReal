using BL;
using Models;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;

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
            FyllCbKategori();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            poddHanterare.RaderaPodd(txtRssInput.Text);
            UppdateraDataGridView();
            RensaFalt();
        }

        private void btnRedigeraPodd_Click(object sender, EventArgs e)
        {
            string url = txtRssInput.Text;
            string titel = poddHanterare.HamtaTitel(url);
            string namn = txtNamn.Text;
            string kategori = cbKategori.SelectedItem.ToString();
            int index = poddHanterare.HamtaIndexMedUrl(url);

            Podd redigeradPodd = new Podd(url, titel, namn, kategori); // samma kod som i LaggTillPodd, lösa det bättre?
            poddHanterare.RedigeraPodd(index, redigeradPodd);
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
                txtRssInput.Text = poddHanterare.HamtaPodd((string)rad.Cells["Column2"].Value).Url; // H mta URL p  ett annat s tt?

                lbAvsnitt.DataSource = poddHanterare.AllaAvsnitt(txtRssInput.Text);
                lbAvsnitt.DisplayMember = "Namn";
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
                lbKategorier.Items.Add(enKategori.Namn);
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
            FyllCbKategori();

        }

        private void btnRedigeraKategori_Click(object sender, EventArgs e)
        {
            try
            {

                if (lbKategorier.SelectedItem is not string gammaltNamn)
                {
                    MessageBox.Show("Välj en kategori att redigera.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nyttNamn = txtKategoriNamn.Text;

                if (string.IsNullOrWhiteSpace(nyttNamn))
                {
                    MessageBox.Show("Det nya namnet kan inte vara tomt", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                kategoriHanterare.UppdateraKategoriNamn(gammaltNamn, nyttNamn);

                UppdateraKategoriListBox();
                FyllCbKategori();

                txtKategoriNamn.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ett fel har uppstått");
            }
        }

        private void UppdateraKategoriListbox()
        {
            lbKategorier.Items.Clear();

            List<Kategori> kategorier = kategoriHanterare.HamtaKategorier();

            foreach (Kategori enKategori in kategorier)
            {
                lbKategorier.Items.Add(enKategori.Namn);
            }

            lbKategorier.DisplayMember = "Name";
        }

        private void FyllCbKategori()
        {
            cbKategori.Items.Clear();
            foreach (Kategori kategori in kategoriHanterare.HamtaKategorier())
            {
                cbKategori.Items.Add(kategori.Namn);
            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (lbKategorier.SelectedItem is not string kategoriNamn)
            {
                MessageBox.Show("Välj en kategori att radera", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bekräftelse = MessageBox.Show($"Är du säker på att du vill radera kategorin '{kategoriNamn}'?",
                                              "Bekräfta",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (bekräftelse == DialogResult.Yes) 
            {
                try
                {
                    kategoriHanterare.RaderaKategori(kategoriNamn);
                    UppdateraKategoriListBox();
                    FyllCbKategori();
                }
                catch 
                {
                    MessageBox.Show("Ett fel uppstod vid radering");
                }
            }


        }

        private void lbAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Avsnitt valtAvsnitt = (Avsnitt)lbAvsnitt.SelectedItem;
            rtbBeskrivning.Text = valtAvsnitt.Beskrivning;
        }
    }

}

