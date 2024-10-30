
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
            lbKategorier = new ListBox();
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
            btnAterstall = new Button();
            cbKategori2 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPoddar).BeginInit();
            SuspendLayout();
            // 
            // txtRssInput
            // 
            txtRssInput.Location = new Point(344, 100);
            txtRssInput.Name = "txtRssInput";
            txtRssInput.PlaceholderText = "Ange RSS-länk";
            txtRssInput.Size = new Size(341, 31);
            txtRssInput.TabIndex = 2;
            // 
            // lbKategorier
            // 
            lbKategorier.FormattingEnabled = true;
            lbKategorier.ItemHeight = 25;
            lbKategorier.Location = new Point(964, 147);
            lbKategorier.Margin = new Padding(3, 2, 3, 2);
            lbKategorier.Name = "lbKategorier";
            lbKategorier.Size = new Size(374, 129);
            lbKategorier.TabIndex = 4;
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.Location = new Point(463, 50);
            btnTaBortPodd.Margin = new Padding(3, 2, 3, 2);
            btnTaBortPodd.Name = "btnTaBortPodd";
            btnTaBortPodd.Size = new Size(97, 43);
            btnTaBortPodd.TabIndex = 6;
            btnTaBortPodd.Text = "Ta bort";
            btnTaBortPodd.UseVisualStyleBackColor = true;
            btnTaBortPodd.Click += btnTaBort_Click;
            // 
            // btnRedigeraPodd
            // 
            btnRedigeraPodd.Location = new Point(571, 50);
            btnRedigeraPodd.Margin = new Padding(3, 2, 3, 2);
            btnRedigeraPodd.Name = "btnRedigeraPodd";
            btnRedigeraPodd.Size = new Size(116, 43);
            btnRedigeraPodd.TabIndex = 7;
            btnRedigeraPodd.Text = "Redigera";
            btnRedigeraPodd.UseVisualStyleBackColor = true;
            btnRedigeraPodd.Click += btnRedigeraPodd_Click;
            // 
            // lbAvsnitt
            // 
            lbAvsnitt.FormattingEnabled = true;
            lbAvsnitt.ItemHeight = 25;
            lbAvsnitt.Location = new Point(660, 147);
            lbAvsnitt.Margin = new Padding(3, 2, 3, 2);
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Size = new Size(297, 404);
            lbAvsnitt.TabIndex = 8;
            lbAvsnitt.SelectedIndexChanged += lbAvsnitt_SelectedIndexChanged;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(660, 572);
            rtbBeskrivning.Margin = new Padding(3, 2, 3, 2);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(297, 241);
            rtbBeskrivning.TabIndex = 9;
            rtbBeskrivning.Text = "Beskrivning";
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(967, 100);
            btnLaggTillKategori.Margin = new Padding(3, 2, 3, 2);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(116, 37);
            btnLaggTillKategori.TabIndex = 10;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click_1;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(1094, 100);
            btnTaBortKategori.Margin = new Padding(3, 2, 3, 2);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(116, 37);
            btnTaBortKategori.TabIndex = 11;
            btnTaBortKategori.Text = "Ta bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnRedigeraKategori
            // 
            btnRedigeraKategori.Location = new Point(1224, 102);
            btnRedigeraKategori.Margin = new Padding(3, 2, 3, 2);
            btnRedigeraKategori.Name = "btnRedigeraKategori";
            btnRedigeraKategori.Size = new Size(116, 37);
            btnRedigeraKategori.TabIndex = 12;
            btnRedigeraKategori.Text = "Redigera";
            btnRedigeraKategori.UseVisualStyleBackColor = true;
            btnRedigeraKategori.Click += btnRedigeraKategori_Click;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(146, 100);
            cbKategori.Margin = new Padding(3, 2, 3, 2);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(187, 33);
            cbKategori.TabIndex = 13;
            cbKategori.Text = "Kategori";
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(119, 55);
            txtNamn.Margin = new Padding(4, 5, 4, 5);
            txtNamn.Name = "txtNamn";
            txtNamn.PlaceholderText = "Namn";
            txtNamn.Size = new Size(215, 31);
            txtNamn.TabIndex = 14;
            // 
            // btnLaggTillPodd
            // 
            btnLaggTillPodd.Location = new Point(359, 50);
            btnLaggTillPodd.Margin = new Padding(4, 5, 4, 5);
            btnLaggTillPodd.Name = "btnLaggTillPodd";
            btnLaggTillPodd.Size = new Size(97, 43);
            btnLaggTillPodd.TabIndex = 15;
            btnLaggTillPodd.Text = "Lägg till";
            btnLaggTillPodd.UseVisualStyleBackColor = true;
            btnLaggTillPodd.Click += btnLaggTillPodd_Click;
            // 
            // dgvPoddar
            // 
            dgvPoddar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoddar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvPoddar.Location = new Point(4, 147);
            dgvPoddar.Margin = new Padding(4, 5, 4, 5);
            dgvPoddar.Name = "dgvPoddar";
            dgvPoddar.RowHeadersVisible = false;
            dgvPoddar.RowHeadersWidth = 62;
            dgvPoddar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoddar.Size = new Size(649, 668);
            dgvPoddar.TabIndex = 16;
            dgvPoddar.CellClick += DgvPoddar_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Namn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Titel";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 150;
            // 
            // txtKategoriNamn
            // 
            txtKategoriNamn.Location = new Point(967, 42);
            txtKategoriNamn.Margin = new Padding(4, 5, 4, 5);
            txtKategoriNamn.Name = "txtKategoriNamn";
            txtKategoriNamn.PlaceholderText = "Namn";
            txtKategoriNamn.Size = new Size(141, 31);
            txtKategoriNamn.TabIndex = 17;
            txtKategoriNamn.TextChanged += textBox1_TextChanged;
            // 
            // btnAterstall
            // 
            btnAterstall.Location = new Point(13, 97);
            btnAterstall.Margin = new Padding(4, 5, 4, 5);
            btnAterstall.Name = "btnAterstall";
            btnAterstall.Size = new Size(100, 40);
            btnAterstall.TabIndex = 18;
            btnAterstall.Text = "Återställ";
            btnAterstall.UseVisualStyleBackColor = true;
            btnAterstall.Click += btnAterstall_Click;
            // 
            // cbKategori2
            // 
            cbKategori2.FormattingEnabled = true;
            cbKategori2.Items.AddRange(new object[] { "Alla" });
            cbKategori2.Location = new Point(711, 98);
            cbKategori2.Margin = new Padding(4, 5, 4, 5);
            cbKategori2.Name = "cbKategori2";
            cbKategori2.Size = new Size(171, 33);
            cbKategori2.TabIndex = 18;
            cbKategori2.Text = "Alla";
            cbKategori2.SelectedIndexChanged += cbKategori2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(711, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 19;
            label1.Text = "Sortera";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 888);
            Controls.Add(btnAterstall);
            Controls.Add(label1);
            Controls.Add(cbKategori2);
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
            Controls.Add(lbKategorier);
            Controls.Add(txtRssInput);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Alla";
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
        private ListBox lbKategorier;
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
        private TextBox txtKategoriNamn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnAterstall;
        private ComboBox cbKategori2;
        private Label label1;

    }
}
