namespace AmigaImageConverter
{
    partial class Form1
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
            hScrollBar1 = new System.Windows.Forms.HScrollBar();
            vScrollBar1 = new System.Windows.Forms.VScrollBar();
            pictureBox1 = new Amiga.PictureBox();
            pictureBox2 = new Amiga.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new System.Drawing.Point(487, 365);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new System.Drawing.Size(275, 20);
            hScrollBar1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new System.Drawing.Point(762, 76);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new System.Drawing.Size(20, 289);
            vScrollBar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.HorizontalScrollBar = hScrollBar1;
            pictureBox1.HorizontalScrollBarAlignment = Amiga.PictureBox.ScrollBarAlignment.Bottom;
            pictureBox1.Image = null;
            pictureBox1.InterpolationAlgorithm = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.ScaleFactor = 1F;
            pictureBox1.Size = new System.Drawing.Size(441, 387);
            pictureBox1.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Scale;
            pictureBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.VerticalScrollBar = vScrollBar1;
            pictureBox1.VerticalScrollBarAlignment = Amiga.PictureBox.ScrollBarAlignment.Right;
            // 
            // pictureBox2
            // 
            pictureBox2.HorizontalScrollBar = hScrollBar1;
            pictureBox2.HorizontalScrollBarAlignment = Amiga.PictureBox.ScrollBarAlignment.Bottom;
            pictureBox2.Image = null;
            pictureBox2.InterpolationAlgorithm = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            pictureBox2.Location = new System.Drawing.Point(487, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.ScaleFactor = 1F;
            pictureBox2.Size = new System.Drawing.Size(275, 289);
            pictureBox2.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Scale;
            pictureBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.VerticalScrollBar = vScrollBar1;
            pictureBox2.VerticalScrollBarAlignment = Amiga.PictureBox.ScrollBarAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private Amiga.PictureBox pictureBox1;
        private Amiga.PictureBox pictureBox2;
    }
}
