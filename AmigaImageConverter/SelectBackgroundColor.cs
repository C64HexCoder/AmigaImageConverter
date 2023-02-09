using Amiga;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class SelectBackgroundColor : Form
    {
        PublicVariables vr = PublicVariables.instance;
        public SelectBackgroundColor()
        {
            InitializeComponent();
            pallete.Colors = vr.bitplane.Pallate;
            imageBox.Image = vr.bitplane.bitmap;
            float multiFactor = pallete.Height/imageBox.Image.Height;
            imageBox.ScaleFactor = (int) Math.Round(multiFactor);
            imageBox.ScaleImage();
            pallete.Left = imageBox.Right + 2;
            swapBt.Left = pallete.Right-swapBt.Width;
        }

        private void pallete_ColorSelected(object sender, Amiga.Pallate.SelectedColorEventArgs e)
        {
           // selectedColorPB.BackColor = e.Color;
        }

        private void swapBt_Click(object sender, EventArgs e)
        {
            // for (int i = 0; i<vr.bitplane.Pallate.Length;i++)
            //{
            //  if (vr.bitplane.Pallate[i] == pallete.SelectedColor)

            //            }
            vr.bitplane.SelectBackgroundColor(pallete.SelectedColorIdx);

        }

        private void imageBox_MouseClick(object sender, MouseEventArgs e)
        {
            ImageBox imageBox = ((ImageBox)sender);
            int x = e.X, y = e.Y;
            Bitmap bitmap = (Bitmap)imageBox.Image;
            //x /= imageBox.ScaleFactor; y /= imageBox.ScaleFactor;
            Color SelectedColor = bitmap.GetPixel(x, y);

            pallete.SelectedColor = SelectedColor; 
            pallete.SelectedColorIdx = pallete.FindColorInPallate (SelectedColor);
        }
    }
}
