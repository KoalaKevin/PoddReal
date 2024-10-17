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
            txtNamn = new TextBox();
            SuspendLayout();
            // 
            // btnLaggTillPodd
            // 
            btnLaggTillPodd.Location = new Point(241, 34);
            btnLaggTillPodd.Name = "btnLaggTillPodd";
            btnLaggTillPodd.Size = new Size(75, 23);
            btnLaggTillPodd.TabIndex = 0;
            btnLaggTillPodd.Text = "Lägg till";
            btnLaggTillPodd.UseVisualStyleBackColor = true;
            btnLaggTillPodd.Click += button1_Click;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(19, 5);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(100, 23);
            txtTest.TabIndex = 1;
            txtTest.Text = "Innehåller kod";
            // 
            // txtRssInput
            // 
            txtRssInput.Location = new Point(241, 60);
            txtRssInput.Margin = new Padding(2, 2, 2, 2);
            txtRssInput.Name = "txtRssInput";
            txtRssInput.Size = new Size(240, 23);
            txtRssInput.TabIndex = 2;
            txtRssInput.Text = "https://api.sr.se/api/rss/pod/itunes/3966";
            // 
            // lbPoddar
            // 
            lbPoddar.FormattingEnabled = true;
            lbPoddar.ItemHeight = 15;
            lbPoddar.Location = new Point(19, 89);
            lbPoddar.Margin = new Padding(2, 1, 2, 1);
            lbPoddar.Name = "lbPoddar";
            lbPoddar.Size = new Size(235, 274);
            lbPoddar.TabIndex = 3;
            lbPoddar.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lbKategorier
            // 
            lbKategorier.FormattingEnabled = true;
            lbKategorier.ItemHeight = 15;
            lbKategorier.Location = new Point(513, 76);
            lbKategorier.Margin = new Padding(2, 1, 2, 1);
            lbKategorier.Name = "lbKategorier";
            lbKategorier.Size = new Size(263, 79);
            lbKategorier.TabIndex = 4;
            // 
            // btnAllaPoddar
            // 
            btnAllaPoddar.Location = new Point(19, 58);
            btnAllaPoddar.Margin = new Padding(2, 2, 2, 2);
            btnAllaPoddar.Name = "btnAllaPoddar";
            btnAllaPoddar.Size = new Size(79, 21);
            btnAllaPoddar.TabIndex = 5;
            btnAllaPoddar.Text = "Alla poddar";
            btnAllaPoddar.UseVisualStyleBackColor = true;
            btnAllaPoddar.Click += btnAllaPoddar_Click;
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.Location = new Point(323, 35);
            btnTaBortPodd.Margin = new Padding(2, 1, 2, 1);
            btnTaBortPodd.Name = "btnTaBortPodd";
            btnTaBortPodd.Size = new Size(68, 21);
            btnTaBortPodd.TabIndex = 6;
            btnTaBortPodd.Text = "Ta bort";
            btnTaBortPodd.UseVisualStyleBackColor = true;
            btnTaBortPodd.Click += btnTaBort_Click;
            // 
            // btnRedigeraPodd
            // 
            btnRedigeraPodd.Location = new Point(400, 35);
            btnRedigeraPodd.Margin = new Padding(2, 1, 2, 1);
            btnRedigeraPodd.Name = "btnRedigeraPodd";
            btnRedigeraPodd.Size = new Size(81, 22);
            btnRedigeraPodd.TabIndex = 7;
            btnRedigeraPodd.Text = "Redigera";
            btnRedigeraPodd.UseVisualStyleBackColor = true;
            btnRedigeraPodd.Click += button1_Click_1;
            // 
            // lbAvsnitt
            // 
            lbAvsnitt.FormattingEnabled = true;
            lbAvsnitt.ItemHeight = 15;
            lbAvsnitt.Location = new Point(272, 89);
            lbAvsnitt.Margin = new Padding(2, 1, 2, 1);
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Size = new Size(209, 274);
            lbAvsnitt.TabIndex = 8;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(513, 166);
            rtbBeskrivning.Margin = new Padding(2, 1, 2, 1);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(168, 126);
            rtbBeskrivning.TabIndex = 9;
            rtbBeskrivning.Text = "Beskrivning";
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(513, 47);
            btnLaggTillKategori.Margin = new Padding(2, 1, 2, 1);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(81, 22);
            btnLaggTillKategori.TabIndex = 10;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(602, 47);
            btnTaBortKategori.Margin = new Padding(2, 1, 2, 1);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(81, 22);
            btnTaBortKategori.TabIndex = 11;
            btnTaBortKategori.Text = "Ta bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // btnRedigeraKategori
            // 
            btnRedigeraKategori.Location = new Point(693, 48);
            btnRedigeraKategori.Margin = new Padding(2, 1, 2, 1);
            btnRedigeraKategori.Name = "btnRedigeraKategori";
            btnRedigeraKategori.Size = new Size(81, 22);
            btnRedigeraKategori.TabIndex = 12;
            btnRedigeraKategori.Text = "Redigera";
            btnRedigeraKategori.UseVisualStyleBackColor = true;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(102, 60);
            cbKategori.Margin = new Padding(2, 1, 2, 1);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(132, 23);
            cbKategori.TabIndex = 13;
            cbKategori.Text = "Kategori";
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(83, 33);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(152, 23);
            txtNamn.TabIndex = 14;
            txtNamn.Text = "Namn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 384);
            Controls.Add(txtNamn);
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
        private TextBox txtNamn;
    }
}
