using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amiga;

namespace AmigaImageConverter
{
    public partial class Animation : UserControl
    {
        Resize resizeImg = new Resize();

        List<Sprite> sprites = new List<Sprite>();
        PublicVariables pv = PublicVariables.instance;
        Resize resize = new AmigaImageConverter.Resize();
        ImageBox ImageBox = null;
        public Animation(ImageBox imgBox)
        {
            InitializeComponent();
            ImageBox = imgBox;

            if (pv.bitplane.bitmap != null)
            {
                if (pv.bitplane.bitmap.Width != 16 && pv.bitplane.bitmap.Width != 32 && pv.bitplane.bitmap.Width != 64)
                {
                    resizeImg.ShowDialog();
                }

                Sprite sprite = pv.bitplane.CreateSprite();

                if (sprite != null)
                    colorsGrid.SetPalette(sprite.palette);
            }
        }

        public void AddImage()
        {
            Sprite sprite = pv.bitplane.CreateSprite();
            sprites.Add(sprite);

        }
        public void LoadImage(Bitmap bitmap)
        {

        }
        private void executeBtn_Click(object sender, EventArgs e)
        {

        }

        private void addImageButton_Click(object sender, EventArgs e)
        {

            Sprite sprite = pv.bitplane.CreateSprite();
            sprites.Add(sprite);
            imageSelectNum.Value = sprites.Count - 1;

            if (sprite.Height > maxSpriteHeightNumeric.Value)
                maxSpriteHeightNumeric.Value = sprite.Height;

        }

        private void imageSelectNum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown imageSelect = sender as NumericUpDown;

            if (sprites.Count > imageSelect.Value)
            {
                ImageBox.Image = (sprites[(int)imageSelect.Value].bitmap); 
                ImageBox.ScaleImage();
                ImageBox.Invalidate();
                colorsGrid.SetPalette(sprites[(int)imageSelect.Value].palette);
            }

        }
    }
}
