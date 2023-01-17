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
            this.imagePallate = new Amiga.Pallate();
            this.SuspendLayout();
            // 
            // imagePallate
            // 
            this.imagePallate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imagePallate.Location = new System.Drawing.Point(12, 12);
            this.imagePallate.Name = "imagePallate";
            this.imagePallate.NumOfColors = 8;
            this.imagePallate.RGBVisible = true;
            this.imagePallate.SelectedColor = System.Drawing.Color.Empty;
            this.imagePallate.SelectedColorBox = true;
            this.imagePallate.Size = new System.Drawing.Size(533, 775);
            this.imagePallate.TabIndex = 0;
            // 
            // Pallate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(557, 895);
            this.Controls.Add(this.imagePallate);
            this.Name = "Pallate";
            this.Text = "Pallate";
            this.ResumeLayout(false);

        }

        #endregion

        public Amiga.Pallate imagePallate;
    }
}