namespace AmigaImageConverter
{
    partial class InfoForm
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
            this.OKbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColorUsedLbl = new System.Windows.Forms.Label();
            this.PaletteSizeLbl = new System.Windows.Forms.Label();
            this.BitplanesLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(154, 249);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(112, 34);
            this.OKbtn.TabIndex = 0;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HeightLbl);
            this.groupBox1.Controls.Add(this.WidthLbl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resolution";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(130, 37);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(110, 25);
            this.HeightLbl.TabIndex = 1;
            this.HeightLbl.Text = "Height: 200";
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(6, 37);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(104, 25);
            this.WidthLbl.TabIndex = 0;
            this.WidthLbl.Text = "Width: 320";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ColorUsedLbl);
            this.groupBox2.Controls.Add(this.PaletteSizeLbl);
            this.groupBox2.Controls.Add(this.BitplanesLbl);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depth";
            // 
            // ColorUsedLbl
            // 
            this.ColorUsedLbl.AutoSize = true;
            this.ColorUsedLbl.Location = new System.Drawing.Point(6, 86);
            this.ColorUsedLbl.Name = "ColorUsedLbl";
            this.ColorUsedLbl.Size = new System.Drawing.Size(124, 25);
            this.ColorUsedLbl.TabIndex = 2;
            this.ColorUsedLbl.Text = "Color Used: 8";
            // 
            // PaletteSizeLbl
            // 
            this.PaletteSizeLbl.AutoSize = true;
            this.PaletteSizeLbl.Location = new System.Drawing.Point(6, 61);
            this.PaletteSizeLbl.Name = "PaletteSizeLbl";
            this.PaletteSizeLbl.Size = new System.Drawing.Size(141, 25);
            this.PaletteSizeLbl.TabIndex = 1;
            this.PaletteSizeLbl.Text = "Palette Size: 16";
            // 
            // BitplanesLbl
            // 
            this.BitplanesLbl.AutoSize = true;
            this.BitplanesLbl.Location = new System.Drawing.Point(6, 36);
            this.BitplanesLbl.Name = "BitplanesLbl";
            this.BitplanesLbl.Size = new System.Drawing.Size(111, 25);
            this.BitplanesLbl.TabIndex = 0;
            this.BitplanesLbl.Text = "Bitplanes: 4";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKbtn);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ColorUsedLbl;
        private System.Windows.Forms.Label PaletteSizeLbl;
        private System.Windows.Forms.Label BitplanesLbl;
    }
}