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
            btnLaggTillPodd = new Button();
            dgvPoddar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPoddar).BeginInit();
            SuspendLayout();
            // 
            // txtTest
            // 
            txtTest.Location = new Point(19, 5);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(100, 23);
            txtTest.TabIndex = 1;
            txtTest.Text = "Innehåller kod";
            txtTest.TextChanged += txtTest_TextChanged;
            // 
            // txtRssInput
            // 
            txtRssInput.Location = new Point(241, 60);
            txtRssInput.Margin = new Padding(2);
            txtRssInput.Name = "txtRssInput";
            txtRssInput.PlaceholderText = "Ange rss-url";
            txtRssInput.Size = new Size(240, 23);
            txtRssInput.TabIndex = 2;
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
            btnAllaPoddar.Margin = new Padding(2);
            btnAllaPoddar.Name = "btnAllaPoddar";
            btnAllaPoddar.Size = new Size(79, 21);
            btnAllaPoddar.TabIndex = 5;
            btnAllaPoddar.Text = "Alla poddar";
            btnAllaPoddar.UseVisualStyleBackColor = true;
            btnAllaPoddar.Click += btnAllaPoddar_Click;
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.Location = new Point(324, 30);
            btnTaBortPodd.Margin = new Padding(2, 1, 2, 1);
            btnTaBortPodd.Name = "btnTaBortPodd";
            btnTaBortPodd.Size = new Size(68, 26);
            btnTaBortPodd.TabIndex = 6;
            btnTaBortPodd.Text = "Ta bort";
            btnTaBortPodd.UseVisualStyleBackColor = true;
            btnTaBortPodd.Click += btnTaBort_Click;
            // 
            // btnRedigeraPodd
            // 
            btnRedigeraPodd.Location = new Point(400, 30);
            btnRedigeraPodd.Margin = new Padding(2, 1, 2, 1);
            btnRedigeraPodd.Name = "btnRedigeraPodd";
            btnRedigeraPodd.Size = new Size(81, 26);
            btnRedigeraPodd.TabIndex = 7;
            btnRedigeraPodd.Text = "Redigera";
            btnRedigeraPodd.UseVisualStyleBackColor = true;
            btnRedigeraPodd.Click += btnRedigeraPodd_Click;
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
            cbKategori.Items.AddRange(new object[] { "Historia", "Humor" });
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
            txtNamn.PlaceholderText = "Namn";
            txtNamn.Size = new Size(152, 23);
            txtNamn.TabIndex = 14;
            // 
            // btnLaggTillPodd
            // 
            btnLaggTillPodd.Location = new Point(251, 30);
            btnLaggTillPodd.Name = "btnLaggTillPodd";
            btnLaggTillPodd.Size = new Size(68, 26);
            btnLaggTillPodd.TabIndex = 15;
            btnLaggTillPodd.Text = "Lägg till";
            btnLaggTillPodd.UseVisualStyleBackColor = true;
            btnLaggTillPodd.Click += btnLaggTillPodd_Click;
            // 
            // dgvPoddar
            // 
            dgvPoddar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoddar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvPoddar.Location = new Point(535, 296);
            dgvPoddar.Name = "dgvPoddar";
            dgvPoddar.RowHeadersVisible = false;
            dgvPoddar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoddar.Size = new Size(305, 96);
            dgvPoddar.TabIndex = 16;
            dgvPoddar.CellClick += DgvPoddar_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Namn";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Titel";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.Name = "Column3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 449);
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
            Controls.Add(txtTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoddar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnLaggTillPodd;
        private DataGridView dgvPoddar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
