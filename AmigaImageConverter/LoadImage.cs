using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amiga;

namespace AmigaImageConverter
{
    public partial class LoadImageDialog : Form
    {
        Bitmap bmp;
        public LoadImageDialog()
        {
            InitializeComponent();
        }

        public LoadImageDialog (Bitmap bitmap)
        {          
            InitializeComponent();
            imageBox.Image = bitmap;
            widthNumericUpDown.Value = bitmap.Width;
            heightNumericUpDown.Value = bitmap.Height;
            bgColorPictureBox.BackColor = findBackgroundColor(bitmap);
            if (bgColorPictureBox.BackColor.A == 0)
            {
                toolStripStatusLabel.Text = "Found Transprent color in Image and is used as Background";
                ImageTransparent = true;
            }
            
            ImageNumOfColors = 16;
            float ScaleFactor;
    
            ScaleFactor = (float)imageBox.Height / (float)bmp.Height;

            imageBox.ScaleImage(ScaleFactor);
            imageBox.SizeMode = PictureBoxSizeMode.AutoSize;

            sidePael.Left = imageBox.Right + 2;

        }

        public int ImageWidth
        {
            get { return (int)widthNumericUpDown.Value; }
        }
        public int ImageHeight
        {
            get { return (int)heightNumericUpDown.Value;}
        }

        public int ImageNumOfColors
        {
            get
            {
                return (int)Math.Pow(2, colorComboBox.SelectedIndex+1);
            }
            set
            {
                colorComboBox.SelectedIndex = (int)(Math.Log(value) / Math.Log(2)-1);
            }
        }

        public bool ImageTransparent
        {
            get { return transparentCheckBox.Checked; }
            set { transparentCheckBox.Checked = value;}
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

        private Color findBackgroundColor (Bitmap bitmap)
        {
            bmp= bitmap;
            Color transColor;
            for (int y=0; y<bitmap.Height; y++)
            {
                for (int x=0; x<bitmap.Width; x++)
                {
                    transColor= bitmap.GetPixel(x, y);
                    if (transColor.A == 0)
                        return transColor;
                }
            }
            return bitmap.GetPixel (0,0);
        }

        private void LoadImageDialog_Load(object sender, EventArgs e)
        {

        }

        private void widthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                float HeightToWidth = (float)bmp.Height / (float)bmp.Width;
                heightNumericUpDown.Value = (int)Math.Round(widthNumericUpDown.Value * (decimal)HeightToWidth);
                heightNumericUpDown.Refresh();
            }
        }

        private void heightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                float WidthToHeight = (float)bmp.Width / (float)bmp.Height;
                widthNumericUpDown.Value = (int)Math.Round(heightNumericUpDown.Value * (decimal)WidthToHeight);
            }
        }

        private void imageBox_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)((ImageBox)sender).Image;
            //Graphics g = imageBox.CreateGraphics();
            // ImageBox imageBox = (ImageBox)sender;
            //  Graphics g = Graphics.FromImage(imageBox.Image);
            BackgroundColor = bitmap.GetPixel(e.X,e.Y);

            string TextOut = $"R:{BackgroundColor.R:X2} G:{BackgroundColor.G:X2} B:{BackgroundColor.B:X2} A:{BackgroundColor.A:X2}";
            
            if (BackgroundColor.A == 0)
                TextOut += " Transparent";

            toolTip.Show(TextOut , imageBox);
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            if (ImageWidth >= 640 || ImageWidth > 480)
            {
                MessageBox.Show("The image is too big to fit the amigaa. Please chane the size of the image and try again.");
            }
            else
                DialogResult = DialogResult.OK;
        }
    }
}
