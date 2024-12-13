namespace AmigaImageConverter
{
    partial class DDFCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDFCalculator));
            tvPanel = new System.Windows.Forms.Panel();
            displayWindowsGB = new System.Windows.Forms.GroupBox();
            diwWidthNum = new System.Windows.Forms.NumericUpDown();
            dataFetchGB = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            diwstopHexBox = new Amiga.HexBox();
            diwheightNum = new System.Windows.Forms.NumericUpDown();
            diwstrtHexBox = new Amiga.HexBox();
            dmaWidthCB = new System.Windows.Forms.ComboBox();
            ddfstartHexBox = new Amiga.HexBox();
            ddfstopHexBox = new Amiga.HexBox();
            resolutionCB = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            hardScrollCheckBox = new System.Windows.Forms.CheckBox();
            displayWindowsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)diwWidthNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diwheightNum).BeginInit();
            SuspendLayout();
            // 
            // tvPanel
            // 
            tvPanel.BackgroundImage = (System.Drawing.Image)resources.GetObject("tvPanel.BackgroundImage");
            tvPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tvPanel.Location = new System.Drawing.Point(12, 12);
            tvPanel.Name = "tvPanel";
            tvPanel.Size = new System.Drawing.Size(844, 601);
            tvPanel.TabIndex = 0;
            tvPanel.Paint += tvPanel_Paint;
            // 
            // displayWindowsGB
            // 
            displayWindowsGB.Controls.Add(diwWidthNum);
            displayWindowsGB.Controls.Add(dataFetchGB);
            displayWindowsGB.Controls.Add(label2);
            displayWindowsGB.Controls.Add(label4);
            displayWindowsGB.Controls.Add(label1);
            displayWindowsGB.Controls.Add(label3);
            displayWindowsGB.Controls.Add(diwstopHexBox);
            displayWindowsGB.Controls.Add(diwheightNum);
            displayWindowsGB.Controls.Add(diwstrtHexBox);
            displayWindowsGB.Location = new System.Drawing.Point(862, 99);
            displayWindowsGB.Name = "displayWindowsGB";
            displayWindowsGB.Size = new System.Drawing.Size(367, 236);
            displayWindowsGB.TabIndex = 2;
            displayWindowsGB.TabStop = false;
            displayWindowsGB.Text = "Display Window";
            // 
            // diwWidthNum
            // 
            diwWidthNum.Location = new System.Drawing.Point(6, 58);
            diwWidthNum.Maximum = new decimal(new int[] { 640, 0, 0, 0 });
            diwWidthNum.Name = "diwWidthNum";
            diwWidthNum.Size = new System.Drawing.Size(160, 31);
            diwWidthNum.TabIndex = 9;
            diwWidthNum.ValueChanged += diwWidthNum_ValueChanged;
            // 
            // dataFetchGB
            // 
            dataFetchGB.Location = new System.Drawing.Point(6, 201);
            dataFetchGB.Name = "dataFetchGB";
            dataFetchGB.Size = new System.Drawing.Size(361, 130);
            dataFetchGB.TabIndex = 8;
            dataFetchGB.TabStop = false;
            dataFetchGB.Text = "Display Data Fetch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(201, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 25);
            label2.TabIndex = 4;
            label2.Text = "Height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(201, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "DIWSTOP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 25);
            label1.TabIndex = 3;
            label1.Text = "Width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 25);
            label3.TabIndex = 5;
            label3.Text = "DIWSTRT";
            // 
            // diwstopHexBox
            // 
            diwstopHexBox.AutoSize = true;
            diwstopHexBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            diwstopHexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            diwstopHexBox.Location = new System.Drawing.Point(201, 133);
            diwstopHexBox.Name = "diwstopHexBox";
            diwstopHexBox.Size = new System.Drawing.Size(152, 62);
            diwstopHexBox.TabIndex = 4;
            diwstopHexBox.Value = 0;
            // 
            // diwheightNum
            // 
            diwheightNum.Location = new System.Drawing.Point(201, 58);
            diwheightNum.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            diwheightNum.Name = "diwheightNum";
            diwheightNum.Size = new System.Drawing.Size(160, 31);
            diwheightNum.TabIndex = 2;
            diwheightNum.ValueChanged += diwheightNum_ValueChanged;
            // 
            // diwstrtHexBox
            // 
            diwstrtHexBox.AutoSize = true;
            diwstrtHexBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            diwstrtHexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            diwstrtHexBox.Location = new System.Drawing.Point(6, 133);
            diwstrtHexBox.Name = "diwstrtHexBox";
            diwstrtHexBox.Size = new System.Drawing.Size(152, 62);
            diwstrtHexBox.TabIndex = 3;
            diwstrtHexBox.Value = 0;
            // 
            // dmaWidthCB
            // 
            dmaWidthCB.FormattingEnabled = true;
            dmaWidthCB.Items.AddRange(new object[] { "16bit DMA", "32bit DMA", "64bit DMA" });
            dmaWidthCB.Location = new System.Drawing.Point(862, 21);
            dmaWidthCB.Name = "dmaWidthCB";
            dmaWidthCB.Size = new System.Drawing.Size(367, 33);
            dmaWidthCB.TabIndex = 7;
            dmaWidthCB.Text = "Select Dma Width";
            dmaWidthCB.SelectedIndexChanged += dmaWidthCB_SelectedIndexChanged;
            // 
            // ddfstartHexBox
            // 
            ddfstartHexBox.AutoSize = true;
            ddfstartHexBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ddfstartHexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ddfstartHexBox.Location = new System.Drawing.Point(868, 355);
            ddfstartHexBox.Name = "ddfstartHexBox";
            ddfstartHexBox.Size = new System.Drawing.Size(152, 62);
            ddfstartHexBox.TabIndex = 8;
            ddfstartHexBox.Value = 0;
            // 
            // ddfstopHexBox
            // 
            ddfstopHexBox.AutoSize = true;
            ddfstopHexBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ddfstopHexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ddfstopHexBox.Location = new System.Drawing.Point(1065, 355);
            ddfstopHexBox.Name = "ddfstopHexBox";
            ddfstopHexBox.Size = new System.Drawing.Size(152, 62);
            ddfstopHexBox.TabIndex = 9;
            ddfstopHexBox.Value = 0;
            // 
            // resolutionCB
            // 
            resolutionCB.FormattingEnabled = true;
            resolutionCB.Items.AddRange(new object[] { "Low Resolution", "High Resolution" });
            resolutionCB.Location = new System.Drawing.Point(862, 60);
            resolutionCB.Name = "resolutionCB";
            resolutionCB.Size = new System.Drawing.Size(367, 33);
            resolutionCB.TabIndex = 10;
            resolutionCB.Text = "Select Resolution";
            resolutionCB.SelectedIndexChanged += resolutionCB_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(868, 327);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 25);
            label5.TabIndex = 11;
            label5.Text = "DDFSTRT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(1063, 327);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(89, 25);
            label6.TabIndex = 0;
            label6.Text = "DDFSTOP";
            // 
            // hardScrollCheckBox
            // 
            hardScrollCheckBox.AutoSize = true;
            hardScrollCheckBox.Location = new System.Drawing.Point(868, 436);
            hardScrollCheckBox.Name = "hardScrollCheckBox";
            hardScrollCheckBox.Size = new System.Drawing.Size(187, 29);
            hardScrollCheckBox.TabIndex = 12;
            hardScrollCheckBox.Text = "Hardware Scrolling";
            hardScrollCheckBox.UseVisualStyleBackColor = true;
            hardScrollCheckBox.Click += hardScrollCheckBox_Click;
            // 
            // DDFCalculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1241, 625);
            Controls.Add(hardScrollCheckBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(resolutionCB);
            Controls.Add(ddfstopHexBox);
            Controls.Add(ddfstartHexBox);
            Controls.Add(dmaWidthCB);
            Controls.Add(displayWindowsGB);
            Controls.Add(tvPanel);
            DoubleBuffered = true;
            Name = "DDFCalculator";
            Text = "DDFCalculator";
            Paint += DDFCalculator_Paint;
            displayWindowsGB.ResumeLayout(false);
            displayWindowsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)diwWidthNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)diwheightNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel tvPanel;
        private System.Windows.Forms.GroupBox displayWindowsGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown diwheightNum;
        private System.Windows.Forms.Label label2;
        private Amiga.HexBox diwstrtHexBox;
        private Amiga.HexBox diwstopHexBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dmaWidthCB;
        private System.Windows.Forms.GroupBox dataFetchGB;
        private Amiga.HexBox ddfstartHexBox;
        private Amiga.HexBox ddfstopHexBox;
        private System.Windows.Forms.ComboBox resolutionCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown diwWidthNum;
        private System.Windows.Forms.CheckBox hardScrollCheckBox;
    }
}