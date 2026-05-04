using System;
using System.Drawing;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class ResizeCanvas : Form
    {
        PublicVariables publicVariables = PublicVariables.instance;
        public ResizeCanvas()
        {
            InitializeComponent();
        }

        public ResizeCanvas(Bitmap bitmap)
        {
            InitializeComponent();
            Bitmap BorderedImage = new Bitmap(bitmap.Width + 8, bitmap.Height + 8);
            BorderedImage.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);

            using (Graphics g = Graphics.FromImage(BorderedImage))
            {
                g.Clear(Color.White);
                g.DrawImage(bitmap, 4, 4);
                g.DrawRectangle(Pens.Green, 0, 0, BorderedImage.Width - 4, BorderedImage.Height - 4);
                g.Dispose();
            }
            scaledImage.Image = BorderedImage;

            widthNUD.Value = bitmap.Width;
            heightNUD.Value = bitmap.Height;
            scaledImage.Invalidate();
            //exPictureBox.Update();
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            //publicVariables.bitplane.ResizeCanvas((int)widthNUD.Value, (int)heightNUD.Value);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            g.DrawRectangle(Pens.Green, 0, 0, scaledImage.Width - 1, scaledImage.Height - 1);
            //e.Graphics.DrawImage(publicVariables.bitplane.GetBitmap(), 0, 0);
        }

        private void scaledImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Green, 4);
            //g.Clear(Color.White);
            //g.DrawRectangle(pen, 0, 0, scaledImage.Image.Width - 4 , scaledImage.Image.Height - 4);
        }

        private void ratioCheckBox_Click(object sender, EventArgs e)
        {

        }

        private void widthNUD_ValueChanged(object sender, EventArgs e)
        {
            if (widthNUD.Value != 0 && heightNUD.Value != 0)
            {

                double HeightRatio = (double)publicVariables.bitplane.Height / (double)publicVariables.bitplane.Width;


                if (ratioCheckBox.Checked)
                {
                    heightNUD.Value = (int)Math.Round((double)widthNUD.Value * HeightRatio);
                }

            }
        }

        private void heightNUD_ValueChanged(object sender, EventArgs e)
        {
            double WidthRatio = (double)publicVariables.bitplane.Width / (double)publicVariables.bitplane.Height;
            if (ratioCheckBox.Checked)
            {
                widthNUD.Value = (int)Math.Round((double)heightNUD.Value * WidthRatio);
            }
        }
    }
}

