using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class ResizeCanvas : Form
    {
        PublicVariables publicVariables = new PublicVariables();
        public ResizeCanvas()
        {
            InitializeComponent();
        }

        public ResizeCanvas(Bitmap bitmap)
        {
            InitializeComponent();
            scaledImage.Image = bitmap;
            widthNUD.Value = bitmap.Width;
            heightNUD.Value = bitmap.Height;
            //exPictureBox.Update();
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            //publicVariables.bitplane.ResizeCanvas((int)widthNUD.Value, (int)heightNUD.Value);
        }
    }
}
