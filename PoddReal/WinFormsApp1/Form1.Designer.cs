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
            button1 = new Button();
            txtTest = new TextBox();
            txtRssInput = new TextBox();
            lbPoddar = new ListBox();
            lbKategorier = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(515, 513);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(182, 62);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(1137, 544);
            txtTest.Margin = new Padding(7, 8, 7, 8);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(237, 47);
            txtTest.TabIndex = 1;
            // 
            // txtRssInput
            // 
            txtRssInput.Location = new Point(1198, 348);
            txtRssInput.Margin = new Padding(5, 5, 5, 5);
            txtRssInput.Name = "txtRssInput";
            txtRssInput.Size = new Size(252, 47);
            txtRssInput.TabIndex = 2;
            txtRssInput.Text = "https://api.sr.se/api/rss/pod/itunes/3966";
            // 
            // lbPoddar
            // 
            lbPoddar.FormattingEnabled = true;
            lbPoddar.ItemHeight = 41;
            lbPoddar.Location = new Point(87, 87);
            lbPoddar.Name = "lbPoddar";
            lbPoddar.Size = new Size(300, 209);
            lbPoddar.TabIndex = 3;
            lbPoddar.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lbKategorier
            // 
            lbKategorier.FormattingEnabled = true;
            lbKategorier.ItemHeight = 41;
            lbKategorier.Location = new Point(475, 87);
            lbKategorier.Name = "lbKategorier";
            lbKategorier.Size = new Size(300, 209);
            lbKategorier.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1943, 1230);
            Controls.Add(lbKategorier);
            Controls.Add(lbPoddar);
            Controls.Add(txtRssInput);
            Controls.Add(txtTest);
            Controls.Add(button1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtTest;
        private TextBox txtRssInput;
        private ListBox lbPoddar;
        private ListBox lbKategorier;
    }
}
