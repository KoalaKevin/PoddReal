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
            Debug.WriteLine("hej");
            txtTest.Text = poddHanterare.GetRss("https://feed.pod.space/alexosigge");
        }
    }
}
