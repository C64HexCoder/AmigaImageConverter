namespace AmigaImageConverter
{
    partial class PaletteQulalizerBtn
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
            paletteGrid = new Amiga.ColorsGrid();
            groupBox1 = new System.Windows.Forms.GroupBox();
            paletteLoadBtn = new System.Windows.Forms.Button();
            fileNameTxt = new System.Windows.Forms.TextBox();
            convertPaletteBtn = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            backgroundColorBox = new Amiga.ColorBox();
            localImageBox = new Amiga.ImageBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)localImageBox).BeginInit();
            SuspendLayout();
            // 
            // paletteGrid
            // 
            paletteGrid.Dock = System.Windows.Forms.DockStyle.Top;
            paletteGrid.Location = new System.Drawing.Point(0, 0);
            paletteGrid.Name = "paletteGrid";
            paletteGrid.NumOfColors = 4;
            paletteGrid.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            paletteGrid.paletteFormat = Amiga.ColorsGrid.PaletteFormat.TwelveBit;
            paletteGrid.Size = new System.Drawing.Size(259, 250);
            paletteGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(paletteLoadBtn);
            groupBox1.Controls.Add(fileNameTxt);
            groupBox1.Location = new System.Drawing.Point(0, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dest. Palette";
            // 
            // paletteLoadBtn
            // 
            paletteLoadBtn.Location = new System.Drawing.Point(139, 67);
            paletteLoadBtn.Name = "paletteLoadBtn";
            paletteLoadBtn.Size = new System.Drawing.Size(111, 34);
            paletteLoadBtn.TabIndex = 1;
            paletteLoadBtn.Text = "Load";
            paletteLoadBtn.UseVisualStyleBackColor = true;
            paletteLoadBtn.Click += paletteLoadBtn_Click;
            // 
            // fileNameTxt
            // 
            fileNameTxt.Location = new System.Drawing.Point(6, 30);
            fileNameTxt.Name = "fileNameTxt";
            fileNameTxt.Size = new System.Drawing.Size(244, 31);
            fileNameTxt.TabIndex = 0;
            // 
            // convertPaletteBtn
            // 
            convertPaletteBtn.Location = new System.Drawing.Point(6, 678);
            convertPaletteBtn.Name = "convertPaletteBtn";
            convertPaletteBtn.Size = new System.Drawing.Size(244, 34);
            convertPaletteBtn.TabIndex = 2;
            convertPaletteBtn.Text = "Convert Palette";
            convertPaletteBtn.UseVisualStyleBackColor = true;
            convertPaletteBtn.Click += convertPaletteBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(backgroundColorBox);
            groupBox2.Location = new System.Drawing.Point(6, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(244, 82);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Background Color";
            // 
            // backgroundColorBox
            // 
            backgroundColorBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            backgroundColorBox.color = System.Drawing.SystemColors.ActiveCaption;
            backgroundColorBox.Location = new System.Drawing.Point(6, 30);
            backgroundColorBox.Name = "backgroundColorBox";
            backgroundColorBox.Size = new System.Drawing.Size(232, 39);
            backgroundColorBox.TabIndex = 0;
            backgroundColorBox.Click += backgroundColorBox_Click;
            // 
            // localImageBox
            // 
            localImageBox.AutoCenter = false;
            localImageBox.AutoScaleImageBox = false;
            localImageBox.HrizontalScrollBar = null;
            localImageBox.Image = null;
            localImageBox.Location = new System.Drawing.Point(12, 486);
            localImageBox.MaxImageScale = 4;
            localImageBox.MouseWheelZoom = false;
            localImageBox.Name = "localImageBox";
            localImageBox.OriginalImage = null;
            localImageBox.ScaleFactor = 1;
            localImageBox.ScaleFactorFloat = 1F;
            localImageBox.Size = new System.Drawing.Size(232, 186);
            localImageBox.TabIndex = 4;
            localImageBox.TabStop = false;
            localImageBox.VerticalScrollBar = null;
            // 
            // PaletteQulalizerBtn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(localImageBox);
            Controls.Add(groupBox2);
            Controls.Add(convertPaletteBtn);
            Controls.Add(groupBox1);
            Controls.Add(paletteGrid);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "PaletteQulalizerBtn";
            Size = new System.Drawing.Size(259, 735);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)localImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Amiga.ColorsGrid paletteGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button paletteLoadBtn;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.Button convertPaletteBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private Amiga.ColorBox backgroundColorBox;
        private Amiga.ImageBox localImageBox;
    }
}
