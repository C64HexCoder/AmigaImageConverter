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
        public Animation()
        {
            InitializeComponent();

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

        public void AddImage ()
        {
            Sprite sprite = pv.bitplane.CreateSprite();
            sprites.Add(sprite);

        }
        public void LoadImage (Bitmap bitmap)
        {
            
        }
        private void executeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
