using System;
using System.Drawing;
using System.Reflection;
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

        public Bitmap bitmap
        {
            get {  return scaledImage.Image as Bitmap; }
        }

        public ResizeCanvas(Bitmap bitmap)
        {
            InitializeComponent();
            alignCombobox.SelectedIndex = 0;

            Bitmap BorderedImage = new Bitmap(bitmap.Width + 16, bitmap.Height + 16);
            BorderedImage.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);
            Pen p = new Pen(Color.Green, 8);
            using (Graphics g = Graphics.FromImage(BorderedImage))
            {
                g.Clear(Color.White);
                g.DrawImage(bitmap, 8, 8);
                g.DrawRectangle(p, 0, 0, BorderedImage.Width, BorderedImage.Height);
                g.Dispose();
            }
            scaledImage.Image = BorderedImage;


            widthNUD.Value = bitmap.Width;
            heightNUD.Value = bitmap.Height;
            scaledImage.Invalidate();
            //exPictureBox.Update();
        }

        public int Width
        {
            get { return (int)widthNUD.Value; }
            set { widthNUD.Value = value; }
        }

        public int Height
        {
            get { return (int)heightNUD.Value; }
            set { heightNUD.Value = value; }
        }

        public void UpdatePreview(int width, int height)
        {
            if (scaledImage.Image == null)
                return;

            Bitmap BorderedImage = new Bitmap(width + 16, height + 16);
            BorderedImage.SetResolution(scaledImage.Image.HorizontalResolution, scaledImage.Image.VerticalResolution);
            Pen p = new Pen(Color.Green, 8);

            Point dest = new Point(8, 8);
            if (centerCheckbox.Checked)
            {
                dest = new Point((BorderedImage.Width - publicVariables.bitplane.bitmap.Width) / 2, (BorderedImage.Height - publicVariables.bitplane.bitmap.Height) / 2);
            }
            using (Graphics g = Graphics.FromImage(BorderedImage))
            {
                g.Clear(Color.White);
                g.DrawImage(publicVariables.bitplane.bitmap, dest.X, dest.Y);
                g.DrawRectangle(p, 0, 0, BorderedImage.Width, BorderedImage.Height);
                g.Dispose();
            }
            scaledImage.Image = BorderedImage;


            widthNUD.Value = width;
            heightNUD.Value = height;
            scaledImage.Invalidate();
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            publicVariables.bitplane.ResizeCanvas((int)widthNUD.Value, (int)heightNUD.Value,centerCheckbox.Checked);
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            PictureBox pb = (PictureBox)sender;

            Point mousexy = MousePosition;
            mousexy = pb.PointToClient(mousexy);
            if (mousexy.X >= 0 && mousexy.X < pb.Width && mousexy.Y >= 0 && mousexy.Y < pb.Height)
            {
                // get the color of the pixel under the mouse cursor
                Color pixelColor = Color.Empty;
                pixelColor = pb.BackColor;
                if (pb.Image != null)
                {
                    Bitmap bitmap = (Bitmap)pb.Image;
                    if (mousexy.X >= 0 && mousexy.X < bitmap.Width && mousexy.Y >= 0 && mousexy.Y < bitmap.Height)
                    {
                        pixelColor = bitmap.GetPixel(mousexy.X, mousexy.Y);
                        alignCombobox.BackColor = pixelColor;
                    }
                }
                // set the cursor color to the pixel color
                Cursor.Current = Cursors.Default;
                // You can also set the cursor color to the pixel color if you want
                // For example, you can create a custom cursor with the pixel color and set it as the current cursor
                // However, this is not implemented in this code snippet
                // You can use pixelColor for any purpose, such as displaying it in a label or using it for drawing

                // Mouse is within the bounds of the PictureBox
                // You can perform actions here, such as highlighting the area or showing coordinates
            }
            if (pb.Image != null)
            {
                //     Pen p = new Pen(Color.Green, 4);
                ///     Rectangle dest = new Rectangle(0, 0, pb.Image.Width + 8, pb.Image.Height + 8);
                //    gfx.DrawRectangle(p, dest);
                //Rectangle imgDest = new Rectangle(4, 4, pb.Image.Width, pb.Image.Height);
                //gfx.DrawImage(pb.Image, imgDest);

            }

            base.OnPaint(e);
        }


        private void widthNUD_ValueChanged(object sender, EventArgs e)
        {

            double HeightRatio = (double)publicVariables.bitplane.Height / (double)publicVariables.bitplane.Width;

            if (ratioCheckBox.Checked)
            {
                if (Width <= publicVariables.bitplane.Width)
                    centerCheckbox.Enabled = false;
                else
                    centerCheckbox.Enabled = true;

                heightNUD.Value = (int)Math.Round((double)widthNUD.Value * HeightRatio);
            }

            ((NumericUpDown)sender).Tag = 1;
            UpdatePreview((int)widthNUD.Value, (int)heightNUD.Value);

            //  if (widthNUD.Tag == "1" && heightNUD.Tag == "1")
            //  {
            widthNUD.Tag = "0";
            heightNUD.Tag = "0";
            //  scaledImage.Invalidate();
            //   Invalidate();
            //  }
        }

        private void heightNUD_ValueChanged(object sender, EventArgs e)
        {
            double WidthRatio = (double)publicVariables.bitplane.Width / (double)publicVariables.bitplane.Height;
            if (ratioCheckBox.Checked)
            {

                if (Width <= publicVariables.bitplane.Width)
                    centerCheckbox.Enabled = false;
                else
                    centerCheckbox.Enabled = true;

                widthNUD.Value = (int)Math.Round((double)heightNUD.Value * WidthRatio);
            }
            ((NumericUpDown)sender).Tag = 1;
            UpdatePreview((int)widthNUD.Value, (int)heightNUD.Value);
            // if (widthNUD.Tag == "1" && heightNUD.Tag == "1")
            //{
            widthNUD.Tag = "0";
            heightNUD.Tag = "0";
            //    scaledImage.Invalidate();
            //}    
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
                    Width = Width % 16 == 0 ? Width : Width + (16 - (Width % 16)); break;
                case 1:
                    Width = Width % 32 == 0 ? Width : Width + (32 - (Width % 32)); break;
                case 2:
                    Width = Width % 64 == 0 ? Width : Width + (64 - (Width % 64)); break;
            }
        }


        public void DrawThePicture()
        {
            Bitmap BorderedImage = new Bitmap((int)widthNUD.Value + 8, (int)heightNUD.Value + 8);

            BorderedImage.SetResolution(publicVariables.bitplane.bitmap.HorizontalResolution, publicVariables.bitplane.bitmap.VerticalResolution);

            using (Graphics g = Graphics.FromImage(BorderedImage))
            {
                g.Clear(colorBox.BackColor);
                g.DrawImage(publicVariables.bitplane.bitmap, 4, 4, publicVariables.bitplane.Width, publicVariables.bitplane.Height);
                g.DrawRectangle(Pens.Green, 0, 0, BorderedImage.Width - 4, BorderedImage.Height - 4);

                scaledImage.Image = BorderedImage;
                //scaledImage.Invalidate();
            }
        }

        private void centerCheckbox_Click(object sender, EventArgs e)
        {
            CheckBox centerCheckbox = sender as CheckBox;

        }

        private void centerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePreview((int)widthNUD.Value, (int)heightNUD.Value);
        }
    }
}

