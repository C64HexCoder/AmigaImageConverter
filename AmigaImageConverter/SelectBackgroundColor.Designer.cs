namespace AmigaImageConverter
{
    partial class SelectBackgroundColor
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
            pallete = new Amiga.Palette();
            swapBt = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            imageBox = new Amiga.ImageBox();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // pallete
            // 
            pallete.AlphChennel = true;
            pallete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pallete.Location = new System.Drawing.Point(754, 12);
            pallete.Name = "pallete";
            pallete.NumOfColors = 4;
            pallete.paletteFormat = Amiga.Palette.PaletteFormat.TwelveBit;
            pallete.RGBVisible = true;
            pallete.SelectedColor = System.Drawing.Color.FromArgb(15, 132, 179);
            pallete.SelectedColorBox = true;
            pallete.SelectedColorIdx = 0;
            pallete.Size = new System.Drawing.Size(397, 519);
            pallete.TabIndex = 0;
            pallete.ColorSelected += pallete_ColorSelected;
            // 
            // swapBt
            // 
            swapBt.DialogResult = System.Windows.Forms.DialogResult.OK;
            swapBt.Location = new System.Drawing.Point(1023, 549);
            swapBt.Name = "swapBt";
            swapBt.Size = new System.Drawing.Size(128, 34);
            swapBt.TabIndex = 1;
            swapBt.Text = "Swap";
            swapBt.UseVisualStyleBackColor = true;
            swapBt.Click += swapBt_Click;
            // 
            // button2
            // 
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.Location = new System.Drawing.Point(12, 549);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(128, 34);
            button2.TabIndex = 2;
            button2.Text = "No Thanks";
            button2.UseVisualStyleBackColor = true;
            // 
            // imageBox
            // 
            imageBox.AutoCenter = false;
            imageBox.AutoScaleImageBox = false;
            imageBox.HrizontalScrollBar = null;
            imageBox.Image = null;
            imageBox.Location = new System.Drawing.Point(12, 12);
            imageBox.MaxImageScale = 4;
            imageBox.MouseWheelZoom = false;
            imageBox.Name = "imageBox";
            imageBox.OriginalImage = null;
            imageBox.ScaleFactor = 1;
            imageBox.ScaleFactorFloat = 1F;
            imageBox.Size = new System.Drawing.Size(736, 519);
            imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            imageBox.TabIndex = 3;
            imageBox.TabStop = false;
            imageBox.VerticalScrollBar = null;
            imageBox.MouseClick += imageBox_MouseClick;
            // 
            // SelectBackgroundColor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1163, 595);
            Controls.Add(imageBox);
            Controls.Add(button2);
            Controls.Add(swapBt);
            Controls.Add(pallete);
            Name = "SelectBackgroundColor";
            Text = "Select Background Color";
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button swapBt;
        private System.Windows.Forms.Button button2;
        public Amiga.Palette pallete;
        private Amiga.ImageBox imageBox;
    }
}