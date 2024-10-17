using BL;
using Models;
using System;
using System.Data;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PoddHanterare poddHanterare;

        public Form1()
        {
            InitializeComponent();
            poddHanterare = new PoddHanterare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UppdateraDataGridView();
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

            string namn = txtNamn.Text;
            string url = txtRssInput.Text;
            string kategori = cbKategori.SelectedText; // Kategori kategori = (Kategori)cbKategori.SelectedItem; Funkar ej än
            Podd nyPodd = new Podd(url, namn, kategori);
            poddHanterare.LaggTillPodd(nyPodd);

            UppdateraDataGridView();
            //txtTest.Text = poddHanterare.GetRss(txtRssInput.Text);
        }

        private void dgvPoddar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UppdateraDataGridView()
        {
            dgvPoddar.Rows.Clear();

            foreach (Podd enPodd in poddHanterare.getAllPodd())
            {
                dgvPoddar.Rows.Add(enPodd.Name, enPodd.Url, enPodd.Kategori); // enPodd.Url ska bli titel sen
            }
        }
    }
}
