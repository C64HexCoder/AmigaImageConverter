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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new Amiga.PictureBox();
            hScrollBar1 = new System.Windows.Forms.HScrollBar();
            vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.HorizontalScrollBar = hScrollBar1;
            pictureBox2.HScrollBarAlignment = Amiga.PictureBox.HorizontalScrollBarAlignment.Bottom;
            pictureBox2.Image = null;
            pictureBox2.InterpolationAlgorithm = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            pictureBox2.Location = new System.Drawing.Point(30, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.ScaleFactor = 1F;
            pictureBox2.ScrollBarsWidth = 30;
            pictureBox2.Size = new System.Drawing.Size(737, 387);
            pictureBox2.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Normal;
            pictureBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.VerticalScrollBar = vScrollBar1;
            pictureBox2.VScrollBarAlignment = Amiga.PictureBox.VerticalScrollBarAlignment.Right;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new System.Drawing.Point(30, 408);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new System.Drawing.Size(737, 30);
            hScrollBar1.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new System.Drawing.Point(767, 21);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new System.Drawing.Size(30, 387);
            vScrollBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Amiga.PictureBox pictureBox2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}
