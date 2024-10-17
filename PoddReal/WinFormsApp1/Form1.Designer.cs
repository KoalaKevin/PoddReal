namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLaggTillPodd = new Button();
            txtTest = new TextBox();
            txtRssInput = new TextBox();
            lbPoddar = new ListBox();
            lbKategorier = new ListBox();
            btnAllaPoddar = new Button();
            btnTaBortPodd = new Button();
            btnRedigeraPodd = new Button();
            lbAvsnitt = new ListBox();
            rtbBeskrivning = new RichTextBox();
            btnLaggTillKategori = new Button();
            btnTaBortKategori = new Button();
            btnRedigeraKategori = new Button();
            cbKategori = new ComboBox();
            SuspendLayout();
            // 
            // btnLaggTillPodd
            // 
            btnLaggTillPodd.Location = new Point(448, 73);
            btnLaggTillPodd.Margin = new Padding(5, 6, 5, 6);
            btnLaggTillPodd.Name = "btnLaggTillPodd";
            btnLaggTillPodd.Size = new Size(139, 49);
            btnLaggTillPodd.TabIndex = 0;
            btnLaggTillPodd.Text = "Lägg till";
            btnLaggTillPodd.UseVisualStyleBackColor = true;
            btnLaggTillPodd.Click += button1_Click;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(36, 29);
            txtTest.Margin = new Padding(5, 6, 5, 6);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(182, 39);
            txtTest.TabIndex = 1;
            txtTest.Text = "Innehåller kod";
            // 
            // txtRssInput
            // 
            txtRssInput.Location = new Point(448, 127);
            txtRssInput.Margin = new Padding(4, 4, 4, 4);
            txtRssInput.Name = "txtRssInput";
            txtRssInput.Size = new Size(442, 39);
            txtRssInput.TabIndex = 2;
            txtRssInput.Text = "https://api.sr.se/api/rss/pod/itunes/3966";
            // 
            // lbPoddar
            // 
            lbPoddar.FormattingEnabled = true;
            lbPoddar.Location = new Point(36, 189);
            lbPoddar.Name = "lbPoddar";
            lbPoddar.Size = new Size(433, 580);
            lbPoddar.TabIndex = 3;
            lbPoddar.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lbKategorier
            // 
            lbKategorier.FormattingEnabled = true;
            lbKategorier.Location = new Point(952, 162);
            lbKategorier.Name = "lbKategorier";
            lbKategorier.Size = new Size(485, 164);
            lbKategorier.TabIndex = 4;
            // 
            // btnAllaPoddar
            // 
            btnAllaPoddar.Location = new Point(36, 124);
            btnAllaPoddar.Margin = new Padding(4, 4, 4, 4);
            btnAllaPoddar.Name = "btnAllaPoddar";
            btnAllaPoddar.Size = new Size(146, 44);
            btnAllaPoddar.TabIndex = 5;
            btnAllaPoddar.Text = "Alla poddar";
            btnAllaPoddar.UseVisualStyleBackColor = true;
            btnAllaPoddar.Click += btnAllaPoddar_Click;
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.Location = new Point(600, 75);
            btnTaBortPodd.Name = "btnTaBortPodd";
            btnTaBortPodd.Size = new Size(127, 44);
            btnTaBortPodd.TabIndex = 6;
            btnTaBortPodd.Text = "Ta bort";
            btnTaBortPodd.UseVisualStyleBackColor = true;
            btnTaBortPodd.Click += btnTaBort_Click;
            // 
            // btnRedigeraPodd
            // 
            btnRedigeraPodd.Location = new Point(743, 74);
            btnRedigeraPodd.Name = "btnRedigeraPodd";
            btnRedigeraPodd.Size = new Size(150, 46);
            btnRedigeraPodd.TabIndex = 7;
            btnRedigeraPodd.Text = "Redigera";
            btnRedigeraPodd.UseVisualStyleBackColor = true;
            btnRedigeraPodd.Click += button1_Click_1;
            // 
            // lbAvsnitt
            // 
            lbAvsnitt.FormattingEnabled = true;
            lbAvsnitt.Location = new Point(506, 189);
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Size = new Size(384, 580);
            lbAvsnitt.TabIndex = 8;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(952, 354);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(308, 264);
            rtbBeskrivning.TabIndex = 9;
            rtbBeskrivning.Text = "Beskrivning";
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(952, 101);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(150, 46);
            btnLaggTillKategori.TabIndex = 10;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(1118, 101);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(150, 46);
            btnTaBortKategori.TabIndex = 11;
            btnTaBortKategori.Text = "Ta bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // btnRedigeraKategori
            // 
            btnRedigeraKategori.Location = new Point(1287, 102);
            btnRedigeraKategori.Name = "btnRedigeraKategori";
            btnRedigeraKategori.Size = new Size(150, 46);
            btnRedigeraKategori.TabIndex = 12;
            btnRedigeraKategori.Text = "Redigera";
            btnRedigeraKategori.UseVisualStyleBackColor = true;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(189, 128);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(242, 40);
            cbKategori.TabIndex = 13;
            cbKategori.Text = "Kategori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 819);
            Controls.Add(cbKategori);
            Controls.Add(btnRedigeraKategori);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(rtbBeskrivning);
            Controls.Add(lbAvsnitt);
            Controls.Add(btnRedigeraPodd);
            Controls.Add(btnTaBortPodd);
            Controls.Add(btnAllaPoddar);
            Controls.Add(lbKategorier);
            Controls.Add(lbPoddar);
            Controls.Add(txtRssInput);
            Controls.Add(txtTest);
            Controls.Add(btnLaggTillPodd);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLaggTillPodd;
        private TextBox txtTest;
        private TextBox txtRssInput;
        private ListBox lbPoddar;
        private ListBox lbKategorier;
        private Button btnAllaPoddar;
        private Button btnTaBortPodd;
        private Button btnRedigeraPodd;
        private ListBox lbAvsnitt;
        private RichTextBox rtbBeskrivning;
        private Button btnLaggTillKategori;
        private Button btnTaBortKategori;
        private Button btnRedigeraKategori;
        private ComboBox cbKategori;
    }
}
