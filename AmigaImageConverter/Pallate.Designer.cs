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
            this.button1 = new System.Windows.Forms.Button();
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
            this.imagePallate.SelectedColorIdx = ((byte)(0));
            this.imagePallate.Size = new System.Drawing.Size(533, 644);
            this.imagePallate.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pallate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(557, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagePallate);
            this.Name = "Pallate";
            this.Text = "Pallate";
            this.ResumeLayout(false);

        }

        #endregion

        public Amiga.Pallate imagePallate;
        private System.Windows.Forms.Button button1;
    }
}