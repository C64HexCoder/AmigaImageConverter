namespace Retro
{
    partial class Palette
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorPanel = new Panel();
            RedLbl = new Label();
            GreenLbl = new Label();
            BlueLbl = new Label();
            redNum = new NumericUpDown();
            greenNum = new NumericUpDown();
            blueNum = new NumericUpDown();
            selectedColorPb = new PictureBox();
            RGBPanel = new Panel();
            AlphaLbl = new Label();
            AlphaNum = new NumericUpDown();
            idxNum = new Label();
            ((System.ComponentModel.ISupportInitialize)redNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedColorPb).BeginInit();
            RGBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlphaNum).BeginInit();
            SuspendLayout();
            // 
            // colorPanel
            // 
            colorPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            colorPanel.Location = new Point(0, 0);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(497, 510);
            colorPanel.TabIndex = 0;
            colorPanel.Paint += colorPanel_Paint;
            colorPanel.Resize += colorPanel_Resize;
            // 
            // RedLbl
            // 
            RedLbl.AutoSize = true;
            RedLbl.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            RedLbl.ForeColor = Color.Red;
            RedLbl.Location = new Point(165, 7);
            RedLbl.Name = "RedLbl";
            RedLbl.Size = new Size(45, 25);
            RedLbl.TabIndex = 2;
            RedLbl.Text = "Red";
            RedLbl.Visible = false;
            // 
            // GreenLbl
            // 
            GreenLbl.AutoSize = true;
            GreenLbl.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            GreenLbl.ForeColor = Color.Lime;
            GreenLbl.Location = new Point(272, 7);
            GreenLbl.Name = "GreenLbl";
            GreenLbl.Size = new Size(63, 25);
            GreenLbl.TabIndex = 3;
            GreenLbl.Text = "Green";
            GreenLbl.Visible = false;
            // 
            // BlueLbl
            // 
            BlueLbl.AutoSize = true;
            BlueLbl.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            BlueLbl.ForeColor = Color.Blue;
            BlueLbl.Location = new Point(398, 7);
            BlueLbl.Name = "BlueLbl";
            BlueLbl.Size = new Size(50, 25);
            BlueLbl.TabIndex = 4;
            BlueLbl.Text = "Blue";
            BlueLbl.Visible = false;
            // 
            // redNum
            // 
            redNum.Location = new Point(142, 35);
            redNum.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            redNum.Name = "redNum";
            redNum.Size = new Size(100, 31);
            redNum.TabIndex = 5;
            redNum.TextAlign = HorizontalAlignment.Center;
            // 
            // greenNum
            // 
            greenNum.Location = new Point(262, 35);
            greenNum.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            greenNum.Name = "greenNum";
            greenNum.Size = new Size(100, 31);
            greenNum.TabIndex = 6;
            greenNum.TextAlign = HorizontalAlignment.Center;
            // 
            // blueNum
            // 
            blueNum.Location = new Point(379, 35);
            blueNum.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            blueNum.Name = "blueNum";
            blueNum.Size = new Size(100, 31);
            blueNum.TabIndex = 7;
            blueNum.TextAlign = HorizontalAlignment.Center;
            // 
            // selectedColorPb
            // 
            selectedColorPb.Location = new Point(3, 517);
            selectedColorPb.Name = "selectedColorPb";
            selectedColorPb.Size = new Size(494, 52);
            selectedColorPb.TabIndex = 8;
            selectedColorPb.TabStop = false;
            selectedColorPb.Visible = false;
            selectedColorPb.Resize += selectedColorPb_Resize;
            // 
            // RGBPanel
            // 
            RGBPanel.Controls.Add(AlphaLbl);
            RGBPanel.Controls.Add(AlphaNum);
            RGBPanel.Controls.Add(greenNum);
            RGBPanel.Controls.Add(RedLbl);
            RGBPanel.Controls.Add(blueNum);
            RGBPanel.Controls.Add(GreenLbl);
            RGBPanel.Controls.Add(BlueLbl);
            RGBPanel.Controls.Add(redNum);
            RGBPanel.Location = new Point(4, 577);
            RGBPanel.Margin = new Padding(4, 5, 4, 5);
            RGBPanel.Name = "RGBPanel";
            RGBPanel.Size = new Size(491, 97);
            RGBPanel.TabIndex = 9;
            RGBPanel.Resize += RGBPanel_Resize;
            // 
            // AlphaLbl
            // 
            AlphaLbl.AutoSize = true;
            AlphaLbl.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            AlphaLbl.Location = new Point(40, 7);
            AlphaLbl.Name = "AlphaLbl";
            AlphaLbl.Size = new Size(51, 25);
            AlphaLbl.TabIndex = 9;
            AlphaLbl.Text = "Alpa";
            // 
            // AlphaNum
            // 
            AlphaNum.Location = new Point(16, 35);
            AlphaNum.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            AlphaNum.Name = "AlphaNum";
            AlphaNum.Size = new Size(100, 31);
            AlphaNum.TabIndex = 8;
            AlphaNum.TextAlign = HorizontalAlignment.Center;
            // 
            // idxNum
            // 
            idxNum.AutoSize = true;
            idxNum.BackColor = Color.Transparent;
            idxNum.Font = new System.Drawing.Font("Segoe UI", 15F, FontStyle.Bold);
            idxNum.Location = new Point(231, 517);
            idxNum.Name = "idxNum";
            idxNum.Size = new Size(35, 41);
            idxNum.TabIndex = 10;
            idxNum.Text = "0";
            // 
            // Pallate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(idxNum);
            Controls.Add(RGBPanel);
            Controls.Add(selectedColorPb);
            Controls.Add(colorPanel);
            Name = "Pallate";
            Size = new Size(500, 679);
            Enter += Pallate_Enter;
            Resize += Pallate_Resize;
            ((System.ComponentModel.ISupportInitialize)redNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedColorPb).EndInit();
            RGBPanel.ResumeLayout(false);
            RGBPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AlphaNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel colorPanel;
        private Label RedLbl;
        private Label GreenLbl;
        private Label BlueLbl;
        private NumericUpDown redNum;
        private NumericUpDown greenNum;
        private NumericUpDown blueNum;
        private PictureBox selectedColorPb;
        private Panel RGBPanel;
        private Label idxNum;
        private Label AlphaLbl;
        private NumericUpDown AlphaNum;
    }
}
