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
            exPictureBox1.HScrollAlignment = Amiga.PictureBox.HorizontalScrollBarAlignment.Bottom;
            exPictureBox1.Image = (System.Drawing.Image)resources.GetObject("exPictureBox1.Image");
            exPictureBox1.InterpulationAlgorithem = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            exPictureBox1.Location = new System.Drawing.Point(12, 14);
            exPictureBox1.Name = "exPictureBox1";
            exPictureBox1.Size = new System.Drawing.Size(968, 720);
            exPictureBox1.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Scale;
            exPictureBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            exPictureBox1.TabIndex = 0;
            exPictureBox1.VScrollAlignment = Amiga.PictureBox.VerticalScrollBarAlignment.Right;
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
