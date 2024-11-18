using Amiga;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace AmigaImageConverter
{
    public partial class LoadImageDialog : Form
    {
        Bitmap bmp, ScaledBitmap;
        public LoadImageDialog()
        {
            InitializeComponent();
            int width = DesktopBounds.Width;
            int height = DesktopBounds.Height;


        }

        public LoadImageDialog(Bitmap bitmap)
        {
            InitializeComponent();
            imageBox.Image = bitmap;
            widthNumericUpDown.Value = bitmap.Width;
            heightNumericUpDown.Value = bitmap.Height;
            bgColorPictureBox.BackColor = findBackgroundColor(bitmap);

            resizeMethodCBox.SelectedIndex = 0;

            if (bgColorPictureBox.BackColor.A == 0)
            {
                toolStripStatusLabel.Text = "Found Transprent color in Image and is used as Background";
                ImageTransparent = true;
            }
            else
            {
                toolStripStatusLabel.Text = "No Transparent color found in the Image.";
            }

            ImageNumOfColors = 16;  // The default num of color to reduce to
            float ScaleFactor;

            ScaleFactor = (float)imageBox.Height / (float)bmp.Height;


            if (bitmap.Width < ScreenWidth * 0.8)
            {
                imageBox.ScaleImage(ScaleFactor);
                imageBox.SizeMode = PictureBoxSizeMode.AutoSize;
                hScrollBar.Visible = false;
            }
            else
            {
                ScaledBitmap = ScaleImage(bitmap, ScaleFactor);
                //imageBox.Image = ScaledBitmap;

                //imageBox.SizeMode = PictureBoxSizeMode.AutoSize;
                imageBox.Width = (int)(ScreenWidth * 0.8);
                imageBox.Image = new Bitmap(imageBox.Width, imageBox.Height, Graphics.FromImage(bitmap));

                hScrollBar.Visible = true;
                hScrollBar.Maximum = ScaledBitmap.Width - imageBox.Width; //(int)((float)imageBox.Width / (float)imageBox.Image.Width * 100);

                Task.Run(() => DrawImagePart(0));


            }

            sidePael.Left = imageBox.Right + 2;
            hScrollBar.Width = imageBox.Width;
            hScrollBar.Top = imageBox.Bottom + 2;

        }

        private void DrawImagePart(int Xpos)
        {
            if (ScaledBitmap == null)
                return;

            Rectangle destRec = new Rectangle(0, 0, imageBox.Width, imageBox.Height);
            Rectangle srcRec = new Rectangle(Xpos, 0, imageBox.Width, imageBox.Height);

            Graphics graphics = Graphics.FromImage(imageBox.Image);

            //graphics.DrawImage(ScaledBitmap, destRec, Xpos, 0, destRec.Width, destRec.Height, GraphicsUnit.Pixel);
            graphics.DrawImage(ScaledBitmap, 0, 0, srcRec, GraphicsUnit.Pixel);
            graphics.Dispose();
        }

        private Bitmap ScaleImage(Bitmap bitmap, float scaleFactor)
        {
            if (bitmap != null)
            {
                Graphics sg = Graphics.FromImage(bitmap);
                Bitmap scaledImage = new Bitmap((int)(bitmap.Width * scaleFactor), (int)(bitmap.Height * scaleFactor), sg);                  //     scaledImage.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);
                //Bitmap scaledImage = new Bitmap(bitmap, (int)(bitmap.Width * scaleFactor), (int)(bitmap.Height * scaleFactor));
                Graphics g = Graphics.FromImage(scaledImage);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                g.DrawImage(bitmap, 0, 0, scaledImage.Width, scaledImage.Height);
                g.Dispose();
                //  Bitmap scaledImage = new Bitmap(bitmap, (int)(bitmap.Width * scaleFactor), (int)(bitmap.Height * scaleFactor));
                return scaledImage;
                //Refresh();

            }
            return null;
        }

        private int ScreenWidth
        {
            get { return SystemInformation.VirtualScreen.Width; }
        }

        private int ScreenHeight
        {
            get { return SystemInformation.VirtualScreen.Height; }
        }

        public int RequestedImageWidth
        {
            get { return (int)widthNumericUpDown.Value; }
        }
        public int RequestedImageHeight
        {
            get { return (int)heightNumericUpDown.Value; }
        }

        public int ImageNumOfColors
        {
            get
            {
                return (int)Math.Pow(2, colorComboBox.SelectedIndex + 1);
            }
            set
            {
                colorComboBox.SelectedIndex = (int)(Math.Log(value) / Math.Log(2) - 1);
            }
        }

        public bool ImageTransparent
        {
            get { return transparentCheckBox.Checked; }
            set { transparentCheckBox.Checked = value; }
        }

        public Color BackgroundColor
        {
            get
            {
                return bgColorPictureBox.BackColor;
            }

            set
            {
                bgColorPictureBox.BackColor = value;
            }
        }

        private Color findBackgroundColor(Bitmap bitmap)
        {
            bmp = bitmap;
            Color transColor;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    transColor = bitmap.GetPixel(x, y);
                    if (transColor.A == 0)
                        return transColor;
                }
            }
            return bitmap.GetPixel(0, 0);
        }

        private void LoadImageDialog_Load(object sender, EventArgs e)
        {

        }

        private void widthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void heightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void imageBox_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)((ImageBox)sender).Image;
            //Graphics g = imageBox.CreateGraphics();
            // ImageBox imageBox = (ImageBox)sender;
            //  Graphics g = Graphics.FromImage(imageBox.Image);
            BackgroundColor = bitmap.GetPixel(e.X, e.Y);

            string TextOut = $"R:{BackgroundColor.R:X2} G:{BackgroundColor.G:X2} B:{BackgroundColor.B:X2} A:{BackgroundColor.A:X2}";

            if (BackgroundColor.A == 0)
                TextOut += " Transparent";

            toolTip.Show(TextOut, imageBox);
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            if ((RequestedImageWidth * RequestedImageHeight / 8) > 0x2000000)
            {
                if (MessageBox.Show("The image is too big to fit into 2M chip memory, are you sure you want to continue?", "Image too big", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.OK;
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            DrawImagePart(hScrollBar.Value);
            imageBox.Invalidate();
        }

        private void resizeMethodCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedIndex > 0)
            {
                if (comboBox.SelectedIndex == 1)
                    widthNumericUpDown.Value = 320;
                else
                    widthNumericUpDown.Value = 640;

                widthNumericUpDown.Enabled = false;
                heightNumericUpDown.Enabled = false;
            }
            else
            {
                widthNumericUpDown.Enabled = true;
                heightNumericUpDown.Enabled = true;
            }
        }

        private void widthNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                float HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                heightNumericUpDown.Refresh();
            }
        }

        private void heightNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                float WidthToHeight = (float)bmp.Width / (float)bmp.Height;
                widthNumericUpDown.Value = (int)Math.Round(heightNumericUpDown.Value * (decimal)WidthToHeight);
            }
        }
    }
}
