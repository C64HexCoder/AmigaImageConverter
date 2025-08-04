using Amiga;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using AmigaImageConverter.Properties;
using static System.Net.Mime.MediaTypeNames;
namespace AmigaImageConverter
{
    public partial class LoadImageDialog : Form
    {
        Bitmap ScaledBitmap;
        private Bitmap _bmp;
        bool isWidthHeightUpdated = false;
        public LoadImageDialog()
        {
            InitializeComponent();
            int width = DesktopBounds.Width;
            int height = DesktopBounds.Height;
            colorComboBox.SelectedIndex = 3;
            interpulationCB.SelectedIndex = 2;


        }

        public Bitmap bmp
        {
            get { return _bmp; }
            set
            {
                imageBox.Image = _bmp = value;
                resizeMethodCBox_SelectedIndexChanged(resizeMethodCBox, new EventArgs());
            }
        }

        public SmoothingMode smoothingMode
        {

            get
            {
                switch (smoothingModeCB.SelectedIndex)
                {
                    case 0:
                        return SmoothingMode.HighQuality;
                    case 1:
                        return SmoothingMode.AntiAlias;
                    case 2:
                        return SmoothingMode.HighSpeed;
                    case 3:
                        return SmoothingMode.None;
                    default:
                        return SmoothingMode.Default;
                }
            }

        }
        public InterpolationMode interpolationMode
        {
            get
            {
                switch (interpulationCB.SelectedIndex)
                {
                    case 0:
                        return InterpolationMode.NearestNeighbor;
                    case 1:
                        return InterpolationMode.Bicubic;
                    case 2:
                        return InterpolationMode.HighQualityBicubic;
                    case 3:
                        return InterpolationMode.Bilinear;
                    case 4:
                        return InterpolationMode.HighQualityBilinear;
                    case 5:
                        return InterpolationMode.High;
                    case 6:
                        return InterpolationMode.Low;
                    default:
                        return InterpolationMode.Default;
                }
            }

        }
        public LoadImageDialog(Bitmap bitmap)
        {
            InitializeComponent();
            bmp = bitmap;

            bgColorPictureBox.BackColor = findBackgroundColor(bitmap);
            colorComboBox.SelectedIndex = 3;
            interpulationCB.SelectedIndex = 2;
            smoothingModeCB.SelectedIndex = 0;

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
                return int.Parse(colorComboBox.SelectedItem.ToString());
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
            if (RequestedImageWidth != bmp.Width || RequestedImageHeight != bmp.Height)
            {
                Bitmap NewBitmap = new Bitmap(RequestedImageWidth, RequestedImageHeight);
                Graphics g = Graphics.FromImage(NewBitmap);
                g.SmoothingMode = smoothingMode;
                g.InterpolationMode = interpolationMode;
                g.DrawImage(bmp, 0, 0, RequestedImageWidth, RequestedImageHeight);
                g.Dispose();
                bmp = NewBitmap;
            }

            if (widthNumericUpDown.Value > 640 || heightNumericUpDown.Value > 512)
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
            float HeightToWidth;


            switch (comboBox.SelectedIndex)
            {
                case 0:
                    widthNumericUpDown.Enabled = true;
                    heightNumericUpDown.Enabled = true;

                    widthNumericUpDown.Value = bmp.Width;
                    heightNumericUpDown.Value = bmp.Height;
                    break;
                case 1:
                    widthNumericUpDown.Enabled = false;
                    heightNumericUpDown.Enabled = false;

                    widthNumericUpDown.Value = 16;
                    HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                    heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                    heightNumericUpDown.Refresh();
                    break;
                case 2:
                    widthNumericUpDown.Enabled = false;
                    heightNumericUpDown.Enabled = false;

                    widthNumericUpDown.Value = 32;
                    HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                    heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                    heightNumericUpDown.Refresh();
                    break;
                case 3:
                    widthNumericUpDown.Enabled = false;
                    heightNumericUpDown.Enabled = false;

                    widthNumericUpDown.Value = 64;
                    HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                    heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                    heightNumericUpDown.Refresh();
                    break;
                case 4:
                    widthNumericUpDown.Enabled = false;
                    heightNumericUpDown.Enabled = false;

                    widthNumericUpDown.Value = 320;
                    HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                    heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                    heightNumericUpDown.Refresh();
                    break;
                case 5:
                    widthNumericUpDown.Enabled = false;
                    heightNumericUpDown.Enabled = false;

                    widthNumericUpDown.Value = 640;
                    HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                    heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                    heightNumericUpDown.Refresh();
                    break;
            }

        }

        private void widthNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (bmp != null && isWidthHeightUpdated)
            {
                float HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                heightNumericUpDown.Refresh();
                isWidthHeightUpdated = false;
            }
        }

        private void heightNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (bmp != null && isWidthHeightUpdated)
            {
                float WidthToHeight = (float)bmp.Width / (float)bmp.Height;
                widthNumericUpDown.Value = (int)Math.Round(heightNumericUpDown.Value * (decimal)WidthToHeight);
                isWidthHeightUpdated = false;
            }
        }

        private void widthNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && bmp != null)
            {

                float HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                isWidthHeightUpdated = false;
            }
            else
                isWidthHeightUpdated = true;
        }

        private void heightNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && bmp != null)
            {
                float WidthToHeight = (float)bmp.Width / (float)bmp.Height;
                widthNumericUpDown.Value = (int)Math.Round(heightNumericUpDown.Value * (decimal)WidthToHeight);
                isWidthHeightUpdated = false;
            }
            else
                isWidthHeightUpdated = true;
        }

        private void autoCropBtn_Click(object sender, EventArgs e)
        {

            Point StartPos = new Point(imageBox.Width, imageBox.Height), StopPos = new Point(0, 0);
            Color backgroundColor = bgColorPictureBox.BackColor;

            for (int y = imageBox.Height - 1; y >= 0; y--)
                for (int x = imageBox.Width - 1; x >= 0; x--)
                {
                    Color pixel = ((Bitmap)imageBox.Image).GetPixel(x, y);
                    if (pixel.R != backgroundColor.R || pixel.G != backgroundColor.G || pixel.B != backgroundColor.B)
                    //if (pixel != backgroundColor) // Dont have a clue why its not working
                    {
                        if (x < StartPos.X)
                            StartPos.X = x;

                        if (y < StartPos.Y)
                            StartPos.Y = y;

                        if (x > StopPos.X) StopPos.X = x;
                        if (y > StopPos.Y) StopPos.Y = y;
                    }
                }

            int NewWidth = StopPos.X - StartPos.X + 1, NewHeight = StopPos.Y - StartPos.Y + 1;
            Bitmap corpedImage = new Bitmap(NewWidth, NewHeight);
            Graphics g = Graphics.FromImage(corpedImage);
            Rectangle destRec = new Rectangle(0, 0, NewWidth, NewHeight);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.DrawImage(imageBox.Image, destRec, StartPos.X, StartPos.Y, NewWidth, NewHeight, GraphicsUnit.Pixel);
            g.Dispose();
            imageBox.Image = bmp = corpedImage;

        }

        private void resizeMethodCBox_Layout(object sender, LayoutEventArgs e)
        {
            if (bmp.Width > 640 || bmp.Height > 512)
                resizeMethodCBox.SelectedValue = 4;
        }
    }
}
