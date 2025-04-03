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
    public partial class Animation : UserControl
    {
        Resize resizeImg = new Resize();

        List<Sprite> sprites = new List<Sprite>();
        PublicVariables pv = PublicVariables.instance;
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

                if (sprite != null ) 
                    colorsGrid.SetPalette(sprite.palette);   
            }
        }
    }
}
