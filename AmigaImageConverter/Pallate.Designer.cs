namespace AmigaImageConverter
{
    partial class Pallate
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
            imagePallate = new Amiga.Palette();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // imagePallate
            // 
            imagePallate.AlphChennel = true;
            imagePallate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            imagePallate.Location = new System.Drawing.Point(2, 1);
            imagePallate.Name = "imagePallate";
            imagePallate.NumOfColors = 8;
            imagePallate.paletteFormat = Amiga.Palette.PaletteFormat.TwelveBit;
            imagePallate.RGBVisible = true;
            imagePallate.SelectedColor = System.Drawing.Color.FromArgb(242, 137, 97);
            imagePallate.SelectedColorBox = true;
            imagePallate.SelectedColorIdx = 0;
            imagePallate.Size = new System.Drawing.Size(542, 628);
            imagePallate.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(433, 664);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // Pallate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(557, 710);
            Controls.Add(button1);
            Controls.Add(imagePallate);
            Name = "Pallate";
            Text = "Pallate";
            ResumeLayout(false);
        }

        #endregion

        public Amiga.Palette imagePallate;
        private System.Windows.Forms.Button button1;
    }
}