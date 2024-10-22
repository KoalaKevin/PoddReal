
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
            btnLaggTillPodd = new Button();
            dgvPoddar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtKategoriNamn = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPoddar).BeginInit();
            SuspendLayout();
            // 
            // txtRssInput
            // 
            txtRssInput.Location = new Point(447, 128);
            txtRssInput.Margin = new Padding(4, 4, 4, 4);
            txtRssInput.Name = "txtRssInput";
            txtRssInput.PlaceholderText = "Ange rss-url";
            txtRssInput.Size = new Size(442, 39);
            txtRssInput.TabIndex = 2;
            // 
            // lbPoddar
            // 
            lbPoddar.FormattingEnabled = true;
            lbPoddar.Location = new Point(35, 189);
            lbPoddar.Margin = new Padding(4, 3, 4, 3);
            lbPoddar.Name = "lbPoddar";
            lbPoddar.Size = new Size(433, 580);
            lbPoddar.TabIndex = 3;
            lbPoddar.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lbKategorier
            // 
            lbKategorier.FormattingEnabled = true;
            lbKategorier.Location = new Point(953, 163);
            lbKategorier.Margin = new Padding(4, 3, 4, 3);
            lbKategorier.Name = "lbKategorier";
            lbKategorier.Size = new Size(485, 164);
            lbKategorier.TabIndex = 4;
            // 
            // btnAllaPoddar
            // 
            btnAllaPoddar.Location = new Point(35, 124);
            btnAllaPoddar.Margin = new Padding(4, 4, 4, 4);
            btnAllaPoddar.Name = "btnAllaPoddar";
            btnAllaPoddar.Size = new Size(147, 45);
            btnAllaPoddar.TabIndex = 5;
            btnAllaPoddar.Text = "Alla poddar";
            btnAllaPoddar.UseVisualStyleBackColor = true;
            btnAllaPoddar.Click += btnAllaPoddar_Click;
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.Location = new Point(602, 64);
            btnTaBortPodd.Margin = new Padding(4, 3, 4, 3);
            btnTaBortPodd.Name = "btnTaBortPodd";
            btnTaBortPodd.Size = new Size(126, 55);
            btnTaBortPodd.TabIndex = 6;
            btnTaBortPodd.Text = "Ta bort";
            btnTaBortPodd.UseVisualStyleBackColor = true;
            btnTaBortPodd.Click += btnTaBort_Click;
            // 
            // btnRedigeraPodd
            // 
            btnRedigeraPodd.Location = new Point(742, 64);
            btnRedigeraPodd.Margin = new Padding(4, 3, 4, 3);
            btnRedigeraPodd.Name = "btnRedigeraPodd";
            btnRedigeraPodd.Size = new Size(151, 55);
            btnRedigeraPodd.TabIndex = 7;
            btnRedigeraPodd.Text = "Redigera";
            btnRedigeraPodd.UseVisualStyleBackColor = true;
            btnRedigeraPodd.Click += btnRedigeraPodd_Click;
            // 
            // lbAvsnitt
            // 
            lbAvsnitt.FormattingEnabled = true;
            lbAvsnitt.Location = new Point(506, 189);
            lbAvsnitt.Margin = new Padding(4, 3, 4, 3);
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Size = new Size(385, 580);
            lbAvsnitt.TabIndex = 8;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(953, 355);
            rtbBeskrivning.Margin = new Padding(4, 3, 4, 3);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(308, 264);
            rtbBeskrivning.TabIndex = 9;
            rtbBeskrivning.Text = "Beskrivning";
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(953, 100);
            btnLaggTillKategori.Margin = new Padding(4, 3, 4, 3);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(151, 47);
            btnLaggTillKategori.TabIndex = 10;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click_1;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(1118, 100);
            btnTaBortKategori.Margin = new Padding(4, 3, 4, 3);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(151, 47);
            btnTaBortKategori.TabIndex = 11;
            btnTaBortKategori.Text = "Ta bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // btnRedigeraKategori
            // 
            btnRedigeraKategori.Location = new Point(1287, 102);
            btnRedigeraKategori.Margin = new Padding(4, 3, 4, 3);
            btnRedigeraKategori.Name = "btnRedigeraKategori";
            btnRedigeraKategori.Size = new Size(151, 47);
            btnRedigeraKategori.TabIndex = 12;
            btnRedigeraKategori.Text = "Redigera";
            btnRedigeraKategori.UseVisualStyleBackColor = true;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Items.AddRange(new object[] { "Historia", "Humor" });
            cbKategori.Location = new Point(190, 128);
            cbKategori.Margin = new Padding(4, 3, 4, 3);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(242, 40);
            cbKategori.TabIndex = 13;
            cbKategori.Text = "Kategori";
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(155, 70);
            txtNamn.Margin = new Padding(5, 6, 5, 6);
            txtNamn.Name = "txtNamn";
            txtNamn.PlaceholderText = "Namn";
            txtNamn.Size = new Size(278, 39);
            txtNamn.TabIndex = 14;
            // 
            // btnLaggTillPodd
            // 
            btnLaggTillPodd.Location = new Point(467, 64);
            btnLaggTillPodd.Margin = new Padding(5, 6, 5, 6);
            btnLaggTillPodd.Name = "btnLaggTillPodd";
            btnLaggTillPodd.Size = new Size(126, 55);
            btnLaggTillPodd.TabIndex = 15;
            btnLaggTillPodd.Text = "Lägg till";
            btnLaggTillPodd.UseVisualStyleBackColor = true;
            btnLaggTillPodd.Click += btnLaggTillPodd_Click;
            // 
            // dgvPoddar
            // 
            dgvPoddar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoddar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvPoddar.Location = new Point(993, 631);
            dgvPoddar.Margin = new Padding(5, 6, 5, 6);
            dgvPoddar.Name = "dgvPoddar";
            dgvPoddar.RowHeadersVisible = false;
            dgvPoddar.RowHeadersWidth = 62;
            dgvPoddar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoddar.Size = new Size(567, 205);
            dgvPoddar.TabIndex = 16;
            dgvPoddar.CellClick += DgvPoddar_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Namn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Titel";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // txtKategoriNamn
            // 
            txtKategoriNamn.Location = new Point(953, 26);
            txtKategoriNamn.Margin = new Padding(5, 6, 5, 6);
            txtKategoriNamn.Name = "txtKategoriNamn";
            txtKategoriNamn.Size = new Size(182, 39);
            txtKategoriNamn.TabIndex = 17;
            txtKategoriNamn.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1738, 957);
            Controls.Add(txtKategoriNamn);
            Controls.Add(dgvPoddar);
            Controls.Add(btnLaggTillPodd);
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
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoddar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

#endregion
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
        private Button btnLaggTillPodd;
        private DataGridView dgvPoddar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtKategoriNamn;
    }
}
