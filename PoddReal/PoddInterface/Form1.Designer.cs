namespace PoddInterface
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
            knapp = new Button();
            tbTest = new TextBox();
            SuspendLayout();
            // 
            // knapp
            // 
            knapp.Location = new Point(156, 178);
            knapp.Name = "knapp";
            knapp.Size = new Size(112, 34);
            knapp.TabIndex = 0;
            knapp.Text = "button1";
            knapp.UseVisualStyleBackColor = true;
            // 
            // tbTest
            // 
            tbTest.Location = new Point(502, 181);
            tbTest.Name = "tbTest";
            tbTest.Size = new Size(150, 31);
            tbTest.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbTest);
            Controls.Add(knapp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button knapp;
        private TextBox tbTest;
    }
}
