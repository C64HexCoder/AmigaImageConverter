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
            exPictureBox1 = new Amiga.ExPictureBox();
            SuspendLayout();
            // 
            // exPictureBox1
            // 
            exPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            exPictureBox1.HScrollAlignment = Amiga.PictureBox.HorizontalScrollBarAlignment.Bottom;
            exPictureBox1.Image = (System.Drawing.Image)resources.GetObject("exPictureBox1.Image");
            exPictureBox1.InterpulationAlgorithem = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            exPictureBox1.Location = new System.Drawing.Point(0, 0);
            exPictureBox1.MouseWheelZoom = true;
            exPictureBox1.Name = "exPictureBox1";
            exPictureBox1.OverlayLineWidth = 4;
            exPictureBox1.OverlayRectangleColor = System.Drawing.Color.Red;
            exPictureBox1.OverlayRectangleEnabled = false;
            exPictureBox1.ScaldeFactor = 1F;
            exPictureBox1.ScaleStep = 0.1F;
            exPictureBox1.ScrollbarVisible = false;
            exPictureBox1.Size = new System.Drawing.Size(992, 746);
            exPictureBox1.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Scale;
            exPictureBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            exPictureBox1.TabIndex = 0;
            exPictureBox1.VScrollAlignment = Amiga.PictureBox.VerticalScrollBarAlignment.Right;
            exPictureBox1.ImageMouseClick += exPictureBox1_ImageMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(992, 746);
            Controls.Add(exPictureBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Amiga.ExPictureBox exPictureBox1;
    }
}
