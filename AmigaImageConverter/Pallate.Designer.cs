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
            this.imagePallate = new Pallate_Control.Pallate();
            this.SuspendLayout();
            // 
            // imagePallate
            // 
            this.imagePallate.Location = new System.Drawing.Point(12, 12);
            this.imagePallate.Name = "imagePallate";
            this.imagePallate.NumOfColors = 256;
            this.imagePallate.SelectedColor = System.Drawing.Color.Lime;
            this.imagePallate.Size = new System.Drawing.Size(501, 668);
            this.imagePallate.TabIndex = 0;
            // 
            // Pallate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 680);
            this.Controls.Add(this.imagePallate);
            this.Name = "Pallate";
            this.Text = "Pallate";
            this.ResumeLayout(false);

        }

        #endregion

        public Pallate_Control.Pallate imagePallate;
    }
}