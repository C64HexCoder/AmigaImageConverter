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
            OKbtn = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            HeightLbl = new System.Windows.Forms.Label();
            WidthLbl = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            PaletteSizeLbl = new System.Windows.Forms.Label();
            BitplanesLbl = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // OKbtn
            // 
            OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            OKbtn.Location = new System.Drawing.Point(154, 249);
            OKbtn.Name = "OKbtn";
            OKbtn.Size = new System.Drawing.Size(112, 34);
            OKbtn.TabIndex = 0;
            OKbtn.Text = "OK";
            OKbtn.UseVisualStyleBackColor = true;
            OKbtn.Click += OKbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HeightLbl);
            groupBox1.Controls.Add(WidthLbl);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(246, 95);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resolution";
            // 
            // HeightLbl
            // 
            HeightLbl.AutoSize = true;
            HeightLbl.Location = new System.Drawing.Point(130, 37);
            HeightLbl.Name = "HeightLbl";
            HeightLbl.Size = new System.Drawing.Size(110, 25);
            HeightLbl.TabIndex = 1;
            HeightLbl.Text = "Height: 200";
            // 
            // WidthLbl
            // 
            WidthLbl.AutoSize = true;
            WidthLbl.Location = new System.Drawing.Point(6, 37);
            WidthLbl.Name = "WidthLbl";
            WidthLbl.Size = new System.Drawing.Size(104, 25);
            WidthLbl.TabIndex = 0;
            WidthLbl.Text = "Width: 320";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PaletteSizeLbl);
            groupBox2.Controls.Add(BitplanesLbl);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(12, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(246, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Depth";
            // 
            // PaletteSizeLbl
            // 
            PaletteSizeLbl.AutoSize = true;
            PaletteSizeLbl.Location = new System.Drawing.Point(6, 61);
            PaletteSizeLbl.Name = "PaletteSizeLbl";
            PaletteSizeLbl.Size = new System.Drawing.Size(141, 25);
            PaletteSizeLbl.TabIndex = 1;
            PaletteSizeLbl.Text = "Palette Size: 16";
            // 
            // BitplanesLbl
            // 
            BitplanesLbl.AutoSize = true;
            BitplanesLbl.Location = new System.Drawing.Point(6, 36);
            BitplanesLbl.Name = "BitplanesLbl";
            BitplanesLbl.Size = new System.Drawing.Size(111, 25);
            BitplanesLbl.TabIndex = 0;
            BitplanesLbl.Text = "Bitplanes: 4";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(278, 298);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(OKbtn);
            Name = "InfoForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Information";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PaletteSizeLbl;
        private System.Windows.Forms.Label BitplanesLbl;
    }
}