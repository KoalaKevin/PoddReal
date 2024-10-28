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
            try
            {
                poddHanterare.RaderaPodd(txtRssInput.Text);
                UppdateraDataGridView();
                RensaFalt();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnRedigeraPodd_Click(object sender, EventArgs e)
        {
            string url = txtRssInput.Text;
            string titel = poddHanterare.HamtaTitel(url);
            string namn = txtNamn.Text;
            int index = poddHanterare.HamtaIndexMedUrl(url);

            if (Validering.HarVarde(cbKategori.SelectedItem))
            {
                try
                {
                    string kategori = cbKategori.SelectedItem.ToString();
                    Podd redigeradPodd = new Podd(url, titel, namn, kategori);
                    poddHanterare.RedigeraPodd(index, redigeradPodd, url);
                    UppdateraDataGridView();
                    RensaFalt();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Vänligen välj en kategori", "Fel");
            }
            
        }

        private void btnLaggTillPodd_Click(object sender, EventArgs e)
        {

            string url = txtRssInput.Text;
            string titel = poddHanterare.HamtaTitel(url);
            string namn = txtNamn.Text;
            
            if (Validering.StrangHarVarde(url))
            {
               
                if (Validering.HarVarde(cbKategori.SelectedItem))
                {
                    string kategori = cbKategori.SelectedItem.ToString();

                    try
                    {
                        poddHanterare.SkapaPodd(url, titel, namn, kategori);
                        UppdateraDataGridView();
                        RensaFalt();
                    }
                    catch (ArgumentException ex) 
                    { 
                        MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vänligen välj en kategori", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }    
            }
            else
            {
                MessageBox.Show("Vänligen fyll i en Rss-länk", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
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

        }

        private void lbAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Avsnitt valtAvsnitt = (Avsnitt)lbAvsnitt.SelectedItem;
            rtbBeskrivning.Text = valtAvsnitt.Beskrivning;
        }

        private void btnAterstall_Click(object sender, EventArgs e)
        {
            RensaFalt();
        }
    }

}

