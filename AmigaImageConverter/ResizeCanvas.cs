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
            colorBox.SetBorder = true;
            alignCombobox.SelectedIndex = 0;

        }

        public ResizeCanvas(Bitmap bitmap)
        {
            InitializeComponent();
            alignCombobox.SelectedIndex = 0;

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
           
            double HeightRatio = (double)publicVariables.bitplane.Height / (double)publicVariables.bitplane.Width;


            if (ratioCheckBox.Checked)
            {
                heightNUD.Value = (int)Math.Round((double)widthNUD.Value * HeightRatio);
            }

            Bitmap BorderedImage = new Bitmap((int)widthNUD.Value + 8, (int)heightNUD.Value + 8);
            BorderedImage.SetResolution(publicVariables.bitplane.bitmap.HorizontalResolution, publicVariables.bitplane.bitmap.VerticalResolution);
            using (Graphics g = Graphics.FromImage(BorderedImage))
            {
                g.Clear(Color.White);
                g.DrawImage(publicVariables.bitplane.bitmap, 4, 4, publicVariables.bitplane.Width, publicVariables.bitplane.Height);
                g.DrawRectangle(Pens.Green, 0, 0, BorderedImage.Width - 4, BorderedImage.Height - 4);
                g.Dispose();

                scaledImage.Image = BorderedImage;
                scaledImage.Invalidate();
            }
          
        }

        private void heightNUD_ValueChanged(object sender, EventArgs e)
        {
            double WidthRatio = (double)publicVariables.bitplane.Width / (double)publicVariables.bitplane.Height;
            if (ratioCheckBox.Checked)
            {
                widthNUD.Value = (int)Math.Round((double)heightNUD.Value * WidthRatio);
            }


            Bitmap BorderedImage = new Bitmap((int)widthNUD.Value + 8, (int)heightNUD.Value + 8);
            BorderedImage.SetResolution(publicVariables.bitplane.bitmap.HorizontalResolution, publicVariables.bitplane.bitmap.VerticalResolution);
            using (Graphics g = Graphics.FromImage(BorderedImage))
            {
                g.Clear(Color.White);
                g.DrawImage(publicVariables.bitplane.bitmap, 4, 4, publicVariables.bitplane.Width, publicVariables.bitplane.Height);
                g.DrawRectangle(Pens.Green, 0, 0, BorderedImage.Width - 4, BorderedImage.Height - 4);
                g.Dispose();

                scaledImage.Image = BorderedImage;
                scaledImage.Invalidate();
            }
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            PaletteDlg palDlg = new PaletteDlg();
            palDlg.imagePallate.SetPalette(publicVariables.bitplane.Palette);
            if (palDlg.ShowDialog() == DialogResult.OK)
            {
                colorBox.color = palDlg.SelectedColor;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scaledImage_Click(object sender, EventArgs e)
        {


        }

        private void scaledImage_MouseClick(object sender, MouseEventArgs e)
        {
            Point position = e.Location;

            Bitmap bitmap = (Bitmap)scaledImage.Image;

            float ImageAspectRatio = (float)publicVariables.bitplane.Width / (float)publicVariables.bitplane.Height;
            float PictureBoxAspectRatio = (float)scaledImage.Width / (float)scaledImage.Height;

            // Check if the click is within the actual image area (considering aspect ratio)
            if (ImageAspectRatio > PictureBoxAspectRatio)
            {
                double scaleFactor = (double)scaledImage.Width / (double)publicVariables.bitplane.Width;
                int scaledImageHeight = (int)(publicVariables.bitplane.Height * scaleFactor);
                int verticalOffset = (scaledImage.Height - scaledImageHeight) / 2;
                int adjustedY = position.Y - verticalOffset;
                if (adjustedY < 0 || adjustedY >= scaledImageHeight)
                {
                    // Click is outside the image area
                    return;
                }
                int originalX = (int)(position.X / scaleFactor);
                int originalY = (int)(adjustedY / scaleFactor);
                if (originalX >= 0 && originalX < publicVariables.bitplane.Width && originalY >= 0 && originalY < publicVariables.bitplane.Height)
                {
                    // Click is within the image area, you can use originalX and originalY
                    colorBox.color = publicVariables.bitplane.bitmap.GetPixel(originalX, originalY);
                }
            }
            else
            {
                double scaleFactor = (double)scaledImage.Height / (double)publicVariables.bitplane.Height;
                int scaledImageWidth = (int)(publicVariables.bitplane.Width * scaleFactor);
                int horizontalOffset = (scaledImage.Width - scaledImageWidth) / 2;
                int adjustedX = position.X - horizontalOffset;
                if (adjustedX < 0 || adjustedX >= scaledImageWidth)
                {
                    // Click is outside the image area
                    return;
                }
                int originalX = (int)(adjustedX / scaleFactor);
                int originalY = (int)(position.Y / scaleFactor);
                if (originalX >= 0 && originalX < publicVariables.bitplane.Width && originalY >= 0 && originalY < publicVariables.bitplane.Height)
                {
                    // Click is within the image area, you can use originalX and originalY
                    colorBox.color = publicVariables.bitplane.bitmap.GetPixel(originalX, originalY);
                }
            }
        }

        private void alignCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox alignComboBox = (ComboBox)sender;

            switch (alignComboBox.SelectedIndex)
            {
                // fix the width alignment to 16 pixels
                case 0:
                    widthNUD.Value = publicVariables.bitplane.Width % 16 == 0 ? publicVariables.bitplane.Width : publicVariables.bitplane.Width + (16 - (publicVariables.bitplane.Width % 16)); break;
                case 1:
                    widthNUD.Value = publicVariables.bitplane.Width % 32 == 0 ? publicVariables.bitplane.Width : publicVariables.bitplane.Width + (32 - (publicVariables.bitplane.Width % 32)); break;
                case 2:
                    widthNUD.Value = publicVariables.bitplane.Width % 64 == 0 ? publicVariables.bitplane.Width : publicVariables.bitplane.Width + (64 - (publicVariables.bitplane.Width % 64)); break;
            }
        }
    }
}

