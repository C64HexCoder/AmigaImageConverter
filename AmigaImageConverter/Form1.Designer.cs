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
            pictureBox1 = new Amiga.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.HorizontalScrollBar = null;
            pictureBox1.HScrollBarAlignment = Amiga.PictureBox.HorizontalScrollBarAlignment.Bottom;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InterpolationAlgorithm = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            pictureBox1.Location = new System.Drawing.Point(-6, 12);
            pictureBox1.MouseWheelZoom = true;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.OverlayLineWidth = 2;
            pictureBox1.OverlayRectangleColor = System.Drawing.Color.Red;
            pictureBox1.OverlayRectangleEnabled = false;
            pictureBox1.OverlayRectangleVisible = true;
            pictureBox1.ScaleFactor = 1F;
            pictureBox1.ScaleStep = 0.1F;
            pictureBox1.ScrollBarsWidth = 20;
            pictureBox1.ShowScrollBars = true;
            pictureBox1.Size = new System.Drawing.Size(997, 690);
            pictureBox1.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Scale;
            pictureBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.VerticalScrollBar = null;
            pictureBox1.VScrollBarAlignment = Amiga.PictureBox.VerticalScrollBarAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(992, 746);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Amiga.PictureBox pictureBox1;
    }
}
