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
                MessageBox.Show("Vänligen välj en kategori", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtRssInput.Text = poddHanterare.HamtaMedTitel((string)rad.Cells["Column2"].Value).Url;
                cbKategori.Text = poddHanterare.HamtaMedUrl(txtRssInput.Text).Kategori;

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
            string namn = txtKategoriNamn.Text;

            if (Validering.StrangHarVarde(namn))
            {
                Debug.WriteLine(namn);
                kategoriHanterare.SkapaKategori(namn);
                UppdateraKategoriListBox();
                FyllCbKategori();
            }
            else
            {
                MessageBox.Show("Vänligen ange ett kategori namn", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRedigeraKategori_Click(object sender, EventArgs e)
        {
            try
            {
                object gammaltNamn = lbKategorier.SelectedItem;
                string nyttNamn = txtKategoriNamn.Text;


                if (!Validering.ArStrang(gammaltNamn))
                {
                    MessageBox.Show("Välj en kategori att redigera.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Validering.HarVarde(nyttNamn))
                {
                    MessageBox.Show("Det nya namnet kan inte vara tomt", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                kategoriHanterare.UppdateraKategoriNamn(gammaltNamn.ToString(), nyttNamn);

                UppdateraKategoriListBox();
                FyllCbKategori();
                txtKategoriNamn.Clear();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                cbKategori2.Items.Add(kategori.Namn);
            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            object valdKategori = lbKategorier.SelectedItem;

            if (!Validering.ArStrang(valdKategori))
            {
                MessageBox.Show("Välj en kategori att radera", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bekräftelse = MessageBox.Show($"Är du säker på att du vill radera kategorin '{lbKategorier.SelectedItem}'?",
                                              "Bekräfta",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (bekräftelse == DialogResult.Yes) 
            {
                try
                {
                    kategoriHanterare.RaderaKategori(valdKategori.ToString());
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


        private void btnAterstall_Click(object sender, EventArgs e)
        {
            RensaFalt();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbKategori2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string kategori = cbKategori2.SelectedItem.ToString();
               
                if (kategori.Equals("Alla"))
                {
                    UppdateraDataGridView();
                }
                else
                {

                
                dgvPoddar.Rows.Clear();
                foreach (Podd enPodd in poddHanterare.GetPoddByKategori(kategori))
                {
                    dgvPoddar.Rows.Add(enPodd.Namn, enPodd.Titel, enPodd.Kategori);
                }
                }

            }
            catch (Exception ex) { }
            
        }
    }

}

