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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(303, 313);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(669, 332);
            txtTest.Margin = new Padding(4, 5, 4, 5);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(141, 31);
            txtTest.TabIndex = 1;
            // 
            // txtRssInput
            // 
            txtRssInput.Location = new Point(705, 212);
            txtRssInput.Name = "txtRssInput";
            txtRssInput.Size = new Size(150, 31);
            txtRssInput.TabIndex = 2;
            txtRssInput.Text = "https://api.sr.se/api/rss/pod/itunes/3966";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(txtRssInput);
            Controls.Add(txtTest);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtTest;
        private TextBox txtRssInput;
    }
}
