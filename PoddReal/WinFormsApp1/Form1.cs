using BL;
using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtTest.Text = poddHanterare.GetRss(txtRssInput.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
