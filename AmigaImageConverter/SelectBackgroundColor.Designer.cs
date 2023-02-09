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
            this.pallete = new Amiga.Pallate();
            this.swapBt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBox = new Amiga.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pallete
            // 
            this.pallete.AlphChennel = true;
            this.pallete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pallete.Location = new System.Drawing.Point(754, 12);
            this.pallete.Name = "pallete";
            this.pallete.NumOfColors = 4;
            this.pallete.RGBVisible = true;
            this.pallete.SelectedColor = System.Drawing.Color.Empty;
            this.pallete.SelectedColorBox = true;
            this.pallete.SelectedColorIdx = ((byte)(0));
            this.pallete.Size = new System.Drawing.Size(397, 519);
            this.pallete.TabIndex = 0;
            this.pallete.ColorSelected += new System.EventHandler<Amiga.Pallate.SelectedColorEventArgs>(this.pallete_ColorSelected);
            // 
            // swapBt
            // 
            this.swapBt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.swapBt.Location = new System.Drawing.Point(1023, 549);
            this.swapBt.Name = "swapBt";
            this.swapBt.Size = new System.Drawing.Size(128, 34);
            this.swapBt.TabIndex = 1;
            this.swapBt.Text = "Swap";
            this.swapBt.UseVisualStyleBackColor = true;
            this.swapBt.Click += new System.EventHandler(this.swapBt_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(12, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "No Thanks";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.ScaleFactor = 1;
            this.imageBox.Size = new System.Drawing.Size(736, 519);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox.TabIndex = 3;
            this.imageBox.TabStop = false;
            this.imageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseClick);
            // 
            // SelectBackgroundColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1163, 595);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.swapBt);
            this.Controls.Add(this.pallete);
            this.Name = "SelectBackgroundColor";
            this.Text = "Select Background Color";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button swapBt;
        private System.Windows.Forms.Button button2;
        public Amiga.Pallate pallete;
        private Amiga.ImageBox imageBox;
    }
}