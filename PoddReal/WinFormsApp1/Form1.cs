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

            string url = txtRssInput.Text;
            string titel = poddHanterare.HamtaTitel(url); // string titel = ??????????? hur får man fram titel på podcast
            string namn = txtNamn.Text;  
            string kategori = cbKategori.SelectedItem.ToString(); // Kategori kategori = (Kategori)cbKategori.SelectedItem; Funkar ej än
            poddHanterare.SkapaPodd(url, titel, namn, kategori); //Titel ska läggas till som parameter

            UppdateraDataGridView();
            //txtTest.Text = poddHanterare.GetRss(txtRssInput.Text);
        }

        private void dgvPoddar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UppdateraDataGridView()
        {
            dgvPoddar.Rows.Clear();

            foreach (Podd enPodd in poddHanterare.HamtaPoddar())
            {
                dgvPoddar.Rows.Add(enPodd.Namn, enPodd.Titel, enPodd.Kategori); // enPodd.Url ska bli titel sen
            }
        }
    }
}
