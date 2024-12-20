namespace AmigaImageConverter
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            button1 = new System.Windows.Forms.Button();
            versionLable = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            richTextBox1.Location = new System.Drawing.Point(14, 16);
            richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            richTextBox1.Size = new System.Drawing.Size(459, 258);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Amiga Image Converter (AIC)\nProgrammed by Yossi Shelly on June 2022.\n\nVersion: \nAll Rights (C) Reserved!! \n\n\n\nYossi.shelly@gmail.com\n\n";
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(314, 223);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(159, 51);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // versionLable
            // 
            versionLable.AutoSize = true;
            versionLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            versionLable.Location = new System.Drawing.Point(92, 92);
            versionLable.Name = "versionLable";
            versionLable.Size = new System.Drawing.Size(52, 25);
            versionLable.TabIndex = 2;
            versionLable.Text = "1.0.0";
            // 
            // About
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(485, 287);
            Controls.Add(versionLable);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "About";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label versionLable;
    }
}