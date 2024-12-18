namespace AmigaImageConverter
{
    partial class BlitterLFCalculator
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
            byteDisplay1 = new Amiga.ByteDisplay();
            label1 = new System.Windows.Forms.Label();
            byteDisplay2 = new Amiga.ByteDisplay();
            byteDisplay3 = new Amiga.ByteDisplay();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            byteDisplay4 = new Amiga.ByteDisplay();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // byteDisplay1
            // 
            byteDisplay1.AutoSize = true;
            byteDisplay1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            byteDisplay1.ByteVal = 255;
            byteDisplay1.Location = new System.Drawing.Point(201, 12);
            byteDisplay1.Name = "byteDisplay1";
            byteDisplay1.Size = new System.Drawing.Size(296, 80);
            byteDisplay1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(12, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 32);
            label1.TabIndex = 9;
            label1.Text = "Source A";
            // 
            // byteDisplay2
            // 
            byteDisplay2.AutoSize = true;
            byteDisplay2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            byteDisplay2.ByteVal = 0;
            byteDisplay2.Location = new System.Drawing.Point(201, 98);
            byteDisplay2.Name = "byteDisplay2";
            byteDisplay2.Size = new System.Drawing.Size(296, 80);
            byteDisplay2.TabIndex = 11;
            // 
            // byteDisplay3
            // 
            byteDisplay3.AutoSize = true;
            byteDisplay3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            byteDisplay3.ByteVal = 0;
            byteDisplay3.Location = new System.Drawing.Point(201, 184);
            byteDisplay3.Name = "byteDisplay3";
            byteDisplay3.Size = new System.Drawing.Size(296, 80);
            byteDisplay3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(12, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 32);
            label2.TabIndex = 13;
            label2.Text = "Source B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(12, 210);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 32);
            label3.TabIndex = 14;
            label3.Text = "Source C";
            // 
            // byteDisplay4
            // 
            byteDisplay4.AutoSize = true;
            byteDisplay4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            byteDisplay4.ByteVal = 0;
            byteDisplay4.Location = new System.Drawing.Point(201, 326);
            byteDisplay4.Name = "byteDisplay4";
            byteDisplay4.Size = new System.Drawing.Size(296, 80);
            byteDisplay4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(12, 347);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(152, 32);
            label4.TabIndex = 16;
            label4.Text = "Destenation";
            // 
            // BlitterLFCalculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(513, 425);
            Controls.Add(label4);
            Controls.Add(byteDisplay4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(byteDisplay3);
            Controls.Add(byteDisplay2);
            Controls.Add(label1);
            Controls.Add(byteDisplay1);
            Name = "BlitterLFCalculator";
            Text = "BlitterLFCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Amiga.ByteDisplay byteDisplay1;
        private System.Windows.Forms.Label label1;
        private Amiga.ByteDisplay byteDisplay2;
        private Amiga.ByteDisplay byteDisplay3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Amiga.ByteDisplay byteDisplay4;
        private System.Windows.Forms.Label label4;
    }
}